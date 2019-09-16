using System.Xml.Serialization;

namespace ApiTravelTest.Model
{
    [XmlRoot("MealPreferenceInfo")]
    public class MealPreference
    {
        [XmlElement("mealPreferenceCode")]
        public string MealPreferenceCode { get; set; }

        [XmlElement("mealPreferenceSegment")]
        public int MealPreferenceSegment { get; set; }
    }
}
