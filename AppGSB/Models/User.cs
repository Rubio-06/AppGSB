using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AppGSB.Utils;

namespace AppGSB.Models;

public class User
{
    [Key]
    public int Id { get; set; }

    [Required, MinLength(3), MaxLength(50)]
    [Column(TypeName = "varchar(50)")]
    public required string Login { get; set; }

    [Required, MinLength(8), MaxLength(100)]
    [Column(TypeName = "varchar(100)")]
    public required string PasswordHash { get; set; }

    [Required, MinLength(2), MaxLength(50)]
    [Column(TypeName = "varchar(50)")]
    public required string FirstName { get; set; }

    [Required, MinLength(2), MaxLength(50)]
    [Column(TypeName = "varchar(50)")]
    public required string LastName { get; set; }

    [Required, EmailAddress, MaxLength(100)]
    [Column(TypeName = "varchar(100)")]
    public required string Email { get; set; }

    [Required, EnumDataType(typeof(UserRole))]
    [Column(TypeName = "varchar(50)")]
    public UserRole Role { get; set; }

    [Required, DataType(DataType.Date)]
    [Column(TypeName = "date")]
    public DateTime CreateDate { get; set; } = DateTime.Now;

    [Required]
    [Column(TypeName = "bit")]
    public bool IsActive { get; set; } = true;

    // Not Mapped
    [NotMapped]
    public string FullName => $"{FirstName} {LastName}";

    // Associated Tables (1-n)
    public virtual ICollection<ExpenseReport> ExpenseReports { get; set; } = new List<ExpenseReport>();
}
