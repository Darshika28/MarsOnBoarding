using Gherkin.Events.Args.Pickle;
using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class Language : Driver
    {
        //Constructor
        public Language(IWebDriver driver)
        {

        }

        //Find Language Tab
        private static IWebElement LanguageTab => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
        
        //Find Add button in Language tab
        private static IWebElement LanguageAdd => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        
        //Find Textbox to type Language
        private static IWebElement lang => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
        
        //Find Dropdown list to select Level of Language
        private static IWebElement LanguageLevel => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]"));
        
        //Find Add button to save Language 
        private static IWebElement LanguageSave => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));


        //Function to Add Language Details
        public void AddLangDetail(int mylang)
        {
            //Wait to check Language Add Button
            WaitHelper.WaitExists(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 30);
            WaitHelper.WaitClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 30);

            //Click on Language Tab
            LanguageTab.Click();
            
            //Click on Language add button
            LanguageAdd.Click();

            //Wait until if find Language Level dropdown
            WaitHelper.WaitExists(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]", 30);
            WaitHelper.WaitClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]", 30);

            //Get record from excel
            lang.SendKeys(ExcelLibHelper.ReadData(mylang, "language"));
            
            //Select Level of Language
            LanguageLevel.Click();

            //Wait until it find Save button
            WaitHelper.WaitExists(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]", 30);
            WaitHelper.WaitClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]", 30);
            //Click on save button to save details.
            LanguageSave.Click();

        }


        //Function to check Existing Language and if present delete
        public void DeleteExistsLang(int mylang)
        {
            //Wait until find language button 
            WaitHelper.WaitExists(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]", 30);
            WaitHelper.WaitClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]", 30);
            //Click on Language Tab 
            LanguageTab.Click();

            //Get Language from excel to Check 
            string DeleteLang = ExcelLibHelper.ReadData(mylang, "language");
              
            //Count number of Language(row) to check
            int numRowToCheck = driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr")).Count();
            
            //Check if Inputing language is already exist
            for ( int i = 1; i <= numRowToCheck; i++)
            {
                //Find the existing language
                var LanguageOnProfile = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i +"]/tr/td[1]"));
                
                //Comparing Existing language with Excel data
                if(LanguageOnProfile.Text == DeleteLang)
                {
                    //Wait to find delete language button 
                    WaitHelper.WaitExists(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]/span[2]/i", 30);
                    WaitHelper.WaitClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]/span[2]/i", 30);

                    //Find and Click on delete
                    IWebElement LanguageToDelete = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]/span[2]/i"));
                    LanguageToDelete.Click();
                    break;
                }
                
            }
        
        }

        public void CheckIfLanguageAdded()
        {
            
        }

        public void CheckIfLanguageDelete()
        {

        }

    }
}
