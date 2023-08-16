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
using Automation_Exercise.Utilities;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;

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
        protected static ExtentReports extent;
        protected ExtentTest suiteTest;
        protected ExtentTest test;
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            BrowserType browserType = BrowserType.Chrome; // Change this to the desired browser

            driver = DriverHelper.Start(browserType); //To use headless mode uncomment it in this method.
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
            if (extent == null)
            {
                var htmlReporter = new ExtentHtmlReporter(@"..\..\..\src\Common\Test Results\UI\results.html");
                extent = new ExtentReports();
                extent.AttachReporter(htmlReporter);
            }
        }
        protected static void ScrollToTop(IWebDriver driver)
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript("window.scrollTo(0, -document.body.scrollHeight)");
            
        }
        protected static void ScrollToBottom(IWebDriver driver)
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
        }
        protected static void ScrollDown(IWebDriver driver, int pixels)
        {
            //Scrolling down  to avoid ads.
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript($"window.scrollBy(0, {pixels});");
        }
        protected static void BackToPreviusPage(IWebDriver driver)
        {
            //Using this method because in some cases every time ads are different.
            if (driver.Url.EndsWith("#google_vignette"))
            {
            driver.Navigate().Back();
            driver.Navigate().Back();
            }
        }
        [TearDown]
        public void AfterTest()
        {
            // Get the test result and update the test status
            var message = TestContext.CurrentContext.Result.Message;
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            if (status == TestStatus.Failed)
            {
                test.Fail($"Test has failed {message}");
            }
            else if (status == TestStatus.Passed)
            {
                test.Pass($"Test has passed {message}");
            }
            else if (status == TestStatus.Skipped)
            {
                test.Skip($"Test skipped {message}");
            }
            extent.Flush();
        }
        [OneTimeTearDown]
        public void Dispose()
        {
            extent.Flush(); //End report
            driver.Dispose();
        }
    }
}
