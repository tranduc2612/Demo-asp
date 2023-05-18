using demoDBconnection.Models;

namespace demoDBconnection.Repository
{
    public interface ILoaiSpRepository
    {
        TLoaiSp Add(TLoaiSp loaisp);
        TLoaiSp Update(string maloai);
        TLoaiSp Delete(string maloai);
 
        TLoaiSp GetLoaiSp(string Maloai);
        IEnumerable<TLoaiSp> GetAllLoaiSp();

    }
}
