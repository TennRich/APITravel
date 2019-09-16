using System.Xml.Serialization;

namespace ApiTravelTest.Model
{
    [XmlRoot("FrequentFlyerInfo")]
    public class FrequentFlyerInfo
    {
        [XmlElement("FrequentFlyer")]
        public FrequentFlyer[] FrequentFlyer { get; set; }
    }
}
