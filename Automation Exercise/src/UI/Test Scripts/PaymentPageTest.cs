using Automation_Exercise.Pages.PaymentPage;
using Automation_Exercise.src.UI.TestData;
using Automation_Exercise.Utilities;

namespace Automation_Exercise.Test_Scripts
{
    [TestFixture]
    [Order(7)]
    public class PaymentPageTest : BaseTest
    {
        private CardInfo cardInfo;
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            suiteTest = extent.CreateTest("Payment Page Tests");
            UserLogin();
        }
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
        [Test, Order(2)]
        [TestCaseSource(typeof(PaymentTestCases), nameof(PaymentTestCases.FormCases))]
        public void VerifyPaymentFormHaveValidationFromEmptyField(string nameOfCard, string cardNumber, string cvc, string month, string year)
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
        [Test, Order(3)]
        public void VerifySuccessfulSubscribe()
        {
            test = suiteTest.CreateNode("Test Successful Subscribe With Valid Credentials");
            ScrollToBottom(driver);
            homePage.Subscrible(Constants.email);
            homePage.ClickOnSubscribeButton();
            homePage.AssertCorrectSuccessfulSubscribeMessageIsDisplayed();
        }
        [Test, Order(4)]
        [TestCaseSource(typeof(SubscribeTestCases), nameof(SubscribeTestCases.InvalidSubscribeCases))]
        public void VerifySubscribeWithInvalidEmail(string email)
        {
            test = suiteTest.CreateNode("Test Subscribe With Invalid Credentials");
            ScrollToBottom(driver);
            homePage.ClearSubscrible();
            homePage.Subscrible(email);
            homePage.ClickOnSubscribeButton();
            switch (email)
            {
                case "":
                    homePage.AssertErrorEmptyFieldMessageIsDisplayed(homePage.subscribeField); break;
                case "invalidEmail":
                    homePage.AssertErrorInvalidEmailAddressMessageIsDisplayed(homePage.subscribeField, email); break;
                case "invalidEmail@":
                    homePage.AssertErrorIncompleteEmailAddressMessageIsDisplayed(homePage.subscribeField, email); break;
            };
        }
        [Test, Order(5)]
        public void VerifyHomeButtonRedirectUserToCorrectPage()
        {
            test = suiteTest.CreateNode("Test home button redirect user to home page. ");
            cartPage.ClickOnHomeButton();
            homePage.AssertCorrectPageIsLoaded();
            homePage.AssertCorrectCarouselTextsAreDisplayed();
        }

    }
}
