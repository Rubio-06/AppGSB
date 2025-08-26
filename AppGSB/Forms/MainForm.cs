using AppGSB.Models;
using AppGSB.Controllers;
using AppGSB.Views;

namespace AppGSB
{
    public partial class MainForm : Form
    {
        private User _user;

        public MainForm(User user)
        {
            InitializeComponent();
            _user = user;
            ApplyRight();
        }

        // ----- General Methods ----- //
        private void ApplyRight()
        {
            // dashboard
            dashboardMenu.Visible = _user.Role == UserRole.Admin;

            // expenses
            expensesMenu.Visible = _user.Role == UserRole.Guest;
        }

        private void showPanel(UserControl panel)
        {
            panelContainer.Controls.Clear();
            panel.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(panel);
        }

        // ----- Account Menu ----- //

        // logout
        private void logoutAccountItem_Click(object sender, EventArgs e)
        {
            AppGSB.Controllers.UsersManager.Logout(this);
        }

        //quit
        private void quitAccountItem_Click(object sender, EventArgs e)
        {

        }

        // ----- Dashboard Menu ----- //
        private void usersDashboardItem_Click(object sender, EventArgs e)
        {
            showPanel(new UsersPanels());
        }

        private void newDashboardItem_Click(object sender, EventArgs e)
        {
            var userForm = new UserForm();
            if (userForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Utilisateur créé avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
