using Basket.Storage.Interfaces.Repositories;
using Basket.Storage.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Basket.Storage.Repositories
{
    public class BasketHistoryRepository : IBasketHistoryRepository
    {

        private readonly DbContextOptions<DataContext> _options;

        public BasketHistoryRepository()
        {
            _options = DataContext.OptionsBuilder.UseNpgsql(DataContext.ConnectionStr).Options;
        }

        public void AddRecord(BasketHistoryModel basketHistory)
        {
            using (var db = new DataContext(_options))
            {
                if (string.IsNullOrEmpty(basketHistory.Id))
                {
                    db.BasketHistoryData.Add(basketHistory);
                    db.SaveChanges();
                }
            }
        }

        public List<BasketHistoryModel> GetHistory(string userID)
        {
            using (var db = new DataContext(_options))
            {
                if (string.IsNullOrEmpty(userID))
                {
                    var result = db.BasketHistoryData.Where(b => b.UserId == userID).ToList();

                    return result;
                }
                return new List<BasketHistoryModel>();
            }
        }
    }
}
