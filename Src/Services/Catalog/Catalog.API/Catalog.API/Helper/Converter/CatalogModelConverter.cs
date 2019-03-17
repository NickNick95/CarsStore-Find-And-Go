using Catalog.API.Model;
using Catalog.Storage.Models;
using System.Collections.Generic;
using System.Linq;

namespace Catalog.API.Helper.Converter
{
    public static class CatalogModelConverter
    {
        public static CatalogDBModel ToDbModel(CatalogModel catalogModel)
        {
            return new CatalogDBModel
            {
                Id = catalogModel.Id,
                Description = catalogModel.Description,
                Title = catalogModel.Title
            };
        }

        public static IList<CatalogDBModel> ToDbModel(IList<CatalogModel> catalogModels)
        {
            return catalogModels.Select(c => ToDbModel(c)).ToList();
        }


        public static CatalogModel ToModel(CatalogDBModel catalogModel)
        {
            return new CatalogModel
            {
                Id = catalogModel.Id,
                Description = catalogModel.Description,
                Title = catalogModel.Title
            };
        }

        public static IList<CatalogModel> ToModel(IList<CatalogDBModel> catalogModels)
        {
            return catalogModels.Select(c => ToModel(c)).ToList();
        }
    }
}
