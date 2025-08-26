using AppGSB.Views;
using AppGSB.Models;
using System.Windows.Forms;
using AppGSB.Manager;

namespace AppGSB
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            try
            {
                // Try database connection
                DatabaseManager.GetConnection();
                
                // Login Form
                var loginForm = new LoginForm();
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    var user = Controllers.UsersManager.ConnectedUser;
                    if (user != null)
                    {
                        Application.Run(new MainForm(user));
                    }
                    else
                    {
                        MessageBox.Show("Login failed. Please try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur est survenue : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
