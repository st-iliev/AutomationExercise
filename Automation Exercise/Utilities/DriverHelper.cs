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
        public static IWebDriver Start(BrowserType browserType)
        {
            
            switch (browserType)
            {
                case BrowserType.Chrome:
                    var chromeOptions = new ChromeOptions();
                    chromeOptions.AddArguments("--lang=en-US");
                    //chromeOptions.AddArgument("--headless");
                    return driver = new ChromeDriver(chromeOptions);
                case BrowserType.Firefox:
                    var mozillaOptions = new FirefoxOptions();
                    mozillaOptions.AddArguments("--lang=en-US");
                    //mozillaOptions.AddArgument("--headless");
                    return driver = new FirefoxDriver(mozillaOptions);
                case BrowserType.Edge:
                    var edgeOptions = new EdgeOptions();
                    edgeOptions.AddArguments("--lang=en-US");
                    //edgeOptions.AddArgument("--headless");
                    return driver = new EdgeDriver(edgeOptions);
                default:
                    throw new ArgumentException("Invalid browser type.");
            }
        }
    }
}
