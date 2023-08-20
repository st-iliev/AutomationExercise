﻿using System.Net;
using Automation_Exercise.src.API.Responses.Brand;
using Automation_Exercise.src.API.Utilities;
using AventStack.ExtentReports.Model;
using NUnit.Framework.Internal;

namespace Automation_Exercise.src.API.Tests
{
    [TestFixture]
    [Order(14)]
    public class BrandTests : ExtentReport
    {
        private string endpoint;
        private Dictionary<string, string> parameters;
        [OneTimeSetUp] 
        public void OneTIme() 
        {
            suiteTest = extent.CreateTest("Brand Test");
            apiClient = new ApiClient();
            endpoint = "/api/brandsList";
        }
        [Test]
        public void Get_AllBrands()
        {
            test = suiteTest.CreateNode("Test Get All Brands.");
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
           test = suiteTest.CreateNode("Test Post All Brands.");
            // Act
            var response = apiClient.Post<object, BrandResponse>(endpoint, null, parameters);

            // Assert
            Assert.NotNull(response);
            Assert.AreEqual(200, response.StatusCode);
            Assert.AreEqual(HttpStatusCode.MethodNotAllowed, response.Data.ResponseCode);
            Assert.AreEqual("This request method is not supported.", response.Data.Message);

        }
        [Test]
        public void Put_AllBrands()
        {
            test = suiteTest.CreateNode("Test Put All Brands.");
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
