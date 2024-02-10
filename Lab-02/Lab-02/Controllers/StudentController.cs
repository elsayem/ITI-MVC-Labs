using Lab_02.Models;
using Lab_02.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Lab_02.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            StudentList db = new StudentList();
            List<Student>  m = db.GetAll();
            return View(m);
        }

        public IActionResult Create()
        {         
            
            return View();

        }

        //public IActionResult Add(int id, string name, int age, string email) {
            
        //    Student student = new Student() { Id=id,Name = name, Age= age,Email = email};

        //    //return Content("DATA Added");
        //    return Json(student); //return data as Json format
        //}
        public IActionResult Add(Student student) {
            StudentList db = new StudentList();

            //return Content("DATA Added");            
            //return Json(student); //return data as Json format

            db.Add(student);
            return RedirectToAction("Index");
        }

        public IActionResult DisplayAll() {
            
            StudentDepartmentListViewModel model = new StudentDepartmentListViewModel() { 
                StudentList= new StudentList(),
                DepartmentList=new DepartmentList(),
            };
            return View(model);
        
        }
    }
}
