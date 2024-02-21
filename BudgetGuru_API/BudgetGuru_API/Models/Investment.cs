using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BudgetGuru_API.Models
{
    public class Investment
    {
        [Key]
        public int InvestmentID { get; set; }
        public string? Type { get; set; }
        public double Amount { get; set; }
        public double CurrentValue { get; set; }
        public DateTime DateAcquired { get; set; }
        [ForeignKey("User")]
        public string? UserID { get; set; }
        public User? User { get; set; }
    }
}
