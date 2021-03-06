﻿using Buildo.lib;
using System;
using System.ComponentModel;
using System.Diagnostics;
using Microsoft.VisualBasic.Devices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Buildo.form;

namespace Buildo
{
    public partial class Form1 : Form
    {

        #region Init Variables
        PerformanceCounter cpuCounter;
        PerformanceCounter ramCounter;
        PerformanceCounter hddCounter;
        #endregion

        /// <summary>
        /// Start here
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            sethomepage();
            systemResourcesBackgroundWorker.RunWorkerAsync();
        }

        #region Methods

        /// <summary>
        /// logs to listbox
        /// </summary>
        /// <param name="v">Item to log</param>
        private void log(string v)
        {
            DateTime now = DateTime.Now;
            logListBox.Items.Add(now.ToString("F") + ": " + v);
        }

        /// <summary>
        /// General Place for all items that need to be updates if the UI does
        /// </summary>
        private void updateIU()
        {
            lib.TimeZone tz = new lib.TimeZone();
            LocalInfo li = new LocalInfo();
            DateTime now = DateTime.Now;

            currentTimeLabel.Text = now.ToString("F");

            timeZoneLabel.Text = tz.getTimeZone();

            domainLabel.Text = li.getLocalWorkstationDomain();

            currentUserLabel.Text = li.getCurrentUser();

            computerNameLabel.Text = li.getMachineName();
        }
        /// <summary>
        /// background worker to get information about system resources
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Allows link in about to be clickable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Rtb_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        /// <summary>
        /// Return to homepage
        /// </summary>
        private void sethomepage()
        {
            removeColumnOneControls();
            updateIU();
            tableLayoutPanel1.Controls.Add(HomePanel, 1, 0);
        }
        
        private void removeColumnOneControls()
        {
            var control = tableLayoutPanel1.GetControlFromPosition(1, 0);
            tableLayoutPanel1.Controls.Remove(control);
        }
        
        /// <summary>
        /// Used for parsing through current computer utilization 
        /// </summary>
        /// <returns></returns>
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
            log("UAC Settings: " + uacremove.removeUAC());
        }
        private void firewallButton_Click(object sender, EventArgs e)
        {
            RemoveFirewall rf = new RemoveFirewall();
            log("Remove Firewall:" + rf.AllOff());
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
            PowerSettings ps = new PowerSettings();

            powerSettingsButton.Enabled = false;
            string psSettings = await Task.Run(() => ps.setPowerSettings());
            log(psSettings);
            powerSettingsButton.Enabled = true;
        }
        private async void chocoInstallsButton_ClickAsync(object sender, EventArgs e)
        {
            Choco choc = new Choco();

            chocoInstallsButton.Enabled = false;
            string t = await Task.Run(() => choc.InstallPackages());
            log("Choco: " + t);
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
        private void enableRDP_Click(object sender, EventArgs e)
        {
            EnableRDP eRDP = new EnableRDP();
            log("Enable RDP: " + eRDP.Enable());
            
        }        
        private void updateTimeZoneButton_Click(object sender, EventArgs e)
        {
            lib.TimeZone tz = new lib.TimeZone();
            string p = "\"";
            tz.setTimeZone(p + timeZoneComboBox.Text + p);
            TimeZoneInfo local = TimeZoneInfo.Local;

            TimeZoneInfo.ClearCachedData();
            local = TimeZoneInfo.Local;
            updateIU();
        }
        private async void automateButton_ClickAsync(object sender, EventArgs e)
        {
            buttonPanel.Enabled = false;
            EnableRDP eRDP = new EnableRDP();
            Choco choc = new Choco();
            PowerSettings ps = new PowerSettings();
            RemoveFirewall rf = new RemoveFirewall();
            UAC uacremove = new UAC();

            log("UAC Settings: " + uacremove.removeUAC());
            log("Remove Firewall:" + rf.AllOff());
            string psSettings = await Task.Run(() => ps.setPowerSettings());
            log(psSettings);
            string t = await Task.Run(() => choc.InstallPackages());
            log("Choco: " + t);
            eRDP.Enable();
            log("Enable RDP: " + eRDP.Enable());
            buttonPanel.Enabled = true;
        }


        #endregion

        private void UninstallProgramsButton_Click(object sender, EventArgs e)
        {
            Form up = new uninstallPrograms();
            up.Show();
        }
    }
}
