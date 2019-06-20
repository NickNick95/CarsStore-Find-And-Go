using Microsoft.AspNetCore.Mvc;

namespace Web.Shopping.Controllers
{
    [Route("api/values")]
    [ApiController]
    public class ValuesController : Controller
    {
        [HttpGet()]
        public IActionResult Index()
        {
            return new RedirectResult("~/swagger");
        }
    }
}
