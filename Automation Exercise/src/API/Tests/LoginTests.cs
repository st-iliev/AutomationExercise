using Automation_Exercise.src.API.Requests;
using Automation_Exercise.src.API.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Exercise.src.API.Tests
{
    public  class LoginTests
    {
        private ApiClient apiClient;
        private string endpoint;
        private Dictionary<string, string> parameters;

        [SetUp]
        public void TestSetup()
        {
            apiClient = new ApiClient();
            endpoint = "/api/verifyLogin";
        }
        [Test]
        public void Post_LoginWithValidCredentials()
        {
            // Arrange
            var parameters = new Dictionary<string, string>
            {
                {"email","justfortest777@abv.bg" },
                {"password", "testqa1" }
            };
            // Act
            var response = apiClient.Post<SearchRequest, ProductResponse>(
               endpoint, null, parameters);

            // Assert
            Assert.NotNull(response);
            Assert.AreEqual(200, response.StatusCode);
            Assert.AreEqual("{\"responseCode\": 200, \"message\": \"User exists!\"}", response.Message);
        }
    }
}
