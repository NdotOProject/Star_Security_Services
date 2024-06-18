using Microsoft.EntityFrameworkCore;

namespace StarSecurityServices.Models.Context
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }


    }
}
