using Automation_Exercise.src.UI.Utilities;
using Automation_Exercise.Utilities;

namespace Automation_Exercise.Test_Scripts
{
    [TestFixture]
    [Order(11)]
    public class DeleteAccountPageTest : BaseTest
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            suiteTest = extent.CreateTest("Delete Account Page Tests");
        }
        [Test]
        public void VerifyDeleteUserAccount()
        {
            test = suiteTest.CreateNode("Test Delete user account.");
            ExceptionHandler.HandleException(() =>
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
            });
        }
    }
}

