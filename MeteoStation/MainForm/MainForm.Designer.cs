﻿
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
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tslErrors = new System.Windows.Forms.ToolStripLabel();
            this.pMainControl = new System.Windows.Forms.Panel();
            this.pConfigControl = new System.Windows.Forms.Panel();
            this.tsViews.SuspendLayout();
            this.SuspendLayout();
            // 
            // spSensorData
            // 
            this.spSensorData.PortName = "COM2";
            // 
            // timerDequeue
            // 
            this.timerDequeue.Interval = 1000;
            this.timerDequeue.Tick += new System.EventHandler(this.timerDequeue_Tick);
            // 
            // tsViews
            // 
            this.tsViews.BackColor = System.Drawing.Color.Black;
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
            this.toolStripSeparator2,
            this.tslErrors});
            this.tsViews.Location = new System.Drawing.Point(0, 0);
            this.tsViews.Name = "tsViews";
            this.tsViews.Size = new System.Drawing.Size(800, 25);
            this.tsViews.TabIndex = 8;
            this.tsViews.Text = "toolStrip1";
            // 
            // tsbMeasures
            // 
            this.tsbMeasures.ForeColor = System.Drawing.Color.White;
            this.tsbMeasures.Image = ((System.Drawing.Image)(resources.GetObject("tsbMeasures.Image")));
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
            this.tsbAlarms.Image = ((System.Drawing.Image)(resources.GetObject("tsbAlarms.Image")));
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
            this.tsbGraphs.Image = ((System.Drawing.Image)(resources.GetObject("tsbGraphs.Image")));
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
            this.tsbAccounts.Image = ((System.Drawing.Image)(resources.GetObject("tsbAccounts.Image")));
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
            this.tsbConnection.Image = ((System.Drawing.Image)(resources.GetObject("tsbConnection.Image")));
            this.tsbConnection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConnection.Name = "tsbConnection";
            this.tsbConnection.Size = new System.Drawing.Size(89, 22);
            this.tsbConnection.Text = "Connection";
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
            this.tsbCalibration.Image = ((System.Drawing.Image)(resources.GetObject("tsbCalibration.Image")));
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
            this.tscbComPorts.ForeColor = System.Drawing.Color.Black;
            this.tscbComPorts.Name = "tscbComPorts";
            this.tscbComPorts.Size = new System.Drawing.Size(75, 25);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tslErrors
            // 
            this.tslErrors.ForeColor = System.Drawing.Color.White;
            this.tslErrors.Name = "tslErrors";
            this.tslErrors.Size = new System.Drawing.Size(47, 22);
            this.tslErrors.Text = "X errors";
            // 
            // pMainControl
            // 
            this.pMainControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pMainControl.BackColor = System.Drawing.Color.Black;
            this.pMainControl.Location = new System.Drawing.Point(12, 28);
            this.pMainControl.Name = "pMainControl";
            this.pMainControl.Padding = new System.Windows.Forms.Padding(1);
            this.pMainControl.Size = new System.Drawing.Size(528, 410);
            this.pMainControl.TabIndex = 9;
            // 
            // pConfigControl
            // 
            this.pConfigControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pConfigControl.BackColor = System.Drawing.Color.Black;
            this.pConfigControl.Location = new System.Drawing.Point(546, 159);
            this.pConfigControl.Name = "pConfigControl";
            this.pConfigControl.Padding = new System.Windows.Forms.Padding(1);
            this.pConfigControl.Size = new System.Drawing.Size(242, 279);
            this.pConfigControl.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pConfigControl);
            this.Controls.Add(this.pMainControl);
            this.Controls.Add(this.tsViews);
            this.Name = "MainForm";
            this.Text = "Meteo Station";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tsViews.ResumeLayout(false);
            this.tsViews.PerformLayout();
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel tslErrors;
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
        private System.Windows.Forms.Panel pMainControl;
        private System.Windows.Forms.Panel pConfigControl;
    }
}

