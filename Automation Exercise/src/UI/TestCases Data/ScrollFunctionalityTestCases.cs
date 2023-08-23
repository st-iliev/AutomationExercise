using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Exercise.src.UI.TestCases_Data
{
    public static class ScrollFunctionalityTestCases
    {
        public static IEnumerable ScrollDownHeightCases()
        {
            yield return new TestCaseData(1250);
            yield return new TestCaseData(2980);
            yield return new TestCaseData(4550);
            yield return new TestCaseData(6310);
        }
    }
}
