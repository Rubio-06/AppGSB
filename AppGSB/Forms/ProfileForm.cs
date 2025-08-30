using AppGSB.Models;

namespace AppGSB.Forms;

public partial class ProfileForm : Form
{
    private readonly User _user;
    public ProfileForm(User user)
    {
        InitializeComponent();
        _user = user;
    }
}
