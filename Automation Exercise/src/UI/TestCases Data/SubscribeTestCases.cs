using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Exercise.src.UI.TestData
{
    public static class SubscribeTestCases
    {
        public static IEnumerable InvalidSubscribeCases()
        {
            yield return new TestCaseData("");
            yield return new TestCaseData("invalidEmail");
            yield return new TestCaseData("invalidEmail@");
        }
        
    }
}
