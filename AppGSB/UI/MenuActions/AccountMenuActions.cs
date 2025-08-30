using System.Windows.Forms;
using AppGSB.Models;
using AppGSB.Data;

namespace AppGSB.UI.MenuActions;

public static class AccountMenuActions
{
    public static void ShowProfile(User user, Form mainForm)
    {
        mainForm.Hide();
        using var profileForm = new Forms.ProfileForm(user);
        profileForm.ShowDialog();
        mainForm.Show();
    }

    public static void Logout(AppDbContext context, Form mainForm)
    {
        mainForm.Hide();
        using var loginForm = new Forms.LoginForm(context);
        loginForm.ShowDialog();
        mainForm.Close();
    }
}