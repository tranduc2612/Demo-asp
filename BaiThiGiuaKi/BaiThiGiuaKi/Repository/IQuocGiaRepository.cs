using BaiThiGiuaKi.Models;

namespace BaiThiGiuaKi.Repository
{
    public interface IQuocGiaRepository
    {
        TQuocGium Add(TQuocGium QuocGia);
        TQuocGium Delete(TQuocGium QuocGia);
        TQuocGium GeTQuocGium(TQuocGium QuocGia);
        TQuocGium Update(TQuocGium QuocGia);
        IEnumerable<TQuocGium> GetAll();
    }
}
