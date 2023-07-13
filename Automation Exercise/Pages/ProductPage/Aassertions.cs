using Automation_Exercise.Utilities;

namespace Automation_Exercise.Pages.ProductPage
{
    partial class ProductPage
    {
        public void AssertCorrectPageIsLoaded()
        {
            Assert.AreEqual("Automation Exercise - All Products", GetPageTitle());
        }
        public void AssertSaleBannerIsDisplayed()
        {
            Assert.True(bigSaleBanner.Displayed);
        }
        public void AssertAddedIconIsDisplayed()
        {
            Assert.True(successfulAddedIcon.Displayed);
        }
        public void AssertCorrectSuccessfulTextIsDisplayed()
        {
            Assert.AreEqual(SuccessfulMessages.productAddSuccessful, productAddedSuccessfulMsg.Text);
        }
        public void AssertSearchedProductAreDisplaed()
        {
            Assert.That(allProducts.Count,Is.GreaterThan(0));
        }
        public void AssertNonProductsAreDisplayed()
        {
            Assert.AreEqual(0,allProducts.Count);
        }
        public void AssertBrandProductCountAndDisplayedBrandProductsAreTheSame(Brands brandName)
        {
            Assert.AreEqual(GetCountOfBrandProducts(brandName), NumberOfDisplayedBrandProducts(brandName));
        }
    }
}
