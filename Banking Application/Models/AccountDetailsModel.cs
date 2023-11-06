using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Banking_Application.Models
{
   
    public class AccountDetailsModel
    {

        public int Acctid { get; set; }
        [Required]
            public int AccountNumber { get; set; }
            [Required]
            public string FirstName { get; set; }
            [Required]
            public string LastName { get; set; }
            [Required]
        public string MobileNo { get; set; }
            [Required]
            public decimal InterestRate { get; set; }
            [Required]
        public int id { get; set; }
            public List<SelectListItem>?accountOptions { get; set; }
            [Required]
            [Compare("ConfirmPassword")]
            public string Password { get; set; }    
            [Required]

            public string ConfirmPassword { get; set; }
        
    }
}