using System.Text.RegularExpressions;

namespace AppGSB.Utils;

public static class Validator
{
    // Login
    public static bool IsValidLogin(string login)
    {
        var regex = new Regex(@"^[a-zA-Z0-9_.]{3,20}$");
        return regex.IsMatch(login);
    }

    // Password
    public static bool IsValidPassword(string password)
    {
        var regex = new Regex(@"^[a-zA-Z0-9_.]{8,50}$");
        return regex.IsMatch(password);
    }
}
