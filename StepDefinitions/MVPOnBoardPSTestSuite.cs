using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using PoojaMVPOnboard.Pages;
using System;
using TechTalk.SpecFlow;
using PoojaMVPOnboard.Utilities;

namespace PoojaMVPOnboard.StepDefinitions
{
    [Binding]
    public class MVPOnBoardPSTestSuite : CommonDriver
    {
        [Given(@"User logs into the portal")]
        public void GivenUserLogsIntoThePortal()
        {
            // Open Chrome Browser
            driver = new ChromeDriver();
            Thread.Sleep(1000);

            // login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);

            //throw new PendingStepException();
        }

        [Given(@"user navigates to language page")]
        public void GivenUserNavigatesToLanguagePage()
        {
            //homepage object inititalization and definition
            //HomePage homePageObj = new HomePage();
           // homePageObj.GoToTMPage(driver);
            //throw new PendingStepException();
        }

        [When(@"user creates a new language")]
        public void WhenUserCreatesANewLanguage()
        {

            //TMPage object inititalization and definition
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTimeRecord(driver);//throw new PendingStepException();
        }

        [Then(@"portal should save the language")]
        public void ThenPortalShouldSaveTheLanguage()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.AssertCreateTMRecord(driver);
            //throw new PendingStepException();
        }
    }
}
