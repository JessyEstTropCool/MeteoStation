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
    public partial class AccountControl : UserControl
    {
        internal event EventHandler ButtonClickRegister;
        internal event EventHandler ButtonClickClear;


        internal DataTable dataUsersAccounts = new DataTable();        

        public AccountControl()
        {
            InitializeComponent();

      

            
            
     

          
        }

        private void AccountControl_Load(object sender, EventArgs e)
        {

        }
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            ButtonClickRegister(sender, e);

        }

        //si l'utilisateur clique sur le btn clear
        //on supp tous les champs et on focus sur le textBox tout en haut
        private void buttonClear_Click(object sender, EventArgs e)
        {

            ButtonClickClear(sender, e);

        }
    }
}
