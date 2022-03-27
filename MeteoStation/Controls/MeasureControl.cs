using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeteoStation.Controls
{
    public partial class MeasureControl : UserControl
    {
        internal DataTable Table { get; }
        private readonly string[] columnNames = { "ID", "Config", "Type", "Data", "Last update", "Alarm" };

        public MeasureControl()
        {
            InitializeComponent();

            //Configure la datatable et ajoute les colones appropriées
            Table = new DataTable();

            foreach ( string name in columnNames )
                Table.Columns.Add(name);

            RefreshGrid();

            dgvGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //Récupere les données immédiatement
            Data.Collections.UpdateMeasureTable(dgvGrid, Table);
        }

        //Rafraichi les infos sur la grille
        public void RefreshGrid()
        {
            dgvGrid.DataSource = Table;
            dgvGrid.Refresh();
        }
        
        //Récupere les données en même temps que le timer du form principal
        internal void UpdateTick(object sender, EventArgs e)
        {
            Data.Collections.UpdateMeasureTable(dgvGrid, Table);
            ColorGrid();

            dgvGrid.ClearSelection();

            //tslErrors.Text = SerialPortHandler.Reception.errors + " erreurs";
        }

        //J'aime pas que la selection reste
        private void dgvGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvGrid.ClearSelection();
        }

        //Donne les bonnes couleurs à la colonne de status
        internal void ColorGrid()
        {
            const int statusCol = 5;

            for (int compt = 0; compt < Table.Rows.Count; compt++)
            {
                switch (Table.Rows[compt][columnNames[statusCol]])
                {
                    case "Normal":
                        if (dgvGrid.Rows.Count > 0)
                            dgvGrid.Rows[compt].Cells[statusCol].Style.BackColor = Color.PaleGreen;
                        break;

                    case "Warning":
                        if (dgvGrid.Rows.Count > 0)
                            dgvGrid.Rows[compt].Cells[statusCol].Style.BackColor = Color.FromArgb(254, 230, 133);
                        break;

                    case "Critical":
                        if (dgvGrid.Rows.Count > 0)
                            dgvGrid.Rows[compt].Cells[statusCol].Style.BackColor = Color.LightCoral;
                        break;

                    case "Obselete":
                        if (dgvGrid.Rows.Count > 0)
                            dgvGrid.Rows[compt].Cells[statusCol].Style.BackColor = Color.Brown;
                        break;

                    default:
                        if (dgvGrid.Rows.Count > 0)
                            dgvGrid.Rows[compt].Cells[statusCol].Style.BackColor = dgvGrid.DefaultCellStyle.BackColor;
                        break;
                }
            }
        }
    }
}
