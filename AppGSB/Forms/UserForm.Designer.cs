namespace AppGSB.Views
{
    partial class UserForm
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
            tbPassword = new TextBox();
            tbPasswordConfirmation = new TextBox();
            lblPassword = new Label();
            lblPasswordConfirmation = new Label();
            lblPasswordError = new Label();
            lblPasswordConfirmationError = new Label();
            lblUsername = new Label();
            tbUsername = new TextBox();
            lblUsernameError = new Label();
            lblLastname = new Label();
            tbLastname = new TextBox();
            lblFirstname = new Label();
            tbFirstname = new TextBox();
            lblLastnameError = new Label();
            lblFirstnameError = new Label();
            lblEmail = new Label();
            tbEmail = new TextBox();
            lblEmailError = new Label();
            lblSector = new Label();
            tbSector = new TextBox();
            tbSectorError = new Label();
            lblRole = new Label();
            cbRole = new ComboBox();
            lblRoleError = new Label();
            lblCreateUser = new Label();
            btnCancel = new Button();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(31, 296);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(300, 27);
            tbPassword.TabIndex = 0;
            // 
            // tbPasswordConfirmation
            // 
            tbPasswordConfirmation.Location = new Point(371, 296);
            tbPasswordConfirmation.Name = "tbPasswordConfirmation";
            tbPasswordConfirmation.Size = new Size(300, 27);
            tbPasswordConfirmation.TabIndex = 0;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.ForeColor = Color.SteelBlue;
            lblPassword.Location = new Point(33, 273);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(98, 20);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Mot de passe";
            // 
            // lblPasswordConfirmation
            // 
            lblPasswordConfirmation.AutoSize = true;
            lblPasswordConfirmation.ForeColor = Color.SteelBlue;
            lblPasswordConfirmation.Location = new Point(371, 273);
            lblPasswordConfirmation.Name = "lblPasswordConfirmation";
            lblPasswordConfirmation.Size = new Size(210, 20);
            lblPasswordConfirmation.TabIndex = 1;
            lblPasswordConfirmation.Text = "Confirmation du mot de passe";
            // 
            // lblPasswordError
            // 
            lblPasswordError.AutoSize = true;
            lblPasswordError.ForeColor = Color.LightCoral;
            lblPasswordError.Location = new Point(33, 326);
            lblPasswordError.Name = "lblPasswordError";
            lblPasswordError.Size = new Size(50, 20);
            lblPasswordError.TabIndex = 1;
            lblPasswordError.Text = "label1";
            lblPasswordError.Visible = false;
            // 
            // lblPasswordConfirmationError
            // 
            lblPasswordConfirmationError.AutoSize = true;
            lblPasswordConfirmationError.ForeColor = Color.LightCoral;
            lblPasswordConfirmationError.Location = new Point(371, 326);
            lblPasswordConfirmationError.Name = "lblPasswordConfirmationError";
            lblPasswordConfirmationError.Size = new Size(50, 20);
            lblPasswordConfirmationError.TabIndex = 1;
            lblPasswordConfirmationError.Text = "label1";
            lblPasswordConfirmationError.Visible = false;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.ForeColor = Color.SteelBlue;
            lblUsername.Location = new Point(31, 85);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(77, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Identifiant";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(29, 108);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(300, 27);
            tbUsername.TabIndex = 0;
            // 
            // lblUsernameError
            // 
            lblUsernameError.AutoSize = true;
            lblUsernameError.ForeColor = Color.LightCoral;
            lblUsernameError.Location = new Point(31, 138);
            lblUsernameError.Name = "lblUsernameError";
            lblUsernameError.Size = new Size(50, 20);
            lblUsernameError.TabIndex = 1;
            lblUsernameError.Text = "label1";
            lblUsernameError.Visible = false;
            // 
            // lblLastname
            // 
            lblLastname.AutoSize = true;
            lblLastname.ForeColor = Color.SteelBlue;
            lblLastname.Location = new Point(33, 179);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(42, 20);
            lblLastname.TabIndex = 1;
            lblLastname.Text = "Nom";
            // 
            // tbLastname
            // 
            tbLastname.Location = new Point(31, 202);
            tbLastname.Name = "tbLastname";
            tbLastname.Size = new Size(300, 27);
            tbLastname.TabIndex = 0;
            // 
            // lblFirstname
            // 
            lblFirstname.AutoSize = true;
            lblFirstname.ForeColor = Color.SteelBlue;
            lblFirstname.Location = new Point(371, 179);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(60, 20);
            lblFirstname.TabIndex = 1;
            lblFirstname.Text = "Prénom";
            // 
            // tbFirstname
            // 
            tbFirstname.Location = new Point(371, 202);
            tbFirstname.Name = "tbFirstname";
            tbFirstname.Size = new Size(300, 27);
            tbFirstname.TabIndex = 0;
            // 
            // lblLastnameError
            // 
            lblLastnameError.AutoSize = true;
            lblLastnameError.ForeColor = Color.LightCoral;
            lblLastnameError.Location = new Point(33, 232);
            lblLastnameError.Name = "lblLastnameError";
            lblLastnameError.Size = new Size(50, 20);
            lblLastnameError.TabIndex = 1;
            lblLastnameError.Text = "label1";
            lblLastnameError.Visible = false;
            // 
            // lblFirstnameError
            // 
            lblFirstnameError.AutoSize = true;
            lblFirstnameError.ForeColor = Color.LightCoral;
            lblFirstnameError.Location = new Point(371, 232);
            lblFirstnameError.Name = "lblFirstnameError";
            lblFirstnameError.Size = new Size(50, 20);
            lblFirstnameError.TabIndex = 1;
            lblFirstnameError.Text = "label1";
            lblFirstnameError.Visible = false;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = Color.SteelBlue;
            lblEmail.Location = new Point(371, 85);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(371, 108);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(302, 27);
            tbEmail.TabIndex = 0;
            // 
            // lblEmailError
            // 
            lblEmailError.AutoSize = true;
            lblEmailError.ForeColor = Color.LightCoral;
            lblEmailError.Location = new Point(371, 138);
            lblEmailError.Name = "lblEmailError";
            lblEmailError.Size = new Size(50, 20);
            lblEmailError.TabIndex = 1;
            lblEmailError.Text = "label1";
            lblEmailError.Visible = false;
            // 
            // lblSector
            // 
            lblSector.AutoSize = true;
            lblSector.ForeColor = Color.SteelBlue;
            lblSector.Location = new Point(371, 372);
            lblSector.Name = "lblSector";
            lblSector.Size = new Size(58, 20);
            lblSector.TabIndex = 1;
            lblSector.Text = "Secteur";
            // 
            // tbSector
            // 
            tbSector.Location = new Point(371, 395);
            tbSector.Name = "tbSector";
            tbSector.Size = new Size(300, 27);
            tbSector.TabIndex = 0;
            // 
            // tbSectorError
            // 
            tbSectorError.AutoSize = true;
            tbSectorError.ForeColor = Color.LightCoral;
            tbSectorError.Location = new Point(371, 425);
            tbSectorError.Name = "tbSectorError";
            tbSectorError.Size = new Size(50, 20);
            tbSectorError.TabIndex = 1;
            tbSectorError.Text = "label1";
            tbSectorError.Visible = false;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.ForeColor = Color.SteelBlue;
            lblRole.Location = new Point(33, 372);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(39, 20);
            lblRole.TabIndex = 1;
            lblRole.Text = "Role";
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(33, 395);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(300, 28);
            cbRole.TabIndex = 2;
            // 
            // lblRoleError
            // 
            lblRoleError.AutoSize = true;
            lblRoleError.ForeColor = Color.LightCoral;
            lblRoleError.Location = new Point(33, 426);
            lblRoleError.Name = "lblRoleError";
            lblRoleError.Size = new Size(50, 20);
            lblRoleError.TabIndex = 1;
            lblRoleError.Text = "label1";
            lblRoleError.Visible = false;
            // 
            // lblCreateUser
            // 
            lblCreateUser.AutoSize = true;
            lblCreateUser.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            lblCreateUser.ForeColor = Color.Navy;
            lblCreateUser.Location = new Point(29, 29);
            lblCreateUser.Name = "lblCreateUser";
            lblCreateUser.Size = new Size(257, 28);
            lblCreateUser.TabIndex = 1;
            lblCreateUser.Text = "Crée un nouvelle utilisateur :";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Lavender;
            btnCancel.Location = new Point(186, 472);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(145, 50);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Annuler";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.Navy;
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(31, 472);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(145, 50);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Crée";
            btnCreate.UseVisualStyleBackColor = false;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 557);
            Controls.Add(btnCreate);
            Controls.Add(btnCancel);
            Controls.Add(cbRole);
            Controls.Add(lblFirstnameError);
            Controls.Add(lblPasswordConfirmationError);
            Controls.Add(lblUsernameError);
            Controls.Add(lblLastnameError);
            Controls.Add(lblRoleError);
            Controls.Add(tbSectorError);
            Controls.Add(lblEmailError);
            Controls.Add(lblPasswordError);
            Controls.Add(tbFirstname);
            Controls.Add(lblFirstname);
            Controls.Add(tbPasswordConfirmation);
            Controls.Add(lblPasswordConfirmation);
            Controls.Add(tbLastname);
            Controls.Add(tbSector);
            Controls.Add(tbUsername);
            Controls.Add(tbEmail);
            Controls.Add(tbPassword);
            Controls.Add(lblRole);
            Controls.Add(lblSector);
            Controls.Add(lblLastname);
            Controls.Add(lblEmail);
            Controls.Add(lblCreateUser);
            Controls.Add(lblUsername);
            Controls.Add(lblPassword);
            Name = "UserForm";
            Text = "UserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbPassword;
        private TextBox tbPasswordConfirmation;
        private Label lblPassword;
        private Label lblPasswordConfirmation;
        private Label lblPasswordError;
        private Label lblPasswordConfirmationError;
        private Label lblUsername;
        private TextBox tbUsername;
        private Label lblUsernameError;
        private Label lblLastname;
        private TextBox tbLastname;
        private Label lblFirstname;
        private TextBox tbFirstname;
        private Label lblLastnameError;
        private Label lblFirstnameError;
        private Label lblEmail;
        private TextBox tbEmail;
        private Label lblEmailError;
        private Label lblSector;
        private TextBox tbSector;
        private Label tbSectorError;
        private Label lblRole;
        private ComboBox cbRole;
        private Label lblRoleError;
        private Label lblCreateUser;
        private Button btnCancel;
        private Button btnCreate;
    }
}