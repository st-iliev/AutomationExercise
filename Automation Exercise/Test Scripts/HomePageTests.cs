using Automation_Exercise.Utilities;

namespace Automation_Exercise.Test_Scripts
{
    [TestFixture]
    [Order(1)]
    public class HomePageTests : BaseTest
    {
        [Test,Order(1)]
        public void VerifyNavigationLinksArePresentAndFunctioningCorrectly()
        {
            homePage.Open();
            homePage.AssertCorrectPageIsLoaded();
            homePage.AssertWebBannerIsDisplayed();
            homePage.AssertNavigationLinksArePresent();
        }
        [Test, Order(2)]
        [TestCase("left")]
        [TestCase("right")]
        [TestCase("right")]
        [TestCase("right")]
        [TestCase("left")]
        [TestCase("left")]
        public void VerifyClickingOnArrowsSwitchCarouselContentImageAndActiveIndicator(string side)
        {
            homePage.AssertCorrectPageIsLoaded();
            homePage.AssertWebBannerIsDisplayed();
            homePage.ClickOnArrow(side);
            homePage.AssertCorrectCarouselTextsAreDisplayed();
            homePage.AssertImageSwitched();
            homePage.AssertActiveIndicatorSwitched();
        }
        [Test, Order(3)]
        [TestCase("First")]
        [TestCase("Second")]
        [TestCase("Third")]
        public void VerifyClickingOnIndicatorsSwitchCarouselContentImageAndActiveIndicator(string indicator)
        {
            homePage.Open();
            homePage.AssertCorrectPageIsLoaded();
            homePage.AssertWebBannerIsDisplayed();
            homePage.ClickOnIndicators(indicator);
            homePage.AssertCorrectCarouselTextsAreDisplayed();
            homePage.AssertImageSwitched();
            homePage.AssertActiveIndicatorSwitched();
        }
        [Test, Order(4)]
        [TestCase("WOMEN")]
        [TestCase("MEN")]
        [TestCase("KIDS")]
        
        public void VerifyCategoryAndSubcategoryAreLoaded(string categoryName)
        {
            homePage.Open();
            homePage.AssertCorrectPageIsLoaded();
            homePage.AssertWebBannerIsDisplayed();
            ScrollDown(driver, 250);
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
            homePage.Open();
            homePage.AssertCorrectPageIsLoaded();
            homePage.AssertWebBannerIsDisplayed();
            ScrollDown(driver,650);
            homePage.AssertBrandProductCountAndDisplayedBrandProductsAreTheSame(brandName);
        }
        [Test, Order(6)]
        public void VerifySuccessfulSubscribe()
        {
            homePage.Open();
            homePage.AssertCorrectPageIsLoaded();
            homePage.AssertWebBannerIsDisplayed();
            ScrollToBottom(driver);
            homePage.Subscrible(Constants.email);
            homePage.ClickOnSubscribeButton();
            homePage.AssertCorrectSuccessfulSubscribeMessageIsDisplayed();
        }
        [Test, Order(7)]
        [TestCase("")]
        [TestCase("invalidEmail")]
        [TestCase("invalidEmail@")]
        public void VerifySubscribeWithInvalidEmail(string email)
        {
            homePage.Open();
            homePage.AssertCorrectPageIsLoaded();
            homePage.AssertWebBannerIsDisplayed();
            ScrollToBottom(driver);
            homePage.Subscrible(email);
            homePage.ClickOnSubscribeButton();
            switch (email)
            {
                case null:
                    homePage.AssertErrorEmptyFieldMessageIsDisplayed(homePage.subscribeField); break;
                case "invalidEmail":
                    homePage.AssertErrorInvalidEmailAddressMessageIsDisplayed(homePage.subscribeField,email); break;
                case "invalidEmail@":
                    homePage.AssertErrorIncompleteEmailAddressMessageIsDisplayed(homePage.subscribeField, email); break;
            };
        }
        [Test, Order(8)]
        [TestCase("Products")]
        [TestCase("Cart")]
        [TestCase("Login")]
        [TestCase("Test Cases")]
        [TestCase("API Testing")]
        //[TestCase("Video Tutorials")]
        [TestCase("Contact us")]
        public void VerifyNavigationLinksNavigateToCorrectPage(string pageName)
        {
            homePage.Open();
            homePage.AssertCorrectPageIsLoaded();
            homePage.AssertWebBannerIsDisplayed();
            switch (pageName)
            {
                case "Products":
                    homePage.ClickOnElement(homePage.productsLink);
                    AdverticeHelper.CheckForAdvertice(driver);
                    homePage.AssertProductsNavigationLinkOpenCorrectPage();
                    break;
                case "Cart":
                    homePage.ClickOnElement(homePage.cartLink);
                    homePage.AssertCartNavigationLinkOpenCorrectPage();
                    break;
                case "Login":
                    homePage.ClickOnElement(homePage.loginLink);
                    homePage.AssertLoginNavigationLinkOpenCorrectPage();
                    break;
                case "Test Cases":
                    homePage.ClickOnElement(homePage.testCasesLink);
                    AdverticeHelper.CheckForAdvertice(driver);
                    homePage.AssertTestCasesNavigationLinkOpenCorrectPage();
                    break;
                case "API Testing":
                    homePage.ClickOnElement(homePage.apiTestingLink);
                    AdverticeHelper.CheckForAdvertice(driver);
                    homePage.AssertAPITestingNavigationLinkOpenCorrectPage();
                    break;
                //case "Video Tutorials":
                //    homePage.ClickOnElement(homePage.videoTutorialsLink);
                //   YTConsentPageHelper.CheckForYYConsentPage(driver);
                //    homePage.AssertVideoTutorialsNavigationLinkOpenCorrectPage();
                //    break;
                case "Contact us":
                    homePage.ClickOnElement(homePage.contactusLink);
                    homePage.AssertContactUsNavigationLinkOpenCorrectPage();
                    break;
            }
        }
        [Test, Order(9)]
        [TestCase("Winter Top")]
        public void VerifyOpenProductDetailsPage(string productName)
        {
            homePage.Open();
            homePage.AssertCorrectPageIsLoaded();
            homePage.AssertWebBannerIsDisplayed();
            ScrollDown(driver, 750);
            int priceFromHomePage = homePage.GetProductPrice(productName);
            homePage.ViewProduct(productName);
            AdverticeHelper.CheckForAdvertice(driver);
            productDetailsPage.AssertCorrectPageIsLoaded();
            productDetailsPage.AssertCorrectProductDetailsPageIsOpened(homePage.GetProductId());
            productDetailsPage.AssertCorrectProductName(productName);
            productDetailsPage.AssertCorrectProductPrice(priceFromHomePage,productDetailsPage.GetProductPrice());


        }
        [Test]
        [TestCase("WOMEN","DRESS")]
        [TestCase("WOMEN","TOPS")]
        [TestCase("WOMEN","SAREE")]
        [TestCase("MEN","TSHIRTS")]
        [TestCase("MEN","JEANS")]
        [TestCase("KIDS","DRESS")]
        [TestCase("KIDS","TOPS & SHIRTS")]
        public void VerifyCorrectProductFromSubCategoryAreLoaded(string categoryName , string subCategoryName)
        {
            homePage.Open();
            homePage.AssertCorrectPageIsLoaded();
            homePage.AssertWebBannerIsDisplayed();
            ScrollDown(driver, 250);
            homePage.SelectCategoryAndSubCategory(categoryName, subCategoryName);
            homePage.AssertCorrectProductSubCategoryTitleIsDisplayed(categoryName, subCategoryName);
        }
    }
}
