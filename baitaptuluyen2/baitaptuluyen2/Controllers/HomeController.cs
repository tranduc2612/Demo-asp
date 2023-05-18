using baitaptuluyen2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using X.PagedList;

namespace baitaptuluyen2.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		QlbanVaLiContext db = new QlbanVaLiContext();	
		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index(string mahang, int? page)
		{
			int pageSize = 8;
			int pageNumber = page == null || page < -1 ? 1 : page.Value;
			PagedList<TDanhMucSp> lst;
			if (mahang==null)
			{
				var lstSP = db.TDanhMucSps.AsNoTracking().ToList();
				lst = new PagedList<TDanhMucSp>(lstSP, pageNumber, pageSize);
			}
			else
			{
				var lstSP = db.TDanhMucSps.AsNoTracking().Where(x=>x.MaHangSx == mahang);
				lst = new PagedList<TDanhMucSp>(lstSP, pageNumber, pageSize);
				ViewBag.mahang = mahang;
			}
			return View(lst);
		}




		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}