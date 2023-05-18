﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QLXemPhimEntities : DbContext
    {
        public QLXemPhimEntities()
            : base("name=QLXemPhimEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tChiTietHoaDon> tChiTietHoaDons { get; set; }
        public virtual DbSet<tDichVu> tDichVus { get; set; }
        public virtual DbSet<tHangSX> tHangSXes { get; set; }
        public virtual DbSet<tHoaDon> tHoaDons { get; set; }
        public virtual DbSet<tKhachHang> tKhachHangs { get; set; }
        public virtual DbSet<tLichChieu> tLichChieux { get; set; }
        public virtual DbSet<tNhanVien> tNhanViens { get; set; }
        public virtual DbSet<tNuocSX> tNuocSXes { get; set; }
        public virtual DbSet<tPhim> tPhims { get; set; }
        public virtual DbSet<tPhongChieu> tPhongChieux { get; set; }
        public virtual DbSet<tTheLoai> tTheLoais { get; set; }
        public virtual DbSet<tVe> tVes { get; set; }
        public virtual DbSet<view2> view2 { get; set; }
        public virtual DbSet<view7> view7 { get; set; }
    
        [DbFunction("QLXemPhimEntities", "Cau1F")]
        public virtual IQueryable<Cau1F_Result> Cau1F(string diaChi)
        {
            var diaChiParameter = diaChi != null ?
                new ObjectParameter("DiaChi", diaChi) :
                new ObjectParameter("DiaChi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<Cau1F_Result>("[QLXemPhimEntities].[Cau1F](@DiaChi)", diaChiParameter);
        }
    
        [DbFunction("QLXemPhimEntities", "Cau6F")]
        public virtual IQueryable<Cau6F_Result> Cau6F(Nullable<int> age, string diaChi)
        {
            var ageParameter = age.HasValue ?
                new ObjectParameter("Age", age) :
                new ObjectParameter("Age", typeof(int));
    
            var diaChiParameter = diaChi != null ?
                new ObjectParameter("DiaChi", diaChi) :
                new ObjectParameter("DiaChi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<Cau6F_Result>("[QLXemPhimEntities].[Cau6F](@Age, @DiaChi)", ageParameter, diaChiParameter);
        }
    
        [DbFunction("QLXemPhimEntities", "Cau7F")]
        public virtual IQueryable<Cau7F_Result> Cau7F(string maPhim)
        {
            var maPhimParameter = maPhim != null ?
                new ObjectParameter("maPhim", maPhim) :
                new ObjectParameter("maPhim", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<Cau7F_Result>("[QLXemPhimEntities].[Cau7F](@maPhim)", maPhimParameter);
        }
    
        [DbFunction("QLXemPhimEntities", "SoLuongHoaDon")]
        public virtual IQueryable<SoLuongHoaDon_Result> SoLuongHoaDon(Nullable<int> thang, Nullable<int> nam)
        {
            var thangParameter = thang.HasValue ?
                new ObjectParameter("thang", thang) :
                new ObjectParameter("thang", typeof(int));
    
            var namParameter = nam.HasValue ?
                new ObjectParameter("nam", nam) :
                new ObjectParameter("nam", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<SoLuongHoaDon_Result>("[QLXemPhimEntities].[SoLuongHoaDon](@thang, @nam)", thangParameter, namParameter);
        }
    
        public virtual int CAU3proc(string nam, ObjectParameter slVe)
        {
            var namParameter = nam != null ?
                new ObjectParameter("nam", nam) :
                new ObjectParameter("nam", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CAU3proc", namParameter, slVe);
        }
    
        public virtual ObjectResult<Nullable<int>> CAU4proc(string maphim, ObjectParameter slLC)
        {
            var maphimParameter = maphim != null ?
                new ObjectParameter("maphim", maphim) :
                new ObjectParameter("maphim", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("CAU4proc", maphimParameter, slLC);
        }
    
        public virtual int CAU5proc(string tenNv, Nullable<int> nam, ObjectParameter tienVe, ObjectParameter slveDaBan)
        {
            var tenNvParameter = tenNv != null ?
                new ObjectParameter("TenNv", tenNv) :
                new ObjectParameter("TenNv", typeof(string));
    
            var namParameter = nam.HasValue ?
                new ObjectParameter("nam", nam) :
                new ObjectParameter("nam", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CAU5proc", tenNvParameter, namParameter, tienVe, slveDaBan);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}