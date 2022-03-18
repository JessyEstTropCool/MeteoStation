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
        //internal DataGridView Grid { get => dgvGrid; }

        public MeasureControl()
        {
            InitializeComponent();

            Table = new DataTable();

            //Ajoute les colones
            Table.Columns.Add("ID");
            Table.Columns.Add("CONFIG");
            Table.Columns.Add("TYPE");
            Table.Columns.Add("DATA");
            Table.Columns.Add("UPDATE");
            Table.Columns.Add("ALARM");
            RefreshGrid();

            dgvGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

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

            dgvGrid.ClearSelection();

            //tslErrors.Text = SerialPortHandler.Reception.errors + " erreurs";
        }
    }
}
