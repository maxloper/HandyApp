using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HandyApp.Models.ViewModels
{
    public class RegisterViewModel
    {

        [Required,EmailAddress,MaxLength(256)]
        public string Email { get; set; }
        [Required,MinLength(6), MaxLength(50),DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, MinLength(6), MaxLength(50), DataType(DataType.Password)]
        [Compare("Password",ErrorMessage = "Password does not match")]
        public string ConfirmPassword { get; set; }
    }
}
