using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDeveloper.Models.Account
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "The UserName is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "The Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "ConfirmPassword")]
        [StringLength(100,ErrorMessage ="The {0} must be at least {2} character long.")]
        [Required(ErrorMessage = "The ConfirmPassword is required")]
        [Compare("Password", ErrorMessage = "The Password and ConfirmPassword does not macht")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

    }
}
