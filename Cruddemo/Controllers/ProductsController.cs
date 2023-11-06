using Cruddemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cruddemo.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        DbContextdemo _db;

        public ProductsController(DbContextdemo db)
        {

            _db = db;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var prod = _db.products.ToList();
            return Ok(prod);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            ProductsModel p = _db.products.Find(id);
            return Ok(p);
        }
        [HttpPost]
        public IActionResult Create(ProductsModel model)
        {
            if (ModelState.IsValid)
            {
                _db.products.Add(model);
                _db.SaveChanges();
            }
            return Ok(model);
        }

        [HttpPut]

        public IActionResult Update(ProductsModel model)
        {
            _db.products.Update(model);
            _db.SaveChanges();
            return Ok(model);

        }

        [HttpDelete ("{id}")]

        public IActionResult Delete(int id)
        {
            ProductsModel model = _db.products.Find(id);
            _db.products.Remove(model);
            _db.SaveChanges();
            return Ok(model);
        }
    }
}
