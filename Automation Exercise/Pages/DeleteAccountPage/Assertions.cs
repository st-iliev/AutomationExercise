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
        public void AssertCorrectPageIsLoade()
        {
            Assert.AreEqual("Automation Exercise - Account Created", GetPageTitle());
        }
        public void AssertAccountDeleteMessageIsDisplayedCorrectly()
        {
            Assert.AreEqual("ACCOUNT DELETED!", accountDeleteMsg.ToString());
        }
        public void AssertAccountDeletedSuccessfullMessageIsDisplayedCorrectly()
        {
            Assert.AreEqual(SuccessfulMessages.accountDeleted, accountDeleteMsg.ToString());
        }
        public void AssertSecondAccountDeletedSuccessfullMessageIsDisplayedCorrectly()
        {
            Assert.AreEqual(SuccessfulMessages.secondAccountDeleted, secondAccountDeletedSuccessfullMsg.ToString());
        }
        public void AsserCountinueButtonIsDisplayed()
        {
            Assert.True(continueButton.Displayed);
        }
    }
}
