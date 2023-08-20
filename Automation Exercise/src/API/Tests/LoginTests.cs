using Automation_Exercise.src.API.Requests;
using Automation_Exercise.src.API.Responses;
using Automation_Exercise.src.API.Utilities;
using System.Net;

namespace Automation_Exercise.src.API.Tests
{
    [TestFixture]
    [Order(16)]
    public  class LoginTests : ExtentReport
    {
        private string endpoint;
        private Dictionary<string, string> parameters;
        [OneTimeSetUp]
        public void OneTIme()
        {
            suiteTest = extent.CreateTest("Login Test");
            apiClient = new ApiClient();
            endpoint = "/api/verifyLogin";
        }
        [Test]
        public void Post_LoginWithValidCredentials()
        {
            test = suiteTest.CreateNode("Test Post Login With Valid Credentials.");
            // Arrange
            parameters = new Dictionary<string, string>
            {
                {"email",ConfigurationHelper.Email },
                {"password", ConfigurationHelper.Password }
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
            test = suiteTest.CreateNode("Test Post Login With Missing Credentials.");
            // Arrange
            parameters = new Dictionary<string, string>
            {
              {"password", ConfigurationHelper.Password }
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
            test = suiteTest.CreateNode("Test Post Login With Invalid Credentials.");
            // Arrange
            parameters = new Dictionary<string, string>
            {
               {"email","here@gmail.com" },
               {"password", ConfigurationHelper.Password }
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
