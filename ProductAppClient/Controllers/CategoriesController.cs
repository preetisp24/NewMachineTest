using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using ProductAppClient.Models;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace ProductAppClient.Controllers
{
    public class CategoriesController : Controller
    {
        HttpClient client;
        string baseAddress;
        public CategoriesController(IConfiguration config)
        {
            this.client = new HttpClient();
            baseAddress = config["ApiClient"];
            this.client.BaseAddress = new Uri(baseAddress);
        }
        [HttpGet]
        public IActionResult Index()
        {
            var response = client.GetStringAsync(this.client.BaseAddress + "categories").Result;
            List<CategoryModel> categories = JsonSerializer.Deserialize<List<CategoryModel>>(response);

            return View(categories);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var response = client.GetStringAsync(this.client.BaseAddress + $"categories/{id}").Result;
            CategoryModel categories = JsonSerializer.Deserialize<CategoryModel>(response);

            return View(categories);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(CategoryModel categoryModel)
        {
            var json = JsonSerializer.Serialize<CategoryModel>(categoryModel);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = client.PostAsync(this.client.BaseAddress + "categories", content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var response = client.GetStringAsync(this.client.BaseAddress + $"categories/{id}").Result;
            CategoryModel categories = JsonSerializer.Deserialize<CategoryModel>(response);

            return View(categories);

        }
        [HttpPost]
        public IActionResult Update(CategoryModel category)
        {
            var json = JsonSerializer.Serialize<CategoryModel>(category);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = client.PutAsync(this.client.BaseAddress + $"categories/{category.Id}", content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var response = client.GetStringAsync(this.client.BaseAddress + $"categories/{id}").Result;
            CategoryModel model = JsonSerializer.Deserialize<CategoryModel>(response);

            return View(model);
        }

        [HttpPost,ActionName("Delete")]
        public IActionResult ConfirmDelete(int id)
        {
            var response = client.DeleteAsync(this.client.BaseAddress + $"categories/{id}").Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
