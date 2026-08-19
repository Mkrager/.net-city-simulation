using CitySimulation.Domain.Entities;
using CitySimulation.Persistence.Seeds;
using Microsoft.EntityFrameworkCore;

namespace CitySimulation.Persistence
{
    public class CitySimulationDbContext : DbContext
    {
        public CitySimulationDbContext(DbContextOptions<CitySimulationDbContext> options)
            : base(options)
        {
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Workplace> Workplaces { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().
                HasOne(p => p.Partner)
                .WithOne()
                .HasForeignKey<Person>(p => p.PartnerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CitySimulationDbContext).Assembly);

            SeedData.Seed(modelBuilder);
        }
    }
}