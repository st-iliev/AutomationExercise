using Automation_Exercise.Utilities;
using OpenQA.Selenium;

namespace Automation_Exercise.Pages.LoginPage
{
    public partial class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }
        public override string PageURL => "https://www.automationexercise.com/login";
        public void FillSingupForm()
        {
            signupNameField.SendKeys(Constants.firstName);
            signupEmailField.SendKeys(Constants.email);
            
        }
        public void ClickOnSignupButton() => signupButton.Click();
        public void FillLoginForm()
        {
            loginEmailField.SendKeys(Constants.email);
            loginPasswordField.SendKeys(Constants.password);
        }
        public void ClickOnSigupButton() => loginButton.Click();
    }
}
