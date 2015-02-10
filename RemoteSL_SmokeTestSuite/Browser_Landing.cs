using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using OpenQA.Selenium.Remote;

namespace RemoteSL_SmokeTestSuite
{
    public class Browser_Landing
    {

        //Instantiating at a Global level for driver access
        public IWebDriver driver;
        public string landingPage = "http://www.smartdrive.net"; 

          
      public void LaunchBrowserIE10() {
          //Driver is instantiated here for the [Setup]
          // Choose the browser, version, and platform to test
          DesiredCapabilities caps = DesiredCapabilities.InternetExplorer();
          caps.SetCapability("platform", "Windows 7");
          caps.SetCapability("version", "10");
          caps.SetCapability("username", "3totheg");
          caps.SetCapability("accessKey", "038bfc28-72fe-4c63-a326-ab5f99ebd474");
          caps.SetCapability("deviceName", "");
          caps.SetCapability("name", "Login SC Test IE10");
          // Create the connection to Sauce Labs to run the tests
          this.driver = new RemoteWebDriver(new Uri("http://ondemand.saucelabs.com:80/wd/hub"), caps);

          //the access to the landing page
          driver.Navigate().GoToUrl(landingPage);

        }

      public void LaunchBrowserIE9()
      {
          //Driver is instantiated here for the [Setup]
          // Choose the browser, version, and platform to test
          DesiredCapabilities caps = DesiredCapabilities.InternetExplorer();
          caps.SetCapability("platform", "Windows 7");
          caps.SetCapability("version", "9");
          caps.SetCapability("username", "3totheg");
          caps.SetCapability("accessKey", "038bfc28-72fe-4c63-a326-ab5f99ebd474");
          caps.SetCapability("deviceName", "");
          caps.SetCapability("name", "Login SC Test IE9");
          // Create the connection to Sauce Labs to run the tests
          this.driver = new RemoteWebDriver(new Uri("http://ondemand.saucelabs.com:80/wd/hub"), caps);

          //the access to the landing page
          driver.Navigate().GoToUrl(landingPage);

      }


        //will do assertions on the following
        
        public string getLandingPlacement(){
            
            // IWebElement placementCheck = driver.FindElement(By.LinkText("/CompanyProfile.aspx#"));;
            IWebElement placementCheck = driver.FindElement(By.XPath("//div[@class = 'header-menu']/ul/li[3]/a"));
            string getPlace = placementCheck.GetCssValue("float");

            return getPlace;

        }          

        public string getLandingColor(){

            /*
             * XPath drilled into the div of the navi which was class header-menu, once in the div
             * drill into the ul [unorder list] then into the 3rd li element and grabbed the anchor tag
             * looks like: 
             *      (By.XPath(("//div[@class = 'header-menu']/ul/li[3]/a")))
             */
            IWebElement getLink = driver.FindElement(By.XPath(("//div[@class = 'header-menu']/ul/li[3]/a")));

            //checking the color = #767676, must convert to rgba
            string NavigationMenu = getLink.GetCssValue("color");

            return NavigationMenu;
        }
     
        //Method to Navigate to login page
        public void SignInPage(){
            IWebElement SignInBtnClick = driver.FindElement(By.ClassName("clientlogin"));
            SignInBtnClick.Click();
         }

        //Method to Assert to login page
        public void loginScreen() {
          IWebElement signBtn = driver.FindElement(By.Name("ctl00$ContentPlaceHolder1$loginid"));
          Assert.AreEqual(true,signBtn.Displayed);
         }

      
    }

}
