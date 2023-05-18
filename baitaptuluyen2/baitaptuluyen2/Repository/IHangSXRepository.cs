using baitaptuluyen2.Models;

namespace baitaptuluyen2.Repository
{
	public interface IHangSXRepository
	{
		THangSx Add(THangSx HangSx);
		THangSx Delete(THangSx HangSx);
		THangSx GeTHangSx(THangSx HangSx);
		THangSx Update(THangSx HangSx);

		IEnumerable<THangSx> GetAll();
	}
}
