using System.Xml.Serialization;

namespace ApiTravelTest.Model
{
    [XmlRoot("Seats")]
    public class Seats
    {
        [XmlElement("Seat")]
        public Seat[] Seat { get; set; }
    }
}
