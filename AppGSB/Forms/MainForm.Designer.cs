namespace AppGSB
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            testToolStripMenuItem = new ToolStripMenuItem();
            fichierToolStripMenuItem = new ToolStripMenuItem();
            menu = new MenuStrip();
            accountMenu = new ToolStripMenuItem();
            logoutAccountItem = new ToolStripMenuItem();
            quitAccountItem = new ToolStripMenuItem();
            dashboardMenu = new ToolStripMenuItem();
            usersDashboardItem = new ToolStripMenuItem();
            newDashboardItem = new ToolStripMenuItem();
            expensesMenu = new ToolStripMenuItem();
            newExpenseItem = new ToolStripMenuItem();
            consultExpenseItem = new ToolStripMenuItem();
            panelContainer = new Panel();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // testToolStripMenuItem
            // 
            testToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fichierToolStripMenuItem });
            testToolStripMenuItem.Name = "testToolStripMenuItem";
            testToolStripMenuItem.Size = new Size(47, 24);
            testToolStripMenuItem.Text = "test";
            // 
            // fichierToolStripMenuItem
            // 
            fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            fichierToolStripMenuItem.Size = new Size(135, 26);
            fichierToolStripMenuItem.Text = "Fichier";
            // 
            // menu
            // 
            menu.BackColor = Color.Navy;
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { accountMenu, dashboardMenu, expensesMenu });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(1053, 28);
            menu.TabIndex = 0;
            menu.Text = "menuStrip1";
            // 
            // accountMenu
            // 
            accountMenu.BackColor = Color.SteelBlue;
            accountMenu.DropDownItems.AddRange(new ToolStripItem[] { logoutAccountItem, quitAccountItem });
            accountMenu.ForeColor = Color.White;
            accountMenu.Name = "accountMenu";
            accountMenu.Size = new Size(76, 24);
            accountMenu.Text = "Compte";
            // 
            // logoutAccountItem
            // 
            logoutAccountItem.Name = "logoutAccountItem";
            logoutAccountItem.Size = new Size(194, 26);
            logoutAccountItem.Text = "Se déconnecter";
            logoutAccountItem.Click += logoutAccountItem_Click;
            // 
            // quitAccountItem
            // 
            quitAccountItem.Name = "quitAccountItem";
            quitAccountItem.Size = new Size(194, 26);
            quitAccountItem.Text = "Quitter";
            quitAccountItem.Click += quitAccountItem_Click;
            // 
            // dashboardMenu
            // 
            dashboardMenu.DropDownItems.AddRange(new ToolStripItem[] { usersDashboardItem, newDashboardItem });
            dashboardMenu.ForeColor = Color.White;
            dashboardMenu.Name = "dashboardMenu";
            dashboardMenu.Size = new Size(131, 24);
            dashboardMenu.Text = "Tableau de bord";
            // 
            // usersDashboardItem
            // 
            usersDashboardItem.Name = "usersDashboardItem";
            usersDashboardItem.Size = new Size(220, 26);
            usersDashboardItem.Text = "Utilisateurs";
            usersDashboardItem.Click += usersDashboardItem_Click;
            // 
            // newDashboardItem
            // 
            newDashboardItem.Name = "newDashboardItem";
            newDashboardItem.Size = new Size(220, 26);
            newDashboardItem.Text = "Nouvelle utilisateur";
            newDashboardItem.Click += newDashboardItem_Click;
            // 
            // expensesMenu
            // 
            expensesMenu.DropDownItems.AddRange(new ToolStripItem[] { newExpenseItem, consultExpenseItem });
            expensesMenu.ForeColor = Color.White;
            expensesMenu.Name = "expensesMenu";
            expensesMenu.Size = new Size(116, 24);
            expensesMenu.Text = "Fiches de frais";
            // 
            // newExpenseItem
            // 
            newExpenseItem.Name = "newExpenseItem";
            newExpenseItem.Size = new Size(216, 26);
            newExpenseItem.Text = "nouvelle fiche";
            // 
            // consultExpenseItem
            // 
            consultExpenseItem.Name = "consultExpenseItem";
            consultExpenseItem.Size = new Size(216, 26);
            consultExpenseItem.Text = "consulter les fiches";
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 28);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1053, 501);
            panelContainer.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 529);
            Controls.Add(panelContainer);
            Controls.Add(menu);
            MainMenuStrip = menu;
            Name = "MainForm";
            Text = "GSB - Application";
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem testToolStripMenuItem;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private MenuStrip menu;
        private ToolStripMenuItem dashboardMenu;
        private ToolStripMenuItem usersDashboardItem;
        private ToolStripMenuItem expensesMenu;
        private ToolStripMenuItem newExpenseItem;
        private ToolStripMenuItem consultExpenseItem;
        private ToolStripMenuItem accountMenu;
        private ToolStripMenuItem logoutAccountItem;
        private ToolStripMenuItem quitAccountItem;
        private Panel panelContainer;
        private ToolStripMenuItem newDashboardItem;
    }
}
