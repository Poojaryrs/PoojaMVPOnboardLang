﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PoojaMVPOnboard.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace PoojaMVPOnboard.Pages
{
    public class TMPage
    {
        public void CreateTimeRecord(IWebDriver driver)
        {
        
            // Click on the create new button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            createNewButton.Click();

            // select time dropdown
            IWebElement typeCodeMainDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            typeCodeMainDropdown.Click();
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[3]"));
            typeCodeDropdown.Click();


            // enter code
            IWebElement codeTextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            codeTextBox.SendKeys("English");

            // click on the save button
            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            saveButton.Click();
            Thread.Sleep(2000); // waiting for mandatory 2 secs


        }

        public void AssertCreateTMRecord(IWebDriver driver)
        {
            {
                    Assert.Pass("new language created successfully");
            }
        }
    }
}
