
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.spSensorData = new System.IO.Ports.SerialPort(this.components);
            this.gMeasures = new System.Windows.Forms.DataGridView();
            this.timerDequeue = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.tsViews = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tscbComPorts = new System.Windows.Forms.ToolStripComboBox();
            this.tslStatus = new System.Windows.Forms.ToolStripLabel();
            this.tsbOpenClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tslErrors = new System.Windows.Forms.ToolStripLabel();
            this.tsbCalibration = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbMeasures = new System.Windows.Forms.ToolStripButton();
            this.tsbAlarms = new System.Windows.Forms.ToolStripButton();
            this.tsbGraphs = new System.Windows.Forms.ToolStripButton();
            this.tsbAccounts = new System.Windows.Forms.ToolStripButton();
            this.tsbConnection = new System.Windows.Forms.ToolStripButton();
            this.pMainControl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gMeasures)).BeginInit();
            this.tsViews.SuspendLayout();
            this.pMainControl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spSensorData
            // 
            this.spSensorData.PortName = "COM2";
            // 
            // gMeasures
            // 
            this.gMeasures.AllowUserToAddRows = false;
            this.gMeasures.AllowUserToDeleteRows = false;
            this.gMeasures.AllowUserToResizeColumns = false;
            this.gMeasures.AllowUserToResizeRows = false;
            this.gMeasures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gMeasures.BackgroundColor = System.Drawing.Color.White;
            this.gMeasures.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gMeasures.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gMeasures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gMeasures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMeasures.GridColor = System.Drawing.Color.Black;
            this.gMeasures.Location = new System.Drawing.Point(5, 5);
            this.gMeasures.Name = "gMeasures";
            this.gMeasures.ReadOnly = true;
            this.gMeasures.RowHeadersVisible = false;
            this.gMeasures.Size = new System.Drawing.Size(476, 400);
            this.gMeasures.TabIndex = 3;
            // 
            // timerDequeue
            // 
            this.timerDequeue.Interval = 1000;
            this.timerDequeue.Tick += new System.EventHandler(this.timerDequeue_Tick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(5, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(274, 269);
            this.button2.TabIndex = 4;
            this.button2.Text = "clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ClearTable);
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
            // tsbCalibration
            // 
            this.tsbCalibration.ForeColor = System.Drawing.Color.White;
            this.tsbCalibration.Image = ((System.Drawing.Image)(resources.GetObject("tsbCalibration.Image")));
            this.tsbCalibration.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCalibration.Name = "tsbCalibration";
            this.tsbCalibration.Size = new System.Drawing.Size(85, 22);
            this.tsbCalibration.Text = "Calibration";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbMeasures
            // 
            this.tsbMeasures.ForeColor = System.Drawing.Color.White;
            this.tsbMeasures.Image = ((System.Drawing.Image)(resources.GetObject("tsbMeasures.Image")));
            this.tsbMeasures.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMeasures.Name = "tsbMeasures";
            this.tsbMeasures.Size = new System.Drawing.Size(77, 22);
            this.tsbMeasures.Text = "Measures";
            // 
            // tsbAlarms
            // 
            this.tsbAlarms.ForeColor = System.Drawing.Color.White;
            this.tsbAlarms.Image = ((System.Drawing.Image)(resources.GetObject("tsbAlarms.Image")));
            this.tsbAlarms.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAlarms.Name = "tsbAlarms";
            this.tsbAlarms.Size = new System.Drawing.Size(64, 22);
            this.tsbAlarms.Text = "Alarms";
            // 
            // tsbGraphs
            // 
            this.tsbGraphs.ForeColor = System.Drawing.Color.White;
            this.tsbGraphs.Image = ((System.Drawing.Image)(resources.GetObject("tsbGraphs.Image")));
            this.tsbGraphs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGraphs.Name = "tsbGraphs";
            this.tsbGraphs.Size = new System.Drawing.Size(64, 22);
            this.tsbGraphs.Text = "Graphs";
            // 
            // tsbAccounts
            // 
            this.tsbAccounts.ForeColor = System.Drawing.Color.White;
            this.tsbAccounts.Image = ((System.Drawing.Image)(resources.GetObject("tsbAccounts.Image")));
            this.tsbAccounts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAccounts.Name = "tsbAccounts";
            this.tsbAccounts.Size = new System.Drawing.Size(77, 22);
            this.tsbAccounts.Text = "Accounts";
            // 
            // tsbConnection
            // 
            this.tsbConnection.ForeColor = System.Drawing.Color.White;
            this.tsbConnection.Image = ((System.Drawing.Image)(resources.GetObject("tsbConnection.Image")));
            this.tsbConnection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConnection.Name = "tsbConnection";
            this.tsbConnection.Size = new System.Drawing.Size(89, 22);
            this.tsbConnection.Text = "Connection";
            // 
            // pMainControl
            // 
            this.pMainControl.BackColor = System.Drawing.Color.Black;
            this.pMainControl.Controls.Add(this.gMeasures);
            this.pMainControl.Location = new System.Drawing.Point(12, 28);
            this.pMainControl.Name = "pMainControl";
            this.pMainControl.Padding = new System.Windows.Forms.Padding(5);
            this.pMainControl.Size = new System.Drawing.Size(486, 410);
            this.pMainControl.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(504, 159);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(284, 279);
            this.panel1.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pMainControl);
            this.Controls.Add(this.tsViews);
            this.Name = "MainForm";
            this.Text = "Meteo Station";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gMeasures)).EndInit();
            this.tsViews.ResumeLayout(false);
            this.tsViews.PerformLayout();
            this.pMainControl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort spSensorData;
        private System.Windows.Forms.DataGridView gMeasures;
        private System.Windows.Forms.Timer timerDequeue;
        private System.Windows.Forms.Button button2;
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
        private System.Windows.Forms.Panel panel1;
    }
}

