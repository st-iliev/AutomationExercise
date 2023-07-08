using Automation_Exercise.Pages.SignupPage;
using Automation_Exercise.Utilities;

namespace Automation_Exercise.Test_Scripts
{
    public class LoginPageTest : BaseTest
    {
        private AccountInfo accountInfo;
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
                case "":
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
        [TestCase("testEmail", "qatest")]
        public void VerifyLoginWithInvalidEmailOrPassword(string email, string password)
        {
            loginPage.Open();
            loginPage.AssertCorrectPageIsLoaded();
            loginPage.AssertCorrectLoginFormTitleIsDisplayed();
            loginPage.FillLoginForm(email, password);
            loginPage.ClickOnLoginButton();
            if (email != Constants.email)
            {
                loginPage.AssertErrorInvalidEmailAddressMessageIsDisplayed(loginPage.loginEmailField, email);
            }
            else
            {
            loginPage.AssertIncorrectInputDataMessageIsDisplayed();
            }
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
                case "":
                    loginPage.AssertErrorEmptyFieldMessageIsDisplayed(loginPage.signupEmailField);
                    break;
                case Constants.email:
                    loginPage.AssertErrorEmptyFieldMessageIsDisplayed(loginPage.signupNameField);
                    break;
            };
        }
        [Test,Order(4)]
        public void VerifyRegisterNewUserWithValidData()
        {
            
            loginPage.Open();
            loginPage.AssertCorrectPageIsLoaded();
            loginPage.AssertCorrectSignupFormTitleIsDisplayed();
            loginPage.FillSingupForm(Constants.name, Constants.email);
            loginPage.ClickOnSignupButton();
            signupPage.AssertCorrectPageIsLoaded();
            accountInfo = new AccountInfo()
            {
                Title = Titles.Mr,
                Password = Constants.password,
                FirstName = Constants.firstName,
                LastName = Constants.lastName,
                Company = Constants.companyName,
                Address1 = Constants.firstAddress,
                Country = Countries.Australia,
                State = Constants.state,
                City = Constants.city,
                ZipCode = Constants.zipCode,
                MobileNumber = Constants.mobileNumber
            };
            signupPage.FillSignupForm(accountInfo);
            signupPage.ClickOnCreateAccount();
            accountCreatedPage.AssertCorrectPageIsLoaded();
            accountCreatedPage.AssertAccountCreatedTitleIsDisplayedCorrectly();
            accountCreatedPage.AssertFirstSuccessfullMessageIsDisplayedCorrectly();
            accountCreatedPage.AssertSecondSuccessfullMessageIsDisplayedCorrectly();
          //accountCreatedPage.ClickOnContinue();
          //homePage.AssertCorrectPageIsLoaded();
          //homePage.AssertUserIsLogin();
          //homePage.Logout();
          //loginPage.AssertCorrectPageIsLoaded();
        }
        [Test,Order(5)]
        public void VerifyUserLoginWithValidData()
        {
            homePage.Open();
            homePage.Logout();
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
