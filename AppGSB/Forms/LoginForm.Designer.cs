namespace AppGSB.Views
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            lblUsernameError = new Label();
            lblPasswordError = new Label();
            lblPassword = new Label();
            btnLogin = new Button();
            lblUsername = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(lblUsernameError);
            panel1.Controls.Add(lblPasswordError);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(tbUsername);
            panel1.Controls.Add(tbPassword);
            panel1.Location = new Point(38, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 257);
            panel1.TabIndex = 0;
            // 
            // lblUsernameError
            // 
            lblUsernameError.AutoSize = true;
            lblUsernameError.ForeColor = Color.LightCoral;
            lblUsernameError.Location = new Point(17, 68);
            lblUsernameError.Name = "lblUsernameError";
            lblUsernameError.Size = new Size(227, 20);
            lblUsernameError.TabIndex = 2;
            lblUsernameError.Text = "L'identifiant comporte une erreur";
            lblUsernameError.Visible = false;
            // 
            // lblPasswordError
            // 
            lblPasswordError.AutoSize = true;
            lblPasswordError.ForeColor = Color.LightCoral;
            lblPasswordError.Location = new Point(17, 153);
            lblPasswordError.Name = "lblPasswordError";
            lblPasswordError.Size = new Size(257, 20);
            lblPasswordError.TabIndex = 2;
            lblPasswordError.Text = "Le mot de passe comporte une erreur";
            lblPasswordError.Visible = false;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.ForeColor = Color.SteelBlue;
            lblPassword.Location = new Point(17, 100);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(98, 20);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Mot de passe";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Navy;
            btnLogin.Enabled = false;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(17, 191);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(301, 50);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Se connecter";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.ForeColor = Color.SteelBlue;
            lblUsername.Location = new Point(17, 15);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(77, 20);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Identifiant";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(17, 38);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(301, 27);
            tbUsername.TabIndex = 1;
            tbUsername.TextChanged += tbUsername_TextChanged;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(17, 123);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(301, 27);
            tbPassword.TabIndex = 1;
            tbPassword.UseSystemPasswordChar = true;
            tbPassword.TextChanged += tbPassword_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(38, 41);
            label1.Name = "label1";
            label1.Size = new Size(279, 46);
            label1.TabIndex = 1;
            label1.Text = "Application GSB";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(752, 494);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "GSB - Connexion";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Button btnLogin;
        private Label lblUsernameError;
        private Label lblPasswordError;
        private Label lblPassword;
        private Label lblUsername;
        private Label label1;
    }
}