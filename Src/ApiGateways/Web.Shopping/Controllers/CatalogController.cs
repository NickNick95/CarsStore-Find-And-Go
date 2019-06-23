using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Shopping.Models;
using Web.Shopping.Services.Interface;

namespace Web.Shopping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly ICatalogService _catalogManager;

        public CatalogController(ICatalogService catalogService)
        {
            _catalogManager = catalogService;
        }

        [HttpGet]
        [Route("All")]
        public async Task<List<CatalogItem>> GetCatalogs()
        {
            var catalogs = await _catalogManager.GetCatalogItemsAsync();

            return catalogs.ToList();
        }

        [HttpGet("{id}")]
        public async Task<CatalogItem> GetCatalogById(string id)
        {
            var catalogs = await _catalogManager.GetCatalogItemById(id);

            return catalogs;
        }

        [HttpPost("AddCatalog")]
        public async Task<string> AddCatalog(CatalogItem catalogItem)
        {
            var messageResponse = await _catalogManager.AddCatalogItem(catalogItem);

            return messageResponse;
        }
    }
}