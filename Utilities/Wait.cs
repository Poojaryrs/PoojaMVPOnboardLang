﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PoojaMVPOnboard.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoojaMVPOnboard.Utilities
{
    public class Wait
    {
        public static void WaitToBeClickable(IWebDriver driver, string locatorType,string locatorValue, int seconds)
        {
          //  var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
           // if (locatorType == "Xpath")
           // {
              //  wait.(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
          //  }
          //  if (locatorType == "Id")
          //  {
          //      wait.(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
          //  }

        }
        public static void WaitToBeVisible(IWebDriver driver, string locatorType, string locatorValue, int seconds)
        {
          //  var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
          //  if (locatorType == "Xpath")
           // {
           //     wait.(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(locatorValue)));
          //  }
          //  if (locatorType == "Id")
          //  {
         //       wait.(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(locatorValue)));
            }

        }
    }
//}
