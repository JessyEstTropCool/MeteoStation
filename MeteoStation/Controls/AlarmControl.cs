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
    public partial class AlarmControl : UserControl
    {
        internal DataTable Table { get; }
        private readonly string[] columnNames = { "ID", "Crit. Min", "Warn. Min", "Status", "Warn. Max", "Crit. Max" };

        public AlarmControl()
        {
            InitializeComponent();

            //Configure la datatable et ajoute les colones appropriées
            Table = new DataTable();

            foreach (string name in columnNames)
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
            Data.Collections.UpdateAlarmTable(dgvGrid, Table);

            dgvGrid.ClearSelection();
        }

        //J'aime pas que la selection reste
        private void dgvGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvGrid.ClearSelection();
        }
    }
}
