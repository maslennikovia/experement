using experiment.Models;
using Microsoft.EntityFrameworkCore;

namespace experiment.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public ApplicationDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(Configuration.GetConnectionString("DefaultDatabase"));


            if (!options.IsConfigured)
            {
                // TODO: брать из конфига.
                //NpgsqlConnectionStringBuilder builder = new NpgsqlConnectionStringBuilder("Host=database;Port=5432;UserId=postgres;Password=qweQWE123;Database=experement;");

                //string host = Environment.GetEnvironmentVariable("HOST");

                //if (!string.IsNullOrEmpty(host))
                //{
                //    builder.Host = host;
                //}

                //options.UseNpgsql(builder.ConnectionString);
            }
        }

        public DbSet<Dimension> Dimensions { get; set; }

        public DbSet<Log> Loggs { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
