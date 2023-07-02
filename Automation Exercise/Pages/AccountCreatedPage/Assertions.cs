using Automation_Exercise.Utilities;

namespace Automation_Exercise.Pages.AccountCreatedPage
{
    partial class AccountCreatedPage
    {
        public void AssertCorrectPageIsLoaded()
        {
            Assert.AreEqual("Automation Exercise - Account Created", GetPageTitle());
        }
        public void AssertAccountCreatedMessageIsDisplayedCorrectly()
        {
            Assert.AreEqual("ACCOUNT CREATED!", accountCreatedMsg.Text);
        }
        public void AssertAccountCreatedSuccessfullMessageIsDisplayedCorrectly()
        {
            Assert.AreEqual(SuccessfulMessages.accountCreated, accountCreatedSuccessfullMsg.Text);
        }
        public void AssertSecondAccountCreatedSuccessfullMessageIsDisplayedCorrectly()
        {
            Assert.AreEqual(SuccessfulMessages.accountCreated, accountCreatedSuccessfullMsg.Text);
        }
        public void AsserCountinueButtonIsDisplayed()
        {
            Assert.True(continueButton.Displayed);
        }

    }
}
