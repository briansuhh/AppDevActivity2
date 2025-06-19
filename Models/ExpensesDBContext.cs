using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AppDevActivity2.Models
{
    public class ExpensesDbContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }

        public ExpensesDbContext(DbContextOptions<ExpensesDbContext> options)
            : base(options)
        {
        }
    }
}
