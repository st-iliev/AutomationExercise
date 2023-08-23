using Automation_Exercise.src.UI.TestData;
using Automation_Exercise.Utilities;

namespace Automation_Exercise.Test_Scripts
{
    [TestFixture]
    [Order(5)]
    public class LoginPageTest : BaseTest
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            suiteTest = extent.CreateTest("Login Page Tests");
        }
        [SetUp]
        public void Setup()
        {

            loginPage.Open();
            loginPage.AssertCorrectPageIsLoaded();
            loginPage.AssertCorrectLoginFormTitleIsDisplayed();
        }
        [Test, Order(1)]
        public void VerifySuccessfulSubscribeFromLoginPage()
        {
            test = suiteTest.CreateNode("Test Successful Subscribe With Valid Credentials");
            ScrollToBottom(driver);
            homePage.Subscrible(Constants.email);
            homePage.ClickOnSubscribeButton();
            homePage.AssertCorrectSuccessfulSubscribeMessageIsDisplayed();
        }
        [Test, Order(2)]
        [TestCaseSource(typeof(SubscribeTestCases), nameof(SubscribeTestCases.InvalidSubscribeCases))]
        public void VerifySubscribeWithInvalidEmailFromLoginPage(string email)
        {
            test = suiteTest.CreateNode("Test Subscribe With InValid Credentials");
            ScrollToBottom(driver);
            homePage.Subscrible(email);
            homePage.ClickOnSubscribeButton();
            switch (email)
            {
                case null:
                    homePage.AssertErrorEmptyFieldMessageIsDisplayed(homePage.subscribeField); break;
                case "invalidEmail":
                    homePage.AssertErrorInvalidEmailAddressMessageIsDisplayed(homePage.subscribeField, email); break;
                case "invalidEmail@":
                    homePage.AssertErrorIncompleteEmailAddressMessageIsDisplayed(homePage.subscribeField, email); break;
            };
        }
        [Test, Order(3)]
        [TestCaseSource(typeof(LoginTestCases), nameof(LoginTestCases.LoginWithoutEmailOrPassowrdCases))]
        public void VerifyUserLoginWithoutEmailOrPassword(string email, string password)
        {
            test = suiteTest.CreateNode("Test User Login Without Credentials");
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
        [Test, Order(4)]
        [TestCaseSource(typeof(LoginTestCases), nameof(LoginTestCases.LoginWithInvalidEmailOrPassowrd))]
        public void VerifyLoginWithInvalidEmailOrPassword(string email, string password)
        {
            test = suiteTest.CreateNode("Test User Login With Invalid Credentials");
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
        [Test, Order(5)]
        [TestCaseSource(typeof(SignupTestCases), nameof(SignupTestCases.SignupWithoutNameOrEmailCases))]
        public void VerifySignupUserWithoutNameOrEmail(string name, string email)
        {
            test = suiteTest.CreateNode("Test User Signup Without Credentials");
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
        [Test, Order(6)]
        public void VerifyScrollDownFuncionallity()
        {
            test = suiteTest.CreateNode("Test Scrolldown fuctionallity of page");
            ScrollToBottom(driver);
            homePage.AssertCopyRightTextIsDisplayed();
        }
        [Test, Order(7)]
        public void VerifyScrollUpFuncionallity()
        {
            test = suiteTest.CreateNode("Test Scrollup fuctionallity of page");
            ScrollToBottom(driver);
            homePage.AssertWebsiteLogoIsDisplayed();
        }
        [Test, Order(8)]
        public void VerifyUserLoginWithValidData()
        {
            test = suiteTest.CreateNode("Test User Login With Valid Credentials");
            loginPage.FillLoginForm(Constants.email, Constants.password);
            loginPage.ClickOnLoginButton();
            homePage.AssertCorrectPageIsLoaded();
            homePage.AssertUserIsLogin();
            homePage.Logout();
        }
    }
}
