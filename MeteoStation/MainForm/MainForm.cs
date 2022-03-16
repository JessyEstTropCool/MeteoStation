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

            tscbComPorts.Items.Add(spSensorData.PortName);
            tscbComPorts.SelectedIndex = 0;
        }

        private void TimerDequeue_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Data.Collections.TypeList.Add(new Data.SensorData.MeasureType("Alarme", "yowchs"));
            Data.Collections.TypeList.Add(new Data.SensorData.MeasureType("CO²", "ppm"));
            Data.Collections.TypeList.Add(new Data.SensorData.MeasureType("Température", "°C"));
            Data.Collections.TypeList.Add(new Data.SensorData.MeasureType("Humidité", "%"));
        }

        private void timerDequeue_Tick(object sender, EventArgs e)
        {
            SerialPortHandler.Reception.DataTreatment();
            tslErrors.Text = SerialPortHandler.Reception.errors + " erreurs";
        }

        private void OpenClosePort(object sender, EventArgs e)
        {
            try
            {
                if (spSensorData.IsOpen)
                {
                    spSensorData.Close();
                    timerDequeue.Enabled = true;
                    ((ToolStripItem)sender).Text = "Open";
                    tslStatus.Text = "Status : Closed";
                }
                else
                {
                    spSensorData.Open();
                    timerDequeue.Enabled = true;
                    ((ToolStripItem)sender).Text = "Close";
                    tslStatus.Text = "Status : Opened";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur de port", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbComPorts_DropDown(object sender, EventArgs e)
        {
            tscbComPorts.Items.Clear();
            tscbComPorts.Items.AddRange(SerialPort.GetPortNames());
        }

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
            }
        }

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
                pSecondaryControl.Controls.Clear();
            }
        }

        private void DockIn(Control control, Panel parent)
        {
            parent.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }

        private void tsbMeasures_Click(object sender, EventArgs e)
        {
            MeasureControl mtc = new MeasureControl();
            MeasureConfigControl mcc = new MeasureConfigControl();
            DataTable dt = mtc.Table;

            ClearPanels();

            mainControl = mtc;
            DockIn(mtc, pMainControl);

            configControl = mcc;
            DockIn(mcc, pSecondaryControl);

            timerDequeue.Tick += mtc.UpdateTick;
        }

        private void tsbAlarms_Click(object sender, EventArgs e)
        {
            ClearPanels();
        }

        private void tsbGraphs_Click(object sender, EventArgs e)
        {
            ClearPanels();
        }

        private void tsbAccounts_Click(object sender, EventArgs e)
        {
            ClearPanels();
        }

        private void tsbConnection_Click(object sender, EventArgs e)
        {
            ClearPanels();
        }

        private void tsbCalibration_Click(object sender, EventArgs e)
        {
            ClearPanels();
        }
    }
}
