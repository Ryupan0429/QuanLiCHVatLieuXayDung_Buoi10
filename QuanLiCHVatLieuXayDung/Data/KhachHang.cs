using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;

namespace QuanLiCHVatLieuXayDung.Data
{
    public class KhachHang
    {
        public int ID { get; set; }
        public string TenKhachHang { get; set; } = null!;
        public string? SoDienThoai { get; set; }
        public string? DiaChi { get; set; }
        public string? LoaiKhachHang { get; set; }
        public decimal TongNo { get; set; }
        public virtual ObservableCollectionListSource<HoaDon> HoaDons { get; } = new();
    }
}