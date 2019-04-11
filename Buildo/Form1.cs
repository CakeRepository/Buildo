using Buildo.lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
