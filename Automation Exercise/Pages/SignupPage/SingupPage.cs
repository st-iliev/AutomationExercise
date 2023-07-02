using Automation_Exercise.Utilities;
using OpenQA.Selenium;
using System.IO.Compression;

namespace Automation_Exercise.Pages.SignupPage
{
    public partial class SingupPage : BasePage
    {
        public bool validationDisplayed = false;
        public SingupPage(IWebDriver driver) : base(driver)
        {
        }
        
        public override string PageURL => "https://www.automationexercise.com/signup";
        AccountInfo accountInfo = new AccountInfo();
        public void ChoiceTitle(Titles title)
        {
           if (title == Titles.Mr)
            {
                titleMrRadioButton.Click();
            }
            else
            {
                titleMrsRadioButton.Click();
            }
        }
       public void ChoiceCountry(Countries country)
        {

            switch (country)
            {
                case Countries.India:  
                    accountInfo.Country = "India"; break;
                case Countries.UnitedStates:
                    accountInfo.Country = "United States"; break;
                case Countries.Canada:
                    accountInfo.Country = "Canada"; break;
                case Countries.Australia:
                    accountInfo.Country = "Australia"; break; 
                case Countries.Israel:
                    accountInfo.Country = "Israel"; break;
                case Countries.NewZealand:
                    accountInfo.Country = "New Zealand"; break; 
                case Countries.Singapore:
                    accountInfo.Country = "Singapore"; break;
            }
        }
        public void FillRequiredFieldInSignupForm(AccountInfo accountInfo)
        {
            passwordField.SendKeys(accountInfo.Password);
            firstNameField.SendKeys(accountInfo.FirstName);
            lastNameField.SendKeys(accountInfo.LastName);
            addressField.SendKeys(accountInfo.Address);
            countryField.SendKeys(accountInfo.Country);
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
