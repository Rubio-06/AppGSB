using AppGSB.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppGSB.Utils;

namespace AppGSB.Models
{
    public enum UserRole
    {
        Admin,
        Accountant,
        Guest
    }

    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public string Email { get; set; }

        public UserRole Role { get; set; }

        public string Sector { get; set; }

        public User(int id, string login, string password, string firstname, string lastname, string email, UserRole role, string sector) 
        {
            Id = id;
            Login = login;
            Password = password;
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Role = role;
            Sector = sector;
        }
    }
}
