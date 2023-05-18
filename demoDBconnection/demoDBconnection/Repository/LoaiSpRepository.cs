using demoDBconnection.Models;

namespace demoDBconnection.Repository
{
    public class LoaiSpRepository : ILoaiSpRepository
    {
        private readonly QlbanVaLiContext _context;
        public LoaiSpRepository(QlbanVaLiContext context)
        {
            _context = context;
        }
        public TLoaiSp Add(TLoaiSp loaisp)
        {
            throw new NotImplementedException();
        }

        public TLoaiSp Delete(string maloai)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TLoaiSp> GetAllLoaiSp()
        {
            return _context.TLoaiSps;
        }


        public TLoaiSp GetLoaiSp(string Maloai)
        {
            throw new NotImplementedException();
        }

        public TLoaiSp Update(string maloai)
        {
            throw new NotImplementedException();
        }
    }
}
