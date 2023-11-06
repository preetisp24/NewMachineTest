using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Banking_Application.Models
{
    public enum AccountType{ Saving,Current,Recurring}
   
    public class AccountDetails
    {
        [Key]
        public int Acctid { get; set; }
        public int AccountNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNo { get; set; }
        public decimal InterestRate { get; set; }

        public AccountType account { get; set; }
        public string Password { get; set; }
    }
}
