using System;
using System.Collections.Generic;

namespace QuanLiCHVatLieuXayDung.Data
{
    public class PhieuNhap_ChiTiet
    {
        public int ID { get; set; }
        public int PhieuNhapID { get; set; }
        public int SanPhamID { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGiaNhap { get; set; }
        public decimal ThanhTien { get; set; }
        public virtual PhieuNhap PhieuNhap { get; set; } = null!;
        public virtual SanPham SanPham { get; set; } = null!;
    }

    public class DanhSachPhieuNhap_ChiTiet
    {
        public int ID { get; set; }
        public int PhieuNhapID { get; set; }
        public int SanPhamID { get; set; }
        public string TenSanPham { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGiaNhap { get; set; }
        public decimal ThanhTien { get; set; }
    }
}