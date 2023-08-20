using System.Collections;

namespace Automation_Exercise.src.UI.TestData
{
    public static class ProductDetailsTestCases
    {
        public static IEnumerable ReviewCases()
        {
            yield return new TestCaseData("", "", "");
            yield return new TestCaseData("Jordan", "", "");
            yield return new TestCaseData("George", "email", "");
            yield return new TestCaseData("John", "email@", "");
            yield return new TestCaseData("John", "email@zzz", "");
        }
    }
}
