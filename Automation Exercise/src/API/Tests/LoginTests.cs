using Automation_Exercise.src.API.Requests;
using Automation_Exercise.src.API.Responses;
using System.Net;

namespace Automation_Exercise.src.API.Tests
{
    [TestFixture, Order(5)]
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
            parameters = new Dictionary<string, string>
            {
                {"email","justfortest777@abv.bg" },
                {"password", "testqa1" }
            };
            // Act
            var response = apiClient.Post<LoginRequest, LoginResponse>(
               endpoint, null, parameters);

            // Assert
            Assert.NotNull(response);
            Assert.AreEqual(200, response.StatusCode);
            Assert.AreEqual(HttpStatusCode.OK, response.Data.ResponseCode);
            Assert.AreEqual("User exists!", response.Data.Message);
        }
        [Test]
        public void Post_LoginWithMissingCredentials()
        {
            // Arrange
            parameters = new Dictionary<string, string>
            {
              {"password", "testqa1" }
            };
            // Act
            var response = apiClient.Post<LoginRequest, LoginResponse>(
               endpoint, null, parameters);

            // Assert
            Assert.NotNull(response);
            Assert.AreEqual(200, response.StatusCode);
            Assert.AreEqual(HttpStatusCode.BadRequest, response.Data.ResponseCode);
            Assert.AreEqual("Bad request, email or password parameter is missing in POST request.", response.Data.Message);
        }
        [Test]
        public void Post_LoginWithInvalidCredentials()
        {
            // Arrange
            parameters = new Dictionary<string, string>
            {
               {"email","here@gmail.com" },
               {"password", "testqa1" }
            };
            // Act
            var response = apiClient.Post<LoginRequest, LoginResponse>(
               endpoint,null,parameters);

            // Assert
            Assert.NotNull(response);
            Assert.AreEqual(200, response.StatusCode);
            Assert.AreEqual(HttpStatusCode.NotFound, response.Data.ResponseCode);
            Assert.AreEqual("User not found!", response.Data.Message);
        }
        
    }
}
