using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppGSB.Models;

public class ExpenseLine
{
    [Key]
    [Column("Id", TypeName = "int")]
    public int Id { get; set; }

    [Required]
    [Column("Quantity", TypeName = "int")]
    public required int Quantity { get; set; }

    [Required]
    [Column("UnitAmount", TypeName = "decimal(18,2)")]
    public required decimal UnitAmount { get; set; }

    [Required]
    [Column("TotalAmount", TypeName = "decimal(18,2)")]
    public required decimal TotalAmount { get; set; }

    [Required]
    [Column("IsApproved", TypeName = "bit")]
    public required bool IsApproved { get; set; } = false;

    [MinLength(10), MaxLength(500)]
    [Column("RefusalReason", TypeName = "varchar(500)")]
    public string? RefusalReason { get; set; }

    // Foreign keys
    [Required]
    [Column("ExpenseReportId", TypeName = "int")]
    public required int ExpenseReportId { get; set; }

    [Required]
    [Column("ExpenseTypeId", TypeName = "int")]
    public required int ExpenseTypeId { get; set; }

    // Navigation Properties
    [ForeignKey(nameof(ExpenseReportId))]
    public virtual ExpenseReport? ExpenseReport { get; set; }

    [ForeignKey(nameof(ExpenseTypeId))]
    public virtual ExpenseType? ExpenseType { get; set; }
}
