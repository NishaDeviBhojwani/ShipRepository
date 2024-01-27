using API.Domain;
using Microsoft.EntityFrameworkCore;

namespace API.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options) { }

        public DbSet<Ship> Ships { get; set; }
    }
}
