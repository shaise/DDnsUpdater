using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DnsUpdater
{
    public partial class DhisSettings : Form
    {
        private CSettings settings;
        public DhisSettings()
        {
            InitializeComponent();
        }

        bool Error(string err)
        {
            MessageBox.Show(err, "Error");
            return false;
        }


        public CSettings Settings
        {
            get { return settings; }
            set
            {
                settings = value;
                textDomain.Text = settings.DhisDomain;
                textPassword.Text = settings.DhisPassword;
                textTimeout.Text = settings.DhisTimeout.ToString();
            }
        }

        private bool ReadForm()
        {
            string domain = textDomain.Text;
            string pass = textPassword.Text;
            int timeout = 0;
            if (textTimeout.Text.Length != 0)
            {
                try
                {
                    timeout = int.Parse(textTimeout.Text);
                }
                catch
                {
                    return Error("Invalid timeout value");
                }
            }
            settings.DhisDomain = domain;
            settings.DhisPassword = pass;
            settings.DhisTimeout = timeout;
            settings.Save();
            return true;
        }

        private void buttOK_Click(object sender, EventArgs e)
        {
            if (ReadForm())
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }
    }
}
