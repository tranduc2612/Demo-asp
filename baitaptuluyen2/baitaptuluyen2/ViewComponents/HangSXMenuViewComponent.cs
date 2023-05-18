using baitaptuluyen2.Repository;
using Microsoft.AspNetCore.Mvc;

namespace baitaptuluyen2.ViewComponents
{
	public class HangSXMenuViewComponent: ViewComponent
	{
		private readonly IHangSXRepository _hangSp;
		public HangSXMenuViewComponent(IHangSXRepository hangSp)
		{
			_hangSp = hangSp;
		}

		public IViewComponentResult Invoke()
		{
			var lst = _hangSp.GetAll().OrderBy(x => x.HangSx).ToList();
			return View(lst);
		}
	}
}
