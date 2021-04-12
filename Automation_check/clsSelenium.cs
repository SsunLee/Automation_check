using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;


namespace Automation_check
{
    class clsSelenium
    {

        public IWebDriver drv;
        public clsSelenium()
        {
            // 초기 생성 영역
            
            Automation_check.Form1.log("initload");
        }

        private string _url = string.Empty;
        private string _id = string.Empty;
        private string _pw = string.Empty;

        public string URL 
        {
            get{return _url;}
            set{_url = value;}
        }
        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string PW
        {
            get { return _pw; }
            set { _pw = value; }
        }

        public void create_webdriver()
        {
            drv = new ChromeDriver();
            drv.Navigate().GoToUrl(_url);
            drv.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);


        }
        public void typingIDPW()
        {
            var elementID = drv.FindElement(By.Id("userId"));
            elementID.Clear();
            elementID.SendKeys(@_id);

            var elementPW = drv.FindElement(By.Id("pw"));
            elementPW.Clear();
            elementPW.SendKeys(@_pw);


            var elementLogin = drv.FindElement(By.ClassName("btn-login"));
            elementLogin.Click();

        }

        public void directCheck()
        {
            var elementQuit = drv.FindElement(By.Id("outChk"));
            
        }


    }
}
