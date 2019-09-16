using System.Xml.Serialization;

namespace ApiTravelTest.Model
{
    [XmlRoot("Travelers")]
    public class Travelers
    {
        [XmlElement("Traveler")]
        public Traveler[] Traveler { get; set; }
    }
}
