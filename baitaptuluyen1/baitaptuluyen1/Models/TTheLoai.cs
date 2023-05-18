using System;
using System.Collections.Generic;

namespace baitaptuluyen1.Models;

public partial class TTheLoai
{
    public string MaTheLoai { get; set; } = null!;

    public string? TenTheLoai { get; set; }

    public int? TongSoDauSach { get; set; }

    public virtual ICollection<TSach> TSaches { get; } = new List<TSach>();
}
