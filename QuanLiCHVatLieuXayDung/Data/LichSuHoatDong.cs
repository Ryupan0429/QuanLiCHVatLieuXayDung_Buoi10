using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;

namespace QuanLiCHVatLieuXayDung.Data
{
    public class LichSuHoatDong
    {
        public int ID { get; set; }
        public int NhanVienID { get; set; }
        public DateTime ThoiGian { get; set; }
        public string HanhDong { get; set; } = null!;
        public string DoiTuong { get; set; } = null!;
        public string? MoTa { get; set; }
        public virtual NhanVien NhanVien { get; set; } = null!;
    }
}