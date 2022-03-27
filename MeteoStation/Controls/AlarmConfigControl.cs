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
    public partial class AlarmConfigControl : UserControl
    {
        internal event EventHandler ConfigDone;
        internal int ID { get; set; }
        internal int CritMax { get => (int)nudCritMax.Value; }
        internal int WarnMax { get => (int)nudWarnMax.Value; }
        internal int WarnMin { get => (int)nudWarnMin.Value; }
        internal int CritMin { get => (int)nudCritMin.Value; }

        public AlarmConfigControl()
        {
            InitializeComponent();
            ID = -1;
        }

        //va chercher les ids des mesures configurées qu'on a
        private void cbIdSelect_DropDown(object sender, EventArgs e)
        {
            cbIdSelect.Items.Clear();
            cbIdSelect.Items.AddRange(Data.Collections.GetConfiguredMeasureIds());
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

        //Affiche les infos de config de la mesure sur les bons controles
        private void UpdateLabels()
        {
            Data.SensorData.Measure m = Data.Collections.GetMeasure(ID);
            lConfigStatus.Text = "Type : " + Data.Collections.TypeList[m.type].Name + " | Limits : " + m.LowLimit + " - " + m.HighLimit;

            if ( m.HasAlarms() )
            {
                lConfigStatus.Text += "\nAlarms set";

                nudCritMax.Value = m.CriticalMax;
                nudWarnMax.Value = m.WarningMax;
                nudWarnMin.Value = m.WarningMin;
                nudCritMin.Value = m.CriticalMin;
            }
            else
            {
                lConfigStatus.Text += "\nNo alarms";

                nudCritMax.Value = m.HighLimit;
                nudWarnMax.Value = m.HighLimit;
                nudWarnMin.Value = m.LowLimit;
                nudCritMin.Value = m.LowLimit;
            }
        }

        private void bApply_Click(object sender, EventArgs e)
        {
            Data.SensorData.Measure m = Data.Collections.GetMeasure(ID);

            if (ID == -1) MessageBox.Show("Veuillez sélectionner une mesure", "Erreur de configuration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (CritMax > m.HighLimit || WarnMax > m.HighLimit || WarnMin < m.LowLimit || CritMin < m.LowLimit) MessageBox.Show("Une alarme est hors limite", "Erreur de configuration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (CritMin > CritMax || WarnMin > WarnMax) MessageBox.Show("Des alarmes sont incohérentes (Min et Max dans le mauvais sens ou égaux)", "Erreur de configuration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (WarnMax > CritMax || WarnMin < CritMin) MessageBox.Show("Alarmes critiques et d'attentions entremélées", "Erreur de configuration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                ConfigDone?.Invoke(this, EventArgs.Empty);
                UpdateLabels();
            }
        }
    }
}
