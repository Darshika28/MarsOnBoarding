using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class Profile : Driver
    {
        //Constructor
        public Profile(IWebDriver driver)
        {

        }

        //Find Availability Button
        private static IWebElement availabiltyBtn => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));

        //Select Availability from dropdown list
        private static IWebElement availability => Driver.driver.FindElement(By.XPath("//select[@name='availabiltyType']"));

        //Find Hour Button
        private static IWebElement hourBtn => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));

        //Select Hours from dropdown list
        private static IWebElement hours => Driver.driver.FindElement(By.XPath("//select[@name='availabiltyHour']"));

        //Find Earn Target Button
        private static IWebElement earnBtn => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));

        //Select Earn from dropdown list
        private static IWebElement earn => Driver.driver.FindElement(By.XPath("//select[@name='availabiltyTarget']"));

        //Find Availability Button
        private static IWebElement profile => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/span"));
       
        //Function to Add Profile Details
        public void AddPerDetails()
        {
            //Wait until get xpath
            WaitHelper.WaitExists(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i", 5);

            //Find and Init Availability
            availabiltyBtn.Click();
            SelectElement selAvailabity = new SelectElement(availability);
            selAvailabity.SelectByValue("1");

            //Find and Init Hours 
            hourBtn.Click();
            SelectElement selHour = new SelectElement(hours);
            selHour.SelectByValue("1");

            // Find and Init Earn Target
            earnBtn.Click();
            SelectElement selEarn = new SelectElement(earn);
            selEarn.SelectByValue("1");

        }

        public void CheckIfAtProfile()
        {
            Assert.That(profile.Text, Is.EqualTo("Hi Darshika"));
        }

    }
}
