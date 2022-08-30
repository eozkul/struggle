using Microsoft.EntityFrameworkCore;
using Struggle.Entities;

namespace Struggle.Data.Context
{
    public class StruggleDbContext:DbContext
    {
        public StruggleDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Boat> Boats { get; set; }
    
    }
}
