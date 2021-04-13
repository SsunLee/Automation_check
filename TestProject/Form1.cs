using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace TestProject
{
    public partial class Form1 : Form
    {

        private Timer TimerTxt = null;

        public Form1()
        {
            InitializeComponent();

            progressBar1.Enabled = false;
            progressBar1.Style = ProgressBarStyle.Marquee;




        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (textBox1.InvokeRequired)
            {
                textBox1.Invoke(new MethodInvoker(delegate () { textBox1.AppendText($"{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}" + Environment.NewLine); }));
            }
            else
            {
                textBox1.AppendText($"{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}"+ Environment.NewLine);
            }
        }


        private System.Threading.Timer timer;
        private void SetUpTimer(TimeSpan alertTime)
        {
            DateTime current = DateTime.Now;
            TimeSpan timeToGo = alertTime - current.TimeOfDay;
            if (timeToGo < TimeSpan.Zero)
            {
                return;//time already passed
            }
            this.timer = new System.Threading.Timer(x =>
            {
                this.testtyping();
            }, null, timeToGo, Timeout.InfiniteTimeSpan);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int hour = Int32.Parse(textBox2.Text.ToString());
            int minitue = Int32.Parse(textBox3.Text.ToString());
            int seconds = Int32.Parse(textBox4.Text.ToString());

            SetUpTimer(new TimeSpan(hour, minitue, seconds));

            textBox1.AppendText($"{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}"+ Environment.NewLine);
            progressBar1.Enabled = true;

            TimerTxt = new Timer();
            TimerTxt.Tick += Timer_Tick;
            TimerTxt.Interval = (int)1000;
            TimerTxt.Start();


        }


        private void testtyping()
        {
            if (textBox1.InvokeRequired)
            {
                textBox1.Invoke(new MethodInvoker(delegate () { textBox1.Text = "입력 되었습니다."; }) );
            }
            else {
                textBox1.Text = "입력 되었습니다.";
            }

            if (progressBar1.InvokeRequired)
            {
                progressBar1.Invoke(new MethodInvoker(delegate () { progressBar1.Enabled = true; }));
            }
            else 
            {
                progressBar1.Enabled = true;
            }
            
        }
    }
}
