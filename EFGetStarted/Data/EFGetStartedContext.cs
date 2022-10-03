using Microsoft.EntityFrameworkCore;
using EFGetStarted.Models;

namespace EFGetStarted.Data
{
  public class EFGetStartedContext : DbContext
  {
    public DbSet<Product> Products { get; set; }
    public DbSet<Customer> Customers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlite("Data Source=efgetstarted.sqlite");
    }
  }
}