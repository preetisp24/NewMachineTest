using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProductAppClient.Models;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace ProductAppClient.Controllers
{
    public class ProductController : Controller
    {
        HttpClient client;
        string baseAddress;
        public ProductController(IConfiguration config)
        {
            this.client = new HttpClient();
            baseAddress=config["ApiClient"];
            this.client.BaseAddress = new Uri(baseAddress);

        }
        // GET: ProductController
        [HttpGet]
        public IActionResult Index()
        {
            var response = client.GetStringAsync(this.client.BaseAddress + "products").Result;
            List<ProductModel> products = JsonSerializer.Deserialize<List<ProductModel>>(response);
            
            return View(products);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var response = client.GetStringAsync(this.client.BaseAddress + $"products/{id}").Result;
            ProductModel product = JsonSerializer.Deserialize<ProductModel>(response);

            return View(product);
        }
        [HttpGet]
        public IActionResult Create()
        {
        //    var apiResponse = client.GetAsync("https://localhost:7249/api/products");

        //    var dropdownOptions = apiResponse.ReadAsAsync(CategoryModel);
        

            return View();
        }

        [HttpPost]
        //to get data from form
        public IActionResult Create(ProductModel productModel)
        {
            var json = JsonSerializer.Serialize<ProductModel>(productModel);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = client.PostAsync(this.client.BaseAddress + "products", content).Result;
           
        // Step 5: Pass the dropdownlist options to the view
      

        return View();
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var response = client.GetStringAsync(this.client.BaseAddress + $"products/{id}").Result;
            ProductModel product = JsonSerializer.Deserialize<ProductModel>(response);

            return View(product);

        }
        [HttpPost]
        public IActionResult Update(ProductModel product)
        {
            var json = JsonSerializer.Serialize<ProductModel>(product);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = client.PutAsync(this.client.BaseAddress + $"products/{product.Id}", content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var response = client.GetStringAsync(this.client.BaseAddress + $"products/{id}").Result;
            ProductModel model = JsonSerializer.Deserialize<ProductModel>(response);

            return View(model);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult ConfirmDelete(int id)
        {
            var response = client.DeleteAsync(this.client.BaseAddress + $"products/{id}").Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}
