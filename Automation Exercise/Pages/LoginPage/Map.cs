using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Exercise.Pages.LoginPage
{
   partial class LoginPage
    {
        public IWebElement loginFormTitle => driver.FindElement(By.XPath("//*[@class='login-form']/h2"));
        public IWebElement loginEmailField => driver.FindElement(By.XPath("//input[@data-qa='login-email']"));
        public IWebElement loginPasswordField => driver.FindElement(By.XPath("//input[@data-qa='login-password']"));
        public IWebElement loginButton => driver.FindElement(By.XPath("//button[@data-qa='signup-button']"));
        public IWebElement errorLoginMessage => driver.FindElement(By.XPath("//form[@action='/login']/p"));
        public IWebElement signupFormTitle => driver.FindElement(By.XPath("//*[@class='signup-form']/h2"));
        public IWebElement signupNameField => driver.FindElement(By.XPath("//input[@data-qa='signup-name']"));
        public IWebElement signupEmailField => driver.FindElement(By.XPath("//input[@data-qa='signup-email']"));
        public IWebElement signupButton => driver.FindElement(By.XPath("//button[@data-qa='signup-button']"));
        public IWebElement errorSignupMessage => driver.FindElement(By.XPath("//form[@action='/signup'p"));
    }
}
