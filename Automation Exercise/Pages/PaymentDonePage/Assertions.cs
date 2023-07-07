using Automation_Exercise.Utilities;

namespace Automation_Exercise.Pages.PaymentDonePage
{
    partial class PaymentDonePage
    {
        public void AssertCorrectPageIsLoaded()
        {
            Assert.AreEqual("Automation Exercise - Order Placed", GetPageTitle());
        }
        public void AssertCorrectOrderTitleIsDisplayed()
        {
            Assert.AreEqual("ORDER PLACED!", orderPlaced.Text);
        }
        public void AssertOrderConfirmedMessageIsDisplayedCorrectly()
        {
            Assert.AreEqual(SuccessfulMessages.orderConfirmed, orderConfirmedMsg.Text);
        }
        public void AssertFileDownloadSuccessful()
        {
            Assert.IsTrue(File.Exists(Constants.downloadedFilePath), "Downloaded file does exist.");
        }
        public void AssrtFileContentIsCorrectly(int orderTotalAmount)
        {
            Assert.AreEqual(string.Format(Constants.expectedFileText,Constants.firstName,Constants.lastName, orderTotalAmount),ReadingDownloadedFile(Constants.downloadedFilePath));
        }
    }
}
