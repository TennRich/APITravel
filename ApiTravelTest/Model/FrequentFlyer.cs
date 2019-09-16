using System.Xml.Serialization;

namespace ApiTravelTest.Model
{
    public class FrequentFlyer
    {
        [XmlElement("frequentTravelerNum")]
        public string FrequentTravelerNum { get; set; }

        [XmlElement("frequentTravelerSupplier")]
        public string FrequentTravelerSupplier { get; set; }
    }
}
