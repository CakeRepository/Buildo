namespace Buildo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chocoInstallsButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.UACOffButton = new System.Windows.Forms.Button();
            this.firewallButton = new System.Windows.Forms.Button();
            this.powerSettingsButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.HomePanel = new System.Windows.Forms.Panel();
            this.UtilizationPanel = new System.Windows.Forms.Panel();
            this.cpuProgressBar = new System.Windows.Forms.ProgressBar();
            this.hardDriveProgressBar = new System.Windows.Forms.ProgressBar();
            this.ramProgressBar = new System.Windows.Forms.ProgressBar();
            this.CPUL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.systemResourcesBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.HomePanel.SuspendLayout();
            this.UtilizationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.46259F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.53741F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.HomePanel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.60448F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(735, 536);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HomeButton);
            this.panel1.Controls.Add(this.updateButton);
            this.panel1.Controls.Add(this.chocoInstallsButton);
            this.panel1.Controls.Add(this.AboutButton);
            this.panel1.Controls.Add(this.UACOffButton);
            this.panel1.Controls.Add(this.firewallButton);
            this.panel1.Controls.Add(this.powerSettingsButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 530);
            this.panel1.TabIndex = 2;
            // 
            // chocoInstallsButton
            // 
            this.chocoInstallsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.chocoInstallsButton.Location = new System.Drawing.Point(0, 135);
            this.chocoInstallsButton.Name = "chocoInstallsButton";
            this.chocoInstallsButton.Size = new System.Drawing.Size(115, 45);
            this.chocoInstallsButton.TabIndex = 5;
            this.chocoInstallsButton.Text = "Choco Installs";
            this.chocoInstallsButton.UseVisualStyleBackColor = true;
            this.chocoInstallsButton.Click += new System.EventHandler(this.chocoInstallsButton_ClickAsync);
            // 
            // AboutButton
            // 
            this.AboutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AboutButton.Location = new System.Drawing.Point(0, 485);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(115, 45);
            this.AboutButton.TabIndex = 4;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // UACOffButton
            // 
            this.UACOffButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.UACOffButton.Location = new System.Drawing.Point(0, 90);
            this.UACOffButton.Name = "UACOffButton";
            this.UACOffButton.Size = new System.Drawing.Size(115, 45);
            this.UACOffButton.TabIndex = 3;
            this.UACOffButton.Text = "UAC Off";
            this.UACOffButton.UseVisualStyleBackColor = true;
            this.UACOffButton.Click += new System.EventHandler(this.UACOffButton_Click);
            // 
            // firewallButton
            // 
            this.firewallButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.firewallButton.Location = new System.Drawing.Point(0, 45);
            this.firewallButton.Name = "firewallButton";
            this.firewallButton.Size = new System.Drawing.Size(115, 45);
            this.firewallButton.TabIndex = 2;
            this.firewallButton.Text = "Firewall Off";
            this.firewallButton.UseVisualStyleBackColor = true;
            this.firewallButton.Click += new System.EventHandler(this.firewallButton_Click);
            // 
            // powerSettingsButton
            // 
            this.powerSettingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.powerSettingsButton.Location = new System.Drawing.Point(0, 0);
            this.powerSettingsButton.Name = "powerSettingsButton";
            this.powerSettingsButton.Size = new System.Drawing.Size(115, 45);
            this.powerSettingsButton.TabIndex = 1;
            this.powerSettingsButton.Text = "Power Settings";
            this.powerSettingsButton.UseVisualStyleBackColor = true;
            this.powerSettingsButton.Click += new System.EventHandler(this.powerSettingsButton_ClickAsync);
            // 
            // updateButton
            // 
            this.updateButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.updateButton.Location = new System.Drawing.Point(0, 180);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(115, 45);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Updates";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HomeButton.Location = new System.Drawing.Point(0, 440);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(115, 45);
            this.HomeButton.TabIndex = 7;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // HomePanel
            // 
            this.HomePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.HomePanel.Controls.Add(this.UtilizationPanel);
            this.HomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePanel.Location = new System.Drawing.Point(124, 3);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(608, 530);
            this.HomePanel.TabIndex = 3;
            // 
            // UtilizationPanel
            // 
            this.UtilizationPanel.Controls.Add(this.label3);
            this.UtilizationPanel.Controls.Add(this.label2);
            this.UtilizationPanel.Controls.Add(this.CPUL);
            this.UtilizationPanel.Controls.Add(this.cpuProgressBar);
            this.UtilizationPanel.Controls.Add(this.hardDriveProgressBar);
            this.UtilizationPanel.Controls.Add(this.ramProgressBar);
            this.UtilizationPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UtilizationPanel.Location = new System.Drawing.Point(0, 334);
            this.UtilizationPanel.Name = "UtilizationPanel";
            this.UtilizationPanel.Size = new System.Drawing.Size(608, 196);
            this.UtilizationPanel.TabIndex = 3;
            // 
            // cpuProgressBar
            // 
            this.cpuProgressBar.Location = new System.Drawing.Point(12, 19);
            this.cpuProgressBar.Name = "cpuProgressBar";
            this.cpuProgressBar.Size = new System.Drawing.Size(587, 50);
            this.cpuProgressBar.TabIndex = 8;
            // 
            // hardDriveProgressBar
            // 
            this.hardDriveProgressBar.Location = new System.Drawing.Point(12, 131);
            this.hardDriveProgressBar.Name = "hardDriveProgressBar";
            this.hardDriveProgressBar.Size = new System.Drawing.Size(587, 50);
            this.hardDriveProgressBar.TabIndex = 7;
            // 
            // ramProgressBar
            // 
            this.ramProgressBar.Location = new System.Drawing.Point(12, 75);
            this.ramProgressBar.Name = "ramProgressBar";
            this.ramProgressBar.Size = new System.Drawing.Size(587, 50);
            this.ramProgressBar.TabIndex = 6;
            // 
            // CPUL
            // 
            this.CPUL.AutoSize = true;
            this.CPUL.BackColor = System.Drawing.Color.White;
            this.CPUL.Location = new System.Drawing.Point(566, 48);
            this.CPUL.Name = "CPUL";
            this.CPUL.Size = new System.Drawing.Size(29, 13);
            this.CPUL.TabIndex = 9;
            this.CPUL.Text = "CPU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(566, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "RAM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(537, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Hard Drive";
            // 
            // systemResourcesBackgroundWorker
            // 
            this.systemResourcesBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.systemResourcesBackgroundWorker_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 536);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Buildo";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.HomePanel.ResumeLayout(false);
            this.UtilizationPanel.ResumeLayout(false);
            this.UtilizationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button powerSettingsButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button UACOffButton;
        private System.Windows.Forms.Button firewallButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button chocoInstallsButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.Panel UtilizationPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CPUL;
        private System.Windows.Forms.ProgressBar cpuProgressBar;
        private System.Windows.Forms.ProgressBar hardDriveProgressBar;
        private System.Windows.Forms.ProgressBar ramProgressBar;
        private System.ComponentModel.BackgroundWorker systemResourcesBackgroundWorker;
    }
}

