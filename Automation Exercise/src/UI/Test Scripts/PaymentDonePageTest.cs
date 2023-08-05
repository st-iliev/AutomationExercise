using Automation_Exercise.src.UI.Pages.PaymentPage;
using Automation_Exercise.Utilities;

namespace Automation_Exercise.Test_Scripts
{
    [TestFixture]
    [Order(8)]
    internal class PaymentDonePageTest : BaseTest
    {
        [OneTimeSetUp]
        public void Setup()
        {
            suiteTest = extent.CreateTest("PaymentDone Page Tests");
            loginPage.Open();
            loginPage.AssertCorrectPageIsLoaded();
            loginPage.AssertCorrectLoginFormTitleIsDisplayed();
            loginPage.FillLoginForm(Constants.email, Constants.password);
            loginPage.ClickOnLoginButton();
        }
        private CardInfo cardInfo;
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
            paymentDonePage.AssertFileDownloadSuccessful(); //Change it to your browser download location.
            paymentDonePage.AssertFileContentIsCorrectly();
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
            paymentDonePage.AssertCorrectOrderTitleIsDisplayed();
            paymentDonePage.AssertOrderConfirmedMessageIsDisplayedCorrectly();
            paymentDonePage.ContinueOrder();
            homePage.AssertCorrectPageIsLoaded();
        }
    }
}
