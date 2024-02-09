using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace Lab_01.Controllers
{
    public class DataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string welcome(string n)
        {
            return $"Welcome {n}";
        }
        public string sum(int x, int y)
        {
            //return $"{x} + {y} = {x+y}" ;
            int res = x + y;
            return $"{x} + {y} = {res}";

            //return res;
        }



        #region Using Int return value type
        //Using INT as return value
        //public int sum(int x, int y)
        //{

        //    int res = x + y;
        //    //return $"{x} + {y} = {res}";

        //    return res;
        //}
        #endregion




        //public JsonResult JsSum(int x, int y) {
        //    //return $"{x} + {y} = {x+y}" ;
        //    var res = x + y;
        //    //return $"{x} + {y} = {x + y}";

        //    return Json(res, JsonRequestBehavior.AllowGet);
        //}
    }
}
