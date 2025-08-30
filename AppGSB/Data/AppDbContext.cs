using Microsoft.EntityFrameworkCore;
using AppGSB.Models;

namespace AppGSB.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    // Tables
    public DbSet<User> Users { get; set; }
    public DbSet<ExpenseReport> ExpenseReports { get; set; }
    public DbSet<ExpenseLine> ExpenseLines { get; set; }
    public DbSet<ExpenseOutLine> ExpenseOutLines { get; set; }
    public DbSet<ExpenseType> ExpenseTypes { get; set; }
    public DbSet<Receipt> Receipts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // --- User ---
        modelBuilder.Entity<User>()
            .HasMany(u => u.ExpenseReports)
            .WithOne(er => er.User)
            .HasForeignKey(er => er.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<User>()
            .Property(u => u.Role)
            .HasConversion<string>();

        // --- ExpenseReport ---
        modelBuilder.Entity<ExpenseReport>()
            .HasMany(er => er.ExpenseLines)
            .WithOne(el => el.ExpenseReport)
            .HasForeignKey(el => el.ExpenseReportId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<ExpenseReport>()
            .HasMany(er => er.ExpenseOutLines)
            .WithOne(eol => eol.ExpenseReport)
            .HasForeignKey(eol => eol.ExpenseReportId)
            .OnDelete(DeleteBehavior.Cascade);

        // --- ExpenseLine ---
        modelBuilder.Entity<ExpenseLine>()
            .HasOne(el => el.ExpenseType)
            .WithMany(et => et.ExpenseLines)
            .HasForeignKey(el => el.ExpenseTypeId)
            .OnDelete(DeleteBehavior.Restrict);

        // --- ExpenseOutLine ---
        modelBuilder.Entity<ExpenseOutLine>()
            .HasOne(eol => eol.Receipt)
            .WithMany(r => r.ExpenseOutLines)
            .HasForeignKey(eol => eol.ReceiptId)
            .OnDelete(DeleteBehavior.SetNull);

        // --- ExpenseType ---
        modelBuilder.Entity<ExpenseType>()
            .HasMany(et => et.ExpenseLines)
            .WithOne(el => el.ExpenseType)
            .HasForeignKey(el => el.ExpenseTypeId);

        // --- Receipt ---
        modelBuilder.Entity<Receipt>()
            .HasMany(r => r.ExpenseOutLines)
            .WithOne(eol => eol.Receipt)
            .HasForeignKey(eol => eol.ReceiptId);
    }
}
