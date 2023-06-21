using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Exercise.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageURL => "https://www.automationexercise.com/login";
        public IWebElement loginEmailField => driver.FindElement(By.XPath("input[@data-qa='login-email']"));
        public IWebElement loginPasswordField => driver.FindElement(By.XPath("input[@data-qa='login-password']"));
        public IWebElement loginButton => driver.FindElement(By.XPath("button[@data-qa='signup-button']"));
        public IWebElement signupNameField => driver.FindElement(By.XPath("input[@data-qa='signup-name']"));
        public IWebElement signupEmailField => driver.FindElement(By.XPath("input[@data-qa='signup-email']"));
        public IWebElement signupButton => driver.FindElement(By.XPath("button[@data-qa='signup-button']"));
    }
}
