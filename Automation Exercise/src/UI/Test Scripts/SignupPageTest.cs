using Automation_Exercise.Pages.SignupPage;
using Automation_Exercise.Utilities;

namespace Automation_Exercise.Test_Scripts
{
    [TestFixture]
    [Order(4)]
    public class SignupPageTest : BaseTest
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            suiteTest = extent.CreateTest("Signup Page Tests");
        }
        [SetUp]
        public void Preconditions()
        {
            loginPage.Open();
            loginPage.AssertCorrectPageIsLoaded();
            loginPage.AssertCorrectSignupFormTitleIsDisplayed();
            loginPage.FillSingupForm(Constants.name, Constants.email);
            loginPage.ClickOnSignupButton();
            signupPage.AssertCorrectPageIsLoaded();
        }
        private AccountInfo accountInfo;
        [Test, Order(1)]
        public void VerifySuccessfulSubscribe()
        {
            test = suiteTest.CreateNode("Test Successful Subscribe With Valid Credentials");
            ScrollToBottom(driver);
            homePage.Subscrible(Constants.email);
            homePage.ClickOnSubscribeButton();
            homePage.AssertCorrectSuccessfulSubscribeMessageIsDisplayed();
        }
        [Test, Order(2)]
        [TestCase("")]
        [TestCase("invalidEmail")]
        [TestCase("invalidEmail@")]
        public void VerifySubscribeWithInvalidEmail(string email)
        {
            test = suiteTest.CreateNode("Test Subscribe With Invalid Credentials");

            ScrollToBottom(driver);
            homePage.Subscrible(email);
            homePage.ClickOnSubscribeButton();
            switch (email)
            {
                case "":
                    homePage.AssertErrorEmptyFieldMessageIsDisplayed(homePage.subscribeField); break;
                case "invalidEmail":
                    homePage.AssertErrorInvalidEmailAddressMessageIsDisplayed(homePage.subscribeField, email); break;
                case "invalidEmail@":
                    homePage.AssertErrorIncompleteEmailAddressMessageIsDisplayed(homePage.subscribeField, email); break;
            };
        }
        [Test, Order(3)]
        public void VerifyRegisterNewUserWithOnlyRequiredFieldsFilled()
        {
            test = suiteTest.CreateNode("Test Register User With Required Credentials");
            accountInfo = new AccountInfo()
            {
                Title = Constants.title,
                Password = Constants.password,
                FirstName = Constants.firstName,
                LastName = Constants.lastName,
                Company = Constants.companyName,
                Address1 = Constants.firstAddress,
                Country = Constants.country,
                State = Constants.state,
                City = Constants.city,
                ZipCode = Constants.zipCode,
                MobileNumber = Constants.mobileNumber
            };
            signupPage.FillSignupForm(accountInfo);
            ScrollToBottom(driver);
            signupPage.ClickOnCreateAccount();
            accountCreatedPage.AssertCorrectPageIsLoaded();
            accountCreatedPage.AssertAccountCreatedTitleIsDisplayedCorrectly();
            accountCreatedPage.AssertFirstSuccessfullMessageIsDisplayedCorrectly();
            accountCreatedPage.AssertSecondSuccessfullMessageIsDisplayedCorrectly();
            accountCreatedPage.ClickOnContinue();
            AdverticeHelper.CheckForAdvertice(driver);
            homePage.AssertCorrectPageIsLoaded();
            homePage.DeleteAccount();
            deleteAccountPage.ClickOnContinue();
            homePage.AssertUserIsLogout();
        }
        [Test, Order(4)]
        [TestCase("", "", "", "", "", "", "", "", "")]
        [TestCase(Constants.password, "", "", "", "", "", "", "", "")]
        [TestCase(Constants.password, Constants.firstName, "", "", "", "", "", "", "")]
        [TestCase(Constants.password, Constants.firstName, Constants.lastName, "", "", "", "", "", "")]
        [TestCase(Constants.password, Constants.firstName, Constants.lastName, Constants.firstAddress, Constants.country, "", "", "", "")]
        [TestCase(Constants.password, Constants.firstName, Constants.lastName, Constants.firstAddress, Constants.country, Constants.state, "", "", "")]
        [TestCase(Constants.password, Constants.firstName, Constants.lastName, Constants.firstAddress, Constants.country, Constants.state, Constants.city, "", "")]
        [TestCase(Constants.password, Constants.firstName, Constants.lastName, Constants.firstAddress, Constants.country,Constants.state, Constants.city, Constants.zipCode, "")]
        public void VerifyErrorMessageDisplayedOnRequiredFields(string password, string firsName, string lastName, string address1, string country,string state, string city, string zipeCode, string mobileNumber)
        {
            test = suiteTest.CreateNode("Test Error Message Displayed On Required Credentials");
            accountInfo = new AccountInfo()
            {
                Password = password,
                FirstName = firsName,
                LastName = lastName,
                Address1 = address1,
                Country = country,
                State = state,
                City = city,
                ZipCode = zipeCode,
                MobileNumber = mobileNumber
            };
            signupPage.FillSignupForm(accountInfo);
            ScrollToBottom(driver);
            signupPage.ClickOnCreateAccount();
            if (accountInfo.Password != "")
            {
            signupPage.AssertValidationMessageIsDisplayed(signupPage.passwordField);
            }
            if (accountInfo.FirstName != "")
            {
                signupPage.AssertValidationMessageIsDisplayed(signupPage.firstNameField);
            }
            if (accountInfo.LastName != "")
            {
                signupPage.AssertValidationMessageIsDisplayed(signupPage.lastNameField);
            }
            if (accountInfo.Address1 != "")
            {
                signupPage.AssertValidationMessageIsDisplayed(signupPage.addressField);
            }
            if (accountInfo.State != "")
            {
                signupPage.AssertValidationMessageIsDisplayed(signupPage.stateField);
            }
            if (accountInfo.City != "")
            {
                signupPage.AssertValidationMessageIsDisplayed(signupPage.cityField);
            }
            if (accountInfo.ZipCode != "")
            {
                signupPage.AssertValidationMessageIsDisplayed(signupPage.zipCodeField);
            }
            if (accountInfo.MobileNumber != "")
            {
                signupPage.AssertValidationMessageIsDisplayed(signupPage.mobileNumberField);
            }

        }
        [Test, Order(5)]
        public void VerifyRegisterNewUserWithAllFields()
        {
            test = suiteTest.CreateNode("Test Register User With All Credentials");
            accountInfo = new AccountInfo()
            {
                Title = Constants.title,
                Password = Constants.password,
                DayOfMonth = DayOfMonth.Day22,
                MonthOfYear = MonthOfYear.July,
                Years = Years.Year1999,
                FirstName = Constants.firstName,
                LastName = Constants.lastName,
                Company = Constants.companyName,
                Address1 = Constants.firstAddress,
                Address2 = Constants.secondAddress,
                Country = Constants.country,
                State = Constants.state,
                City = Constants.city,
                ZipCode = Constants.zipCode,
                MobileNumber = Constants.mobileNumber
            };
            ScrollDown(driver, 250);
            signupPage.CheckForNewsLetter();
            signupPage.CheckForReceiveSpecialOffers();
            signupPage.FillSignupForm(accountInfo);
            ScrollToBottom(driver);
            signupPage.ClickOnCreateAccount();
            accountCreatedPage.AssertCorrectPageIsLoaded();
            accountCreatedPage.AssertAccountCreatedTitleIsDisplayedCorrectly();
            accountCreatedPage.AssertFirstSuccessfullMessageIsDisplayedCorrectly();
            accountCreatedPage.AssertSecondSuccessfullMessageIsDisplayedCorrectly();
            accountCreatedPage.ClickOnContinue();
            AdverticeHelper.CheckForAdvertice(driver);
            homePage.AssertCorrectPageIsLoaded();
            homePage.AssertUserIsLogin();
        }   
    }
}
