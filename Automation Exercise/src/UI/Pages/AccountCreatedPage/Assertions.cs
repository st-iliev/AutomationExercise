using Automation_Exercise.Utilities;

namespace Automation_Exercise.Pages.AccountCreatedPage
{
    partial class AccountCreatedPage
    {
        public void AssertCorrectPageIsLoaded()
        {
            Assert.AreEqual("Automation Exercise - Account Created", GetPageTitle());
        }
        public void AssertAccountCreatedTitleIsDisplayedCorrectly()
        {
            Assert.AreEqual("ACCOUNT CREATED!", accountCreatedMsg.Text);
        }
        public void AssertFirstSuccessfullMessageIsDisplayedCorrectly()
        {
            Assert.AreEqual(SuccessfulMessages.accountCreated, accountCreatedSuccessfullMsg.Text);
        }
        public void AssertSecondSuccessfullMessageIsDisplayedCorrectly()
        {
            Assert.AreEqual(SuccessfulMessages.secondAccountCreated, secondAccountCreatedSuccessfullMsg.Text);
        }
        public void AsserCountinueButtonIsDisplayed()
        {
            Assert.True(continueButton.Displayed);
        }

    }
}
