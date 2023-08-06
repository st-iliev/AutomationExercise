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

        [Test,Order(1)]
        public void VerifyNavigationLinksArePresentAndFunctioningCorrectly()
        {
            test = suiteTest.CreateNode("Test All navigation links are displayed and works correct");
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
            test = suiteTest.CreateNode("Test Using side arrows works correctly");
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
            test = suiteTest.CreateNode("Test Using indicators works correctly");
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
            test = suiteTest.CreateNode("Test All category and subcategory are displayed");
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
            test = suiteTest.CreateNode("Test Number of BrandProducts is same as BrandProducts count");
            ScrollDown(driver,1500);
            homePage.AssertBrandProductCountAndDisplayedBrandProductsAreTheSame(brandName);
        }
        [Test, Order(6)]
        public void VerifySuccessfulSubscribe()
        {
            test = suiteTest.CreateNode("Test Subscribe With Valid Credential");
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
            test = suiteTest.CreateNode("Test Subscribe With Invalid Credential");
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
            test = suiteTest.CreateNode("Test All navigation links navigate user to correct pages");
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
        [TestCase("WOMEN","DRESS")]
        [TestCase("WOMEN","TOPS")]
        [TestCase("WOMEN","SAREE")]
        [TestCase("MEN","TSHIRTS")]
        [TestCase("MEN","JEANS")]
        [TestCase("KIDS","DRESS")]
        [TestCase("KIDS","TOPS & SHIRTS")]
        public void VerifyCorrectProductFromSubCategoryAreLoaded(string categoryName , string subCategoryName)
        {
            test = suiteTest.CreateNode("Test Subscribe With Valid Credential");
            ScrollDown(driver, 600);
            homePage.SelectCategoryAndSubCategory(categoryName, subCategoryName);
            homePage.AssertCorrectProductSubCategoryTitleIsDisplayed(categoryName, subCategoryName);
        }
        [Test,Order(10)]
        public void VerifyScrollDownFuncionallity()
        {
            test = suiteTest.CreateNode("Test Scrolldown fuctionallity of page");
            ScrollToBottom(driver);
            homePage.AssertCopyRightTextIsDisplayed();
        }
        [Test,Order(11)]
        public void VerifyScrollUpFuncionallity()
        {
            test = suiteTest.CreateNode("Test Scrollup fuctionallity of page");
            homePage.Open();
            homePage.AssertCorrectPageIsLoaded();
            homePage.AssertWebBannerIsDisplayed();
            ScrollToBottom(driver);
            homePage.AssertCorrectCarouselTextsAreDisplayed();
        }
        [Test, Order(12)]
        [TestCase("Sleeveless Dress")]
        [TestCase("Men Tshirt")]
        [TestCase("Blue Top")]
        public void VerifyOpenProductDetailsPage(string productName)
        {
            test = suiteTest.CreateNode("Test Open detailspage of product");
            ScrollDown(driver, 600);
            homePage.ClickOnViewProduct(productName);
            AdverticeHelper.CheckForAdvertice(driver);
            productDetailsPage.AssertCorrectPageIsLoaded();
            productDetailsPage.AssertCorrectProductName(productName);
        }
    }
}
