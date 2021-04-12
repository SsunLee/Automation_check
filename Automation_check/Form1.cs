using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        public new static void log(string msg)
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
            log("init_event success");
        }

        private void main(object sender, EventArgs e)
        {
            log("main method load success");
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
        
        }


    }
}
