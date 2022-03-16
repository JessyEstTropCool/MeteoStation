
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bApply = new System.Windows.Forms.Button();
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
            this.lTitre.TabIndex = 0;
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
            this.cbIdSelect.TabIndex = 1;
            // 
            // lType
            // 
            this.lType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lType.Location = new System.Drawing.Point(5, 74);
            this.lType.Name = "lType";
            this.lType.Size = new System.Drawing.Size(192, 18);
            this.lType.TabIndex = 2;
            this.lType.Text = "Type : Unknown";
            this.lType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudMax
            // 
            this.nudMax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMax.Location = new System.Drawing.Point(77, 95);
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(120, 20);
            this.nudMax.TabIndex = 3;
            // 
            // nudMin
            // 
            this.nudMin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMin.Location = new System.Drawing.Point(78, 121);
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(120, 20);
            this.nudMin.TabIndex = 4;
            // 
            // lMax
            // 
            this.lMax.Location = new System.Drawing.Point(2, 95);
            this.lMax.Name = "lMax";
            this.lMax.Size = new System.Drawing.Size(67, 20);
            this.lMax.TabIndex = 5;
            this.lMax.Text = "Max :";
            this.lMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(2, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Min :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(2, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bApply
            // 
            this.bApply.BackColor = System.Drawing.Color.White;
            this.bApply.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bApply.Location = new System.Drawing.Point(0, 147);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(201, 44);
            this.bApply.TabIndex = 8;
            this.bApply.Text = "Apply";
            this.bApply.UseVisualStyleBackColor = false;
            // 
            // MeasureConfigControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.bApply);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lMax);
            this.Controls.Add(this.nudMin);
            this.Controls.Add(this.nudMax);
            this.Controls.Add(this.lType);
            this.Controls.Add(this.cbIdSelect);
            this.Controls.Add(this.lTitre);
            this.Name = "MeasureConfigControl";
            this.Size = new System.Drawing.Size(201, 191);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bApply;
    }
}
