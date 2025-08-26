using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGSB.Utils
{
    internal static class InputValidator
    {
        // ----- Text fields validation methods ----- //
        // Username & Login
        public static bool IsValidUsername(string username, Label errorLabel)
        {
            bool isValid = Regex.IsMatch(username, @"^[a-zA-Z0-9]{3,20}$");
            errorLabel.Text = isValid
                ? ""
                : "Le nom d'utilisateur doit contenir entre 3 et 20 caractères.";
            return isValid;
        }

        // Firstname
        public static bool IsValidFirstname(string firstname, Label errorLabel)
        {
            bool isValid = Regex.IsMatch(firstname, @"^[A-Za-zÀ-ÖØ-öø-ÿ' -]{2,30}$");
            errorLabel.Text = isValid
                ? ""
                : "Le prénom doit contenir entre 2 et 30 caractères alphabétiques.";
            return isValid;
        }

        // Lastname
        public static bool IsValidLastname(string lastname, Label errorLabel)
        {
            bool isValid = Regex.IsMatch(lastname, @"^[A-Za-zÀ-ÖØ-öø-ÿ' -]{2,30}$");
            errorLabel.Text = isValid
                ? ""
                : "Le nom de famille doit contenir entre 2 et 30 caractères alphabétiques.";
            return isValid;
        }

        // ----- Password and email validation methods ----- //
        // Password
        public static bool IsValidPassword(string password, Label errorLabel)
        {
            bool isValid = Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$");
            errorLabel.Text = isValid
                ? ""
                : "Le mot de passe doit contenir au moins 8 caractères,\n une majuscule, une minuscule, un chiffre.";
            return isValid;
        }

        // Match passwords
        public static bool DoPasswordsMatch(string password, string confirmPassword, Label errorLabel)
        {
            bool isMatch = password == confirmPassword;
            errorLabel.Text = isMatch
                ? ""
                : "Les mots de passe ne correspondent pas.";
            return isMatch;
        }

        // Email
        public static bool IsValidEmail(string email, Label errorLabel)
        {
            bool isValid = Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            errorLabel.Text = isValid
                ? ""
                : "L'adresse e-mail n'est pas valide.";
            return isValid;
        }

        // ----- Generic validation methods ----- //
        // Not null or empty
        public static bool IsNotEmpty(string input)
        {
            // Not null, not whitespace
            return !string.IsNullOrWhiteSpace(input);
        }
    }
}
