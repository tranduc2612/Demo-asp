﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace demoaspcore.Models
{
    public partial class TChiTietNhanVien
    {
        public string MaNv { get; set; }
        public string ChucVu { get; set; }
        public byte? Hsluong { get; set; }
        public string MucDoCv { get; set; }
        public byte? Gtgc { get; set; }

        public virtual TNhanVien MaNvNavigation { get; set; }
    }
}