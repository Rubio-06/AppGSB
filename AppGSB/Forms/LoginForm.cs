using AppGSB.Data;
using AppGSB.Utils;

namespace AppGSB.Forms
{
    public partial class LoginForm : Form
    {
        private readonly AppDbContext _context;

        public LoginForm(AppDbContext context)
        {
            InitializeComponent();
            _context = context;

            lblErrorLogin.Text = "";
            lblErrorPassword.Text = "";
            btnLogin.Enabled = false;
        }

        public void ValidateInputs()
        {
            bool isLoginValid = Validator.IsValidLogin(tbLogin.Text);
            lblErrorLogin.Text = isLoginValid 
                ? "" 
                : "Le format de l'identifiant est incorrect";

            bool isPasswordValid = Validator.IsValidPassword(tbPassword.Text);
            lblErrorPassword.Text = isPasswordValid 
                ? "" 
                : "Le format du mot de passe est incorect";

            btnLogin.Enabled = isLoginValid && isPasswordValid;
        }

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = tbLogin.Text;
            string password = tbPassword.Text;

            // Final Validation
            if (!Validator.IsValidLogin(login) || !Validator.IsValidPassword(password))
            {
                MessageBox.Show("Le format de l'identifiant ou du mot de passe est incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Search User
            var user = _context.Users.FirstOrDefault(u => u.Login == login);

            // Verify Password & User Existence
            if (user == null || !HashHelper.VerifyPassword(password, user.PasswordHash))
            {
                MessageBox.Show("Identifiant ou mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 
            else
            {
                MessageBox.Show($"Bienvenue, {user.FullName} ({user.Role})!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form mainForm = new MainForm(_context, user);

                this.Hide();
                mainForm.ShowDialog();
                this.Close();
            }
        }
    }
}
