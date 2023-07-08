using Automation_Exercise.Utilities;
using OpenQA.Selenium;

namespace Automation_Exercise.Pages.SignupPage
{
    public partial class SignupPage : BasePage
    {
        public bool validationDisplayed = false;
        public SignupPage(IWebDriver driver) : base(driver)
        {
        }
        
        public override string PageURL => "https://www.automationexercise.com/signup";
   
        public void FillSignupForm(AccountInfo accountInfo)
        {
            if (accountInfo.Title == Titles.Mr)
            {
                titleMrRadioButton.Click();
            }
            else
            {
                titleMrsRadioButton.Click();
            }
            passwordField.SendKeys(accountInfo.Password);
            firstNameField.SendKeys(accountInfo.FirstName);
            lastNameField.SendKeys(accountInfo.LastName);
            companyField.SendKeys(accountInfo.Company);
            addressField.SendKeys(accountInfo.Address1);
            countryField.SendKeys(accountInfo.Country.ToString());
            stateField.SendKeys(accountInfo.State);
            cityField.SendKeys(accountInfo.City);
            zipCodeField.SendKeys(accountInfo.ZipCode);
            mobileNumberField.SendKeys(accountInfo.MobileNumber);
        }
        public void ClickOnCreateAccount() => createAccountButton.Click();
       public void ValidationMessageIsDisplayed(IWebElement nameOfField)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            bool isRequired = (bool)js.ExecuteScript("return arguments[0].required;", nameOfField);
           if (isRequired)
            {
                validationDisplayed = true;
            }
        }
    }
}
