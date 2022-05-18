
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
            this.lFrequency = new System.Windows.Forms.Label();
            this.pFrequency = new System.Windows.Forms.Panel();
            this.bConfirmTime = new System.Windows.Forms.Button();
            this.mtbFrequency = new System.Windows.Forms.MaskedTextBox();
            this.tlpButtons.SuspendLayout();
            this.pFrequency.SuspendLayout();
            this.SuspendLayout();
            // 
            // lTitre
            // 
            this.lTitre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitre.Location = new System.Drawing.Point(0, 0);
            this.lTitre.Margin = new System.Windows.Forms.Padding(0);
            this.lTitre.Name = "lTitre";
            this.tlpButtons.SetRowSpan(this.lTitre, 2);
            this.lTitre.Size = new System.Drawing.Size(97, 51);
            this.lTitre.TabIndex = 5;
            this.lTitre.Text = "Connect to :";
            this.lTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpButtons
            // 
            this.tlpButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpButtons.AutoSize = true;
            this.tlpButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpButtons.ColumnCount = 2;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.Controls.Add(this.pFrequency, 1, 2);
            this.tlpButtons.Controls.Add(this.lFrequency, 0, 2);
            this.tlpButtons.Controls.Add(this.bLocal, 1, 0);
            this.tlpButtons.Controls.Add(this.lTitre, 0, 0);
            this.tlpButtons.Controls.Add(this.bRemote, 1, 1);
            this.tlpButtons.Location = new System.Drawing.Point(0, 77);
            this.tlpButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 3;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpButtons.Size = new System.Drawing.Size(194, 76);
            this.tlpButtons.TabIndex = 6;
            // 
            // bLocal
            // 
            this.bLocal.BackColor = System.Drawing.Color.White;
            this.bLocal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.bLocal.Location = new System.Drawing.Point(97, 0);
            this.bLocal.Margin = new System.Windows.Forms.Padding(0);
            this.bLocal.Name = "bLocal";
            this.bLocal.Size = new System.Drawing.Size(97, 25);
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
            this.bRemote.Location = new System.Drawing.Point(97, 25);
            this.bRemote.Margin = new System.Windows.Forms.Padding(0);
            this.bRemote.Name = "bRemote";
            this.bRemote.Size = new System.Drawing.Size(97, 26);
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
            this.bOnOff.Size = new System.Drawing.Size(188, 32);
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
            this.label1.Size = new System.Drawing.Size(194, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "Settings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bSend
            // 
            this.bSend.BackColor = System.Drawing.Color.White;
            this.bSend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSend.Location = new System.Drawing.Point(0, 198);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(194, 32);
            this.bSend.TabIndex = 9;
            this.bSend.Text = "Send Now";
            this.bSend.UseVisualStyleBackColor = false;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // lFrequency
            // 
            this.lFrequency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFrequency.Location = new System.Drawing.Point(0, 51);
            this.lFrequency.Margin = new System.Windows.Forms.Padding(0);
            this.lFrequency.Name = "lFrequency";
            this.lFrequency.Size = new System.Drawing.Size(97, 25);
            this.lFrequency.TabIndex = 11;
            this.lFrequency.Text = "Send every :";
            this.lFrequency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pFrequency
            // 
            this.pFrequency.AutoSize = true;
            this.pFrequency.Controls.Add(this.mtbFrequency);
            this.pFrequency.Controls.Add(this.bConfirmTime);
            this.pFrequency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pFrequency.Location = new System.Drawing.Point(97, 51);
            this.pFrequency.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.pFrequency.Name = "pFrequency";
            this.pFrequency.Size = new System.Drawing.Size(97, 25);
            this.pFrequency.TabIndex = 10;
            // 
            // bConfirmTime
            // 
            this.bConfirmTime.AutoSize = true;
            this.bConfirmTime.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bConfirmTime.BackColor = System.Drawing.Color.White;
            this.bConfirmTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.bConfirmTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bConfirmTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.bConfirmTime.Location = new System.Drawing.Point(61, 0);
            this.bConfirmTime.Margin = new System.Windows.Forms.Padding(0);
            this.bConfirmTime.Name = "bConfirmTime";
            this.bConfirmTime.Size = new System.Drawing.Size(36, 25);
            this.bConfirmTime.TabIndex = 2;
            this.bConfirmTime.Text = "OK";
            this.bConfirmTime.UseVisualStyleBackColor = false;
            this.bConfirmTime.Click += new System.EventHandler(this.bConfirmTime_Click);
            // 
            // mtbFrequency
            // 
            this.mtbFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbFrequency.Location = new System.Drawing.Point(0, 1);
            this.mtbFrequency.Margin = new System.Windows.Forms.Padding(0);
            this.mtbFrequency.Mask = "00:00:00";
            this.mtbFrequency.MinimumSize = new System.Drawing.Size(0, 23);
            this.mtbFrequency.Name = "mtbFrequency";
            this.mtbFrequency.Size = new System.Drawing.Size(61, 23);
            this.mtbFrequency.TabIndex = 11;
            this.mtbFrequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.Size = new System.Drawing.Size(194, 230);
            this.tlpButtons.ResumeLayout(false);
            this.tlpButtons.PerformLayout();
            this.pFrequency.ResumeLayout(false);
            this.pFrequency.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitre;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.Button bLocal;
        private System.Windows.Forms.Button bRemote;
        private System.Windows.Forms.Button bOnOff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bSend;
        private System.Windows.Forms.Label lFrequency;
        private System.Windows.Forms.Panel pFrequency;
        private System.Windows.Forms.MaskedTextBox mtbFrequency;
        private System.Windows.Forms.Button bConfirmTime;
    }
}
