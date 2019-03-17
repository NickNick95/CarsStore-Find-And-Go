using Catalog.Storage.Interfaces.Repositories;
using Catalog.Storage.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Catalog.Storage.Repositories
{
    public class CatalogRepository : ICatalogsRepository
    {
        private readonly DbContextOptions<DataContext> _options;

        public CatalogRepository()
        {
            _options = DataContext.OptionsBuilder.UseNpgsql(DataContext.ConnectionStr).Options;
        }

        public void Add(CatalogDBModel catalog)
        {
            using (var db = new DataContext(_options))
            {
                if (string.IsNullOrEmpty(catalog.Id))
                {
                    db.CatalogsData.Add((CatalogDBModel)catalog);
                    db.SaveChanges();
                }
                else
                {
                    var catalogExisting = db.CatalogsData.SingleOrDefault(u => u.Id == catalog.Id);
                    catalogExisting = (CatalogDBModel)catalog;

                    db.CatalogsData.Add(catalogExisting);
                    db.SaveChanges();
                }
            }
        }

        public void Delete(string id)
        {
            using (var db = new DataContext(_options))
            {
                var catalog = db.CatalogsData.SingleOrDefault(c => c.Id == id);
                if (catalog != null)
                {
                    db.Remove(catalog);
                    db.SaveChanges();
                }
            }
        }

        public CatalogDBModel Get(string id)
        {
            using (var db = new DataContext(_options))
            {
                var catalog = db.CatalogsData.SingleOrDefault(c => c.Id == id);

                if (catalog != null)
                    return catalog;
                else
                    return null;
            }
        }
        
        public IList<CatalogDBModel> GetAll() 
        {
            using (var db = new DataContext(_options))
                return db.CatalogsData.ToList();
        }
    }
}
