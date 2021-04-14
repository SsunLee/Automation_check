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
    
        public Form1()
        {
            InitializeComponent();
            f = this;
            init_event();
            inputValueCombobox();
            TimerTxt = new Timer();
            TimerTxt.Tick += Timer_Tick;
            TimerTxt.Interval = (int)1000;
            TimerTxt.Start();

            cs = new clsSelenium();

            timer_textbox.ReadOnly = true;
            label1.Text = $"{getUserName()} 님 환영합니다. ^^";
            txtLog.Font = new Font("맑은 고딕", 8);

            pn_log.Visible = false;
            panel1.Visible = false;

        }
        public static Form1 f;
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

        public void Log(string msg)
        {
            string time = DateTime.Now.ToString("yyyy_MM_dd_HH:mm:ss");
            System.Diagnostics.Debug.Print($"{time} : {msg}");
            string savePath = @"C:\Users\tnsqo\Desktop\log\log.txt";
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
                f.txtLog.AppendText($"{time} : {msg}"+ Environment.NewLine);
            }
        }
        private clsSelenium cs;

        private void init_event()
        {
            this.Load += new EventHandler(this.main);
            this.btn_open.Click += new EventHandler(this.openBrowser);
            this.btn_chk.Click += new EventHandler(this.clickCheck);
            this.btn_quit.Click += new EventHandler(this.clickQuit);
            this.btnRunSchedule.Click += new EventHandler(this.Schedule_Check);
            this.btn_openPanel.Click += new EventHandler(this.Open_Schedule_Panel);
            this.btn_showLog.Click += new EventHandler(this.Open_Log);
            Log("init_event success");
        }

        private Timer TimerTxt = null;
        private void Timer_Tick(object sender, EventArgs e)
        {
            
            if (timer_textbox.InvokeRequired)
            {
                timer_textbox.Invoke(new MethodInvoker(delegate () { timer_textbox.Text = $"{DateTime.Now.Hour.ToString("00.##")}:{DateTime.Now.Minute.ToString("00.##")}:{DateTime.Now.Second.ToString("00.##")}"; }));
            }
            else
            {
                timer_textbox.Text=$"{DateTime.Now.Hour.ToString("00.##")}:{DateTime.Now.Minute.ToString("00.##")}:{DateTime.Now.Second.ToString("00.##")}";
            }
        }

        private void Open_Log(object sender, EventArgs e)
        {
            if (pn_log.Visible == false)
            {
                pn_log.Visible = true;
                this.Height = 555;
            }
            else
            {
                pn_log.Visible = false;
                this.Height = 407;
            }
        }


        #region 예약실행
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

        private void Schedule_Check(object sender, EventArgs e)
        {
            if (cs.drv != null)
            {
                Log("Schedule_Check");
                int hour = Int32.Parse(cbHH.Text.ToString());
                int minute = Int32.Parse(cbMM.Text.ToString());
                int seconds = Int32.Parse(cbSS.Text.ToString());
                SetUpTimer(new TimeSpan(hour, minute, seconds));
                Log("SetUpTimer");
            }
            else
            {
                MessageBox.Show("브라우저가 실행되지 않았습니다.", "쑨쑨배", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void GotoClick()
        {
            Log("GotoClick");
            try
            {
                cs.create_webdriver();
                Log("create_webdriver");

                cs.typingIDPW();
                Log("typingIDPW");
            }
            catch (Exception e)
            {
                Log(e.Message);
            }
      
        }
        #endregion




        private void main(object sender, EventArgs e)
        {
            Log("main method load success");
            string _url = $"http://portal.wisewires.com/";
 
            cs.URL = _url;
            cs.ID = "w201001";
            cs.PW = "wise201001";

        }

        private void openBrowser(object sender, EventArgs e)
        {
            Log("openBrowser");
            
            cs.create_webdriver();
        }
        private void clickCheck(object sender, EventArgs e)
        {
            Log("clickCheck");
            if (cs.drv != null)
            {
                cs.typingIDPW();
            }
            else
            {
                MessageBox.Show("브라우저가 실행되지 않았습니다.", "쑨쑨배", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void clickQuit(object sender, EventArgs e)
        {
            Log("clickQuit");
            if (cs.drv != null)
            {
                try
                {
                    cs.directCheck();
                }
                catch (Exception a)
                {
                    Log(a.Message);
                }

            }
            else
            {
                MessageBox.Show("브라우저가 실행되지 않았습니다.", "쑨쑨배", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Log("Form1_FormClosed");
            if (cs.drv != null)
            {
                Log("Program Quit");
                cs.drv.Quit();
            }
        }

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

    }
}
