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
	public class CamelCaseExtension : ExplicitXmlNamesExtension
	{
		string ToCamelCase(string input)
		{
			if (input == null || input.Length == 0) {
				return input;
			} else {
				string[] words = input.Split(new char[]{'_'}, StringSplitOptions.RemoveEmptyEntries);
				for(int i = 0; i < words.Length; i++) {
					words[i] = words[i][0].ToString().ToUpper() + words[i].Remove(0, 1);
				}
				return String.Join("", words);
			}
		}
		
		protected override void ProcessProperty(CodeTypeDeclaration type, CodeMemberField field, CodeMemberProperty property)
		{
			base.ProcessProperty(type, field, property);
			
			foreach(CodeAttributeDeclaration attrib in property.CustomAttributes) {
				if (attrib.AttributeType.BaseType == "System.Xml.Serialization.XmlElementAttribute" ||
				    attrib.AttributeType.BaseType == "System.Xml.Serialization.XmlAttributeAttribute")
				{
					property.Name = ToCamelCase(property.Name);
					break;
				}
			}
		}
		
		protected override void End()
		{
			base.End();
			
			Dictionary<string, string> renames = new Dictionary<string, string>();
			
			foreach (CodeTypeDeclaration type in Code.Types) {
				if (type.IsClass || type.IsStruct) {
					string newName = ToCamelCase(type.Name);
					renames[type.Name] = newName;
					type.Name = newName;
				}
			}
			
			new TypeRenamer(renames).Rename(this.Code);
		}
		
		public class TypeRenamer
		{
			Dictionary<string, string> renames;
			
			public TypeRenamer(Dictionary<string, string> renames)
			{
				this.renames = renames;
			}
			
			public void Rename(CodeNamespace @namespace)
			{
				foreach (CodeTypeDeclaration type in @namespace.Types) {
					Rename(type.CustomAttributes);
					foreach(CodeTypeReference baseType in type.BaseTypes) {
						Rename(baseType);
					}
					foreach(CodeTypeMember member in type.Members) {
						Rename(member.CustomAttributes);
						if (member is CodeMemberField) {
							Rename(((CodeMemberField)member).Type);
						}
						if (member is CodeMemberProperty) {
							Rename(((CodeMemberProperty)member).Type);
						}
					}
				}
			}
			
			void Rename(CodeAttributeDeclarationCollection attributes)
			{
				foreach(CodeAttributeDeclaration attrib in attributes) {
					foreach(CodeAttributeArgument arg in attrib.Arguments) {
						CodeTypeOfExpression typeExpr = arg.Value as CodeTypeOfExpression;
						if (typeExpr != null) {
							Rename(typeExpr.Type);
						}
					}
				}
			}
			
			void Rename(CodeTypeReference type)
			{
				if (renames.ContainsKey(type.BaseType)) {
					type.BaseType = renames[type.BaseType];
				}
				if (type.ArrayElementType != null) {
					Rename(type.ArrayElementType);
				}
				foreach(CodeTypeReference typeArg in type.TypeArguments) {
					Rename(typeArg);
				}
			}
		}
	}
}
