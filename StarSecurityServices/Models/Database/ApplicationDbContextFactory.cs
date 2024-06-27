using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace StarSecurityServices.Models.Database
{
    public class ApplicationDbContextFactory
        : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        //dotnet ef migrations add DatabaseVer1 -p .\StarSecurityServices

        private ConfigurationManager configuration;

        public ApplicationDbContextFactory(ConfigurationManager configuration)
        {
            this.configuration = configuration;
        }

        public ApplicationDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<ApplicationDbContext> optionBuilder = new();

            optionBuilder.UseSqlServer(
                //"Server=DESKTOP-JO6DIGF\\SQLEXPRESS;Database=StarSecurityServices;TrustServerCertificate=True;Trusted_Connection=True;User Id=sa;Password=12345678;"
                configuration.GetConnectionString("Default")
            ).EnableSensitiveDataLogging(true);

            return new ApplicationDbContext(optionBuilder.Options);
        }
    }
}
