using System.Collections;
using Automation_Exercise.Utilities;

namespace Automation_Exercise.src.UI.TestData
{
    public static class PaymentTestCases
    {
        public static IEnumerable FormCases()
        {
            yield return new TestCaseData("", "", "", "", "");
            yield return new TestCaseData($"{Constants.firstName} {Constants.lastName}", "", "", "", "");
            yield return new TestCaseData($"{Constants.firstName} {Constants.lastName}", Constants.cardNumber, "", "", "");
            yield return new TestCaseData($"{Constants.firstName} {Constants.lastName}", Constants.cardNumber, Constants.CVC, "", "");
            yield return new TestCaseData($"{Constants.firstName} {Constants.lastName}", Constants.cardNumber, Constants.CVC, Constants.expirationMonth, "");
        }
    }
}
