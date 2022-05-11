
namespace MeteoStation.Controls
{
    partial class ConnectionControl
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
            this.lInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lInfo
            // 
            this.lInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lInfo.BackColor = System.Drawing.Color.White;
            this.lInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lInfo.Location = new System.Drawing.Point(25, 25);
            this.lInfo.Name = "lInfo";
            this.lInfo.Size = new System.Drawing.Size(100, 100);
            this.lInfo.TabIndex = 0;
            this.lInfo.Text = "Heelo";
            this.lInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConnectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.lInfo);
            this.Name = "ConnectionControl";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lInfo;
    }
}
