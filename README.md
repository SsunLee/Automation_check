셀레니움 - 자동화


### 👤 소개
---

- Name : Automation_Check
- 사용 기술 : C#, Selenium, Chrome Driver, Timer
- 기능 분류 : 출근 체크, 즉시 퇴근, 예약 퇴근, 설정, Log 보기

<br/>

### 👤 메인 화면 
---

![메인](https://user-images.githubusercontent.com/41108401/120090431-77159100-c13d-11eb-85bc-a8d36533a54e.gif)

<br/>

### 👤 예약 퇴근 화면
---
![예약퇴근](https://user-images.githubusercontent.com/41108401/120090435-7aa91800-c13d-11eb-8c55-284bfec84096.gif)



### 👤 Source Code - Class 부분 

```C#
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

        /// <summary>
        /// Web Driver 생성 영역
        /// </summary>
        public void create_webdriver()
        {
            // 로그 찍기
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

```


### 👤 Source Code - Form 부분 

```C#
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Automation_check
{
    public partial class Form1 : Form
    {
        public static Form1 f;
        private clsSelenium cs;

        public Form1()
        {
            InitializeComponent();
            f = this;
            init_event();
            inputValueCombobox();

            import_time();

            cs = new clsSelenium();

            string sname = $" - {getUserName()} 님 환영합니다.";
            this.Text += sname;

            txtLog.Font = new Font("맑은 고딕", 8);

            pn_log.Visible = false;
            panel1.Visible = false;
            pn_IDPW.Visible = false;

            //TimerTxt
            label1.Text = GetPublishVersion();

        }


        // ----------------------------------------------------------------
        // 각 종 기능 구현 -----------------------------------------------
        #region 시계 켜는 기능
        private void import_time()
        {
            TimerTxt = new Timer();
            TimerTxt.Tick += Timer_Tick;
            TimerTxt.Interval = (int)1000;
            TimerTxt.Start();
        }


        #endregion
        #region 콤보박스 값 넣기 기능
        private protected void inputValueCombobox()
        {
            for (int i = 0; i < 24; i++)
            {
                cbHH.Items.Add(i.ToString("00.##"));
            }
            for (int i = 0; i < 60; i++)
            {
                cbMM.Items.Add(i.ToString("00.##"));
            }
            for (int i = 0; i < 60; i++)
            {
                cbSS.Items.Add(i.ToString("00.##"));
            }
            cbHH.Text = DateTime.Now.Hour.ToString("00.##");
            cbMM.Text = DateTime.Now.Minute.ToString("00.##");
            cbSS.Text = DateTime.Now.Second.ToString("00.##");
        }
        #endregion
        #region 이름가져오기
        public string getUserName()
        {
            string description = null;

            using (ManagementClass mc = new ManagementClass("Win32_OperatingSystem"))
            {
                using (ManagementObjectCollection moc = mc.GetInstances())
                {
                    foreach (ManagementObject mo in moc)
                    {
                        if (mo.Properties["Description"] != null)
                        {
                            description = mo.Properties["Description"].Value.ToString();
                            break;
                        }
                    }
                }
            }

            char str = '/';
            string[] str_sp = description.Split(str);
            //str = ';';
            string[] info_userid = str_sp[0].Split(str);

            return info_userid[0];
        }
        #endregion
        #region 로그 기능 
        public void Log(string msg)
        {
            string time = DateTime.Now.ToString("yyyy_MM_dd_HH:mm:ss");
            System.Diagnostics.Debug.Print($"{time} : {msg}");

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string savePath = path + @"\log.txt";
            string textValue = @msg;

            if (System.IO.File.Exists(savePath) == true)
            {
                System.IO.File.AppendAllText(savePath, $"\r\n{time} :{textValue}", Encoding.Default);
            }
            else
            {
                System.IO.File.WriteAllText(savePath, $"{time}:{textValue}", Encoding.Default);
            }

            if (f.txtLog.InvokeRequired)
            {
                f.txtLog.Invoke(new MethodInvoker(delegate () { f.txtLog.AppendText($"{time} : {msg}" + Environment.NewLine); }));
            }
            else
            {
                f.txtLog.AppendText($"{time} : {msg}" + Environment.NewLine);
            }
        }
        #endregion
        #region Timer 관련 기능
        private Timer TimerTxt = null;
        private void Timer_Tick(object sender, EventArgs e)
        {

            if (laTime.InvokeRequired)
            {
                laTime.Invoke(new MethodInvoker(delegate () { laTime.Text = $"{DateTime.Now.Hour.ToString("00.##")}:{DateTime.Now.Minute.ToString("00.##")}:{DateTime.Now.Second.ToString("00.##")}"; }));
            }
            else
            {
                laTime.Text = $"{DateTime.Now.Hour.ToString("00.##")}:{DateTime.Now.Minute.ToString("00.##")}:{DateTime.Now.Second.ToString("00.##")}";
            }
        }
        #endregion
        #region 열기/닫기 관련 기능
        private void Open_settings(object sender, EventArgs e)
        {
            if (pn_IDPW.Visible == false)
            {
                pn_IDPW.Visible = true;
                pn_IDPW.BringToFront();
                pn_IDPW.Top = 363;
                this.Height = 555;
            }
            else
            {
                pn_IDPW.Visible = false;
                this.Height = 407;
            }
        }

        private void Open_Log(object sender, EventArgs e)
        {
            if (pn_log.Visible == false)
            {
                pn_log.Visible = true;
                pn_log.BringToFront();
                this.Height = 555;
            }
            else
            {
                pn_log.Visible = false;
                this.Height = 407;
            }
        }
        private void Open_Schedule_Panel(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
            }
        }

        #endregion
        #region 버전 불러오기 기능
        public string GetPublishVersion()
        {
            string strVersion;

            strVersion = Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;

            return strVersion;
        }
        #endregion
        // ----------------------------------------------------------------
        // ----------------------------------------------------------------

        #region 이벤트초기화
        private void init_event()
        {
            this.Load += new EventHandler(this.main);
            this.btn_quit.Click += new EventHandler(this.clickQuit);
            this.btnRunSchedule.Click += new EventHandler(this.Schedule_Check);
            this.btn_openPanel.Click += new EventHandler(this.Open_Schedule_Panel);
            this.btn_showLog.Click += new EventHandler(this.Open_Log);
            this.btn_Showsetting.Click += new EventHandler(this.Open_settings);
            this.btn_IDPWsave.Click += new EventHandler(this.saveButtonIDPW);
            this.btn_Early.Click += new EventHandler(this.Check_Early);
            Log("init_event success");
        }

        #endregion

        // ----------------------------------------------------------------

        #region 타이머 동작 메소드
        private System.Threading.Timer scheduleTimer;
        private void SetUpTimer(TimeSpan alertTime)
        {
            try
            {
                Log("SetUpTimer");
                DateTime current = DateTime.Now;
                TimeSpan timeToGo = alertTime - current.TimeOfDay;
                if (timeToGo < TimeSpan.Zero)
                {
                    Log("time already pass - return");
                    return;//time already passed
                }
                this.scheduleTimer = new System.Threading.Timer(x =>
                {
                    Log("예약실행 - GotoClick");
                    this.GotoClick();
                }, null, timeToGo, Timeout.InfiniteTimeSpan);
            }
            catch (Exception e)
            {
                Log($"exception : {e.Message}");
            }
        }
        #endregion

        // ----------------------------------------------------------------

        #region 설정불러오기/저장하기
        private void frmLoad_idpw(object sender, EventArgs e)
        {
            txtID.Text = Properties.Settings.Default.ID_SAVE;
            txtPW.Text = Properties.Settings.Default.PW_SAVE;
        }
        private void frmClosing(object sender, FormClosingEventArgs e)
        { 
        
        }
        private void saveButtonIDPW(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            Log("SAVE_EVENT");
            Log($"ID : {txtID.Text.ToString()} \r\n PW : {txtPW.Text.ToString()}");
            txtID.Text = Properties.Settings.Default.ID_SAVE;
            txtPW.Text = Properties.Settings.Default.PW_SAVE;
        }
        private string _id = Properties.Settings.Default.ID_SAVE;
        private string _pw = Properties.Settings.Default.PW_SAVE;


        #endregion

        // ----------------------------------------------------------------

        #region 메인 Method 영역(url, id, pw)
        private void main(object sender, EventArgs e)
        {
            Log("main method load success");
            string _url = $"http://portal.wisewires.com/";

            frmLoad_idpw(sender, e);

            cs.URL = _url;
            cs.ID = txtID.Text;
            cs.PW = txtPW.Text;

        }
        #endregion

        // ----------------------------------------------------------------

        #region 브라우저 열기
        private void openBrowser(object sender, EventArgs e)
        {
            Log("openBrowser");

            cs.create_webdriver();
        }
        #endregion

        #region 로그인
        private void clickCheck(object sender, EventArgs e)
        {
            Log("clickCheck");
            if (cs.drv != null)
            {
                if (txtID.Text.ToString() != string.Empty && txtPW.Text.ToString() != string.Empty)
                {
                    cs.typingIDPW();
                }
                else
                {
                    MessageBox.Show($"저장 된 ID와 PW가 없습니다. \r\nSetting에 정보를 입력 하세요.", "쑨쑨배", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("브라우저가 실행되지 않았습니다.", "쑨쑨배", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        #region 출근 체크
        private void Check_Early(object sender, EventArgs e)
        {
            Log("Check_Early");
            try
            {
                Log("openBrowser");
                cs.create_webdriver();

                cs.typingIDPW();
                Log("typingIDPW");

                cs.ClickStartEnd("inChk");
                Log("Direct Check");
            }
            catch (Exception a)
            {
                Log(a.Message);
            }
        }


        #endregion

        #region 즉시 퇴근
        private void clickQuit(object sender, EventArgs e)
        {
            try
            {
                Log("openBrowser");
                cs.create_webdriver();

                cs.typingIDPW();
                Log("typingIDPW");

                cs.ClickStartEnd("outChk");
                Log("Direct Check");
            }
            catch (Exception a)
            {
                Log(a.Message);
            }

        }
        #endregion

        #region 예약 퇴근 체크
        private void Schedule_Check(object sender, EventArgs e)
        {
                Log("Schedule_Check");
                int hour = Int32.Parse(cbHH.Text.ToString());
                int minute = Int32.Parse(cbMM.Text.ToString());
                int seconds = Int32.Parse(cbSS.Text.ToString());
                SetUpTimer(new TimeSpan(hour, minute, seconds));
                Log("SetUpTimer");
            
   

        }
        private void GotoClick()
        {
            if (txtID.Text.ToString() == string.Empty && txtPW.Text.ToString() == string.Empty)
            {
                MessageBox.Show($"저장 된 ID와 PW가 없습니다. \r\nSetting에 정보를 입력 하세요.", "쑨쑨배", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
                Log("GotoClick");
            try
            {
                cs.create_webdriver();
                Log("create_webdriver");

                cs.typingIDPW();
                Log("typingIDPW");

                cs.ClickStartEnd("outChk");
                Log("end check");

                Thread.Sleep(5000);

                if (checkBox1.Checked)
                {
                    // PC 종료 ( 바로종료 )
                    System.Diagnostics.Process.Start("cmd.exe", "ShutDown.exe -s -f -t 00");
                }


            }
            catch (Exception e)
            {
                Log(e.Message);
            }
        }

        #endregion

        #region 폼 닫기 이벤트
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Log("Form1_FormClosed");
            if (cs.drv != null)
            {
                Log("Program Quit");
                cs.drv.Quit();
            }
        }


        #endregion

        // ----------------------------------------------------------------


    }
}

```
