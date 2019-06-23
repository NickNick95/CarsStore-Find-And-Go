using Basket.Storage.Model;

namespace Basket.Storage.Interfaces.Repositories
{
    public interface IBasketHistoryRepository
    {
       void AddRecord(BasketHistoryModel catalog);
    }
}
