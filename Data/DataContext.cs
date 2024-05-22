using CarPartStore.Models;
using Microsoft.EntityFrameworkCore;

namespace CarPartStore.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder
                .UseSqlServer("Server =.\\SQLEXPRESS; Database = CarPartStoreDB; Trusted_Connection = True; TrustServerCertificate = True;");
        }

        public DbSet<User> Users => Set<User>();
    }
}
