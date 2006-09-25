// <file>
//     <copyright name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <license name="GPL"/>
// </file>

using System;
using System.Collections;
using System.Collections.Generic;
using System.CodeDom;
using System.Xml.Schema;
using System.Xml.XPath;

namespace xsd2net
{
	public abstract class Extension
	{
		CodeGenerationContext context;
		
		protected CodeGenerationContext Context {
			get {
				return context;
			}
		}
			
		protected CodeNamespace Code {
			get {
				return context.Code;
			}
		}
		
		protected System.Xml.Schema.XmlSchema Schema {
			get {
				return context.Schema;
			}
		}
		
		protected XPathDocument XPathDocument {
			get {
				return context.XPathDocument;
			}
		}
		
		public Extension()
		{
			
		}
		
		protected virtual void Begin()
		{
			
		}
		
		protected virtual void ProcessProperty(CodeTypeDeclaration type, CodeMemberField field, CodeMemberProperty property)
		{
			
		}
		
		protected virtual void End()
		{
			
		}
		
		
		public virtual void ApplyTo(CodeGenerationContext context)
		{
			this.context = context;
			
			Begin();
			
			ArrayList originalTypes = new ArrayList(this.Code.Types);
			
			foreach (CodeTypeDeclaration type in originalTypes) {
				if (type.IsClass || type.IsStruct) {
					ArrayList originalMembers = new ArrayList(type.Members);
					foreach (CodeTypeMember member in originalMembers) {
						CodeMemberProperty property = member as CodeMemberProperty;
						if (property == null) continue;
						
						CodeMemberField field = GetFieldForProperty(type, property);
						ProcessProperty(type, field, property);
					}
				}
			}
			
			End();
		}
		
		/// <summary>
		/// Finds the field which is used as a return value for the property
		/// </summary>
		protected virtual CodeMemberField GetFieldForProperty(CodeTypeDeclaration type, CodeMemberProperty property) {
			foreach (CodeStatement statement in property.GetStatements) {
				CodeMethodReturnStatement returnStatement = statement as CodeMethodReturnStatement;
				if (returnStatement == null) continue;
				
				CodeFieldReferenceExpression fieldRef = returnStatement.Expression as CodeFieldReferenceExpression;
				if (fieldRef == null) continue;
				
				foreach (CodeTypeMember member in type.Members) {
					if (member is CodeMemberField && member.Name == fieldRef.FieldName) {
						return (CodeMemberField)member;
					}
				}
			}
			return null;
		}
	}
}
