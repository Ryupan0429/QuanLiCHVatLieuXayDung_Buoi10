using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCHVatLieuXayDung.Data
{
    public class SanPham
    {
        public int ID { get; set; }
        public int NhaCungCapID { get; set; }
        public int LoaiSanPhamID { get; set; }
        public string TenSanPham { get; set; }
        public int DonGia { get; set; }
        public int GiaNhap { get; set; }
        public string DonViTinh { get; set; }
        public int SoLuong { get; set; }
        public string? MoTa { get; set; }
        public string? HinhAnh { get; set; }

        public bool DaXoa { get; set; } = false;
        public virtual ObservableCollectionListSource<HoaDon_ChiTiet> HoaDon_ChiTiet { get; } = new();
        public virtual ObservableCollectionListSource<PhieuNhap_ChiTiet> PhieuNhap_ChiTiet { get; } = new();
        public virtual LoaiSanPham LoaiSanPham { get; set; } = null!;
        public virtual NhaCungCap NhaCungCap { get; set; } = null!;
    }
    [NotMapped]
    public class DanhSachSanPham
    {
        public int ID { get; set; }
        public int NhaCungCapID { get; set; }

        public string TenNhaCungCap { get; set; }
        public int LoaiSanPhamID { get; set; }
        public string TenLoai{ get; set; }
        public string TenSanPham { get; set; }
        public int DonGia { get; set; }
        public int GiaNhap { get; set; }
        public string DonViTinh { get; set; }
        public int SoLuong { get; set; }
        public string? MoTa { get; set; }
        public string? HinhAnh { get; set; }
    }
}