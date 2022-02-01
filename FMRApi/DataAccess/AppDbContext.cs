
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Infrastructure.Internal;
using System.Collections.Generic;

namespace LEUMITApi.DataAccess
{
    public class AppDbContext : DbContext
    {
          public DbSet<Employees> Employees { get; set; }
       
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employees>().ToTable("Employees");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        if (!optionsBuilder.IsConfigured)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();
            var connectionString = "data source=.;initial catalog=MyNewDb;integrated security=true";
            optionsBuilder.UseSqlServer(connectionString);
        }
        }



}

}
