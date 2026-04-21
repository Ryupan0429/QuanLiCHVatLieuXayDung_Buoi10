using System;
using System.Collections.Generic;

namespace QuanLiCHVatLieuXayDung.Data
{
    public class HoaDon
    {
        public int ID { get; set; }
        public int NhanVienID { get; set; }
        public int KhachHangID { get; set; }
        public DateTime NgayLap { get; set; }
        public string? GhiChuHoaDon { get; set; }
        public string TrangThaiThanhToan { get; set; } = "Chưa thanh toán";

        public virtual ICollection<HoaDon_ChiTiet> HoaDon_ChiTiet { get; set; } = new List<HoaDon_ChiTiet>();
        public virtual ICollection<ThanhToan> ThanhToans { get; set; } = new List<ThanhToan>();
        public virtual KhachHang KhachHang { get; set; } = null!;
        public virtual NhanVien NhanVien { get; set; } = null!;
    }

    public class DanhSachHoaDon
    {
        public int ID { get; set; }
        public int NhanVienID { get; set; }
        public string HoVaTenNhanVien { get; set; }
        public int KhachHangID { get; set; }
        public string HoVaTenKhachHang { get; set; }
        public DateTime NgayLap { get; set; }

        public string TrangThaiThanhToan { get; set; }
        public string? GhiChuHoaDon { get; set; }
        public decimal? TongTienHoaDon { get; set; }
        public string? XemChiTiet { get; set; }
    }
}