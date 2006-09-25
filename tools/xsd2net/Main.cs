// <file>
//     <copyright name="David Srbeck�" email="dsrbecky@gmail.com"/>
//     <license name="GPL"/>
// </file>

using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Data;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace xsd2net
{
	public class Generator
	{
		public static void Main(string[] args)
		{
			string schemaFilename  = @"..\doc\COLLADASchema_141.xsd";
			string targetFilename  = @"..\src\collada\autogenerated\Collada.cs";
			string targetNamespace = @"Collada";
			
			// Generate CodeDOM classes
			CodeNamespace code;
			using(FileStream schemaStream = new FileStream(schemaFilename, FileMode.Open)) {
				code = GenerateCode(schemaStream, targetNamespace);
			}
			
			// Write classes to file
			CodeDomProvider provider = new Microsoft.CSharp.CSharpCodeProvider();
			using(StreamWriter writer = new StreamWriter(targetFilename, false)) {
				provider.GenerateCodeFromNamespace(code, writer, new CodeGeneratorOptions());
			}
		}
		
		public static CodeNamespace GenerateCode(Stream schemaStream, string classesNamespace)
		{
			// Open schema
			XmlSchema schema = XmlSchema.Read(schemaStream, null);
			XmlSchemas schemas = new XmlSchemas();
			schemas.Add(schema);
			schemas.Compile(null, true);
			
			// Generate code
			CodeNamespace code = new CodeNamespace(classesNamespace);
			XmlSchemaImporter importer = new XmlSchemaImporter(schemas);
			XmlCodeExporter exporter = new XmlCodeExporter(code);
			foreach (XmlSchemaElement element in schema.Elements.Values) {
				XmlTypeMapping mapping = importer.ImportTypeMapping(element.QualifiedName);
				exporter.ExportTypeMapping(mapping);
			}
			
			// Modify generated code using extensions
			schemaStream.Position = 0; // Rewind stream to the start
			XPathDocument xPathDoc = new XPathDocument(schemaStream);
			CodeGenerationContext context = new CodeGenerationContext(code, schema, xPathDoc);
			
			new ExplicitXmlNamesExtension().ApplyTo(context);
			new DocumentationExtension().ApplyTo(context);
			new FixXmlTextAttributeExtension().ApplyTo(context);
			new ArraysToGenericExtension().ApplyTo(context);
			new CamelCaseExtension().ApplyTo(context);
			new GetByIDExtension().ApplyTo(context);
			
			return code;
		}
	}
}
