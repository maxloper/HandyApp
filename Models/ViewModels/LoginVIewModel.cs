using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace HandyApp.Models.ViewModels
{
    public class LoginVIewModel
    {
        [Required]
      
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public Boolean RememberMe { get; set; }

    }
}
