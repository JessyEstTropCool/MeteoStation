
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
            this.bOnOff = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bSend = new System.Windows.Forms.Button();
            this.tlpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lTitre
            // 
            this.lTitre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lTitre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitre.Location = new System.Drawing.Point(0, 0);
            this.lTitre.Margin = new System.Windows.Forms.Padding(0);
            this.lTitre.Name = "lTitre";
            this.tlpButtons.SetRowSpan(this.lTitre, 2);
            this.lTitre.Size = new System.Drawing.Size(88, 52);
            this.lTitre.TabIndex = 5;
            this.lTitre.Text = "Connect to :";
            this.lTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpButtons
            // 
            this.tlpButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpButtons.ColumnCount = 2;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.Controls.Add(this.bLocal, 1, 0);
            this.tlpButtons.Controls.Add(this.lTitre, 0, 0);
            this.tlpButtons.Controls.Add(this.bRemote, 1, 1);
            this.tlpButtons.Location = new System.Drawing.Point(0, 77);
            this.tlpButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 2;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.Size = new System.Drawing.Size(176, 52);
            this.tlpButtons.TabIndex = 6;
            // 
            // bLocal
            // 
            this.bLocal.BackColor = System.Drawing.Color.White;
            this.bLocal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.bLocal.Location = new System.Drawing.Point(88, 0);
            this.bLocal.Margin = new System.Windows.Forms.Padding(0);
            this.bLocal.Name = "bLocal";
            this.bLocal.Size = new System.Drawing.Size(88, 26);
            this.bLocal.TabIndex = 0;
            this.bLocal.Text = "Local";
            this.bLocal.UseVisualStyleBackColor = false;
            this.bLocal.Click += new System.EventHandler(this.bLocal_Click);
            // 
            // bRemote
            // 
            this.bRemote.BackColor = System.Drawing.Color.White;
            this.bRemote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bRemote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRemote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.bRemote.Location = new System.Drawing.Point(88, 26);
            this.bRemote.Margin = new System.Windows.Forms.Padding(0);
            this.bRemote.Name = "bRemote";
            this.bRemote.Size = new System.Drawing.Size(88, 26);
            this.bRemote.TabIndex = 1;
            this.bRemote.Text = "Remote";
            this.bRemote.UseVisualStyleBackColor = false;
            this.bRemote.Click += new System.EventHandler(this.bRemote_Click);
            // 
            // bOnOff
            // 
            this.bOnOff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bOnOff.BackColor = System.Drawing.Color.PaleGreen;
            this.bOnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOnOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOnOff.Location = new System.Drawing.Point(3, 42);
            this.bOnOff.Name = "bOnOff";
            this.bOnOff.Size = new System.Drawing.Size(170, 32);
            this.bOnOff.TabIndex = 7;
            this.bOnOff.Text = "On/Off";
            this.bOnOff.UseVisualStyleBackColor = false;
            this.bOnOff.Click += new System.EventHandler(this.bOnOff_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "Settings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bSend
            // 
            this.bSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bSend.BackColor = System.Drawing.Color.White;
            this.bSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSend.Location = new System.Drawing.Point(3, 132);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(170, 32);
            this.bSend.TabIndex = 9;
            this.bSend.Text = "Send Now";
            this.bSend.UseVisualStyleBackColor = false;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // ConnectionConfigControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bOnOff);
            this.Controls.Add(this.tlpButtons);
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
        private System.Windows.Forms.Button bOnOff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bSend;
    }
}
