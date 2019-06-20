using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Web.Shopping.Config;
using Web.Shopping.Models;
using Web.Shopping.Services.Interface;

namespace Web.Shopping.Services
{
    public class CatalogService : ICatalogService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<CatalogService> _logger;
        private UrlsConfig _urls;

        public CatalogService(HttpClient httpClient, 
                            ILogger<CatalogService> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
            _urls = new UrlsConfig();
        }

        public async Task<string> AddCatalogItem(CatalogItem catalogItem)
        {

            var responseMessage = new HttpResponseMessage();
            try
            {
                responseMessage = await _httpClient.PostAsJsonAsync<CatalogItem>(_urls.Catalog + UrlsConfig.CatalogOperations.AddItem(), catalogItem);
            }
            catch (Exception ex)
            {
                _logger.LogDebug(ex.Message);

                return ex.Message;
            }

            return responseMessage.RequestMessage.ToString();
        }

        public async Task<CatalogItem> GetCatalogItemById(string id)
        {
            var stringContent = string.Empty;
            var catalogItem = new CatalogItem();
            try
            {
                stringContent = await _httpClient.GetStringAsync(_urls.Catalog + UrlsConfig.CatalogOperations.GetItemById(id));
                catalogItem = JsonConvert.DeserializeObject<CatalogItem>(stringContent);
            }
            catch (Exception ex)
            {
                _logger.LogDebug(ex.Message);
                return new CatalogItem();
            }

            return catalogItem;
        }

        public async Task<List<CatalogItem>> GetCatalogItemsAsync()
        {
            var stringContent = string.Empty;
            var catalogItems = new List<CatalogItem>();
            try
            {
                stringContent = await _httpClient.GetStringAsync(_urls.Catalog + UrlsConfig.CatalogOperations.GetItems());
                catalogItems = JsonConvert.DeserializeObject<List<CatalogItem>>(stringContent);
            }
            catch (Exception ex)
            {
                _logger.LogDebug(ex.Message);
                return new List<CatalogItem>();
            }
            
            return catalogItems;
        }
    }
}

