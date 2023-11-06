using Banking_Application.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Banking_Application.Areas.Users.Controllers
{
    [Area("Users")]
    public class UserController : Controller
    {
        AppDbContext _db;
        public UserController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Details()
        {
            var account = _db.Accounts?.FirstOrDefault();
            UserModel model = new UserModel();
            if (account != null)
            {
                model.UserName = account.AccountNumber;
            }
            //int acctno = model.UserName;
            var user = (from u in _db.Accounts
                        where u.AccountNumber ==model.UserName
                        select new AccountDetails
                        {
                          AccountNumber=u.AccountNumber,
                          FirstName=u.FirstName,
                          LastName=u.LastName,
                          MobileNo=u.MobileNo,
                          InterestRate=u.InterestRate,
                          account=u.account

                        }).SingleOrDefault();

            return View(user);
        }
    }
}
