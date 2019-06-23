using Basket.Storage.Interfaces.Managers;
using Basket.Storage.Interfaces.Repositories;
using Basket.Storage.Model;
using System;
using System.Threading.Tasks;

namespace Basket.Storage.Managers
{
    public class BasketHistoryManagerl : IBasketHistoryManager
    {

        private readonly IBasketHistoryRepository _historyRepository;

        public BasketHistoryManagerl(IBasketHistoryRepository historyRepository)
        {
            _historyRepository = historyRepository;
        }

        public Task WriteRecordToHistory(CatalogModel catalog)
        {
            if (catalog.UserId == null || catalog.Title == null)
                return Task.CompletedTask;

            var backeRecord = new BasketHistoryModel
            {
                DayAndTime = DateTime.Now,
                Title = catalog.Title,
                Description = catalog.Description,
                UserId = catalog.UserId,
                CatalogId = catalog.CatalogId
            };

            _historyRepository.AddRecord(backeRecord);

            return Task.CompletedTask;
        }
    }
}
