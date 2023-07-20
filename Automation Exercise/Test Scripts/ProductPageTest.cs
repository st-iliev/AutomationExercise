using Automation_Exercise.Utilities;

namespace Automation_Exercise.Test_Scripts
{
    [TestFixture]
    [Order(8)]
    public class ProductPageTest : BaseTest
    {
        [Test, Order(1)]
        [TestCase("Premium Polo T-Shirts")]
        [TestCase("Soft Stretch Jeans")]
        [TestCase("Colour Blocked Shirt – Sky Blue")]
        public void VerifySearchForExistingProduct(string productName)
        {
            productPage.Open();
            productPage.AssertCorrectPageIsLoaded();
            productPage.AssertSaleBannerIsDisplayed();
            productPage.SearchForProduct(productName);
            productPage.AssertSearchedProductIsDisplaed(productName);        
        }
        [Test, Order(1)]
        [TestCase("Shoes")]
        [TestCase("Smoking")]
        [TestCase("Hat")]
        public void VerifySearchForNonExistingProduct(string productName)
        {
            productPage.Open();
            productPage.AssertCorrectPageIsLoaded();
            productPage.AssertSaleBannerIsDisplayed();
            productPage.SearchForProduct(productName);
            productPage.AssertNonProductsAreDisplayed();
        }
        [Test, Order(2)]
        [TestCase(Brands.Polo)]
        [TestCase(Brands.AllenSollyJunior)]
        [TestCase(Brands.HandM)]
        [TestCase(Brands.MastAndHarbour)]
        [TestCase(Brands.KookieKids)]
        [TestCase(Brands.Biba)]
        [TestCase(Brands.Babyhug)]
        [TestCase(Brands.Madame)]
        public void VerifyNumberOfBrandProductIsSameAsBrandProductCount(Brands brandName)
        {
            productPage.Open();
            productPage.AssertCorrectPageIsLoaded();
            productPage.AssertSaleBannerIsDisplayed();
            ScrollDown(driver, 650);
            homePage.AssertBrandProductCountAndDisplayedBrandProductsAreTheSame(brandName);
        }
        [Test, Order(3)]
        [TestCase("WOMEN")]
        [TestCase("MEN")]
        [TestCase("KIDS")]

        public void VerifyCategoryAndSubcategoryAreLoaded(string categoryName)
        {
            productPage.Open();
            productPage.AssertCorrectPageIsLoaded();
            productPage.AssertSaleBannerIsDisplayed();
            ScrollDown(driver, 250);
            homePage.SelectCategoryAndSubCategory(categoryName, null);
            switch (categoryName)
            {
                case "WOMEN":
                    homePage.AssertWomenCategoryAndSubCategoriesAreDisplayed();
                    break;
                case "MEN":
                    homePage.AssertMenCategoryAndSubCategoriesAreDisplayed();
                    break;
                case "KIDS":
                    homePage.AssertKidsCategoryAndSubCategoriesAreDisplayed();
                    break;
                default:
                    Assert.Fail("Wrong category name");
                    break;
            }

        }
    }
}
