using Automation_Exercise.Utilities;

namespace Automation_Exercise.Pages.AccountCreatedPage
{
    partial class AccountCreatedPage
    {
        public void AssertCorrectPageIsLoade()
        {
            Assert.AreEqual("Automation Exercise - Account Created", GetPageTitle());
        }
        public void AssertAccountCreatedMessageIsDisplayedCorrectly()
        {
            Assert.AreEqual("ACCOUNT CREATED!", accountCreatedMsg.ToString());
        }
        public void AssertAccountCreatedSuccessfullMessageIsDisplayedCorrectly()
        {
            Assert.AreEqual(SuccessfulMessages.accountCreated, accountCreatedSuccessfullMsg.ToString());
        }
        public void AssertSecondAccountCreatedSuccessfullMessageIsDisplayedCorrectly()
        {
            Assert.AreEqual(SuccessfulMessages.accountCreated, accountCreatedSuccessfullMsg.ToString());
        }
        public void AsserCountinueButtonIsDisplayed()
        {
            Assert.True(continueButton.Displayed);
        }

    }
}
