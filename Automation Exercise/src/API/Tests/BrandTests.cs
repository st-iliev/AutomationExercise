using Automation_Exercise.src.API.Responses.Brand;
using System.Net;

namespace Automation_Exercise.src.API.Tests
{
    [TestFixture, Order(3)]
    public class BrandTests
    {
        private ApiClient apiClient;
        private string endpoint;
        private Dictionary<string, string> parameters;

        [SetUp]
        public void TestSetup()
        {
            apiClient = new ApiClient();
            endpoint = "/api/brandsList";
        }
        [Test]
        public void Get_AllBrands()
        {
            // Act
            var response = apiClient.Get<BrandResponse>(endpoint);

            // Assert
            Assert.NotNull(response);
            Assert.AreEqual(200, response.StatusCode);
            Assert.NotNull(response.Data);
            Assert.That(response.Data.Brands.Count, Is.GreaterThan(0));
            foreach (var brand in response.Data.Brands)
            {
                Assert.That(brand.Id, Is.GreaterThan(0));
                Assert.IsNotNull(brand.Brand);
            }
        }
        [Test]
        public void Post_AllBrands()
        {
            // Act
            var response = apiClient.Post<object,BrandResponse>(endpoint, null, parameters);

            // Assert
            Assert.NotNull(response);
            Assert.AreEqual(200, response.StatusCode);
            Assert.AreEqual(HttpStatusCode.MethodNotAllowed, response.Data.ResponseCode);
            Assert.AreEqual("This request method is not supported.", response.Data.Message);

        }
        [Test]
        public void Put_AllBrands()
        {
            // Act
            var response = apiClient.Put<object, BrandResponse>(endpoint, null);

            // Assert
            Assert.NotNull(response);
            Assert.AreEqual(200, response.StatusCode);
            Assert.AreEqual(HttpStatusCode.MethodNotAllowed, response.Data.ResponseCode);
            Assert.AreEqual("This request method is not supported.", response.Data.Message);
        }
    }
}
