using System;
using System.Collections.Generic;

namespace baitaptuluyen1.Models;

public partial class TKhachHang
{
    public string MaKh { get; set; } = null!;

    public string? TenKh { get; set; }

    public string? DiaChi { get; set; }

    public string? DienThoai { get; set; }

    public bool? GioiTinh { get; set; }

    public int? SlsachMua { get; set; }

    public virtual ICollection<THoaDonBan> THoaDonBans { get; } = new List<THoaDonBan>();
}
