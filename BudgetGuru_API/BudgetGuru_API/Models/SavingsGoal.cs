using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BudgetGuru_API.Models
{
    public class SavingsGoal
    {
        [Key]
        public int SavingsGoalID { get; set; }
        public double TargetAmount { get; set; }
        public double CurrentAmount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [ForeignKey("User")]
        public string? UserID { get; set; }
        public User? User { get; set; }
    }
}
