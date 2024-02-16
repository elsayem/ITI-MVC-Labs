using Microsoft.AspNetCore.Mvc;
using MVC_Bootcamp.Data;
using MVC_Bootcamp.Models;

namespace MVC_Bootcamp.Controllers
{
    public class DepartmentController : Controller
    {
        MvcDbContext db = new MvcDbContext();

        public IActionResult Index()
        {
            var m = db.Departments.ToList();
            return View(m);
        }

        public IActionResult Create()
        {   
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(Department dept)
        {
            if(dept.DeptId != 0  &&dept.DeptName != null)
            {
                db.Departments.Add(dept);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(dept);
            }
           
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
                return BadRequest();
            //id.value due to the nullable type
            var model = db.Departments.FirstOrDefault(a =>a.DeptId==id.Value);
            if(model == null)
                return NotFound();

            return View(model);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
                return BadRequest();
            //id.value due to the nullable type
            var model = db.Departments.FirstOrDefault(a => a.DeptId == id.Value);
            if (model == null)
                return NotFound();

            db.Departments.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
                return BadRequest();
            //id.value due to the nullable type
            var model = db.Departments.FirstOrDefault(a => a.DeptId == id.Value);
            if (model == null)
                return NotFound();

            return View(model);
        }


        [HttpPost]

        public IActionResult Edit(Department dept)
        {
            if (dept.DeptId != 0 && dept.DeptName != null)
            {
                db.Departments.Update(dept);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(dept);
            }

        }
    }
}
