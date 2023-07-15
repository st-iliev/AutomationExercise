using Automation_Exercise.Utilities;

namespace Automation_Exercise.Test_Scripts
{
    [TestFixture]
    [Order(2)]
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
        
        public void VerifyCategoryAndSubcategory(string categoryName)
        {
            homePage.Open();
            homePage.AssertCorrectPageIsLoaded();
            homePage.AssertWebBannerIsDisplayed();
            ScrollDown(driver, 250);
            homePage.SelectCategoryAndSubCategory(categoryName, "");
            switch (categoryName)
            {
                case "WOMEN":
                    homePage.AssertWomenCategoryIsDisplayed();
                    break;
                case "MEN":
                    homePage.AssertMenCategoryIsDisplayed();
                    break;
                case "KIDS":
                    homePage.AssertKidsCategoryIsDisplayed();
                    break;
                default:
                    break;
            }
            
        }
        [Test, Order(5)]
        public void VerifyNumberOfBrandProductIsSameAsBrandProductCount()
        {
            homePage.Open();
            homePage.AssertCorrectPageIsLoaded();
            homePage.AssertWebBannerIsDisplayed();
            ScrollDown(driver, 500);
            homePage.AssertBrandProductCountAndDisplayedBrandProductsAreTheSame(Brands.Biba);
        }
        [Test, Order(6)]
        public void VerifySuccessfullSubscribe()
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
                case "":
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
        [TestCase("Video Tutorials")]
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
                    homePage.AssertTestCasesNavigationLinkOpenCorrectPage();
                    break;
                case "API Testing":
                    homePage.ClickOnElement(homePage.apiTestingLink);
                    AdverticeHelper.CheckForAdvertice(driver);
                    homePage.AssertAPITestingNavigationLinkOpenCorrectPage();
                    break;
                case "Video Tutorials":
                    homePage.ClickOnElement(homePage.videoTutorialsLink);
                    YTConsentPageHelper.CheckForYYConsentPage(driver);
                    homePage.AssertVideoTutorialsNavigationLinkOpenCorrectPage();
                    break;
                case "Contact us":
                    homePage.ClickOnElement(homePage.contactusLink);
                    homePage.AssertContactUsNavigationLinkOpenCorrectPage();
                    break;
            }
        }
    }
}
