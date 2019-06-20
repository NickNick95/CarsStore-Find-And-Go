using System.Collections.Generic;
using System.Threading.Tasks;
using Web.Shopping.Models;

namespace Web.Shopping.Services.Interface
{
    public interface ICatalogService
    {
        Task<CatalogItem> GetCatalogItemById(string id);

        Task<List<CatalogItem>> GetCatalogItemsAsync();

        Task<string> AddCatalogItem(CatalogItem catalogItem);
    }
}
