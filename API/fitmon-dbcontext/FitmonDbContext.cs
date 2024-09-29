using fitmon_datamodels;
using Microsoft.EntityFrameworkCore;


namespace fitmon_dbcontext
{
    public class FitmonDbContext : DbContext
    {
        // Constructor to accept DbContextOptions
        public FitmonDbContext(DbContextOptions<FitmonDbContext> options) : base(options)
        {
        }

        public DbSet<Test> Tests { get; set; }


        // Configure entity relationships and any additional configurations
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
