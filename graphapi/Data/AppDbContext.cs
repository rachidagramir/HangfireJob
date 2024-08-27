using Microsoft.EntityFrameworkCore;

namespace graphapi.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        public DbSet<Personn> Personn { get; set; }
    }

}
 