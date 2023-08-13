using Automation_Exercise.src.API.Requests;
using Automation_Exercise.src.API.Responses;
using System.Net;

namespace Automation_Exercise.src.API.Tests
{
    [TestFixture, Order(6)]
    public class UpdateUserAccount
    {
        private ApiClient apiClient;
        private string endpoint;
        private CreateAccountRequest account;

        [SetUp]
        public void TestSetup()
        {
            apiClient = new ApiClient();
            account = new CreateAccountRequest();
            endpoint = "/api/updateAccount";
        }
        [Test]
        public void Put_UpdateUserAccount()
        {
            //Arrange
            var parameters = new Dictionary<string, string>
            {
                {"name","Jo" },
                {"email","justfortest777@abv.bg" },
                {"password","testqa1" },
                {"title","Mr" },
                {"birth_date","14" },
                {"birth_month","novembur" },
                {"birth_year","1995" },
                {"firstname","John" },
                {"lastname","Fibber" },
                {"company","Space Y" },
                {"address1","bul.Freedom" },
                {"address2","str.Doom" },
                {"country","United State" },
                {"zipcode","15847" },
                {"state","Utah" },
                {"city","Orem" },
                {"mobile_number","+397114779" },
            };
            // Act
            var response = apiClient.Put<CreateAccountRequest, UpdateUserResponse>(
               endpoint, null, parameters);

            // Assert
            Assert.NotNull(response);
            Assert.AreEqual(200, response.StatusCode);
            Assert.AreEqual(HttpStatusCode.OK, response.Data.ResponseCode);
            Assert.AreEqual("User updated!", response.Data.Message);
        }
    }
}
