using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandyApp.Models;

namespace HandyApp.Controllers
{
    public class CustomerController : Controller
    {


        // DI for context in controller
        private readonly ApplicationDbContext _db;

        public CustomerController(ApplicationDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            IEnumerable<Customer> objList = _db.Customers;

          

            return View(objList);
        }


        public IActionResult Create()
        {
           
            return View();
        }


        [HttpPost]
       
        [ValidateAntiForgeryToken]

        public IActionResult Create(Customer obj)
        {
            if (ModelState.IsValid)
            {
                _db.Customers.Add(obj);
           
                _db.SaveChanges();
                return RedirectToAction("Login", "Account");
            }

            return View(obj);
        }



        public IActionResult Delete(int? id)
        {


            if (id == null || id == 0)
            {
                return NotFound();

            }

            var obj = _db.Customers.Find(id);

            if (obj == null)
            {
                return NotFound();
            }



            return View(obj);

        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {

            var obj = _db.Customers.Find(id);
            if (obj == null)
            {
                return NotFound();

            }
            _db.Customers.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}
