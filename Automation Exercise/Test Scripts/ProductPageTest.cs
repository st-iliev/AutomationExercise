using Automation_Exercise.Utilities;

namespace Automation_Exercise.Test_Scripts
{
    [TestFixture]
    [Order(8)]
    public class ProductPageTest : BaseTest
    {
        [Test, Order(1)]
        [TestCase("Premium Polo T-Shirts")]
        [TestCase("Soft Stretch Jeans")]
        [TestCase("Colour Blocked Shirt – Sky Blue")]
        public void VerifySearchForExistingProduct(string productName)
        {
            productPage.Open();
            productPage.AssertCorrectPageIsLoaded();
            productPage.AssertSaleBannerIsDisplayed();
            productPage.SearchForProduct(productName);
            productPage.AssertSearchedProductIsDisplaed(productName);        
        }
        [Test, Order(2)]
        [TestCase("Shoes")]
        [TestCase("Smoking")]
        [TestCase("Hat")]
        public void VerifySearchForNonExistingProduct(string productName)
        {
            productPage.Open();
            productPage.AssertCorrectPageIsLoaded();
            productPage.AssertSaleBannerIsDisplayed();
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
            productPage.Open();
            productPage.AssertCorrectPageIsLoaded();
            productPage.AssertSaleBannerIsDisplayed();
            ScrollDown(driver, 1900);
            homePage.AssertBrandProductCountAndDisplayedBrandProductsAreTheSame(brandName);
        }
        [Test, Order(4)]
        [TestCase("WOMEN")]
        [TestCase("MEN")]
        [TestCase("KIDS")]

        public void VerifyCategoryAndSubcategoryAreLoaded(string categoryName)
        {
            productPage.Open();
            productPage.AssertCorrectPageIsLoaded();
            productPage.AssertSaleBannerIsDisplayed();
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
            productPage.Open();
            productPage.AssertCorrectPageIsLoaded();
            productPage.AssertSaleBannerIsDisplayed();
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
            productPage.Open();
            productPage.AssertCorrectPageIsLoaded();
            productPage.AssertSaleBannerIsDisplayed();
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
            productPage.Open();
            productPage.AssertCorrectPageIsLoaded();
            productPage.AssertSaleBannerIsDisplayed();
            ScrollToBottom(driver);
            productPage.AddProductToCart("GRAPHIC DESIGN MEN T SHIRT - BLUE");
            productPage.AssertAddedIconIsDisplayed();
            productPage.AssertProductAddedSuccessfulTextIsDisplayed();
        }
        [Test, Order(8)]
        public void VerifySearchProductAndAddedToCart()
        {
            productPage.Open();
            productPage.AssertCorrectPageIsLoaded();
            productPage.AssertSaleBannerIsDisplayed();
            productPage.SearchForProduct("Premium Polo T-Shirts");
            ScrollDown(driver, 500);
            productPage.AddProductToCart("Premium Polo T-Shirts");
            productPage.AssertAddedIconIsDisplayed();
            productPage.AssertProductAddedSuccessfulTextIsDisplayed();
        }
       
    }
}
