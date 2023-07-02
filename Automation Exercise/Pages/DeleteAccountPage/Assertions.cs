using Automation_Exercise.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Exercise.Pages.DeleteAccountPage
{
    partial class DeleteAccountPage
    {
        public void AssertCorrectPageIsLoaded()
        {
            Assert.AreEqual("Automation Exercise - Account Created", GetPageTitle());
        }
        public void AssertAccountDeleteMessageIsDisplayedCorrectly()
        {
            Assert.AreEqual("ACCOUNT DELETED!", accountDeleteMsg.Text);
        }
        public void AssertAccountDeletedSuccessfullMessageIsDisplayedCorrectly()
        {
            Assert.AreEqual(SuccessfulMessages.accountDeleted, accountDeleteMsg.Text);
        }
        public void AssertSecondAccountDeletedSuccessfullMessageIsDisplayedCorrectly()
        {
            Assert.AreEqual(SuccessfulMessages.secondAccountDeleted, secondAccountDeletedSuccessfullMsg.Text);
        }
        public void AsserCountinueButtonIsDisplayed()
        {
            Assert.True(continueButton.Displayed);
        }
    }
}
