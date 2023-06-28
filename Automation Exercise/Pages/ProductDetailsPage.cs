using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Exercise.Pages
{
    internal class ProductDetailsPage : ProductPage
    {
        public ProductDetailsPage(IWebDriver driver) : base(driver)
        {
        }
        public IWebElement productName => driver.FindElement(By.XPath("//*[@class='product-information']//h2"));
        public IWebElement productQuantity => driver.FindElement(By.XPath("//*[@id='quantity']"));
        public IWebElement addToCartButton => driver.FindElement(By.XPath("//button[@type='button']"));
        public IWebElement avaliableInfo => driver.FindElement(By.XPath("//*[@class='product-information']//p[2]"));
        public IWebElement conditionInfo => driver.FindElement(By.XPath("//*[@class='product-information']//p[3]"));
        public IWebElement brandInfo => driver.FindElement(By.XPath("//*[@class='product-information']//p[4]"));
        public IWebElement nameField => driver.FindElement(By.XPath("//*[@id='name']"));
        public IWebElement emailAddressField => driver.FindElement(By.XPath("//*[@id='email']"));
        public IWebElement reviewField => driver.FindElement(By.XPath("//*[@id='review']"));
        public IWebElement submitButton => driver.FindElement(By.XPath("//*[@id='button-review']"));

    }
}
