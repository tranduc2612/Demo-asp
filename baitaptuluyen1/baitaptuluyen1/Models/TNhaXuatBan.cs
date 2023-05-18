using System;
using System.Collections.Generic;

namespace baitaptuluyen1.Models;

public partial class TNhaXuatBan
{
    public string MaNxb { get; set; } = null!;

    public string? TenNxb { get; set; }

    public int? SlNxb { get; set; }

    public virtual ICollection<TSach> TSaches { get; } = new List<TSach>();
}
