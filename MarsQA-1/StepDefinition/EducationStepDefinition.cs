using MarsQA_1.SpecflowPages.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinition
{
    [Binding]
    public sealed class EducationStepDefinition
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private Education _Education;

        public EducationStepDefinition(IWebDriver driver)
        {
            _Education = new Education(driver);
        }

        [Given(@"I click on education tab")]
        public void GivenIClickOnEducationTab()
        {
        }

        [When(@"I click on Add new button on Epage")]
        public void WhenIClickOnAddNewButtonOnEpage()
        {
        }

        [When(@"I type my university name I studied")]
        public void WhenITypeMyUniversityNameIStudied()
        {
        }

        [When(@"I choose the country of my university")]
        public void WhenIChooseTheCountryOfMyUniversity()
        {
        }

        [When(@"I choose the title of degree")]
        public void WhenIChooseTheTitleOfDegree()
        {
        }

        [When(@"I type the name of my degree")]
        public void WhenITypeTheNameOfMyDegree()
        {
        }

        [When(@"I choose the year of my completion of degree\.")]
        public void WhenIChooseTheYearOfMyCompletionOfDegree_()
        {
        }

        [When(@"I click on Add button on Epage")]
        public void WhenIClickOnAddButtonOnEpage()
        {
            _Education.AddEduDetail(2);
        }

        [Then(@"As a Seller I can see Education detail in my profile")]
        public void ThenAsASellerICanSeeEducationDetailInMyProfile()
        {
        }


    }
}
