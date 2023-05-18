using Azure;
using demoDBconnection.Models;
using demoDBconnection.Models.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;
using System.Diagnostics;
using X.PagedList;

namespace demoDBconnection.Controllers
{
    public class HomeController : Controller
    {
        QlbanVaLiContext db = new QlbanVaLiContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //[Authentication]
        public IActionResult Index(int? page)
        {
            int pageNum = page == null || page < 1 ? 1 : page.Value;
            int pageSize = 8;
            var listSp = db.TDanhMucSps.AsNoTracking().OrderBy(x=>x.TenSp);
            PagedList<TDanhMucSp> lst = new PagedList<TDanhMucSp>(listSp,pageNum,pageSize);
            return View(lst);
        }

        public IActionResult ChiTietSanPham(string maSp)
        {
            var sanpham = db.TDanhMucSps.SingleOrDefault(x => x.MaSp == maSp);
            var image = db.TAnhSps.Where(x => x.MaSp == maSp);
            ViewBag.image = image;
            if (sanpham == null)
            {
                return RedirectToAction("Index");
            }
            
            return View(sanpham);
        }

        public IActionResult SanPhamTheoLoai(int?page ,String Maloai)
        {
            int pageNum = page == null || page < 1 ? 1 : page.Value;
            int pageSize = 8;
            var listLoai = db.TDanhMucSps.AsNoTracking().Where(x => x.MaLoai == Maloai);
            PagedList<TDanhMucSp> lst = new PagedList<TDanhMucSp>(listLoai, pageNum, pageSize);
            ViewBag.maloai = Maloai;
            return View(lst);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Test()
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