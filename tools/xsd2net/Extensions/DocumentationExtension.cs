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
	public class DocumentationExtension : Extension
	{
		string XPathExpression = "//xs:element/xs:annotation/xs:documentation|//xs:attribute/xs:annotation/xs:documentation";
		
		class Documentation
		{
			public string FullName = String.Empty;
			public string Text = String.Empty;
			public bool Used = false;
			
			public override string ToString()
			{
				int chars = Math.Min(48, Text.Length);
				return FullName + ":   " + Text.Substring(0, chars);
			}
		}
		
		string FirstUpper(string str)
		{
			if (str == null || str.Length == 0) {
				return str;
			} else {
				return str[0].ToString().ToUpper() + str.Remove(0, 1);
			}
		}
		
		protected override void Begin()
		{
			Dictionary<string, Documentation> docs = new Dictionary<string, Documentation>();
			
			XPathNavigator nav = this.XPathDocument.CreateNavigator();
			
			XmlNamespaceManager nsmgr = new XmlNamespaceManager(nav.NameTable);
			nsmgr.AddNamespace("xs", XmlSchema.Namespace);
			
			foreach(XPathNavigator node in nav.Select(XPathExpression, nsmgr)) {
				Documentation doc = new Documentation();
				string[] lines = node.Value.Split(new char[]{'\r', '\n'}, StringSplitOptions.RemoveEmptyEntries);
				for(int i = 0; i < lines.Length; i++) {
					lines[i] = lines[i].TrimStart(' ','\t');
				}
				doc.Text = String.Join("\r\n", lines);
				
				while(node.MoveToParent()) {
					if (node.LocalName == "attribute" ||
					    node.LocalName == "complexType" ||
					    node.LocalName == "element")
					{
						string name = node.GetAttribute("name", String.Empty);
						if (name == String.Empty) {
							name = node.GetAttribute("ref", String.Empty);
						}
						
						doc.FullName = name + FirstUpper(doc.FullName);
					}
				}
				docs[doc.FullName] = doc;
			}
			
			foreach (CodeTypeDeclaration type in this.Code.Types) {
				Comment(docs, type.Name, type.Comments);
				foreach(CodeTypeMember member in type.Members) {
					Comment(docs, type.Name + FirstUpper(member.Name), member.Comments);
				}
			}
			
//			System.Diagnostics.Debug.WriteLine("Unused comments:");
//			foreach(KeyValuePair<string, Documentation> kvp in docs) {
//				if (!kvp.Value.Used) {
//					System.Diagnostics.Debug.WriteLine(kvp.Value.ToString());
//				}
//			}
		}
		
		void Comment(Dictionary<string, Documentation> docs, string name, CodeCommentStatementCollection comments)
		{
			if (comments.Count > 0 && comments[0].Comment.Text == "<remarks/>") {
				comments.RemoveAt(0);
			}
			if (docs.ContainsKey(name)) {
				comments.Insert(0, new CodeCommentStatement("<summary>" + docs[name].Text + "</summary>", true));
				docs[name].Used = true;
			}
		}
		
		protected override void End()
		{
			
		}
	}
}
