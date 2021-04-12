
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
            this.btn_chk = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            this.btn_scheduleQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_chk
            // 
            this.btn_chk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_chk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chk.Font = new System.Drawing.Font("새굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_chk.ForeColor = System.Drawing.Color.White;
            this.btn_chk.Location = new System.Drawing.Point(12, 119);
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
            this.btn_open.Location = new System.Drawing.Point(12, 80);
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
            this.btn_quit.Location = new System.Drawing.Point(12, 158);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(118, 33);
            this.btn_quit.TabIndex = 1;
            this.btn_quit.Text = "즉시 퇴근";
            this.btn_quit.UseVisualStyleBackColor = false;
            // 
            // btn_scheduleQuit
            // 
            this.btn_scheduleQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_scheduleQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_scheduleQuit.Font = new System.Drawing.Font("새굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_scheduleQuit.ForeColor = System.Drawing.Color.White;
            this.btn_scheduleQuit.Location = new System.Drawing.Point(136, 158);
            this.btn_scheduleQuit.Name = "btn_scheduleQuit";
            this.btn_scheduleQuit.Size = new System.Drawing.Size(110, 33);
            this.btn_scheduleQuit.TabIndex = 1;
            this.btn_scheduleQuit.Text = "예약 퇴근";
            this.btn_scheduleQuit.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 450);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_scheduleQuit);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_chk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_chk;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Button btn_scheduleQuit;
    }
}

