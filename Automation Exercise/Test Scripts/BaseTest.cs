using Automation_Exercise.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automation_Exercise.Pages.LoginPage;
using Automation_Exercise.Pages.SignupPage;
using Automation_Exercise.Pages.AccountCreatedPage;
using Automation_Exercise.Pages.DeleteAccountPage;
using Automation_Exercise.Pages.ContactUsPage;

namespace Automation_Exercise.Test_Scripts
{
    public abstract class BaseTest
    {
        private IWebDriver driver;
        private HomePage homePage;
        private ProductPage productPage;
        private ProductDetailsPage productDetailsPage;
        private CartPage cartPage;
        private PaymentPage paymentPage;
        private PaymentDonePage paymentDonePage;
        private CheckoutPage checkoutPage;
        private LoginPage loginPage;
        private SingupPage singupPage;
        private AccountCreatedPage accountCreatedPage;
        private DeleteAccountPage deleteAccountPage;
        private ContactUsPage contactUsPage;

        public BaseTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            homePage = new HomePage(driver);
            productPage = new ProductPage(driver);
            productDetailsPage = new ProductDetailsPage(driver);
            cartPage = new CartPage(driver);
            paymentPage = new PaymentPage(driver);
            paymentDonePage = new PaymentDonePage(driver);
            checkoutPage = new CheckoutPage(driver);
            loginPage = new LoginPage(driver);
            singupPage = new SingupPage(driver);
            accountCreatedPage = new AccountCreatedPage(driver);
            deleteAccountPage = new DeleteAccountPage(driver);
            contactUsPage = new ContactUsPage(driver);
           
        }
        public void Dispose()
        {
            driver.Dispose();
        }
    }
}
