using Automation_Exercise.Utilities;

namespace Automation_Exercise.Test_Scripts
{
    public class HomePageTests : BaseTest
    {
        [Test]
        public void VerifyWomenSubCategoris()
        {
            homePage.Open();
            homePage.AssertCorrectPageIsLoaded();
            homePage.AssertWebBannerIsDisplayed();
            homePage.SelectCategoryAndSubCategory("WOMEN", "");
            homePage.AssertWomenCategoryIsDisplayed();
        }
        [Test]
        public void VerifyMenSubCategoris()
        {
            homePage.Open();
            homePage.AssertCorrectPageIsLoaded();
            homePage.AssertWebBannerIsDisplayed();
            homePage.SelectCategoryAndSubCategory("MEN", "");
            homePage.AssertMenCategoryIsDisplayed();
        }
        [Test]
        public void VerifyKidsSubCategoris()
        {
            homePage.Open();
            homePage.AssertCorrectPageIsLoaded();
            homePage.AssertWebBannerIsDisplayed();
            homePage.SelectCategoryAndSubCategory("KIDS", "");
            homePage.AssertKidsCategoryIsDisplayed();
        }
        [Test]
        public void VerifyNumberOfBrandProductIsSameAsBrandProductCount()
        {
            homePage.Open();
            homePage.AssertCorrectPageIsLoaded();
            homePage.AssertWebBannerIsDisplayed();
            homePage.AssertBrandProductCountAndDisplayedBrandProductsAreTheSame(Brands.Biba);
        }
        [Test]
        public void VerifySuccessfullSubscribe()
        {
            homePage.Open();
            homePage.AssertCorrectPageIsLoaded();
            homePage.AssertWebBannerIsDisplayed();
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
            homePage.Subscrible(Constants.email);
            homePage.ClickOnSubscribeButton();
            switch (email)
            {
                case "":
                    homePage.AssertErrorEmptyFieldMessageIsDisplayed(homePage.subscribeField); break;
                case "invalidEmail":
                    homePage.AssertErrorInvalidEmailAddressMessageIsDisplayed(homePage.subscribeField,email); break;
                case "invalidEmail@":
                    homePage.AssertErrorInvalidEmailAddressMessageIsDisplayed(homePage.subscribeField, email); break;
            };
        }
    }
}
