using Basket.Storage.Model;
using System.Threading.Tasks;

namespace Basket.Storage.Interfaces.Managers
{
    public interface IBasketHistoryManager
    {
        Task WriteRecordToHistory(CatalogModel catalog);
    }
}
