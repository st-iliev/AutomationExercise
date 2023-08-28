using System.Collections;

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
