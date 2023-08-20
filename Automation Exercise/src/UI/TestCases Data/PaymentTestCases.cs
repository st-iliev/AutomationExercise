using System.Collections;

namespace Automation_Exercise.src.UI.TestData
{
    public static class PaymentTestCases
    {
        public static IEnumerable FormCases()
        {
            yield return new TestCaseData("", "", "", "", "");
            yield return new TestCaseData("name", "", "", "", "");
            yield return new TestCaseData("name", "number", "", "", "");
            yield return new TestCaseData("name", "number", "cvc", "", "");
            yield return new TestCaseData("name", "number", "cvc", "month", "");
        }
    }
}
