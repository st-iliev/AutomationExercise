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
            var response = apiClient.Post<object, UserResponse>(
               endpoint, null, parameters);

            // Assert
            Assert.NotNull(response);
            Assert.AreEqual(200, response.StatusCode);
            Assert.AreEqual("{\"responseCode\": 200, \"message\": \"User exists!\"}", response.Message);
        }
        [Test]
        public void Post_LoginWithMissingCredentials()
        {
            // Arrange
            var parameters = new Dictionary<string, string>
            {
              {"password", "testqa1" }
            };
            // Act
            var response = apiClient.Post<object, UserResponse>(
               endpoint, null, parameters);

            // Assert
            Assert.NotNull(response);
            Assert.AreEqual(200, response.StatusCode);
            Assert.AreEqual("{\"responseCode\": 400, \"message\": \"Bad request, email or password parameter is missing in POST request.\"}", response.Message);
        }
        [Test]
        public void Delete_LoginWithInvalidCredentials()
        {
            // Arrange
            var parameters = new Dictionary<string, string>
            {
               {"email","here@gmail.com" },
                {"password", "testqa1" }
            };
            // Act
            var response = apiClient.Delete<UserResponse>(
               endpoint,parameters);

            // Assert
            Assert.NotNull(response);
            Assert.AreEqual(200, response.StatusCode);
            Assert.AreEqual("{\"responseCode\": 405, \"message\": \"This request method is not supported.\"}", response.Message);
        }
        
    }
}
