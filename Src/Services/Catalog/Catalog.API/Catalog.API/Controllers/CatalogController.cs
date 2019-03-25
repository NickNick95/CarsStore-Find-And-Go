using Catalog.API.Helper.Converter;
using Catalog.API.Model;
using Catalog.Storage.Interfaces.Managers;
using Catalog.Storage.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : Controller
    {
        private readonly ICatalogsManager _сatalogManager;

        public CatalogController(ICatalogsManager сatalogManager)
        {
            _сatalogManager = сatalogManager;
        }

        [HttpGet]
        public JsonResult GetCatalogs()
        {
            var catalogs = _сatalogManager.GetAll();

            return Json(catalogs);
        }

        [HttpGet("{id}")]
        public ActionResult<CatalogModel> GetCatalogById(string id)
        {
            if (string.IsNullOrEmpty(id))
                return BadRequest();

            var catalog = _сatalogManager.Get(id);

            if (catalog == null)
                return NotFound();

            return Ok(CatalogModelConverter.ToModel(catalog));
        }

        [HttpPost]
        public ActionResult AddCatalog([FromBody] CatalogModel catalogModel)
        {
            if (string.IsNullOrEmpty(catalogModel.Title))
                return BadRequest();

            _сatalogManager.Add(CatalogModelConverter.ToDbModel(catalogModel));

            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult UpdateCatalog(string id, [FromBody] CatalogModel catalogModel)
        {
            if (string.IsNullOrEmpty(id))
                return BadRequest();

            _сatalogManager.Add(CatalogModelConverter.ToDbModel(catalogModel));

            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteCatalog(string id)
        {
            if (string.IsNullOrEmpty(id))
                return BadRequest();

            _сatalogManager.Delete(id);

            return Ok();
        }
    }
}