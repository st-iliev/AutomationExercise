using Automation_Exercise.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V112.Debugger;

namespace Automation_Exercise.Pages.SignupPage
{
    public partial class SignupPage : BasePage
    {
        public SignupPage(IWebDriver driver) : base(driver)
        {
        }
        
        public override string PageURL => "https://www.automationexercise.com/signup";
   
        public void FillSignupForm(AccountInfo accountInfo)
        {
            if (accountInfo.Title != null)
            {
                if (accountInfo.Title == Titles.Mr) 
                {
                    titleMrRadioButton.Click();
                   
                }
                else
                {
                    titleMrsRadioButton.Click();
                }                 
            }
            if (accountInfo.Password != null)
            {
            passwordField.SendKeys(accountInfo.Password);
            }
            if (accountInfo.DayOfMonth != null && accountInfo.MonthOfYear != null && accountInfo.Years != null)
            {
                dayOfBirthDropDown.SendKeys(accountInfo.DayOfMonth.ToString());
                monthOfBirthDropDown.SendKeys(accountInfo.MonthOfYear.ToString());
                yearOfBirthDropDown.SendKeys(accountInfo.Years.ToString());
            }
            if (accountInfo.FirstName != null)
            {
                firstNameField.SendKeys(accountInfo.FirstName);
            }
            if (accountInfo.LastName != null)
            {
                lastNameField.SendKeys(accountInfo.LastName);
            }
            if (accountInfo.Company != null)
            {
                companyField.SendKeys(accountInfo.Company);
            }
            if (accountInfo.Address1 != null)
            {
                addressField.SendKeys(accountInfo.Address1);
            }
            if (accountInfo.Address2 != null)
            {
                address2Field.SendKeys(accountInfo.Address2);
            }
            countryField.SendKeys(accountInfo.Country);
            if (accountInfo.State != null)
            {
                stateField.SendKeys(accountInfo.State);
            }
            if (accountInfo.City != null)
            {
                cityField.SendKeys(accountInfo.City);
            }
            if (accountInfo.ZipCode != null)
            {
                zipCodeField.SendKeys(accountInfo.ZipCode);
            }
            if (accountInfo.MobileNumber != null)
            {
                mobileNumberField.SendKeys(accountInfo.MobileNumber);
            }
        }
        public void ClickOnCreateAccount() => createAccountButton.Click();
       public bool ValidationMessageIsDisplayed(IWebElement nameOfField)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            bool isRequired = (bool)js.ExecuteScript("return arguments[0].required;", nameOfField);
           if (isRequired)
            {
                return true;
            }
           return false;
        }
        public void CheckForNewsLetter() => newsLetterCheckbox.Click();
        public void CheckForReceiveSpecialOffers() => receiveOffersCheckbox.Click();
    }
}
