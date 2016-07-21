namespace DnsUpdater
{
    partial class DhisSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttOK = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textDomain = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textTimeout = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Domain*:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password*:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Timeout:";
            // 
            // buttOK
            // 
            this.buttOK.Location = new System.Drawing.Point(15, 108);
            this.buttOK.Name = "buttOK";
            this.buttOK.Size = new System.Drawing.Size(82, 23);
            this.buttOK.TabIndex = 3;
            this.buttOK.Text = "OK";
            this.buttOK.UseVisualStyleBackColor = true;
            this.buttOK.Click += new System.EventHandler(this.buttOK_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textDomain
            // 
            this.textDomain.Location = new System.Drawing.Point(79, 9);
            this.textDomain.Name = "textDomain";
            this.textDomain.Size = new System.Drawing.Size(201, 20);
            this.textDomain.TabIndex = 5;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(79, 35);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(201, 20);
            this.textPassword.TabIndex = 6;
            // 
            // textTimeout
            // 
            this.textTimeout.Location = new System.Drawing.Point(79, 61);
            this.textTimeout.Name = "textTimeout";
            this.textTimeout.Size = new System.Drawing.Size(201, 20);
            this.textTimeout.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "* Required field";
            // 
            // DhisSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 143);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textTimeout);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textDomain);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DhisSettings";
            this.Text = "Dhis.org Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttOK;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textDomain;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textTimeout;
        private System.Windows.Forms.Label label4;
    }
}