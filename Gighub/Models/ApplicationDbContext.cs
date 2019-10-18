using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Gighub.Models
{
    public class ApplicationDbContext : DbContext
    {

        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        //{

        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration.GetConnectionString("GighubConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Gig> Gigs { get; set; }
        public DbSet<Genre> Genres { get; set; }

    }
}