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




        [Given(@"I click on Language tab")]
        public void GivenIClickOnLanguageTab()
        {
        }

        [When(@"I click on Add new button")]
        public void WhenIClickOnAddNewButton()
        {
        }

        [When(@"I type language I know")]
        public void WhenITypeLanguageIKnow()
        {
        }

        [When(@"I choose my language level")]
        public void WhenIChooseMyLanguageLevel()
        {
        }

        [When(@"I click on Add button")]
        public void WhenIClickOnAddButton()
        {
        }

        [Then(@"As a Seller I can see languages detail in my profile")]
        public void ThenAsASellerICanSeeLanguagesDetailInMyProfile()
        {
        }

        [Given(@"I click on Skill tab")]
        public void GivenIClickOnSkillTab()
        {
        }

        [When(@"I type a skill I have")]
        public void WhenITypeASkillIHave()
        {
        }

        [When(@"I choose my skill level")]
        public void WhenIChooseMySkillLevel()
        {
        }

        [Then(@"As a Seller I can see skills detail in my profile")]
        public void ThenAsASellerICanSeeSkillsDetailInMyProfile()
        {
        }

        [Given(@"I click on education tab")]
        public void GivenIClickOnEducationTab()
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

        [Then(@"As a Seller I can see Education detail in my profile")]
        public void ThenAsASellerICanSeeEducationDetailInMyProfile()
        {
        }

        [Given(@"I click on certificate tab")]
        public void GivenIClickOnCertificateTab()
        {
        }

        [When(@"I type a name of certificate I got")]
        public void WhenITypeANameOfCertificateIGot()
        {
        }

        [When(@"I type name of institute who gave me certificate")]
        public void WhenITypeNameOfInstituteWhoGaveMeCertificate()
        {
        }

        [When(@"I choose the year when I got certificate")]
        public void WhenIChooseTheYearWhenIGotCertificate()
        {
        }

        [Given(@"I click on edit button")]
        public void GivenIClickOnEditButton()
        {
        }

        [When(@"I type description under (.*) characters")]
        public void WhenITypeDescriptionUnderCharacters(int p0)
        {
        }

        [When(@"I click on save button")]
        public void WhenIClickOnSaveButton()
        {
        }

        [Then(@"I can See the description on my profile")]
        public void ThenICanSeeTheDescriptionOnMyProfile()
        {
        }

    }
}
