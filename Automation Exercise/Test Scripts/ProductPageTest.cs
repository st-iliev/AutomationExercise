﻿using Automation_Exercise.Utilities;

namespace Automation_Exercise.Test_Scripts
{
    [TestFixture]
    [Order(9)]
    public class ProductPageTest : BaseTest
    {

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            suiteTest = extent.CreateTest("Product Page Tests");
        }
        [SetUp]
        public void Precondition()
        {
            productPage.Open();
            productPage.AssertCorrectPageIsLoaded();
            productPage.AssertSaleBannerIsDisplayed();
        }
        [Test, Order(1)]
        [TestCase("Premium Polo T-Shirts")]
        [TestCase("Soft Stretch Jeans")]
        [TestCase("Colour Blocked Shirt – Sky Blue")]
        public void VerifySearchForExistingProduct(string productName)
        {
            test = suiteTest.CreateNode("Test Search For Existing Product");
            productPage.SearchForProduct(productName);
            productPage.AssertSearchedProductIsDisplaed(productName);        
        }
        [Test, Order(2)]
        [TestCase("Shoes")]
        [TestCase("Smoking")]
        [TestCase("Hat")]
        public void VerifySearchForNonExistingProduct(string productName)
        {
            test = suiteTest.CreateNode("Test Search For NonExisting Product");
            productPage.SearchForProduct(productName);
            productPage.AssertNonProductsAreDisplayed();
        }
        [Test, Order(3)]
        [TestCase(Brands.Polo)]
        [TestCase(Brands.AllenSollyJunior)]
        [TestCase(Brands.HandM)]
        [TestCase(Brands.MastAndHarbour)]
        [TestCase(Brands.KookieKids)]
        [TestCase(Brands.Biba)]
        [TestCase(Brands.Babyhug)]
        [TestCase(Brands.Madame)]
        public void VerifyNumberOfBrandProductIsSameAsBrandProductCount(Brands brandName)
        {
            test = suiteTest.CreateNode("Test Number Of BrandProduct Is Same As BrandProduct Count");
            ScrollDown(driver, 1900);
            homePage.AssertBrandProductCountAndDisplayedBrandProductsAreTheSame(brandName);
        }
        [Test, Order(4)]
        [TestCase("WOMEN")]
        [TestCase("MEN")]
        [TestCase("KIDS")]

        public void VerifyCategoryAndSubcategoryAreLoaded(string categoryName)
        {
            test = suiteTest.CreateNode("Test All Category And Subcategory Are Loaded");
            ScrollDown(driver, 500);
            homePage.SelectCategoryAndSubCategory(categoryName, null);
            switch (categoryName)
            {
                case "WOMEN":
                    homePage.AssertWomenCategoryAndSubCategoriesAreDisplayed();
                    break;
                case "MEN":
                    homePage.AssertMenCategoryAndSubCategoriesAreDisplayed();
                    break;
                case "KIDS":
                    homePage.AssertKidsCategoryAndSubCategoriesAreDisplayed();
                    break;
                default:
                    Assert.Fail("Wrong category name");
                    break;
            }
        }
        [Test, Order(5)]
        public void VerifySuccessfulSubscribe()
        {
            test = suiteTest.CreateNode("Test Search For Existing Product");
            ScrollToBottom(driver);
            homePage.Subscrible(Constants.email);
            homePage.ClickOnSubscribeButton();
            homePage.AssertCorrectSuccessfulSubscribeMessageIsDisplayed();
        }
        [Test, Order(6)]
        [TestCase("")]
        [TestCase("invalidEmail")]
        [TestCase("invalidEmail@")]
        public void VerifySubscribeWithInvalidEmail(string email)
        {
            test = suiteTest.CreateNode("Test Subscribe With Invalid Credential");
            ScrollToBottom(driver);
            homePage.Subscrible(email);
            homePage.ClickOnSubscribeButton();
            switch (email)
            {
                case null:
                    homePage.AssertErrorEmptyFieldMessageIsDisplayed(homePage.subscribeField); break;
                case "invalidEmail":
                    homePage.AssertErrorInvalidEmailAddressMessageIsDisplayed(homePage.subscribeField, email); break;
                case "invalidEmail@":
                    homePage.AssertErrorIncompleteEmailAddressMessageIsDisplayed(homePage.subscribeField, email); break;
            };
        }
        [Test, Order(7)]
        public void VerifyAddProductToCart()
        {
            test = suiteTest.CreateNode("Test Add Product To Cart");
            ScrollToBottom(driver);
            productPage.AddProductToCart("GRAPHIC DESIGN MEN T SHIRT - BLUE");
            productPage.AssertAddedIconIsDisplayed();
            productPage.AssertProductAddedSuccessfulTextIsDisplayed();
        }
        [Test, Order(8)]
        public void VerifySearchProductAndAddedToCart()
        {
            test = suiteTest.CreateNode("Test Add Searched Product To Cart");
            productPage.SearchForProduct("Premium Polo T-Shirts");
            ScrollDown(driver, 500);
            productPage.AddProductToCart("Premium Polo T-Shirts");
            productPage.AssertAddedIconIsDisplayed();
            productPage.AssertProductAddedSuccessfulTextIsDisplayed();
        }
        [Test, Order(9)]
        public void VerifySearchProductAndOpenProductDetailsPage()
        {
            test = suiteTest.CreateNode("Test Open the ProductDetailsPage of the searched product");
            productPage.SearchForProduct("Premium Polo T-Shirts");
            ScrollDown(driver, 500);
            productPage.ClickOnViewProduct("Premium Polo T-Shirts");
            AdverticeHelper.CheckForAdvertice(driver);
            productDetailsPage.AssertCorrectPageIsLoaded();
            productDetailsPage.AssertCorrectProductName("Premium Polo T-Shirts");
        }
        [Test, Order(10)]
        [TestCase("Sleeveless Dress")]
        [TestCase("Men Tshirt")]
        [TestCase("Blue Top")]
        public void VerifyOpenProductDeatailsPage(string productName)
        {
            test = suiteTest.CreateNode("Test Open the ProductDetailsPage of the product");
            ScrollDown(driver, 600);
            productPage.ClickOnViewProduct(productName);
            AdverticeHelper.CheckForAdvertice(driver);
            productDetailsPage.AssertCorrectPageIsLoaded();
            productDetailsPage.AssertCorrectProductName(productName);
        }

    }
}
