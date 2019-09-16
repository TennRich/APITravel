using System.Xml.Serialization;

namespace ApiTravelTest.Model
{
    [XmlRoot("MealPreferenceInfo")]
    public class MealPreferenceInfo
    {
        [XmlElement("MealPreference")]
        public MealPreference[] MealPreference { get; set; }
    }
}
