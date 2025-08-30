using System.Windows.Forms;
using AppGSB.Models;
using AppGSB.Data;
using AppGSB.Forms;

namespace AppGSB.UI.MenuActions;

public class ExpenseMenuActions
{
    public static void NewExpense(AppDbContext context, User user, Form mainForm)
    {
        
    }

    public static void MyExpenses(AppDbContext context, User user, Form mainForm)
    {
        mainForm.Hide();
        using var expensesForm = new MyExpenseReportForm(context, user);
        expensesForm.ShowDialog();
        mainForm.Show();
    }
}
