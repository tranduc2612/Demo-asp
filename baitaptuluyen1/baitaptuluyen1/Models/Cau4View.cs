using System;
using System.Collections.Generic;

namespace baitaptuluyen1.Models;

public partial class Cau4View
{
    public string MaSach { get; set; } = null!;

    public string? TenSach { get; set; }

    public int SoLuongBan { get; set; }

    public int SoLuongNhap { get; set; }

    public int? ChenhLech { get; set; }
}
