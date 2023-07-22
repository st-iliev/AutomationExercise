using Automation_Exercise.Utilities;

namespace Automation_Exercise.Test_Scripts
{
    [TestFixture]
    [Order(9)]
    public class CheckoutPageTest : BaseTest
    {
        [Test,Order(1)]
        public void VerifyInformationAboutDeliveryAndBillingAdressesAreDisplayedCorrect()
        {
            loginPage.Open();
            loginPage.FillLoginForm(Constants.email, Constants.password);
            loginPage.loginButton.Click();
            productPage.Open();
            ScrollDown(driver, 500);
            productPage.AddProductToCart("Blue Top");
            productPage.OpenCart();
            cartPage.ContinueToCheckout();
            checkoutPage.AssertCorrectPageIsLoaded();
            checkoutPage.AssertBillingAddressFormIsFilledCorrectly();
            checkoutPage.AssertDeliveryAddressFormIsFilledCorrectly();
        }
        [Test,Order(2)]
        public void VerifyAddedProductIsInYourOrder()
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
        }
        [Test, Order(3)]
        public void VerifySuccessfullyFinishedOrder()
        {
            cartPage.Open();
            cartPage.RemoveAllProductFromOrder();
            productPage.Open();
            ScrollDown(driver, 500);
            productPage.AddProductToCart("Sleeveless Dress");
            productPage.OpenCart();
            cartPage.ContinueToCheckout();
            checkoutPage.AssertCorrectPageIsLoaded();
            ScrollDown(driver, 500);
            checkoutPage.AssertProductIsInOrder("Sleeveless Dress");
            checkoutPage.AssertCorrectTotalPriceOfProductIsCalculation("Sleeveless Dress");
            checkoutPage.AssertCorrectTotalPriceOfOrderIsCalculation();
            checkoutPage.WriteCommentMessage("Test");
            ScrollDown(driver, 250);
            checkoutPage.PlaceOrder();
            AdverticeHelper.CheckForAdvertice(driver);
            paymentPage.AssertCorrectPageIsLoaded();
        }

    }

}
