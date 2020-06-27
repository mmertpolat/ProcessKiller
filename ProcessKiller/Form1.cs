using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessKiller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process[] runingProcess = Process.GetProcesses();
            for (int i = 0; i < runingProcess.Length; i++)
            {
                // compare equivalent process by their name
                if (runingProcess[i].ProcessName == "AdobeIPCBroker" || runingProcess[i].ProcessName == "AdobeUpdateService" || runingProcess[i].ProcessName == "AGMService" || runingProcess[i].ProcessName == "AGSService" || runingProcess[i].ProcessName == "armsvc" || runingProcess[i].ProcessName == "CCLibrary" || runingProcess[i].ProcessName == "CCXProcess" || runingProcess[i].ProcessName == "node" || runingProcess[i].ProcessName == "vpnagent" || runingProcess[i].ProcessName == "TeamViewer_Service" || runingProcess[i].ProcessName == "AcroTray" || runingProcess[i].ProcessName == "TeamViewer" || runingProcess[i].ProcessName == "sqlceip" || runingProcess[i].ProcessName == "sqlservr" || runingProcess[i].ProcessName == "sqlwriter")
                {
                    // kill  running process
                    runingProcess[i].Kill();

                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.muhammedmertpolat.com");
        }
    }
}
