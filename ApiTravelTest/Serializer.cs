using ApiTravelTest.Model;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace ApiTravelTest
{
    public class Serializer
    {
        //TODO: Rewrite to Generic
        public XMLInfo DeserializeXml(string path)
        {
            XMLInfo Employees = null;
            var serializer = new XmlSerializer(typeof(XMLInfo));
            using (StreamReader reader = new StreamReader(path))
            Employees = (XMLInfo)serializer.Deserialize(reader);

            return Employees;
        }

        public void SerializeToXml(string path, XMLInfo model)
        {
            var xmlDocument = new XmlDocument();
            var serializer = new XmlSerializer(model.GetType());
            using (var stream = new MemoryStream())
            {
                serializer.Serialize(stream, model);
                stream.Position = 0;
                xmlDocument.Load(stream);
                xmlDocument.Save(path);
            }
        }
    }
}
