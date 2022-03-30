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
        public MeasureControl()
        {
            InitializeComponent();

            //Récupere les données immédiatement
            Data.Collections.UpdateMeasureTable(dgvGrid);

            dgvGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        
        //Récupere les données en même temps que le timer du form principal
        internal void UpdateTick(object sender, EventArgs e)
        {
            Data.Collections.UpdateMeasureTable(dgvGrid);

            dgvGrid.ClearSelection();

            //tslErrors.Text = SerialPortHandler.Reception.errors + " erreurs";
        }

        //J'aime pas que la selection reste
        private void dgvGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvGrid.ClearSelection();
        }
    }
}
