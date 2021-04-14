
namespace Automation_check
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_chk = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            this.btn_openPanel = new System.Windows.Forms.Button();
            this.timer_textbox = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSS = new System.Windows.Forms.ComboBox();
            this.cbMM = new System.Windows.Forms.ComboBox();
            this.cbHH = new System.Windows.Forms.ComboBox();
            this.btnRunSchedule = new System.Windows.Forms.Button();
            this.btn_showLog = new System.Windows.Forms.Button();
            this.pn_log = new System.Windows.Forms.Panel();
            this.pn_IDPW = new System.Windows.Forms.Panel();
            this.btn_IDPWsave = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Showsetting = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pn_log.SuspendLayout();
            this.pn_IDPW.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_chk
            // 
            this.btn_chk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_chk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chk.Font = new System.Drawing.Font("새굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_chk.ForeColor = System.Drawing.Color.White;
            this.btn_chk.Location = new System.Drawing.Point(12, 147);
            this.btn_chk.Name = "btn_chk";
            this.btn_chk.Size = new System.Drawing.Size(234, 33);
            this.btn_chk.TabIndex = 1;
            this.btn_chk.Text = "로그인";
            this.btn_chk.UseVisualStyleBackColor = false;
            // 
            // btn_open
            // 
            this.btn_open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open.Font = new System.Drawing.Font("새굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_open.ForeColor = System.Drawing.Color.White;
            this.btn_open.Location = new System.Drawing.Point(12, 108);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(234, 33);
            this.btn_open.TabIndex = 0;
            this.btn_open.Text = "Browser Open";
            this.btn_open.UseVisualStyleBackColor = false;
            // 
            // btn_quit
            // 
            this.btn_quit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quit.Font = new System.Drawing.Font("새굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_quit.ForeColor = System.Drawing.Color.White;
            this.btn_quit.Location = new System.Drawing.Point(127, 186);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(118, 33);
            this.btn_quit.TabIndex = 3;
            this.btn_quit.Text = "즉시 퇴근";
            this.btn_quit.UseVisualStyleBackColor = false;
            // 
            // btn_openPanel
            // 
            this.btn_openPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_openPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_openPanel.Font = new System.Drawing.Font("새굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_openPanel.ForeColor = System.Drawing.Color.White;
            this.btn_openPanel.Location = new System.Drawing.Point(14, 186);
            this.btn_openPanel.Name = "btn_openPanel";
            this.btn_openPanel.Size = new System.Drawing.Size(110, 33);
            this.btn_openPanel.TabIndex = 2;
            this.btn_openPanel.Text = "예약 퇴근";
            this.btn_openPanel.UseVisualStyleBackColor = false;
            // 
            // timer_textbox
            // 
            this.timer_textbox.BackColor = System.Drawing.Color.White;
            this.timer_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timer_textbox.Font = new System.Drawing.Font("맑은 고딕", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timer_textbox.Location = new System.Drawing.Point(12, 25);
            this.timer_textbox.Multiline = true;
            this.timer_textbox.Name = "timer_textbox";
            this.timer_textbox.Size = new System.Drawing.Size(233, 77);
            this.timer_textbox.TabIndex = 2;
            this.timer_textbox.Text = "00:00:00";
            this.timer_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLog
            // 
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLog.Location = new System.Drawing.Point(7, 19);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(218, 103);
            this.txtLog.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(2, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "ㆍ Log";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbSS);
            this.panel1.Controls.Add(this.cbMM);
            this.panel1.Controls.Add(this.cbHH);
            this.panel1.Controls.Add(this.btnRunSchedule);
            this.panel1.Location = new System.Drawing.Point(12, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 103);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 99;
            this.label3.Text = "시간 : ";
            // 
            // cbSS
            // 
            this.cbSS.FormattingEnabled = true;
            this.cbSS.Location = new System.Drawing.Point(171, 23);
            this.cbSS.Name = "cbSS";
            this.cbSS.Size = new System.Drawing.Size(49, 23);
            this.cbSS.TabIndex = 7;
            // 
            // cbMM
            // 
            this.cbMM.FormattingEnabled = true;
            this.cbMM.Location = new System.Drawing.Point(116, 23);
            this.cbMM.Name = "cbMM";
            this.cbMM.Size = new System.Drawing.Size(49, 23);
            this.cbMM.TabIndex = 6;
            // 
            // cbHH
            // 
            this.cbHH.FormattingEnabled = true;
            this.cbHH.Location = new System.Drawing.Point(61, 23);
            this.cbHH.Name = "cbHH";
            this.cbHH.Size = new System.Drawing.Size(49, 23);
            this.cbHH.TabIndex = 5;
            // 
            // btnRunSchedule
            // 
            this.btnRunSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRunSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunSchedule.Font = new System.Drawing.Font("새굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRunSchedule.ForeColor = System.Drawing.Color.White;
            this.btnRunSchedule.Location = new System.Drawing.Point(61, 62);
            this.btnRunSchedule.Name = "btnRunSchedule";
            this.btnRunSchedule.Size = new System.Drawing.Size(110, 33);
            this.btnRunSchedule.TabIndex = 8;
            this.btnRunSchedule.Text = "예약 퇴근";
            this.btnRunSchedule.UseVisualStyleBackColor = false;
            // 
            // btn_showLog
            // 
            this.btn_showLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_showLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showLog.Font = new System.Drawing.Font("새굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_showLog.ForeColor = System.Drawing.Color.White;
            this.btn_showLog.Location = new System.Drawing.Point(173, 334);
            this.btn_showLog.Name = "btn_showLog";
            this.btn_showLog.Size = new System.Drawing.Size(73, 23);
            this.btn_showLog.TabIndex = 7;
            this.btn_showLog.Text = "Log 보기";
            this.btn_showLog.UseVisualStyleBackColor = false;
            // 
            // pn_log
            // 
            this.pn_log.Controls.Add(this.txtLog);
            this.pn_log.Controls.Add(this.label2);
            this.pn_log.Location = new System.Drawing.Point(14, 363);
            this.pn_log.Name = "pn_log";
            this.pn_log.Size = new System.Drawing.Size(232, 126);
            this.pn_log.TabIndex = 8;
            // 
            // pn_IDPW
            // 
            this.pn_IDPW.Controls.Add(this.btn_IDPWsave);
            this.pn_IDPW.Controls.Add(this.txtID);
            this.pn_IDPW.Controls.Add(this.txtPW);
            this.pn_IDPW.Controls.Add(this.label7);
            this.pn_IDPW.Controls.Add(this.label5);
            this.pn_IDPW.Controls.Add(this.label6);
            this.pn_IDPW.Location = new System.Drawing.Point(12, 495);
            this.pn_IDPW.Name = "pn_IDPW";
            this.pn_IDPW.Size = new System.Drawing.Size(234, 139);
            this.pn_IDPW.TabIndex = 11;
            // 
            // btn_IDPWsave
            // 
            this.btn_IDPWsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_IDPWsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IDPWsave.Font = new System.Drawing.Font("새굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_IDPWsave.ForeColor = System.Drawing.Color.White;
            this.btn_IDPWsave.Location = new System.Drawing.Point(90, 88);
            this.btn_IDPWsave.Name = "btn_IDPWsave";
            this.btn_IDPWsave.Size = new System.Drawing.Size(73, 23);
            this.btn_IDPWsave.TabIndex = 11;
            this.btn_IDPWsave.Text = "Save";
            this.btn_IDPWsave.UseVisualStyleBackColor = false;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(45, 30);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(118, 23);
            this.txtID.TabIndex = 10;
            // 
            // txtPW
            // 
            this.txtPW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPW.Location = new System.Drawing.Point(45, 59);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(118, 23);
            this.txtPW.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(13, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "ㆍ아이디 비번 저장";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "PW :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(34, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "편하게 퇴근해보아요 !! (feat.쑨쑨배)";
            // 
            // btn_Showsetting
            // 
            this.btn_Showsetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Showsetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Showsetting.Font = new System.Drawing.Font("새굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Showsetting.ForeColor = System.Drawing.Color.White;
            this.btn_Showsetting.Location = new System.Drawing.Point(113, 334);
            this.btn_Showsetting.Name = "btn_Showsetting";
            this.btn_Showsetting.Size = new System.Drawing.Size(54, 23);
            this.btn_Showsetting.TabIndex = 7;
            this.btn_Showsetting.Text = "Setting";
            this.btn_Showsetting.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(261, 359);
            this.Controls.Add(this.pn_IDPW);
            this.Controls.Add(this.pn_log);
            this.Controls.Add(this.btn_Showsetting);
            this.Controls.Add(this.btn_showLog);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timer_textbox);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_openPanel);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_chk);
            this.Controls.Add(this.label4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "출/퇴근 관리";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pn_log.ResumeLayout(false);
            this.pn_log.PerformLayout();
            this.pn_IDPW.ResumeLayout(false);
            this.pn_IDPW.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_chk;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Button btn_openPanel;
        private System.Windows.Forms.TextBox timer_textbox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbSS;
        private System.Windows.Forms.ComboBox cbMM;
        private System.Windows.Forms.ComboBox cbHH;
        private System.Windows.Forms.Button btnRunSchedule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_showLog;
        private System.Windows.Forms.Panel pn_log;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pn_IDPW;
        private System.Windows.Forms.Button btn_IDPWsave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Showsetting;
    }
}

