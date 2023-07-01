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
        public void Singup()
        {
            signupNameField.SendKeys(Constants.firstName);
            signupEmailField.SendKeys(Constants.email);
            signupButton.Click();
        }
        public void Login()
        {
            loginEmailField.SendKeys(Constants.email);
            loginPasswordField.SendKeys(Constants.password);
            loginButton.Click();
        }
    }
}
