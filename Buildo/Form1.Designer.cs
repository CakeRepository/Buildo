﻿namespace Buildo
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
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.automateButton = new System.Windows.Forms.Button();
            this.enableRDP = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.chocoInstallsButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.UACOffButton = new System.Windows.Forms.Button();
            this.firewallButton = new System.Windows.Forms.Button();
            this.powerSettingsButton = new System.Windows.Forms.Button();
            this.HomePanel = new System.Windows.Forms.Panel();
            this.computerNameLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.domainLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.logListBox = new System.Windows.Forms.ListBox();
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.timeZoneComboBox = new System.Windows.Forms.ComboBox();
            this.updateTimeZoneButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.timeZoneLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UtilizationPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CPUL = new System.Windows.Forms.Label();
            this.cpuProgressBar = new System.Windows.Forms.ProgressBar();
            this.hardDriveProgressBar = new System.Windows.Forms.ProgressBar();
            this.ramProgressBar = new System.Windows.Forms.ProgressBar();
            this.systemResourcesBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.uninstallProgramsButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.HomePanel.SuspendLayout();
            this.UtilizationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.46259F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.53741F));
            this.tableLayoutPanel1.Controls.Add(this.buttonPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.HomePanel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.60448F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(736, 543);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.uninstallProgramsButton);
            this.buttonPanel.Controls.Add(this.automateButton);
            this.buttonPanel.Controls.Add(this.enableRDP);
            this.buttonPanel.Controls.Add(this.HomeButton);
            this.buttonPanel.Controls.Add(this.updateButton);
            this.buttonPanel.Controls.Add(this.chocoInstallsButton);
            this.buttonPanel.Controls.Add(this.AboutButton);
            this.buttonPanel.Controls.Add(this.UACOffButton);
            this.buttonPanel.Controls.Add(this.firewallButton);
            this.buttonPanel.Controls.Add(this.powerSettingsButton);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPanel.Location = new System.Drawing.Point(3, 3);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(115, 537);
            this.buttonPanel.TabIndex = 2;
            // 
            // automateButton
            // 
            this.automateButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.automateButton.Location = new System.Drawing.Point(0, 270);
            this.automateButton.Name = "automateButton";
            this.automateButton.Size = new System.Drawing.Size(115, 45);
            this.automateButton.TabIndex = 9;
            this.automateButton.Text = "Automate";
            this.automateButton.UseVisualStyleBackColor = true;
            this.automateButton.Click += new System.EventHandler(this.automateButton_ClickAsync);
            // 
            // enableRDP
            // 
            this.enableRDP.Dock = System.Windows.Forms.DockStyle.Top;
            this.enableRDP.Location = new System.Drawing.Point(0, 225);
            this.enableRDP.Name = "enableRDP";
            this.enableRDP.Size = new System.Drawing.Size(115, 45);
            this.enableRDP.TabIndex = 8;
            this.enableRDP.Text = "Enable RDP";
            this.enableRDP.UseVisualStyleBackColor = true;
            this.enableRDP.Click += new System.EventHandler(this.enableRDP_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HomeButton.Location = new System.Drawing.Point(0, 447);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(115, 45);
            this.HomeButton.TabIndex = 7;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
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
            this.AboutButton.Location = new System.Drawing.Point(0, 492);
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
            // HomePanel
            // 
            this.HomePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.HomePanel.Controls.Add(this.computerNameLabel);
            this.HomePanel.Controls.Add(this.label8);
            this.HomePanel.Controls.Add(this.currentUserLabel);
            this.HomePanel.Controls.Add(this.label7);
            this.HomePanel.Controls.Add(this.domainLabel);
            this.HomePanel.Controls.Add(this.label5);
            this.HomePanel.Controls.Add(this.logListBox);
            this.HomePanel.Controls.Add(this.currentTimeLabel);
            this.HomePanel.Controls.Add(this.timeZoneComboBox);
            this.HomePanel.Controls.Add(this.updateTimeZoneButton);
            this.HomePanel.Controls.Add(this.label4);
            this.HomePanel.Controls.Add(this.timeZoneLabel);
            this.HomePanel.Controls.Add(this.label1);
            this.HomePanel.Controls.Add(this.UtilizationPanel);
            this.HomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePanel.Location = new System.Drawing.Point(124, 3);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(609, 537);
            this.HomePanel.TabIndex = 3;
            // 
            // computerNameLabel
            // 
            this.computerNameLabel.AutoSize = true;
            this.computerNameLabel.Location = new System.Drawing.Point(426, 58);
            this.computerNameLabel.Name = "computerNameLabel";
            this.computerNameLabel.Size = new System.Drawing.Size(105, 13);
            this.computerNameLabel.TabIndex = 16;
            this.computerNameLabel.Text = "computerNameLabel";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(337, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Computer Name:";
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.AutoSize = true;
            this.currentUserLabel.Location = new System.Drawing.Point(426, 32);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.Size = new System.Drawing.Size(88, 13);
            this.currentUserLabel.TabIndex = 14;
            this.currentUserLabel.Text = "currentUserLabel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(351, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Current User:";
            // 
            // domainLabel
            // 
            this.domainLabel.AutoSize = true;
            this.domainLabel.Location = new System.Drawing.Point(426, 10);
            this.domainLabel.Name = "domainLabel";
            this.domainLabel.Size = new System.Drawing.Size(67, 13);
            this.domainLabel.TabIndex = 12;
            this.domainLabel.Text = "domainLabel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Domain:";
            // 
            // logListBox
            // 
            this.logListBox.FormattingEnabled = true;
            this.logListBox.Location = new System.Drawing.Point(18, 233);
            this.logListBox.Name = "logListBox";
            this.logListBox.Size = new System.Drawing.Size(583, 82);
            this.logListBox.TabIndex = 10;
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.AutoSize = true;
            this.currentTimeLabel.Location = new System.Drawing.Point(104, 32);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(89, 13);
            this.currentTimeLabel.TabIndex = 9;
            this.currentTimeLabel.Text = "currentTimeLabel";
            // 
            // timeZoneComboBox
            // 
            this.timeZoneComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeZoneComboBox.FormattingEnabled = true;
            this.timeZoneComboBox.Items.AddRange(new object[] {
            "Central Standard Time",
            "Mountain Standard Time",
            "Pacific Standard Time",
            "Eastern Standard Time"});
            this.timeZoneComboBox.Location = new System.Drawing.Point(107, 58);
            this.timeZoneComboBox.Name = "timeZoneComboBox";
            this.timeZoneComboBox.Size = new System.Drawing.Size(168, 21);
            this.timeZoneComboBox.TabIndex = 8;
            // 
            // updateTimeZoneButton
            // 
            this.updateTimeZoneButton.Location = new System.Drawing.Point(106, 90);
            this.updateTimeZoneButton.Name = "updateTimeZoneButton";
            this.updateTimeZoneButton.Size = new System.Drawing.Size(75, 23);
            this.updateTimeZoneButton.TabIndex = 7;
            this.updateTimeZoneButton.Text = "Update";
            this.updateTimeZoneButton.UseVisualStyleBackColor = true;
            this.updateTimeZoneButton.Click += new System.EventHandler(this.updateTimeZoneButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "New Time Zone:";
            // 
            // timeZoneLabel
            // 
            this.timeZoneLabel.AutoSize = true;
            this.timeZoneLabel.Location = new System.Drawing.Point(104, 10);
            this.timeZoneLabel.Name = "timeZoneLabel";
            this.timeZoneLabel.Size = new System.Drawing.Size(77, 13);
            this.timeZoneLabel.TabIndex = 5;
            this.timeZoneLabel.Text = "timeZoneLabel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Time Zone:";
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
            this.UtilizationPanel.Location = new System.Drawing.Point(0, 341);
            this.UtilizationPanel.Name = "UtilizationPanel";
            this.UtilizationPanel.Size = new System.Drawing.Size(609, 196);
            this.UtilizationPanel.TabIndex = 3;
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
            // systemResourcesBackgroundWorker
            // 
            this.systemResourcesBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.systemResourcesBackgroundWorker_DoWork);
            // 
            // uninstallProgramsButton
            // 
            this.uninstallProgramsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.uninstallProgramsButton.Location = new System.Drawing.Point(0, 315);
            this.uninstallProgramsButton.Name = "uninstallProgramsButton";
            this.uninstallProgramsButton.Size = new System.Drawing.Size(115, 45);
            this.uninstallProgramsButton.TabIndex = 10;
            this.uninstallProgramsButton.Text = "Uninstall Programs";
            this.uninstallProgramsButton.UseVisualStyleBackColor = true;
            this.uninstallProgramsButton.Click += new System.EventHandler(this.UninstallProgramsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 543);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(752, 582);
            this.Name = "Form1";
            this.Text = "Buildo";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.buttonPanel.ResumeLayout(false);
            this.HomePanel.ResumeLayout(false);
            this.HomePanel.PerformLayout();
            this.UtilizationPanel.ResumeLayout(false);
            this.UtilizationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button powerSettingsButton;
        private System.Windows.Forms.Panel buttonPanel;
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
        private System.Windows.Forms.Button enableRDP;
        private System.Windows.Forms.Label timeZoneLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox timeZoneComboBox;
        private System.Windows.Forms.Button updateTimeZoneButton;
        private System.Windows.Forms.Label currentTimeLabel;
        private System.Windows.Forms.Button automateButton;
        private System.Windows.Forms.ListBox logListBox;
        private System.Windows.Forms.Label domainLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label currentUserLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label computerNameLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button uninstallProgramsButton;
    }
}

