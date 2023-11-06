using CruddemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace CruddemoMVC.Controllers
{
    public class ProductController : Controller
    {
        
        HttpClient client;
        string baseaddress;
        public ProductController(IConfiguration config)
        {
            this.client = new HttpClient();
            baseaddress = config["apiAddress"];
           this.client.BaseAddress = new Uri(baseaddress);
        }
        [HttpGet]
        public IActionResult Index()
        {
            string result=client.GetStringAsync(this.client.BaseAddress + "GetAll").Result;

            List<ProductModel> model=JsonSerializer.Deserialize<List<ProductModel>>(result);
            return View(model);
        }


        public IActionResult Details(int id)
        {
            string result = client.GetStringAsync(baseaddress + $"GetById/{id}").Result;

            ProductModel model1=JsonSerializer.Deserialize<ProductModel>(result);
            return View(model1);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductModel model)
        {
           // var result = client.GetStringAsync(this.client.BaseAddress + "Create").Result;
            var response = client.PostAsJsonAsync(baseaddress + "Create", model).Result;
            return RedirectToAction("Index");
        }

        [HttpGet]

        public IActionResult Edit(int id)
        {
            string result = client.GetStringAsync(baseaddress + $"GetById/{id}").Result;

            ProductModel model1 = JsonSerializer.Deserialize<ProductModel>(result);
            return View(model1);

           
        }

        [HttpPost]

        public IActionResult Edit(ProductModel prod)
        {
            var result = client.PutAsJsonAsync(baseaddress + $"update", prod).Result;


            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            string result = client.GetStringAsync(baseaddress + $"GetById/{id}").Result;
            ProductModel model = JsonSerializer.Deserialize<ProductModel>(result);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult Delete_model(ProductModel model)
        {
            var result=client.DeleteAsync(baseaddress+ $"Delete/{model.Id}").Result;
            return RedirectToAction("Index");

        }
    }
}
