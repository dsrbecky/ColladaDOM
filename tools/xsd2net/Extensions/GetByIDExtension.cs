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
	public class GetByIDExtension : Extension
	{
		static string staticFiled  = @"        public static System.Collections.Generic.Dictionary<string, TValue> IDs = new System.Collections.Generic.Dictionary<string, TValue>();";
		static string setStatement = @"                IDs[value] = this;";
		
		protected override void ProcessProperty(CodeTypeDeclaration type, CodeMemberField field, CodeMemberProperty property)
		{
			foreach(CodeAttributeDeclaration attrib in property.CustomAttributes) {
				if (attrib.AttributeType.BaseType == "System.Xml.Serialization.XmlAttributeAttribute" &&
				    attrib.Arguments.Count >= 2 &&
				    attrib.Arguments[0].Value is CodePrimitiveExpression &&
				    (attrib.Arguments[0].Value as CodePrimitiveExpression).Value.ToString() == "id")
				{
					type.Members.Insert(0, new CodeSnippetTypeMember(staticFiled.Replace("TValue", type.Name)));
					
					property.SetStatements.Add(new CodeSnippetStatement(setStatement));
				}
			}
		}
	}
}
