using MarsQA_1.SpecflowPages.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public sealed class SellerProfileStepDefinition
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private Home _Home;

        public SellerProfileStepDefinition(IWebDriver driver)
        {
            _Home = new Home(driver);
        }


        [Given(@"I am as user at my profile page")]
        public void GivenIAmAsUserAtMyProfilePage()
        {

        }

        [When(@"User add personal details in profile page")]
        public void WhenUserAddPersonalDetailsInProfilePage()
        {
            _Home.AddPerDetails();
        }

        [Then(@"User is able to see Profile details")]
        public void ThenUserIsAbleToSeeProfileDetails()
        {

        }

    }
}
