using System;

namespace QuanLiCHVatLieuXayDung.Data
{
    public class ThanhToan
    {
        public int ID { get; set; }
        public int HoaDonID { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public decimal SoTienThanhToan { get; set; }
        public string PhuongThucThanhToan { get; set; } = "Tiền mặt";  // Tiền mặt, Chuyển khoản, Séc
        public string? GhiChu { get; set; }
        public int NhanVienID { get; set; }  // Nhân viên ghi nhận

        public virtual HoaDon HoaDon { get; set; } = null!;
        public virtual NhanVien NhanVien { get; set; } = null!;
    }
}