﻿using Automation_Exercise.Utilities;
using OpenQA.Selenium;

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
        public void AssertNavigationLinksArePresent()
        {
            Assert.True(homeLink.Displayed);
            Assert.True(productsLink.Displayed);
            Assert.True(cartLink.Displayed);
            Assert.True(loginLink.Displayed);
            Assert.True(testCasesLink.Displayed);
            Assert.True(apiTestingLink.Displayed);
            Assert.True(videoTutorialsLink.Displayed);
            Assert.True(contactusLink.Displayed);          
        }
        public void AssertHomeNavigationLinkOpenCorrectPage()
        {
            Assert.AreEqual("https://www.automationexercise.com/",driver.Url);
            Assert.AreEqual("Automation Exercise", GetPageTitle());
        }
        public void AssertProductsNavigationLinkOpenCorrectPage()
        {
            Assert.AreEqual("https://www.automationexercise.com/products",driver.Url);
            Assert.AreEqual("Automation Exercise - All Products", GetPageTitle());
        } 
        public void AssertCartNavigationLinkOpenCorrectPage()
        {
            Assert.AreEqual("https://www.automationexercise.com/view_cart",driver.Url);
            Assert.AreEqual("Automation Exercise - Checkout", GetPageTitle());
        }
        public void AssertLoginNavigationLinkOpenCorrectPage()
        {
            Assert.AreEqual("https://www.automationexercise.com/login",driver.Url);
            Assert.AreEqual("Automation Exercise - Signup / Login", GetPageTitle());
        }
        public void AssertTestCasesNavigationLinkOpenCorrectPage()
        {
            Assert.AreEqual("https://www.automationexercise.com/test_cases",driver.Url);
            Assert.AreEqual("Automation Practice Website for UI Testing - Test Cases", GetPageTitle());
        }
        public void AssertAPITestingNavigationLinkOpenCorrectPage()
        {
            Assert.AreEqual("https://www.automationexercise.com/api_list",driver.Url);
            Assert.AreEqual("Automation Practice for API Testing", GetPageTitle());
        } 
        public void AssertVideoTutorialsNavigationLinkOpenCorrectPage()
        {
            Assert.True(driver.Url.Contains("https://www.youtube.com/c/AutomationExercise"));
            Assert.AreEqual("AutomationExercise - YouTube", GetPageTitle());
        } 
        public void AssertContactUsNavigationLinkOpenCorrectPage()
        {
            Assert.AreEqual("https://www.automationexercise.com/contact_us",driver.Url);
            Assert.AreEqual("Automation Exercise - Contact Us", GetPageTitle());
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
        public void AssertUserIsLogin()
        {
            Assert.AreEqual($"{Constants.name}", usernameLogin.Text);
        }
        public void AssertUserIsLogout()
        {
            Assert.True(loginLink.Displayed);
        }
        public void AssertBrandProductCountAndDisplayedBrandProductsAreTheSame(Brands brandName)
        {
            Assert.AreEqual(GetCountOfBrandProducts(brandName), NumberOfDisplayedBrandProducts(brandName));
        }
        public void AssertCorrectSuccessfulSubscribeMessageIsDisplayed()
        {
            Assert.AreEqual(SuccessfulMessages.subscribedSuccessfulMessage, subscribleSuccessfulMessage.Text);
        }
        public void AssertErrorInvalidEmailAddressMessageIsDisplayed(IWebElement field, string email)
        {
            Assert.AreEqual(string.Format(ErrorMessages.incorrectEmailAddress, email), ValidationMessage(field));
        }
        public void AssertErrorIncompleteEmailAddressMessageIsDisplayed(IWebElement field, string email)
        {
            Assert.AreEqual(string.Format(ErrorMessages.incompleteEmailAddress, email), ValidationMessage(field));
        }
        public void AssertErrorEmptyFieldMessageIsDisplayed(IWebElement field)
        {
            Assert.AreEqual(ErrorMessages.emptyField, ValidationMessage(field));
        }
        public void AssertImageSwitched()
        {
            Assert.AreNotSame(previusModelImage, GetCurrectModelImage());
        }
        public void AssertActiveIndicatorSwitched()
        {
            Assert.AreNotSame(previusIndicator, GetNumberOfActiveIndicator());
        }
        public void AssertCorrectCarouselTextsAreDisplayed()
        {
            Assert.AreEqual(Constants.carouselFirstText,carouselFirstText.Text);
            Assert.AreEqual(Constants.carouselSecondText,carouselSecondText.Text);
            Assert.AreEqual(Constants.carouselThirdText,carouselThirdText.Text);
        }
    }
}
