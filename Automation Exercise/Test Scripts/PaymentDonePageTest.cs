using Automation_Exercise.Pages.PaymentPage;
using Automation_Exercise.Utilities;

namespace Automation_Exercise.Test_Scripts
{
    [TestFixture]
    [Order(7)]
    internal class PaymentDonePageTest : BaseTest
    {
        private CardInfo cardInfo;
        [Test, Order(1)]
        public void VerifyDownloadAndCheckContentOfInvoiceFile()
        {
            loginPage.Open();
            loginPage.AssertCorrectPageIsLoaded();
            loginPage.AssertCorrectLoginFormTitleIsDisplayed();
            loginPage.FillLoginForm(Constants.email, Constants.password);
            loginPage.ClickOnLoginButton();
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
            paymentDonePage.DownloadInvoice();
            AdverticeHelper.CheckForAdvertice(driver);
            paymentDonePage.AssertFileDownloadSuccessful();
            paymentDonePage.AssertFileContentIsCorrectly();
            paymentDonePage.DeleteDownloadedFile();
            BackToPreviusPage(driver);
            paymentDonePage.ContinueOrder();
            homePage.AssertCorrectPageIsLoaded();
        }
        [Test, Order(2)]
        public void VerifyCompleteOrderWihtoutAddedProduct()
        {
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
