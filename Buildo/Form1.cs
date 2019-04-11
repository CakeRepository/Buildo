using Buildo.lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using Microsoft.VisualBasic.Devices;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buildo
{
    public partial class Form1 : Form
    {
        PerformanceCounter cpuCounter;
        PerformanceCounter ramCounter;
        PerformanceCounter hddCounter;

        public Form1()
        {
            InitializeComponent();
            systemResourcesBackgroundWorker.RunWorkerAsync();
        }

        #region Methods
        private void systemResourcesBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            cpuCounter = new PerformanceCounter();
            cpuCounter.CategoryName = "Processor Information";
            cpuCounter.CounterName = "% Processor Time";
            cpuCounter.InstanceName = "_Total";

            ramCounter = new PerformanceCounter("Memory", "Available MBytes");

            hddCounter = new PerformanceCounter("PhysicalDisk", "% Disk Time", "_Total");

            ComputerInfo CI = new ComputerInfo();
            ulong mem = ulong.Parse(CI.TotalPhysicalMemory.ToString());

            int totalram = (int)(CI.TotalPhysicalMemory / (1024 * 1024));
            string windows = CI.OSFullName + " " + CI.OSVersion;

            while (1 == 1)
            {
                var t = getCPUUtil();
                this.cpuProgressBar.Invoke((MethodInvoker)delegate {
                    cpuProgressBar.Maximum = 100;
                    cpuProgressBar.Value = (int)t.Item1;
                });
                this.ramProgressBar.Invoke((MethodInvoker)delegate {
                    ramProgressBar.Maximum = totalram;
                    ramProgressBar.Value = totalram - (int)t.Item2;
                });
                this.hardDriveProgressBar.Invoke((MethodInvoker)delegate {
                    hardDriveProgressBar.Maximum = 100;
                    if(t.Item3 <= 100)
                    {
                        hardDriveProgressBar.Value = (int)t.Item3;
                    }
                });
                Thread.Sleep(1000);
            }
        }
        private void Rtb_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }
        private void sethomepage()
        {
            removeColumnOneControls();
            tableLayoutPanel1.Controls.Add(HomePanel, 1, 0);
        }
        private void removeColumnOneControls()
        {
            var control = tableLayoutPanel1.GetControlFromPosition(1, 0);
            tableLayoutPanel1.Controls.Remove(control);
        }
        private Tuple<float, float, float> getCPUUtil()
        {
            float cpuUsage = cpuCounter.NextValue();
            float ram = ramCounter.NextValue();
            float hdd = hddCounter.NextValue();
            return new Tuple<float, float, float>(cpuUsage, ram, hdd);
        }
        #endregion

        #region Buttons
        private void UACOffButton_Click(object sender, EventArgs e)
        {
            UAC uacremove = new UAC();
            uacremove.removeUAC();
        }
        private void firewallButton_Click(object sender, EventArgs e)
        {
            RemoveFirewall rf = new RemoveFirewall();
            rf.AllOff();
        }
        private void AboutButton_Click(object sender, EventArgs e)
        {
            removeColumnOneControls();

            RichTextBox rtb = new RichTextBox();
            rtb.ReadOnly = true;
            rtb.Dock = DockStyle.Fill;
            rtb.DetectUrls = true;
            rtb.LinkClicked += Rtb_LinkClicked;
            rtb.Text = "Welcome to Buildo where the automation Build Agent of the future!" + Environment.NewLine +
                "License: https://github.com/CakeRepository/Buildo/blob/master/LICENSE" + Environment.NewLine +
                "Github: https://github.com/CakeRepository/Buildo" + Environment.NewLine +
                "Please let me know if there are any issues I'd be happy to assist" + Environment.NewLine +
                Environment.NewLine +
                Environment.NewLine +
                Environment.NewLine +
                "Cake Program icon found at https://icons8.com/" + Environment.NewLine +
                "Thanks, " + Environment.NewLine +
                "Justin G. Trantham";

            tableLayoutPanel1.Controls.Add(rtb, 1, 0);

        }
        private async void powerSettingsButton_ClickAsync(object sender, EventArgs e)
        {
            RenameComputer ps = new RenameComputer();

            powerSettingsButton.Enabled = false;
            await Task.Run(() => ps.ChangeComputerName());
            powerSettingsButton.Enabled = true;
        }
        private async void chocoInstallsButton_ClickAsync(object sender, EventArgs e)
        {
            Choco choc = new Choco();

            chocoInstallsButton.Enabled = false;
            await Task.Run(() => choc.InstallPackages());
            chocoInstallsButton.Enabled = true;
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            WindowsUpdate wu = new WindowsUpdate();

            wu.OpenWindowsUpdate();
        }
        private void HomeButton_Click(object sender, EventArgs e)
        {
            sethomepage();
        }
        #endregion
        
    }
}
