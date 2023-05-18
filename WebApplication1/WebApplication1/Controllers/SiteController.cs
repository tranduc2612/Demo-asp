using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{

    public class SiteController : Controller
    {
        public static List<HttpPostedFileBase> ListImg = new List<HttpPostedFileBase>();

        // GET: Site
        public ActionResult Index()
        {
            //QLXemPhimEntities db = new QLXemPhimEntities();
            //List<tKhachHang> dsKhachHang = db.tKhachHangs.ToList();
            @ViewBag.isLogin = false;
       
            return View();
        }

        

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Index(User data)
        {
      
            foreach (var pathImg in ListImg)
            {
                // đưa lên database

                string _FileName = Path.GetFileName(pathImg.FileName);
                string sourceFile = Path.Combine(Server.MapPath("~/data/temp"), _FileName);
                string destinationFile = Path.Combine(Server.MapPath("~/data/imgpost"));
                System.IO.File.Move(sourceFile, destinationFile);

                System.IO.File.Delete(sourceFile);

                return View();

            }
            ViewBag.data = ModelState.IsValid;
            ViewBag.active = "active";

            ViewBag.name = data.name;

            if (!ModelState.IsValid)
            {
                ViewBag.active = "active";
            }
                       
            return View();
        }


        [HttpPost]
        public ActionResult UpLoadFile(HttpPostedFileBase upload)
        {
            if (upload.ContentLength > 0 && upload != null)
            {
                string _FileName = Path.GetFileName(upload.FileName);
                string _FolderName = Path.Combine(Server.MapPath("~/data/temp/id-user"));
                
                if (Directory.Exists(_FolderName))
                {
                    string _path = Path.Combine(Server.MapPath("~/data/temp/id-user/"), _FileName);
                    upload.SaveAs(_path);
                    return Json(new { url = "https://localhost:44308/" + "data/temp/id-user/" + _FileName });

                }
                else
                {
                    System.IO.Directory.CreateDirectory(_FolderName);
                    string _path = Path.Combine(Server.MapPath("~/data/temp/id-user/"), _FileName);
                    upload.SaveAs(_path);
                    return Json(new { url = "https://localhost:44308/" + "data/temp/id-user/" + _FileName });

                }
            }
            else
            {
                return Json(new { message = "Error" });
            }
        }

        public ActionResult About()
        {
            QLXemPhimEntities db = new QLXemPhimEntities();
            List<tKhachHang> listKh = db.tKhachHangs.ToList();
            ViewBag.listKh = listKh;
            return View();
        }
    }
}