using baitaptuluyen1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using X.PagedList;

namespace baitaptuluyen1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        QlbanSachLuyenThemContext db = new QlbanSachLuyenThemContext();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int? page)
        {
            int pageSize = 9;
            int pageNumber = page==null||page<-1?1:page.Value;
            var lstSach = db.TSaches.AsNoTracking().ToList();
            PagedList<TSach> lst = new PagedList<TSach>(lstSach, pageNumber, pageSize);
            return View(lst);
        }

        public IActionResult SanPhamTheoLoai(string? loai)
        {
            List<TSach> lst = db.TSaches.Where(x=>x.TacGia == loai).ToList();
            return View(lst);
        }

        public IActionResult Products()
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