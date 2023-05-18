using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace baitaptuluyen1.Models;

public partial class QlbanSachLuyenThemContext : DbContext
{
    public QlbanSachLuyenThemContext()
    {
    }

    public QlbanSachLuyenThemContext(DbContextOptions<QlbanSachLuyenThemContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cau1View> Cau1Views { get; set; }

    public virtual DbSet<Cau2View> Cau2Views { get; set; }

    public virtual DbSet<Cau3LuyenTapT7> Cau3LuyenTapT7s { get; set; }

    public virtual DbSet<Cau3QlbanSachThem> Cau3QlbanSachThems { get; set; }

    public virtual DbSet<Cau3View> Cau3Views { get; set; }

    public virtual DbSet<Cau4View> Cau4Views { get; set; }

    public virtual DbSet<TChiTietHdb> TChiTietHdbs { get; set; }

    public virtual DbSet<TChiTietHdn> TChiTietHdns { get; set; }

    public virtual DbSet<THoaDonBan> THoaDonBans { get; set; }

    public virtual DbSet<THoaDonNhap> THoaDonNhaps { get; set; }

    public virtual DbSet<TKhachHang> TKhachHangs { get; set; }

    public virtual DbSet<TNhaCungCap> TNhaCungCaps { get; set; }

    public virtual DbSet<TNhaXuatBan> TNhaXuatBans { get; set; }

    public virtual DbSet<TNhanVien> TNhanViens { get; set; }

    public virtual DbSet<TSach> TSaches { get; set; }

    public virtual DbSet<TTheLoai> TTheLoais { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=MSI\\SQLEXPRESS;Initial Catalog=QLBanSachLuyenThem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cau1View>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("cau1View");

            entity.Property(e => e.MaNxb)
                .HasMaxLength(10)
                .HasColumnName("MaNXB");
            entity.Property(e => e.TenNxb)
                .HasMaxLength(100)
                .HasColumnName("tenNXB");
        });

        modelBuilder.Entity<Cau2View>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("cau2View");

