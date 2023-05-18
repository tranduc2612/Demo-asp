using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using testtemplate13.Models;

namespace testtemplate13.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClbController : ControllerBase
    {
        QlbongDaContext db = new QlbongDaContext();
        [HttpGet]
        public List<Cauthu> cauthu(string id)
        {
            return db.Cauthus.Where(x=>x.CauLacBoId == id).ToList();
        }
    }
}
