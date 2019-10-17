using Microsoft.EntityFrameworkCore;

namespace Gighub.Models
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Gig> Gigs { get; set; }

    }
}