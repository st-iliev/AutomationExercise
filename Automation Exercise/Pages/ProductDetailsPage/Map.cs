using OpenQA.Selenium;

namespace Automation_Exercise.Pages.ProductDetailsPage
{
    partial class ProductDetailsPage
    {
        public IWebElement productPicture => driver.FindElement(By.XPath("//*[contains(@src,'/get_product_picture/')]"));
        public IWebElement productName => driver.FindElement(By.XPath("//*[@class='product-information']//h2"));
        public IWebElement productQuantity => driver.FindElement(By.XPath("//*[@id='quantity']"));
        public IWebElement addToCartButton => driver.FindElement(By.XPath("//button[@type='button']"));
        public IWebElement avaliableInfo => driver.FindElement(By.XPath("//*[@class='product-information']//p[2]"));
        public IWebElement conditionInfo => driver.FindElement(By.XPath("//*[@class='product-information']//p[3]"));
        public IWebElement brandInfo => driver.FindElement(By.XPath("//*[@class='product-information']//p[4]"));
        public IWebElement reviewFormTitle => driver.FindElement(By.XPath("//*[@href='#reviews']"));
        public IWebElement nameField => driver.FindElement(By.XPath("//*[@id='name']"));
        public IWebElement emailAddressField => driver.FindElement(By.XPath("//*[@id='email']"));
        public IWebElement reviewField => driver.FindElement(By.XPath("//*[@id='review']"));
        public IWebElement submitButton => driver.FindElement(By.XPath("//*[@id='button-review']"));
    }
}
