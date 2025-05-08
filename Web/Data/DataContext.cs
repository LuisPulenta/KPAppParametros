using Microsoft.EntityFrameworkCore;
using Web.Data.Entities;

namespace Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        
        public DbSet<Empresa> Empresas { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Company>().HasIndex(x => x.Name).IsUnique();
            //modelBuilder.Entity<Survey>().HasIndex("Name", "CompanyId").IsUnique();
        }
    }
}