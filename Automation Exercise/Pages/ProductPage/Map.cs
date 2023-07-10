using OpenQA.Selenium;

namespace Automation_Exercise.Pages.ProductPage
{
    partial class ProductPage
    {
        public IWebElement bigSaleBanner => driver.FindElement(By.XPath("//*[@id='sale_image']"));
        public IWebElement searchField => driver.FindElement(By.XPath("//*[@id='search_product']"));
        public IWebElement searchButton => driver.FindElement(By.XPath("//*[@id='submit_search']"));
        public IList<IWebElement> allProducts => (IList<IWebElement>)driver.FindElements(By.XPath("//*[@class='features_items']/*[@class='col-sm-4']"));
        public IList<IWebElement> productsName => (IList<IWebElement>)driver.FindElements(By.XPath("//*[@class='productinfo text-center']"));
        public IList<IWebElement> addProductButton => (IList<IWebElement>)driver.FindElements(By.XPath("//*[@class='productinfo text-center']//a[contains(@data-product-id,'')]"));
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
        public IWebElement successfulAddedIcon => driver.FindElement(By.XPath("//i[@class='material-icons']"));
        public IWebElement productAddedSuccessfulMsg => driver.FindElement(By.XPath("//p[@class='text-center'][1]"));
        public IWebElement viewCart => driver.FindElement(By.XPath("//p[@class='text-center'][2]/a"));
        public IWebElement continueShoppingButton => driver.FindElement(By.XPath("//button[@data-dismiss='modal']"));
    }
}
