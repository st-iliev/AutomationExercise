using OpenQA.Selenium;
using File = System.IO.File;

namespace Automation_Exercise.Pages.PaymentDonePage
{
    public partial class PaymentDonePage : BasePage
    {
        public PaymentDonePage(IWebDriver driver) : base(driver)
        {
            
        }
        public override string PageURL => "https://www.automationexercise.com/payment_done/";
        public string GeneratePageUrl(int totalAmount) => $"https://www.automationexercise.com/payment_done/{totalAmount}";
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
