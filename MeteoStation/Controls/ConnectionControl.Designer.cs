
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gGoodMeasures = new System.Windows.Forms.DataGridView();
            this.lInfo = new System.Windows.Forms.Label();
            this.pLastRequest = new System.Windows.Forms.Panel();
            this.tbLastResponse = new System.Windows.Forms.TextBox();
            this.tbLastAddress = new System.Windows.Forms.TextBox();
            this.lLastRequest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gGoodMeasures)).BeginInit();
            this.pLastRequest.SuspendLayout();
            this.SuspendLayout();
            // 
            // gGoodMeasures
            // 
            this.gGoodMeasures.AllowUserToAddRows = false;
            this.gGoodMeasures.AllowUserToDeleteRows = false;
            this.gGoodMeasures.AllowUserToResizeColumns = false;
            this.gGoodMeasures.AllowUserToResizeRows = false;
            this.gGoodMeasures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gGoodMeasures.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gGoodMeasures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gGoodMeasures.Dock = System.Windows.Forms.DockStyle.Left;
            this.gGoodMeasures.Location = new System.Drawing.Point(0, 0);
            this.gGoodMeasures.MultiSelect = false;
            this.gGoodMeasures.Name = "gGoodMeasures";
            this.gGoodMeasures.ReadOnly = true;
            this.gGoodMeasures.RowHeadersVisible = false;
            this.gGoodMeasures.Size = new System.Drawing.Size(181, 317);
            this.gGoodMeasures.TabIndex = 3;
            this.gGoodMeasures.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gGoodMeasures_CellClick);
            // 
            // lInfo
            // 
            this.lInfo.BackColor = System.Drawing.Color.White;
            this.lInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lInfo.Location = new System.Drawing.Point(181, 0);
            this.lInfo.Name = "lInfo";
            this.lInfo.Size = new System.Drawing.Size(211, 117);
            this.lInfo.TabIndex = 4;
            this.lInfo.Text = "Heelo";
            this.lInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pLastRequest
            // 
            this.pLastRequest.Controls.Add(this.tbLastResponse);
            this.pLastRequest.Controls.Add(this.tbLastAddress);
            this.pLastRequest.Controls.Add(this.lLastRequest);
            this.pLastRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pLastRequest.Location = new System.Drawing.Point(181, 117);
            this.pLastRequest.Name = "pLastRequest";
            this.pLastRequest.Size = new System.Drawing.Size(211, 200);
            this.pLastRequest.TabIndex = 5;
            // 
            // tbLastResponse
            // 
            this.tbLastResponse.BackColor = System.Drawing.Color.White;
            this.tbLastResponse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLastResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLastResponse.Location = new System.Drawing.Point(0, 44);
            this.tbLastResponse.Multiline = true;
            this.tbLastResponse.Name = "tbLastResponse";
            this.tbLastResponse.ReadOnly = true;
            this.tbLastResponse.Size = new System.Drawing.Size(211, 156);
            this.tbLastResponse.TabIndex = 3;
            this.tbLastResponse.Text = "No response yet";
            // 
            // tbLastAddress
            // 
            this.tbLastAddress.BackColor = System.Drawing.Color.Black;
            this.tbLastAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLastAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbLastAddress.ForeColor = System.Drawing.Color.White;
            this.tbLastAddress.Location = new System.Drawing.Point(0, 24);
            this.tbLastAddress.Name = "tbLastAddress";
            this.tbLastAddress.ReadOnly = true;
            this.tbLastAddress.Size = new System.Drawing.Size(211, 20);
            this.tbLastAddress.TabIndex = 2;
            this.tbLastAddress.Text = "Address :";
            // 
            // lLastRequest
            // 
            this.lLastRequest.BackColor = System.Drawing.Color.White;
            this.lLastRequest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lLastRequest.Dock = System.Windows.Forms.DockStyle.Top;
            this.lLastRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLastRequest.Location = new System.Drawing.Point(0, 0);
            this.lLastRequest.Name = "lLastRequest";
            this.lLastRequest.Size = new System.Drawing.Size(211, 24);
            this.lLastRequest.TabIndex = 0;
            this.lLastRequest.Text = "Last Request :";
            // 
            // ConnectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.pLastRequest);
            this.Controls.Add(this.lInfo);
            this.Controls.Add(this.gGoodMeasures);
            this.Name = "ConnectionControl";
            this.Size = new System.Drawing.Size(392, 317);
            ((System.ComponentModel.ISupportInitialize)(this.gGoodMeasures)).EndInit();
            this.pLastRequest.ResumeLayout(false);
            this.pLastRequest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gGoodMeasures;
        private System.Windows.Forms.Label lInfo;
        private System.Windows.Forms.Panel pLastRequest;
        private System.Windows.Forms.TextBox tbLastResponse;
        private System.Windows.Forms.TextBox tbLastAddress;
        private System.Windows.Forms.Label lLastRequest;
    }
}
