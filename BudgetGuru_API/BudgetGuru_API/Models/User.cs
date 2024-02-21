using Microsoft.AspNetCore.Identity;

namespace BudgetGuru_API.Models
{
    public class User: IdentityUser
    {
        public DateTime RegistrationDate { get; set; }
    }
}
