using apiexploretuor.Model;
using Microsoft.EntityFrameworkCore;

namespace apiexploretuor.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)  {
        
        }

        public DbSet<Destino> destinos { get; set; }
    }
}
