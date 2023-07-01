using OpenQA.Selenium;

namespace Automation_Exercise.Pages.SignupPage
{
    public partial class SingupPage : BasePage
    {
        public SingupPage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageURL => "https://www.automationexercise.com/signup";
       
    }
}
