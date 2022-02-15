namespace TestFirewall
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
            this.btnShowProfile = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAddApp = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtProtocol = new System.Windows.Forms.TextBox();
            this.btnDeletePort = new System.Windows.Forms.Button();
            this.btnAppApp = new System.Windows.Forms.Button();
            this.txtApp = new System.Windows.Forms.TextBox();
            this.txtAppPath = new System.Windows.Forms.TextBox();
            this.txtRemoteIp = new System.Windows.Forms.TextBox();
            this.txtProfile = new System.Windows.Forms.TextBox();
            this.btnDeleteApp = new System.Windows.Forms.Button();
            this.btnSetLogging = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtLogFile = new System.Windows.Forms.TextBox();
            this.txtLogPath = new System.Windows.Forms.TextBox();
            this.txtLogSize = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMMC = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowProfile
            // 
            this.btnShowProfile.Location = new System.Drawing.Point(12, 257);
            this.btnShowProfile.Name = "btnShowProfile";
            this.btnShowProfile.Size = new System.Drawing.Size(576, 23);
            this.btnShowProfile.TabIndex = 0;
            this.btnShowProfile.Text = "Show current firewall profiles";
            this.btnShowProfile.UseVisualStyleBackColor = true;
            this.btnShowProfile.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(577, 238);
            this.listBox1.TabIndex = 1;
            // 
            // btnAddApp
            // 
            this.btnAddApp.Location = new System.Drawing.Point(255, 317);
            this.btnAddApp.Name = "btnAddApp";
            this.btnAddApp.Size = new System.Drawing.Size(333, 23);
            this.btnAddApp.TabIndex = 3;
            this.btnAddApp.Text = "Add a port";
            this.btnAddApp.UseVisualStyleBackColor = true;
            this.btnAddApp.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(191, 320);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(58, 20);
            this.txtPort.TabIndex = 4;
            this.txtPort.Text = "8383";
            // 
            // txtProtocol
            // 
            this.txtProtocol.Location = new System.Drawing.Point(12, 320);
            this.txtProtocol.Name = "txtProtocol";
            this.txtProtocol.Size = new System.Drawing.Size(173, 20);
            this.txtProtocol.TabIndex = 5;
            this.txtProtocol.Text = "TCP";
            // 
            // btnDeletePort
            // 
            this.btnDeletePort.Location = new System.Drawing.Point(255, 346);
            this.btnDeletePort.Name = "btnDeletePort";
            this.btnDeletePort.Size = new System.Drawing.Size(333, 23);
            this.btnDeletePort.TabIndex = 6;
            this.btnDeletePort.Text = "Delete a port";
            this.btnDeletePort.UseVisualStyleBackColor = true;
            this.btnDeletePort.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAppApp
            // 
            this.btnAppApp.Location = new System.Drawing.Point(352, 385);
            this.btnAppApp.Name = "btnAppApp";
            this.btnAppApp.Size = new System.Drawing.Size(236, 23);
            this.btnAppApp.TabIndex = 8;
            this.btnAppApp.Text = "Add Application";
            this.btnAppApp.UseVisualStyleBackColor = true;
            this.btnAppApp.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtApp
            // 
            this.txtApp.Location = new System.Drawing.Point(12, 385);
            this.txtApp.Name = "txtApp";
            this.txtApp.Size = new System.Drawing.Size(117, 20);
            this.txtApp.TabIndex = 9;
            this.txtApp.Text = "My App";
            // 
            // txtAppPath
            // 
            this.txtAppPath.Location = new System.Drawing.Point(135, 385);
            this.txtAppPath.Name = "txtAppPath";
            this.txtAppPath.Size = new System.Drawing.Size(211, 20);
            this.txtAppPath.TabIndex = 10;
            this.txtAppPath.Text = "c:\\My App\\MyApp.exe";
            // 
            // txtRemoteIp
            // 
            this.txtRemoteIp.Location = new System.Drawing.Point(13, 412);
            this.txtRemoteIp.Name = "txtRemoteIp";
            this.txtRemoteIp.Size = new System.Drawing.Size(198, 20);
            this.txtRemoteIp.TabIndex = 11;
            this.txtRemoteIp.Text = "157.60.0.1,172.16.0.0/16";
            // 
            // txtProfile
            // 
            this.txtProfile.Location = new System.Drawing.Point(218, 412);
            this.txtProfile.Name = "txtProfile";
            this.txtProfile.Size = new System.Drawing.Size(128, 20);
            this.txtProfile.TabIndex = 12;
            this.txtProfile.Text = "domain";
            // 
            // btnDeleteApp
            // 
            this.btnDeleteApp.Location = new System.Drawing.Point(352, 414);
            this.btnDeleteApp.Name = "btnDeleteApp";
            this.btnDeleteApp.Size = new System.Drawing.Size(236, 23);
            this.btnDeleteApp.TabIndex = 13;
            this.btnDeleteApp.Text = "Remove Application";
            this.btnDeleteApp.UseVisualStyleBackColor = true;
            this.btnDeleteApp.Click += new System.EventHandler(this.btnDeleteApp_Click);
            // 
            // btnSetLogging
            // 
            this.btnSetLogging.Location = new System.Drawing.Point(352, 455);
            this.btnSetLogging.Name = "btnSetLogging";
            this.btnSetLogging.Size = new System.Drawing.Size(237, 23);
            this.btnSetLogging.TabIndex = 15;
            this.btnSetLogging.Text = "Set Firewall Logging";
            this.btnSetLogging.UseVisualStyleBackColor = true;
            this.btnSetLogging.Click += new System.EventHandler(this.btnSetLogging_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(13, 374);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 3);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(13, 446);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(575, 3);
            this.panel2.TabIndex = 17;
            // 
            // txtLogFile
            // 
            this.txtLogFile.Location = new System.Drawing.Point(13, 457);
            this.txtLogFile.Name = "txtLogFile";
            this.txtLogFile.Size = new System.Drawing.Size(227, 20);
            this.txtLogFile.TabIndex = 18;
            this.txtLogFile.Text = "My Firewall Log";
            // 
            // txtLogPath
            // 
            this.txtLogPath.Location = new System.Drawing.Point(13, 484);
            this.txtLogPath.Name = "txtLogPath";
            this.txtLogPath.Size = new System.Drawing.Size(333, 20);
            this.txtLogPath.TabIndex = 19;
            this.txtLogPath.Text = "%systemroot%\\system32\\LogFiles\\Firewall\\bDlpfirewall.log";
            // 
            // txtLogSize
            // 
            this.txtLogSize.Location = new System.Drawing.Point(246, 458);
            this.txtLogSize.Name = "txtLogSize";
            this.txtLogSize.Size = new System.Drawing.Size(100, 20);
            this.txtLogSize.TabIndex = 20;
            this.txtLogSize.Text = "4096";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(14, 510);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(575, 3);
            this.panel3.TabIndex = 21;
            // 
            // btnMMC
            // 
            this.btnMMC.Location = new System.Drawing.Point(12, 286);
            this.btnMMC.Name = "btnMMC";
            this.btnMMC.Size = new System.Drawing.Size(576, 23);
            this.btnMMC.TabIndex = 2;
            this.btnMMC.Text = "Windows Firewall MMC snap-in";
            this.btnMMC.UseVisualStyleBackColor = true;
            this.btnMMC.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.Location = new System.Drawing.Point(14, 519);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(576, 23);
            this.btnEnable.TabIndex = 22;
            this.btnEnable.Text = "Enable Firewall";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 548);
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtLogSize);
            this.Controls.Add(this.txtLogPath);
            this.Controls.Add(this.txtLogFile);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSetLogging);
            this.Controls.Add(this.btnDeleteApp);
            this.Controls.Add(this.txtProfile);
            this.Controls.Add(this.txtRemoteIp);
            this.Controls.Add(this.txtAppPath);
            this.Controls.Add(this.txtApp);
            this.Controls.Add(this.btnAppApp);
            this.Controls.Add(this.btnDeletePort);
            this.Controls.Add(this.txtProtocol);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.btnAddApp);
            this.Controls.Add(this.btnMMC);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnShowProfile);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Windows Firewall";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowProfile;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAddApp;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtProtocol;
        private System.Windows.Forms.Button btnDeletePort;
        private System.Windows.Forms.Button btnAppApp;
        private System.Windows.Forms.TextBox txtApp;
        private System.Windows.Forms.TextBox txtAppPath;
        private System.Windows.Forms.TextBox txtRemoteIp;
        private System.Windows.Forms.TextBox txtProfile;
        private System.Windows.Forms.Button btnDeleteApp;
        private System.Windows.Forms.Button btnSetLogging;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtLogFile;
        private System.Windows.Forms.TextBox txtLogPath;
        private System.Windows.Forms.TextBox txtLogSize;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMMC;
        private System.Windows.Forms.Button btnEnable;
    }
}

