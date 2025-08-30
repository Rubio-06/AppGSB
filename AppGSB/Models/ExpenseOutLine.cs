using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppGSB.Models;

public class ExpenseOutLine
{
    [Key]
    [Column("Id", TypeName = "int")]
    public int Id { get; set; }

    [Required, MaxLength(200)]
    [Column("Label", TypeName = "varchar(200)")]
    public required string Label { get; set; } = string.Empty;

    [Required, DataType(DataType.Date)]
    [Column("ExpenseDate", TypeName = "date")]
    public required DateTime ExpenseDate { get; set; }

    [Required]
    [Column("Amount", TypeName = "decimal(18,2)")]
    public required decimal Amount { get; set; }

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

    [Column("ReceiptId", TypeName = "int")]
    public int? ReceiptId { get; set; }   // optionnel

    // Navigation Properties
    [ForeignKey(nameof(ExpenseReportId))]
    public virtual ExpenseReport? ExpenseReport { get; set; }

    [ForeignKey(nameof(ReceiptId))]
    public virtual Receipt? Receipt { get; set; }
}
