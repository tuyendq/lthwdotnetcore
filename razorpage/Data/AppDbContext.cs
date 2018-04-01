using Microsoft.EntityFrameworkCore;

namespace razorpage.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {            
        }

        public DbSet<Customer> Customers { get; set; }
    }
}