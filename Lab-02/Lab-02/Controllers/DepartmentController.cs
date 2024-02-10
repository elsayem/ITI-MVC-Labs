using Lab_02.Models;
using Lab_02.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Lab_02.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            DepartmentList db = new DepartmentList();
            List<Department> m = db.GetAll();


            return View(m);
        }


        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Add(Department dept) { 
            DepartmentList db = new DepartmentList();
            db.Add(dept);
            return RedirectToAction("index");
        
        }
        public IActionResult Display() {

            Student student = new Student() { Id=5, Name="Aziz", Age=30,Email="aziz.mahmoud@gmail.com"};
            Department Dept = new Department() { Id = 4, Name = "CEI" };
            StudentDepartmentViewModel StudentDepartmentObj = new StudentDepartmentViewModel() { Student=student,Department=Dept};

            return View(StudentDepartmentObj);
        }
    }
}
