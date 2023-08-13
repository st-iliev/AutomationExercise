using Automation_Exercise.src.API.Responses.User;
using System.Net;

namespace Automation_Exercise.src.API.Tests
{
    [TestFixture, Order(7)]
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
            parameters = new Dictionary<string, string>
            {
                {"email","justfortest777@abv.bg"}
            };
            // Act
            var response = apiClient.Get<UserResponse>(
               endpoint,parameters);

            // Assert
            Assert.NotNull(response);
            Assert.AreEqual(200, response.StatusCode);
            Assert.AreEqual(HttpStatusCode.OK, response.Data.ResponseCode);
            Assert.NotNull(response.Data.User.Id);
            Assert.AreEqual("justfortest777@abv.bg", response.Data.User.Email);
        }
    }
}
