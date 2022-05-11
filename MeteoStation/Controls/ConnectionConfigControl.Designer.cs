
namespace MeteoStation.Controls
{
    partial class ConnectionConfigControl
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
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.bLocal = new System.Windows.Forms.Button();
            this.bRemote = new System.Windows.Forms.Button();
            this.tlpButtons.SuspendLayout();
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
            this.lTitre.Size = new System.Drawing.Size(176, 47);
            this.lTitre.TabIndex = 5;
            this.lTitre.Text = "Connect to";
            this.lTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpButtons
            // 
            this.tlpButtons.ColumnCount = 1;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.Controls.Add(this.bLocal, 0, 0);
            this.tlpButtons.Controls.Add(this.bRemote, 0, 1);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtons.Location = new System.Drawing.Point(0, 47);
            this.tlpButtons.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 2;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpButtons.Size = new System.Drawing.Size(176, 176);
            this.tlpButtons.TabIndex = 6;
            // 
            // bLocal
            // 
            this.bLocal.BackColor = System.Drawing.Color.White;
            this.bLocal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.bLocal.Location = new System.Drawing.Point(0, 0);
            this.bLocal.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.bLocal.Name = "bLocal";
            this.bLocal.Size = new System.Drawing.Size(176, 88);
            this.bLocal.TabIndex = 0;
            this.bLocal.Text = "Local Version";
            this.bLocal.UseVisualStyleBackColor = false;
            this.bLocal.Click += new System.EventHandler(this.bLocal_Click);
            // 
            // bRemote
            // 
            this.bRemote.BackColor = System.Drawing.Color.White;
            this.bRemote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bRemote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRemote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.bRemote.Location = new System.Drawing.Point(0, 88);
            this.bRemote.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.bRemote.Name = "bRemote";
            this.bRemote.Size = new System.Drawing.Size(176, 88);
            this.bRemote.TabIndex = 1;
            this.bRemote.Text = "Remote Version";
            this.bRemote.UseVisualStyleBackColor = false;
            this.bRemote.Click += new System.EventHandler(this.bRemote_Click);
            // 
            // ConnectionConfigControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.tlpButtons);
            this.Controls.Add(this.lTitre);
            this.Name = "ConnectionConfigControl";
            this.Size = new System.Drawing.Size(176, 223);
            this.tlpButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lTitre;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.Button bLocal;
        private System.Windows.Forms.Button bRemote;
    }
}
