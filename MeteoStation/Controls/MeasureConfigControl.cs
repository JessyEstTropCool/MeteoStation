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
        internal event EventHandler ConfigDone;
        internal event EventHandler DropDown;
        internal event EventHandler DropDownClosed;
        internal int ID { get; set; } = -1;
        internal int Max { get => (int)nudMax.Value; }
        internal int Min { get => (int)nudMin.Value; }
        internal object SelectedItem { get => cbIdSelect.SelectedItem; }

        public MeasureConfigControl()
        {
            InitializeComponent();
        }

        //set ce qui va dans la combobox (dans ce cas les IDs)
        internal void SetCbItems(object[] items)
        {
            cbIdSelect.Items.Clear();
            cbIdSelect.Items.AddRange(items);
        }

        //Affiche les infos de config de la mesure sur les bons controles
        internal void UpdateInfo(int low, int high, string type, string unit, bool config)
        {
            lType.Text = "Type : " + type + " (" + unit + ")";
            lStatus.Text = "Status : " + ((config)? "Done" : "Not Done");

            nudMax.Value = high;
            nudMin.Value = low;
        }

        //Demande la configuration de la mesure
        private void bApply_Click(object sender, EventArgs e)
        {
            ConfigDone.Invoke(this, e);
        }

        //Event pour quand on ouvre le combo box
        private void cbIdSelect_DropDown(object sender, EventArgs e)
        {
            DropDown.Invoke(this, e);
        }

        //Event pour quand on ferme le combo box
        private void cbIdSelect_DropDownClosed(object sender, EventArgs e)
        {
            DropDownClosed.Invoke(this, e);
        }

        internal void SendError(int code)
        {
            switch (code)
            {
                case 0:
                    MessageBox.Show("Veuillez sélectionner une mesure", "Erreur de configuration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case 1:
                    MessageBox.Show("Min et Max incohérents (ils ne peuvent pas êtres égaux, non plus)", "Erreur de configuration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                default:
                    MessageBox.Show("Une erreur c'est produite", "Erreur de configuration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
