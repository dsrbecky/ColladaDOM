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
	public class ExplicitXmlNamesExtension : Extension
	{
		protected override void ProcessProperty(CodeTypeDeclaration type, CodeMemberField field, CodeMemberProperty property)
		{
			foreach(CodeAttributeDeclaration attrib in property.CustomAttributes) {
				if (attrib.AttributeType.BaseType == "System.Xml.Serialization.XmlElementAttribute" ||
				    attrib.AttributeType.BaseType == "System.Xml.Serialization.XmlAttributeAttribute")
				{
					if (attrib.Arguments.Count == 0 ||
					    attrib.Arguments[0].Name.Length > 0 ||
					    attrib.Arguments[0].Value is CodeTypeOfExpression)
					{
						attrib.Arguments.Insert(0, new CodeAttributeArgument(new CodePrimitiveExpression(property.Name)));
					}
				}
			}
			
			if (property.CustomAttributes.Count == 0) {
				property.CustomAttributes.Add(
					new CodeAttributeDeclaration(
						"System.Xml.Serialization.XmlElementAttribute",
						new CodeAttributeArgument(
							new CodePrimitiveExpression(property.Name))));
			}
		}
	}
}
