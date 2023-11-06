using crudado1.modelDb;
using crudado1.Models;
using Microsoft.AspNetCore.Mvc;

namespace crudado1.Controllers
{
    [Route("[controller]/[action]")]
    public class CategoryController : Controller
    {
        IConfiguration _config;
        public CategoryController(IConfiguration config)
        {
            _config = config;
        }

        public IActionResult Index()
        {
            CategoryDb db = new CategoryDb(_config);
            var categories = db.cat();
            return View(categories);
        }

        [Route("{id?}")]
        public IActionResult ProdByCat([FromRoute] int? id)
        {
            CategoryDb db = new CategoryDb(_config);
            List<ProductModel> model = db.prod(id);
            return View(model);
        }
    }
}
