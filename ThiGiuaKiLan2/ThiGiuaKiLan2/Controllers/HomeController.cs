using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using ThiGiuaKiLan2.Models;

namespace ThiGiuaKiLan2.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		QlbongDaContext db = new QlbongDaContext();

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			List<Cauthu> cauthu = db.Cauthus.Where(x=>x.CauLacBoId == "101").ToList();
			return View(cauthu);
		}

        public IActionResult Update(string macauthu)
        {
            var cauthu = db.Cauthus.Find(macauthu);
            return View(cauthu);
         
        }

        [HttpPost]
        public IActionResult Update(Cauthu cauthu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cauthu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
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