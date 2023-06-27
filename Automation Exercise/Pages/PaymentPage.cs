using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Exercise.Pages
{
    public class PaymentPage : BasePage
    {
        public PaymentPage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageURL => "https://www.automationexercise.com/payment";
        public IWebElement nameOnCardField => driver.FindElement(By.XPath("//input[@data-qa='name-on-card']"));
        public IWebElement cardNumberField => driver.FindElement(By.XPath("//input[@data-qa='card-number']"));
        public IWebElement cvcField => driver.FindElement(By.XPath("//input[@data-qa='cvc']"));
        public IWebElement expirationMonthField => driver.FindElement(By.XPath("//input[@data-qa='expiry-month']"));
        public IWebElement expirationYearField => driver.FindElement(By.XPath("//input[@data-qa='expiry-year']"));
        public IWebElement payOrderButton => driver.FindElement(By.XPath("//button[@data-qa='pay-button']"));
        public IWebElement successfullyOrder => driver.FindElement(By.XPath("//*[@class='alert-success alert']"));
    }
}
