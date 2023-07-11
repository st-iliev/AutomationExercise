using Automation_Exercise.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Internal;

namespace Automation_Exercise.Pages.ProductPage
{
    public partial class ProductPage : BasePage
    {

        public ProductPage(IWebDriver driver) : base(driver)
        {
        }
        private int productId;
        public int GetProductId() => productId;
        public override string PageURL => "https://www.automationexercise.com/products";
        public void SelectCategoryAndProductType(string categoryName, string productType)
        {
            switch (categoryName)
            {
                case "Women":
                    womenCategory.Click();
                    switch (productType)
                    {
                        case "DRESS":
                            womenDress.Click(); break;
                        case "TOPS":
                            womenDress.Click(); break;
                        case "SAREE":
                            womenSaree.Click(); break;
                    }
                    break;
                case "Men":
                    menCategory.Click();
                    switch (productType)
                    {
                        case "TSHIRTS":
                            menTshirts.Click(); break;
                        case "JEANS":
                            menJeans.Click(); break;

                    }
                    break;
                case "Kids":
                    kidsCategory.Click();
                    switch (productType)
                    {
                        case "DRESS":
                            kidsDress.Click(); break;
                        case "TOPS&SHIRTS":
                            kidsTopsAndShirts.Click(); break;

                    }
                    break;
            }
        }
        public void SelectBrands(Brands brandName)
        {
            switch (brandName)
            {
                case Brands.Polo:
                    brandsPolo.Click(); break;
                case Brands.HandM:
                    brandsHandM.Click(); break;
                case Brands.Madame:
                    brandsMademe.Click(); break;
                case Brands.MastAndHarbour:
                    brandsMasterAndHarbour.Click(); break;
                case Brands.Babyhug:
                    brandsBabyhug.Click(); break;
                case Brands.AllenSollyJunior:
                    brandsAllenSollyJunior.Click(); break;
                case Brands.KookieKids:
                    brandsKookieKids.Click(); break;
                case Brands.Biba:
                    brandsBiba.Click(); break;
            }
        }
        public void SearchProduct(string productName) => searchField.SendKeys(productName);
        public void ClickOnSearch() => searchField.Click();
        public void AddProductToCart(string productName)
        {
            foreach (var product in productsName)
            {
                if (product.FindElement(By.TagName("p")).Text == productName)
                {
                    var element = product.FindElement(By.TagName("a"));
                    productId = int.Parse(element.GetAttribute("data-product-id"));
                    addProductButton[productId-1].Click();
                    break;
                }
            }

        }
        public void ViewProduct(string productName)
        {
            foreach (var product in productsName)
            {
                if (product.ToString() == productName)
                {
                    int productId = int.Parse(product.GetDomProperty("data-product-id"));
                    viewProducts[productId].Click();
                }
            }
        }
        public void ContinueToShopping() => continueShoppingButton.Click();
        public void OpenCart() => viewCart.Click();
        
        public int GetCountOfBrandProducts(Brands brandName)
        {
            int count = 0;
            switch (brandName)
            {
                case Brands.Polo:
                  count = int.Parse(brandsPolo.FindElement(By.TagName("span")).Text.Trim('(', ')'));
                    break;
                case Brands.HandM:
                    count = int.Parse(brandsHandM.FindElement(By.TagName("span")).Text.Trim('(', ')'));
                    break;
                case Brands.Madame:
                    count = int.Parse(brandsMademe.FindElement(By.TagName("span")).Text.Trim('(', ')'));
                    break;
                case Brands.Babyhug:
                    count = int.Parse(brandsBabyhug.FindElement(By.TagName("span")).Text.Trim('(', ')'));
                    break;
                case Brands.AllenSollyJunior:
                    count = int.Parse(brandsAllenSollyJunior.FindElement(By.TagName("span")).Text.Trim('(', ')'));
                    break;
                case Brands.KookieKids:
                    count = int.Parse(brandsKookieKids.FindElement(By.TagName("span")).Text.Trim('(', ')'));
                    break;
                case Brands.Biba:
                    count = int.Parse(brandsBiba.FindElement(By.TagName("span")).Text.Trim('(', ')'));
                    break;
            }
            return count;
        }
    }
}
