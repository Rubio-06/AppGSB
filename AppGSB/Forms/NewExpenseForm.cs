using AppGSB.Models;
using AppGSB.Data;

namespace AppGSB.Forms;

public partial class NewExpenseForm : Form
{
    private readonly AppDbContext _context;
    private readonly User _currentUser;

    public NewExpenseForm(AppDbContext context, User user)
    {
        InitializeComponent();
        _context = context;
        _currentUser = user;
    }
}
