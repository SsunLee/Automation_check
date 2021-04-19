using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Automation_check
{
    class clsSelenium
    {
        public IWebDriver drv;
        public clsSelenium()
        {
            // 초기 생성 영역
            Form1.f.Log("[Selenium Class]>init complete");
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
            
            Form1.f.Log(@System.IO.Directory.GetCurrentDirectory());

                drv = new ChromeDriver();
                drv.Navigate().GoToUrl(_url);
                drv.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                Form1.f.Log(@"[Selenium Class]>Create Webdriver");
  
        }
        public void typingIDPW()
        {

            var elementID = drv.FindElement(By.Id("userId"));
            var elementPW = drv.FindElement(By.Id("pw"));
            elementID.Clear();
            elementPW.Clear();
            foreach (char s in _id)
            {
                elementID.SendKeys(s.ToString());
                Form1.f.Log($" ID : {s}");
                Thread.Sleep(50);
            }
            foreach (char s in _pw)
            {
                elementPW.SendKeys(s.ToString());
                Form1.f.Log($" PW : {s}");
                Thread.Sleep(50);
            }

            Form1.f.Log(@"[Selenium Class]> Typing ID PW ");

            Thread.Sleep(100);
            
            var elementLogin = drv.FindElement(By.ClassName("btn-login"));
            elementLogin.Click();
            Form1.f.Log(@"[Selenium Class]> Click Login Button ");

        }


        public void ClickStartEnd(string strID)
        {
            IWebElement elementQuit;

            try
            {
                elementQuit = drv.FindElement(By.Id(strID));
                Form1.f.Log($"{strID}");

                elementQuit.Click();

                WebDriverWait wait = new WebDriverWait(drv, TimeSpan.FromSeconds(10));
                IAlert alert = wait.Until(ExpectedConditions.AlertIsPresent());

                //IAlert alert = drv.SwitchTo().Alert();
                Form1.f.Log($"[Selenium Class]> popup : {alert.Text.ToString()}");
                alert.Accept();
                
                if (strID == "outChk")
                {
                    Form1.f.Log($"퇴근 체크 완료");
                }
                else 
                {
                    Form1.f.Log($"출근 체크 완료");
                }
                Thread.Sleep(2000);
                drv.Close();
                drv = null;

            }
            catch (NoAlertPresentException e)
            {
                Form1.f.Log($"[Selenium Class]> Error : {e.Message.ToString()}");
                drv.Close();
                drv = null;
                return;
            }

        }


    }
}
