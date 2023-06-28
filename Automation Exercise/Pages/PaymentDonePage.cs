using OpenQA.Selenium;


namespace Automation_Exercise.Pages
{
    public class PaymentDonePage : CheckoutPage
    {
        public PaymentDonePage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement orderPlaced => driver.FindElement(By.XPath("//h2[@data-qa='order-placed']"));
        public IWebElement continueButton => driver.FindElement(By.XPath("//*[@data-qa='continue-button']"));
        public IWebElement downloadInvoiceButton => driver.FindElement(By.XPath("//*[contains(@href, '/download_invoice/')]"));
        
    }
}
