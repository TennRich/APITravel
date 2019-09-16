using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using ApiTravelTest.Utils;

namespace ApiTravelTest
{
    [TestClass]
    public class TravelersTest
    {
        private const string NewFilePath = "NewFile.xml";
        private const string ExistingFilePath = "test-pnr.xml";

        [TestMethod]
        public void ApiTest()
        {
            var restClient = new RestClient("http://icerow.com/prodjects.xml");
            var restRequest = new RestRequest(Method.POST);
            var some = new Serializer();
            var randomInt = new Randomizer();
            var model1 = some.DeserializeXml(ExistingFilePath);
            model1.PlatformID = randomInt.GetRandomInt();

            some.SerializeToXml(NewFilePath, model1);
            var model2 = some.DeserializeXml(NewFilePath);

            restRequest.AddXmlBody(model2);

            var restResponse = restClient.Execute(restRequest);
            Assert.AreEqual(404, (int)restResponse.StatusCode);
        }
    }
}
