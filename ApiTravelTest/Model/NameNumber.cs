using System.Xml.Serialization;

namespace ApiTravelTest.Model
{
    public class NameNumber
    {
        [XmlElement("prefix")]
        public int Prefix { get; set; }

        [XmlElement("suffix")]
        public int Suffix { get; set; }
    }
}
