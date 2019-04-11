using Buildo.lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buildo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Methods
        private void Rtb_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void removeColumnOneControls()
        {
            var control = tableLayoutPanel1.GetControlFromPosition(1, 0);
            tableLayoutPanel1.Controls.Remove(control);
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
        #endregion


    }
}
