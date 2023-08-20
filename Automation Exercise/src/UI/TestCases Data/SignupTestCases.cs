using Automation_Exercise.Utilities;
using System.Collections;

namespace Automation_Exercise.src.UI.TestData
{
    public static class SignupTestCases
    {
        public static IEnumerable SignupWithoutNameOrEmailCases()
        {
            yield return new TestCaseData(Constants.name, "");
            yield return new TestCaseData("", Constants.email);
            yield return new TestCaseData("", "");
        }
    }
}
