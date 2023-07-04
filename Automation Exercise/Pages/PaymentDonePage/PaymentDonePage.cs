using OpenQA.Selenium;


namespace Automation_Exercise.Pages.PaymentDonePage
{
    public partial class PaymentDonePage : CheckoutPage
    {
        public PaymentDonePage(IWebDriver driver) : base(driver)
        {
        }
        public override string PageURL => $"https://www.automationexercise.com/payment_done/{TotalOrderAmount}";
        public void DownloadInvoice() => downloadInvoiceButton.Click();
        public void ContinueOrder() => continueButton.Click(); 
        public string ReadingDownloadedFile(string filePath) => File.ReadAllText(filePath);
        public void DeleteDownloadedFile(string filePath)
        {
             if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

        }
    }
}
