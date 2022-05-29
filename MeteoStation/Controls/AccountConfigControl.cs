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
        internal event EventHandler ButtonClickRegister;
        internal event EventHandler ButtonClickClear;

        string username { get; set; }
        string password { get; set; }

        public AccountConfigControl()
        {
            InitializeComponent();
           
        }

        private void AccountConfigControl_Load(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            ButtonClickRegister(sender, e);

        }

        //si l'utilisateur clique sur le btn clear
        //on supp tous les champs et on focus sur le textBox tout en haut
        private void buttonClear_Click_1(object sender, EventArgs e)
        {

            ButtonClickClear(sender, e);

        }

        //méthode qui permet de supprimer les saisies de l'utilisateur se trouvant dans les textBoxs
        private void clearTextBox(TextBox txtb)
        {
            txtb.Clear();
        }

      
      

        //méthode qui nous permet de remplacés en cachant/affichant les caractères des mdp
        private void textBoxHidePasswordByAChar(TextBox txtbox, Char caractere)
        {
            txtbox.PasswordChar = caractere;
        }

      /*  private void checkBoxShowPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            //si l'user veut voir son mdp, on lui montre
            if (checkBoxShowPassword.Checked)
            {
                textBoxHidePasswordByAChar(textBoxPassword, '\0');
                textBoxHidePasswordByAChar(textBoxConfirmPassword, '\0');


            }
            //sinon, les caractères seront remplacés et affichés de la manière ci-dessous
            else
            {
                textBoxHidePasswordByAChar(textBoxPassword, '•');
                textBoxHidePasswordByAChar(textBoxConfirmPassword, '•');


            }
        }*/

        bool ifRegisterButtonIsClicked(bool ok)
        {
            return true;
        }

        private void Rights_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
