using System.Windows.Forms;
using AppGSB.Models;

namespace AppGSB.UI;

public class ExpenseReportBuilder
{
    public static DataGridView Build()
    {
        var dgv = new DataGridView()
        {
            Dock = DockStyle.Fill,
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
            ReadOnly = true,
            AllowUserToAddRows = false,
            AllowUserToDeleteRows = false,
            SelectionMode = DataGridViewSelectionMode.FullRowSelect,
            MultiSelect = false
        };

        // Month
        var monthColumn = new DataGridViewTextBoxColumn()
        {
            Name = "Mois",
            DataPropertyName = nameof(ExpenseReport.MonthYear),
            Width = 100
        };

        // Status
        var statusColumn = new DataGridViewTextBoxColumn()
        {
            Name = "Statut",
            DataPropertyName = nameof(ExpenseReport.Status),
            Width = 100
        };

        // Amount
        var amountColumn = new DataGridViewTextBoxColumn()
        {
            Name = "Montant approuvé",
            DataPropertyName = nameof(ExpenseReport.ApprovedAmount),
            Width = 100
        };

        // Justification Count
        var justificationCountColumn = new DataGridViewTextBoxColumn()
        {
            Name = "Nombre de justificatifs",
            DataPropertyName = nameof(ExpenseReport.NumberOfReceipts),
            Width = 150
        };

        // Creation Date
        var creationDateColumn = new DataGridViewTextBoxColumn()
        {
            Name = "Date de création",
            DataPropertyName = nameof(ExpenseReport.CreateDate),
            Width = 150
        };

        // Button
        var actionButton = new DataGridViewButtonColumn()
        {
            Name = "Action",
            Text = "ActionColumn",
            UseColumnTextForButtonValue = true,
            Width = 100
        };
        dgv.Columns.Add(actionButton);

        return dgv;
    }
}
