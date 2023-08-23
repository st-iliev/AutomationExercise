using System.Collections;

namespace Automation_Exercise.src.UI.TestData
{
    public static class HomePageTestCases
    {
        public static IEnumerable CarouselIndicatorsCases()
        {
            yield return new TestCaseData("First");
            yield return new TestCaseData("Second");
            yield return new TestCaseData("Third");
        }  
        public static IEnumerable CarouselArrowCases()
        {
            yield return new TestCaseData("left");
            yield return new TestCaseData("right");
            yield return new TestCaseData("right");
            yield return new TestCaseData("right");
            yield return new TestCaseData("left");
            yield return new TestCaseData("left");
        }
        public static IEnumerable SidesOfArrowsCases()
        {
            yield return new TestCaseData("left");
            yield return new TestCaseData("left");
            yield return new TestCaseData("right");
            yield return new TestCaseData("right");
        }
        public static IEnumerable ProductOverlayInfo()
        {
            yield return new TestCaseData("Blue Top");
            yield return new TestCaseData("Men Tshirt");
            yield return new TestCaseData("Sleeveless Dress");
        }
    }
}
