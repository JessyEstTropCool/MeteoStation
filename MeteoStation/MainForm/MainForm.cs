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

namespace MeteoStation
{
    public partial class MainForm : Form
    {
        DataTable dt;

        public MainForm()
        {
            InitializeComponent();

            spSensorData.DataReceived += new SerialDataReceivedEventHandler(SerialPortHandler.Reception.RecieveData);

            dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("CONFIG");
            dt.Columns.Add("TYPE");
            dt.Columns.Add("DATA");
            dt.Columns.Add("UPDATE");
            dt.Columns.Add("ALARM");
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
            SerialPortHandler.Reception.DataTreatment(this, gMeasures, dt);

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

        private void ClearTable(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            gMeasures.DataSource = dt;

            Data.Collections.ObjectList.Clear();
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
                spSensorData.PortName = tscbComPorts.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur de port", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tscbComPorts.SelectedText = spSensorData.PortName;
            }
        }
    }
}
