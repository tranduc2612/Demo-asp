using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace dethithu2.Models;

public partial class QlbongDaContext : DbContext
{
    public QlbongDaContext()
    {
    }

    public QlbongDaContext(DbContextOptions<QlbongDaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Caulacbo> Caulacbos { get; set; }

    public virtual DbSet<Cauthu> Cauthus { get; set; }

    public virtual DbSet<Huanluyenvien> Huanluyenviens { get; set; }

    public virtual DbSet<Sanvandong> Sanvandongs { get; set; }

    public virtual DbSet<Trandau> Trandaus { get; set; }

    public virtual DbSet<TrandauCauthu> TrandauCauthus { get; set; }

    public virtual DbSet<TrandauGhiban> TrandauGhibans { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=MSI\\SQLEXPRESS;Initial Catalog=QLBongDa;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Caulacbo>(entity =>
        {
            entity.HasKey(e => e.CauLacBoId).HasName("PK__CAULACBO__144BAB43C781C4E9");

            entity.ToTable("CAULACBO");

            entity.Property(e => e.CauLacBoId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CauLacBoID");
            entity.Property(e => e.HuanLuyenVienId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HuanLuyenVienID");
            entity.Property(e => e.SanVanDongId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SanVanDongID");
            entity.Property(e => e.TenClb)
                .HasMaxLength(80)
                .HasColumnName("TenCLB");
            entity.Property(e => e.TenGoi)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Cauthu>(entity =>
        {
            entity.HasKey(e => e.CauThuId).HasName("PK__CAUTHU__023D5A04");

            entity.ToTable("CAUTHU");

            entity.Property(e => e.CauThuId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CauThuID");
            entity.Property(e => e.Anh)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CauLacBoId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CauLacBoID");
            entity.Property(e => e.HoVaTen).HasMaxLength(40);
            entity.Property(e => e.Ngaysinh)
                .HasColumnType("datetime")
                .HasColumnName("NGAYSINH");
            entity.Property(e => e.QuocTich)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.SoAo)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ViTri)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Huanluyenvien>(entity =>
        {
            entity.HasKey(e => e.HuanLuyenVienId).HasName("PK__HUANLUYE__8DF5FB214240E890");

            entity.ToTable("HUANLUYENVIEN");

            entity.Property(e => e.HuanLuyenVienId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HuanLuyenVienID");
            entity.Property(e => e.Anh)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.QuocTich).HasMaxLength(40);
            entity.Property(e => e.TenHlv)
                .HasMaxLength(40)
                .HasColumnName("TenHLV");
        });

        modelBuilder.Entity<Sanvandong>(entity =>
        {
            entity.HasKey(e => e.SanVanDongId).HasName("PK__SANVANDONG__7E6CC920");

            entity.ToTable("SANVANDONG");

            entity.Property(e => e.SanVanDongId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SanVanDongID");
            entity.Property(e => e.Anh)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TenSan).HasMaxLength(60);
            entity.Property(e => e.ThanhPho)
                .HasMaxLength(30)
                .IsFixedLength();
        });

        modelBuilder.Entity<Trandau>(entity =>
        {
            entity.HasKey(e => e.TranDauId).HasName("PK__TRANDAU__0425A276");

            entity.ToTable("TRANDAU");

            entity.Property(e => e.TranDauId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TranDauID");
            entity.Property(e => e.Clbkhach)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CLBKhach");
            entity.Property(e => e.Clbnha)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CLBNha");
            entity.Property(e => e.HiepPhu).HasColumnType("datetime");
            entity.Property(e => e.KetQua).HasMaxLength(30);
            entity.Property(e => e.NgayThiDau).HasColumnType("datetime");
            entity.Property(e => e.SanVanDongId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SanVanDongID");
        });

        modelBuilder.Entity<TrandauCauthu>(entity =>
        {
            entity.HasKey(e => new { e.TranDauId, e.CauThuId }).HasName("PK__TRANDAU_CAUTHU__07F6335A");

            entity.ToTable("TRANDAU_CAUTHU");

            entity.Property(e => e.TranDauId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TranDauID");
            entity.Property(e => e.CauThuId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CauThuID");
            entity.Property(e => e.PhamLoi)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<TrandauGhiban>(entity =>
        {
            entity.HasKey(e => e.GhiBanId).HasName("PK__TRANDAU_GHIBAN__060DEAE8");

            entity.ToTable("TRANDAU_GHIBAN");

            entity.Property(e => e.GhiBanId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("GhiBanID");
            entity.Property(e => e.CauLacBoId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CauLacBoID");
            entity.Property(e => e.CauThuId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CauThuID");
            entity.Property(e => e.TranDauId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TranDauID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
