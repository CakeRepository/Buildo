using Buildo.lib;
using Buildo.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buildo.form
{
    public partial class uninstallPrograms : Form
    {
        UninstallProgram uPrograms;
        public uninstallPrograms()
        {
            InitializeComponent();
        }

        private void UninstallPrograms_Load(object sender, EventArgs e)
        {
            createDatatable();
            displayApps();
        }

        private void createDatatable()
        {
            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "X";
            checkColumn.HeaderText = "Check";
            checkColumn.Width = 50;
            checkColumn.ValueType = typeof(bool);
            checkColumn.ReadOnly = false;
            checkColumn.FillWeight = 10;
            dataGridView1.Columns.Add(checkColumn);           

            DataGridViewTextBoxColumn productNameColumn = new DataGridViewTextBoxColumn();
            productNameColumn.Name = "ProductName";
            productNameColumn.HeaderText = "Product Name";
            productNameColumn.Width = 175;
            productNameColumn.ReadOnly = true;
            productNameColumn.ToolTipText = "Product Name";
            dataGridView1.Columns.Add(productNameColumn);

            DataGridViewTextBoxColumn uninstallStringColumn = new DataGridViewTextBoxColumn();
            uninstallStringColumn.Name = "UninstallString";
            uninstallStringColumn.HeaderText = "Uninstall String";
            uninstallStringColumn.Width = 275;
            uninstallStringColumn.ReadOnly = true;
            dataGridView1.Columns.Add(uninstallStringColumn);

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void displayApps()
        {
            dataGridView1.Rows.Clear();
            uPrograms = new UninstallProgram(); 
            var uninstallList = uPrograms.getApplication();
            var noDupes = uninstallList.Distinct().ToList();
            foreach (var tmp in noDupes)
            {
                var index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells["ProductName"].Value = tmp.Item1;
                dataGridView1.Rows[index].Cells["UninstallString"].Value = tmp.Item2;
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            displayApps();
        }

        private void UninstallCheckedButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    string productName = Convert.ToString(row.Cells[1].Value);
                    string uninstallString = Convert.ToString(row.Cells[2].Value);

                    if (uninstallString.Contains('{'))
                    {
                        
                        string splitGUID = uninstallString.Split('{', '}')[1];
                        CMD cmd = new CMD();
                        cmd.RunCMD("msiexec /x {" + splitGUID + "}");

                    }
                    else
                    {


                        try
                        {
                            Process process = new Process();
                            // Configure the process using the StartInfo properties.
                            process.StartInfo.FileName = Convert.ToString(row.Cells[2].Value);
                            process.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
                            process.Start();
                            process.WaitForExit();// Waits here for the process to exit.
                                                  // You can start any process, HelloWorld is a do-nothing example.

                            // This code assumes the process you are starting will terminate itself. 
                            // Given that is is started without a window so you cannot terminate it 
                            // on the desktop, it must terminate itself or you can do it programmatically
                            // from this application using the Kill method.

                        }
                        catch
                        {

                        }
                    }

                }
            }
        }

        private void HpBloatRemoveButton_Click(object sender, EventArgs e)
        {
            buttonPanel.Enabled = false;
            hpBloatRunnerAsync();
            
        }
        private async void hpBloatRunnerAsync()
        {
            UninstallProgram us = new UninstallProgram();
            await Task.Run(() => us.uninstallHPBloat());
            buttonPanel.Enabled = true;
        }
    }
}
