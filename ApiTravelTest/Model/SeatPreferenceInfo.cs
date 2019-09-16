using System.Xml.Serialization;

namespace ApiTravelTest.Model
{
    [XmlRoot("SeatPreferenceInfo")]
    public class SeatPreferenceInfo
    {
        [XmlElement("SeatPref")]
        public SeatPref[] SeatPref { get; set; }
    }
}
