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

        public static DataSet UserAccess;

        public DataTable UserTable;
        internal DataColumn User_ID;
        internal DataColumn Username;
        internal DataColumn UserPassword;
        internal DataColumn Access_Type;

        internal DataTable AccessTable;
        internal DataColumn Access_ID;
        internal DataColumn AccessName;
        internal DataColumn CreateID;
        internal DataColumn DestroyID;
        internal DataColumn ConfigAlarm;
        internal DataColumn CreateUser;




        Control mainControl = null, configControl = null;

        AccountConfigControl myAccount ;

        AccountControl AccountControl ;

        public MainForm()
        {
            InitializeComponent();


            UserAccess = new DataSet(); // DB

            UserTable = new DataTable(); // Table
            User_ID = new DataColumn("ID", System.Type.GetType("System.Int16"));
            Username = new DataColumn("Name", System.Type.GetType("System.String"));
            UserPassword = new DataColumn("Password", System.Type.GetType("System.String"));
            Access_Type = new DataColumn("Access type", System.Type.GetType("System.Int16"));

            AccessTable = new DataTable(); // Table
            Access_ID = new DataColumn("ID", System.Type.GetType("System.Int16"));
            AccessName = new DataColumn("Name", System.Type.GetType("System.String"));
            CreateID = new DataColumn("Create ID", System.Type.GetType("System.Boolean"));
            DestroyID = new DataColumn("Destroy ID", System.Type.GetType("System.Boolean"));
            ConfigAlarm = new DataColumn("Config Alarms", System.Type.GetType("System.Boolean"));
            CreateUser = new DataColumn("Create User", System.Type.GetType("System.Boolean"));

            

            /* UserTable*/
            UserTable.TableName = "Users";
            User_ID.Unique = true;
            User_ID.AutoIncrement = true;
            UserTable.Columns.Add(User_ID);

            Username.Unique = true;
            UserTable.Columns.Add(Username);

            UserPassword.Unique = false;
            UserTable.Columns.Add(UserPassword);

            Access_Type.Unique = false;
            UserTable.Columns.Add(Access_Type);

            /* Access*/
            AccessTable.TableName = "Access";
            Access_ID.Unique = true;
            Access_ID.AutoIncrement = true;
            AccessTable.Columns.Add(Access_ID);

            AccessName.Unique = true;
            AccessTable.Columns.Add(AccessName);

            CreateID.Unique = false;
            AccessTable.Columns.Add(CreateID);

            DestroyID.Unique = false;
            AccessTable.Columns.Add(DestroyID);

            ConfigAlarm.Unique = false;
            AccessTable.Columns.Add(ConfigAlarm);

            CreateUser.Unique = false;
            AccessTable.Columns.Add(CreateUser);

            /* Dataset & Datarelation*/
            UserAccess.Tables.Add(UserTable);
            UserAccess.Tables.Add(AccessTable);

            DataColumn parentColumn = UserAccess.Tables["Access"].Columns["ID"];
            DataColumn childColumn = UserAccess.Tables["Users"].Columns["Access type"];

            DataRelation relation = new DataRelation("Access2User", parentColumn, childColumn);

            UserAccess.Tables["Users"].ParentRelations.Add(relation);

            UserAccess.Tables["Access"].Rows.Add(new object[] { 1, "AdminRights", true, true, true, true });
            UserAccess.Tables["Access"].Rows.Add(new object[] { 2, "MasterRights", true, true, true, false });
            UserAccess.Tables["Access"].Rows.Add(new object[] { 3, "UserRights", false, false, false, false });


            UserAccess.Tables["Users"].Rows.Add(new object[] { 1, "Abdou", "Password", 3 });

            /*Rights box*/
            //myAccount.Rights_box.DataSource = UserAccess.Tables["Access"];
            //myAccount.Rights_box.ValueMember = "ID";
            //myAccount.Rights_box.DisplayMember = "Name";



            tsslPrompt.Text = "";

            Files.ConfigFiles.LoadConfigs();
            Task.Run(() => Data.WebConnection.GetNewToken());

            spSensorData.DataReceived += new SerialDataReceivedEventHandler(SerialPortHandler.Reception.RecieveData);
            timerDequeue.Tick += new System.EventHandler(Data.WebConnection.SendDataToServer);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //En attendant de récupérer les types de la db on a déjà ceux du cahier de charges
            Data.Collections.TypeDict.Add(1, new Data.SensorData.MeasureType("CO²", "ppm"));
            Data.Collections.TypeDict.Add(2, new Data.SensorData.MeasureType("Température", "°C"));
            Data.Collections.TypeDict.Add(3, new Data.SensorData.MeasureType("Humidité", "%"));

            Task.Run(() => Data.WebConnection.GetTypes()); 

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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Files.ConfigFiles.SaveConfigs();
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

        //Envoie le signal pour la sauvegarde du fichier de configuration
        private void tsmiSave_Click(object sender, EventArgs e)
        {
            Files.ConfigFiles.SaveConfigs(); 
            ShowPrompt("Le fichier a été enregistré", 5);
        }

        //Demande l'exportation de la configuration là ou l'utilisateur le demande avec sfdSaveConfig
        private void tsmiExport_Click(object sender, EventArgs e)
        {
            sfdSaveConfig.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            sfdSaveConfig.FileName = "*.csv";

            if (sfdSaveConfig.ShowDialog() == DialogResult.OK)
            {
                Files.ConfigFiles.ExportConfigs(sfdSaveConfig.FileName);
                ShowPrompt("Le fichier a été exporté", 5);
            }
        }

        private void tsmiImport_Click(object sender, EventArgs e)
        {
            ofdLoadConfig.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofdLoadConfig.FileName = "";

            if (ofdLoadConfig.ShowDialog() == DialogResult.OK )
            {
                Files.ConfigFiles.ImportConfigs(ofdLoadConfig.FileName);
                ShowPrompt("Les configurations ont été appliquées", 5);
            }
        }

        //Envoi le signal pour la suppression de la confguration
        private void tsmiReset_Click(object sender, EventArgs e)
        {
            Files.ConfigFiles.ClearConfigs();
        }

        //Affiche les informations concernant une mesure
        private void ShowMeasureInfo(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;

            string message = Data.Collections.GetMeasureInfo( int.Parse( (string)((DataTable)grid.DataSource).Rows[e.RowIndex]["ID"] ) );

            MessageBox.Show(message, "Info");
        }

        private static void ChangeAddress(object sender, EventArgs e)
        {
            ConnectionConfigControl ccc = (ConnectionConfigControl)sender;

            Data.WebConnection.SetAddress(ccc.State);
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

        //Modifie le header du grand panel pour montrer le controle ouvert
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

            mtc.RowClick += ShowMeasureInfo;

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

            ac.RowClick += ShowMeasureInfo;

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
            myAccount = new AccountConfigControl();
            AccountControl = new AccountControl();

            AccountControl.dataUsersAccounts.Columns.Add("Username", typeof(string));
            AccountControl.dataUsersAccounts.Columns.Add("Password", typeof(string));

            AccountControl.dataGridViewAccount.DataSource = AccountControl.dataUsersAccounts;
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
            ConnectionControl cc = new ConnectionControl();
            ConnectionConfigControl ccc = new ConnectionConfigControl();

            SetHeader(sender);
            ClearPanels();

            SetMainControl(cc);
            SetConfigControl(ccc);

            cc.RowClick += ShowMeasureInfo;

            timerDequeue.Tick += cc.FetchInfo;

            ccc.StateChanged += ChangeAddress;
            ccc.StateChanged += cc.FetchInfo;
        }

        //Met les controles de calibration
        private void tsbCalibration_Click(object sender, EventArgs e)
        {
            SetHeader(sender);
            ClearPanels();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            //////si les textBoxs sont vides, on affiche un msg d'erreur
            //if (myAccount.textBoxUsername.Text == "" || myAccount.textBoxPassword.Text == "" || myAccount.textBoxConfirmPassword.Text == "")
            //{
            //    MessageBox.Show("Username or Password field is empty", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //////si les mdp ne sont pas les memes, on affiche un msg d'erreur
            //else if (myAccount.textBoxPassword.Text != myAccount.textBoxConfirmPassword.Text)
            //{
            //    MessageBox.Show("Paswords does not match, Please Re-enter ", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    clearTextBox(myAccount.textBoxPassword);
            //    clearTextBox(myAccount.textBoxConfirmPassword);
            //    myAccount.textBoxPassword.Focus();
            //}
            //////sinon on affiche un message de success
            //else
            //{

            //    MessageBox.Show("Your Account has been Successfully Created", "Registration Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    updateDGV(AccountControl.dataUsersAccounts, AccountControl.dataGridViewAccount, myAccount.textBoxUsername.Text, myAccount.textBoxPassword.Text);

            //    //on supprime les texts qui ont été entrés dans les textBoxs
            //    clearTextBox(myAccount.textBoxUsername);
            //    clearTextBox(myAccount.textBoxConfirmPassword);
            //    clearTextBox(myAccount.textBoxPassword);
            //    myAccount.textBoxUsername.Focus();


            //}
            try
            {
                UserAccess.Tables[0].Rows.Add(new object[] { null, myAccount.textBoxUsername.Text, myAccount.textBoxPassword.Text, myAccount.Rights_box.SelectedValue });

                myAccount.Rights_box.ResetText();
                clearTextBox(myAccount.textBoxUsername);
                clearTextBox(myAccount.textBoxConfirmPassword);
                clearTextBox(myAccount.textBoxPassword);

                AccountControl.dataGridViewAccount.DataSource = UserAccess.Tables["Users"];
                AccountControl.dataGridViewRights.DataSource = AccessTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
