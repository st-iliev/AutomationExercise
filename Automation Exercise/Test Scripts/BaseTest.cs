using Automation_Exercise.Pages.AccountCreatedPage;
using Automation_Exercise.Pages.CartPage;
using Automation_Exercise.Pages.CheckoutPage;
using Automation_Exercise.Pages.ContactUsPage;
using Automation_Exercise.Pages.DeleteAccountPage;
using Automation_Exercise.Pages.HomePage;
using Automation_Exercise.Pages.LoginPage;
using Automation_Exercise.Pages.PaymentDonePage;
using Automation_Exercise.Pages.PaymentPage;
using Automation_Exercise.Pages.ProductDetailsPage;
using Automation_Exercise.Pages.ProductPage;
using Automation_Exercise.Pages.SignupPage;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Automation_Exercise.Test_Scripts
{
    public abstract class BaseTest
    {
        protected IWebDriver driver;
        protected HomePage homePage;
        protected ProductPage productPage;
        protected ProductDetailsPage productDetailsPage;
        protected CartPage cartPage;
        protected PaymentPage paymentPage;
        protected PaymentDonePage paymentDonePage;
        protected CheckoutPage checkoutPage;
        protected LoginPage loginPage;
        protected SignupPage signupPage;
        protected AccountCreatedPage accountCreatedPage;
        protected DeleteAccountPage deleteAccountPage;
        protected ContactUsPage contactUsPage;
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            //DriverHelper.Start(BrowserType.Chrome);
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--lang=en-US");
            //options.AddArgument("--headless");
            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            homePage = new HomePage(driver);
            productPage = new ProductPage(driver);
            productDetailsPage = new ProductDetailsPage(driver);
            cartPage = new CartPage(driver);
            paymentPage = new PaymentPage(driver);
            paymentDonePage = new PaymentDonePage(driver);
            checkoutPage = new CheckoutPage(driver);
            loginPage = new LoginPage(driver);
            signupPage = new SignupPage(driver);
            accountCreatedPage = new AccountCreatedPage(driver);
            deleteAccountPage = new DeleteAccountPage(driver);
            contactUsPage = new ContactUsPage(driver);
           
        }
        [OneTimeTearDown]
        public void Dispose()
        {
            driver.Dispose();
        }
       
    }
}
