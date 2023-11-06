using Microsoft.EntityFrameworkCore;

namespace Banking_Application.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<AccountDetails>?Accounts { get; set; }

    }
}
