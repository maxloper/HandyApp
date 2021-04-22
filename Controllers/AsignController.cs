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
    public class AsignController : Controller
    {

        private readonly ApplicationDbContext _db;

        public AsignController(ApplicationDbContext db)
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

        public IActionResult Create()
        {


            //IEnumerable<SelectListItem> typeDropDown = _db.Employees.Select(i => new SelectListItem
            //{
            //    Text =i.Name + "  Speciality =  " + i.Speciality,
            //    Value = i.Id.ToString()
            //});

            //ViewBag.typeDropDown = typeDropDown;

            AsignVM asignVM = new AsignVM()
            {
                Asign = new Asign(),
                TypeDropDown = _db.Employees.Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                })
            };



            return View(asignVM);
        }



        [HttpPost]

        [ValidateAntiForgeryToken]

        public IActionResult Create(AsignVM obj)
        {

            _db.Asigns.Add(obj.Asign);

            _db.SaveChanges();



            return RedirectToAction("Index");


        }

        public IActionResult Delete(int? id)
        {


            if (id == null || id == 0)
            {
                return NotFound();

            }

            var obj = _db.Asigns.Find(id);

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

            var obj = _db.Asigns.Find(id);
            if (obj == null)
            {
                return NotFound();

            }
            _db.Asigns.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }


    }
}
