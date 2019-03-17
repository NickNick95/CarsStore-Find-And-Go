
using Catalog.Storage.Models;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Storage
{
    public class DataContext : DbContext
    {
        public static DbContextOptionsBuilder<DataContext> OptionsBuilder =
            new DbContextOptionsBuilder<DataContext>();

        public static string ConnectionStr =
        "Host=localhost;Port=5432;Database=FindAndGo;Username=postgres;Password=Qwerty123456;";

        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CatalogDBModel> CatalogsData { get; set; }
        
    }
}
