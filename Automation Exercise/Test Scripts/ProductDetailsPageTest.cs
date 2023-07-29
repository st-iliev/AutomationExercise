using Automation_Exercise.Pages.ProductDetailsPage;
using Automation_Exercise.Utilities;

namespace Automation_Exercise.Test_Scripts
{
    [TestFixture]
    [Order(6)]
    public class ProductDetailsPageTest : BaseTest
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            suiteTest = extent.CreateTest("Product Details Page Tests");
        }
        [SetUp]
        public void Preconditions()
        {
            homePage.Open();
            homePage.AssertCorrectPageIsLoaded();
            homePage.AssertWebBannerIsDisplayed();
        }
        private ReviewForm form;
        [Test, Order(1)]
        public void VerifySuccessfulSubscribe()
        {
            test = suiteTest.CreateNode("Test Sucessful Subscribe With Valid Credential");
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
            test = suiteTest.CreateNode("Test Subscribe With Invalid Credential");
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
        [TestCase("Stylish Dress")]
        public void VerifyProductDetailsAreCorrect(string productName)
        {
            test = suiteTest.CreateNode("Test Product Details Are Correct");
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
        [Test, Order(4)]
        public void VerifySubmitReviewForProductWithValidData()
        {
            test = suiteTest.CreateNode("Test Submit Review For Product With Valaid Credentials");
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
        [Test, Order(5)]
        [TestCase("", "", "")]
        [TestCase("Jordan", "", "")]
        [TestCase("George", "email", "")]
        [TestCase("John", "email@", "")]
        [TestCase("John", "email@zzz", "")]
        public void VerifySubmitVeviewForProductWithValidData(string name, string email, string reviewText)
        {
            test = suiteTest.CreateNode("Test Submit Review For Product With Invalaid Credentials");
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
        [Test, Order(6)]
        [TestCase("Sleeveless Dress")]
        public void VerifyAddProductFromDetailsPage(string productName)
        {
            test = suiteTest.CreateNode("Test Successful Add Product From ProductDetailsPage");
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
        [Test, Order(7)]
        [TestCase("Blue Top", 3)]
        public void VerifyChangeQuantityAndAddProductFromDetailsPrage(string productName, int quantity)
        {
            test = suiteTest.CreateNode("Test Successful Change Quantity of Product And Add To Product To Cart From ProductDeatailsPage ");
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
            cartPage.AssertProductIsAddedToCart(productName);
            cartPage.AssertCorrectProductQuantity(productName, quantity);
            cartPage.AssertTotalPriceOfProductIsCorrect(productName);
        }
    }
}
