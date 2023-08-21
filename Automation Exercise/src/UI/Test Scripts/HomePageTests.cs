using Automation_Exercise.src.UI.TestData;
using Automation_Exercise.src.UI.Utilities;
using Automation_Exercise.Utilities;

namespace Automation_Exercise.Test_Scripts
{
    [TestFixture]
    [Order(1)]
    public class HomePageTests : BaseTest
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            suiteTest = extent.CreateTest("Home Page Tests");
        }
        [SetUp]
        public void Preconditions()
        {
            homePage.Open();
            homePage.AssertCorrectPageIsLoaded();
            homePage.AssertWebBannerIsDisplayed();
        }

        [Test, Order(1)]
        public void VerifyNavigationLinksArePresentAndFunctioningCorrectly()
        {
            test = suiteTest.CreateNode("Test All navigation links are displayed and works correct");
            ExceptionHandler.HandleException(() =>
            {
                homePage.AssertNavigationLinksArePresent();
            });
        }
        [Test, Order(2)]
        [TestCaseSource(typeof(HomePageTestCases), nameof(HomePageTestCases.CarouselArrowCases))]
        public void VerifyClickingOnArrowsSwitchCarouselContentImageAndActiveIndicator(string side)
        {
            test = suiteTest.CreateNode("Test Using side arrows works correctly");
            ExceptionHandler.HandleException(() =>
            {
                homePage.AssertCorrectPageIsLoaded();
                homePage.AssertWebBannerIsDisplayed();
                homePage.ClickOnArrow(side);
                homePage.AssertCorrectCarouselTextsAreDisplayed();
                homePage.AssertImageSwitched();
                homePage.AssertActiveIndicatorSwitched();
            });
        }
        [Test, Order(3)]
        [TestCaseSource(typeof(HomePageTestCases), nameof(HomePageTestCases.CarouselIndicatorsCases))]
        public void VerifyClickingOnIndicatorsSwitchCarouselContentImageAndActiveIndicator(string indicator)
        {
            test = suiteTest.CreateNode("Test Using indicators works correctly");
            ExceptionHandler.HandleException(() =>
            {
                homePage.ClickOnIndicators(indicator);
                homePage.AssertCorrectCarouselTextsAreDisplayed();
                homePage.AssertImageSwitched();
                homePage.AssertActiveIndicatorSwitched();
            });
        }
        [Test, Order(4)]
        [TestCaseSource(typeof(ProductTestCases), nameof(ProductTestCases.CategoryCases))]
        public void VerifyCategoryAndSubcategoryAreLoaded(string categoryName)
        {
            test = suiteTest.CreateNode("Test All category and subcategory are displayed");
            ExceptionHandler.HandleException(() =>
            {
                ScrollDown(driver, 660);
                homePage.SelectCategoryAndSubCategory(categoryName, null);
                switch (categoryName)
                {
                    case "WOMEN":
                        homePage.ClickOnElement(homePage.womenCategory);
                        homePage.AssertWomenCategoryAndSubCategoriesAreDisplayed();
                        break;
                    case "MEN":
                        homePage.ClickOnElement(homePage.menCategory);
                        homePage.AssertMenCategoryAndSubCategoriesAreDisplayed();
                        break;
                    case "KIDS":
                        homePage.ClickOnElement(homePage.kidsCategory);
                        homePage.AssertKidsCategoryAndSubCategoriesAreDisplayed();
                        break;
                    default:
                        Assert.Fail("Wrong category name");
                        break;
                }
            });

        }
        [Test, Order(5)]
        [TestCaseSource(typeof(ProductTestCases), nameof(ProductTestCases.BrandCases))]
        public void VerifyNumberOfBrandProductIsSameAsBrandProductCount(Brands brandName)
        {
            test = suiteTest.CreateNode("Test Number of BrandProducts is same as BrandProducts count");
            ExceptionHandler.HandleException(() =>
            {
                ScrollDown(driver, 1200);
                homePage.AssertBrandProductCountAndDisplayedBrandProductsAreTheSame(brandName);
            });
        }
        [Test, Order(6)]
        public void VerifySuccessfulSubscribe()
        {
            test = suiteTest.CreateNode("Test Subscribe With Valid Credential");
            ExceptionHandler.HandleException(() =>
            {
                ScrollToBottom(driver);
                homePage.Subscrible(Constants.email);
                homePage.ClickOnSubscribeButton();
                homePage.AssertCorrectSuccessfulSubscribeMessageIsDisplayed();
            });
        }
        [Test, Order(7)]
        [TestCaseSource(typeof(SubscribeTestCases), nameof(SubscribeTestCases.InvalidSubscribeCases))]
        public void VerifySubscribeWithInvalidEmail(string email)
        {
            test = suiteTest.CreateNode("Test Subscribe With Invalid Credential");
            ExceptionHandler.HandleException(() =>
            {
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
            });
        }
        [TestCaseSource(typeof(HeaderTestCases), nameof(HeaderTestCases.NavigationLinksCases))]
        public void VerifyNavigationLinksNavigateToCorrectPage(string pageName)
        {
            test = suiteTest.CreateNode("Test All navigation links navigate user to correct pages");
            ExceptionHandler.HandleException(() =>
            {
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
                    //    YTConsentPageHelper.CheckForYYConsentPage(driver);
                    //    homePage.AssertVideoTutorialsNavigationLinkOpenCorrectPage();
                    //    break;
                    case "Contact us":
                        homePage.ClickOnElement(homePage.contactusLink);
                        homePage.AssertContactUsNavigationLinkOpenCorrectPage();
                        break;
                }
            });
        }
        [Test, Order(9)]
        [TestCaseSource(typeof(ProductTestCases), nameof(ProductTestCases.CategoryAndSubcategoryCases))]
        public void VerifyCorrectProductFromSubCategoryAreLoaded(string categoryName, string subCategoryName)
        {
            test = suiteTest.CreateNode("Test Subscribe With Valid Credential");
            ExceptionHandler.HandleException(() =>
            {
                ScrollDown(driver, 600);
                homePage.SelectCategoryAndSubCategory(categoryName, subCategoryName);
                homePage.AssertCorrectProductSubCategoryTitleIsDisplayed(categoryName, subCategoryName);
            });
        }
        [Test, Order(10)]
        public void VerifyScrollDownFuncionallity()
        {
            test = suiteTest.CreateNode("Test Scrolldown fuctionallity of page");
            ExceptionHandler.HandleException(() =>
            {
                ScrollToBottom(driver);
                homePage.AssertCopyRightTextIsDisplayed();
            });
        }
        [Test, Order(11)]
        public void VerifyScrollUpFuncionallity()
        {
            test = suiteTest.CreateNode("Test Scrollup fuctionallity of page");
            ExceptionHandler.HandleException(() =>
            {
                homePage.Open();
                homePage.AssertCorrectPageIsLoaded();
                homePage.AssertWebBannerIsDisplayed();
                ScrollToBottom(driver);
                homePage.AssertCorrectCarouselTextsAreDisplayed();
            });
        }
        [Test, Order(12)]
        [TestCaseSource(typeof(ProductTestCases), nameof(ProductTestCases.ProductCases))]
        public void VerifyOpenProductDetailsPage(string productName)
        {
            test = suiteTest.CreateNode("Test Open detailspage of product");
            ExceptionHandler.HandleException(() =>
            {
                ScrollDown(driver, 600);
                homePage.ClickOnViewProduct(productName);
                AdverticeHelper.CheckForAdvertice(driver);
                productDetailsPage.AssertCorrectPageIsLoaded();
                productDetailsPage.AssertCorrectProductName(productName);
            });
        }
    }
}
