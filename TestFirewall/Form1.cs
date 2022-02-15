using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NetFwTypeLib;
using System.Diagnostics;
using System.IO;

namespace TestFirewall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Need using System.Diagnostics;
            string output;
            string line;

            /*
            string sWlanConnectionStatus = "";
            string sWlanConnectedSSID = "";
            string sWlanConnectedBSSID = "";
            int iWlanConnectionStatus = 0;
            bool bIsInCsvList = false;
             */
              

            try
            {

                //Advance Firewall Interfaces Status
                Process proc = new Process();
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.FileName = "netsh";
                proc.StartInfo.Arguments = "advfirewall show currentprofile";

                listBox1.Items.Add(proc.StartInfo.FileName + " " + proc.StartInfo.Arguments);
               

                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.UseShellExecute = false; // required for the Redirect setting above Process.Start(proc);
                proc.Start();
                output = proc.StandardOutput.ReadToEnd();
                proc.WaitForExit();

                StringReader sr = new StringReader(output.ToString());
                line = null;


                while ((line = sr.ReadLine()) != null)
                {
                    listBox1.Items.Add(line);
                }

                /*
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.StartsWith("General Failure"))
                    {
                        iWlanConnectionStatus = 0;
                        break;
                    }
                    if (line.StartsWith("    State"))
                    {

                        sWlanConnectionStatus = line.Substring(line.IndexOf(":") + 1).TrimStart(' ').TrimEnd(' ');
                        if (sWlanConnectionStatus == "connected") iWlanConnectionStatus = 1;
                        continue;
                    }
                    if (line.StartsWith("    SSID"))
                    {
                        sWlanConnectedSSID = line.Substring(line.IndexOf(":") + 1).TrimStart(' ').TrimEnd(' ');
                        continue;
                    }
                    if (line.StartsWith("    BSSID"))
                    {
                        sWlanConnectedBSSID = line.Substring(line.IndexOf(":") + 1).TrimStart(' ').TrimEnd(' ');
                        break;
                    }
                }; //While loop

                if (iWlanConnectionStatus == 0) //Not connected to any Wireless LAN
                {
                    performEncryption();
                    AddLogFile(sMonLocLogFullPath, "Not connected. Action Taken: Sensitive data will be encrypted.");
                }
                else
                {
                    CheckSsidDbCsv(sWlanConnectedSSID, out bIsInCsvList);

                    if (bIsInCsvList) //True = SSID is in the CSV list
                    {
                        //The SSID is authorised
                        performDecryption();
                        AddLogFile(sMonLocLogFullPath, "Connected to authourised SSID: " + sWlanConnectedSSID + " with MAC Address: " + sWlanConnectedBSSID);
                    }
                    else
                    {
                        //The SSID is unauthorised
                        performEncryption();
                        AddLogFile(sMonLocLogFullPath, "Connected to unauthourised SSID: " + sWlanConnectedSSID + " with MAC Address: " + sWlanConnectedBSSID
                            + ", Action Taken: Sensitive data will be encrypted.");
                    }
                };
                 * */

            }
            catch (Exception exp)
            {
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string output;
            string line;

            try
            {

                //Advance Firewall Interfaces Status
                Process proc = new Process();
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.FileName = "mmc";
                proc.StartInfo.Arguments = "WF.msc";

                listBox1.Items.Add(proc.StartInfo.FileName + " " + proc.StartInfo.Arguments);
                
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.UseShellExecute = false; // required for the Redirect setting above Process.Start(proc);
                proc.Start();
                output = proc.StandardOutput.ReadToEnd();
                proc.WaitForExit();

                StringReader sr = new StringReader(output.ToString());
                line = null;


                while ((line = sr.ReadLine()) != null)
                {
                    listBox1.Items.Add(line);
                }
            }
            catch (Exception exp)
            {
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sError;
            string sCmd;
            try
            {
                WinFirewall.AddPort(txtPort.Text, txtProtocol.Text, out sCmd, out sError);

                listBox1.Items.Add(sCmd);
                listBox1.Items.Add(sError);

            }
            catch (Exception exp)
            {
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sError;
            string sCmd;
            try
            {
                WinFirewall.RemovePort(txtPort.Text, txtProtocol.Text, out sCmd, out sError);
                listBox1.Items.Add(sCmd);
                listBox1.Items.Add(sError);
            }
            catch (Exception exp)
            {
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sError;
            string sCmd;
            try
            {
                WinFirewall.AddApp(txtApp.Text, txtAppPath.Text, out sCmd, out sError);
                listBox1.Items.Add(sCmd);
                listBox1.Items.Add(sError);

            }
            catch (Exception exp)
            {
            }
        }

        private void btnAddAdvApp_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSetLogging_Click(object sender, EventArgs e)
        {
            string sError;
            string sCmd;
            try
            {
                WinFirewall.SetLogging(txtLogFile.Text, txtLogPath.Text, txtLogSize.Text, out sCmd, out sError);
                listBox1.Items.Add(sCmd);
                listBox1.Items.Add(sError);

            }
            catch (Exception exp)
            {
            }
        }

        private void btnDeleteApp_Click(object sender, EventArgs e)
        {
            string sError;
            string sCmd;
            try
            {
                WinFirewall.RemoveApp(txtApp.Text, txtAppPath.Text, out sCmd, out sError);
                listBox1.Items.Add(sCmd);
                listBox1.Items.Add(sError);
            }
            catch (Exception exp)
            {
            }

        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            string sError;
            string sCmd;
            try
            {
                WinFirewall.EnableWinFirewall(out sCmd, out sError);
                listBox1.Items.Add(sCmd);
                listBox1.Items.Add(sError);
            }
            catch (Exception exp)
            {
            }
        }

    }
}
