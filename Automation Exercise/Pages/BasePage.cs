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
            private int elementsTimeout = 10;
            protected IWebDriver driver { get; set; }
            public BasePage(IWebDriver driver)
            {
                this.driver = driver;
                waitDriver = new WebDriverWait(driver, TimeSpan.FromSeconds(elementsTimeout));
            }
            protected WebDriverWait waitDriver { get; set; }
            public abstract string PageURL { get; }
            public void Open()
            {
                driver.Navigate().GoToUrl(PageURL);
                
            }
            public string GetPageTitle() => driver.Title;

    }
}
