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
    public sealed class LanguageStepDefinition
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private Language _Language;

        public LanguageStepDefinition(IWebDriver driver)
        {
            _Language = new Language(driver);
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
            _Language.AddLangDetail(2);
            _Language.AddLangDetail(3);
            _Language.AddLangDetail(4);
        }

        [Then(@"As a Seller I can see languages detail in my profile")]
        public void ThenAsASellerICanSeeLanguagesDetailInMyProfile()
        {
        }

    }
}
