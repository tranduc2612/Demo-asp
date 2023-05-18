using demoLayout.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace demoLayout.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult TestLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult TestLogin(Login login)
        {
            if (login.userName == "Peter" && login.password == "pass@123")
            {
                string msg = "Welcome " + login.userName;
                return RedirectToAction("Index");
            }
            else { 
                return View(); 
            }
        }
    

    public IActionResult Index()
        {
            var listuser = new List<User>();
            var user1 = new User();
            user1.Id = 1;
            user1.name= "Duc";
            user1.address = "Quang Ninh";
            user1.email = "mintduc2612@gmail.com";

            var user2 = new User();
            user2.Id = 2;
            user2.name = "HUHU";
            user2.address = "Quang Ninh";
            user2.email = "huhu@gmail.com";
            listuser.Add(user1);
            listuser.Add(user2);
            //ViewBag.listuser = listuser;
            return View();
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