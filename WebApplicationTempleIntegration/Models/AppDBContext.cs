using Microsoft.EntityFrameworkCore;

namespace WebApplicationTempleIntegration.Models
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options):base(options)
        {
                
        }
        public DbSet<Contact> contacts { get; set; }
        public DbSet<App> Apps { get; set; }

    }
}
