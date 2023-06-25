using OpenQA.Selenium;

namespace Automation_Exercise.Pages
{
    public class ContactUsPage : BasePage
    {
        public ContactUsPage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageURL => "https://www.automationexercise.com/contact_us";
        public IWebElement nameField => driver.FindElement(By.XPath("//input[@data-qa='name']"));
        public IWebElement emailField => driver.FindElement(By.XPath("//input[@data-qa='email']"));
        public IWebElement subjectField => driver.FindElement(By.XPath("//input[@data-qa='subject']"));
        public IWebElement messagetField => driver.FindElement(By.XPath("//textarea[@data-qa='message']"));
        public IWebElement submitButton => driver.FindElement(By.XPath("//input[@data-qa='submit-button']"));
        public IWebElement successMessaGE => driver.FindElement(By.XPath("//*[@class='status alert alert-success']"));
        public IWebElement homeButton => driver.FindElement(By.XPath("//a[@class='btn btn-success']"));
        

    
    }
}
