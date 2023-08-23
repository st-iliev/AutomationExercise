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
            UserLogin();
            homePage.AssertUserIsLogin();
            homePage.DeleteAccount();
            AdverticeHelper.CheckForAdvertice(driver);
            deleteAccountPage.AssertCorrectPageIsLoaded();
            deleteAccountPage.AssertCorrectAccountDeleteMessageIsDisplayed();
            deleteAccountPage.AssertCorrectSuccessfullMessageIsDisplayed();
            deleteAccountPage.AssertCorrectSecondSuccessfullMessageIsDisplayed();
            deleteAccountPage.ClickOnContinue();
            UserLogin();
            loginPage.AssertIncorrectInputDataMessageIsDisplayed();
        }
    }
}

