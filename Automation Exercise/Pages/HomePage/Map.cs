using Automation_Exercise.Utilities;
using OpenQA.Selenium;

namespace Automation_Exercise.Pages.HomePage
{
    partial class HomePage
    {
        public IWebElement homeLink => driver.FindElement(By.XPath("//a[contains(text(),'Home')]"));
        public IWebElement productsLink => driver.FindElement(By.XPath("//a[contains(@href,'/products')]"));
        public IWebElement cartLink => driver.FindElement(By.XPath("//a[contains(@href,'/view cart')]"));
        public IWebElement loginLink => driver.FindElement(By.XPath("//a[contains(@href,'/login')]"));
        public IWebElement logoutLink => driver.FindElement(By.XPath("//a[contains(@href,'/logout')]"));
        public IWebElement deleteAccountLink => driver.FindElement(By.XPath("//a[contains(@href,'/delete')]"));
        public IWebElement contactusLink => driver.FindElement(By.XPath("//a[contains(@href,'/contact us')]"));
        public IWebElement usernameLogin => driver.FindElement(By.XPath($"//*[@class='nav navbar-nav']//b[contains(text(), '{Constants.name}')]"));

        public IWebElement logoHomeLink => driver.FindElement(By.XPath("//*[src='/static/images/home/logo.png']"));
        public IWebElement subscribeField => driver.FindElement(By.XPath("//input[@id='susbscribe_email']"));
        public IWebElement subscribeButton => driver.FindElement(By.XPath("//button[@id='subscribe']"));
        public IWebElement subscribleSuccessfulMessage => driver.FindElement(By.XPath("//*[@class='Alert-success alert']"));
        public IWebElement webBanner => driver.FindElement(By.XPath("//*[@id='slider-carousel']"));
        public IWebElement rightArrow => driver.FindElement(By.XPath("//*[@class='fa fa-angle-right']"));
        public IWebElement leftArrow => driver.FindElement(By.XPath("//*[@class='fa fa-angle-left']"));
        public IList<IWebElement> activeIndicators => (IList<IWebElement>)driver.FindElements(By.XPath("//*[@id='slider-carousel']/ol"));
        public IList<IWebElement> allProducts => (IList<IWebElement>)driver.FindElements(By.XPath("//*[@class='features_items']"));
        public IList<WebElement> productsName => (IList<WebElement>)driver.FindElements(By.XPath("//*[@class='productinfo text-center']/p"));
        public IList<WebElement> addProductButton => (IList<WebElement>)driver.FindElements(By.XPath("//*[@class='product-overlay']//a[contains(@data-product-id,'')]"));
        public IList<WebElement> viewProducts => (IList<WebElement>)driver.FindElements(By.XPath("//*[@class='choose']"));
        public IWebElement categoryProducts => driver.FindElement(By.XPath("//h2[@class='title text-center']"));
        public IWebElement womenCategory => driver.FindElement(By.XPath("//*[contains(@href, '#Women')]"));
        public IWebElement womenDress => driver.FindElement(By.XPath("//*[contains(@href, '/category_products/1')]"));
        public IWebElement womenTops => driver.FindElement(By.XPath("//*[contains(@href, '/category_products/2')]"));
        public IWebElement womenSaree => driver.FindElement(By.XPath("//*[contains(@href, '/category_products/7')]"));
        public IWebElement menCategory => driver.FindElement(By.XPath("//*[contains(@href, '#Men')]"));
        public IWebElement menTshirts => driver.FindElement(By.XPath("//*[contains(@href, '/category_products/3')]"));
        public IWebElement menJeans => driver.FindElement(By.XPath("//*[contains(@href, '/category_products/6')]"));
        public IWebElement kidsCategory => driver.FindElement(By.XPath("//*[contains(@href, '#Kids')]"));
        public IWebElement kidsDress => driver.FindElement(By.XPath("//*[contains(@href, '/category_products/4')]"));
        public IWebElement kidsTopsAndShirts => driver.FindElement(By.XPath("//*[contains(@href, '/category_products/5')]"));
        public IWebElement brandsPolo => driver.FindElement(By.XPath("//*[contains(@href, '/brand_products/Polo')]"));
        public IWebElement brandsHandM => driver.FindElement(By.XPath("//*[contains(@href, '/brand_products/H&M')]"));
        public IWebElement brandsMademe => driver.FindElement(By.XPath("//*[contains(@href, '/brand_products/Mademe')]"));
        public IWebElement brandsMasterAndHarbour => driver.FindElement(By.XPath("//*[contains(@href, '/brand_products/Master & Harbour')]"));
        public IWebElement brandsBabyhug => driver.FindElement(By.XPath("//*[contains(@href, '/brand_products/BabyHug')]"));
        public IWebElement brandsAllenSollyJunior => driver.FindElement(By.XPath("//*[contains(@href, '/brand_products/Allen Solly Junior')]"));
        public IWebElement brandsKookieKids => driver.FindElement(By.XPath("//*[contains(@href, '/brand_products/Kookie Kids')]"));
        public IWebElement brandsBiba => driver.FindElement(By.XPath("//*[contains(@href, '/brand_products/Biba')]"));
    }
}
