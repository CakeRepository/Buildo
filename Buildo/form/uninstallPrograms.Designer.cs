namespace Buildo.form
{
    partial class uninstallPrograms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uninstallPrograms));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.hpBloatRemoveButton = new System.Windows.Forms.Button();
            this.uninstallCheckedButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(163, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(634, 444);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonPanel.Controls.Add(this.hpBloatRemoveButton);
            this.buttonPanel.Controls.Add(this.uninstallCheckedButton);
            this.buttonPanel.Controls.Add(this.refreshButton);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPanel.Location = new System.Drawing.Point(3, 3);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(154, 444);
            this.buttonPanel.TabIndex = 1;
            // 
            // hpBloatRemoveButton
            // 
            this.hpBloatRemoveButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.hpBloatRemoveButton.ForeColor = System.Drawing.Color.Black;
            this.hpBloatRemoveButton.Location = new System.Drawing.Point(0, 162);
            this.hpBloatRemoveButton.Name = "hpBloatRemoveButton";
            this.hpBloatRemoveButton.Size = new System.Drawing.Size(154, 81);
            this.hpBloatRemoveButton.TabIndex = 3;
            this.hpBloatRemoveButton.Text = "HP Bloat Remover";
            this.hpBloatRemoveButton.UseVisualStyleBackColor = true;
            this.hpBloatRemoveButton.Click += new System.EventHandler(this.HpBloatRemoveButton_Click);
            // 
            // uninstallCheckedButton
            // 
            this.uninstallCheckedButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.uninstallCheckedButton.Location = new System.Drawing.Point(0, 81);
            this.uninstallCheckedButton.Name = "uninstallCheckedButton";
            this.uninstallCheckedButton.Size = new System.Drawing.Size(154, 81);
            this.uninstallCheckedButton.TabIndex = 2;
            this.uninstallCheckedButton.Text = "Uninstall Checked";
            this.uninstallCheckedButton.UseVisualStyleBackColor = true;
            this.uninstallCheckedButton.Click += new System.EventHandler(this.UninstallCheckedButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.refreshButton.Location = new System.Drawing.Point(0, 0);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(154, 81);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // uninstallPrograms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "uninstallPrograms";
            this.Text = "Uninstall Programs";
            this.Load += new System.EventHandler(this.UninstallPrograms_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button uninstallCheckedButton;
        private System.Windows.Forms.Button hpBloatRemoveButton;
    }
}