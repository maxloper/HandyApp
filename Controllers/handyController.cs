using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandyApp.Models;
using HandyApp.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HandyApp.Controllers
{
    public class handyController : Controller
    {

        // DI for context in controller
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



        public IActionResult Update(int? id)
        {

            AsignVM asignVM = new AsignVM()
            {
                Asign = new Asign(),
                TypeDropDown = _db.Employees.Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                })
            };




            if (id == null || id == 0)
            {
                return NotFound();

            }

            asignVM.Asign = _db.Asigns.Find(id);

            if (asignVM.Asign == null)
            {
                return NotFound();
            }



            return View(asignVM);

        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdatePost(AsignVM obj)
        {


            _db.Asigns.Update(obj.Asign);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }


        public IActionResult Details(int? id)
        {
            AsignVM asignVM = new AsignVM()
            {
                Asign = new Asign(),
                TypeDropDown = _db.Employees.Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                })
            };




            if (id == null || id == 0)
            {
                return NotFound();

            }

            asignVM.Asign = _db.Asigns.Find(id);

            if (asignVM.Asign == null)
            {
                return NotFound();
            }



            return View(asignVM);
        }

    }
    }

