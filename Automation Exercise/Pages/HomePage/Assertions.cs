namespace Automation_Exercise.Pages.HomePage
{
    partial class HomePage
    {
        public void AssertCorrectPageIsLoaded()
        {
            Assert.AreEqual("Automation Exercise", GetPageTitle());
        } 
        public void AssertWebBannerIsDisplayed()
        {
            Assert.True(webBanner.Displayed);
        }
        public void AssertWomenCategoryIsDisplayed()
        {
            Assert.True(womenCategory.Displayed);
            Assert.True(womenDress.Displayed);
            Assert.True(womenTops.Displayed);
            Assert.True(womenSaree.Displayed);
        } 
        public void AssertMenCategoryIsDisplayed()
        {
            Assert.True(menCategory.Displayed);
            Assert.True(menTshirts.Displayed);
            Assert.True(menJeans.Displayed);
        }
        public void AssertKidsCategoryIsDisplayed()
        {
            Assert.True(kidsCategory.Displayed);
            Assert.True(kidsDress.Displayed);
            Assert.True(kidsTopsAndShirts.Displayed);
        }
        public void AssertAllBrandsAreDisplayed()
        {
            Assert.True(brandsPolo.Displayed);
            Assert.True(brandsHandM.Displayed);
            Assert.True(brandsMademe.Displayed);
            Assert.True(brandsMasterAndHarbour.Displayed);
            Assert.True(brandsBabyhug.Displayed);
            Assert.True(brandsAllenSollyJunior.Displayed);
            Assert.True(brandsKookieKids.Displayed);
            Assert.True(brandsBiba.Displayed);
        }
    }
}
