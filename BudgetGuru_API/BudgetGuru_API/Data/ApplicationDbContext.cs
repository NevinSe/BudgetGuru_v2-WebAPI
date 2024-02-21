using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using BudgetGuru_API.Models;

namespace BudgetGuru_API.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSets represent tables in your database.
        public DbSet<Transaction> Transactions { get; set; }
        // Add more DbSets for other models
    }
}
