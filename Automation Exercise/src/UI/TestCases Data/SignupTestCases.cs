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
        public static IEnumerable ErrorMessagesOnSignup()
        {
            yield return new TestCaseData("", "", "", "", "", "", "", "", "");
            yield return new TestCaseData(Constants.password, "", "", "", "", "", "", "", "");
            yield return new TestCaseData(Constants.password, Constants.firstName, "", "", "", "", "", "", "");  
            yield return new TestCaseData(Constants.password, Constants.firstName, Constants.lastName, "", "", "", "", "", "");
            yield return new TestCaseData(Constants.password, Constants.firstName, Constants.lastName, Constants.firstAddress, Constants.country, "", "", "", "");
            yield return new TestCaseData(Constants.password, Constants.firstName, Constants.lastName, Constants.firstAddress, Constants.country, Constants.state, "", "", "");
            yield return new TestCaseData(Constants.password, Constants.firstName, Constants.lastName, Constants.firstAddress, Constants.country, Constants.state, Constants.city, "", "");
            yield return new TestCaseData(Constants.password, Constants.firstName, Constants.lastName, Constants.firstAddress, Constants.country, Constants.state, Constants.city, Constants.zipCode, "");
        }
    }
}
