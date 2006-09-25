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
		protected override void ProcessProperty(CodeTypeDeclaration type, CodeMemberField field, CodeMemberProperty property)
		{
			if (property.Type.ArrayElementType == null) return;
			
			foreach(CodeAttributeDeclaration attrib in property.CustomAttributes) {
				if (attrib.AttributeType.BaseType == "System.Xml.Serialization.XmlTextAttribute") {
					field.Type = new CodeTypeReference(typeof(string));
					property.Type = new CodeTypeReference(typeof(string));
				}
			}
		}
	}
}
