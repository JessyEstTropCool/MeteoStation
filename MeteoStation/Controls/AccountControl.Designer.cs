namespace MeteoStation.Controls
{
    partial class AccountControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewAccount = new System.Windows.Forms.DataGridView();
            this.dataGridViewRights = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRights)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAccount
            // 
            this.dataGridViewAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAccount.BackgroundColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewAccount.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewAccount.Name = "dataGridViewAccount";
            this.dataGridViewAccount.RowHeadersVisible = false;
            this.dataGridViewAccount.RowHeadersWidth = 51;
            this.dataGridViewAccount.RowTemplate.Height = 28;
            this.dataGridViewAccount.Size = new System.Drawing.Size(492, 198);
            this.dataGridViewAccount.TabIndex = 1;
            // 
            // dataGridViewRights
            // 
            this.dataGridViewRights.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewRights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRights.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewRights.GridColor = System.Drawing.Color.PowderBlue;
            this.dataGridViewRights.Location = new System.Drawing.Point(0, 215);
            this.dataGridViewRights.Name = "dataGridViewRights";
            this.dataGridViewRights.RowHeadersWidth = 51;
            this.dataGridViewRights.RowTemplate.Height = 24;
            this.dataGridViewRights.Size = new System.Drawing.Size(492, 192);
            this.dataGridViewRights.TabIndex = 2;
            // 
            // AccountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewRights);
            this.Controls.Add(this.dataGridViewAccount);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AccountControl";
            this.Size = new System.Drawing.Size(492, 407);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRights)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.DataGridView dataGridViewAccount;
        internal System.Windows.Forms.DataGridView dataGridViewRights;
    }
}
