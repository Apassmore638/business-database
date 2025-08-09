using Microsoft.EntityFrameworkCore;
using DatabaseSite.Models;

namespace DatabaseSite.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Job> Jobs { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<CostingSheet> CostingSheets { get; set; }
        public DbSet<LineItem> LineItems { get; set; }
        public DbSet<TriageItem> TriageItems { get; set; }
    }
}
