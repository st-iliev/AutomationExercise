using System.Collections;

namespace Automation_Exercise.src.UI.TestData
{
    public static class HeaderTestCases
    {
        public static IEnumerable NavigationLinksCases()
        {
            yield return new TestCaseData("Products");
            yield return new TestCaseData("Cart");
            yield return new TestCaseData("Login");
            yield return new TestCaseData("Test Cases");
            yield return new TestCaseData("API Testing");
           // yield return new TestCaseData("Video Tutorials");
            yield return new TestCaseData("Contact us");
        }
    }
}
