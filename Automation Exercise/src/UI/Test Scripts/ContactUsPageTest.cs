using Automation_Exercise.Pages.ContactUsPage;
using Automation_Exercise.src.UI.TestData;
using Automation_Exercise.Utilities;

namespace Automation_Exercise.Test_Scripts
{
    [TestFixture]
    [Order(2)]
    public class ContactUsPageTest : BaseTest
    {
        private ContactUsForm form;
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
        [Test, Order(1)]
        [TestCaseSource(typeof(ContactUsTestCases), nameof(ContactUsTestCases.InvalidEmailCases))]
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
        [Test, Order(2)]
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
        [Test, Order(3)]
        public void VerifySuccessfulSubscribeFromContactUsPage()
        {
            test = suiteTest.CreateNode("Test Subscribe with valid credential.");
            ScrollToBottom(driver);
            homePage.Subscrible(Constants.email);
            homePage.ClickOnSubscribeButton();
            homePage.AssertCorrectSuccessfulSubscribeMessageIsDisplayed();
        }
        [Test, Order(4)]
        [TestCaseSource(typeof(SubscribeTestCases), nameof(SubscribeTestCases.InvalidSubscribeCases))]
        public void VerifySubscribeWithInvalidEmailFromContactUsPage(string email)
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
        [Test, Order(5)]
        public void VerifyFeedbackInformationIsDisplayedCorrect()
        {
            test = suiteTest.CreateNode("Test Correct feedback information is displayed.");
            contactUsPage.AssertFeedbackTitleIsDisplayedCorrectly();
            contactUsPage.AssertFeedbackTextInfoIsDisplayedCorrectly();
        }
    }
}