            entity.Property(e => e.Anh).HasColumnType("image");
            entity.Property(e => e.DonGiaBan).HasColumnType("money");
            entity.Property(e => e.DonGiaNhap).HasColumnType("money");
            entity.Property(e => e.MaNxb)
                .HasMaxLength(10)
                .HasColumnName("MaNXB");
            entity.Property(e => e.MaSach).HasMaxLength(10);
            entity.Property(e => e.MaTheLoai).HasMaxLength(10);
            entity.Property(e => e.TacGia).HasMaxLength(150);
            entity.Property(e => e.TenSach).HasMaxLength(200);
            entity.Property(e => e.TrongLuong).HasMaxLength(50);
        });

        modelBuilder.Entity<Cau3LuyenTapT7>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("cau3LuyenTapT7");

            entity.Property(e => e.GiaTri).HasColumnType("money");
            entity.Property(e => e.MaKh)
                .HasMaxLength(10)
                .HasColumnName("MaKH");
            entity.Property(e => e.TenKh)
                .HasMaxLength(50)
                .HasColumnName("TenKH");
        });

        modelBuilder.Entity<Cau3QlbanSachThem>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Cau3_QLBanSachThem");

            entity.Property(e => e.MaNcc)
                .HasMaxLength(10)
                .HasColumnName("MaNCC");
            entity.Property(e => e.NgayNhap).HasColumnType("datetime");
            entity.Property(e => e.Slnhap).HasColumnName("SLNhap");
            entity.Property(e => e.SoHdn)
                .HasMaxLength(10)
                .HasColumnName("SoHDN");
            entity.Property(e => e.TenNcc)
                .HasMaxLength(200)
                .HasColumnName("TenNCC");
            entity.Property(e => e.TriGiaHoaDon).HasColumnType("money");
        });

        modelBuilder.Entity<Cau3View>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("cau3View");

            entity.Property(e => e.ChiTieu).HasColumnType("money");
            entity.Property(e => e.MaKh)
                .HasMaxLength(10)
                .HasColumnName("MaKH");
        });

        modelBuilder.Entity<Cau4View>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("cau4View");

            entity.Property(e => e.MaSach).HasMaxLength(10);
            entity.Property(e => e.TenSach).HasMaxLength(200);
        });

        modelBuilder.Entity<TChiTietHdb>(entity =>
        {
            entity.HasKey(e => new { e.SoHdb, e.MaSach });

            entity.ToTable("tChiTietHDB", tb =>
                {
                    tb.HasTrigger("Cau2CNTT2");
                    tb.HasTrigger("cau4");
                    tb.HasTrigger("cau4LuyenTapT7");
                });

            entity.Property(e => e.SoHdb)
                .HasMaxLength(10)
                .HasColumnName("SoHDB");
            entity.Property(e => e.MaSach).HasMaxLength(10);
            entity.Property(e => e.KhuyenMai).HasMaxLength(100);
            entity.Property(e => e.Slban).HasColumnName("SLBan");

            entity.HasOne(d => d.MaSachNavigation).WithMany(p => p.TChiTietHdbs)
                .HasForeignKey(d => d.MaSach)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tChiTietHDB_tSach");

            entity.HasOne(d => d.SoHdbNavigation).WithMany(p => p.TChiTietHdbs)
                .HasForeignKey(d => d.SoHdb)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tChiTietHDB_tHoaDonBan");
        });

        modelBuilder.Entity<TChiTietHdn>(entity =>
        {
            entity.HasKey(e => new { e.SoHdn, e.MaSach });

            entity.ToTable("tChiTietHDN");

            entity.Property(e => e.SoHdn)
                .HasMaxLength(10)
                .HasColumnName("SoHDN");
            entity.Property(e => e.MaSach).HasMaxLength(10);
            entity.Property(e => e.KhuyenMai).HasMaxLength(100);
            entity.Property(e => e.Slnhap).HasColumnName("SLNhap");

            entity.HasOne(d => d.MaSachNavigation).WithMany(p => p.TChiTietHdns)
                .HasForeignKey(d => d.MaSach)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tChiTietHDN_tSach");

            entity.HasOne(d => d.SoHdnNavigation).WithMany(p => p.TChiTietHdns)
                .HasForeignKey(d => d.SoHdn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tChiTietHDN_tHoaDonNhap");
        });

        modelBuilder.Entity<THoaDonBan>(entity =>
        {
            entity.HasKey(e => e.SoHdb);

            entity.ToTable("tHoaDonBan");

            entity.Property(e => e.SoHdb)
                .HasMaxLength(10)
                .HasColumnName("SoHDB");
            entity.Property(e => e.MaKh)
                .HasMaxLength(10)
                .HasColumnName("MaKH");
            entity.Property(e => e.MaNv)
                .HasMaxLength(10)
                .HasColumnName("MaNV");
            entity.Property(e => e.NgayBan).HasColumnType("datetime");
            entity.Property(e => e.SoSanPhamBan).HasColumnName("soSanPhamBan");

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.THoaDonBans)
                .HasForeignKey(d => d.MaKh)
                .HasConstraintName("FK_tHoaDonBan_tKhachHang");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.THoaDonBans)
                .HasForeignKey(d => d.MaNv)
                .HasConstraintName("FK_tHoaDonBan_tNhanVien");
        });

        modelBuilder.Entity<THoaDonNhap>(entity =>
        {
            entity.HasKey(e => e.SoHdn);

            entity.ToTable("tHoaDonNhap");

            entity.Property(e => e.SoHdn)
                .HasMaxLength(10)
                .HasColumnName("SoHDN");
            entity.Property(e => e.MaNcc)
                .HasMaxLength(10)
                .HasColumnName("MaNCC");
            entity.Property(e => e.MaNv)
                .HasMaxLength(10)
                .HasColumnName("MaNV");
            entity.Property(e => e.NgayNhap).HasColumnType("datetime");

            entity.HasOne(d => d.MaNccNavigation).WithMany(p => p.THoaDonNhaps)
                .HasForeignKey(d => d.MaNcc)
                .HasConstraintName("FK_tHoaDonNhap_tNhaCungCap");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.THoaDonNhaps)
                .HasForeignKey(d => d.MaNv)
                .HasConstraintName("FK_tHoaDonNhap_tNhanVien");
        });

        modelBuilder.Entity<TKhachHang>(entity =>
        {
            entity.HasKey(e => e.MaKh);

            entity.ToTable("tKhachHang");

            entity.Property(e => e.MaKh)
                .HasMaxLength(10)
                .HasColumnName("MaKH");
            entity.Property(e => e.DiaChi).HasMaxLength(150);
            entity.Property(e => e.DienThoai).HasMaxLength(15);
            entity.Property(e => e.SlsachMua).HasColumnName("SLSachMua");
            entity.Property(e => e.TenKh)
                .HasMaxLength(50)
                .HasColumnName("TenKH");
        });

        modelBuilder.Entity<TNhaCungCap>(entity =>
        {
            entity.HasKey(e => e.MaNcc);

            entity.ToTable("tNhaCungCap");

            entity.Property(e => e.MaNcc)
                .HasMaxLength(10)
                .HasColumnName("MaNCC");
            entity.Property(e => e.TenNcc)
                .HasMaxLength(200)
                .HasColumnName("TenNCC");
        });

        modelBuilder.Entity<TNhaXuatBan>(entity =>
        {
            entity.HasKey(e => e.MaNxb);

            entity.ToTable("tNhaXuatBan");

            entity.Property(e => e.MaNxb)
                .HasMaxLength(10)
                .HasColumnName("MaNXB");
            entity.Property(e => e.SlNxb).HasColumnName("slNXB");
            entity.Property(e => e.TenNxb)
                .HasMaxLength(100)
                .HasColumnName("TenNXB");
        });

        modelBuilder.Entity<TNhanVien>(entity =>
        {
            entity.HasKey(e => e.MaNv);

            entity.ToTable("tNhanVien");

            entity.Property(e => e.MaNv)
                .HasMaxLength(10)
                .HasColumnName("MaNV");
            entity.Property(e => e.DiaChi).HasMaxLength(150);
            entity.Property(e => e.DienThoai).HasMaxLength(15);
            entity.Property(e => e.GioiTinh).HasMaxLength(5);
            entity.Property(e => e.NgaySinh).HasColumnType("datetime");
            entity.Property(e => e.TenNv)
                .HasMaxLength(50)
                .HasColumnName("TenNV");
        });

        modelBuilder.Entity<TSach>(entity =>
        {
            entity.HasKey(e => e.MaSach);

            entity.ToTable("tSach", tb => tb.HasTrigger("Cau4_QLBanSachThem"));

            entity.Property(e => e.MaSach).HasMaxLength(10);
            entity.Property(e => e.Anh).HasColumnType("image");
            entity.Property(e => e.DonGiaBan).HasColumnType("money");
            entity.Property(e => e.DonGiaNhap).HasColumnType("money");
            entity.Property(e => e.MaNxb)
                .HasMaxLength(10)
                .HasColumnName("MaNXB");
            entity.Property(e => e.MaTheLoai).HasMaxLength(10);
            entity.Property(e => e.TacGia).HasMaxLength(150);
            entity.Property(e => e.TenSach).HasMaxLength(200);
            entity.Property(e => e.TrongLuong).HasMaxLength(50);

            entity.HasOne(d => d.MaNxbNavigation).WithMany(p => p.TSaches)
                .HasForeignKey(d => d.MaNxb)
                .HasConstraintName("FK_tSach_tNhaXuatBan");

            entity.HasOne(d => d.MaTheLoaiNavigation).WithMany(p => p.TSaches)
                .HasForeignKey(d => d.MaTheLoai)
                .HasConstraintName("FK_tSach_tTheLoai");
        });

        modelBuilder.Entity<TTheLoai>(entity =>
        {
            entity.HasKey(e => e.MaTheLoai);

            entity.ToTable("tTheLoai");

            entity.Property(e => e.MaTheLoai).HasMaxLength(10);
            entity.Property(e => e.TenTheLoai).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
