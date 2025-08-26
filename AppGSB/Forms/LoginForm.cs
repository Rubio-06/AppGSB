using AppGSB.Controllers;
using AppGSB.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGSB.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            UpdateLoginButtonState();
        }

        // handle fields changes
        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            bool isValid = InputValidator.IsValidUsername(tbUsername.Text, lblUsernameError);
            UpdateLoginButtonState();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            bool isValid = InputValidator.IsValidPassword(tbPassword.Text, lblPasswordError);
            UpdateLoginButtonState();
        }

        // handle login button
        private void UpdateLoginButtonState()
        {
            bool isUsernameValid = InputValidator.IsValidUsername(tbUsername.Text, lblUsernameError);
            bool isPasswordValid = InputValidator.IsValidPassword(tbPassword.Text, lblPasswordError);

            btnLogin.Enabled = isUsernameValid && isPasswordValid;
            btnLogin.BackColor = btnLogin.Enabled ? Color.Navy : Color.Lavender;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();

            if (UsersManager.Login(login, password))
            {
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Identifiant ou mot de passe invalide.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
