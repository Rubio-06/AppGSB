using AppGSB.Controllers;
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
    public partial class UsersPanels : UserControl
    {
        public UsersPanels()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            var users = UsersManager.GetAllUsers();
            dgUsers.DataSource = users;

            // hide password column
            dgUsers.Columns["Password"].Visible = false;
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            var userForm = new UserForm();
            if (userForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Utilisateur créé avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
