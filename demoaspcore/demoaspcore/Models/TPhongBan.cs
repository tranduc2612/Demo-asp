﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace demoaspcore.Models
{
    public partial class TPhongBan
    {
        public TPhongBan()
        {
            TNhanVien = new HashSet<TNhanVien>();
        }

        public string MaPb { get; set; }
        public string Tenpb { get; set; }
        public string TruongPhong { get; set; }

        public virtual ICollection<TNhanVien> TNhanVien { get; set; }
    }
}