using Automation_Exercise.Utilities;

namespace Automation_Exercise.Pages.ProductDetailsPage
{
    partial class ProductDetailsPage
    {
        public void AssertCorrectPageIsLoaded()
        {
            Assert.AreEqual("Automation Exercise - Product Details", GetPageTitle());
        }
        public void AssertProductPictureIsDisplayed()
        {
            Assert.True(productPicture.Displayed);
        }
        public void AssertCorrectProductDetailsPageIsOpened(string productId)
        {
            Assert.AreEqual(GeneratePageDetailsUrl(productId), GetPageUrl());
        }
        public void AssertCorrectProductName(string nameOfProduct)
        {
            Assert.AreEqual(nameOfProduct, productName.Text);
        }
        public void AssertCorrectProductAvailability()
        {
            Assert.AreEqual("In Stock", avaliableInfo.Text);
        }
        public void AssertCorrectProductCondition(string condition)
        {
            Assert.AreEqual(condition, conditionInfo.Text);
        }
        public void AssertCorrectProductBrandName(Brands brandName)
        {
            Assert.AreEqual(brandName.ToString(), brandInfo.Text);
        }
    }
}

