using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppGSB.Models;

public class Receipt
{
    [Key]
    [Column("Id", TypeName = "int")]
    public int Id { get; set; }

    [Required, MaxLength(200)]
    [Column("FileName", TypeName = "varchar(200)")]
    public required string FileName { get; set; } = string.Empty;

    [Required, MaxLength(500)]
    [Column("FilePath", TypeName = "varchar(500)")]
    public required string FilePath { get; set; } = string.Empty;

    [Required, DataType(DataType.Date)]
    [Column("UploadDate", TypeName = "date")]
    public required DateTime UploadDate { get; set; } = DateTime.Now;

    // Navigation Properties
    public virtual ICollection<ExpenseOutLine> ExpenseOutLines { get; set; } = new List<ExpenseOutLine>();
}
