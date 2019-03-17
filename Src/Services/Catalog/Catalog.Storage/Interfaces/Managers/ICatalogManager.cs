using Catalog.Storage.Models;
using System.Collections.Generic;

namespace Catalog.Storage.Interfaces.Managers
{
    public interface ICatalogsManager
    {
        IList<CatalogDBModel> GetAll();

        void Add(CatalogDBModel catalog);

        void Update(string id, CatalogDBModel catalog);

        CatalogDBModel Get(string id);

        void Delete(string id);
    }
}
