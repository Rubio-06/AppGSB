namespace AppGSB.Views
{
    partial class UsersPanels
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            dgUsers = new DataGridView();
            btnNewUser = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgUsers).BeginInit();
            SuspendLayout();
            // 
            // dgUsers
            // 
            dgUsers.AllowUserToAddRows = false;
            dgUsers.AllowUserToDeleteRows = false;
            dgUsers.BackgroundColor = Color.WhiteSmoke;
            dgUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUsers.Location = new Point(3, 60);
            dgUsers.Name = "dgUsers";
            dgUsers.ReadOnly = true;
            dgUsers.RowHeadersWidth = 51;
            dgUsers.Size = new Size(1046, 449);
            dgUsers.TabIndex = 0;
            // 
            // btnNewUser
            // 
            btnNewUser.BackColor = Color.Navy;
            btnNewUser.ForeColor = Color.White;
            btnNewUser.Location = new Point(880, 3);
            btnNewUser.Name = "btnNewUser";
            btnNewUser.Size = new Size(169, 51);
            btnNewUser.TabIndex = 1;
            btnNewUser.Text = "Ajouter un utilisateur";
            btnNewUser.UseVisualStyleBackColor = false;
            btnNewUser.Click += btnNewUser_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(185, 28);
            label1.TabIndex = 2;
            label1.Text = "Liste des utilisateurs";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(3, 11);
            label2.Name = "label2";
            label2.Size = new Size(194, 28);
            label2.TabIndex = 2;
            label2.Text = "Liste des utilisateurs :";
            // 
            // UsersPanels
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnNewUser);
            Controls.Add(dgUsers);
            Name = "UsersPanels";
            Size = new Size(1052, 512);
            ((System.ComponentModel.ISupportInitialize)dgUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgUsers;
        private Button btnNewUser;
        private Label label1;
        private Label label2;
    }
}
