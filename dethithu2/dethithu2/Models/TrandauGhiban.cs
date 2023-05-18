using System;
using System.Collections.Generic;

namespace dethithu2.Models;

public partial class TrandauGhiban
{
    public string GhiBanId { get; set; } = null!;

    public string? TranDauId { get; set; }

    public string? CauLacBoId { get; set; }

    public int? ThoiDiemGhiBan { get; set; }

    public string? CauThuId { get; set; }

    public int? VaoLuoiNha { get; set; }
}
