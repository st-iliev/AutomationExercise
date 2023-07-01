using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Exercise.Pages.DeleteAccountPage
{
    public partial class DeleteAccountPage : BasePage
    {
        public DeleteAccountPage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageURL => "https://www.automationexercise.com/delete_account";
       
    }
}
