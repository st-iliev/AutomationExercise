using OpenQA.Selenium;

namespace Automation_Exercise.Utilities
{
    public static class AlertHelper
    {
        public static void CheckForAlert(IWebDriver driver)
        {
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
        }
    }
}
