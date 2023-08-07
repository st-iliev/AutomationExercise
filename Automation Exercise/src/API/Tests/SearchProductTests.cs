using Automation_Exercise.src.API.Model;
using Automation_Exercise.src.API.Requests;
using Automation_Exercise.src.API.Responses;
using Automation_Exercise.src.API.Responses.Brand;

namespace Automation_Exercise.src.API.Tests
{
    public class SearchProductTests
    {
        private ApiClient apiClient;
        private string endpoint;

        [OneTimeSetUp]
        public void TestSetup()
        {
            apiClient = new ApiClient();
            endpoint = "/api/searchProduct";
        }
        [TestCase("search_product","Dress")]
        public void Post_SearchExistsProduct(string parameter,string value)
        {
            // Arrange
            var parameters = new List<ApiParameter>
            {
                new ApiParameter { Name = parameter, Value = "Dress" }
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
                Assert.That(product.Category.Category.Contains(value));
            }
        }
        [Test]
        public void Post_SearchProductWithoutParameter()
        {
            // Act
            var response = apiClient.Post<object, BrandResponse>(endpoint, null);

            // Assert
            Assert.NotNull(response);
            Assert.AreEqual(200, response.StatusCode);
            Assert.AreEqual("{\"responseCode\": 400, \"message\": \"Bad request, search_product parameter is missing in POST request.\"}", response.Message);
        }
    }
}
