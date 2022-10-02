using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace DnsUpdater
{
    public partial class Form1 : Form
    {
        WebClient wClient;
        Timer tmr;
        bool minimize = false;
        bool errorShown = false;
        CSettings settings;
        string curip = "";
        bool dhisOk = false, dynsOk = false;
        public Form1()
        {
            settings = new CSettings();
            InitializeComponent();
            wClient = new WebClient();
            tmr = new Timer();
            tmr.Interval = 300000;
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Start();
        }

        void ParseVars()
        {
            string[] args = Environment.GetCommandLineArgs();
            for (int i = 1; i < args.Length; i++)
            {
                if (args[i].StartsWith("-m"))
                    minimize = true;
            }
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            string data = "";
            try
            {
                // first see if the ip was changed 
                string ipurl = "http://icanhazip.com/";
                string newip = wClient.DownloadString(ipurl);
                if (newip != curip)
                {
                    dhisOk = false;
                    dynsOk = false;
                }
                curip = newip;

                if (settings.DhisValid && !dhisOk)
                {
                    string url = "http://is.dhis.org/?updatetimeout=" + settings.DhisTimeout + "&hostname=" + settings.DhisDomain + "&password=" + settings.DhisPassword;
                    //DhisStatus.Text = url;
                    data = wClient.DownloadString(url);
                    string[] vars = data.Split(' ');
                    data = vars[0] + " " + vars[1] + " " + vars[2];
                    DhisStatus.Text = "Dhis: " + DateTime.Now.ToString("h:mm:ss tt") + ": " + data;
                    dhisOk = data.IndexOf("OK") >= 0;
                }
                if (settings.DynsValid && !dynsOk)
                {
                    StringBuilder urlBuilder = new StringBuilder();
                    urlBuilder.Append(String.Format("http://www.dyns.cx/postscript011.php?username={0}&password={1}&host={2}",
                        settings.DynsUser, settings.DynsPassword, settings.DynsHostname));
                    if (settings.DynsDomain.Length > 0)
                        urlBuilder.Append("&domain=" + settings.DynsDomain);
                    if (settings.DynsIP.Length > 0)
                        urlBuilder.Append("&ip=" + settings.DynsIP);
                    data = wClient.DownloadString(urlBuilder.ToString());
                    //string[] vars = data.Split(' ');
                    //data = vars[0] + " " + vars[1] + " " + vars[2];
                    DynsStatus.Text = "Dyns: " + DateTime.Now.ToString("h:mm:ss tt") + ": " + data;
                    dynsOk = data.IndexOf("updated") >= 0;
                }
                errorShown = false;

            }
            catch (Exception ex)
            {
                data = ex.Message;
                if (WindowState == FormWindowState.Minimized && !errorShown)
                {
                    notifyIcon1.BalloonTipText = data;
                    notifyIcon1.ShowBalloonTip(1000);
                    errorShown = true;
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ParseVars();
            settings.Load();
            if (minimize && (WindowState != FormWindowState.Minimized))
                WindowState = FormWindowState.Minimized;
            tmr_Tick(this, null);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
                notifyIcon1.Visible = true;
                //notifyIcon1.ShowBalloonTip(1000);
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttDhisConf_Click(object sender, EventArgs e)
        {
            DhisSettings ds = new DhisSettings();
            ds.Settings = settings;
            if (ds.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tmr_Tick(this, null);
            }
        }

        private void buttDynsConf_Click(object sender, EventArgs e)
        {
            DynsSettings ds = new DynsSettings();
            ds.Settings = settings;
            if (ds.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tmr_Tick(this, null);
            }
        }


    }
}
