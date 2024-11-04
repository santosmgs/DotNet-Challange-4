using Microsoft.EntityFrameworkCore;

namespace WorkerService1.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<WorkerService1.Models.UpStyle> UpStyles { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WorkerService1.Models.UpStyle>().ToTable("UPSTYLES");
        }
    }
}