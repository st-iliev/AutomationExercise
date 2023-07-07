using OpenQA.Selenium;

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
