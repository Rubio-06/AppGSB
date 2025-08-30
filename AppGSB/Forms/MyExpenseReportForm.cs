using AppGSB.Data;
using AppGSB.Models;
using AppGSB.Utils;
//using AppGSB.Services;
using AppGSB.UI;

namespace AppGSB.Forms;

public partial class MyExpenseReportForm : Form
{
    private readonly AppDbContext _context;
    private readonly User _user;
    private readonly DataGridView _dgv;

    public MyExpenseReportForm(AppDbContext context, User user)
    {
        InitializeComponent();
        _context = context;
        _user = user;
        _dgv = ExpenseReportBuilder.Build();
        Controls.Add(_dgv);

        LoadReports();
    }

    private void LoadReports()
    {
        var reports = _context.ExpenseReports
            .Where(er => er.UserId == _user.Id)
            .OrderByDescending(er => er.CreateDate)
            .Select(er => new
                {
                    er.Id,
                    er.MonthYear,
                    er.Status,
                    er.NumberOfReceipts,
                    er.ApprovedAmount,
                    er.CreateDate
                }
            )
            .ToList();

        _dgv.DataSource = reports;

        // Update Actions Buttons
        foreach (DataGridViewRow row in _dgv.Rows)
        {
            if (row.DataBoundItem is ExpenseReport report)
            {
                bool isEditable = IsEditable(report);
                row.Cells["ActionColumn"].Value = isEditable ? "Éditer" : "Détails";
            }
        }
    }

    private bool IsEditable(ExpenseReport report)
    {
        var limitDate = new DateTime(report.MonthYear.Year, report.MonthYear.Month, 1)
                            .AddMonths(1).AddDays(9);
        return report.Status == ExpenseReportStatus.InProgress && DateTime.Now <= limitDate;
    }

    private void btnAddReport_Click(object sender, EventArgs e)
    {
        var existingReport = _context.ExpenseReports
            .FirstOrDefault(er => er.UserId == _user.Id && er.Status == ExpenseReportStatus.InProgress);
    
        if (existingReport != null)
        {
            MessageBox.Show(
                "Vous avez déjà un rapport de frais en cours. Veuillez le terminer avant d'en créer un nouveau.",
                "Rapport en cours",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        var newReport = new ExpenseReport
        {
            UserId = _user.Id,
            MonthYear = DateTime.Now,
            Status = ExpenseReportStatus.InProgress,
            CreateDate = DateTime.Now,
            UpdateDate = DateTime.Now,
            ApprovedAmount = 0,
            NumberOfReceipts = 0
        };

        _context.ExpenseReports.Add(newReport);
        _context.SaveChanges();

        MessageBox.Show(
            "Nouveau rapport de frais créé avec succès.",
            "Succès",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );

        LoadReports();
    }
}
