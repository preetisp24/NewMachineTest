using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductManageAPI.Models;
using System.Reflection.Metadata.Ecma335;
using Type = ProductManageAPI.Models.Type;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductManageAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        AppDbContext _db;
        public ProductsController(AppDbContext db)
        {
            _db = db;
        }
        // GET: api/<ProductsController>
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Products> products = _db.Products.ToList();
            return Ok(products);
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Products products = _db.Products.Find(id);
            return Ok(products);
        }

        // POST api/<ProductsController>
        [HttpPost]

        public IActionResult Create(ProductModel productModel)
        { 

            if (productModel != null)
            {
                Products products = new Products()
               // Products products = _db.Products.Include("Categories").Select(x => new ProductModel()
                {
                    Id = productModel.Id,
                    CategoryId = productModel.categoryModel.Id,
                    Name = productModel.Name,
                    Description = productModel.Description,
                    SKU = productModel.SKU,
                    ImagePath = productModel.ImagePath,
                    SellingPrice = productModel.SellingPrice,
                    AvailableQty = productModel.AvailableQty,
                    Weight = productModel.Weight,
                    Length = productModel.Length,
                    Width = productModel.Width,
                    Height = productModel.Height,
                    ShippingCost = productModel.ShippingCost,
                    



                };
                var enumType = Enum.GetValues(typeof(Type)).Cast<Type>().FirstOrDefault();

                _db.Products.Add(products);
                _db.SaveChanges();
                return Created("Create", products);
                
            }
            return BadRequest("Enter valid data");

        }

      //  PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public IActionResult Update(int id, ProductModel productModel)
        {
            if (id == productModel.Id)
            {
                if (ModelState.IsValid)
                {
                    Products products = new Products()
                    {
                        Id = productModel.Id,
                        CategoryId = productModel.CategoryId,
                        Name = productModel.Name,
                        Description = productModel.Description,
                        SKU = productModel.SKU,
                        ImagePath = productModel.ImagePath,
                        SellingPrice = productModel.SellingPrice,
                        AvailableQty = productModel.AvailableQty,
                        Weight = productModel.Weight,
                        Length = productModel.Length,
                        Width = productModel.Width,
                        Height = productModel.Height,
                        ShippingCost = productModel.ShippingCost
                    };
                    var enumType = Enum.GetValues(typeof(Type)).Cast<Type>().FirstOrDefault();
                    _db.Products.Update(products);
                    _db.SaveChanges();
                    return Ok(products);
                }
            }

            return BadRequest("Enter correct details");

        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest("Enter correct id");
            if (ModelState.IsValid)
            {
                Products product = _db.Products.Find(id);
                _db.Products.Remove(product);
                _db.SaveChanges();
                return Ok(product);
            }
            return NotFound("Id not found");
        }
    }
}

