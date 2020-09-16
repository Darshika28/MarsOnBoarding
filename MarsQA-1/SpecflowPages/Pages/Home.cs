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
    class Home : Driver
    {
        public Home(IWebDriver driver)
        {

        }

        private static IWebElement availabiltyBtn => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
        private static IWebElement availability => Driver.driver.FindElement(By.XPath("//select[@name='availabiltyType']"));
        private static IWebElement hourBtn => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
        private static IWebElement hours => Driver.driver.FindElement(By.XPath("//select[@name='availabiltyHour']"));
        private static IWebElement earnBtn => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));
        private static IWebElement earn => Driver.driver.FindElement(By.XPath("//select[@name='availabiltyTarget']"));

        private static IWebElement profile => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/span"));
        public void AddPerDetails()
        {
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
