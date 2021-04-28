using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandyApp.Controllers
{
    public class LoginController : Controller
    {


        // login returns view only 
        public IActionResult Index()
        {
            return View();
        }



    }
}
