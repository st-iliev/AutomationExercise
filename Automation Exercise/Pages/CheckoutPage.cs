using OpenQA.Selenium;

namespace Automation_Exercise.Pages
{
    public class CheckoutPage : BasePage
    {
        public CheckoutPage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageURL => "https://www.automationexercise.com/checkout";
        public IWebElement addressDetailsMessage => driver.FindElement(By.XPath("//*[@class='heading']"));
       
        public IWebElement deliveryAddress => driver.FindElement(By.XPath("//*[@id='address_delivery']/li[1]"));
        public IWebElement deliveryFirstLastNameInfo => driver.FindElement(By.XPath("//*[@id='address_delivery']/li[2]"));
        public IWebElement deliveryCompanyInfo => driver.FindElement(By.XPath("//*[@id='address_delivery']/li[3]"));
        public IWebElement deliveryAddress1Info => driver.FindElement(By.XPath("//*[@id='address_delivery']/li[4]"));
        public IWebElement deliveryAddress2Info => driver.FindElement(By.XPath("//*[@id='address_delivery']/li[5]"));
        public IWebElement deliveryCityNameStateZipCode => driver.FindElement(By.XPath("//*[@id='address_delivery']/li[6]"));
        public IWebElement deliveryCountryInfo => driver.FindElement(By.XPath("//*[@id='address_delivery']/li[7]"));
        public IWebElement deliveryPhoneNumberInfo => driver.FindElement(By.XPath("//*[@id='address_delivery']/li[8]"));
        public IWebElement billingAddress => driver.FindElement(By.XPath("//*[@id='address_invoice']/li[1]"));
        public IWebElement billingFirstLastNameInfo => driver.FindElement(By.XPath("//*[@id='address_invoice']/li[2]"));
        public IWebElement billingCompanyInfo => driver.FindElement(By.XPath("//*[@id='address_invoice']/li[3]"));
        public IWebElement billingAddress1Info => driver.FindElement(By.XPath("//*[@id='address_invoice']/li[4]"));
        public IWebElement billingAddress2Info => driver.FindElement(By.XPath("//*[@id='address_invoice']/li[5]"));
        public IWebElement billingCityNameStateZipCode => driver.FindElement(By.XPath("//*[@id='address_invoice']/li[6]"));
        public IWebElement billingCountryInfo => driver.FindElement(By.XPath("//*[@id='address_invoice']/li[7]"));
        public IWebElement billingPhoneNumberInfo => driver.FindElement(By.XPath("//*[@id='address_invoice']/li[8]"));
        public IWebElement productsOrder => driver.FindElement(By.XPath("//*[@id='cart_info']//tbody/tr"));
        public IWebElement cartDescription => productsOrder.FindElement(By.XPath("//td[@class='cart_description']/h4/a"));
        public IWebElement cartPrice => productsOrder.FindElement(By.XPath("//td[@class='cart_price']/h4/a"));
        public IWebElement cartQuantity => productsOrder.FindElement(By.XPath("//td[@class='cart_quantity']/button"));
        public IWebElement cartTotal => productsOrder.FindElement(By.XPath("//td[@class='cart_total']/button"));
        public IWebElement cartTotalPrice => productsOrder.FindElement(By.XPath("//td[4]/p"));

        public IWebElement commentArea => driver.FindElement(By.XPath("//textarea[@class='form-control']"));
        public IWebElement placeOrderButton => driver.FindElement(By.XPath("//*[@href='/payment']"));

       

    }
}
