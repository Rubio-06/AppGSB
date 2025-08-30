namespace AppGSB.Forms
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
            tbLogin = new TextBox();
            tbPassword = new TextBox();
            btnLogin = new Button();
            lblErrorLogin = new Label();
            lblErrorPassword = new Label();
            SuspendLayout();
            // 
            // tbLogin
            // 
            tbLogin.Location = new Point(66, 66);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(199, 27);
            tbLogin.TabIndex = 0;
            tbLogin.TextChanged += tbLogin_TextChanged;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(66, 159);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(199, 27);
            tbPassword.TabIndex = 0;
            tbPassword.TextChanged += tbPassword_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(66, 258);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(199, 29);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblErrorLogin
            // 
            lblErrorLogin.AutoSize = true;
            lblErrorLogin.ForeColor = Color.Red;
            lblErrorLogin.Location = new Point(66, 96);
            lblErrorLogin.Name = "lblErrorLogin";
            lblErrorLogin.Size = new Size(82, 20);
            lblErrorLogin.TabIndex = 2;
            lblErrorLogin.Text = "Error Login";
            // 
            // lblErrorPassword
            // 
            lblErrorPassword.AutoSize = true;
            lblErrorPassword.ForeColor = Color.Red;
            lblErrorPassword.Location = new Point(66, 189);
            lblErrorPassword.Name = "lblErrorPassword";
            lblErrorPassword.Size = new Size(106, 20);
            lblErrorPassword.TabIndex = 2;
            lblErrorPassword.Text = "Error Password";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 327);
            Controls.Add(lblErrorPassword);
            Controls.Add(lblErrorLogin);
            Controls.Add(btnLogin);
            Controls.Add(tbPassword);
            Controls.Add(tbLogin);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbLogin;
        private TextBox tbPassword;
        private Button btnLogin;
        private Label lblErrorLogin;
        private Label lblErrorPassword;
    }
}