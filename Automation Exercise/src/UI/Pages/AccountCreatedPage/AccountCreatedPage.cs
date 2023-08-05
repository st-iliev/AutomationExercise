using OpenQA.Selenium;


namespace Automation_Exercise.Pages.AccountCreatedPage
{
    public partial class AccountCreatedPage : BasePage
    {
        public AccountCreatedPage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageURL => "https://www.automationexercise.com/account_created";
        
        public void ClickOnContinue() => continueButton.Click();
    }
}
