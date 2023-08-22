using System.Collections;

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
