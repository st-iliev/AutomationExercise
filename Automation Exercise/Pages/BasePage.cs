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
        public string GetPageUrl() => driver.Url;
        //Method that wait element to be visible then located him and
        //if isn't visible then catch the exception
        protected IWebElement WaitAndFindElements(By locator)
        {
            try
            {
                return waitDriver.Until(ExpectedConditions.ElementIsVisible(locator));
            }
            catch (NoSuchElementException ex)
            {
                throw new NoSuchElementException($"Element not found: {locator}, {ex}");
            }
            catch (WebDriverException ex)
            {
                throw new WebDriverException($"WebDriverException occurred: {ex.Message}, {ex}");
            }
        }
        protected string ValidationMessage(IWebElement field) => field.GetAttribute("validationMessage");
    }
}
