﻿using System;
using System.Collections.Generic;

namespace testtemplate13.Models;

public partial class Huanluyenvien
{
    public string HuanLuyenVienId { get; set; } = null!;

    public string? TenHlv { get; set; }

    public int? NamSinh { get; set; }

    public string? QuocTich { get; set; }

    public string? Anh { get; set; }
}
