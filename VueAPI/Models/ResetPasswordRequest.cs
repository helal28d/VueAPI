 
using System.ComponentModel.DataAnnotations;
 

namespace VueAPI.Models
{
    public class ResetPasswordRequest
    {
        [Required]
        public string Token { get; set; }
        [Required, MinLength(6, ErrorMessage = "Please enter at least 6 characters, dude!")]
        public string Password { get; set; }
        [Required, Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}