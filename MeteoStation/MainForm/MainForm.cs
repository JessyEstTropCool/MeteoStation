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

        AccountConfigControl myAccount = new AccountConfigControl();

        AccountControl AccountControl = new AccountControl();

        DataTable myTable = new DataTable();

        public MainForm()
        {
            InitializeComponent();

            AccountControl.dataUsersAccounts.Columns.Add("Username", typeof(string));
            AccountControl.dataUsersAccounts.Columns.Add("Password", typeof(string));

            AccountControl.dataGridViewAccount.DataSource = AccountControl.dataUsersAccounts;

            tsslPrompt.Text = "";

            spSensorData.DataReceived += new SerialDataReceivedEventHandler(SerialPortHandler.Reception.RecieveData);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Dans le futur a prendre d'un fichier voire la db
            Data.Collections.TypeDict.Add(1, new Data.SensorData.MeasureType("CO²", "ppm"));
            Data.Collections.TypeDict.Add(2, new Data.SensorData.MeasureType("Température", "°C"));
            Data.Collections.TypeDict.Add(3, new Data.SensorData.MeasureType("Humidité", "%"));

            if (SerialPort.GetPortNames().Length > 0)
            {
                spSensorData.PortName = SerialPort.GetPortNames()[0];

                tscbComPorts.Items.Add(SerialPort.GetPortNames()[0]);
                tscbComPorts.SelectedIndex = 0;
            }

            //Affiche les controles de mesures des le début
            tsbMeasures.PerformClick();

            ShowPrompt("Welcome !", 5);
        }

        internal void ShowPrompt(string text, int length)
        {
            tsslPrompt.Text = text;

            Task.Delay(length*1000).ContinueWith(t => tsslPrompt.Text = "");
        }

        //Handler du timer responsable du traitement des données
        private void timerDequeue_Tick(object sender, EventArgs e)
        {
            //Traitement des données toutes les secondes
            if (spSensorData.IsOpen)
            {
                SerialPortHandler.Reception.DataTreatment();
                tsslErrors.Text = SerialPortHandler.Reception.errors + " errors";
            }

            tsslTemps.Text = DateTime.Now.ToString("F");
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

        private void SetHeader(object sender)
        {
            ToolStripItem tsi = (ToolStripItem)sender;

            pbIcon.Image = tsi.Image;
            lTitle.Text = tsi.Text;
        }

        //Met les controles de mesures
        private void tsbMeasures_Click(object sender, EventArgs e)
        {
            MeasureControl mtc = new MeasureControl();
            MeasureConfigControl mcc = new MeasureConfigControl();

            SetHeader(sender);
            ClearPanels();

            SetMainControl(mtc);
            SetConfigControl(mcc);

            timerDequeue.Tick += mtc.UpdateTick;

            mcc.ConfigDone += Data.Collections.MeasureBasicConfigDone;
            mcc.ConfigDone += mtc.UpdateTick;

            mcc.DropDown += Data.Collections.MeasureConfigDropDown;
            mcc.DropDownClosed += Data.Collections.MeasureConfigDropDownClosed;
        }

        //Met les controles d'alarmes
        private void tsbAlarms_Click(object sender, EventArgs e)
        {
            AlarmControl ac = new AlarmControl();
            AlarmConfigControl acc = new AlarmConfigControl();

            SetHeader(sender);
            ClearPanels();

            SetMainControl(ac);
            SetConfigControl(acc);

            timerDequeue.Tick += ac.UpdateTick;

            acc.ConfigDone += Data.Collections.MeasureAlarmConfigDone;
            acc.ConfigDone += ac.UpdateTick;

            acc.DropDown += Data.Collections.AlarmConfigDropDown;
            acc.DropDownClosed += Data.Collections.AlarmConfigDropDownClosed;
        }

        //Met les controles de graphiques
        private void tsbGraphs_Click(object sender, EventArgs e)
        {
            SetHeader(sender);
            ClearPanels();
        }

        //Met les controles de comptes
        private void tsbAccounts_Click(object sender, EventArgs e)
        {
            //Attention on peut l'ouvrir qu'une fois car le clearPanels détruit tout
            SetHeader(sender);
            ClearPanels();
            SetMainControl(AccountControl);

            myAccount.ButtonClickRegister += new EventHandler(Register_Click);
            myAccount.ButtonClickClear += new EventHandler(Clear_Click);
            SetConfigControl(myAccount);
        }

        //Met les controles de connection
        private void tsbConnection_Click(object sender, EventArgs e)
        {
            SetHeader(sender);
            ClearPanels();
        }

        //Met les controles de calibration
        private void tsbCalibration_Click(object sender, EventArgs e)
        {
            SetHeader(sender);
            ClearPanels();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            ////si les textBoxs sont vides, on affiche un msg d'erreur
            if (myAccount.textBoxUsername.Text == "" || myAccount.textBoxPassword.Text == "" || myAccount.textBoxConfirmPassword.Text == "")
            {
                MessageBox.Show("Username or Password field is empty", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ////si les mdp ne sont pas les memes, on affiche un msg d'erreur
            else if (myAccount.textBoxPassword.Text != myAccount.textBoxConfirmPassword.Text)
            {
                MessageBox.Show("Paswords does not match, Please Re-enter ", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearTextBox(myAccount.textBoxPassword);
                clearTextBox(myAccount.textBoxConfirmPassword);
                myAccount.textBoxPassword.Focus();
            }
            ////sinon on affiche un message de success
            else
            {
              
                MessageBox.Show("Your Account has been Successfully Created", "Registration Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                updateDGV(AccountControl.dataUsersAccounts, AccountControl.dataGridViewAccount, myAccount.textBoxUsername.Text, myAccount.textBoxPassword.Text);

                //on supprime les texts qui ont été entrés dans les textBoxs
                clearTextBox(myAccount.textBoxUsername);
                clearTextBox(myAccount.textBoxConfirmPassword);
                clearTextBox(myAccount.textBoxPassword);
                myAccount.textBoxUsername.Focus();


            }
        }



        //si l'utilisateur clique sur le btn clear du user Control Account
        //on supp tous les champs et on focus sur le textBox tout en haut
        public void Clear_Click(object sender, EventArgs e)
        {

            clearTextBox(myAccount.textBoxUsername);
            clearTextBox(myAccount.textBoxConfirmPassword);
            clearTextBox(myAccount.textBoxPassword);
            myAccount.textBoxUsername.Focus();
        }
        //méthode qui permet de supprimer les saisies de l'utilisateur se trouvant dans les textBoxs du user control Account
        private void clearTextBox(TextBox txtb)
        {
            txtb.Clear();
        }

        //méthode qui nous permet de remplacés en cachant/affichant les caractères des mdp
        private void textBoxHidePasswordByAChar(TextBox txtbox, Char caractere)
        {
            txtbox.PasswordChar = caractere;
        }

        private void updateDGV(DataTable dt, DataGridView dgv,string username, string password)
        {
            
            dt.Rows.Add(username,password);
            dgv.Refresh();
            dgv.DataSource = dt;
        }
    }

    }
