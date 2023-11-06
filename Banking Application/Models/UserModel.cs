using System.ComponentModel.DataAnnotations;

namespace Banking_Application.Models
{
    public class UserModel
    {

        [Required]
        //[Display("UserName")]
        public int UserName { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "enter correct length")]
        public string Password { get; set; }
    }
}
