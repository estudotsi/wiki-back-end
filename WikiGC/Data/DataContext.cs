using Microsoft.EntityFrameworkCore;
using WikiGC.Models;

namespace WikiGC.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opts) : base(opts) { }

        public DbSet<Portais> Portais { get; set; }
    }
}
