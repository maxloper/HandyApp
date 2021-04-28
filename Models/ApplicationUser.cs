using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace HandyApp.Models
{
    public class ApplicationUser:IdentityUser
    {
       
        // UserName seed for ASP.NET users in identity

        public string UsersName { get; set; }

    
    }
}
