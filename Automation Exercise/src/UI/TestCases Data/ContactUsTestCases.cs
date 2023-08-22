using System.Collections;

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
