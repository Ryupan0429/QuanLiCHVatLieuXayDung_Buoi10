using QuanLiCHVatLieuXayDung.Data;
using System;

namespace QuanLiCHVatLieuXayDung.Utilities
{
    public static class NhatKyHeThong
    {
        public static int MaNhanVienHienTai { get; set; } = 0;

        public static void GhiNhatKy(string hanhDong, string doiTuong, string moTa)
        {
            if (MaNhanVienHienTai == 0) return;

                using (var context = new QLCHVLXDDbContext())
                {
                    LichSuHoatDong log = new LichSuHoatDong();
                    log.NhanVienID = MaNhanVienHienTai;
                    log.ThoiGian = DateTime.Now;
                    log.HanhDong = hanhDong; 
                    log.DoiTuong = doiTuong; 
                    log.MoTa = moTa;  

                    context.LichSuHoatDong.Add(log);
                    context.SaveChanges();
            }
        }
    }
}