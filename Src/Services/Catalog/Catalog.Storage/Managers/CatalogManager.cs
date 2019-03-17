using Catalog.Storage.Interfaces.Managers;
using Catalog.Storage.Interfaces.Model;
using Catalog.Storage.Interfaces.Repositories;
using Catalog.Storage.Models;
using System.Collections.Generic;

namespace Catalog.Storage.Managers
{
    public class CatalogManager : ICatalogsManager
    {
        private readonly ICatalogsRepository _сatalogRepository;

        public CatalogManager(ICatalogsRepository сatalogRepository)
        {
            _сatalogRepository = сatalogRepository;
        }
        
        public void Add(CatalogDBModel catalog)
        {
            if (catalog != null)
                _сatalogRepository.Add(catalog);
        }

        public void Delete(string id)
        {
            if (!string.IsNullOrEmpty(id))
                _сatalogRepository.Delete(id);
        }

        public CatalogDBModel Get(string id)
        {
            if (!string.IsNullOrEmpty(id))
                return _сatalogRepository.Get(id);

            return null;
        }

        public IList<CatalogDBModel> GetAll()
        {
           return _сatalogRepository.GetAll();
        }

        public void Update(string id, CatalogDBModel catalog)
        {
            if (!string.IsNullOrEmpty(id))
                return;

            var updateCatalog = _сatalogRepository.Get(id);

            updateCatalog.Title = catalog.Title;
            updateCatalog.Description = catalog.Description;

            _сatalogRepository.Add(updateCatalog);
        }
    }
}
