using Microsoft.AspNetCore.Mvc;
using ProductManageAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductManageAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase

    {
        AppDbContext _db;
      
        public CategoriesController(AppDbContext db)
        {
            _db = db;
         
        }

        // GET: api/<CategoriesController>
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Category> categories=_db.Categories.ToList();

            return Ok(categories);
        }

        // GET api/<CategoriesController>/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {          
            Category cat = _db.Categories.Find(id);
            return Ok(cat);
        }

        // POST api/<CategoriesController>
        [HttpPost]
        public IActionResult Create(CategoryModel category)
        {
            if (category!= null)
            {
                try
                {
                    if (ModelState.IsValid)
                    {
                        Category cat = new Category()
                        {
                            Id = category.Id,
                            Name = category.Name,

                        };
                        _db.Categories.Add(cat);
                        _db.SaveChanges();
                        return Created("Create", cat);

                    }
                }
                catch
                {
                    return BadRequest("Insert correct data");
                    
                }
            }

            return BadRequest("Enter Correct details");

        }

        // PUT api/<CategoriesController>/5
        [HttpPut("{id}")]
        public IActionResult Update(int id,CategoryModel cat)
        {
            if (id == cat.Id)
            {
                if (ModelState.IsValid)
                {
                    Category category = new Category()
                    {
                        Id = cat.Id,
                        Name = cat.Name

                    };
                    _db.Categories.Update(category);
                    _db.SaveChanges();
                    return Ok(category);
                }
            }
            return BadRequest("Id not found");
        }

        // DELETE api/<CategoriesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id <= 0)

             return BadRequest("Enter Valid Id");
            Category cat = _db.Categories.Find(id);
            _db.Categories.Remove(cat);
            _db.SaveChanges();
            return Ok(cat);
        }
    }
}
