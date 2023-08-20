using Automation_Exercise.Utilities;
using System.Collections;

namespace Automation_Exercise.src.UI.TestData
{
    public static class LoginTestCases
    {
        public static IEnumerable LoginWithoutEmailOrPassowrdCases()
        {
            yield return new TestCaseData(Constants.email, "");
            yield return new TestCaseData("", Constants.password);
            yield return new TestCaseData("", "");
        } 
        public static IEnumerable LoginWithInvalidEmailOrPassowrd()
        {
            yield return new TestCaseData(Constants.email, "qatest");
            yield return new TestCaseData("incorrectEmail", Constants.password);
            yield return new TestCaseData("incorrectEmail@", Constants.password);
        }
    }
}
