using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Exercise.Pages
{
    public abstract class BasePage
    {
        private int elementsTimeout = 5;
        protected IWebDriver driver { get; set; }
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            waitDriver = new WebDriverWait(driver, TimeSpan.FromSeconds(elementsTimeout));
        }
        public IWebElement homeLink => driver.FindElement(By.XPath("//a[contains(text(),'Home')]"));
        public IWebElement productsLink => driver.FindElement(By.XPath("//a[contains(@href,'/products')]"));
        public IWebElement cartLink => driver.FindElement(By.XPath("//a[contains(@href,'/view cart')]"));
        public IWebElement loginLink => driver.FindElement(By.XPath("//a[contains(@href,'/login')]"));
        public IWebElement contactusLink => driver.FindElement(By.XPath("//a[contains(@href,'/contact us')]"));
        protected WebDriverWait waitDriver { get; set; }
        public abstract string PageURL { get; }
        public void Open() => driver.Navigate().GoToUrl(PageURL);
        public string GetPageTitle() => driver.Title;

    }
}
