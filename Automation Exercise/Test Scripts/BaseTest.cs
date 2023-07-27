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
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
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
        private ExtentReports extent;
        private ExtentTest test;
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            //DriverHelper.Start(BrowserType.Chrome);
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--lang=en-US");
            options.AddArgument("--headless");
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
            var htmlReporter = new ExtentHtmlReporter(@"E:\QA\QA Automation\Projects\Report.html");
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
            
        }
        [SetUp]
        public void SetUp()
        {
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
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
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript($"window.scrollBy(0, {pixels});");
        }
        protected static void BackToPreviusPage(IWebDriver driver)
        {
            if (driver.Url.EndsWith("#google_vignette"))
            {
            driver.Navigate().Back();
            driver.Navigate().Back();
            }
        }
        [TearDown]
        public void TrearDown()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;

            switch (status)
            {
                case NUnit.Framework.Interfaces.TestStatus.Failed:
                    test.Log(Status.Fail, "Test Failed");
                    test.Fail(TestContext.CurrentContext.Result.Message);
                    break;
                case NUnit.Framework.Interfaces.TestStatus.Passed:
                    test.Log(Status.Pass, "Test Passed");
                    break;
                case NUnit.Framework.Interfaces.TestStatus.Skipped:
                    test.Log(Status.Skip, "Test Skipped");
                    break;
            }
        }
        [OneTimeTearDown]
        public void Dispose()
        {
           
            extent.Flush();
            driver.Dispose();
        }
    }
}
