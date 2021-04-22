﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandyApp.Models;

namespace HandyApp.Controllers
{
    public class CustomerController : Controller
    {

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
         
            _db.Customers.Add(obj);
           
            _db.SaveChanges();



            return RedirectToAction("Index", "Home");
        }




    }
}
