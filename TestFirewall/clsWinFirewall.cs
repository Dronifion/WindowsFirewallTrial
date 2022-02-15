using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace TestFirewall
{
    class WinFirewall
    {
        static WinFirewall()
        { 
            //...
        }

        public static bool AddPort (string sPort, string sProtocol, out string sCmd, out string sError) 
        {
            string output;
            string line;

            try
            {

                //Advance Firewall Interfaces Status
                //sProtocol is either TCP or UDP
                Process proc = new Process();
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.FileName = "netsh";
                proc.StartInfo.Arguments = "advfirewall firewall add rule name=\"bDLP Policy: IP Port: " + sPort + "\" dir=in action=allow protocol=" + sProtocol + " localport=" + sPort;

                sCmd = proc.StartInfo.FileName + " " + proc.StartInfo.Arguments;

                //listBox1.Items.Add(proc.StartInfo.FileName + " " + proc.StartInfo.Arguments);

                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.UseShellExecute = false; // required for the Redirect setting above Process.Start(proc);
                proc.Start();
                output = proc.StandardOutput.ReadToEnd();
                proc.WaitForExit();

                sError = "";
                return true;

                StringReader sr = new StringReader(output.ToString());
                line = null;


                while ((line = sr.ReadLine()) != null)
                {
                    //listBox1.Items.Add(line);
                }
            }
            catch (Exception exp)
            {
                sError = exp.Message;
                sCmd = "";
                return false;
            }
        }

        public static bool RemovePort(string sPort, string sProtocol, out string sCmd, out string sError)
        {
            try
            {

                //Advance Firewall Interfaces Status
                //sProtocol is either TCP or UDP
                Process proc = new Process();
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.FileName = "netsh";
                proc.StartInfo.Arguments = "advfirewall firewall delete rule name=\"bDLP Policy: IP Port: " + sPort + "\" protocol=" + sProtocol +  " localport=" + sPort;
                sCmd = proc.StartInfo.FileName + " " + proc.StartInfo.Arguments;

                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.UseShellExecute = false; // required for the Redirect setting above Process.Start(proc);
                proc.Start();
                proc.WaitForExit();

                sError = "";
                return true;
            }
            catch (Exception exp)
            {
                sError = exp.Message;
                sCmd = "";
                return false;
            }
        }

        public static bool AddApp(string sAppName, string sAppPath, out string sCmd, out string sError)
        {
            try
            {

                //Advance Firewall Interfaces Status
                Process proc = new Process();
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.FileName = "netsh";
                proc.StartInfo.Arguments = "advfirewall firewall add rule name=\"bDLP Policy: " + sAppName + "\" dir=in action=allow program=\"" + sAppPath + "\" enable=yes";
                sCmd = proc.StartInfo.FileName + " " + proc.StartInfo.Arguments;

                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.UseShellExecute = false; // required for the Redirect setting above Process.Start(proc);
                proc.Start();
                proc.WaitForExit();

                sError = "";
                return true;
            }
            catch (Exception exp)
            {
                sError = exp.Message;
                sCmd = "";
                return false;
            }
        }

        public static bool RemoveApp(string sAppName, string sAppPath, out string sCmd, out string sError)
        {
            try
            {

                //Advance Firewall Interfaces Status
                Process proc = new Process();
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.FileName = "netsh";
                proc.StartInfo.Arguments = "advfirewall firewall delete rule name=\"bDLP Policy: " + sAppName + "\" program=\"" + sAppPath + "\"";
                sCmd = proc.StartInfo.FileName + " " + proc.StartInfo.Arguments;

                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.UseShellExecute = false; // required for the Redirect setting above Process.Start(proc);
                proc.Start();
                proc.WaitForExit();

                sError = "";
                return true;
            }
            catch (Exception exp)
            {
                sError = exp.Message;
                sCmd = "";
                return false;
            }
        }


        public static bool SetLogging(string sLogFileName, string sLogPath, string sLogSize, out string sCmd, out string sError)
        {
            try
            {

                //Advance Firewall Interfaces Status
                //sLogPath e.g. %systemroot%\system32\LogFiles\Firewall\bDlpfirewall.log
                //sLogSize e.g. 4096
                Process proc = new Process();
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.UseShellExecute = false; // required for the Redirect setting above Process.Start(proc);

                //Command #1
                proc.StartInfo.FileName = "netsh";
                proc.StartInfo.Arguments = "advfirewall set currentprofile logging \"" + sLogFileName + "\" " + sLogPath;
                sCmd = proc.StartInfo.FileName + " " + proc.StartInfo.Arguments;
                proc.Start();
                proc.WaitForExit();

                //Command #2
                proc.StartInfo.FileName = "netsh";
                proc.StartInfo.Arguments = "advfirewall set currentprofile logging maxfilesize " + sLogSize;
                sCmd = sCmd + " ## " + proc.StartInfo.FileName + " " + proc.StartInfo.Arguments;
                proc.Start();
                proc.WaitForExit();

                //Command #3
                proc.StartInfo.FileName = "netsh";
                proc.StartInfo.Arguments = "advfirewall set currentprofile logging droppedconnections enable";
                sCmd = sCmd + " ## " + proc.StartInfo.FileName + " " + proc.StartInfo.Arguments;
                proc.Start();
                proc.WaitForExit();

                //Command #4
                proc.StartInfo.FileName = "netsh";
                proc.StartInfo.Arguments = "advfirewall set currentprofile logging allowedconnections enable";
                sCmd = sCmd + " ## " + proc.StartInfo.FileName + " " + proc.StartInfo.Arguments;
                proc.Start();
                proc.WaitForExit();
                
                sError = "";
                return true;
            }
            catch (Exception exp)
            {
                sError = exp.Message;
                sCmd = "";
                return false;
            }
        }

        public static bool EnableWinFirewall(out string sCmd, out string sError)
        {
            try
            {

                //Advance Firewall Interfaces Status
                Process proc = new Process();
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.UseShellExecute = false; // required for the Redirect setting above Process.Start(proc);

                //Command #1
                proc.StartInfo.FileName = "netsh";
                proc.StartInfo.Arguments = "advfirewall set currentprofile state on";
                sCmd = proc.StartInfo.FileName + " " + proc.StartInfo.Arguments;

                proc.Start();
                proc.WaitForExit();


                sError = "";
                return true;
            }
            catch (Exception exp)
            {
                sError = exp.Message;
                sCmd = "";
                return false;
            }
        }

    }
}
