using System;
using System.Collections.Generic;

namespace baitaptuluyen1.Models;

public partial class Cau3QlbanSachThem
{
    public string? MaNcc { get; set; }

    public string? TenNcc { get; set; }

    public string SoHdn { get; set; } = null!;

    public DateTime? NgayNhap { get; set; }

    public int? Slnhap { get; set; }

    public decimal? TriGiaHoaDon { get; set; }
}
