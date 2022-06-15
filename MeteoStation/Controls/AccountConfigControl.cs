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

    public partial class AccountConfigControl : UserControl
    {
        
        internal event EventHandler ButtonClickLogin;
        internal event EventHandler ButtonClickLogout;


        string username { get; set; }
        string password { get; set; }

        public AccountConfigControl()
        {
            InitializeComponent();
           
        }

        private void AccountConfigControl_Load(object sender, EventArgs e)
        {

        }

             
     
        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            this.ButtonClickLogin(sender, e);
        }

        private void buttonDeconnexion_Click(object sender, EventArgs e)
        {
            this.ButtonClickLogout(sender, e);
        }
    }
}
