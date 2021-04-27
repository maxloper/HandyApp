using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace HandyApp.Models
{
    public class ApplicationUser:IdentityUser
    {
       

        public string UsersName { get; set; }

        public string employeeNum { get; set; }
    }
}
