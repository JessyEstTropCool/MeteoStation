using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using MeteoStation.Controls;

namespace MeteoStation
{
    public partial class MainForm : Form
    {
        Control mainControl = null, configControl = null;

        public MainForm()
        {
            InitializeComponent();

            spSensorData.DataReceived += new SerialDataReceivedEventHandler(SerialPortHandler.Reception.RecieveData);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Dans le futur a prendre d'un fichier voire la db
            Data.Collections.TypeList.Add(new Data.SensorData.MeasureType("Alarme", "yowchs"));
            Data.Collections.TypeList.Add(new Data.SensorData.MeasureType("CO²", "ppm"));
            Data.Collections.TypeList.Add(new Data.SensorData.MeasureType("Température", "°C"));
            Data.Collections.TypeList.Add(new Data.SensorData.MeasureType("Humidité", "%"));

            if (SerialPort.GetPortNames().Length > 0)
            {
                spSensorData.PortName = SerialPort.GetPortNames()[0];

                tscbComPorts.Items.Add(SerialPort.GetPortNames()[0]);
                tscbComPorts.SelectedIndex = 0;
            }

            //Affiche les controles de mesures des le début
            tsbMeasures.PerformClick();
        }

        //Handler du timer responsable du traitement des données
        private void timerDequeue_Tick(object sender, EventArgs e)
        {
            //Traitement des données toutes les secondes
            if (spSensorData.IsOpen)
            {
                SerialPortHandler.Reception.DataTreatment();
                tslErrors.Text = SerialPortHandler.Reception.errors + " erreurs";
            }

            lTemps.Text = DateTime.Now.ToString("F");
        }

        //Ouverture / Fermeture du port
        private void OpenClosePort(object sender, EventArgs e)
        {
            try
            {
                //Update des label et bouton + (dés)activation du timer quand on ouvre/ferme le port
                if (spSensorData.IsOpen)
                {
                    spSensorData.Close();
                    ((ToolStripItem)sender).Text = "Open";
                    tslStatus.Text = "Status : Closed";
                }
                else
                {
                    spSensorData.Open();
                    ((ToolStripItem)sender).Text = "Close";
                    tslStatus.Text = "Status : Opened";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur de port", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Recherche les items a afficher quand on ouvre le dropdown
        private void cbComPorts_DropDown(object sender, EventArgs e)
        {
            tscbComPorts.Items.Clear();
            tscbComPorts.Items.AddRange(SerialPort.GetPortNames());
        }

        //Essaye d'assigner le nom de port quand on ferme le dropdown
        private void cbComPorts_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                if (tscbComPorts.SelectedItem != null) spSensorData.PortName = tscbComPorts.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur de port", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tscbComPorts.SelectedText = spSensorData.PortName;
                tscbComPorts.Text = spSensorData.PortName;
            }
        }

        //On retire tout ce qu'il y a dans les pânels pour faire place au autres usercontrol
        private void ClearPanels()
        {
            if (mainControl != null)
            {
                mainControl.Dispose();
                mainControl = null;
                pMainControl.Controls.Clear();
            }

            if (configControl != null)
            {
                configControl.Dispose();
                configControl = null;
                pConfigControl.Controls.Clear();
            }
        }

        //Met un control dans le grand panel et l'assigne comme controle principal
        private void SetMainControl(Control control)
        {
            mainControl = control;
            pMainControl.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }

        //Met un control dans le petit panel et l'assigne comme controle secondaire
        private void SetConfigControl(Control control)
        {
            configControl = control;
            pConfigControl.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }

        //Met les controles de mesures
        private void tsbMeasures_Click(object sender, EventArgs e)
        {
            MeasureControl mtc = new MeasureControl();
            MeasureConfigControl mcc = new MeasureConfigControl();
            DataTable dt = mtc.Table;

            ClearPanels();

            SetMainControl(mtc);
            SetConfigControl(mcc);

            timerDequeue.Tick += mtc.UpdateTick;

            mcc.ConfigDone += Data.Collections.MeasureBasicConfigDone;
            mcc.ConfigDone += mtc.UpdateTick;
        }

        //Met les controles d'alarmes
        private void tsbAlarms_Click(object sender, EventArgs e)
        {
            AlarmControl ac = new AlarmControl();
            AlarmConfigControl acc = new AlarmConfigControl();

            ClearPanels();

            SetMainControl(ac);
            SetConfigControl(acc);

            timerDequeue.Tick += ac.UpdateTick;

            acc.ConfigDone += Data.Collections.MeasureAlarmConfigDone;
            acc.ConfigDone += ac.UpdateTick;
        }

        //Met les controles de graphiques
        private void tsbGraphs_Click(object sender, EventArgs e)
        {
            ClearPanels();
            
            
        }

        //Met les controles de comptes
        private void tsbAccounts_Click(object sender, EventArgs e)
        {
            ClearPanels();
            SetMainControl(new AccountControl());
            SetConfigControl(new AccountConfigControl());
        }

        //Met les controles de connection
        private void tsbConnection_Click(object sender, EventArgs e)
        {
            ClearPanels();
        }

        //Met les controles de calibration
        private void tsbCalibration_Click(object sender, EventArgs e)
        {
            ClearPanels();
        }
    }
}
