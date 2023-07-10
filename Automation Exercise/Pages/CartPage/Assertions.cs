using Automation_Exercise.Utilities;

namespace Automation_Exercise.Pages.CartPage
{
    partial class CartPage
    {
        public void AssertCorrectPageIsLoaded()
        {
            Assert.AreEqual("Automation Exercise - Checkout", GetPageTitle());
        }
        public void AssertProcessToCheckoutButtonIsDisplayed()
        {
            Assert.True(proceedToCheckoutButton.Displayed);
        }
        public void AssertCorrectLoginToAccoutMessageIsDisplayed()
        {
            Assert.AreEqual(SuccessfulMessages.loginToContinueToCheckout, loginMessage.Text);
        }
        public void AssertProductListIsNotEmpty()
        {
            Assert.Greater(productList.Count,0);
        }
        public void AssertProductIsRemoved(string productName)
        {
            Assert.True(CheckProductRemoval(productName));
        }
        public void AssertCorrectEmptyCartMessageIsDisplayed()
        {
            Assert.True(emptyCartMessage.Displayed);
        }
        public void AssertProductIsAddedToCart(string productName)
        {
            Assert.True(CheckProductIsAddedToCart(productName));
        }
    }
}
