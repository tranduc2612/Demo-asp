using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dethithu2.Models;

public partial class Cauthu
{
    public string CauThuId { get; set; } = null!;

    public string? HoVaTen { get; set; }

    public string? CauLacBoId { get; set; }

    public DateTime? Ngaysinh { get; set; }

    public string? ViTri { get; set; }

	[RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Chi duoc nhap chu cai")]
	public string? QuocTich { get; set; }

    public string? SoAo { get; set; }

	[RegularExpression(@"(.*/)*.+\.(png|jpg|gif|bmp|jpeg|PNG|JPG|GIF|BMP|JPEG)$", ErrorMessage = "Nhap dung dinh dang")]
	public string? Anh { get; set; }
}
