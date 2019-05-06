using Microsoft.EntityFrameworkCore;
using PracticeQuotes.Api.Models;

namespace PracticeQuotes.Api.Data
{
    public class PracticeQuotesContext : DbContext
    {
        public PracticeQuotesContext(DbContextOptions<PracticeQuotesContext> options) 
            : base(options)
        {
        }

        public DbSet<Quote> Quotes { get; set; }
    }
}