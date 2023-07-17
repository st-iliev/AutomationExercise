using Automation_Exercise.Pages.SignupPage;
using Automation_Exercise.Utilities;

namespace Automation_Exercise.Test_Scripts
{
    [TestFixture]
    [Order(5)]
    public class LoginPageTest : BaseTest
    {
        [Test, Order(1)]
        [TestCase(Constants.email, "")]
        [TestCase("", Constants.password)]
        [TestCase("", "")]
        public void VerifyUserLoginWithoutEmailOrPassword(string email, string password)
        {
            loginPage.Open();
            loginPage.AssertCorrectPageIsLoaded();
            loginPage.AssertCorrectLoginFormTitleIsDisplayed();
            loginPage.FillLoginForm(email, password);
            loginPage.ClickOnLoginButton();
            switch (password)
            {
                case null:
                    loginPage.AssertErrorEmptyFieldMessageIsDisplayed(loginPage.loginPasswordField);
                    break;
                case Constants.password:
                    loginPage.AssertErrorEmptyFieldMessageIsDisplayed(loginPage.loginEmailField);
                    break;
            };
        }
        [Test, Order(2)]
        [TestCase(Constants.email, "qatest")]
        [TestCase("incorrectEmail", Constants.password)]
        [TestCase("incorrectEmail@", Constants.password)]
        public void VerifyLoginWithInvalidEmailOrPassword(string email, string password)
        {
            loginPage.Open();
            loginPage.AssertCorrectPageIsLoaded();
            loginPage.AssertCorrectLoginFormTitleIsDisplayed();
            loginPage.FillLoginForm(email, password);
            loginPage.ClickOnLoginButton();
            switch (email)
            {
                case "incorrectEmail":
                    loginPage.AssertErrorInvalidEmailAddressMessageIsDisplayed(loginPage.loginEmailField, email);
                    break;
                case "incorrectEmail@":
                    loginPage.AssertErrorIncompleteEmailAddressMessageIsDisplayed(loginPage.loginEmailField, email);
                    break;
                case Constants.email:
                    loginPage.AssertIncorrectInputDataMessageIsDisplayed();
                    break;
            };
            
        }
        [Test, Order(3)]
        [TestCase(Constants.name, "")]
        [TestCase("", Constants.email)]
        [TestCase("", "")]
        public void VerifySignupUserWithoutNameOrEmail(string name, string email)
        {
            loginPage.Open();
            loginPage.AssertCorrectPageIsLoaded();
            loginPage.AssertCorrectSignupFormTitleIsDisplayed();
            loginPage.FillSingupForm(name, email);
            loginPage.ClickOnSignupButton();
            switch (email)
            {
                case null:
                    loginPage.AssertErrorEmptyFieldMessageIsDisplayed(loginPage.signupEmailField);
                    break;
                case Constants.email:
                    loginPage.AssertErrorEmptyFieldMessageIsDisplayed(loginPage.signupNameField);
                    break;
            };
        }
        
        [Test, Order(4)]
        public void VerifyUserLoginWithValidData()
        {
            loginPage.Open();
            loginPage.AssertCorrectPageIsLoaded();
            loginPage.AssertCorrectLoginFormTitleIsDisplayed();
            loginPage.FillLoginForm(Constants.email, Constants.password);
            loginPage.ClickOnLoginButton();
            homePage.AssertCorrectPageIsLoaded();
            homePage.AssertUserIsLogin();
        }
    }
}
