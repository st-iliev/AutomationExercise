using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Automation_Exercise.Pages
{
    public abstract class BasePage
    {
        private int elementsTimeout = 10;
        protected IWebDriver driver { get; set; }
        protected WebDriverWait waitDriver { get; set; }
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            waitDriver = new WebDriverWait(driver, TimeSpan.FromSeconds(elementsTimeout));
        }
        public abstract string PageURL { get; }
        public void Open() => driver.Navigate().GoToUrl(PageURL);
        public string GetPageTitle() => driver.Title;
        public string GetPageUrl () => driver.Url;
        protected IWebElement WaitAndFindElements(By locator)
        {
            return waitDriver.Until(ExpectedConditions.ElementIsVisible(locator));
        }
        protected string ValidationMessage(IWebElement field) => field.GetAttribute("validationMessage");
    }
}
