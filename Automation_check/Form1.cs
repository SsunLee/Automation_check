using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
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
