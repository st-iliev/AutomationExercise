using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Exercise.Pages.ProductPage
{
    partial class ProductPage
    {
        public void AssertCorrectPageIsLoaded()
        {
            Assert.AreEqual("Automation Exercise - All Products", GetPageTitle());
        }
        public void AssertSaleBannerIsDisplayed()
        {
            Assert.True(bigSaleBanner.Displayed);
        }
        //TODO
    }
}
