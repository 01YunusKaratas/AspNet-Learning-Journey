using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Lesson2.Controllers
{
    public class OrnekController : Controller
    {
        public IActionResult Index()
        {


            return View();
        }

        public IActionResult ContentResult()
        {

            return Content("Content Result");
        }


        public IActionResult JsonResult()
        {

            return Json(new { id = 1, name = "yunus", school = "MCBÜ" });
        }

        public IActionResult EmptyResult()
        {
            return new EmptyResult();//hiçbirşey döndürmez.

        }
    }
}
