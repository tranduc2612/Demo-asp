using Microsoft.AspNetCore.Mvc;

namespace demoTemplate.Controllers
{
    public class YummyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
