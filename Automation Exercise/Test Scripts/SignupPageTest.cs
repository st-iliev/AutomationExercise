using Automation_Exercise.Pages.SignupPage;
using Automation_Exercise.Utilities;

namespace Automation_Exercise.Test_Scripts
{
    [TestFixture]
    [Order(4)]
    public class SignupPageTest : BaseTest
    {
        private AccountInfo accountInfo;
        [Test, Order(1)]
        public void VerifyRegisterNewUserWithOnlyRequiredFieldsFilled()
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
        [Test, Order(2)]
        [TestCase(null, null, null, null, null, null, null, null)]
        [TestCase(Constants.password, null, null, null, null, null, null, null)]
        [TestCase(Constants.password, Constants.firstName, null, null, null, null, null, null)]
        [TestCase(Constants.password, Constants.firstName, Constants.lastName, null, null, null, null, null)]
        [TestCase(Constants.password, Constants.firstName, Constants.lastName, Constants.firstAddress, null, null, null, null)]
        [TestCase(Constants.password, Constants.firstName, Constants.lastName, Constants.firstAddress, Constants.state, null, null, null)]
        [TestCase(Constants.password, Constants.firstName, Constants.lastName, Constants.firstAddress, Constants.state, Constants.city, null, null)]
        [TestCase(Constants.password, Constants.firstName, Constants.lastName, Constants.firstAddress, Constants.state, Constants.city, Constants.zipCode, null)]
        public void VerifyErrorMessageDisplayedOnRequiredFields(string password, string firsName, string lastName, string address1, string state, string city, string zipeCode, string mobileNumber)
        {

            loginPage.Open();
            loginPage.AssertCorrectPageIsLoaded();
            loginPage.AssertCorrectSignupFormTitleIsDisplayed();
            loginPage.FillSingupForm(Constants.name, Constants.email);
            loginPage.ClickOnSignupButton();
            signupPage.AssertCorrectPageIsLoaded();
            accountInfo = new AccountInfo()
            {
                Password = password,
                FirstName = firsName,
                LastName = lastName,
                Address1 = address1,
                State = state,
                City = city,
                ZipCode = zipeCode,
                MobileNumber = mobileNumber
            };
            signupPage.FillSignupForm(accountInfo);
            ScrollToBottom(driver);
            signupPage.ClickOnCreateAccount();
            if (accountInfo.Password != null)
            {
            signupPage.AssertValidationMessageIsDisplayed(signupPage.passwordField);
            }
            if (accountInfo.FirstName != null)
            {
                signupPage.AssertValidationMessageIsDisplayed(signupPage.firstNameField);
            }
            if (accountInfo.LastName != null)
            {
                signupPage.AssertValidationMessageIsDisplayed(signupPage.lastNameField);
            }
            if (accountInfo.Address1 != null)
            {
                signupPage.AssertValidationMessageIsDisplayed(signupPage.addressField);
            }
            if (accountInfo.State != null)
            {
                signupPage.AssertValidationMessageIsDisplayed(signupPage.stateField);
            }
            if (accountInfo.City != null)
            {
                signupPage.AssertValidationMessageIsDisplayed(signupPage.cityField);
            }
            if (accountInfo.ZipCode != null)
            {
                signupPage.AssertValidationMessageIsDisplayed(signupPage.zipCodeField);
            }
            if (accountInfo.MobileNumber != null)
            {
                signupPage.AssertValidationMessageIsDisplayed(signupPage.mobileNumberField);
            }

        }
        [Test, Order(3)]
        public void VerifyRegisterNewUserWithAllFields()
        {
            homePage.Open();
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
                DayOfMonth = DayOfMonth.Day22,
                MonthOfYear = MonthOfYear.July,
                Years = Years.Year1999,
                FirstName = Constants.firstName,
                LastName = Constants.lastName,
                Company = Constants.companyName,
                Address1 = Constants.firstAddress,
                Address2 = Constants.secondAddress,
                Country = Countries.Australia,
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
