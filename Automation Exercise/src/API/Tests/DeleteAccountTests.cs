using Automation_Exercise.src.API.Requests;
using Automation_Exercise.src.API.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Exercise.src.API.Tests
{
    public class DeleteAccountTests
    {
        private ApiClient apiClient;
        private string endpoint;

        [SetUp]
        public void TestSetup()
        {
            apiClient = new ApiClient();
            endpoint = "/api/deleteAccount";
        }
        [Test]
        public void Delete_DeleteExistsAccount()
        {
            // Arrange
            var parameters = new Dictionary<string, string>
            {
                {"email","justfortest777@abv.bg" },
                {"password", "testqa1" }
            };
            // Act
            var response = apiClient.Delete<UserResponse>(
               endpoint,parameters);

            // Assert
            Assert.NotNull(response);
            Assert.AreEqual(200, response.StatusCode);
            Assert.AreEqual("{\"responseCode\": 200, \"message\": \"Account deleted!\"}", response.Message);
        }
    }
}
