
using Microsoft.EntityFrameworkCore;

namespace draal
{
    public class BandDbContext : DbContext  
    {
        public BandDbContext(DbContextOptions<BandDbContext> options)
            : base(options)
        { }

        public DbSet<Band> Bands { get; set; }
    }
} 