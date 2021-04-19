
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
            this.btn_quit = new System.Windows.Forms.Button();
            this.btn_openPanel = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
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
            this.btn_Early = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.laTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pn_log.SuspendLayout();
            this.pn_IDPW.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_quit
            // 
            this.btn_quit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quit.Font = new System.Drawing.Font("새굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_quit.ForeColor = System.Drawing.Color.White;
            this.btn_quit.Location = new System.Drawing.Point(122, 22);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(104, 33);
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
            this.btn_openPanel.Location = new System.Drawing.Point(6, 22);
            this.btn_openPanel.Name = "btn_openPanel";
            this.btn_openPanel.Size = new System.Drawing.Size(110, 33);
            this.btn_openPanel.TabIndex = 2;
            this.btn_openPanel.Text = "예약 퇴근";
            this.btn_openPanel.UseVisualStyleBackColor = false;
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
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbSS);
            this.panel1.Controls.Add(this.cbMM);
            this.panel1.Controls.Add(this.cbHH);
            this.panel1.Controls.Add(this.btnRunSchedule);
            this.panel1.Location = new System.Drawing.Point(12, 250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 78);
            this.panel1.TabIndex = 6;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 48);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 19);
            this.checkBox1.TabIndex = 100;
            this.checkBox1.Text = "컴퓨터 종료";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 99;
            this.label3.Text = "시간 : ";
            // 
            // cbSS
            // 
            this.cbSS.FormattingEnabled = true;
            this.cbSS.Location = new System.Drawing.Point(170, 7);
            this.cbSS.Name = "cbSS";
            this.cbSS.Size = new System.Drawing.Size(49, 23);
            this.cbSS.TabIndex = 7;
            // 
            // cbMM
            // 
            this.cbMM.FormattingEnabled = true;
            this.cbMM.Location = new System.Drawing.Point(115, 7);
            this.cbMM.Name = "cbMM";
            this.cbMM.Size = new System.Drawing.Size(49, 23);
            this.cbMM.TabIndex = 6;
            // 
            // cbHH
            // 
            this.cbHH.FormattingEnabled = true;
            this.cbHH.Location = new System.Drawing.Point(60, 7);
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
            this.btnRunSchedule.Location = new System.Drawing.Point(109, 41);
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
            this.txtPW.PasswordChar = '*';
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
            // btn_Early
            // 
            this.btn_Early.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Early.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Early.Font = new System.Drawing.Font("새굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Early.ForeColor = System.Drawing.Color.White;
            this.btn_Early.Location = new System.Drawing.Point(5, 22);
            this.btn_Early.Name = "btn_Early";
            this.btn_Early.Size = new System.Drawing.Size(220, 33);
            this.btn_Early.TabIndex = 2;
            this.btn_Early.Text = "출근 체크";
            this.btn_Early.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btn_openPanel);
            this.groupBox1.Controls.Add(this.btn_quit);
            this.groupBox1.Location = new System.Drawing.Point(11, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 68);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(15, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "ㆍ퇴근";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btn_Early);
            this.groupBox2.Location = new System.Drawing.Point(11, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 67);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(15, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "ㆍ출근";
            // 
            // laTime
            // 
            this.laTime.AutoSize = true;
            this.laTime.Font = new System.Drawing.Font("맑은 고딕", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.laTime.Location = new System.Drawing.Point(16, 19);
            this.laTime.Name = "laTime";
            this.laTime.Size = new System.Drawing.Size(222, 65);
            this.laTime.TabIndex = 14;
            this.laTime.Text = "00:00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(261, 363);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.laTime);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pn_IDPW);
            this.Controls.Add(this.pn_log);
            this.Controls.Add(this.btn_Showsetting);
            this.Controls.Add(this.btn_showLog);
            this.Controls.Add(this.panel1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Button btn_openPanel;
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
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btn_Early;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label laTime;
        private System.Windows.Forms.Label label1;
    }
}

