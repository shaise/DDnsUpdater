namespace DnsUpdater
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DhisStatus = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttDhisConf = new System.Windows.Forms.Button();
            this.buttDynsConf = new System.Windows.Forms.Button();
            this.DynsStatus = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DhisStatus
            // 
            this.DhisStatus.AutoSize = true;
            this.DhisStatus.Location = new System.Drawing.Point(12, 13);
            this.DhisStatus.Name = "DhisStatus";
            this.DhisStatus.Size = new System.Drawing.Size(71, 13);
            this.DhisStatus.TabIndex = 0;
            this.DhisStatus.Text = "Dhis: Unused";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "DDNS updater";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // buttDhisConf
            // 
            this.buttDhisConf.Location = new System.Drawing.Point(357, 8);
            this.buttDhisConf.Name = "buttDhisConf";
            this.buttDhisConf.Size = new System.Drawing.Size(51, 23);
            this.buttDhisConf.TabIndex = 1;
            this.buttDhisConf.Text = "Config";
            this.buttDhisConf.UseVisualStyleBackColor = true;
            this.buttDhisConf.Click += new System.EventHandler(this.buttDhisConf_Click);
            // 
            // buttDynsConf
            // 
            this.buttDynsConf.Location = new System.Drawing.Point(357, 37);
            this.buttDynsConf.Name = "buttDynsConf";
            this.buttDynsConf.Size = new System.Drawing.Size(51, 23);
            this.buttDynsConf.TabIndex = 2;
            this.buttDynsConf.Text = "Config";
            this.buttDynsConf.UseVisualStyleBackColor = true;
            this.buttDynsConf.Click += new System.EventHandler(this.buttDynsConf_Click);
            // 
            // DynsStatus
            // 
            this.DynsStatus.AutoSize = true;
            this.DynsStatus.Location = new System.Drawing.Point(12, 42);
            this.DynsStatus.Name = "DynsStatus";
            this.DynsStatus.Size = new System.Drawing.Size(74, 13);
            this.DynsStatus.TabIndex = 3;
            this.DynsStatus.Text = "Dyns: Unused";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 66);
            this.Controls.Add(this.DynsStatus);
            this.Controls.Add(this.buttDynsConf);
            this.Controls.Add(this.buttDhisConf);
            this.Controls.Add(this.DhisStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Dynamic DNS Updater";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DhisStatus;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button buttDhisConf;
        private System.Windows.Forms.Button buttDynsConf;
        private System.Windows.Forms.Label DynsStatus;
    }
}

