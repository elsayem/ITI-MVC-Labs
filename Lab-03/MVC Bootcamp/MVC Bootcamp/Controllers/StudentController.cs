using Microsoft.AspNetCore.Mvc;
using MVC_Bootcamp.Data;

namespace MVC_Bootcamp.Controllers
{
    public class StudentController : Controller
    {
        MvcDbContext db = new MvcDbContext();
        public IActionResult Index()
        {
            return View();
        }

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
    }
}
