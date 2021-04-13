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

        #region 예약실행
        private System.Threading.Timer scheduleTimer;
        private void SetUpTimer(TimeSpan alertTime)
        {
            DateTime current = DateTime.Now;
            TimeSpan timeToGo = alertTime - current.TimeOfDay;
            if (timeToGo < TimeSpan.Zero)
            {
                return;//time already passed
            }
            this.scheduleTimer = new System.Threading.Timer(x =>
            {
                this.temp_method();
            }, null, timeToGo, Timeout.InfiniteTimeSpan);
        }
        private void temp_method()
        {
            SetUpTimer(new TimeSpan(16, 00, 00));
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
            cs.create_webdriver();
        }
        private void clickCheck(object sender, EventArgs e)
        {
            cs.typingIDPW();
        }
        private void clickQuit(object sender, EventArgs e)
        {
            cs.directCheck();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (cs.drv != null)
            {
                cs.drv.Quit();
            }
        }

        private protected void inputValueCombobox()
        {
            for (int i = 0; i <= 24; i++)
            {
                cbHH.Items.Add(i);
            }
            for (int i = 0; i <= 60; i++)
            {
                cbMM.Items.Add(i);
            }
            for (int i = 0; i <= 60; i++)
            {
                cbSS.Items.Add(i);
            }
        }

    }
}
