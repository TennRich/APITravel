using System.Xml.Serialization;

namespace ApiTravelTest.Model
{
    public class Traveler
    {
        [XmlElement("firstName")]
        public string FirstName { get; set; }

        [XmlElement("lastName")]
        public string LastName { get; set; }

        [XmlElement("FrequentFlyerInfo")]
        public FrequentFlyerInfo FrequentFlyerInfo { get; set; }

        [XmlElement("MealPreferenceInfo")]
        public MealPreferenceInfo MealPreferenceInfo { get; set; }

        [XmlElement("SeatPreferenceInfo")]
        public SeatPreferenceInfo SeatPreferenceInfo { get; set; }

        [XmlElement("Seats")]
        public Seat Seats { get; set; }

        [XmlElement("passengerNumber")]
        public int PassengerNumber { get; set; }

        [XmlElement("nameInGds")]
        public string NameInGds { get; set; }

        [XmlElement("NameNumber")]
        public NameNumber[] NameNumber { get; set; }
    }
}
