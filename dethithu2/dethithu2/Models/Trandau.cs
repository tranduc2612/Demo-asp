using System;
using System.Collections.Generic;

namespace dethithu2.Models;

public partial class Trandau
{
    public string TranDauId { get; set; } = null!;

    public DateTime? NgayThiDau { get; set; }

    public string? Clbkhach { get; set; }

    public string? Clbnha { get; set; }

    public string? SanVanDongId { get; set; }

    public int? Vong { get; set; }

    public DateTime? HiepPhu { get; set; }

    public string? KetQua { get; set; }

    public bool? TrangThai { get; set; }
}
