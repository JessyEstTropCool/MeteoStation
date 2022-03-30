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
        public AlarmControl()
        {
            InitializeComponent();

            //Récupere les données immédiatement
            Data.Collections.UpdateAlarmTable(dgvGrid);

            dgvGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        //Récupere les données en même temps que le timer du form principal
        internal void UpdateTick(object sender, EventArgs e)
        {
            Data.Collections.UpdateAlarmTable(dgvGrid);

            dgvGrid.ClearSelection();
        }

        //J'aime pas que la selection reste
        private void dgvGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvGrid.ClearSelection();
        }
    }
}
