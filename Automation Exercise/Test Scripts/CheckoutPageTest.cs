using Automation_Exercise.Utilities;

namespace Automation_Exercise.Test_Scripts
{
    [TestFixture]
    [Order(9)]
    public class CheckoutPageTest : BaseTest
    {
      
        [Test,Order(1)]
        public void VerifyAddedProductIsInOrder()
        {
            loginPage.Open();
            loginPage.FillLoginForm(Constants.email, Constants.password);
            loginPage.loginButton.Click();
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
        public void VerifyInformationAboutDeliveryAndBillingAdressesAreDisplayedCorrect()
        {
            productPage.Open();
            ScrollDown(driver, 500);
            productPage.AddProductToCart("Blue Top");
            productPage.OpenCart();
            cartPage.ContinueToCheckout();
            checkoutPage.AssertCorrectPageIsLoaded();
            checkoutPage.AssertBillingAddressFormIsFilledCorrectly();
            checkoutPage.AssertDeliveryAddressFormIsFilledCorrectly();
        }

    }

}
