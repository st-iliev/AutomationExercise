using Automation_Exercise.src.API.Responses;

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
                {"email","justfortest777@abv.bg"},
                {"password","testqa1"}
            };
            // Act
            var response = apiClient.Delete<string>(
               endpoint,parameters);

            // Assert
            Assert.NotNull(response);
            Assert.AreEqual(200, response.StatusCode);
            Assert.AreEqual("{\"responseCode\": 200, \"message\": \"Account deleted!\"}", response.Message);
        }
    }
}
