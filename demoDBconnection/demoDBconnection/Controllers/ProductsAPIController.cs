using demoDBconnection.Models;
using demoDBconnection.Models.ProductModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace demoDBconnection.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsAPIController : ControllerBase
	{
		QlbanVaLiContext db = new QlbanVaLiContext();
		[HttpGet]

		public IEnumerable<TDanhMucSp> GetProductsByCategory()
		{
			return db.TDanhMucSps.ToList();
		}

		//[HttpGet]

		//public IEnumerable<Product> GetAllProducts(string maloai)
		//{
		
		//		var sanPham = (from p in db.TDanhMucSps select new Product
		//		{
		//			MaSp = p.MaSp,
		//			TenSp = p.TenSp,
		//			AnhDaiDien = p.AnhDaiDien,
		//			GiaNhoNhat = p.GiaNhoNhat
		//		}).ToList();
		//	return sanPham;
		//}

		[HttpGet("{maloai}")]
		public IEnumerable<Product> GetProductsByCategory(string maloai)
		{
			IList<Product> products = new List<Product>();
			var sanPhams = db.TDanhMucSps.Where(x => x.MaLoai == maloai).ToList();
			foreach(var s in sanPhams)
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
