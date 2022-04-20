
namespace MeteoStation.Controls
{
    partial class AlarmConfigControl
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lTitre = new System.Windows.Forms.Label();
            this.bApply = new System.Windows.Forms.Button();
            this.tlpRows = new System.Windows.Forms.TableLayoutPanel();
            this.pExpiration = new System.Windows.Forms.Panel();
            this.lMaxPeriod = new System.Windows.Forms.Label();
            this.nudMaxPeriod = new System.Windows.Forms.NumericUpDown();
            this.pIdSelect = new System.Windows.Forms.Panel();
            this.cbIdSelect = new System.Windows.Forms.ComboBox();
            this.lId = new System.Windows.Forms.Label();
            this.pCritMin = new System.Windows.Forms.Panel();
            this.lCritMin = new System.Windows.Forms.Label();
            this.nudCritMin = new System.Windows.Forms.NumericUpDown();
            this.pWarnMin = new System.Windows.Forms.Panel();
            this.lWarnMin = new System.Windows.Forms.Label();
            this.nudWarnMin = new System.Windows.Forms.NumericUpDown();
            this.pStatus = new System.Windows.Forms.Panel();
            this.lConfigStatus = new System.Windows.Forms.Label();
            this.pWarnMax = new System.Windows.Forms.Panel();
            this.lWarnMax = new System.Windows.Forms.Label();
            this.nudWarnMax = new System.Windows.Forms.NumericUpDown();
            this.pCritMax = new System.Windows.Forms.Panel();
            this.lCritMax = new System.Windows.Forms.Label();
            this.nudCritMax = new System.Windows.Forms.NumericUpDown();
            this.tlpRows.SuspendLayout();
            this.pExpiration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPeriod)).BeginInit();
            this.pIdSelect.SuspendLayout();
            this.pCritMin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCritMin)).BeginInit();
            this.pWarnMin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWarnMin)).BeginInit();
            this.pStatus.SuspendLayout();
            this.pWarnMax.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWarnMax)).BeginInit();
            this.pCritMax.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCritMax)).BeginInit();
            this.SuspendLayout();
            // 
            // lTitre
            // 
            this.lTitre.BackColor = System.Drawing.Color.White;
            this.lTitre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lTitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitre.Location = new System.Drawing.Point(0, 0);
            this.lTitre.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lTitre.Name = "lTitre";
            this.lTitre.Size = new System.Drawing.Size(264, 47);
            this.lTitre.TabIndex = 2;
            this.lTitre.Text = "Alarms";
            this.lTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bApply
            // 
            this.bApply.BackColor = System.Drawing.Color.White;
            this.bApply.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bApply.Location = new System.Drawing.Point(0, 350);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(264, 44);
            this.bApply.TabIndex = 1;
            this.bApply.Text = "Apply";
            this.bApply.UseVisualStyleBackColor = false;
            this.bApply.Click += new System.EventHandler(this.bApply_Click);
            // 
            // tlpRows
            // 
            this.tlpRows.ColumnCount = 1;
            this.tlpRows.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRows.Controls.Add(this.pExpiration, 0, 6);
            this.tlpRows.Controls.Add(this.pIdSelect, 0, 0);
            this.tlpRows.Controls.Add(this.pCritMin, 0, 5);
            this.tlpRows.Controls.Add(this.pWarnMin, 0, 4);
            this.tlpRows.Controls.Add(this.pStatus, 0, 3);
            this.tlpRows.Controls.Add(this.pWarnMax, 0, 2);
            this.tlpRows.Controls.Add(this.pCritMax, 0, 1);
            this.tlpRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRows.Location = new System.Drawing.Point(0, 47);
            this.tlpRows.Name = "tlpRows";
            this.tlpRows.RowCount = 7;
            this.tlpRows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpRows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpRows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpRows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpRows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpRows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpRows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpRows.Size = new System.Drawing.Size(264, 303);
            this.tlpRows.TabIndex = 0;
            // 
            // pExpiration
            // 
            this.pExpiration.BackColor = System.Drawing.Color.Brown;
            this.pExpiration.Controls.Add(this.lMaxPeriod);
            this.pExpiration.Controls.Add(this.nudMaxPeriod);
            this.pExpiration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pExpiration.Location = new System.Drawing.Point(0, 258);
            this.pExpiration.Margin = new System.Windows.Forms.Padding(0);
            this.pExpiration.Name = "pExpiration";
            this.pExpiration.Size = new System.Drawing.Size(264, 45);
            this.pExpiration.TabIndex = 6;
            // 
            // lMaxPeriod
            // 
            this.lMaxPeriod.Dock = System.Windows.Forms.DockStyle.Left;
            this.lMaxPeriod.ForeColor = System.Drawing.Color.White;
            this.lMaxPeriod.Location = new System.Drawing.Point(0, 0);
            this.lMaxPeriod.Name = "lMaxPeriod";
            this.lMaxPeriod.Size = new System.Drawing.Size(80, 45);
            this.lMaxPeriod.TabIndex = 1;
            this.lMaxPeriod.Text = "Max Period :";
            this.lMaxPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudMaxPeriod
            // 
            this.nudMaxPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMaxPeriod.Location = new System.Drawing.Point(86, 13);
            this.nudMaxPeriod.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.nudMaxPeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxPeriod.Name = "nudMaxPeriod";
            this.nudMaxPeriod.Size = new System.Drawing.Size(175, 20);
            this.nudMaxPeriod.TabIndex = 0;
            this.nudMaxPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMaxPeriod.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pIdSelect
            // 
            this.pIdSelect.Controls.Add(this.cbIdSelect);
            this.pIdSelect.Controls.Add(this.lId);
            this.pIdSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pIdSelect.Location = new System.Drawing.Point(0, 0);
            this.pIdSelect.Margin = new System.Windows.Forms.Padding(0);
            this.pIdSelect.Name = "pIdSelect";
            this.pIdSelect.Size = new System.Drawing.Size(264, 43);
            this.pIdSelect.TabIndex = 0;
            // 
            // cbIdSelect
            // 
            this.cbIdSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbIdSelect.FormattingEnabled = true;
            this.cbIdSelect.Location = new System.Drawing.Point(86, 11);
            this.cbIdSelect.Name = "cbIdSelect";
            this.cbIdSelect.Size = new System.Drawing.Size(175, 21);
            this.cbIdSelect.TabIndex = 0;
            this.cbIdSelect.DropDown += new System.EventHandler(this.cbIdSelect_DropDown);
            this.cbIdSelect.DropDownClosed += new System.EventHandler(this.cbIdSelect_DropDownClosed);
            // 
            // lId
            // 
            this.lId.Dock = System.Windows.Forms.DockStyle.Left;
            this.lId.Location = new System.Drawing.Point(0, 0);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(80, 43);
            this.lId.TabIndex = 1;
            this.lId.Text = "ID :";
            this.lId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pCritMin
            // 
            this.pCritMin.BackColor = System.Drawing.Color.LightCoral;
            this.pCritMin.Controls.Add(this.lCritMin);
            this.pCritMin.Controls.Add(this.nudCritMin);
            this.pCritMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCritMin.Location = new System.Drawing.Point(0, 215);
            this.pCritMin.Margin = new System.Windows.Forms.Padding(0);
            this.pCritMin.Name = "pCritMin";
            this.pCritMin.Size = new System.Drawing.Size(264, 43);
            this.pCritMin.TabIndex = 5;
            // 
            // lCritMin
            // 
            this.lCritMin.Dock = System.Windows.Forms.DockStyle.Left;
            this.lCritMin.Location = new System.Drawing.Point(0, 0);
            this.lCritMin.Name = "lCritMin";
            this.lCritMin.Size = new System.Drawing.Size(80, 43);
            this.lCritMin.TabIndex = 1;
            this.lCritMin.Text = "Critical Min :";
            this.lCritMin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudCritMin
            // 
            this.nudCritMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudCritMin.Location = new System.Drawing.Point(86, 12);
            this.nudCritMin.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.nudCritMin.Minimum = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            this.nudCritMin.Name = "nudCritMin";
            this.nudCritMin.Size = new System.Drawing.Size(175, 20);
            this.nudCritMin.TabIndex = 0;
            this.nudCritMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pWarnMin
            // 
            this.pWarnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(230)))), ((int)(((byte)(133)))));
            this.pWarnMin.Controls.Add(this.lWarnMin);
            this.pWarnMin.Controls.Add(this.nudWarnMin);
            this.pWarnMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pWarnMin.Location = new System.Drawing.Point(0, 172);
            this.pWarnMin.Margin = new System.Windows.Forms.Padding(0);
            this.pWarnMin.Name = "pWarnMin";
            this.pWarnMin.Size = new System.Drawing.Size(264, 43);
            this.pWarnMin.TabIndex = 4;
            // 
            // lWarnMin
            // 
            this.lWarnMin.Dock = System.Windows.Forms.DockStyle.Left;
            this.lWarnMin.Location = new System.Drawing.Point(0, 0);
            this.lWarnMin.Name = "lWarnMin";
            this.lWarnMin.Size = new System.Drawing.Size(80, 43);
            this.lWarnMin.TabIndex = 1;
            this.lWarnMin.Text = "Warning Min :";
            this.lWarnMin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudWarnMin
            // 
            this.nudWarnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudWarnMin.Location = new System.Drawing.Point(86, 11);
            this.nudWarnMin.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.nudWarnMin.Minimum = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            this.nudWarnMin.Name = "nudWarnMin";
            this.nudWarnMin.Size = new System.Drawing.Size(175, 20);
            this.nudWarnMin.TabIndex = 0;
            this.nudWarnMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pStatus
            // 
            this.pStatus.BackColor = System.Drawing.Color.PaleGreen;
            this.pStatus.Controls.Add(this.lConfigStatus);
            this.pStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pStatus.Location = new System.Drawing.Point(0, 129);
            this.pStatus.Margin = new System.Windows.Forms.Padding(0);
            this.pStatus.Name = "pStatus";
            this.pStatus.Size = new System.Drawing.Size(264, 43);
            this.pStatus.TabIndex = 3;
            // 
            // lConfigStatus
            // 
            this.lConfigStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lConfigStatus.Location = new System.Drawing.Point(0, 0);
            this.lConfigStatus.Name = "lConfigStatus";
            this.lConfigStatus.Size = new System.Drawing.Size(264, 43);
            this.lConfigStatus.TabIndex = 0;
            this.lConfigStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pWarnMax
            // 
            this.pWarnMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(230)))), ((int)(((byte)(133)))));
            this.pWarnMax.Controls.Add(this.lWarnMax);
            this.pWarnMax.Controls.Add(this.nudWarnMax);
            this.pWarnMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pWarnMax.Location = new System.Drawing.Point(0, 86);
            this.pWarnMax.Margin = new System.Windows.Forms.Padding(0);
            this.pWarnMax.Name = "pWarnMax";
            this.pWarnMax.Size = new System.Drawing.Size(264, 43);
            this.pWarnMax.TabIndex = 2;
            // 
            // lWarnMax
            // 
            this.lWarnMax.Dock = System.Windows.Forms.DockStyle.Left;
            this.lWarnMax.Location = new System.Drawing.Point(0, 0);
            this.lWarnMax.Name = "lWarnMax";
            this.lWarnMax.Size = new System.Drawing.Size(80, 43);
            this.lWarnMax.TabIndex = 1;
            this.lWarnMax.Text = "Warning Max :";
            this.lWarnMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudWarnMax
            // 
            this.nudWarnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudWarnMax.Location = new System.Drawing.Point(86, 11);
            this.nudWarnMax.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.nudWarnMax.Minimum = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            this.nudWarnMax.Name = "nudWarnMax";
            this.nudWarnMax.Size = new System.Drawing.Size(175, 20);
            this.nudWarnMax.TabIndex = 0;
            this.nudWarnMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pCritMax
            // 
            this.pCritMax.BackColor = System.Drawing.Color.LightCoral;
            this.pCritMax.Controls.Add(this.lCritMax);
            this.pCritMax.Controls.Add(this.nudCritMax);
            this.pCritMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCritMax.Location = new System.Drawing.Point(0, 43);
            this.pCritMax.Margin = new System.Windows.Forms.Padding(0);
            this.pCritMax.Name = "pCritMax";
            this.pCritMax.Size = new System.Drawing.Size(264, 43);
            this.pCritMax.TabIndex = 1;
            // 
            // lCritMax
            // 
            this.lCritMax.Dock = System.Windows.Forms.DockStyle.Left;
            this.lCritMax.Location = new System.Drawing.Point(0, 0);
            this.lCritMax.Name = "lCritMax";
            this.lCritMax.Size = new System.Drawing.Size(80, 43);
            this.lCritMax.TabIndex = 1;
            this.lCritMax.Text = "Critical Max :";
            this.lCritMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudCritMax
            // 
            this.nudCritMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudCritMax.Location = new System.Drawing.Point(86, 11);
            this.nudCritMax.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.nudCritMax.Minimum = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            this.nudCritMax.Name = "nudCritMax";
            this.nudCritMax.Size = new System.Drawing.Size(175, 20);
            this.nudCritMax.TabIndex = 0;
            this.nudCritMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AlarmConfigControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.tlpRows);
            this.Controls.Add(this.bApply);
            this.Controls.Add(this.lTitre);
            this.Name = "AlarmConfigControl";
            this.Size = new System.Drawing.Size(264, 394);
            this.tlpRows.ResumeLayout(false);
            this.pExpiration.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPeriod)).EndInit();
            this.pIdSelect.ResumeLayout(false);
            this.pCritMin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCritMin)).EndInit();
            this.pWarnMin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudWarnMin)).EndInit();
            this.pStatus.ResumeLayout(false);
            this.pWarnMax.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudWarnMax)).EndInit();
            this.pCritMax.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCritMax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lTitre;
        private System.Windows.Forms.Button bApply;
        private System.Windows.Forms.TableLayoutPanel tlpRows;
        private System.Windows.Forms.Panel pWarnMin;
        private System.Windows.Forms.Panel pStatus;
        private System.Windows.Forms.Panel pWarnMax;
        private System.Windows.Forms.Panel pCritMin;
        private System.Windows.Forms.Panel pCritMax;
        private System.Windows.Forms.NumericUpDown nudCritMax;
        private System.Windows.Forms.Label lWarnMin;
        private System.Windows.Forms.NumericUpDown nudWarnMin;
        private System.Windows.Forms.Label lConfigStatus;
        private System.Windows.Forms.Label lWarnMax;
        private System.Windows.Forms.NumericUpDown nudWarnMax;
        private System.Windows.Forms.Label lCritMin;
        private System.Windows.Forms.NumericUpDown nudCritMin;
        private System.Windows.Forms.Label lCritMax;
        private System.Windows.Forms.Panel pIdSelect;
        private System.Windows.Forms.ComboBox cbIdSelect;
        private System.Windows.Forms.Label lId;
        private System.Windows.Forms.Panel pExpiration;
        private System.Windows.Forms.Label lMaxPeriod;
        private System.Windows.Forms.NumericUpDown nudMaxPeriod;
    }
}
