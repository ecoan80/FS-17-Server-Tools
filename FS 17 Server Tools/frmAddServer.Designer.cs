namespace FS_17_Server_Tools
{
    partial class frmAddServer
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
            this.rbtHTTP = new System.Windows.Forms.RadioButton();
            this.rbtHTTPS = new System.Windows.Forms.RadioButton();
            this.grpProtocol = new System.Windows.Forms.GroupBox();
            this.grpHostname = new System.Windows.Forms.GroupBox();
            this.txtHostName = new System.Windows.Forms.TextBox();
            this.grpPort = new System.Windows.Forms.GroupBox();
            this.txtPortNum = new System.Windows.Forms.TextBox();
            this.grpCredentials = new System.Windows.Forms.GroupBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkAnonDownload = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtWebApiCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddServer = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnCancelAddServer = new System.Windows.Forms.Button();
            this.grpProtocol.SuspendLayout();
            this.grpHostname.SuspendLayout();
            this.grpPort.SuspendLayout();
            this.grpCredentials.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtHTTP
            // 
            this.rbtHTTP.AutoSize = true;
            this.rbtHTTP.Checked = true;
            this.rbtHTTP.Location = new System.Drawing.Point(21, 19);
            this.rbtHTTP.Name = "rbtHTTP";
            this.rbtHTTP.Size = new System.Drawing.Size(56, 17);
            this.rbtHTTP.TabIndex = 0;
            this.rbtHTTP.TabStop = true;
            this.rbtHTTP.Text = "http://";
            this.rbtHTTP.UseVisualStyleBackColor = true;
            // 
            // rbtHTTPS
            // 
            this.rbtHTTPS.AutoSize = true;
            this.rbtHTTPS.Location = new System.Drawing.Point(83, 19);
            this.rbtHTTPS.Name = "rbtHTTPS";
            this.rbtHTTPS.Size = new System.Drawing.Size(61, 17);
            this.rbtHTTPS.TabIndex = 1;
            this.rbtHTTPS.TabStop = true;
            this.rbtHTTPS.Text = "https://";
            this.rbtHTTPS.UseVisualStyleBackColor = true;
            // 
            // grpProtocol
            // 
            this.grpProtocol.Controls.Add(this.rbtHTTP);
            this.grpProtocol.Controls.Add(this.rbtHTTPS);
            this.grpProtocol.Location = new System.Drawing.Point(12, 12);
            this.grpProtocol.Name = "grpProtocol";
            this.grpProtocol.Size = new System.Drawing.Size(160, 49);
            this.grpProtocol.TabIndex = 2;
            this.grpProtocol.TabStop = false;
            this.grpProtocol.Text = "Protocol";
            // 
            // grpHostname
            // 
            this.grpHostname.Controls.Add(this.txtHostName);
            this.grpHostname.Location = new System.Drawing.Point(178, 12);
            this.grpHostname.Name = "grpHostname";
            this.grpHostname.Size = new System.Drawing.Size(363, 49);
            this.grpHostname.TabIndex = 3;
            this.grpHostname.TabStop = false;
            this.grpHostname.Text = "IP Address or FQDN";
            // 
            // txtHostName
            // 
            this.txtHostName.Location = new System.Drawing.Point(6, 20);
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.Size = new System.Drawing.Size(351, 20);
            this.txtHostName.TabIndex = 0;
            this.txtHostName.Leave += new System.EventHandler(this.txtHostName_Leave);
            // 
            // grpPort
            // 
            this.grpPort.Controls.Add(this.txtPortNum);
            this.grpPort.Location = new System.Drawing.Point(547, 12);
            this.grpPort.Name = "grpPort";
            this.grpPort.Size = new System.Drawing.Size(121, 49);
            this.grpPort.TabIndex = 4;
            this.grpPort.TabStop = false;
            this.grpPort.Text = "Web Server Port";
            // 
            // txtPortNum
            // 
            this.txtPortNum.Location = new System.Drawing.Point(6, 19);
            this.txtPortNum.Name = "txtPortNum";
            this.txtPortNum.Size = new System.Drawing.Size(104, 20);
            this.txtPortNum.TabIndex = 0;
            // 
            // grpCredentials
            // 
            this.grpCredentials.Controls.Add(this.lblPassword);
            this.grpCredentials.Controls.Add(this.lblUserName);
            this.grpCredentials.Controls.Add(this.txtUsername);
            this.grpCredentials.Controls.Add(this.txtPassword);
            this.grpCredentials.Controls.Add(this.chkAnonDownload);
            this.grpCredentials.Location = new System.Drawing.Point(12, 67);
            this.grpCredentials.Name = "grpCredentials";
            this.grpCredentials.Size = new System.Drawing.Size(656, 73);
            this.grpCredentials.TabIndex = 5;
            this.grpCredentials.TabStop = false;
            this.grpCredentials.Text = "Credentials";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(415, 33);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(169, 34);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(58, 13);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(233, 31);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(176, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(479, 30);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(166, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // chkAnonDownload
            // 
            this.chkAnonDownload.AutoSize = true;
            this.chkAnonDownload.Checked = true;
            this.chkAnonDownload.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAnonDownload.Location = new System.Drawing.Point(21, 33);
            this.chkAnonDownload.Name = "chkAnonDownload";
            this.chkAnonDownload.Size = new System.Drawing.Size(132, 17);
            this.chkAnonDownload.TabIndex = 0;
            this.chkAnonDownload.Text = "Anonymous Download";
            this.chkAnonDownload.UseVisualStyleBackColor = true;
            this.chkAnonDownload.CheckedChanged += new System.EventHandler(this.chkAnonDownload_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtWebApiCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 68);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Web API Code (Not necessary, but recommended)";
            // 
            // txtWebApiCode
            // 
            this.txtWebApiCode.Location = new System.Drawing.Point(53, 27);
            this.txtWebApiCode.Name = "txtWebApiCode";
            this.txtWebApiCode.Size = new System.Drawing.Size(592, 20);
            this.txtWebApiCode.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Code:";
            // 
            // btnAddServer
            // 
            this.btnAddServer.Location = new System.Drawing.Point(307, 220);
            this.btnAddServer.Name = "btnAddServer";
            this.btnAddServer.Size = new System.Drawing.Size(75, 23);
            this.btnAddServer.TabIndex = 7;
            this.btnAddServer.Text = "Add";
            this.btnAddServer.UseVisualStyleBackColor = true;
            this.btnAddServer.Click += new System.EventHandler(this.btnAddServer_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(194, 220);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(95, 23);
            this.btnTest.TabIndex = 8;
            this.btnTest.Text = "Test Settings";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnCancelAddServer
            // 
            this.btnCancelAddServer.Location = new System.Drawing.Point(401, 220);
            this.btnCancelAddServer.Name = "btnCancelAddServer";
            this.btnCancelAddServer.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAddServer.TabIndex = 9;
            this.btnCancelAddServer.Text = "Cancel";
            this.btnCancelAddServer.UseVisualStyleBackColor = true;
            this.btnCancelAddServer.Click += new System.EventHandler(this.btnCancelAddServer_Click);
            // 
            // frmAddServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 256);
            this.Controls.Add(this.btnCancelAddServer);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnAddServer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpCredentials);
            this.Controls.Add(this.grpPort);
            this.Controls.Add(this.grpHostname);
            this.Controls.Add(this.grpProtocol);
            this.Name = "frmAddServer";
            this.Text = "Add New Multiplayer Server";
            this.grpProtocol.ResumeLayout(false);
            this.grpProtocol.PerformLayout();
            this.grpHostname.ResumeLayout(false);
            this.grpHostname.PerformLayout();
            this.grpPort.ResumeLayout(false);
            this.grpPort.PerformLayout();
            this.grpCredentials.ResumeLayout(false);
            this.grpCredentials.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtHTTP;
        private System.Windows.Forms.RadioButton rbtHTTPS;
        private System.Windows.Forms.GroupBox grpProtocol;
        private System.Windows.Forms.GroupBox grpHostname;
        private System.Windows.Forms.TextBox txtHostName;
        private System.Windows.Forms.GroupBox grpPort;
        private System.Windows.Forms.TextBox txtPortNum;
        private System.Windows.Forms.GroupBox grpCredentials;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkAnonDownload;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtWebApiCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddServer;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnCancelAddServer;
    }
}