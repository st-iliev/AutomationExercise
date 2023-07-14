using Automation_Exercise.Utilities;

namespace Automation_Exercise.Test_Scripts
{
    public class HomePageTests : BaseTest
    {
        [TestCase("WOMEN")]
        [TestCase("MEN")]
        [TestCase("KIDS")]
        
        public void VerifyCategoryAndSubcategory(string categoryName)
        {
            homePage.Open();
            homePage.AssertCorrectPageIsLoaded();
            homePage.AssertWebBannerIsDisplayed();
            ScrollDown(driver, 250);
            homePage.SelectCategoryAndSubCategory(categoryName, "");
            switch (categoryName)
            {
                case "WOMEN":
                    homePage.AssertWomenCategoryIsDisplayed();
                    break;
                case "MEN":
                    homePage.AssertMenCategoryIsDisplayed();
                    break;
                case "KIDS":
                    homePage.AssertKidsCategoryIsDisplayed();
                    break;
                default:
                    break;
            }
            
        }
        [Test]
        public void VerifyNumberOfBrandProductIsSameAsBrandProductCount()
        {
            homePage.Open();
            homePage.AssertCorrectPageIsLoaded();
            homePage.AssertWebBannerIsDisplayed();
            ScrollDown(driver, 500);
            homePage.AssertBrandProductCountAndDisplayedBrandProductsAreTheSame(Brands.Biba);
        }
        [Test]
        public void VerifySuccessfullSubscribe()
        {
            homePage.Open();
            homePage.AssertCorrectPageIsLoaded();
            homePage.AssertWebBannerIsDisplayed();
            ScrollToBottom(driver);
            homePage.Subscrible(Constants.email);
            homePage.ClickOnSubscribeButton();
            homePage.AssertCorrectSuccessfulSubscribeMessageIsDisplayed();
        }
        [TestCase("")]
        [TestCase("invalidEmail")]
        [TestCase("invalidEmail@")]
        public void VerifySubscribeWithInvalidEmail(string email)
        {
            homePage.Open();
            homePage.AssertCorrectPageIsLoaded();
            homePage.AssertWebBannerIsDisplayed();
            ScrollToBottom(driver);
            homePage.Subscrible(email);
            homePage.ClickOnSubscribeButton();
            switch (email)
            {
                case "":
                    homePage.AssertErrorEmptyFieldMessageIsDisplayed(homePage.subscribeField); break;
                case "invalidEmail":
                    homePage.AssertErrorInvalidEmailAddressMessageIsDisplayed(homePage.subscribeField,email); break;
                case "invalidEmail@":
                    homePage.AssertErrorIncompleteEmailAddressMessageIsDisplayed(homePage.subscribeField, email); break;
            };
        }
    }
}
