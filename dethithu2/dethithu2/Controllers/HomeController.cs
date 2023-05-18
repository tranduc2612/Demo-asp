using dethithu2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace dethithu2.Controllers
{
    public class HomeController : Controller
    {
        QlbongDaContext db = new QlbongDaContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Cauthu> lstCauthu = db.Cauthus.ToList();
            return View(lstCauthu);
        }
		public IActionResult AddCauThu()
		{
			return View();
		}
        [HttpPost]
		public IActionResult AddCauThu(Cauthu cauthu)
		{
            if (ModelState.IsValid)
            {
				Cauthu newcauthu = new Cauthu();
                newcauthu.HoVaTen = cauthu.HoVaTen;
                newcauthu.CauThuId = cauthu.CauThuId;
                newcauthu.CauLacBoId = cauthu.CauLacBoId;
                newcauthu.Ngaysinh = cauthu.Ngaysinh;
                newcauthu.ViTri = cauthu.ViTri;
                newcauthu.QuocTich = cauthu.QuocTich;
                newcauthu.SoAo = cauthu.SoAo;
                newcauthu.Anh = cauthu.Anh;
                db.Cauthus.Add(newcauthu);
                db.SaveChanges();
                return RedirectToAction("Index");
			}
            return View();
		}
        [HttpGet]
		public IActionResult UpdateCauThu(string maCauThu)
		{
            var cauthu = db.Cauthus.Find(maCauThu);
			return View(cauthu);
		}

		[HttpPost]
		public IActionResult UpdateCauThu(Cauthu cauthu)
		{
			if (ModelState.IsValid)
			{
				db.Entry(cauthu).State = EntityState.Modified;
				db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View();
		}

		public IActionResult DeleteCauThu(string maCauThu)
		{
            var cauthu = db.Cauthus.Where(x => x.CauThuId == maCauThu).ToList();
            db.Cauthus.RemoveRange(cauthu);
            db.SaveChanges();
			return RedirectToAction("Index");
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