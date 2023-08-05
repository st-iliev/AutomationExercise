using Automation_Exercise.src.UI.Pages.PaymentPage;
using Automation_Exercise.Utilities;

namespace Automation_Exercise.Test_Scripts
{
    [TestFixture]
    [Order(7)]
    public class PaymentPageTest : BaseTest
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            suiteTest = extent.CreateTest("Payment Page Tests");
            loginPage.Open();
            loginPage.AssertCorrectPageIsLoaded();
            loginPage.AssertCorrectLoginFormTitleIsDisplayed();
            loginPage.FillLoginForm(Constants.email, Constants.password);
            loginPage.ClickOnLoginButton();
        }
        private CardInfo cardInfo;
        [Test, Order(1)]
        public void VerifySuccessfulPaymentWithValidData()
        {
            test = suiteTest.CreateNode("Test Payment With Valid Credentials");
            paymentPage.Open();
            paymentPage.AssertCorrectPageIsLoaded();
            paymentPage.AssertCorrectPaymentTitleIsDisplayed();
            paymentPage.AssertCorrectPaymentFormIsDisplayed();
            cardInfo = new CardInfo()
            {
                NameOnCard = $"{Constants.firstName} {Constants.lastName}",
                CardNumber = Constants.cardNumber,
                CVC = Constants.CVC,
                ExpirationMonth = Constants.expirationMonth,
                ExpirationYear = Constants.expirationYear,
            };
            paymentPage.FillPaymentForm(cardInfo);
            paymentPage.ClickOnPayOrder();
            paymentDonePage.AssertOrderConfirmedMessageIsDisplayedCorrectly();
        }
        [Test,Order(2)]
        [TestCase("", "" , "" , "", "")]
        [TestCase("name", "" , "" , "", "")]
        [TestCase("name", "number" , "" , "", "")]
        [TestCase("name", "number" , "cvc" , "", "")]
        [TestCase("name", "number" , "cvc" , "month", "")]
        public void VerifyPaymentFormHaveValidationFromEmptyField(string nameOfCard,string cardNumber,string cvc,string month,string year)
        {
            test = suiteTest.CreateNode("Test Payment With Valid Credentials");
            paymentPage.Open();
            paymentPage.AssertCorrectPageIsLoaded();
            paymentPage.AssertCorrectPaymentTitleIsDisplayed();
            paymentPage.AssertCorrectPaymentFormIsDisplayed();
            cardInfo = new CardInfo()
            {
                NameOnCard = nameOfCard,
                CardNumber = cardNumber,
                CVC = cvc,
                ExpirationMonth = month,
                ExpirationYear = year
            };
            paymentPage.FillPaymentForm(cardInfo);
            paymentPage.ClickOnPayOrder();
            if (nameOfCard == "")
            {
            paymentPage.AssertErrorEmptyFieldMessageIsDisplayed(paymentPage.nameOnCardField);
            }
            if (cardNumber == "")
            {
                paymentPage.AssertErrorEmptyFieldMessageIsDisplayed(paymentPage.cardNumberField);
            }
            if (cvc == "")
            {
                paymentPage.AssertErrorEmptyFieldMessageIsDisplayed(paymentPage.cvcField);
            }
            if (month == "")
            {
                paymentPage.AssertErrorEmptyFieldMessageIsDisplayed(paymentPage.expirationMonthField);
            }
            if (year == "")
            {
                paymentPage.AssertErrorEmptyFieldMessageIsDisplayed(paymentPage.expirationYearField);
            }
        }
        
    }
}
