using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automation_check
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            init_event();

            TimerTxt = new Timer();
            TimerTxt.Tick += Timer_Tick;
            TimerTxt.Interval = (int)1000;
            TimerTxt.Start();

            timer_textbox.ReadOnly = true;
            label1.Text = $"{getUserName()} 님 환영합니다. ^^";


        }
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

        public static void Log(string msg)
        {
            string time = DateTime.Now.ToString("yyyy_MM_dd_HH:mm:ss");
            System.Diagnostics.Debug.Print($"{time} : {msg}");
        }
        private clsSelenium cs = new clsSelenium();

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
                timer_textbox.Invoke(new MethodInvoker(delegate () { timer_textbox.Text = $"{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}"; }));
            }
            else
            {
                timer_textbox.Text=$"{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}";
            }
        }


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


    }
}
