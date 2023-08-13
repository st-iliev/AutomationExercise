using Automation_Exercise.src.API.Responses;

namespace Automation_Exercise.src.API.Tests
{
    [TestFixture, Order(8)]
    public class DeleteAccountTests
    {
        private ApiClient apiClient;
        private string endpoint;
        private Dictionary<string, string> parameters;

        [SetUp]
        public void TestSetup()
        {
            apiClient = new ApiClient();
            endpoint = "/api/deleteAccount";
        }
        [Test]
        public void Delete_DeleteAccount()
        {

            // Arrange
            parameters = new Dictionary<string, string>
            {
                {"email","justfortest777@abv.bg" },
                {"password", "testqa1" }
            };
            // Act
            var response = apiClient.Delete<DeleteAccountResponse>(
               endpoint,parameters);

            // Assert
            Assert.NotNull(response);
            Assert.AreEqual(200, response.StatusCode);
        }


    }
}
