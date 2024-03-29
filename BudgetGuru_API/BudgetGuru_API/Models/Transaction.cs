﻿using System.ComponentModel.DataAnnotations.Schema;

namespace BudgetGuru_API.Models
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public string? Description { get; set; }
        public string? Type { get; set; }

        [ForeignKey("User")]
        public string? UserID { get; set; }
        public User? User { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public Category? Category { get; set; }

    }
}
