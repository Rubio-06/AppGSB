using System.Windows.Forms;
using AppGSB.Models;
using AppGSB.Utils;
using AppGSB.UI.MenuActions;
using AppGSB.Data;

namespace AppGSB.UI;

public static class MenuBuilder
{
    public static MenuStrip Build(User user, AppDbContext context, Form mainForm)
    {
        var menu = new MenuStrip();

        // Account Menu
        var accountMenu = new ToolStripMenuItem("Compte");
        
        var profileItem = new ToolStripMenuItem("Mon profil");
        profileItem.Click += (sender, e) => AccountMenuActions.ShowProfile(user, mainForm);
        accountMenu.DropDownItems.Add(profileItem);

        var logoutItem = new ToolStripMenuItem("Se déconnecter");
        logoutItem.Click += (sender, e) => AccountMenuActions.Logout(context, mainForm);
        accountMenu.DropDownItems.Add(logoutItem);

        menu.Items.Add(accountMenu);

        // Expenses Menu
        var expensesMenu = new ToolStripMenuItem("Frais");
        expensesMenu.DropDownItems.Add("Nouveaux frais");
        

        var myExpensesItem = new ToolStripMenuItem("Mes frais");
        myExpensesItem.Click += (sender, e) => ExpenseMenuActions.MyExpenses(context, user, mainForm);
        expensesMenu.DropDownItems.Add(myExpensesItem);

        if (user.Role == UserRole.Accountant || user.Role == UserRole.Admin)
        {
            expensesMenu.DropDownItems.Add("Valider les frais");
        }

        menu.Items.Add(expensesMenu);

        // Admin Menu
        if (user.Role == UserRole.Admin)
        {
            var adminMenu = new ToolStripMenuItem("Gestion");
            adminMenu.DropDownItems.Add("Utilisateurs");
            adminMenu.DropDownItems.Add("Types de frais");
            menu.Items.Add(adminMenu);
        }

        return menu;
    }
}
