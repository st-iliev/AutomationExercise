using Automation_Exercise.Utilities;
using OpenQA.Selenium;

namespace Automation_Exercise.Pages.ProductPage
{
    public partial class ProductPage : BasePage
    {

        public ProductPage(IWebDriver driver) : base(driver)
        {
        }
        public override string PageURL => "https://www.automationexercise.com/products";
       public void SelectCategoryAndProductType(string categoryName,string productType )
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
                    switch(productType) 
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
        public void SearchProduct(string productName)
        {
            searchField.SendKeys(productName);
            searchButton.Click();
        }
        //TODO
    }
}
