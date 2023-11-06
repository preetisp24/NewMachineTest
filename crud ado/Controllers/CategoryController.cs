using crud_ado.Custom;
using Microsoft.AspNetCore.Mvc;

namespace crud_ado.Controllers
{
    public class CategoryController : Controller
    {
        IConfiguration _config;
        public CategoryController(IConfiguration config)
        {
            _config = config;
        }

        public IActionResult Index()
        {
            CategoryDB db = new CategoryDB(_config);
            var categories = db.cat();
            return View(categories);
        }
    }
}
