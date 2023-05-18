using System;
using System.Collections.Generic;

namespace baitaptuluyen1.Models;

public partial class THoaDonBan
{
    public string SoHdb { get; set; } = null!;

    public string? MaNv { get; set; }

    public DateTime? NgayBan { get; set; }

    public string? MaKh { get; set; }

    public int? SoSanPhamBan { get; set; }

    public virtual TKhachHang? MaKhNavigation { get; set; }

    public virtual TNhanVien? MaNvNavigation { get; set; }

    public virtual ICollection<TChiTietHdb> TChiTietHdbs { get; } = new List<TChiTietHdb>();
}
