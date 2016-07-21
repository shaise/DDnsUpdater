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
    public partial class DynsSettings : Form
    {
        private CSettings settings;
        public DynsSettings()
        {
            InitializeComponent();
        }

        public CSettings Settings
        {
            get { return settings; }
            set
            {
                settings = value;
                textUser.Text = settings.DynsUser;
                textDomain.Text = settings.DynsDomain;
                textPassword.Text = settings.DynsPassword;
                textHostname.Text = settings.DynsHostname;
                textIP.Text = settings.DynsIP;
            }
        }

        private bool ReadForm()
        {
            settings.DynsUser = textUser.Text;
            settings.DynsHostname = textHostname.Text;
            settings.DynsDomain = textDomain.Text;
            settings.DynsPassword = textPassword.Text;
            settings.DynsIP = textIP.Text;
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
