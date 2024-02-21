using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BudgetGuru_API.Models
{
    public class Budget
    {
        [Key]
        public int BudgetID { get; set; }
        public double Amount { get; set; }
        public string? Month { get; set; }
        public string? Year { get; set; }

        [ForeignKey("User")]
        public string? UserID { get; set; }
        public User? User { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public Category? Category { get; set; }
    }
}
