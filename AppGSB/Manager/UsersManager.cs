using AppGSB.Manager;
using AppGSB.Models;
using AppGSB.Utils;
using AppGSB.Views;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AppGSB.Controllers
{
    internal static class UsersManager
    {
        public static User? ConnectedUser { get; private set; }

        public static bool IsAdmin()
        {
            return ConnectedUser != null && ConnectedUser.Role == UserRole.Admin;
        }

        // ----- General methods ----- //

        // Login method : 
        public static bool Login(string login, string password)
        {
            string hashedPassword = HashHelper.HashPassword(password);
            
            using var conn = DatabaseManager.GetConnection();
            using var cmd = new MySqlCommand(
                "SELECT * FROM users WHERE login = @login AND password = @password", 
                conn
            );

            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@password", hashedPassword);

            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                ConnectedUser = new User(
                    reader.GetInt32("id"),
                    reader.GetString("login"),
                    reader.GetString("password"),
                    reader.GetString("firstname"),
                    reader.GetString("lastname"),
                    reader.GetString("email"),
                    Enum.Parse<UserRole>(reader.GetString("role"), ignoreCase: true),
                    reader.GetString("sector")
                );
                return true;
            }
            return false;
        }

        // Logout method :
        public static void Logout(Form currentForm)
        {
            var result = MessageBox.Show(
                "Voulez-vous vraiment vous déconnecter ?",
                "Déconnexion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                
            }
        }

        // Get all users method : 
        public static List<User> GetAllUsers()
        {
            var users = new List<User>();

            using var conn = DatabaseManager.GetConnection();
            using var cmd = new MySqlCommand("SELECT * FROM users", conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                users.Add(new User(
                    reader.GetInt32("id"),
                    reader.GetString("login"),
                    reader.GetString("password"),
                    reader.GetString("firstname"),
                    reader.GetString("lastname"),
                    reader.GetString("email"),
                    Enum.Parse<UserRole>(reader.GetString("role"), ignoreCase: true),
                    reader.GetString("sector")
                ));
            }

            return users;
        }

        // ----- Admin methods ----- //

        // Add user method :
        public static void AddUser(User user)
        {
            if (IsAdmin())
            {
                Console.WriteLine($"User {user.Login} added successfully.");
            }
            else
            {
                Console.WriteLine("You do not have permission to add users.");
            }
        }

        // Update user method :
        public static void UpdateUser(User updateUser)
        {
            if (IsAdmin())
            {
                // Update the user selected
            }
            else
            {
                Console.WriteLine("You do not have permission to update users.");
            }
        }

        // Delete user method :
        public static void DeleteUser(int id)
        {
            if (IsAdmin())
            {
                // Delete User
            }
            else
            {
                Console.WriteLine("You do not have permission to delete users.");
            }
        }
    }
}
