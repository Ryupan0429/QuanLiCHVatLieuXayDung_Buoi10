using Microsoft.EntityFrameworkCore.ChangeTracking;
using QuanLiCHVatLieuXayDung.Data;
using System;
using System.Collections.Generic;

namespace QuanLiCHVatLieuXayDung.Data
{
    public class NhaCungCap
    {
        public int ID { get; set; }
        public string TenNhaCungCap { get; set; } = null!;
        public string SoDienThoai { get; set; }
        public string? DiaChi { get; set; }
        public virtual ObservableCollectionListSource<PhieuNhap> PhieuNhaps { get; } = new();
        public virtual ObservableCollectionListSource<SanPham> SanPhams { get; } = new();
    }
}