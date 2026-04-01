using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCHVatLieuXayDung.Data
{
    public class PhieuNhap
    {
        public int ID { get; set; }
        public int NhaCungCapID { get; set; }
        public int NhanVienID { get; set; }
        public DateTime NgayNhap { get; set; }
        public string? GhiChu { get; set; }
        public decimal TongTien { get; set; }
        public virtual ObservableCollectionListSource<PhieuNhap_ChiTiet> PhieuNhap_ChiTiet { get; } = new();
        public virtual NhaCungCap NhaCungCap { get; set; } = null!;
        public virtual NhanVien NhanVien { get; set; } = null!;
    }

    public class DanhSachPhieuNhap
    {
        public int ID { get; set; }
        public int NhaCungCapID { get; set; }
        public string TenNhaCungCap { get; set; }
        public int NhanVienID { get; set; }
        public string HoVaTenNhanVien { get; set; }
        public DateTime NgayNhap { get; set; }
        public string? GhiChu { get; set; }
        public decimal TongTien { get; set; }
        public string? XemChiTiet { get; set; }
    }
}
