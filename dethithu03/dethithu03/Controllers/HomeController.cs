using dethithu03.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace dethithu03.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		QlbanNoiContext db = new QlbanNoiContext();

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			var lst = db.SanPhams.ToList();
			var query = (from sp in db.SanPhams join
						loai in db.PhanLoais on sp.MaPhanLoai equals loai.MaPhanLoai 
						 where loai.MaPhanLoai == "001"
						 select new { SanPham=sp,Loai = loai }).ToList();
			return View(lst);
		}
		[HttpGet]
		public IActionResult Category(string maCategory)
		{
			var lst = db.SanPhams.Where(x=>x.MaPhanLoai == maCategory).ToList();
			return new JsonResult(new { lst });
		}

		public IActionResult Add()
		{
			ViewBag.MaPhanLoai = new SelectList(db.PhanLoais.ToList(), "MaPhanLoai", "PhanLoaiChinh");
			ViewBag.MaPhanLoaiPhu = new SelectList(db.PhanLoaiPhus.ToList(), "MaPhanLoaiPhu", "TenPhanLoaiPhu");

			return View();
		}

		[HttpPost]
		public IActionResult Add(SanPham sp)
		{

			if (ModelState.IsValid)
			{
				db.SanPhams.Add(sp);
				db.SaveChanges();
				return RedirectToAction("Index", "Home");
			}
            ViewBag.MaPhanLoai = new SelectList(db.PhanLoais.ToList(), "MaPhanLoai", "PhanLoaiChinh");
            ViewBag.MaPhanLoaiPhu = new SelectList(db.PhanLoaiPhus.ToList(), "MaPhanLoaiPhu", "TenPhanLoaiPhu");
            return View(sp);
		}

		[HttpGet]
		public IActionResult Update(string maSp)
		{
			SanPham sp = db.SanPhams.FirstOrDefault(x=>x.MaSanPham== maSp);
			if(sp == null)
			{
				return RedirectToAction("Index");
			}
            ViewBag.MaPhanLoai = new SelectList(db.PhanLoais.ToList(), "MaPhanLoai", "PhanLoaiChinh");
            ViewBag.MaPhanLoaiPhu = new SelectList(db.PhanLoaiPhus.ToList(), "MaPhanLoaiPhu", "TenPhanLoaiPhu");
            return View(sp);
		}

		[HttpPost]
		public IActionResult Update(SanPham sp)
		{
            if (ModelState.IsValid)
            {
                db.SanPhams.Update(sp);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            ViewBag.MaPhanLoai = new SelectList(db.PhanLoais.ToList(), "MaPhanLoai", "PhanLoaiChinh");
            ViewBag.MaPhanLoaiPhu = new SelectList(db.PhanLoaiPhus.ToList(), "MaPhanLoaiPhu", "TenPhanLoaiPhu");
            return View(sp);
        }

		[HttpGet]

		public IActionResult Delete(string maSp)
		{
			SanPham sp = db.SanPhams.Where(x=>x.MaSanPham == maSp).FirstOrDefault();
			if (sp!=null)
			{

				//db.SptheoMaus.RemoveRange(db.SptheoMaus.Where(x=>x.MaSanPham==sp.MaSanPham).ToList());
				db.SanPhams.Remove(sp);
				db.SaveChanges();
                return RedirectToAction("Index");
            }
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