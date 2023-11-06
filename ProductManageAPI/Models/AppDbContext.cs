using Microsoft.EntityFrameworkCore;

namespace ProductManageAPI.Models
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
        
        }

        public DbSet<Category> Categories { get; set; } 

       public DbSet<Products> Products { get; set; }
    }
}
