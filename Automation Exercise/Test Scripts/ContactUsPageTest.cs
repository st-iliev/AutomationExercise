using Automation_Exercise.Pages.ContactUsPage;
using Automation_Exercise.Utilities;

namespace Automation_Exercise.Test_Scripts
{
    [TestFixture]
    [Order(2)]
    public class ContactUsPageTest : BaseTest
    {
        private ContactUsForm form;
        [TestCase("invalidEmail")]
        [TestCase("invalidEmail@")]
        [TestCase(" ")]
        public void VerifySubmitContactFormWithEmptyEmailAddressOrInvalidEmailAddress(string email)
        {
            contactUsPage.Open();
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
            contactUsPage.Open();
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
    }
}
