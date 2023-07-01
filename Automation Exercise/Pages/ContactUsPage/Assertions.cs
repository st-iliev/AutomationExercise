using Automation_Exercise.Utilities;

namespace Automation_Exercise.Pages.ContactUsPage
{
    partial class ContactUsPage
    {
        public void AssertCorrectPageIsLoade()
        {
            Assert.AreEqual("Automation Exercise - Contact Us", GetPageTitle());
        }
        public void AssertContactUsFormTitleIsDisplayedCorectly()
        {
            Assert.AreEqual("GET IN TOUCH", contactUsFormTitle.ToString());
        }
        public void AssertNameFieldIsDisplayed()
        {
            Assert.True(nameField.Displayed);
        }
        public void AssertEmailFieldIsDisplayed()
        {
            Assert.True(emailField.Displayed);
        }
        public void AssertSubjectFieldIsDisplayed()
        {
            Assert.True(subjectField.Displayed);
        }
        public void AssertMessageFieldIsDisplayed()
        {
            Assert.True(messagetField.Displayed);
        }
        public void AssertUploadFileButtonIsDisplayed()
        {
            Assert.True(uploadFileButton.Displayed);
        }
        public void AssertSubmitButtonIsDisplayed()
        {
            Assert.True(submitButton.Displayed);
        }
        public void AssertSuccessfulMessageIsDisplayed()
        {
            Assert.True(successfulMessage.Displayed);
        }
        public void AssertHomeButtonIsDisplayed()
        {
            Assert.True(homeButton.Displayed);
        }
    }
}
