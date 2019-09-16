using System.Xml.Serialization;

namespace ApiTravelTest.Model
{
    [XmlRoot(Namespace = "http://gdsx.com/PnrDataPush.xsd", ElementName = "pnr")]
    public class XMLInfo
    {
        [XmlElement("Travelers")]
        public Travelers Travelers { get; set; }

        [XmlElement("BookingDateTime")]
        public string BookingDateTime { get; set; }

        [XmlElement("PNRid")]
        public string PNRid { get; set; }

        [XmlElement("GDS")]
        public string GDS { get; set; }

        [XmlElement("platformID")]
        public int PlatformID { get; set; }

        [XmlElement("securityManagerID")]
        public int SecurityManagerID { get; set; }

        [XmlElement("globalCustomerNumber")]
        public int GlobalCustomerNumber { get; set; }

        [XmlElement("customerNumber")]
        public long CustomerNumber { get; set; }

        [XmlElement("agentSignature")]
        public string AgentSignature { get; set; }

        [XmlElement("agentPCC")]
        public string AgentPCC { get; set; }

        [XmlElement("etrHits")]
        public int EtrHits { get; set; }
    }
}
