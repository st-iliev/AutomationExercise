using Automation_Exercise.src.API.Responses;
using System.Net;

namespace Automation_Exercise.src.API.Tests
{
    [TestFixture,Order(2)]
    public class ProductTests
    {
        private ApiClient apiClient;
        private string endpoint;
        private Dictionary<string, string> parameters;

        [SetUp]
        public void TestSetup()
        {
            apiClient = new ApiClient();
            endpoint = "/api/productsList";
        }
        [Test]
        public void Get_AllProduct()
        {
            // Act
            var response = apiClient.Get<ProductResponse>(endpoint);

            // Assert
            Assert.NotNull(response);
            Assert.AreEqual(200,response.StatusCode);
            Assert.NotNull(response.Data);
            Assert.That(response.Data.Products.Count,Is.GreaterThan(0));
        }
        [Test]
        public void Post_AllProduct()
        {
            // Act
            var response = apiClient.Post<object, ProductResponse>(endpoint, null, parameters);
            // Assert
            Assert.NotNull(response);
            Assert.AreEqual(200, response.StatusCode);
            Assert.AreEqual(HttpStatusCode.MethodNotAllowed, response.Data.ResponseCode);
            Assert.AreEqual("This request method is not supported.", response.Data.Message);
        }
    }
}
