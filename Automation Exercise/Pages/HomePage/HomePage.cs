using Automation_Exercise.Utilities;
using OpenQA.Selenium;

namespace Automation_Exercise.Pages.HomePage
{
    public partial class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }
        private int productId;
        public int GetProductId () =>  productId;
        public override string PageURL => "https://www.automationexercise.com/";
        public void SelectCategoryAndSubCategory(string categoryName, string subCategory
            )
        {
            switch (categoryName)
            {
                case "WOMEN":
                    womenCategory.Click();
                    switch (subCategory)
                    {
                        case "DRESS":
                            womenDress.Click(); break;
                        case "TOPS":
                            womenTops.Click(); break;
                        case "SAREE":
                            womenSaree.Click(); break;
                    }
                    break;
                case "MEN":
                    menCategory.Click();
                    switch (subCategory)
                    {
                        case "TSHIRTS":
                            menTshirts.Click(); break;
                        case "JEANS":
                            menJeans.Click(); break;

                    }
                    break;
                case "KIDS":
                    kidsCategory.Click();
                    switch (subCategory)
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
            AdverticeHelper.CheckForAdvertice(driver);
        }
        public void AddProductToCart(string productName)
        {
            foreach (var product in productsName)
            {
                if (product.ToString() == productName)
                {
                    productId = int.Parse(product.GetDomProperty("data-product-id"));
                    addProductButton[productId].Click();
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
        public void Logout() => logoutLink.Click();
        public void DeleteAccount() => deleteAccountLink.Click();
        public void Subscrible(string email) => subscribeField.SendKeys(email);
        public void ClickOnSubscribeButton() => subscribeButton.Click();
        public void SwitchCarolselUsingIndicators(int indicator)
        {

            activeIndicators[indicator].Click();

        }
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
        public int NumberOfDisplayedBrandProducts(Brands brandName)
        {
            SelectBrands(brandName);
            return allProducts.Count;
        }
        public string ValidationMessage(IWebElement field) => field.GetAttribute("validationMessage");
    }
}
