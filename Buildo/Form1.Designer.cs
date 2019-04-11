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
            this.powerSettingsButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.firewallButton = new System.Windows.Forms.Button();
            this.UACOffButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.46259F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.53741F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.60448F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(735, 536);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.powerSettingsButton.Click += new System.EventHandler(this.powerSettingsButton_Click);
            // 
            // panel1
            // 
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
            // firewallButton
            // 
            this.firewallButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.firewallButton.Location = new System.Drawing.Point(0, 45);
            this.firewallButton.Name = "firewallButton";
            this.firewallButton.Size = new System.Drawing.Size(115, 45);
            this.firewallButton.TabIndex = 2;
            this.firewallButton.Text = "Firewall Off";
            this.firewallButton.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button powerSettingsButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button UACOffButton;
        private System.Windows.Forms.Button firewallButton;
        private System.Windows.Forms.Button AboutButton;
    }
}

