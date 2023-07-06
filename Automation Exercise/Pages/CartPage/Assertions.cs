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
    }
}
