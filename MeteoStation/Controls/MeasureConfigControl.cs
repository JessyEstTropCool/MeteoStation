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
    public partial class MeasureConfigControl : UserControl
    {
        internal int ID { get; set; }
        internal int Max { get => (int)nudMax.Value; }
        internal int Min { get => (int)nudMin.Value; }

        internal event EventHandler ConfigDone;

        public MeasureConfigControl()
        {
            InitializeComponent();
            ID = -1;
        }

        //Vérifie que les données on du sens
        private void bApply_Click(object sender, EventArgs e)
        {
            if (ID == -1) MessageBox.Show("Veuillez sélectionner une mesure", "Erreur de configuration", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            else if (Min >= Max) MessageBox.Show("Min et Max incohérents (ils ne peuvent pas êtres égaux, non plus)", "Erreur de configuration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                ConfigDone?.Invoke(this, EventArgs.Empty);
                UpdateLabels();
                MessageBox.Show("Verif ok");
            }
        }

        //va chercher les ids des mesures qu'on a
        private void cbIdSelect_DropDown(object sender, EventArgs e)
        {
            cbIdSelect.Items.Clear();
            cbIdSelect.Items.AddRange(Data.Collections.GetMeasureIds());
        }

        //Set l'id de la mesure a configurer et indique le type et status
        private void cbIdSelect_DropDownClosed(object sender, EventArgs e)
        {
            if (cbIdSelect.SelectedItem != null)
            {
                ID = (int.Parse((string)cbIdSelect.SelectedItem));
                UpdateLabels();
            }
        }

        //Affiche le type et status de config sur les bons labels
        private void UpdateLabels()
        {
            Data.SensorData.Measure m = Data.Collections.GetMeasure(ID);
            lType.Text = "Type : " + Data.Collections.TypeList[m.type].Name + " (" + Data.Collections.TypeList[m.type].Unit + ")";
            lStatus.Text = "Status : " + ((m.IsConfigured())? "Done" : "Not Done");
        }
    }
}
