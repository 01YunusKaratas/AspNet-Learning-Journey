using ASP.NET_Lesson4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASP.NET_Lesson4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //ViewBag gösterimi
        public IActionResult Index()
        {
            User user1 = new User();

            user1.name = "TEST";
            user1.surname = "DENEME";
            user1.age = 10;

            ViewBag.user = user1; //added into viewbag

            return View();
        }


        //ViewData gösterimi
        public IActionResult Index1()
        {

            ViewData["name"] = "test deneme";
            ViewData["info"] = "data transfer with viewdata "; //viewdata string gönderdik

            List<User> users = new List<User>()  //viewdataya liste gönderdik onu dönderdik
            {
                new User(){name="yunus emre",surname="karataþ",age=24},
                new User(){name="ömer",surname="karataþ",age=24},
                new User(){name="muhsin",surname="ay",age=24}
            };

            ViewData["listem"] = users; // bilgileri viewdataya yükledik ve cshtmle gönderdik .


            return View();
        }


        //TempData
        public IActionResult Index2()
        {
            TempData["lesson"] = "ASP.NET programming with C# language";

            // Index3 action'ýna yönlendirme yapýyoruz
            return View();
        }

        public IActionResult Index3()
        {
            var surname = TempData["lesson"];

            ViewBag.surname = surname;  


            return View();
        }


        //ViewModel

        public IActionResult Index4()
        {

            Product pr1 = new Product(); //Instance for Product

            pr1.ID = 12;
            pr1.Name = "deneme";





            return View(pr1);
        }



















        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
