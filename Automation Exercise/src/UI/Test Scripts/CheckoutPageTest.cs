using Automation_Exercise.src.UI.Utilities;
using Automation_Exercise.Utilities;

namespace Automation_Exercise.Test_Scripts
{
    [TestFixture]
    [Order(10)]
    public class CheckoutPageTest : BaseTest
    {
        [OneTimeSetUp]
        public void Preconditions()
        {
            suiteTest = extent.CreateTest("Checkout Page Tests");
            loginPage.Open();
            loginPage.FillLoginForm(Constants.email, Constants.password);
            loginPage.loginButton.Click();
        }
      
        [Test,Order(1)]
        public void VerifyAddedProductIsInOrder()
        {
            test = suiteTest.CreateNode("Test Added product is in order.");
            ExceptionHandler.HandleException(() =>
            {
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
            });
        }
        [Test, Order(2)]
        public void VerifySuccessfullyFinishedOrder()
        {
            test = suiteTest.CreateNode("Test User finish order.");
            ExceptionHandler.HandleException(() =>
            {
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
            });
        }
        [Test, Order(3)]
        public void VerifyInformationAboutDeliveryAndBillingAddressesAreDisplayedCorrect()
        {
            test = suiteTest.CreateNode("Test Information about delivery and billing adresses are displayed correctly ");
            ExceptionHandler.HandleException(() =>
            {
                productPage.Open();
                ScrollDown(driver, 500);
                productPage.AddProductToCart("Blue Top");
                productPage.OpenCart();
                cartPage.ContinueToCheckout();
                checkoutPage.AssertCorrectPageIsLoaded();
                checkoutPage.AssertBillingAddressFormIsFilledCorrectly();
                checkoutPage.AssertDeliveryAddressFormIsFilledCorrectly();
            });
        }

    }

}
