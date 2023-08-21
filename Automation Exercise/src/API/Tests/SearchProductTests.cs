using Automation_Exercise.src.API.Model;
using Automation_Exercise.src.API.Requests;
using Automation_Exercise.src.API.Responses;
using Automation_Exercise.src.API.Responses.Brand;
using Automation_Exercise.src.API.Utilities;
using System.Net;

namespace Automation_Exercise.src.API.Tests
{
    [TestFixture]
    [Order(12)]
    public class SearchProductTests : ExtentReport
    {
        private string endpoint;
        private Dictionary<string, string> parameters;
        [OneTimeSetUp]
        public void OneTime()
        {
            suiteTest = extent.CreateTest("Search Product Test");
            apiClient = new ApiClient();
            endpoint = "/api/searchProduct";
        }
        [Test,Order(1)]
        public void Post_SearchExistsProduct()
        {
            // Arrange
            test = suiteTest.CreateNode("Test Search Exists Product.");
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
        [Test,Order(2)]
        public void Post_SearchProductWithoutParameter()
        {
            // Act
            test = suiteTest.CreateNode("Test Search Product Without Parameter.");
            var response = apiClient.Post<object, BrandResponse>(endpoint, null, parameters);

            // Assert
            Assert.NotNull(response);
            Assert.AreEqual(200, response.StatusCode);
            Assert.AreEqual(HttpStatusCode.BadRequest, response.Data.ResponseCode);
            Assert.AreEqual("Bad request, search_product parameter is missing in POST request.", response.Data.Message);
        }
    }
}
