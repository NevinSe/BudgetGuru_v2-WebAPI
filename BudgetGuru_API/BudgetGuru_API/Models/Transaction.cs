namespace BudgetGuru_API.Models
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public double amount { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

        public User UserID { get; set; }

    }
}
