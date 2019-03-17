using Catalog.Common.Model;
using System.Collections.Generic;

namespace Catalog.Common.Repositories
{
    public interface ICatalogsRepository
    {
        IList<ICatalogDBModel> GetAll();

        void Add(ICatalogDBModel catalog);

        ICatalogDBModel Get(string id);

        void Delete(string id);
    }
}
