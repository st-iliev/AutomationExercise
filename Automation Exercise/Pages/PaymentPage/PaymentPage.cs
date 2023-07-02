using Automation_Exercise.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Exercise.Pages.PaymentPage
{
    public partial class PaymentPage : BasePage
    {
        public PaymentPage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageURL => "https://www.automationexercise.com/payment";
       public void FillPaymentForm(CardInfo cardInfo)
        {
            nameOnCardField.SendKeys(cardInfo.NameOnCard);
            cardNumberField.SendKeys(cardInfo.CardNumber);
            cvcField.SendKeys(cardInfo.CVC);
            expirationMonthField.SendKeys(cardInfo.ExpirationMonth);
            expirationYearField.SendKeys(cardInfo.ExpirationYear);
        }
        public void PayAndConfirmOrder() => payOrderButton.Click();
    }
}
