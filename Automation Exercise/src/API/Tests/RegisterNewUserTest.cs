using Automation_Exercise.src.API.Requests;
using Automation_Exercise.src.API.Responses;
using Automation_Exercise.src.API.Utilities;
using System.Net;

namespace Automation_Exercise.src.API.Tests
{
    [TestFixture]
    [Order(15)]
    public class RegisterNewUserTest : ExtentReport
    {
        private string endpoint;
        private CreateAccountRequest account;
        [OneTimeSetUp]
        public void OneTime()
        {
            suiteTest = extent.CreateTest("Register New User Test");
            apiClient = new ApiClient();
            account = new CreateAccountRequest();
            endpoint = "/api/createAccount";
        }
     
        [Test,Order(1)]
        public void Post_RegisterNewUser()
        {
            test = suiteTest.CreateNode("Test Post Register New User.");
            //Arrange
            var parameters = new Dictionary<string, string>
            {
                {"name","Mat" },
                {"email",ConfigurationHelper.Email },
                {"password",ConfigurationHelper.Password },
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
            test = suiteTest.CreateNode("Test Register Exists User.");
            //Arrange
            var parameters = new Dictionary<string, string>
            {
                {"name","Mat" },
                {"email",ConfigurationHelper.Email },
                {"password",ConfigurationHelper.Password },
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
