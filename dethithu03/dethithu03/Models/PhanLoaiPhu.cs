﻿using System;
using System.Collections.Generic;

namespace dethithu03.Models;

public partial class PhanLoaiPhu
{
    public string MaPhanLoaiPhu { get; set; } = null!;

    public string? TenPhanLoaiPhu { get; set; }

    public string? MaPhanLoai { get; set; }

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
