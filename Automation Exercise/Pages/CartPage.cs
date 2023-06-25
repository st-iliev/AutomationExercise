using OpenQA.Selenium;

namespace Automation_Exercise.Pages
{
    public class CartPage : BasePage
    {
        public CartPage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageURL => "https://www.automationexercise.com/view_cart";
        public IList<WebElement> productList => (IList<WebElement>)driver.FindElement(By.XPath("//*[@id='cart_info_table']/tbody"));
        public IWebElement proceedToCheckoutButton => driver.FindElement(By.XPath("//a[@class='btn btn-default check_out']"));
        public IWebElement continueOnCardButton => driver.FindElement(By.XPath("//button[@class='btn btn-success close-checkout-modal btn-block']"));
        public IWebElement loginRegister => driver.FindElement(By.XPath("//p[contains(@href,'/login']"));
        public IWebElement emptyCartMessage => driver.FindElement(By.XPath("//span[@id='empty_cart']/p"));
        public IWebElement homeButton => driver.FindElement(By.XPath("//*[@id='cart_items']//a[contains(text(),'Home')]"));

    }
}
