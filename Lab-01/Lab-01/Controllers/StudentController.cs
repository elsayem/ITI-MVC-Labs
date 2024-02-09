using Lab_01.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_01.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult StdView()
        {
            Student sudent01 = new Student() { id= 1, name="Abdulrahman", age=25};
            return View(sudent01);
        }
    }
}
