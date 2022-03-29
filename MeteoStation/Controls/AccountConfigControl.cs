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
        public AccountConfigControl()
        {
            InitializeComponent();
        }

        private void AccountConfigControl_Load(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            //si les textBoxs sont vides, on affiche un msg d'erreur
            if (textBoxUsername.Text == "" || textBoxPassword.Text == "" || textBoxConfirmPassword.Text == "")
            {
                MessageBox.Show("Username or Password field is empty", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //si les mdp ne sont pas les memes, on affiche un msg d'erreur
            else if (textBoxPassword.Text != textBoxConfirmPassword.Text)
            {
                MessageBox.Show("Paswords does not match, Please Re-enter ", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearTextBox(textBoxPassword);
                clearTextBox(textBoxConfirmPassword);
                textBoxPassword.Focus();
            }
            //sinon on affiche un message de success
            else
            {
                MessageBox.Show("Your Account has been Successfully Created", "Registration Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //on ajoute les noms d'user ainsi que les mdp entré par le user dans la table
                //table.Rows.Add(textBoxUsername.Text, textBoxPassword.Text);

                //on l'ajoute ensuite dans le gried
                //dataGridView1.DataSource = table;

                //on supprime les texts qui ont été entrés dans les textBoxs
                clearTextBox(textBoxUsername);
                clearTextBox(textBoxConfirmPassword);
                clearTextBox(textBoxPassword);


            }

        }

        //si l'utilisateur clique sur le btn clear
        //on supp tous les champs et on focus sur le textBox tout en haut
        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            clearTextBox(textBoxUsername);
            clearTextBox(textBoxConfirmPassword);
            clearTextBox(textBoxPassword);
            textBoxUsername.Focus();
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

        private void checkBoxShowPassword_CheckedChanged_1(object sender, EventArgs e)
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
        }
    }
}
