﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Exercise.Pages.AccountCreatedPage
{
    partial class AccountCreatedPage
    {
        public IWebElement accountCreatedMsg => driver.FindElement(By.XPath("//h2[@data-qa='account-created']"));
        public IWebElement accountCreatedSuccessfullMsg => driver.FindElement(By.XPath("//p[contains(text(), 'Congratulations!')]"));
        public IWebElement secondAccountCreatedSuccessfullMsg => driver.FindElement(By.XPath("//*[@class='col-sm-9 col-sm-offset-1')/p[2]]"));
        public IWebElement continueButton => driver.FindElement(By.XPath("//a[@data-qa='continue-button']"));
    }
}
