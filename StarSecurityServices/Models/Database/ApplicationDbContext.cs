using Microsoft.EntityFrameworkCore;
using StarSecurityServices.Models.Common;
using System.Reflection;

namespace StarSecurityServices.Models.Database
{
    public class ApplicationDbContext : DbContext
    {
        #region Entities
        public DbSet<Achievement> Achievements { get; set; }

        public DbSet<Branch> Branches { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Contract> Contracts { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<EducationalQualification>
            EducationalQualifications
        { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Grade> Grades { get; set; }

        public DbSet<Recruitment> Recruitments { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Service> Services { get; set; }
        #endregion

        public ApplicationDbContext() { }

        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(
            ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(
                Assembly.GetExecutingAssembly()
            );
        }

        public async Task<int> SaveChangesAsync()
        {
            foreach (var entry in ChangeTracker
                .Entries<IStringKeyEntity>()
                .Where(e => e.State == EntityState.Added))
            {
                IStringKeyEntity.Generate(entry.Entity);
            }

            return await base.SaveChangesAsync();
        }
    }
}
