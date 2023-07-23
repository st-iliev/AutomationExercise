using Automation_Exercise.Utilities;

namespace Automation_Exercise.Test_Scripts
{
    [TestFixture]
    [Order(3)]
    public class CartPageTest : BaseTest
    {
        [Test, Order(1)]
        public void VerifyUserCartIsEmptyWithoutLogin()
        {
            homePage.Open();
            homePage.AssertUserIsLogout();
            cartPage.Open();
            cartPage.AssertCorrectPageIsLoaded();
            cartPage.AssertCorrectEmptyCartMessageIsDisplayed();
        }
        [Test, Order(2)]
        public void VerifyUserCanAddProductToCartWithoutLogin()
        {
            cartPage.Open();
            cartPage.AssertCorrectPageIsLoaded();
            cartPage.AssertCorrectEmptyCartMessageIsDisplayed();
            cartPage.ContinueToProductPage();
            AdverticeHelper.CheckForAdvertice(driver);
            productPage.AssertCorrectPageIsLoaded();
            ScrollDown(driver, 250);
            productPage.AddProductToCart("Blue Top");
            productPage.AssertProductAddedSuccessfulTextIsDisplayed();
            productPage.OpenCart();
            cartPage.AssertCorrectPageIsLoaded();
            cartPage.AssertProductIsAddedToCart("Blue Top");
        }
        [Test, Order(3)]
        public void VerifyUserCantCheckoutWithoutLogin()
        {
            productPage.Open();
            productPage.AssertCorrectPageIsLoaded();
            ScrollDown(driver, 250);
            productPage.AddProductToCart("Blue Top");
            productPage.AssertProductAddedSuccessfulTextIsDisplayed();
            productPage.OpenCart();
            cartPage.AssertCorrectPageIsLoaded();
            cartPage.AssertProductListIsNotEmpty();
            cartPage.ContinueToCheckout();
            cartPage.AssertCorrectLoginToAccoutMessageIsDisplayed();
            cartPage.ContinueOnCart();
        }
        [Test, Order(4)]
        public void VerifyUserCanRemoveProductFromCartWithoutLogin()
        {
            cartPage.Open();
            cartPage.AssertCorrectPageIsLoaded();
            cartPage.RemoveProductFromOrder("Blue Top");
            cartPage.CheckProductRemoval("Blue Top");
        }
        [Test, Order(5)]
        public void VerifyLoginUserCartIsEmpty()
        {
            loginPage.Open();
            loginPage.FillLoginForm(Constants.email, Constants.password);
            loginPage.ClickOnLoginButton();
            cartPage.Open();
            cartPage.AssertCorrectPageIsLoaded();
            cartPage.AssertCorrectEmptyCartMessageIsDisplayed();
        }
       
        [Test, Order(6)]
        public void VerifyLoginUserCanAddProductToCart()
        {
            cartPage.Open();
            cartPage.AssertCorrectPageIsLoaded();
            cartPage.AssertCorrectEmptyCartMessageIsDisplayed();
            cartPage.ContinueToProductPage();
            AdverticeHelper.CheckForAdvertice(driver);
            productPage.AssertCorrectPageIsLoaded();
            ScrollDown(driver, 250);
            productPage.AddProductToCart("Blue Top");
            productPage.AssertProductAddedSuccessfulTextIsDisplayed();
            productPage.OpenCart();
            cartPage.AssertCorrectPageIsLoaded();
            cartPage.AssertProductIsAddedToCart("Blue Top");
        }
        [Test, Order(7)]
        public void VerifyLoginUserCanCheckout()
        {
            productPage.Open();
            productPage.AssertCorrectPageIsLoaded();
            ScrollDown(driver, 250);
            productPage.AddProductToCart("Blue Top");
            productPage.AssertProductAddedSuccessfulTextIsDisplayed();
            productPage.OpenCart();
            cartPage.AssertCorrectPageIsLoaded();
            cartPage.AssertProductListIsNotEmpty();
            cartPage.ContinueToCheckout();
            checkoutPage.AssertCorrectPageIsLoaded();
        }
        [Test, Order(8)]
        public void VerifyLoginUserCanRemoveProductFromCart()
        {
            cartPage.Open();
            cartPage.AssertCorrectPageIsLoaded();
            cartPage.RemoveProductFromOrder("Blue Top");
            cartPage.CheckProductRemoval("Blue Top");
        }
        
        [Test, Order(9)]
        public void VerifyTotalPriceOfAllAddedProductsAreCorrect()
        {
            productPage.Open();
            productPage.AssertCorrectPageIsLoaded();
            ScrollDown(driver, 350);
            productPage.AddProductToCart("Men Tshirt");
            productPage.ContinueToShopping();
            productPage.AddProductToCart("Blue Top");
            productPage.ContinueToShopping();
            productPage.AddProductToCart("Sleeveless Dress");
            productPage.AssertProductAddedSuccessfulTextIsDisplayed();
            productPage.OpenCart();
            cartPage.AssertCorrectPageIsLoaded();
            var productNames = cartPage.GetNameOfAllAddedProducts();
            foreach (var product in productNames)
            {
                cartPage.AssertTotalPriceOfProductIsCorrect(product);
            }
        }
        [Test, Order(10)]
        public void VerifyLoginUserCanRemoveAllProductFromCart()
        {
            cartPage.Open();
            cartPage.AssertCorrectPageIsLoaded();
            cartPage.RemoveAllProductFromOrder();
            cartPage.AssertCorrectEmptyCartMessageIsDisplayed();
            cartPage.ContinueToProductPage();
            AdverticeHelper.CheckForAdvertice(driver);
            productPage.AssertCorrectPageIsLoaded();
        }
        [Test, Order(11)]
        public void VerifyTotalPriceOfAddedProductIsCorrect()
        {
            productPage.Open();
            productPage.AssertCorrectPageIsLoaded();
            ScrollDown(driver, 250);
            productPage.AddProductToCart("Blue Top");
            productPage.AssertProductAddedSuccessfulTextIsDisplayed();
            productPage.OpenCart();
            cartPage.AssertCorrectPageIsLoaded();
            ScrollDown(driver, 250);
            cartPage.AssertTotalPriceOfProductIsCorrect("Blue Top");
        }
    }
}