using Automation_Exercise.Utilities;
using System.Collections;

namespace Automation_Exercise.src.UI.TestData
{
    public static class ProductTestCases
    {
        public static IEnumerable BrandCases()
        {
            yield return new TestCaseData(Brands.Polo);
            yield return new TestCaseData(Brands.AllenSollyJunior);
            yield return new TestCaseData(Brands.HandM);
            yield return new TestCaseData(Brands.MastAndHarbour);
            yield return new TestCaseData(Brands.KookieKids);
            yield return new TestCaseData(Brands.Biba);
            yield return new TestCaseData(Brands.Babyhug);
            yield return new TestCaseData(Brands.Madame);
        }
        public static IEnumerable CategoryCases()
        {
            yield return new TestCaseData("WOMEN");
            yield return new TestCaseData("MEN");
            yield return new TestCaseData("KIDS");
        }
        public static IEnumerable SearchProductCases()
        {
            yield return new TestCaseData("GRAPHIC DESIGN MEN T SHIRT - BLUE");
            yield return new TestCaseData("Premium Polo T-Shirts");
            yield return new TestCaseData("Lace Top For Women");
            yield return new TestCaseData("Cotton Silk Hand Block Print Saree");
            yield return new TestCaseData("Soft Stretch Jeans");
            yield return new TestCaseData("Pure Cotton V-Neck T-Shirt");
            yield return new TestCaseData("Long Maxi Tulle Fancy Dress Up Outfits -Pink");
        }
        public static IEnumerable ProductCases()
        {
            yield return new TestCaseData("Sleeveless Dress");
            yield return new TestCaseData("Men Tshirt");
            yield return new TestCaseData("Blue Top");
        }
        public static IEnumerable InvalidProductNameCases()
        {
            yield return new TestCaseData("Shoes");
            yield return new TestCaseData("Smoking");
            yield return new TestCaseData("Hat");
        }
        public static IEnumerable CategoryAndSubcategoryCases()
        {
            yield return new TestCaseData("WOMEN", "DRESS");
            yield return new TestCaseData("WOMEN", "TOPS");
            yield return new TestCaseData("WOMEN", "SAREE");
            yield return new TestCaseData("MEN", "TSHIRTS");
            yield return new TestCaseData("MEN", "JEANS");
            yield return new TestCaseData("MEN", "TSHIRTS");
            yield return new TestCaseData("KIDS", "DRESS");
            yield return new TestCaseData("KIDS", "TOPS & SHIRTS");
        }

    }
}
