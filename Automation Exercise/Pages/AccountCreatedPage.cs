using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Automation_Exercise.Pages
{
    internal class AccountCreatedPage: BasePage
    {
        public AccountCreatedPage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageURL => "https://www.automationexercise.com/account_created";
        public IWebElement accountCreatedMsg => driver.FindElement(By.XPath("//h2[@data-qa='account-created']"));
        public IWebElement continueButton => driver.FindElement(By.XPath("//a[@data-qa='continue-button']"));
        public IWebElement accountCreatedSuccessfullMsg => driver.FindElement(By.XPath("//p[contains(text(), 'Congratulations!')]"));

        
    }
}
