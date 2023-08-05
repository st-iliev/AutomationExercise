using Automation_Exercise.src.UI.Pages.ContactUsPage;
using Automation_Exercise.Utilities;

namespace Automation_Exercise.Test_Scripts
{
    [TestFixture]
    [Order(2)]
    public class ContactUsPageTest : BaseTest
    {

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            suiteTest = extent.CreateTest("ContactUs Page Tests");
        }
        [SetUp]
        public void Preconditions()
        {
            contactUsPage.Open();
            contactUsPage.AssertCorrectPageIsLoaded();
            contactUsPage.AssertContactUsFormTitleIsDisplayedCorectly();
            contactUsPage.AssertContactFormFieldsAreDisplayed();
        }
        private ContactUsForm form;
        [TestCase("invalidEmail")]
        [TestCase("invalidEmail@")]
        [TestCase(" ")]
        public void VerifySubmitContactFormWithInvalidEmailAddress(string email)
        {
            test = suiteTest.CreateNode("Test Submit contact form with invalid credentials.");
            form = new ContactUsForm()
            {
                Name = Constants.name,
                Email = email,
                Subject = Constants.contactUsSubject,
                Message = Constants.contactUsMessage,
                // ChoosenFile = Constants.choosenFilePath
            };
            contactUsPage.FillContactUsForm(form);
            contactUsPage.SubmiteForm();
            switch (email)
            {
                case "invalidEmail":
                    contactUsPage.AssertErrorInvalidEmailAddressMessageIsDisplayed(contactUsPage.emailField, email);
                    break;
                case "invalidEmail@":
                    contactUsPage.AssertErrorIncompleteEmailAddressMessageIsDisplayed(contactUsPage.emailField, email);
                    break;
                case null:
                    contactUsPage.AssertErrorEmptyFieldMessageIsDisplayed(contactUsPage.emailField);
                    break;
            };
        }
        [Test]
        public void VerifySubmitContactFormWithValidData()
        {
            test = suiteTest.CreateNode("Test Submit contact form with valid credentials.");
            form = new ContactUsForm()
            {
                Name = Constants.name,
                Email = Constants.email,
                Subject = Constants.contactUsSubject,
                Message = Constants.contactUsMessage,
                ChoosenFile = Constants.choosenFilePath
            };
            contactUsPage.FillContactUsForm(form);
            contactUsPage.SubmiteForm();
            AlertHelper.CheckForAlert(driver);
            contactUsPage.AssertSuccessfulMessageIsDisplayed();
            contactUsPage.ClickOnHomeButton();
            AdverticeHelper.CheckForAdvertice(driver);
            homePage.AssertCorrectPageIsLoaded();
        }
        [Test]
        public void VerifySuccessfulSubscribe()
        {
            test = suiteTest.CreateNode("Test Subscribe with valid credential.");
            ScrollToBottom(driver);
            homePage.Subscrible(Constants.email);
            homePage.ClickOnSubscribeButton();
            homePage.AssertCorrectSuccessfulSubscribeMessageIsDisplayed();
        }
        [Test]
        [TestCase("")]
        [TestCase("invalidEmail")]
        [TestCase("invalidEmail@")]
        public void VerifySubscribeWithInvalidEmail(string email)
        {
            test = suiteTest.CreateNode("Test subscribe with invalid credentials.");
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
    }
}
