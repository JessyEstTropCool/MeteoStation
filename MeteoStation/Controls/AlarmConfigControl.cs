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
        internal event EventHandler DropDown;
        internal event EventHandler DropDownClosed;
        internal int ID { get; set; } = -1;
        internal int CritMax { get => (int)nudCritMax.Value; }
        internal int WarnMax { get => (int)nudWarnMax.Value; }
        internal int WarnMin { get => (int)nudWarnMin.Value; }
        internal int CritMin { get => (int)nudCritMin.Value; }
        internal uint MaxPeriod { get => (uint)nudMaxPeriod.Value; }
        internal object SelectedItem { get => cbIdSelect.SelectedItem; }

        public AlarmConfigControl()
        {
            InitializeComponent();
        }

        //set ce qui va dans la combobox (dans ce cas les IDs)
        internal void SetCbItems(object[] items)
        {
            cbIdSelect.Items.Clear();
            cbIdSelect.Items.AddRange(items);
        }

        //va chercher les ids des mesures configurées qu'on a
        private void cbIdSelect_DropDown(object sender, EventArgs e)
        {
            DropDown.Invoke(this, e);
        }

        //Set l'id de la mesure a configurer et indique le type et status
        private void cbIdSelect_DropDownClosed(object sender, EventArgs e)
        {
            DropDownClosed.Invoke(this, e);
        }

        private void bApply_Click(object sender, EventArgs e)
        {
            ConfigDone.Invoke(this, EventArgs.Empty);
        }

        internal void UpdateInfo(int low, int high, int maxPeriod, string type)
        {
            UpdateInfo(low, high, high, high, low, low, maxPeriod, type, false);
        }

        //Affiche les infos de config de la mesure sur les bons controles
        internal void UpdateInfo(int low, int high, int critMax, int warnMax, int warnMin, int critMin, int maxPeriod, string type, bool alarms)
        {
            lConfigStatus.Text = "Type : " + type + " | Limits : " + low + " - " + high;

            nudCritMax.Value = critMax;
            nudWarnMax.Value = warnMax;
            nudWarnMin.Value = warnMin;
            nudCritMin.Value = critMin;
            nudMaxPeriod.Value = maxPeriod;

            if ( alarms ) lConfigStatus.Text += "\nAlarms set";
            else lConfigStatus.Text += "\nNo alarms";
        }

        internal void SendError(int code)
        {
            switch (code)
            {
                case 0:
                    MessageBox.Show("Veuillez sélectionner une mesure", "Erreur de configuration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case 1:
                    MessageBox.Show("Une alarme est hors limite", "Erreur de configuration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case 2:
                    MessageBox.Show("Des alarmes sont incohérentes (Min et Max dans le mauvais sens ou égaux)", "Erreur de configuration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case 3:
                    MessageBox.Show("Alarmes critiques et d'attentions entremélées", "Erreur de configuration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case 4:
                    MessageBox.Show("La durée de temps ne peut pas être négative ou nulle", "Erreur de configuration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                default:
                    MessageBox.Show("Une erreur c'est produite", "Erreur de configuration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
