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
            initUI();
        }

        private void initUI()
        {
            
        }

        private void powerSettingsButton_Click(object sender, EventArgs e)
        {
            RenameComputer ps = new RenameComputer();

            ps.ChangeComputerName();
        }

        private void removeUACButton_Click_1(object sender, EventArgs e)
        {
            UAC uacremove = new UAC();
            uacremove.removeUAC();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            
            RichTextBox rtb = new RichTextBox();
            rtb.ReadOnly = true;
            rtb.Dock = DockStyle.Fill;
            rtb.Text = "Welcome to Buildo where the automation Build Agent of the future!" + Environment.NewLine +
                "Copyright 2019 MIT License" + Environment.NewLine +
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
    }
}
