using AppGSB.Models;
using AppGSB.Data;
using AppGSB.UI;

namespace AppGSB.Forms;

public partial class MainForm : Form
{
    private readonly AppDbContext _context;
    private readonly User _currentUser;

    public MainForm(AppDbContext context, User currentUser)
    {
        InitializeComponent();
        _context = context;
        _currentUser = currentUser;

        // Init Menu
        var menu = MenuBuilder.Build(_currentUser, _context, this);
        this.MainMenuStrip = menu;
        this.Controls.Add(menu);
    }
}
