
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
            this.btn_scheduleQuit = new System.Windows.Forms.Button();
            this.timer_textbox = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSS = new System.Windows.Forms.ComboBox();
            this.cbMM = new System.Windows.Forms.ComboBox();
            this.cbHH = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnRunSchedule = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            // btn_scheduleQuit
            // 
            this.btn_scheduleQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_scheduleQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_scheduleQuit.Font = new System.Drawing.Font("새굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_scheduleQuit.ForeColor = System.Drawing.Color.White;
            this.btn_scheduleQuit.Location = new System.Drawing.Point(14, 186);
            this.btn_scheduleQuit.Name = "btn_scheduleQuit";
            this.btn_scheduleQuit.Size = new System.Drawing.Size(110, 33);
            this.btn_scheduleQuit.TabIndex = 2;
            this.btn_scheduleQuit.Text = "예약 퇴근";
            this.btn_scheduleQuit.UseVisualStyleBackColor = false;
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
            this.txtLog.Location = new System.Drawing.Point(12, 360);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(232, 103);
            this.txtLog.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 274);
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
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.btnRunSchedule);
            this.panel1.Location = new System.Drawing.Point(12, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 119);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 99;
            this.label3.Text = "시간 : ";
            // 
            // cbSS
            // 
            this.cbSS.FormattingEnabled = true;
            this.cbSS.Location = new System.Drawing.Point(171, 41);
            this.cbSS.Name = "cbSS";
            this.cbSS.Size = new System.Drawing.Size(49, 23);
            this.cbSS.TabIndex = 7;
            // 
            // cbMM
            // 
            this.cbMM.FormattingEnabled = true;
            this.cbMM.Location = new System.Drawing.Point(116, 41);
            this.cbMM.Name = "cbMM";
            this.cbMM.Size = new System.Drawing.Size(49, 23);
            this.cbMM.TabIndex = 6;
            // 
            // cbHH
            // 
            this.cbHH.FormattingEnabled = true;
            this.cbHH.Location = new System.Drawing.Point(61, 41);
            this.cbHH.Name = "cbHH";
            this.cbHH.Size = new System.Drawing.Size(49, 23);
            this.cbHH.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(14, 9);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 19);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "예약 활성화";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnRunSchedule
            // 
            this.btnRunSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRunSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunSchedule.Font = new System.Drawing.Font("새굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRunSchedule.ForeColor = System.Drawing.Color.White;
            this.btnRunSchedule.Location = new System.Drawing.Point(61, 80);
            this.btnRunSchedule.Name = "btnRunSchedule";
            this.btnRunSchedule.Size = new System.Drawing.Size(110, 33);
            this.btnRunSchedule.TabIndex = 8;
            this.btnRunSchedule.Text = "예약 퇴근";
            this.btnRunSchedule.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(263, 516);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.timer_textbox);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_scheduleQuit);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_chk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "출/퇴근 관리";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_chk;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Button btn_scheduleQuit;
        private System.Windows.Forms.TextBox timer_textbox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbSS;
        private System.Windows.Forms.ComboBox cbMM;
        private System.Windows.Forms.ComboBox cbHH;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnRunSchedule;
        private System.Windows.Forms.Label label3;
    }
}

