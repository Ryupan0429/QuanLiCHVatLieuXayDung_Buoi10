using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCHVatLieuXayDung.Data
{
    public class NhanVien
    {
        public int ID { get; set; }
        public string HoVaTen { get; set; } = null!;
        public string? DienThoai { get; set; }
        public string? DiaChi { get; set; }
        public string TenDangNhap { get; set; } = null!;
        public string MatKhau { get; set; } = null!;
        public bool QuyenHan { get; set; }
        public virtual ObservableCollectionListSource<HoaDon> HoaDon { get; } = new();
        public virtual ObservableCollectionListSource<PhieuNhap> PhieuNhaps { get; } = new();

        public virtual ObservableCollectionListSource<LichSuHoatDong> LichSuHoatDongs { get; } = new();
    }

    public class DanhSachNhanVien
    {
        public int ID { get; set; }
        public string HoVaTen { get; set; } = null!;
        public string? DienThoai { get; set; }
        public string? DiaChi { get; set; }
        public string TenDangNhap { get; set; } = null!;
        public bool QuyenHan { get; set; }
        public string? XemHoaDon { get; set; }
        public string? XemPhieuNhap { get; set; }
    }
}