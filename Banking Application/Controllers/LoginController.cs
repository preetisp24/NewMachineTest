using Banking_Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace Banking_Application.Controllers
{
    public class LoginController : Controller
    {
        AppDbContext _db;
        public LoginController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserModel model)
        {
    
            var account = _db.Accounts?.FirstOrDefault();

            if (account != null)
            {
                model.UserName = account.AccountNumber;
                model.Password = account.Password;

                return RedirectToAction("Details", "User", new { area = "Users" });
             
            }
           // TempData["details"]= model.UserName;
            return View();
        }
       
    }

}

