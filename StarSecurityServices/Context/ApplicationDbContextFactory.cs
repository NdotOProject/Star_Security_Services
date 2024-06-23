using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace StarSecurityServices.Context
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
                configuration.GetConnectionString("Default")
            );

            return new ApplicationDbContext(optionBuilder.Options);
        }
    }
}
