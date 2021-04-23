using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandyApp.Models;

namespace HandyApp.Controllers
{
    public class handyController : Controller
    {


        private readonly ApplicationDbContext _db;

        public handyController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {


            IEnumerable<Asign> objList = _db.Asigns;


            foreach (var obj in objList)
            {
                obj.Employee = _db.Employees.FirstOrDefault(u => u.Id == obj.EmployeeNameId);
            }




            return View(objList);
        }

        

      



        }
    }

