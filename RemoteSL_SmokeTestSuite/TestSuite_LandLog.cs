using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.IE;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;



namespace RemoteSL_SmokeTestSuite
{
    //NUnit Test Setup

    //Done before all Tests are run, tests are found within the TestFixture Attrib.
    [TestFixture, Description("IE10, Launch url, verify elements, log in, verify landing page")]

    //will run test fixtures in parallel

    [Parallelizable(ParallelScope.Fixtures)]

    public class ServiceConsoleTestIE10 : Browser_Landing
    //From here on is testing correlating to Logging in  
    {
        [SetUp]
        //This has to be done for all tests.  It is the setup I say!
        public void SetupIE10()
        {
            LaunchBrowserIE10();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(60));
        }

        [TearDown]
        //This has to be done for all tests.  It is the teardown I say!
        public void TearItDown()
        {
            if (driver != null)
                driver.Quit();
        }

        [Test, Description("Testing Landing Page and Asserting Color Check")]
        public void LandingPageVerificiation()
        {

            //used are equal instead of are same due to syntax.  using are equal was able to do the appropriate compare.  Used in Placement test too
            Assert.AreEqual("rgba(118, 118, 118, 1)", getLandingColor());
        }

        [Test, Description("Testing Landing Page and Asserting Placement Check")]


        public void PlacementChk()
        {

            Assert.AreEqual("left", getLandingPlacement());

        }

        [Test, Description("Testing Signing into Service Console")]
        //getting to the sign on page from the landing page
        public void SignOnPage()
        {
            SignInPage();
        }
        //assert that we're on the login screen
        public void OnRightPage()
        {
            loginScreen();
        }
        //Clear txt field and send key to input company name
        public void SC_LogInComp()
        {
            //Accessing LogIns class
            LogIns info_Co = new LogIns();
            info_Co.sdLoginCompany();
        }

        //Clear txt field and send key to input login name
        public void SC_LogInUser()
        {
            LogIns info_User = new LogIns();
            info_User.sdLoginUser();
        }

        //Clear txt field and send key to input password
        public void SC_LogInPass()
        {
            LogIns info_Pass = new LogIns();
            info_Pass.sdLoginPass();
        }

        //Once in Service console assert that the warehouse link is in place
        public void SC_LoginSuccess()
        {
            IWebElement vSuccess = driver.FindElement(By.Id("ctl00_ctlMenu_linkWarehouse"));

            Assert.IsTrue(vSuccess.Displayed);
        }

    }
    //second series of tests to run in parallel
    [TestFixture, Description("IE9, Launch url, verify elements, log in, verify landing page")]

    //will run test fixtures in parallel

    [Parallelizable(ParallelScope.Fixtures)]

    public class ServiceConsoleTestIE9 : Browser_Landing
    //From here on is testing correlating to Logging in  
    {
        [SetUp]
        //This has to be done for all tests.  It is the setup I say!
        public void SetupIE9()
        {
            LaunchBrowserIE9();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(60));
        }

        [TearDown]
        //This has to be done for all tests.  It is the teardown I say!
        public void TearItDown()
        {
            if (driver != null)
                driver.Quit();
        }

        [Test, Description("Testing Landing Page and Asserting Color Check")]
        public void LandingPageVerificiation()
        {

            //used are equal instead of are same due to syntax.  using are equal was able to do the appropriate compare.  Used in Placement test too
            Assert.AreEqual("rgba(118, 118, 118, 1)", getLandingColor());
        }

        [Test, Description("Testing Landing Page and Asserting Placement Check")]


        public void PlacementChk()
        {

            Assert.AreEqual("left", getLandingPlacement());

        }

        [Test, Description("Testing Signing into Service Console")]
        //getting to the sign on page from the landing page
        public void SignOnPage()
        {
            SignInPage();
        }
        //assert that we're on the login screen
        public void OnRightPage()
        {
            loginScreen();
        }
        //Clear txt field and send key to input company name
        public void SC_LogInComp()
        {
            //Accessing LogIns class
            LogIns info_Co = new LogIns();
            info_Co.sdLoginCompany();
        }

        //Clear txt field and send key to input login name
        public void SC_LogInUser()
        {
            LogIns info_User = new LogIns();
            info_User.sdLoginUser();
        }

        //Clear txt field and send key to input password
        public void SC_LogInPass()
        {
            LogIns info_Pass = new LogIns();
            info_Pass.sdLoginPass();
        }

        //Once in Service console assert that the warehouse link is in place
        public void SC_LoginSuccess()
        {
            IWebElement vSuccess = driver.FindElement(By.Id("ctl00_ctlMenu_linkWarehouse"));

            Assert.IsTrue(vSuccess.Displayed);
        }

        [MTAThread]
        static void Main()
        {
        }
    }
}
