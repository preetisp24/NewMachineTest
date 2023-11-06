using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Banking_Application.Models;

namespace Banking_Application.Controllers
{
    public class AccountDetailsController : Controller
    {
        private readonly AppDbContext _context;

        public AccountDetailsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: AccountDetails
        public async Task<IActionResult> Index()
        {
           

           // return View(AccountDetails);
              return _context.Accounts != null ?
                          View(await _context.Accounts.ToListAsync()) :
                          Problem("Entity set 'AppDbContext.Accounts'  is null.");
           
        }

      
        


        // GET: AccountDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Accounts == null)
            {
                return NotFound();
            }

            var accountDetails = await _context.Accounts
                .FirstOrDefaultAsync(m => m.Acctid == id);
            if (accountDetails == null)
            {
                return NotFound();
            }

            return View(accountDetails);
        }

        // GET: AccountDetails/Create
        public IActionResult Create()
        {
            var AccountDetail = new AccountDetailsModel
            {
                accountOptions = Enum.GetValues(typeof(AccountType))
            .Cast<AccountType>()
            .Select(e => new SelectListItem
            {
                Value = ((int)e).ToString(),
                Text = e.ToString()
            }).ToList()
            };
            return View(AccountDetail);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AccountDetailsModel model)
        {
            if (ModelState.IsValid)
            {
                AccountDetails act = new AccountDetails()
                {
                    AccountNumber = model.AccountNumber,
                    FirstName=model.FirstName,
                    LastName=model.LastName,
                    MobileNo=model.MobileNo,
                    InterestRate=model.InterestRate,
                    account = (AccountType)model.id,
                    Password =model.Password

                };
                _context.Add(act);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            model.accountOptions = Enum.GetValues(typeof(AccountType))
       .Cast<AccountType>()
       .Select(e => new SelectListItem
       {
           Value = ((int)e).ToString(),
           Text = e.ToString()
       })
       .ToList();
            return View(model);

        }

        // GET: AccountDetails/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null || _context.Accounts == null)
        //    {
        //        return NotFound();
        //    }

        //    var accountDetails = await _context.Accounts.FindAsync(id);
        //    if (accountDetails == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(accountDetails);
        //}

        //// POST: AccountDetails/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("AccountNumber,FirstName,LastName,MobileNo,InterestRate,account,Password")] AccountDetails accountDetails)
        //{
        //    if (id != accountDetails.AccountNumber)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(accountDetails);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!AccountDetailsExists(accountDetails.AccountNumber))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(accountDetails);
        //}

        //// GET: AccountDetails/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null || _context.Accounts == null)
        //    {
        //        return NotFound();
        //    }

        //    var accountDetails = await _context.Accounts
        //        .FirstOrDefaultAsync(m => m.AccountNumber == id);
        //    if (accountDetails == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(accountDetails);
        //}

        //// POST: AccountDetails/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    if (_context.Accounts == null)
        //    {
        //        return Problem("Entity set 'AppDbContext.Accounts'  is null.");
        //    }
        //    var accountDetails = await _context.Accounts.FindAsync(id);
        //    if (accountDetails != null)
        //    {
        //        _context.Accounts.Remove(accountDetails);
        //    }
            
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool AccountDetailsExists(int id)
        //{
        //  return (_context.Accounts?.Any(e => e.AccountNumber == id)).GetValueOrDefault();
        //}
    }
}
