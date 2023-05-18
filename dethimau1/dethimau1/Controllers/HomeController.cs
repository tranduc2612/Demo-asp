using dethimau1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;

namespace dethimau1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        QlbanVaLiContext db = new QlbanVaLiContext();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.QuocGia = db.TQuocGia.ToList();
            List<TDanhMucSp> listProduct = db.TDanhMucSps.Where(x => x.MaLoai == "vali").ToList();
            return View(listProduct);
        }


        //public JsonResult GetSpLoai(string manuoc)
        //      {
        //          var lst = db.TDanhMucSps.Where(x=>x.MaNuocSx == manuoc).ToList();
        //          return new JsonResult(new { lst });
        //}

        [HttpGet]
        public JsonResult GetSpLoai(string manuoc)
        {
            var lst = db.TDanhMucSps.Where(x => x.MaNuocSx == manuoc).ToList();
            
            return new JsonResult(new { lst });
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