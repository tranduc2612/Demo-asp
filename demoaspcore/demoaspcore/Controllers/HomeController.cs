using demoaspcore.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
using Azure;

namespace demoaspcore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IHostingEnvironment _env;

        public HomeController(ILogger<HomeController> logger, IHostingEnvironment _environment)
        {
            _env = _environment;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(User user,IFormFile filse,string content)
        {
            ViewBag.content = content;
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}
            //else
            //{
            //    return RedirectToAction("Privacy");
            //}
            return View();
        }
        [HttpPost]
        public IActionResult UpLoadFile(List<IFormFile> files)
        {
            var filepath = "";
            var userID = "id-user1";
            string serverMapPath = Path.Combine(this._env.WebRootPath, "Image", userID);

            //Directory.GetCurrentDirectory()
            foreach (IFormFile photo in Request.Form.Files) 
            {
                string milliseconds = DateTimeOffset.Now.ToUnixTimeMilliseconds().ToString();
                if (Directory.Exists(serverMapPath))
                {
                    string serverMapPathFile = Path.Combine(this._env.WebRootPath, "Image", userID, milliseconds+photo.FileName);
                    using (var stream = new FileStream(serverMapPathFile, FileMode.Create))
                    { 
                        photo.CopyTo(stream);
                    }
                }
                else
                {
                    Directory.CreateDirectory(serverMapPath);
                    string serverMapPathFile = Path.Combine(this._env.WebRootPath, "Image", userID, milliseconds+photo.FileName);
                    using (var stream = new FileStream(serverMapPathFile, FileMode.Create))
                    {
                        photo.CopyTo(stream);
                    }
                }
                
                filepath = "https://localhost:7133/"+"Image/"+userID+"/"+ milliseconds + photo.FileName;
            }
            return Json(new { url = filepath });
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