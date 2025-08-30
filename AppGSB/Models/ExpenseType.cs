using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AppGSB.Models;

public class ExpenseType
{
    [Key]
    [Column("Id", TypeName = "int")]
    public int Id { get; set; }

    [Required, MaxLength(50)]
    [Column("Code", TypeName = "varchar(50)")]
    public required string Code { get; set; } = string.Empty;

    [Required, MaxLength(200)]
    [Column("Label", TypeName = "varchar(200)")]
    public required string Label { get; set; } = string.Empty;

    [Required]
    [Column("IsFlatRate", TypeName = "bit")]
    public required bool IsFlatRate { get; set; }

    [Required]
    [Column("Rate", TypeName = "decimal(18,2)")]
    public required decimal Rate { get; set; }

    [Required]
    [Column("Active", TypeName = "bit")]
    public required bool Active { get; set; }

    [Required, DataType(DataType.Date)]
    [Column("CreatedAt", TypeName = "date")]
    public required DateTime CreatedAt { get; set; } = DateTime.Now;

    // --- Navigation property ---
    public virtual ICollection<ExpenseLine> ExpenseLines { get; set; } = new List<ExpenseLine>();
}
