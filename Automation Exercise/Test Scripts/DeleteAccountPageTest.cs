using Automation_Exercise.Utilities;

namespace Automation_Exercise.Test_Scripts
{
    [TestFixture]
    [Order(10)]
    public class DeleteAccountPageTest : BaseTest
    {
        [Test]
        public void VerifyDeleteUserAccount()
        {
            loginPage.Open();
            loginPage.AssertCorrectPageIsLoaded();
            loginPage.AssertCorrectLoginFormTitleIsDisplayed();
            loginPage.FillLoginForm(Constants.email, Constants.password);
            loginPage.ClickOnLoginButton();
            homePage.AssertUserIsLogin();
            homePage.DeleteAccount();
            AdverticeHelper.CheckForAdvertice(driver);
            deleteAccountPage.AssertCorrectPageIsLoaded();
            deleteAccountPage.AssertCorrectAccountDeleteMessageIsDisplayed();
            deleteAccountPage.AssertCorrectAccountDeletedSuccessfullMessageIsDisplayed();
            deleteAccountPage.AssertCorrectSecondAccountDeletedSuccessfullMessageIsDisplayed();
            deleteAccountPage.ClickOnContinue();
            loginPage.Open();
            loginPage.FillLoginForm(Constants.email, Constants.password);
            loginPage.ClickOnLoginButton();
            loginPage.AssertIncorrectInputDataMessageIsDisplayed();
        }
    }
}

