using Automation_Exercise.src.UI.TestCases_Data;
using Automation_Exercise.Utilities;

namespace Automation_Exercise.Test_Scripts
{
    [TestFixture]
    [Order(10)]
    public class CheckoutPageTest : BaseTest
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            suiteTest = extent.CreateTest("Checkout Page Tests");
            UserLogin();
        }

        [Test, Order(1)]
        public void VerifyAddedProductIsInOrder()
        {
            test = suiteTest.CreateNode("Test Added product is in order.");
            productPage.Open();
            ScrollDown(driver, 500);
            productPage.AddProductToCart("Men Tshirt");
            productPage.OpenCart();
            cartPage.ContinueToCheckout();
            checkoutPage.AssertCorrectPageIsLoaded();
            ScrollDown(driver, 500);
            checkoutPage.AssertProductIsInOrder("Men Tshirt");
            checkoutPage.AssertCorrectTotalPriceOfProductIsCalculation("Men Tshirt");
            checkoutPage.AssertCorrectTotalPriceOfOrderIsCalculation();
        }
        [Test, Order(2)]
        public void VerifySuccessfullyFinishedOrder()
        {
            test = suiteTest.CreateNode("Test User finish order.");
            productPage.Open();
            ScrollDown(driver, 500);
            productPage.AddProductToCart("Sleeveless Dress");
            productPage.OpenCart();
            cartPage.ContinueToCheckout();
            checkoutPage.AssertCorrectPageIsLoaded();
            ScrollDown(driver, 750);
            checkoutPage.AssertProductIsInOrder("Sleeveless Dress");
            checkoutPage.AssertCorrectTotalPriceOfProductIsCalculation("Sleeveless Dress");
            checkoutPage.AssertCorrectTotalPriceOfOrderIsCalculation();
            checkoutPage.WriteCommentMessage("Test");
            ScrollDown(driver, 250);
            checkoutPage.PlaceOrder();
            AdverticeHelper.CheckForAdvertice(driver);
            paymentPage.AssertCorrectPageIsLoaded();
        }
        [Test, Order(3)]
        public void VerifyInformationAboutDeliveryAndBillingAddressesAreDisplayedCorrect()
        {
            test = suiteTest.CreateNode("Test Information about delivery and billing adresses are displayed correctly ");
            productPage.Open();
            ScrollDown(driver, 500);
            productPage.AddProductToCart("Blue Top");
            productPage.OpenCart();
            cartPage.ContinueToCheckout();
            checkoutPage.AssertCorrectPageIsLoaded();
            checkoutPage.AssertBillingAddressFormIsFilledCorrectly();
            checkoutPage.AssertDeliveryAddressFormIsFilledCorrectly();
        }
        [Test, Order(4)]
        public void VerifyHomeButtonRedirectUserToCorrectPage()
        {
            test = suiteTest.CreateNode("Test home button redirect user to home page. ");
            checkoutPage.Open();
            checkoutPage.ClickOnHomeButton();
            homePage.AssertCorrectPageIsLoaded();
            homePage.AssertCorrectCarouselTextsAreDisplayed();
        }
        [Test, Order(5)]
        public void VerifyScrollDownFuncionallity()
        {
            test = suiteTest.CreateNode("Test Scrolldown fuctionallity of page");
            productPage.Open();
            ScrollToBottom(driver);
            homePage.AssertCopyRightTextIsDisplayed();
        }
        [Test, Order(6)]
        [TestCaseSource(typeof(ScrollFunctionalityTestCases), nameof(ScrollFunctionalityTestCases.ScrollDownHeightCases))]
        public void VerifyFunctuallityOfScrollUpButton(int height)
        {
            test = suiteTest.CreateNode("Test Functuallity of scrollup button.");
            productPage.Open();
            ScrollDown(driver, height);
            homePage.ClickOnScrollUpButton();
            homePage.AssertWebsiteLogoIsDisplayed();
        }
    }
}
