using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Bootcamp.Data;
using MVC_Bootcamp.Models;

namespace MVC_Bootcamp.Controllers
{
    public class StudentController : Controller
    {
        MvcDbContext db = new MvcDbContext();
        public IActionResult Index()
        {
            var model = db.Students.Include(d =>d.Department).ToList();
            return View(model);
        }

        //
        public IActionResult Create()
        {
            ViewBag.dept = db.Departments.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            if ( student.Name != null && student.Age >= 20 && student.Age <= 40)
            {
                db.Students.Add(student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.dept = db.Departments.ToList();
                return View(student);
            }

        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
                return BadRequest();
            //id.value due to the nullable type
            var model = db.Students.FirstOrDefault(a => a.Id == id.Value);
            if (model == null)
                return NotFound();
            ViewBag.dept = db.Departments.ToList();
            return View(model);
        }


        [HttpPost]
        public IActionResult Edit(Student std)
        {
            if (std.Id != 0 && std.Name != null)
            {
                db.Students.Update(std);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.dept = db.Departments.ToList();
                return View(std);   
            }

        }


        public IActionResult Delete(int? id)
        {

            if (id == null)
                return BadRequest();
            //id.value due to the nullable type
            var model = db.Students.FirstOrDefault(a => a.Id == id.Value);
            if (model == null)
                return NotFound();

            db.Students.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }









        #region Add Image Controller 
        public IActionResult AddImg()
        {
            return View();

        }
        [HttpPost]
        public IActionResult AddImg(int i, IFormFile img)
        {
            string imgName = i.ToString() + "." + img.FileName.Split('.').Last();
            using (FileStream f01 = new FileStream("wwwroot/Images/" + imgName, FileMode.Create))
            {
                img.CopyTo(f01);
            }
            return Content("Image Added");

        }
        #endregion

    }
}
