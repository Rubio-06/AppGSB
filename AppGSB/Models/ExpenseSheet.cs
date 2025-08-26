using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGSB.Models
{
    public enum ExpenseStatus
    {
        Current,
        Pending,
        Approved,
        Rejected,
        RejectedPartially
    }

    internal class ExpenseSheet
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public ExpenseStatus Status { get; set; }
        
        public ExpenseSheet(int id, int userId, DateTime date, string description, decimal amount, ExpenseStatus status)
        {
            Id = id;
            UserId = userId;
            Date = date;
            Description = description;
            Amount = amount;
            Status = status;
        }
    }
}
