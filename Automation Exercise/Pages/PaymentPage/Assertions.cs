using Automation_Exercise.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Exercise.Pages.PaymentPage
{
    partial class PaymentPage
    {
        public void AssertCorrectPageIsLoaded()
        {
            Assert.AreEqual("Automation Exercise - Payment", GetPageTitle());
        }
        public void AssertCorrectPaymentTitleIsDisplayed()
        {
            Assert.AreEqual("Payment", paymentTitle.Text);
        }
        public void AssertCorrectSuccessfulOrderMessageIsDisplayed()
        {
            Assert.AreEqual(SuccessfulMessages.successfulOrder, successfulOrderMsg.Text);
        }
    }
}
