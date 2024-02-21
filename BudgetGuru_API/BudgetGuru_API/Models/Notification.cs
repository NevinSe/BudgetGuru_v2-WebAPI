using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BudgetGuru_API.Models
{
    public class Notification
    {
        [Key]
        public int NotificationID { get; set; }
        public string? Type { get; set; }
        public string? Message { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey("User")]
        public string? UserID { get; set; }
        public User? User { get; set; }
    }
}
