using System;
using System.Collections.Generic;

namespace ThiGiuaKiLan2.Models;

public partial class Caulacbo
{
    public string CauLacBoId { get; set; } = null!;

    public string? TenClb { get; set; }

    public string? TenGoi { get; set; }

    public string? SanVanDongId { get; set; }

    public string? HuanLuyenVienId { get; set; }
}
