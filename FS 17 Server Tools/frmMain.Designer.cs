namespace FS_17_Server_Tools
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.cmbCurrentServer = new System.Windows.Forms.ComboBox();
            this.ServersDataSet = new System.Data.DataSet();
            this.lblCurrentServer = new System.Windows.Forms.Label();
            this.btnEditServer = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPageMap = new System.Windows.Forms.TabPage();
            this.tabPagePlayers = new System.Windows.Forms.TabPage();
            this.tabPageFields = new System.Windows.Forms.TabPage();
            this.tabPageVehicles = new System.Windows.Forms.TabPage();
            this.tabPageSales = new System.Windows.Forms.TabPage();
            this.tabPageWeather = new System.Windows.Forms.TabPage();
            this.tabPageMods = new System.Windows.Forms.TabPage();
            this.tabPageOverview = new System.Windows.Forms.TabPage();
            this.lblServerName = new System.Windows.Forms.Label();
            this.lblWebUrl = new System.Windows.Forms.Label();
            this.lblOnline = new System.Windows.Forms.Label();
            this.lblPingTime = new System.Windows.Forms.Label();
            this.lblWebApiAccess = new System.Windows.Forms.Label();
            this.btnOverviewRefresh = new System.Windows.Forms.Button();
            this.lblOverviewPlayers = new System.Windows.Forms.Label();
            this.lblOverviewFields = new System.Windows.Forms.Label();
            this.lblOverviewMods = new System.Windows.Forms.Label();
            this.lblOverviewVehicles = new System.Windows.Forms.Label();
            this.lblOverviewLoginType = new System.Windows.Forms.Label();
            this.lblOverviewCurrentSale = new System.Windows.Forms.Label();
            this.lblOverviewWeather = new System.Windows.Forms.Label();
            this.btnNewServer = new System.Windows.Forms.Button();
            this.btnDelServer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ServersDataSet)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tabPageOverview.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCurrentServer
            // 
            this.cmbCurrentServer.DataSource = this.ServersDataSet;
            this.cmbCurrentServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCurrentServer.FormattingEnabled = true;
            this.cmbCurrentServer.Location = new System.Drawing.Point(134, 14);
            this.cmbCurrentServer.Name = "cmbCurrentServer";
            this.cmbCurrentServer.Size = new System.Drawing.Size(312, 28);
            this.cmbCurrentServer.TabIndex = 0;
            this.cmbCurrentServer.SelectedIndexChanged += new System.EventHandler(this.cmbCurrentServer_SelectedIndexChanged);
            // 
            // ServersDataSet
            // 
            this.ServersDataSet.DataSetName = "ServersDataSet";
            // 
            // lblCurrentServer
            // 
            this.lblCurrentServer.AutoSize = true;
            this.lblCurrentServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentServer.Location = new System.Drawing.Point(12, 17);
            this.lblCurrentServer.Name = "lblCurrentServer";
            this.lblCurrentServer.Size = new System.Drawing.Size(116, 20);
            this.lblCurrentServer.TabIndex = 1;
            this.lblCurrentServer.Text = "Current Server:";
            // 
            // btnEditServer
            // 
            this.btnEditServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditServer.Image = ((System.Drawing.Image)(resources.GetObject("btnEditServer.Image")));
            this.btnEditServer.Location = new System.Drawing.Point(452, 9);
            this.btnEditServer.Name = "btnEditServer";
            this.btnEditServer.Size = new System.Drawing.Size(42, 39);
            this.btnEditServer.TabIndex = 2;
            this.btnEditServer.UseVisualStyleBackColor = true;
            this.btnEditServer.Click += new System.EventHandler(this.btnEditServer_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPageOverview);
            this.tabMain.Controls.Add(this.tabPageMap);
            this.tabMain.Controls.Add(this.tabPagePlayers);
            this.tabMain.Controls.Add(this.tabPageFields);
            this.tabMain.Controls.Add(this.tabPageVehicles);
            this.tabMain.Controls.Add(this.tabPageSales);
            this.tabMain.Controls.Add(this.tabPageWeather);
            this.tabMain.Controls.Add(this.tabPageMods);
            this.tabMain.Location = new System.Drawing.Point(16, 54);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(579, 515);
            this.tabMain.TabIndex = 3;
            // 
            // tabPageMap
            // 
            this.tabPageMap.Location = new System.Drawing.Point(4, 22);
            this.tabPageMap.Name = "tabPageMap";
            this.tabPageMap.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMap.Size = new System.Drawing.Size(571, 489);
            this.tabPageMap.TabIndex = 0;
            this.tabPageMap.Text = "Map";
            this.tabPageMap.UseVisualStyleBackColor = true;
            // 
            // tabPagePlayers
            // 
            this.tabPagePlayers.Location = new System.Drawing.Point(4, 22);
            this.tabPagePlayers.Name = "tabPagePlayers";
            this.tabPagePlayers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePlayers.Size = new System.Drawing.Size(571, 489);
            this.tabPagePlayers.TabIndex = 1;
            this.tabPagePlayers.Text = "Players";
            this.tabPagePlayers.UseVisualStyleBackColor = true;
            // 
            // tabPageFields
            // 
            this.tabPageFields.Location = new System.Drawing.Point(4, 22);
            this.tabPageFields.Name = "tabPageFields";
            this.tabPageFields.Size = new System.Drawing.Size(571, 489);
            this.tabPageFields.TabIndex = 2;
            this.tabPageFields.Text = "Fields";
            this.tabPageFields.UseVisualStyleBackColor = true;
            // 
            // tabPageVehicles
            // 
            this.tabPageVehicles.Location = new System.Drawing.Point(4, 22);
            this.tabPageVehicles.Name = "tabPageVehicles";
            this.tabPageVehicles.Size = new System.Drawing.Size(571, 489);
            this.tabPageVehicles.TabIndex = 3;
            this.tabPageVehicles.Text = "Vehicles";
            this.tabPageVehicles.UseVisualStyleBackColor = true;
            // 
            // tabPageSales
            // 
            this.tabPageSales.Location = new System.Drawing.Point(4, 22);
            this.tabPageSales.Name = "tabPageSales";
            this.tabPageSales.Size = new System.Drawing.Size(571, 489);
            this.tabPageSales.TabIndex = 4;
            this.tabPageSales.Text = "Sales";
            this.tabPageSales.UseVisualStyleBackColor = true;
            // 
            // tabPageWeather
            // 
            this.tabPageWeather.Location = new System.Drawing.Point(4, 22);
            this.tabPageWeather.Name = "tabPageWeather";
            this.tabPageWeather.Size = new System.Drawing.Size(571, 489);
            this.tabPageWeather.TabIndex = 5;
            this.tabPageWeather.Text = "Weather";
            this.tabPageWeather.UseVisualStyleBackColor = true;
            // 
            // tabPageMods
            // 
            this.tabPageMods.Location = new System.Drawing.Point(4, 22);
            this.tabPageMods.Name = "tabPageMods";
            this.tabPageMods.Size = new System.Drawing.Size(571, 489);
            this.tabPageMods.TabIndex = 6;
            this.tabPageMods.Text = "Mods";
            this.tabPageMods.UseVisualStyleBackColor = true;
            // 
            // tabPageOverview
            // 
            this.tabPageOverview.Controls.Add(this.lblOverviewWeather);
            this.tabPageOverview.Controls.Add(this.lblOverviewCurrentSale);
            this.tabPageOverview.Controls.Add(this.lblOverviewLoginType);
            this.tabPageOverview.Controls.Add(this.lblOverviewVehicles);
            this.tabPageOverview.Controls.Add(this.lblOverviewMods);
            this.tabPageOverview.Controls.Add(this.lblOverviewFields);
            this.tabPageOverview.Controls.Add(this.lblOverviewPlayers);
            this.tabPageOverview.Controls.Add(this.btnOverviewRefresh);
            this.tabPageOverview.Controls.Add(this.lblWebApiAccess);
            this.tabPageOverview.Controls.Add(this.lblPingTime);
            this.tabPageOverview.Controls.Add(this.lblOnline);
            this.tabPageOverview.Controls.Add(this.lblWebUrl);
            this.tabPageOverview.Controls.Add(this.lblServerName);
            this.tabPageOverview.Location = new System.Drawing.Point(4, 22);
            this.tabPageOverview.Name = "tabPageOverview";
            this.tabPageOverview.Size = new System.Drawing.Size(571, 489);
            this.tabPageOverview.TabIndex = 7;
            this.tabPageOverview.Text = "Overview";
            this.tabPageOverview.UseVisualStyleBackColor = true;
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerName.Location = new System.Drawing.Point(39, 23);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(103, 16);
            this.lblServerName.TabIndex = 0;
            this.lblServerName.Text = "Server Name:";
            // 
            // lblWebUrl
            // 
            this.lblWebUrl.AutoSize = true;
            this.lblWebUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWebUrl.Location = new System.Drawing.Point(15, 56);
            this.lblWebUrl.Name = "lblWebUrl";
            this.lblWebUrl.Size = new System.Drawing.Size(128, 16);
            this.lblWebUrl.TabIndex = 1;
            this.lblWebUrl.Text = "Server Web URL:";
            // 
            // lblOnline
            // 
            this.lblOnline.AutoSize = true;
            this.lblOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnline.Location = new System.Drawing.Point(395, 23);
            this.lblOnline.Name = "lblOnline";
            this.lblOnline.Size = new System.Drawing.Size(56, 16);
            this.lblOnline.TabIndex = 2;
            this.lblOnline.Text = "Online:";
            // 
            // lblPingTime
            // 
            this.lblPingTime.AutoSize = true;
            this.lblPingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPingTime.Location = new System.Drawing.Point(369, 56);
            this.lblPingTime.Name = "lblPingTime";
            this.lblPingTime.Size = new System.Drawing.Size(82, 16);
            this.lblPingTime.TabIndex = 3;
            this.lblPingTime.Text = "Ping Time:";
            // 
            // lblWebApiAccess
            // 
            this.lblWebApiAccess.AutoSize = true;
            this.lblWebApiAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWebApiAccess.Location = new System.Drawing.Point(16, 89);
            this.lblWebApiAccess.Name = "lblWebApiAccess";
            this.lblWebApiAccess.Size = new System.Drawing.Size(127, 16);
            this.lblWebApiAccess.TabIndex = 4;
            this.lblWebApiAccess.Text = "Web API Access:";
            // 
            // btnOverviewRefresh
            // 
            this.btnOverviewRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOverviewRefresh.Location = new System.Drawing.Point(237, 451);
            this.btnOverviewRefresh.Name = "btnOverviewRefresh";
            this.btnOverviewRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnOverviewRefresh.TabIndex = 5;
            this.btnOverviewRefresh.Text = "Refresh";
            this.btnOverviewRefresh.UseVisualStyleBackColor = true;
            // 
            // lblOverviewPlayers
            // 
            this.lblOverviewPlayers.AutoSize = true;
            this.lblOverviewPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverviewPlayers.Location = new System.Drawing.Point(29, 122);
            this.lblOverviewPlayers.Name = "lblOverviewPlayers";
            this.lblOverviewPlayers.Size = new System.Drawing.Size(113, 16);
            this.lblOverviewPlayers.TabIndex = 6;
            this.lblOverviewPlayers.Text = "Players Online:";
            // 
            // lblOverviewFields
            // 
            this.lblOverviewFields.AutoSize = true;
            this.lblOverviewFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverviewFields.Location = new System.Drawing.Point(36, 153);
            this.lblOverviewFields.Name = "lblOverviewFields";
            this.lblOverviewFields.Size = new System.Drawing.Size(106, 16);
            this.lblOverviewFields.TabIndex = 7;
            this.lblOverviewFields.Text = "Owned Fields:";
            // 
            // lblOverviewMods
            // 
            this.lblOverviewMods.AutoSize = true;
            this.lblOverviewMods.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverviewMods.Location = new System.Drawing.Point(45, 185);
            this.lblOverviewMods.Name = "lblOverviewMods";
            this.lblOverviewMods.Size = new System.Drawing.Size(97, 16);
            this.lblOverviewMods.TabIndex = 8;
            this.lblOverviewMods.Text = "Active Mods:";
            // 
            // lblOverviewVehicles
            // 
            this.lblOverviewVehicles.AutoSize = true;
            this.lblOverviewVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverviewVehicles.Location = new System.Drawing.Point(70, 220);
            this.lblOverviewVehicles.Name = "lblOverviewVehicles";
            this.lblOverviewVehicles.Size = new System.Drawing.Size(72, 16);
            this.lblOverviewVehicles.TabIndex = 9;
            this.lblOverviewVehicles.Text = "Vehicles:";
            // 
            // lblOverviewLoginType
            // 
            this.lblOverviewLoginType.AutoSize = true;
            this.lblOverviewLoginType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverviewLoginType.Location = new System.Drawing.Point(361, 89);
            this.lblOverviewLoginType.Name = "lblOverviewLoginType";
            this.lblOverviewLoginType.Size = new System.Drawing.Size(90, 16);
            this.lblOverviewLoginType.TabIndex = 10;
            this.lblOverviewLoginType.Text = "Login Type:";
            // 
            // lblOverviewCurrentSale
            // 
            this.lblOverviewCurrentSale.AutoSize = true;
            this.lblOverviewCurrentSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverviewCurrentSale.Location = new System.Drawing.Point(45, 251);
            this.lblOverviewCurrentSale.Name = "lblOverviewCurrentSale";
            this.lblOverviewCurrentSale.Size = new System.Drawing.Size(97, 16);
            this.lblOverviewCurrentSale.TabIndex = 11;
            this.lblOverviewCurrentSale.Text = "Current Sale:";
            // 
            // lblOverviewWeather
            // 
            this.lblOverviewWeather.AutoSize = true;
            this.lblOverviewWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverviewWeather.Location = new System.Drawing.Point(19, 285);
            this.lblOverviewWeather.Name = "lblOverviewWeather";
            this.lblOverviewWeather.Size = new System.Drawing.Size(123, 16);
            this.lblOverviewWeather.TabIndex = 12;
            this.lblOverviewWeather.Text = "Current Weather:";
            // 
            // btnNewServer
            // 
            this.btnNewServer.Image = ((System.Drawing.Image)(resources.GetObject("btnNewServer.Image")));
            this.btnNewServer.Location = new System.Drawing.Point(500, 9);
            this.btnNewServer.Name = "btnNewServer";
            this.btnNewServer.Size = new System.Drawing.Size(44, 39);
            this.btnNewServer.TabIndex = 4;
            this.btnNewServer.UseVisualStyleBackColor = true;
            this.btnNewServer.Click += new System.EventHandler(this.btnNewServer_Click);
            // 
            // btnDelServer
            // 
            this.btnDelServer.Image = ((System.Drawing.Image)(resources.GetObject("btnDelServer.Image")));
            this.btnDelServer.Location = new System.Drawing.Point(550, 9);
            this.btnDelServer.Name = "btnDelServer";
            this.btnDelServer.Size = new System.Drawing.Size(41, 39);
            this.btnDelServer.TabIndex = 5;
            this.btnDelServer.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 585);
            this.Controls.Add(this.btnDelServer);
            this.Controls.Add(this.btnNewServer);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.btnEditServer);
            this.Controls.Add(this.lblCurrentServer);
            this.Controls.Add(this.cmbCurrentServer);
            this.Name = "frmMain";
            this.Text = "FS 17 Server Tools";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ServersDataSet)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tabPageOverview.ResumeLayout(false);
            this.tabPageOverview.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCurrentServer;
        private System.Windows.Forms.Label lblCurrentServer;
        private System.Windows.Forms.Button btnEditServer;
        private System.Data.DataSet ServersDataSet;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPageOverview;
        private System.Windows.Forms.TabPage tabPageMap;
        private System.Windows.Forms.TabPage tabPagePlayers;
        private System.Windows.Forms.TabPage tabPageFields;
        private System.Windows.Forms.TabPage tabPageVehicles;
        private System.Windows.Forms.TabPage tabPageSales;
        private System.Windows.Forms.TabPage tabPageWeather;
        private System.Windows.Forms.TabPage tabPageMods;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.Label lblWebUrl;
        private System.Windows.Forms.Label lblOnline;
        private System.Windows.Forms.Label lblPingTime;
        private System.Windows.Forms.Label lblWebApiAccess;
        private System.Windows.Forms.Button btnOverviewRefresh;
        private System.Windows.Forms.Label lblOverviewPlayers;
        private System.Windows.Forms.Label lblOverviewFields;
        private System.Windows.Forms.Label lblOverviewVehicles;
        private System.Windows.Forms.Label lblOverviewMods;
        private System.Windows.Forms.Label lblOverviewLoginType;
        private System.Windows.Forms.Label lblOverviewCurrentSale;
        private System.Windows.Forms.Label lblOverviewWeather;
        private System.Windows.Forms.Button btnNewServer;
        private System.Windows.Forms.Button btnDelServer;
    }
}

