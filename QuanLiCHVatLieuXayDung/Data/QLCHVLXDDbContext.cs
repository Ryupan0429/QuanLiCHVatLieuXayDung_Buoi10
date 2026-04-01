using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCHVatLieuXayDung.Data
{
    public class QLCHVLXDDbContext : DbContext
    {
        public DbSet<LoaiSanPham> LoaiSanPham { get; set; }
        public DbSet<NhaCungCap> NhaCungCap { get; set; }
        public DbSet<SanPham> SanPham { get; set; }
        public DbSet<PhieuNhap> PhieuNhap { get; set; }
        public DbSet<PhieuNhap_ChiTiet> PhieuNhap_ChiTiet { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<HoaDon_ChiTiet> HoaDon_ChiTiet { get; set; }

        public DbSet<LichSuHoatDong> LichSuHoatDong { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["QLCHVLXDConnection"].ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PhieuNhap_ChiTiet>()
                .HasOne(ct => ct.SanPham)
                .WithMany(sp => sp.PhieuNhap_ChiTiet)
                .HasForeignKey(ct => ct.SanPhamID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<HoaDon_ChiTiet>()
                .HasOne(ct => ct.SanPham)
                .WithMany(sp => sp.HoaDon_ChiTiet)
                .HasForeignKey(ct => ct.SanPhamID)
                .OnDelete(DeleteBehavior.Restrict);

            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetProperties())
                .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
            {
                property.SetColumnType("decimal(18, 2)");
            }
        }
    }
}