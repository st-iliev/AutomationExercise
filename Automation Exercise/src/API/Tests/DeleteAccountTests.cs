using Automation_Exercise.src.API.Model;
using Automation_Exercise.src.API.Requests;
using Automation_Exercise.src.API.Responses;
using RestSharp;

namespace Automation_Exercise.src.API.Tests
{
    public class DeleteAccountTests
    {
        private RestClient _client;

        [SetUp]
        public void Setup()
        {
            // Set up the base URL for the API
            _client = new RestClient("https://www.automationexercise.com");
        }

        [Test]
        public void TestDeleteAccount()
        {
            var request = new RestRequest("/api/deleteAccount", Method.Delete);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");

            var bodyParameters = new Dictionary<string, string>
{
    { "email", "justfortest777@abv.bg" },
    { "password", "testqa1" }
};

            foreach (var param in bodyParameters)
            {
                request.AddParameter(param.Key, param.Value);
            }

            var response = _client.Execute(request);

            Assert.AreEqual(200, (int)response.StatusCode);
            Assert.AreEqual("asdasd", response.Content.ToString());
            // You can add more assertions based on the expected response from the API
        }

    }
}
