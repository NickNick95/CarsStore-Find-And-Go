using Catalog.Common.Model;
using System.Collections.Generic;

namespace Catalog.Common.Managers
{
    public interface ICatalogsManager
    {
        IList<ICatalogDBModel> GetAll();

        void Add(ICatalogDBModel catalog);

        void Update(string id, ICatalogDBModel catalog);

        ICatalogDBModel Get(string id);

        void Delete(string id);
    }
}
