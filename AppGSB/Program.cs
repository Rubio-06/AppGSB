using Microsoft.EntityFrameworkCore;
using AppGSB.Data;
using AppGSB.Forms;

namespace AppGSB;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        try
        {
            var connexionString = "server=localhost;port=3306;database=gsb_database;user=gsb_user;password=gsb_password;";

            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseMySql(connexionString, ServerVersion.AutoDetect(connexionString));

            using var context = new AppDbContext(optionsBuilder.Options);

            // Seed Database
            DbInitializer.Seed(context);

            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm(context));

        } catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while initializing the application: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }    
}
