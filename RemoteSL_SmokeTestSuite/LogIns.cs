using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;

namespace RemoteSL_SmokeTestSuite 
{
    public class LogIns : Browser_Landing
    {
        public void sdLoginCompany(){
            //Instantiating Company Info *SERVICE CONSOLE*
            string sdCompany = "Smartdrive";
            
            //Finding where you place the info
            IWebElement sdCompanyLog = driver.FindElement(By.Name("ctl00$ContentPlaceHolder1$company_name"));

            sdCompanyLog.Clear();
            
            //sending keys with an added tab to shift to next text area
            sdCompanyLog.SendKeys(sdCompany + Keys.Tab);
        
        }
        public void sdLoginUser(){
            //Instantiating Username
            string sdUser = "SWQA";

            //Finding where you place the info
            IWebElement sdUserLog = driver.FindElement(By.Name("ctl00$ContentPlaceHolder1$loginid"));

            sdUserLog.Clear();

            //sending keys with an added tab to shift to next text area
            sdUserLog.SendKeys(sdUser + Keys.Tab);
        }
        public void sdLoginPass(){
            //Instantiating Password
            string sdPassword = "Te$t1234";

            //Finding where you place the info
            IWebElement sdPassLog = driver.FindElement(By.Name("ctl00$ContentPlaceHolder1$password"));

            sdPassLog.Clear();

            //sending keys with an added tab to shift to next text area
            sdPassLog.SendKeys(sdPassword + Keys.Tab);

            //clicking submit
            IWebElement subBtn = driver.FindElement(By.Name("ctl00$ctl00$ContentContainer$MainContent$btnImage"));
            subBtn.Click();
        }
        public void rcCompany(){
            //Instantiateing Company Info *Company Specific Response Center Testing*
            string rcCompany = "ICEE";

            //Finding where you place the info
            IWebElement rcCompanyLog = driver.FindElement(By.Name("ctl00$ContentPlaceHolder1$company_name"));

            rcCompanyLog.Clear();

            //sending keys with an added tab to shift to next text area
            rcCompanyLog.SendKeys(rcCompany + Keys.Tab);
       }
        public void rcUser(){
            //Instantiating Username
            string rcdUser = "SWQA";

            //Finding where you place the info
            IWebElement rcCompanyLog = driver.FindElement(By.Name("ctl00$ContentPlaceHolder1$loginid"));

            rcCompanyLog.Clear();

            //sending keys with an added tab to shift to next text area
            rcCompanyLog.SendKeys(rcdUser + Keys.Tab);
        }
        public void rcPass(){

            //Instantiating Password
            string rcPassword = "Te$t1234";

            //Finding where you place the info
            IWebElement rcPasswordLog = driver.FindElement(By.Name("ctl00$ContentPlaceHolder1$password"));

            rcPasswordLog.Clear();

            //sending keys with an added tab to shift to next text area
            rcPasswordLog.SendKeys(rcPassword);

            //clicking submit
            IWebElement subBtn = driver.FindElement(By.Name("ctl00$ctl00$ContentContainer$MainContent$btnImage"));
            subBtn.Click();
        }
    }
}
