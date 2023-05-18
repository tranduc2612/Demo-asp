using baitaptuluyen2.Models;

namespace baitaptuluyen2.Repository
{
	public class HangSXRepository : IHangSXRepository
	{
		private readonly QlbanVaLiContext _context;

		public HangSXRepository(QlbanVaLiContext context)
		{
			_context = context;
		}

		public THangSx Add(THangSx HangSx)
		{
			throw new NotImplementedException();
		}

		public THangSx Delete(THangSx HangSx)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<THangSx> GetAll()
		{
			return _context.THangSxes;
		}

		public THangSx GeTHangSx(THangSx HangSx)
		{
			throw new NotImplementedException();
		}

		public THangSx Update(THangSx HangSx)
		{
			throw new NotImplementedException();
		}
	}
}
