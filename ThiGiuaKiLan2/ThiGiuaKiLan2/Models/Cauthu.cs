using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThiGiuaKiLan2.Models;

public partial class Cauthu
{
    public string CauThuId { get; set; } = null!;

    public string? HoVaTen { get; set; }

    public string? CauLacBoId { get; set; }

    public DateTime? Ngaysinh { get; set; }

    public string? ViTri { get; set; }

    public string? QuocTich { get; set; }

    [RegularExpression(@"^[0-9]*$", ErrorMessage = "chi nhap so")]
    public string? SoAo { get; set; }

    [RegularExpression(@"(.*/)*.+\.(png)$", ErrorMessage = "Nhap dung dinh dang")]
    public string? Anh { get; set; }
}
