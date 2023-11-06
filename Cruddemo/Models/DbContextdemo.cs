using Microsoft.EntityFrameworkCore;

namespace Cruddemo.Models
{
    public class DbContextdemo:DbContext
    {

        public DbContextdemo(DbContextOptions<DbContextdemo> options):base(options) 
        { 
        }

       public DbSet<ProductsModel> products { get; set; }
    }
}
