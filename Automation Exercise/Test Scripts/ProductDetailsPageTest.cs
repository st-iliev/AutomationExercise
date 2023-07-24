using Automation_Exercise.Pages.ProductDetailsPage;
using Automation_Exercise.Utilities;

namespace Automation_Exercise.Test_Scripts
{
    public class ProductDetailsPageTest : BaseTest
    {
        private ReviewForm form;
        [Test, Order(1)]
        public void VerifySuccessfulSubscribe()
        {
            homePage.Open();
            homePage.AssertCorrectPageIsLoaded();
            homePage.AssertWebBannerIsDisplayed();
            ScrollDown(driver, 600);
            homePage.ClickOnViewProduct("Blue Top");
            AdverticeHelper.CheckForAdvertice(driver);
            productDetailsPage.AssertCorrectPageIsLoaded();
            ScrollToBottom(driver);
            homePage.Subscrible(Constants.email);
            homePage.ClickOnSubscribeButton();
            homePage.AssertCorrectSuccessfulSubscribeMessageIsDisplayed();
        }
        [Test, Order(2)]
        [TestCase("")]
        [TestCase("invalidEmail")]
        [TestCase("invalidEmail@")]
        public void VerifySubscribeWithInvalidEmail(string email)
        {
            homePage.Open();
            homePage.AssertCorrectPageIsLoaded();
            homePage.AssertWebBannerIsDisplayed();
            ScrollDown(driver, 600);
            homePage.ClickOnViewProduct("Blue Top");
            AdverticeHelper.CheckForAdvertice(driver);
            ScrollToBottom(driver);
            homePage.Subscrible(email);
            homePage.ClickOnSubscribeButton();
            switch (email)
            {
                case null:
                    homePage.AssertErrorEmptyFieldMessageIsDisplayed(homePage.subscribeField); break;
                case "invalidEmail":
                    homePage.AssertErrorInvalidEmailAddressMessageIsDisplayed(homePage.subscribeField, email); break;
                case "invalidEmail@":
                    homePage.AssertErrorIncompleteEmailAddressMessageIsDisplayed(homePage.subscribeField, email); break;
            };
        }
        [Test, Order(3)]
        [TestCase("Sleeveless Dress")]
        [TestCase("Men Tshirt")]
        [TestCase("Blue Top")]
        public void VerifyOpenProductDetailsPageFromHomePage(string productName)
        {
            homePage.Open();
            homePage.AssertCorrectPageIsLoaded();
            homePage.AssertWebBannerIsDisplayed();
            ScrollDown(driver, 600);
            homePage.ClickOnViewProduct(productName);
            AdverticeHelper.CheckForAdvertice(driver);
            productDetailsPage.AssertCorrectPageIsLoaded();
            productDetailsPage.AssertCorrectProductName(productName);
        }
        [Test, Order(4)]
        [TestCase("Sleeveless Dress")]
        [TestCase("Men Tshirt")]
        [TestCase("Blue Top")]
        public void VerifyOpenProductDeatailsPageFromProductPage(string productName)
        {
            productPage.Open();
            productPage.AssertCorrectPageIsLoaded();
            productPage.AssertSaleBannerIsDisplayed();
            ScrollDown(driver, 600);
            productPage.ClickOnViewProduct(productName);
            AdverticeHelper.CheckForAdvertice(driver);
            productDetailsPage.AssertCorrectPageIsLoaded();
            productDetailsPage.AssertCorrectProductName(productName);
        }
        [Test, Order(5)]
        [TestCase("Stylish Dress")]
        public void VerifyProductDetailsAreCorrect(string productName)
        {
            homePage.Open();
            homePage.AssertCorrectPageIsLoaded();
            homePage.AssertWebBannerIsDisplayed();
            ScrollDown(driver, 1100);
            int productPrice = homePage.GetProductPrice(productName);
            homePage.ClickOnViewProduct(productName);
            AdverticeHelper.CheckForAdvertice(driver);
            productDetailsPage.AssertCorrectPageIsLoaded();
            productDetailsPage.AssertProductPictureIsDisplayed();
            productDetailsPage.AssertCorrectProductName(productName);
            productDetailsPage.AssertCorrectProductPrice(productPrice);
            productDetailsPage.AssertCorrectProductBrandName(Brands.Madame);
            productDetailsPage.AssertCorrectProductCondition("New");
            productDetailsPage.AssertProductIsAvailable();
        }
        [Test, Order(6)]
        public void VerifySubmitVeviewForProductWithValidData()
        {
            homePage.Open();
            homePage.AssertCorrectPageIsLoaded();
            homePage.AssertWebBannerIsDisplayed();
            ScrollDown(driver, 750);
            homePage.ClickOnViewProduct("Blue Top");
            AdverticeHelper.CheckForAdvertice(driver);
            productDetailsPage.AssertCorrectPageIsLoaded();
            productDetailsPage.AssertCorrectProductName("Blue Top");
            form = new ReviewForm()
            {
                Name = Constants.firstName,
                Email = Constants.email,
                ReviewText = Constants.productReviewText
            };
            productDetailsPage.FillReviewForm(form);
            ScrollDown(driver, 600);
            productDetailsPage.SubmitReview();
            productDetailsPage.AssertSuccessfulSubmiteReviewMessageIsDisplayed();
        }
        [Test, Order(7)]
        [TestCase("", "", "")]
        [TestCase("Jordan", "", "")]
        [TestCase("George", "email", "")]
        [TestCase("John", "email@", "")]
        [TestCase("John", "email@zzz", "")]
        public void VerifySubmitVeviewForProductWithValidData(string name, string email, string reviewText)
        {
            homePage.Open();
            homePage.AssertCorrectPageIsLoaded();
            homePage.AssertWebBannerIsDisplayed();
            ScrollDown(driver, 750);
            homePage.ClickOnViewProduct("Blue Top");
            AdverticeHelper.CheckForAdvertice(driver);
            productDetailsPage.AssertCorrectPageIsLoaded();
            productDetailsPage.AssertCorrectProductName("Blue Top");
            form = new ReviewForm()
            {
                Name = name,
                Email = email,
                ReviewText = reviewText
            };
            productDetailsPage.FillReviewForm(form);
            ScrollDown(driver, 600);
            productDetailsPage.SubmitReview();
            if (name == "")
            {
                productDetailsPage.AssertErrorEmptyFieldMessageIsDisplayed(productDetailsPage.nameField);
            }
            else if (email == "")
            {
                switch (email)
                {
                    case "": productDetailsPage.AssertErrorEmptyFieldMessageIsDisplayed(productDetailsPage.emailAddressField); break;
                    case "email": productDetailsPage.AssertErrorInvalidEmailAddressMessageIsDisplayed(productDetailsPage.emailAddressField, email); break;
                    case "email@": productDetailsPage.AssertErrorIncompleteEmailAddressMessageIsDisplayed(productDetailsPage.emailAddressField, email); break;
                }
            }
            else
            {
                productDetailsPage.AssertErrorEmptyFieldMessageIsDisplayed(productDetailsPage.reviewField);
            }
        }
        [Test, Order(8)]
        [TestCase("Sleeveless Dress")]
        public void VerifyAddProductFromDetailsPrage(string productName)
        {
            homePage.Open();
            homePage.AssertCorrectPageIsLoaded();
            homePage.AssertWebBannerIsDisplayed();
            ScrollDown(driver, 600);
            int productPrice = homePage.GetProductPrice(productName);
            homePage.ClickOnViewProduct(productName);
            AdverticeHelper.CheckForAdvertice(driver);
            productDetailsPage.AssertCorrectPageIsLoaded();
            productDetailsPage.AssertProductPictureIsDisplayed();
            productDetailsPage.AssertCorrectProductName(productName);
            productDetailsPage.AssertCorrectProductPrice(productPrice);
            productDetailsPage.AddProductToCart();
            productDetailsPage.AssertAddedIconIsDisplayed();
            productDetailsPage.AssertProductAddedSuccessfulTextIsDisplayed();
            productDetailsPage.OpenCart();
            cartPage.AssertCorrectPageIsLoaded();
            cartPage.AssertProductIsAddedToCart(productName);
            cartPage.RemoveProductFromOrder(productName);
        }
        [Test, Order(9)]
        [TestCase("Blue Top", 3)]
        public void VerifyChangeQuantityAndAddProductFromDetailsPrage(string productName, int quantity)
        {
            homePage.Open();
            homePage.AssertCorrectPageIsLoaded();
            homePage.AssertWebBannerIsDisplayed();
            ScrollDown(driver, 600);
            int productPrice = homePage.GetProductPrice(productName);
            homePage.ClickOnViewProduct(productName);
            AdverticeHelper.CheckForAdvertice(driver);
            productDetailsPage.AssertCorrectPageIsLoaded();
            productDetailsPage.AssertProductPictureIsDisplayed();
            productDetailsPage.AssertCorrectProductName(productName);
            productDetailsPage.AssertCorrectProductPrice(productPrice);
            productDetailsPage.SetProductQuantity(quantity);
            productDetailsPage.AddProductToCart();
            productDetailsPage.AssertAddedIconIsDisplayed();
            productDetailsPage.AssertProductAddedSuccessfulTextIsDisplayed();
            productDetailsPage.OpenCart();
            cartPage.AssertCorrectPageIsLoaded();
            cartPage.AssertProductIsAddedToCart(productName); //TODO
            cartPage.AssertCorrectProductQuantity(productName, quantity);
            cartPage.AssertTotalPriceOfProductIsCorrect(productName);
        }
    }
}
