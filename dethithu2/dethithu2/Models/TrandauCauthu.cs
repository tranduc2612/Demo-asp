using System;
using System.Collections.Generic;

namespace dethithu2.Models;

public partial class TrandauCauthu
{
    public string TranDauId { get; set; } = null!;

    public string CauThuId { get; set; } = null!;

    public int? ThoiGianBatDau { get; set; }

    public int? ThoiGianKetThuc { get; set; }

    public string? PhamLoi { get; set; }
}
