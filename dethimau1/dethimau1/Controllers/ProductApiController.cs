using dethimau1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dethimau1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductApiController : ControllerBase
    {
        QlbanVaLiContext db = new QlbanVaLiContext();

        [HttpGet("{manuoc}")]
        public IEnumerable<TDanhMucSp> GetAllProducts(string manuoc)
        {
            return db.TDanhMucSps.Where(x=>x.MaNuocSx == manuoc).ToList();
        }
    }
}
