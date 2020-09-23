using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class Education : Driver
    {
        //Contructor
        public Education(IWebDriver driver)
        {

        }
        //Find Education Tab
        private static IWebElement EducationTab => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
       
        //Find Add button in Education Tab
        private static IWebElement EducationAdd => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
        
        //Find Textbox to type University
        private static IWebElement University => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
       
        //Find dropdown list to select country of university
        private static IWebElement UniCountry => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[66]"));
        
        //Find dropdown list to select appropriate title of degree
        private static IWebElement Title => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[7]"));
        
        //Find Textbox to type Name of Degree
        private static IWebElement DegreeName => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
        
        //Find Dropdown list to select year of completion of degree
        private static IWebElement DegreeYear => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[9]"));
        
        //Find Save button to Save the Records
        private static IWebElement SaveEducation => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));


        //Function to Add Educational Details
        public void AddEduDetail(int Edu)
        {
            //Wait until pathh exits
            WaitHelper.WaitExists(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div", 5);

            // Click to Education Tab
            EducationTab.Click();

            //Click Add New button in Education Tab
            EducationAdd.Click();

            //Wait until pathh exits
            WaitHelper.WaitExists(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[66]", 5);
            //Fetch College Name from Excel
            University.SendKeys(ExcelLibHelper.ReadData(Edu, "CollegeName"));

            //Select Country of university from dropdownlist
            UniCountry.Click();

            //Wait until pathh exits
            WaitHelper.WaitExists(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[7]", 5);
            //Select Title of Degree from dropdownlist
            Title.Click();

            //Fetch Degree Name from Excel
            DegreeName.SendKeys(ExcelLibHelper.ReadData(Edu, "Degree"));

            //Wait until pathh exits
            WaitHelper.WaitExists(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[9]", 5);
            //Select Year of Degree Completion from dropdownlist
            DegreeYear.Click();

            //Wait until pathh exits
            WaitHelper.WaitExists(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]", 5);
            //Click on save button to save Record
            SaveEducation.Click();


                                    
        }
    }
}
