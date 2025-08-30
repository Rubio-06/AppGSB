using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AppGSB.Utils;

namespace AppGSB.Models;

public class ExpenseReport
{
    [Key]
    [Column("Id", TypeName = "int")]
    public int Id { get; set; }

    [Required, DataType(DataType.Date)]
    [Column("MonthYear", TypeName = "date")]
    public required DateTime MonthYear { get; set; }   // représente "mois + année"

    [Required, EnumDataType(typeof(ExpenseReportStatus))]
    [Column("Status", TypeName = "int")]
    public required ExpenseReportStatus Status { get; set; } = ExpenseReportStatus.InProgress;

    [Required, DataType(DataType.Date)]
    [Column("CreateDate", TypeName = "date")]
    public required DateTime CreateDate { get; set; } = DateTime.Now;

    [Required, DataType(DataType.Date)]
    [Column("UpdateDate", TypeName = "date")]
    public required DateTime UpdateDate { get; set; } = DateTime.Now;

    [DataType(DataType.Date)]
    [Column("ValidationDate", TypeName = "date")]
    public DateTime? ValidationDate { get; set; }

    [Range(0, int.MaxValue)]
    [Column("NumberOfReceipts", TypeName = "int")]
    public int NumberOfReceipts { get; set; } = 0;

    [Required]
    [Column("ApprovedAmount", TypeName = "decimal(18,2)")]
    public required decimal ApprovedAmount { get; set; } = 0;

    [MinLength(10), MaxLength(500)]
    [Column("RefusalReason", TypeName = "varchar(500)")]
    public string? RefusalReason { get; set; }

    // Not Mapped
    [NotMapped]
    public decimal TotalAmount { get; set; }

    [NotMapped]
    public int TotalExpense { get; set; }

    // Foreign key
    [Required]
    [Column("UserId", TypeName = "int")]
    public required int UserId { get; set; }

    // Navigation Properties
    [ForeignKey(nameof(UserId))]
    public virtual User? User { get; set; }

    // Associated Tables (1-n)
    public virtual ICollection<ExpenseLine> ExpenseLines { get; set; } = new List<ExpenseLine>();
    public virtual ICollection<ExpenseOutLine> ExpenseOutLines { get; set; } = new List<ExpenseOutLine>();
}
