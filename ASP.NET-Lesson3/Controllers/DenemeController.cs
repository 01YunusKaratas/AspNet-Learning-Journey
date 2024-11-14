using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Lesson3.Controllers
{
    public class DenemeController : Controller
    {
        public IActionResult Index()
        {
          
            return RedirectToAction("Index1", "Deneme", new {name ="yunus emre karataş"});
        }

        
        public IActionResult Index1(string name)
        {


            ViewBag.Name = name;  // name parametresini ViewBag ile view'a gönderiyoruz
            return View();
        }
    }
}
