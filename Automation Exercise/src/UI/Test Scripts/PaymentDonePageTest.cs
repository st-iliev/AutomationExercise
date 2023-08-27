using Automation_Exercise.Pages.PaymentPage;
using Automation_Exercise.src.UI.TestData;
using Automation_Exercise.Utilities;

namespace Automation_Exercise.Test_Scripts
{
    [TestFixture]
    [Order(8)]
    internal class PaymentDonePageTest : BaseTest
    {
        private CardInfo cardInfo;
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            suiteTest = extent.CreateTest("PaymentDone Page Tests");
            UserLogin();
        }
        [Test, Order(1)]
        public void VerifyDownloadAndCheckContentOfInvoiceFile()
        {
            test = suiteTest.CreateNode("Test Download and check content of invoice file.");
            productPage.Open();
            ScrollDown(driver, 500);
            productPage.AddProductToCart("Blue Top");
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
            paymentDonePage.AssertCorrectOrderTitleIsDisplayed();
            paymentDonePage.AssertOrderConfirmedMessageIsDisplayedCorrectly();
            paymentDonePage.DeleteDownloadedFile();
            paymentDonePage.DownloadInvoice();
            AdverticeHelper.CheckForAdvertice(driver);
            //paymentDonePage.AssertFileDownloadSuccessful(); //Change it to your browser download location.
            //paymentDonePage.AssertFileContentIsCorrectly();
            BackToPreviusPage(driver);
            paymentDonePage.ContinueOrder();
            homePage.AssertCorrectPageIsLoaded();
        }
        [Test, Order(2)]
        public void VerifyCompleteOrderWihtoutAddedProduct()
        {
            test = suiteTest.CreateNode("Test Complete order without added product.");
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
            AdverticeHelper.CheckForAdvertice(driver);
            paymentDonePage.AssertCorrectOrderTitleIsDisplayed();
            paymentDonePage.AssertOrderConfirmedMessageIsDisplayedCorrectly();
            paymentDonePage.ContinueOrder();
            homePage.AssertCorrectPageIsLoaded();
        }
        [Test, Order(3)]
        public void VerifySuccessfulSubscribe()
        {
            test = suiteTest.CreateNode("Test Search For Existing Product");
            ScrollToBottom(driver);
            homePage.Subscrible(Constants.email);
            homePage.ClickOnSubscribeButton();
            homePage.AssertCorrectSuccessfulSubscribeMessageIsDisplayed();
        }
        [Test, Order(4)]
        [TestCaseSource(typeof(SubscribeTestCases), nameof(SubscribeTestCases.InvalidSubscribeCases))]
        public void VerifySubscribeWithInvalidEmail(string email)
        {
            test = suiteTest.CreateNode("Test Subscribe With Invalid Credential");
            ScrollToBottom(driver);
            homePage.ClearSubscrible();
            homePage.Subscrible(email);
            homePage.ClickOnSubscribeButton();
            switch (email)
            {
                case null:
                    homePage.AssertErrorEmptyFieldMessageIsDisplayed(homePage.subscribeField); break;
                case "invalidEmail":
                    homePage.AssertErrorInvalidEmailAddressMessageIsDisplayed(homePage.subscribeField, email); break;
                case "invalidEmail@":
                    homePage.AssertErrorIncompleteEmailAddressMessageIsDisplayed(homePage.subscribeField, email); break;
            };
        }
    }
}
