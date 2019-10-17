using Microsoft.EntityFrameworkCore;

namespace Gighub.Models
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<ErrorViewModel> ErrorViews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ErrorViewModel>().HasKey(s => s.RequestId);
        }
    }
}