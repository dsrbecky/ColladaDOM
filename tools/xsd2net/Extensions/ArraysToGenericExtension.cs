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
	public class ArraysToGenericExtension : Extension
	{
		protected override void ProcessProperty(CodeTypeDeclaration type, CodeMemberField field, CodeMemberProperty property)
		{
			if (property.Type.ArrayElementType == null) return; // Is array?
			
			if (property.Name == "Items" || property.Name == "ItemsElementName") return;
			
			CodeTypeReference genericType = new CodeTypeReference("System.Collections.Generic.List", new CodeTypeReference(property.Type.BaseType));
			
			property.Type = genericType;
			if (field != null) {
				field.Type = genericType;
				
				property.GetStatements.Insert(0,
					// if
					new CodeConditionStatement(
						// field == null
						new CodeBinaryOperatorExpression(
							new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), field.Name),
							CodeBinaryOperatorType.IdentityEquality,
							new CodePrimitiveExpression(null)),
						// field = new List<T>();
						new CodeAssignStatement(
							new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), field.Name),
							new CodeObjectCreateExpression(genericType))));	
			}
		}
	}
}
