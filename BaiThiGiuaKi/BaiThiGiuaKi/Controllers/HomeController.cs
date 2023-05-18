using Azure;
using BaiThiGiuaKi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Drawing.Printing;
using X.PagedList;

namespace BaiThiGiuaKi.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
        QlbanVaLiContext db = new QlbanVaLiContext();
        public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index(int? page,string? manuoc)
		{
			PagedList<TDanhMucSp> lst;

            if (manuoc == null)
			{
                int pageSize = 8;
                int pageNumber = page == null || page < -1 ? 1 : page.Value;
                var listSp = db.TDanhMucSps.AsNoTracking().OrderBy(x => x.TenSp);
                lst = new PagedList<TDanhMucSp>(listSp, pageNumber, pageSize);
			}
			else
			{
                int pageSize = 8;
                int pageNumber = page == null || page < -1 ? 1 : page.Value;
                var listSp = db.TDanhMucSps.AsNoTracking().OrderBy(x => x.TenSp).Where(x=>x.MaNuocSx == manuoc);
                lst = new PagedList<TDanhMucSp>(listSp, pageNumber, pageSize);
            }
            
			ViewBag.quocgia = db.TQuocGia.ToList();
            return View(lst);
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