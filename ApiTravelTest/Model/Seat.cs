using System.Xml.Serialization;

namespace ApiTravelTest.Model
{
    [XmlRoot("Seat")]
    public class Seat
    {
        [XmlElement("segmentNumber")]
        public int SegmentNumber { get; set; }

        [XmlElement("location")]
        public string Location { get; set; }
    }
}
