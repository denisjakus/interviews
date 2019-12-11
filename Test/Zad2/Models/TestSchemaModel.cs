using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Zad2.Models
{
    [XmlRoot(ElementName = "sheet")]
    public class TestSchemaModel
    {
        [XmlElement(ElementName = "row")]
        public List<Row> Rows { get; set; }
    }

    [XmlRoot(ElementName = "row")]
    public class Row
    {
        [XmlElement(ElementName = "cell")]
        public List<string> Cell { get; set; }
    }
}
