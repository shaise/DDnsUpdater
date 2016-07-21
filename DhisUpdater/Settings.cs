using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace DnsUpdater
{
    public class CSettings
    {
        public String DhisDomain = "";
        public String DhisPassword = "";
        public int DhisTimeout = 0;

        public String DynsUser = "";
        public String DynsPassword = "";
        public String DynsHostname = "";
        public String DynsDomain = "";
        public String DynsIP = "";

        String GetSettingsFileName()
        {
            return Application.StartupPath + Path.DirectorySeparatorChar + "DDNSSettings.dat";
        }

        string RemoveWhitespace(string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }

        public void Save()
        {
            try
            {
                StreamWriter sw = new StreamWriter(GetSettingsFileName());
                sw.WriteLine(string.Format("Dhis={0},{1},{2}", DhisDomain, DhisPassword, DhisTimeout));
                sw.WriteLine(string.Format("Dyns={0},{1},{2},{3},{4}", DynsUser, DynsPassword, DynsHostname, DynsDomain, DynsIP));
                sw.Close();
            }
            catch
            {
                MessageBox.Show("Can not write settings", "Error");
            }
        }

        void ReadDhis(String data)
        {
            try
            {
                String[] args = data.Split(',');
                if (args.Length > 0) DhisDomain = args[0];
                if (args.Length > 1) DhisPassword = args[1];
                if (args.Length > 2) DhisTimeout = int.Parse(args[2]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to parse Dhis settings: " + ex.Message, "Error");
            }
        }

        void ReadDyns(String data)
        {
            try
            {
                String[] args = data.Split(',');
                if (args.Length > 0) DynsUser = args[0];
                if (args.Length > 1) DynsPassword = args[1];
                if (args.Length > 2) DynsHostname = args[2];
                if (args.Length > 3) DynsDomain = args[3];
                if (args.Length > 4) DynsIP = args[4];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to parse Dhis settings: " + ex.Message, "Error");
            }
        }

        public bool DhisValid
        {
            get { return DhisDomain.Length > 0 && DhisPassword.Length > 0; }
        }

        public bool DynsValid
        {
            get { return DynsUser.Length > 0 && DynsPassword.Length > 0 && DynsHostname.Length > 0; }
        }

        public void Load()
        {
            try
            {
                StreamReader sr = new StreamReader(GetSettingsFileName());
                while (!sr.EndOfStream)
                {
                    String line = RemoveWhitespace(sr.ReadLine());
                    String[] args = line.Split('=');
                    if (args.Length == 2)
                    {
                        if (args[0] == "Dhis")
                        {
                            ReadDhis(args[1]);
                        }
                        if (args[0] == "Dyns")
                        {
                            ReadDyns(args[1]);
                        }
                    }
                }
            }
            catch
            {
            }
        }
    }
}
