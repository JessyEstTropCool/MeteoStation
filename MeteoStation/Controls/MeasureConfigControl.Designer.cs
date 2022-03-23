
namespace MeteoStation.Controls
{
    partial class MeasureConfigControl
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
            this.cbIdSelect = new System.Windows.Forms.ComboBox();
            this.lType = new System.Windows.Forms.Label();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.lMax = new System.Windows.Forms.Label();
            this.lMin = new System.Windows.Forms.Label();
            this.lId = new System.Windows.Forms.Label();
            this.bApply = new System.Windows.Forms.Button();
            this.lStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
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
            this.lTitre.Size = new System.Drawing.Size(201, 47);
            this.lTitre.TabIndex = 4;
            this.lTitre.Text = "Configuration";
            this.lTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbIdSelect
            // 
            this.cbIdSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbIdSelect.FormattingEnabled = true;
            this.cbIdSelect.Location = new System.Drawing.Point(77, 50);
            this.cbIdSelect.Name = "cbIdSelect";
            this.cbIdSelect.Size = new System.Drawing.Size(121, 21);
            this.cbIdSelect.TabIndex = 0;
            this.cbIdSelect.DropDown += new System.EventHandler(this.cbIdSelect_DropDown);
            this.cbIdSelect.DropDownClosed += new System.EventHandler(this.cbIdSelect_DropDownClosed);
            // 
            // lType
            // 
            this.lType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lType.Location = new System.Drawing.Point(0, 74);
            this.lType.Name = "lType";
            this.lType.Size = new System.Drawing.Size(201, 18);
            this.lType.TabIndex = 6;
            this.lType.Text = "Type : Unknown";
            this.lType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudMax
            // 
            this.nudMax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMax.Location = new System.Drawing.Point(77, 120);
            this.nudMax.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.nudMax.Minimum = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(120, 20);
            this.nudMax.TabIndex = 2;
            // 
            // nudMin
            // 
            this.nudMin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMin.Location = new System.Drawing.Point(78, 94);
            this.nudMin.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.nudMin.Minimum = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(120, 20);
            this.nudMin.TabIndex = 1;
            // 
            // lMax
            // 
            this.lMax.Location = new System.Drawing.Point(2, 118);
            this.lMax.Name = "lMax";
            this.lMax.Size = new System.Drawing.Size(67, 20);
            this.lMax.TabIndex = 8;
            this.lMax.Text = "Max :";
            this.lMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lMin
            // 
            this.lMin.Location = new System.Drawing.Point(2, 92);
            this.lMin.Name = "lMin";
            this.lMin.Size = new System.Drawing.Size(67, 20);
            this.lMin.TabIndex = 7;
            this.lMin.Text = "Min :";
            this.lMin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lId
            // 
            this.lId.Location = new System.Drawing.Point(2, 49);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(67, 20);
            this.lId.TabIndex = 5;
            this.lId.Text = "ID :";
            this.lId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bApply
            // 
            this.bApply.BackColor = System.Drawing.Color.White;
            this.bApply.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bApply.Location = new System.Drawing.Point(0, 191);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(201, 44);
            this.bApply.TabIndex = 3;
            this.bApply.Text = "Apply";
            this.bApply.UseVisualStyleBackColor = false;
            this.bApply.Click += new System.EventHandler(this.bApply_Click);
            // 
            // lStatus
            // 
            this.lStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lStatus.Location = new System.Drawing.Point(0, 143);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(201, 18);
            this.lStatus.TabIndex = 9;
            this.lStatus.Text = "Status : Not done";
            this.lStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MeasureConfigControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.bApply);
            this.Controls.Add(this.lId);
            this.Controls.Add(this.lMin);
            this.Controls.Add(this.lMax);
            this.Controls.Add(this.nudMin);
            this.Controls.Add(this.nudMax);
            this.Controls.Add(this.lType);
            this.Controls.Add(this.cbIdSelect);
            this.Controls.Add(this.lTitre);
            this.Name = "MeasureConfigControl";
            this.Size = new System.Drawing.Size(201, 235);
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lTitre;
        private System.Windows.Forms.ComboBox cbIdSelect;
        private System.Windows.Forms.Label lType;
        private System.Windows.Forms.NumericUpDown nudMax;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.Label lMax;
        private System.Windows.Forms.Label lMin;
        private System.Windows.Forms.Label lId;
        private System.Windows.Forms.Button bApply;
        private System.Windows.Forms.Label lStatus;
    }
}
