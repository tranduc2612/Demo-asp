using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ThiGiuaKiLan2.Models;

namespace ThiGiuaKiLan2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TranDauController : ControllerBase
    {
        QlbongDaContext db = new QlbongDaContext();
        [HttpGet]
        public List<Cauthu> trandau(string idkhach,string idnha,string? matrandau)
        {
            return db.Cauthus.Where(x=>x.CauLacBoId == idkhach || x.CauLacBoId == idnha).ToList();
        }
    }
}
