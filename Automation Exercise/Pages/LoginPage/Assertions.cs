namespace Automation_Exercise.Pages.LoginPage
{
    partial class LoginPage
    {
        public void AssertCorrectPageIsLoade()
        {
            Assert.AreEqual("Automation Exercise Singup/Login", GetPageTitle());
        }
        public void AssertCorrectLoginFormTitleIsDisplayed()
        {
            Assert.AreEqual("Login to your account",loginFormTitle.ToString());
        }
        public void AssertLoginEmailAddressFieldIsDisplayed()
        {
            Assert.True(loginEmailField.Displayed);
        }
        public void AssertLoginPasswordFieldIsDisplayed() 
        {
            Assert.True(loginPasswordField.Displayed);
        }
        public void AssertLoginButtonIsDisplayed()
        {
            Assert.True(loginButton.Displayed);
        }
        public void AssertLoginErrorMessageIsDisplayed()
        {
            Assert.True(errorLoginMessage.Displayed);
        }
        public void AssertCorrectSignupFormTitleIsDisplayed()
        {
            Assert.AreEqual("New User Signup!", signupFormTitle.ToString());
        }
        public void AssertSignupNameFieldIsDisplayed()
        {
            Assert.True(signupNameField.Displayed);
        }
        public void AssertSignupEmailFieldIsDisplayed()
        {
            Assert.True(signupEmailField.Displayed);
        }
        public void AssertSignupButtonIsDisplayed()
        {
            Assert.True(signupButton.Displayed);
        }
        public void AssertSignupErrorMessageIsDisplayed()
        {
            Assert.True(errorSignupMessage.Displayed);
        }
    }
}
