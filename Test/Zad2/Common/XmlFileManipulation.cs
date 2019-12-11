using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;
using Zad2.Models;

namespace Zad2.Common
{
    public static class XmlFileManipulation
    {

        public static TestSchemaModel GetXmlDeserializedData(string fileName)
        {
            TestSchemaModel schemaModel = default;

            var doc = ValidateXDocument(fileName);

            schemaModel = DeserializeFromXml<TestSchemaModel>(doc.ToString());

            return schemaModel;
        }

        private static XDocument ValidateXDocument(string fileName)
        {
            XDocument doc = default;
            try
            {
                var path = new Uri(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase) ?? throw new InvalidOperationException())
                    .LocalPath;

                var concatenatedStringPath = string.Concat(path, "\\TestSchema.xsd");

                XmlSchemaSet schema = new XmlSchemaSet();
                schema.Add("http://tempuri.org/TestSchema.xsd", concatenatedStringPath);

                XmlReader rd = XmlReader.Create($"{path}\\{fileName}");
                doc = System.Xml.Linq.XDocument.Load(rd);

                doc.Validate(schema, ValidationEventHandler);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during validating file: {ex.Message}");
            }

            return doc;
        }


        public static void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            XmlSeverityType type = XmlSeverityType.Warning;

            if (!Enum.TryParse<XmlSeverityType>("Error", out type)) return;

            if (type == XmlSeverityType.Error)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static T DeserializeFromXml<T>(string xml)
        {
            T result = default;

            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(T));
                using (TextReader tr = new StringReader(xml))
                {
                    result = (T)ser.Deserialize(tr);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while deserializing file: {ex.Message}");
            }

            return result;
        }
    }
}
