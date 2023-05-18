using dethithu2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dethithu2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClbController : ControllerBase
    {
        QlbongDaContext db = new QlbongDaContext();
        [HttpGet("{idClb}")]
        public List<Cauthu> ShowClb(string? idClb)
        {
            return db.Cauthus.Where(x => x.CauLacBoId == idClb).ToList();
        }
    }
}
