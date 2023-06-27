using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Exercise.Pages
{
    public class DeleteAccountPage : BasePage
    {
        public DeleteAccountPage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageURL => "https://www.automationexercise.com/delete_account";
        public IWebElement accountDeleteMsg => driver.FindElement(By.XPath("//h2[@data-qa='account-created']"));
        public IWebElement continueButton => driver.FindElement(By.XPath("//a[@data-qa='continue-button']"));
        public IWebElement firstAccountDeletedSuccessfullMsg => driver.FindElement(By.XPath("//*[contains(text(), 'deleted!')]"));
    }
}
