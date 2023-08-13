using Automation_Exercise.src.API.Requests;
using Automation_Exercise.src.API.Responses;
using System.Net;

namespace Automation_Exercise.src.API.Tests
{
    [TestFixture, Order(4)]
    public class RegisterNewUserTest
    {
        private ApiClient apiClient;
        private string endpoint;
        private CreateAccountRequest account;

        [SetUp]
        public void TestSetup()
        {
            apiClient = new ApiClient();
            account = new CreateAccountRequest();
            endpoint = "/api/createAccount";
        }
        [Test,Order(1)]
        public void Post_RegisterNewUser()
        {
            //Arrange
            var parameters = new Dictionary<string, string>
            {
                {"name","Mat" },
                {"email","justfortest777@abv.bg" },
                {"password","testqa1" },
                {"title","Mr" },
                {"birth_date","10" },
                {"birth_month","may" },
                {"birth_year","1990" },
                {"firstname","Matthew" },
                {"lastname","Tudor" },
                {"company","Space Z" },
                {"address1","bul.Bulgaria" },
                {"address2","str.Yalta" },
                {"country","Australia" },
                {"zipcode","10005" },
                {"state","Sula" },
                {"city","Hamilton" },
                {"mobile_number","+365895874" },
            };
            // Act
            var response = apiClient.Post<CreateAccountRequest, CreateUserResponse>(
               endpoint, null, parameters);

            // Assert
            Assert.NotNull(response);
            Assert.AreEqual(200, response.StatusCode);
            Assert.AreEqual(HttpStatusCode.Created, response.Data.ResponseCode);
            Assert.AreEqual("User created!", response.Data.Message);
        }
        [Test,Order(2)]
        public void Post_RegisterExistsUser()
        {
            //Arrange
            var parameters = new Dictionary<string, string>
            {
                {"name","Mat" },
                {"email","justfortest777@abv.bg" },
                {"password","testqa1" },
                {"firstname","Matthew" },
                {"lastname","Tudor" },
                {"company","Space Z" },
                {"address1","bul.Bulgaria" },
                {"country","Australia" },
                {"zipcode","10005" },
                {"state","Sula" },
                {"city","Hamilton" },
                {"mobile_number","+365895874" },

            };
            // Act
            var response = apiClient.Post<CreateAccountRequest, CreateUserResponse>(
               endpoint, null, parameters);

            // Assert
            Assert.NotNull(response);
            Assert.AreEqual(200, response.StatusCode);
            Assert.AreEqual(HttpStatusCode.BadRequest, response.Data.ResponseCode);
            Assert.AreEqual("Email already exists!", response.Data.Message);
        }
    }
}
