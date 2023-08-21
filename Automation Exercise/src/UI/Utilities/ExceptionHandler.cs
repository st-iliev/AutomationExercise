using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Automation_Exercise.src.UI.Utilities
{
    public  static class ExceptionHandler
    {
       public static void HandleException(Action testCode)
        {
            try
            {
                testCode(); // Execute the test code provided as an Action
            }
            catch (WebDriverException ex)
            {
                // Handle WebDriverException here
            }
            catch (Exception ex)
            {
                // Handle other exceptions here
            }
        }

    }
}
