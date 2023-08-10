using Automation_Exercise.src.API.Requests;
using Automation_Exercise.src.API.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Exercise.src.API.Tests
{
    public class UserAccountTests
    {
        private ApiClient apiClient;
        private string endpoint;
        private Dictionary<string, string> parameters;

        [SetUp]
        public void TestSetup()
        {
            apiClient = new ApiClient();
            endpoint = "/api/getUserDetailByEmail";
        }
        [Test]
        public void Get_UserAccountByEmail()
        {
            // Arrange
            var parameters = new Dictionary<string, string>
            {
                {"email","justfortest777@abv.bg"}
            };
            // Act
            var response = apiClient.Get<User>(
               endpoint,parameters);

            // Assert
            Assert.NotNull(response);
            Assert.AreEqual(200, response.StatusCode);
            Assert.NotNull(response.Data.Id);
            Assert.AreEqual("Mat", response.Data.Name);
        }
    }
}
