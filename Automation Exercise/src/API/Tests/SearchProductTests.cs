using Automation_Exercise.src.API.Model;
using Automation_Exercise.src.API.Requests;
using Automation_Exercise.src.API.Responses;
using Automation_Exercise.src.API.Responses.Brand;
using System.Net;

namespace Automation_Exercise.src.API.Tests
{
    [TestFixture,Order(1)]
    public class SearchProductTests
    {
        private ApiClient apiClient;
        private string endpoint;
        private Dictionary<string, string> parameters;

        [OneTimeSetUp]
        public void TestSetup()
        {
            apiClient = new ApiClient();
            endpoint = "/api/searchProduct";
        }
        [Test]
        public void Post_SearchExistsProduct()
        {
            // Arrange
            var parameters = new Dictionary<string, string>
            {
                {"search_product", "Dress" }
            };
            // Act
            var response = apiClient.Post<SearchRequest, ProductResponse>(
               endpoint, null, parameters);
            // Assert
            Assert.NotNull(response);
            Assert.AreEqual(200, response.StatusCode);
            Assert.That(response.Data.Products.Count, Is.GreaterThan(0));
            foreach (var product in response.Data.Products)
            {
                Assert.That(product.Category.Category.Contains("Dress"));
            }
        }
        [Test]
        public void Post_SearchProductWithoutParameter()
        {
            // Act
            var response = apiClient.Post<object, BrandResponse>(endpoint, null, parameters);

            // Assert
            Assert.NotNull(response);
            Assert.AreEqual(200, response.StatusCode);
            Assert.AreEqual(HttpStatusCode.BadRequest, response.Data.ResponseCode);
            Assert.AreEqual("Bad request, search_product parameter is missing in POST request.", response.Data.Message);
        }
    }
}
