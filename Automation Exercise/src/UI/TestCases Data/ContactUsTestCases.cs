using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Exercise.src.UI.TestData
{
    public static class ContactUsTestCases
    {
        public static IEnumerable InvalidEmailCases()
        {
            yield return new TestCaseData("invalidEmail");
            yield return new TestCaseData("invalidEmail@");
            yield return new TestCaseData(" ");
        }
    }
}
