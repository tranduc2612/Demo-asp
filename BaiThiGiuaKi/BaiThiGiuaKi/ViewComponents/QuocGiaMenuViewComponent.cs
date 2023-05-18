using BaiThiGiuaKi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BaiThiGiuaKi.ViewComponents
{
    public class QuocGiaMenuViewComponent : ViewComponent
    {
        private readonly IQuocGiaRepository _QuocGia;
        public QuocGiaMenuViewComponent(IQuocGiaRepository QuocGia)
        {
            _QuocGia = QuocGia;
        }

        public IViewComponentResult Invoke()
        {
            var lst = _QuocGia.GetAll().OrderBy(x => x.MaNuoc).ToList();
            return View(lst);
        }
    }
}
