using Basket.Storage.Model;
using Microsoft.EntityFrameworkCore;

namespace Basket.Storage
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

        public DbSet<BasketHistoryModel> BasketHistoryData { get; set; }

    }
}
