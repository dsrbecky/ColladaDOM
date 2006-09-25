// <file>
//     <copyright name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <license name="GPL"/>
// </file>

using System;
using System.CodeDom;
using System.Xml.Schema;
using System.Xml.XPath;

namespace xsd2net
{
	public class CodeGenerationContext
	{
		CodeNamespace code;
		XmlSchema schema;
		XPathDocument xPathDocument;
		
		public CodeNamespace Code {
			get {
				return code;
			}
		}
		
		public XmlSchema Schema {
			get {
				return schema;
			}
		}
		
		public XPathDocument XPathDocument {
			get {
				return xPathDocument;
			}
		}
		
		public CodeGenerationContext(CodeNamespace code, XmlSchema schema, XPathDocument xPathDocument)
		{
			this.code = code;
			this.schema = schema;
			this.xPathDocument = xPathDocument;
		}
	}
}
