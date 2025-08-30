using AppGSB.Models;
using AppGSB.Utils;

namespace AppGSB.Data;

public static class DbInitializer
{
    public static void Seed(AppDbContext context)
    {
        context.Database.EnsureCreated();

        if (!context.Users.Any())
        {
            context.Users.AddRange(
                new User
                {
                    Login = "admin",
                    PasswordHash = HashHelper.HashPassword("Admin123"),
                    FirstName = "Super",
                    LastName = "Admin",
                    Email = "admin@gsb.com",
                    Role = UserRole.Admin,
                    CreateDate = DateTime.Now,
                    IsActive = true
                },
                new User
                {
                    Login = "accountant",
                    PasswordHash = HashHelper.HashPassword("Accountant123"),
                    FirstName = "Jean",
                    LastName = "Comptable",
                    Email = "accountant@gsb.com",
                    Role = UserRole.Accountant,
                    CreateDate = DateTime.Now,
                    IsActive = true
                },
                new User
                {
                    Login = "guest",
                    PasswordHash = HashHelper.HashPassword("Guest123"),
                    FirstName = "Marie",
                    LastName = "Visiteur",
                    Email = "guest@gsb.com",
                    Role = UserRole.Guest,
                    CreateDate = DateTime.Now,
                    IsActive = true
                }
            );

            context.SaveChanges();
        }
    }
}
