// <file>
//     <copyright name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <license name="GPL"/>
// </file>

using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.XPath;

namespace xsd2net
{
	public class FixXmlTextAttributeExtension : Extension
	{
		string codeStart = 
			@"        TValue[] cacheOfNAME;" + "\r\n" +
			@"        " + "\r\n" +
			@"        [System.Xml.Serialization.XmlIgnore]" + "\r\n" +
			@"        public TValue[] NAME {" + "\r\n" +
			@"            get {" + "\r\n" +
			@"                if (cacheOfNAME != null) return cacheOfNAME;" + "\r\n" +
			@"                " + "\r\n";
		
		string genericBody = 
			@"                string[] txts = this.Text.Split(new char[]{' '}, System.StringSplitOptions.RemoveEmptyEntries);" + "\r\n" +
			@"                TValue[] values = new TValue[txts.Length];" + "\r\n" +
			@"                for(int i = 0; i < txts.Length; i++) {" + "\r\n" +
			@"                    values[i] = TValue.Parse(txts[i]CULTURE);" + "\r\n" +
			@"                }" + "\r\n" +
			@"                cacheOfNAME = values;" + "\r\n" +
			@"                return cacheOfNAME;" + "\r\n";
			
		string stringBody = 
			@"                cacheOfNAME = this.Text.Split(new char[]{' '}, System.StringSplitOptions.RemoveEmptyEntries);" + "\r\n" +
			@"                return cacheOfNAME;" + "\r\n";
			
		string codeEnd = 
			@"            }" + "\r\n" +
			@"        }";
		
		protected override void ProcessProperty(CodeTypeDeclaration type, CodeMemberField field, CodeMemberProperty property)
		{
			if (property.Type.ArrayElementType == null) return;
			
			foreach(CodeAttributeDeclaration attrib in property.CustomAttributes) {
				if (attrib.AttributeType.BaseType == "System.Xml.Serialization.XmlTextAttribute") {
					string elementType = property.Type.ArrayElementType.BaseType;
					type.Members.Add(new CodeSnippetTypeMember(MakeMemberCode(elementType, "Values")));
					if (elementType == "System.Double") {
						type.Members.Add(new CodeSnippetTypeMember(MakeMemberCode("System.Single", "ValuesAsFloats")));
					}
					                 
					field.Type = new CodeTypeReference(typeof(string));
					property.Type = new CodeTypeReference(typeof(string));
				}
			}
		}
		
		string MakeMemberCode(string elementType, string functionName)
		{
			string code = codeStart;
			if (elementType == "System.String") {
				code += stringBody;
			} else {
				code += genericBody;
			}
			code += codeEnd;
			code = code.Replace("TValue", elementType);
			code = code.Replace("NAME", functionName);
			if (elementType == "System.Boolean" | elementType == "System.String") {
				code = code.Replace("CULTURE", "");
			} else {
				code = code.Replace("CULTURE", ", System.Globalization.CultureInfo.InvariantCulture");
			}
			return code;
		}
	
	}
}
