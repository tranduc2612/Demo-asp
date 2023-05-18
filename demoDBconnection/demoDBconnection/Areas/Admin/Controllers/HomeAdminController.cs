using Azure;
using demoDBconnection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

namespace demoDBconnection.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin")]
    [Route("admin/homeadmin")]

    public class HomeAdminController : Controller
    {
        QlbanVaLiContext db = new QlbanVaLiContext();
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("danhsachsanpham")]
        public IActionResult DanhSachSanPham(int? page)
        {
            int pageNum = page == null || page < 1 ? 1 : page.Value;
            int pageSize = 10;
            var listSp = db.TDanhMucSps.AsNoTracking().OrderBy(x => x.TenSp);
            PagedList<TDanhMucSp> lst = new PagedList<TDanhMucSp>(listSp, pageNum, pageSize);
            return View(lst);
        }

        [Route("SuaSanPham")]
        [HttpGet]
        public IActionResult SuaSanPham(string masanpham)
        {
            ViewBag.MaChatLieu = new SelectList(db.TChatLieus, "MaChatLieu", "ChatLieu");
            ViewBag.MaHangSx = new SelectList(db.THangSxes, "MaHangSx", "HangSx");
            ViewBag.MaNuocSx = new SelectList(db.TQuocGia, "MaNuoc", "TenNuoc");
            ViewBag.MaDt = new SelectList(db.TLoaiSps, "MaLoai", "Loai");
            ViewBag.MaDt = new SelectList(db.TLoaiDts, "MaDt", "TenLoai");
            var sanpham = db.TDanhMucSps.Find(masanpham);  
            return View(sanpham);
        }

        [Route("SuaSanPham")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SuaSanPham(TDanhMucSp sanpham)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sanpham).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("DanhSachSanPham","HomeAdmin");
            }

            return View(sanpham);
        }

        [Route("xoasanpham")]
        [HttpGet]
        public IActionResult XoaSanPham(string? masanpham)
        {
            TempData["Message"] = "";
            var lstChiTiet = db.TChiTietSanPhams.Where(x=>x.MaSp == masanpham);
            foreach(var item in lstChiTiet)
            {
                if(db.TChiTietHdbs.Where(x=>x.MaChiTietSp==item.MaChiTietSp)!= null)
                {
                    TempData["Message"] = "Không xóa được sản phẩm này";
                    return RedirectToAction("DanhSachSanPham");
                }
            }
            var lstAnh = db.TAnhSps.Where(x=>x.MaSp ==masanpham);
            if (lstAnh != null) db.RemoveRange(lstAnh);
            if (lstChiTiet != null) db.RemoveRange(lstChiTiet);
            db.Remove(db.TDanhMucSps.Find(masanpham));
            db.SaveChanges();
            TempData["Message"] = "Sản phẩm đã được xóa";
            return RedirectToAction("DanhSachSanPham");
        }

    }
}
