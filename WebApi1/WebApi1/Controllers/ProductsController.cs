using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi1.Models;
using WebApi1.Models.ProductModels;

namespace WebApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        QlbanVaLiContext db = new QlbanVaLiContext();

        [HttpGet("{maloai}")]
        public IEnumerable<Product> GetProductsByCategory(string maloai)
        {
            IList<Product> products = new List<Product>();
            var sanPhams = db.TDanhMucSps.Where(x => x.MaLoai == maloai).ToList();
            foreach (var s in sanPhams)
            {
                products.Add(new Product
                {
                    MaSp = s.MaSp,
                    TenSp = s.TenSp,
                    AnhDaiDien = s.AnhDaiDien,
                    GiaNhoNhat = s.GiaNhoNhat
                });
            }

            return products;
        }
    }
}
