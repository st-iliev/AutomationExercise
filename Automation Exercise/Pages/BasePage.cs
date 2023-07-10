using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace Automation_Exercise.Pages
{
    public abstract class BasePage
    {
        private int elementsTimeout = 30;
        protected IWebDriver driver { get; set; }
        protected WebDriverWait waitDriver { get; set; }
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            waitDriver = new WebDriverWait(driver, TimeSpan.FromSeconds(elementsTimeout));
        }
       // TODO Need to add wait until displayed.
        public abstract string PageURL { get; }
        public void Open() => driver.Navigate().GoToUrl(PageURL);
        public string GetPageTitle() => driver.Title;
        public string GetPageUrl () => driver.Url;
       
    }
}
