using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;


namespace Automation_Exercise.Utilities
{
    public class DriverHelper
    {
        private static IWebDriver driver;
        public static void Start(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    driver = new ChromeDriver();
                    break;
                case BrowserType.Firefox:
                    driver = new FirefoxDriver();
                    break;
                case BrowserType.Edge:
                    driver = new EdgeDriver();
                    break; 
                case BrowserType.Safari:
                    driver = new SafariDriver();
                    break;
                case BrowserType.Opera:
                    ChromeOptions options = new ChromeOptions();
                    driver = new ChromeDriver(options);
                    options.AddArgument("--user-data-dir=C:/Users/YourUsername/AppData/Roaming/Opera Software/Opera Stable");
                    break;
                case BrowserType.Brave:
                    ChromeOptions braveOptions = new ChromeOptions();
                    braveOptions.AddArgument("--user-data-dir=C:/Program Files/BraveSoftware/Brave-Browser/Application");
                    driver = new ChromeDriver(braveOptions);
                    break;            
            }
        }
    }
}
