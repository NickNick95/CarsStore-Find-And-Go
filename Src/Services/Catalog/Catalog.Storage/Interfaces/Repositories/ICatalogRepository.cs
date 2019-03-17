using Catalog.Storage.Models;
using System.Collections.Generic;

namespace Catalog.Storage.Interfaces.Repositories
{
    public interface ICatalogsRepository
    {
        IList<CatalogDBModel> GetAll();

        void Add(CatalogDBModel catalog);

        CatalogDBModel Get(string id);

        void Delete(string id);
    }
}
