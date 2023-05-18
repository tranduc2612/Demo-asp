using BaiThiGiuaKi.Models;

namespace BaiThiGiuaKi.Repository
{
    public class QuocGiaRepository : IQuocGiaRepository
    {
        private readonly QlbanVaLiContext _context;

        public TQuocGium Add(TQuocGium QuocGia)
        {
            throw new NotImplementedException();
        }

        public TQuocGium Delete(TQuocGium QuocGia)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TQuocGium> GetAll()
        {
            return _context.TQuocGia;
        }

        public TQuocGium GeTQuocGium(TQuocGium QuocGia)
        {
            throw new NotImplementedException();
        }

        public TQuocGium Update(TQuocGium QuocGia)
        {
            throw new NotImplementedException();
        }
    }
}
