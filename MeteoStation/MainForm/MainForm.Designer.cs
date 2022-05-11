
namespace MeteoStation
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.spSensorData = new System.IO.Ports.SerialPort(this.components);
            this.timerDequeue = new System.Windows.Forms.Timer(this.components);
            this.tsViews = new System.Windows.Forms.ToolStrip();
            this.tsbMeasures = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAlarms = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbGraphs = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAccounts = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbConnection = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCalibration = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tscbComPorts = new System.Windows.Forms.ToolStripComboBox();
            this.tslStatus = new System.Windows.Forms.ToolStripLabel();
            this.tsbOpenClose = new System.Windows.Forms.ToolStripButton();
            this.tsddbSave = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiExport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiImport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiReset = new System.Windows.Forms.ToolStripMenuItem();
            this.pMainCointainer = new System.Windows.Forms.Panel();
            this.pMainControl = new System.Windows.Forms.Panel();
            this.pHeader = new System.Windows.Forms.Panel();
            this.lTitle = new System.Windows.Forms.Label();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.pConfigControl = new System.Windows.Forms.Panel();
            this.lCredits = new System.Windows.Forms.Label();
            this.ssInfo = new System.Windows.Forms.StatusStrip();
            this.tsslTemps = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslErrors = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslPrompt = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.sfdSaveConfig = new System.Windows.Forms.SaveFileDialog();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.ofdLoadConfig = new System.Windows.Forms.OpenFileDialog();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsViews.SuspendLayout();
            this.pMainCointainer.SuspendLayout();
            this.pHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.ssInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // spSensorData
            // 
            this.spSensorData.PortName = "COM";
            // 
            // timerDequeue
            // 
            this.timerDequeue.Enabled = true;
            this.timerDequeue.Interval = 1000;
            this.timerDequeue.Tick += new System.EventHandler(this.timerDequeue_Tick);
            // 
            // tsViews
            // 
            this.tsViews.BackColor = System.Drawing.Color.Black;
            this.tsViews.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsViews.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbMeasures,
            this.toolStripSeparator7,
            this.tsbAlarms,
            this.toolStripSeparator6,
            this.tsbGraphs,
            this.toolStripSeparator5,
            this.tsbAccounts,
            this.toolStripSeparator4,
            this.tsbConnection,
            this.toolStripSeparator3,
            this.tsbCalibration,
            this.toolStripSeparator1,
            this.tscbComPorts,
            this.tslStatus,
            this.tsbOpenClose,
            this.tsddbSave});
            this.tsViews.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsViews.Location = new System.Drawing.Point(0, 0);
            this.tsViews.Name = "tsViews";
            this.tsViews.Size = new System.Drawing.Size(784, 25);
            this.tsViews.TabIndex = 8;
            this.tsViews.Text = "toolStrip1";
            // 
            // tsbMeasures
            // 
            this.tsbMeasures.ForeColor = System.Drawing.Color.White;
            this.tsbMeasures.Image = global::MeteoStation.Properties.Resources.Measures;
            this.tsbMeasures.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMeasures.Name = "tsbMeasures";
            this.tsbMeasures.Size = new System.Drawing.Size(77, 22);
            this.tsbMeasures.Text = "Measures";
            this.tsbMeasures.Click += new System.EventHandler(this.tsbMeasures_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbAlarms
            // 
            this.tsbAlarms.ForeColor = System.Drawing.Color.White;
            this.tsbAlarms.Image = global::MeteoStation.Properties.Resources.Alarms;
            this.tsbAlarms.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAlarms.Name = "tsbAlarms";
            this.tsbAlarms.Size = new System.Drawing.Size(64, 22);
            this.tsbAlarms.Text = "Alarms";
            this.tsbAlarms.Click += new System.EventHandler(this.tsbAlarms_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbGraphs
            // 
            this.tsbGraphs.ForeColor = System.Drawing.Color.White;
            this.tsbGraphs.Image = global::MeteoStation.Properties.Resources.Graphs;
            this.tsbGraphs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGraphs.Name = "tsbGraphs";
            this.tsbGraphs.Size = new System.Drawing.Size(64, 22);
            this.tsbGraphs.Text = "Graphs";
            this.tsbGraphs.Click += new System.EventHandler(this.tsbGraphs_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbAccounts
            // 
            this.tsbAccounts.ForeColor = System.Drawing.Color.White;
            this.tsbAccounts.Image = global::MeteoStation.Properties.Resources.Accounts;
            this.tsbAccounts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAccounts.Name = "tsbAccounts";
            this.tsbAccounts.Size = new System.Drawing.Size(77, 22);
            this.tsbAccounts.Text = "Accounts";
            this.tsbAccounts.Click += new System.EventHandler(this.tsbAccounts_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbConnection
            // 
            this.tsbConnection.ForeColor = System.Drawing.Color.White;
            this.tsbConnection.Image = global::MeteoStation.Properties.Resources.Connection;
            this.tsbConnection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConnection.Name = "tsbConnection";
            this.tsbConnection.Size = new System.Drawing.Size(89, 22);
            this.tsbConnection.Text = "&Connection";
            this.tsbConnection.Click += new System.EventHandler(this.tsbConnection_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbCalibration
            // 
            this.tsbCalibration.ForeColor = System.Drawing.Color.White;
            this.tsbCalibration.Image = global::MeteoStation.Properties.Resources.Calibration;
            this.tsbCalibration.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCalibration.Name = "tsbCalibration";
            this.tsbCalibration.Size = new System.Drawing.Size(85, 22);
            this.tsbCalibration.Text = "Calibration";
            this.tsbCalibration.Click += new System.EventHandler(this.tsbCalibration_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tscbComPorts
            // 
            this.tscbComPorts.BackColor = System.Drawing.Color.White;
            this.tscbComPorts.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.tscbComPorts.ForeColor = System.Drawing.Color.Black;
            this.tscbComPorts.Name = "tscbComPorts";
            this.tscbComPorts.Size = new System.Drawing.Size(75, 25);
            this.tscbComPorts.Text = "NO COM";
            this.tscbComPorts.DropDown += new System.EventHandler(this.cbComPorts_DropDown);
            this.tscbComPorts.DropDownClosed += new System.EventHandler(this.cbComPorts_DropDownClosed);
            // 
            // tslStatus
            // 
            this.tslStatus.ForeColor = System.Drawing.Color.White;
            this.tslStatus.Name = "tslStatus";
            this.tslStatus.Size = new System.Drawing.Size(84, 22);
            this.tslStatus.Text = "Status : Closed";
            // 
            // tsbOpenClose
            // 
            this.tsbOpenClose.BackColor = System.Drawing.Color.White;
            this.tsbOpenClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbOpenClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpenClose.Image")));
            this.tsbOpenClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpenClose.Name = "tsbOpenClose";
            this.tsbOpenClose.Size = new System.Drawing.Size(40, 22);
            this.tsbOpenClose.Text = "Open";
            this.tsbOpenClose.Click += new System.EventHandler(this.OpenClosePort);
            // 
            // tsddbSave
            // 
            this.tsddbSave.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsddbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsddbSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSave,
            this.tsmiExport,
            this.tsmiImport,
            this.toolStripSeparator2,
            this.tsmiReset});
            this.tsddbSave.Image = global::MeteoStation.Properties.Resources.Saving;
            this.tsddbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbSave.Name = "tsddbSave";
            this.tsddbSave.ShowDropDownArrow = false;
            this.tsddbSave.Size = new System.Drawing.Size(20, 22);
            this.tsddbSave.Text = "Configuration";
            // 
            // tsmiExport
            // 
            this.tsmiExport.Name = "tsmiExport";
            this.tsmiExport.Size = new System.Drawing.Size(187, 22);
            this.tsmiExport.Text = "Export Configuration";
            this.tsmiExport.Click += new System.EventHandler(this.tsmiExport_Click);
            // 
            // tsmiImport
            // 
            this.tsmiImport.Name = "tsmiImport";
            this.tsmiImport.Size = new System.Drawing.Size(187, 22);
            this.tsmiImport.Text = "Import Configuration";
            this.tsmiImport.Click += new System.EventHandler(this.tsmiImport_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(184, 6);
            // 
            // tsmiReset
            // 
            this.tsmiReset.Name = "tsmiReset";
            this.tsmiReset.Size = new System.Drawing.Size(187, 22);
            this.tsmiReset.Text = "Reset Configuration";
            this.tsmiReset.Click += new System.EventHandler(this.tsmiReset_Click);
            // 
            // pMainCointainer
            // 
            this.pMainCointainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pMainCointainer.BackColor = System.Drawing.Color.Black;
            this.pMainCointainer.Controls.Add(this.pMainControl);
            this.pMainCointainer.Controls.Add(this.pHeader);
            this.pMainCointainer.Location = new System.Drawing.Point(12, 28);
            this.pMainCointainer.Name = "pMainCointainer";
            this.pMainCointainer.Padding = new System.Windows.Forms.Padding(1);
            this.pMainCointainer.Size = new System.Drawing.Size(512, 424);
            this.pMainCointainer.TabIndex = 9;
            // 
            // pMainControl
            // 
            this.pMainControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMainControl.Location = new System.Drawing.Point(1, 28);
            this.pMainControl.Name = "pMainControl";
            this.pMainControl.Size = new System.Drawing.Size(510, 395);
            this.pMainControl.TabIndex = 10;
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.Color.White;
            this.pHeader.Controls.Add(this.lTitle);
            this.pHeader.Controls.Add(this.pbIcon);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(1, 1);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(510, 27);
            this.pHeader.TabIndex = 6;
            // 
            // lTitle
            // 
            this.lTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.Location = new System.Drawing.Point(24, 0);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(486, 27);
            this.lTitle.TabIndex = 5;
            this.lTitle.Text = "Measures";
            this.lTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbIcon
            // 
            this.pbIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbIcon.Image = global::MeteoStation.Properties.Resources.Measures;
            this.pbIcon.Location = new System.Drawing.Point(0, 0);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(24, 27);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbIcon.TabIndex = 4;
            this.pbIcon.TabStop = false;
            // 
            // pConfigControl
            // 
            this.pConfigControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pConfigControl.BackColor = System.Drawing.Color.Black;
            this.pConfigControl.Location = new System.Drawing.Point(530, 159);
            this.pConfigControl.Name = "pConfigControl";
            this.pConfigControl.Padding = new System.Windows.Forms.Padding(1);
            this.pConfigControl.Size = new System.Drawing.Size(242, 293);
            this.pConfigControl.TabIndex = 10;
            // 
            // lCredits
            // 
            this.lCredits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lCredits.Location = new System.Drawing.Point(530, 116);
            this.lCredits.Name = "lCredits";
            this.lCredits.Size = new System.Drawing.Size(242, 40);
            this.lCredits.TabIndex = 13;
            this.lCredits.Text = "Made by :\r\nAdam Jessy, Afkir Ridwane et Bah Abdoulaye";
            this.lCredits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ssInfo
            // 
            this.ssInfo.BackColor = System.Drawing.Color.Black;
            this.ssInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTemps,
            this.tsslErrors,
            this.tsslPrompt,
            this.tsslVersion});
            this.ssInfo.Location = new System.Drawing.Point(0, 457);
            this.ssInfo.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.ssInfo.Name = "ssInfo";
            this.ssInfo.Size = new System.Drawing.Size(784, 24);
            this.ssInfo.SizingGrip = false;
            this.ssInfo.TabIndex = 14;
            this.ssInfo.Text = "statusStrip1";
            // 
            // tsslTemps
            // 
            this.tsslTemps.ForeColor = System.Drawing.Color.White;
            this.tsslTemps.Name = "tsslTemps";
            this.tsslTemps.Size = new System.Drawing.Size(136, 19);
            this.tsslTemps.Text = "Changing locales is hard";
            // 
            // tsslErrors
            // 
            this.tsslErrors.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.tsslErrors.ForeColor = System.Drawing.Color.White;
            this.tsslErrors.Name = "tsslErrors";
            this.tsslErrors.Size = new System.Drawing.Size(51, 19);
            this.tsslErrors.Text = "X errors";
            // 
            // tsslPrompt
            // 
            this.tsslPrompt.ForeColor = System.Drawing.Color.White;
            this.tsslPrompt.Name = "tsslPrompt";
            this.tsslPrompt.Size = new System.Drawing.Size(519, 19);
            this.tsslPrompt.Spring = true;
            this.tsslPrompt.Text = "This is information";
            // 
            // tsslVersion
            // 
            this.tsslVersion.ForeColor = System.Drawing.Color.White;
            this.tsslVersion.Name = "tsslVersion";
            this.tsslVersion.Size = new System.Drawing.Size(63, 19);
            this.tsslVersion.Text = "Version 2.0";
            this.tsslVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sfdSaveConfig
            // 
            this.sfdSaveConfig.DefaultExt = "csv";
            this.sfdSaveConfig.Filter = "Fichier CSV (*.csv)|*.csv";
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbLogo.Image = global::MeteoStation.Properties.Resources.HELB_Logo;
            this.pbLogo.Location = new System.Drawing.Point(530, 28);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(242, 85);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 11;
            this.pbLogo.TabStop = false;
            // 
            // ofdLoadConfig
            // 
            this.ofdLoadConfig.DefaultExt = "csv";
            this.ofdLoadConfig.FileName = "Config.csv";
            this.ofdLoadConfig.Filter = "Fichier CSV (*.csv)|*.csv";
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(187, 22);
            this.tsmiSave.Text = "Save Configuration";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(784, 481);
            this.Controls.Add(this.ssInfo);
            this.Controls.Add(this.lCredits);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pConfigControl);
            this.Controls.Add(this.pMainCointainer);
            this.Controls.Add(this.tsViews);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 520);
            this.Name = "MainForm";
            this.Text = "Meteo Station";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tsViews.ResumeLayout(false);
            this.tsViews.PerformLayout();
            this.pMainCointainer.ResumeLayout(false);
            this.pHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ssInfo.ResumeLayout(false);
            this.ssInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort spSensorData;
        private System.Windows.Forms.Timer timerDequeue;
        private System.Windows.Forms.ToolStrip tsViews;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox tscbComPorts;
        private System.Windows.Forms.ToolStripLabel tslStatus;
        private System.Windows.Forms.ToolStripButton tsbOpenClose;
        private System.Windows.Forms.ToolStripButton tsbMeasures;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tsbAlarms;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbGraphs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbAccounts;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbConnection;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbCalibration;
        private System.Windows.Forms.Panel pMainCointainer;
        private System.Windows.Forms.Panel pConfigControl;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lCredits;
        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Panel pMainControl;
        private System.Windows.Forms.StatusStrip ssInfo;
        private System.Windows.Forms.ToolStripStatusLabel tsslTemps;
        private System.Windows.Forms.ToolStripStatusLabel tsslVersion;
        private System.Windows.Forms.ToolStripStatusLabel tsslPrompt;
        private System.Windows.Forms.ToolStripStatusLabel tsslErrors;
        private System.Windows.Forms.ToolStripDropDownButton tsddbSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiExport;
        private System.Windows.Forms.SaveFileDialog sfdSaveConfig;
        private System.Windows.Forms.ToolStripMenuItem tsmiImport;
        private System.Windows.Forms.OpenFileDialog ofdLoadConfig;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiReset;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
    }
}

