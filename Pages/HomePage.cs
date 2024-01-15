using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoojaMVPOnboard.Pages
{
    public class HomePage
    {
        public void GoToTMPage(IWebDriver driver)
        {

            // navigate to T&M module
            Thread.Sleep(5000);
            IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/text()"));
                administrationDropdown.Click();

            IWebElement tmOption = driver.FindElement(By.XPath("//a[contains(text(),'Time & Materials')]"));
            tmOption.Click();
        }
    }
}
