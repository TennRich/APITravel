using System.Xml.Serialization;

namespace ApiTravelTest.Model
{
    [XmlRoot("SeatPref")]
    public class SeatPref
    {
        [XmlElement("preferenceLocationText")]
        public string PreferenceLocationText { get; set; }

        [XmlElement("preferenceLocationCode")]
        public string PreferenceLocationCode { get; set; }

        [XmlElement("longFreeText")]
        public string LongFreeText { get; set; }
    }
}
