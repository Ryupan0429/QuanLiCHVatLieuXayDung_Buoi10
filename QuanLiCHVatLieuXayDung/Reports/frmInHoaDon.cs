using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using QuanLiCHVatLieuXayDung.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace QuanLiCHVatLieuXayDung.Reports
{
    public partial class frmInHoaDon : Form
    {
        QLCHVLXDDbContext context = new QLCHVLXDDbContext();
        QLCHVLXDDataSet.DanhSachHoaDon_ChiTietDataTable dt = new QLCHVLXDDataSet.DanhSachHoaDon_ChiTietDataTable();
        string reportsFolder;
        int idHD;

        public frmInHoaDon(int id = 0)
        {
            InitializeComponent();
            idHD = id;
            reportsFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Reports");
            reportsFolder = Path.GetFullPath(reportsFolder);
        }

        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            var hoaDon = context.HoaDon.Include(r => r.KhachHang).Include(r => r.NhanVien)
                .Where(r => r.ID == idHD).SingleOrDefault();

            if (hoaDon == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var chiTiet = context.HoaDon_ChiTiet.Where(r => r.HoaDonID == idHD).Select(r => new
            {
                r.ID,
                r.HoaDonID,
                r.SanPhamID,
                TenSanPham = r.SanPham.TenSanPham,
                SoLuong = (int)r.SoLuong,
                DonGia = (int)r.DonGia,
                ThanhTien = (int)r.ThanhTien
            }).ToList();

            dt.Clear();
            foreach (var row in chiTiet)
            {
                dt.AddDanhSachHoaDon_ChiTietRow(row.ID, row.HoaDonID, row.SanPhamID, row.TenSanPham, row.SoLuong, row.DonGia, row.ThanhTien);
            }
            decimal total = chiTiet.Sum(x => x.ThanhTien);

            ReportDataSource rds = new ReportDataSource("DanhSachHoaDon_ChiTiet", (DataTable)dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            string reportPath = Path.Combine(reportsFolder, "rptInHoaDon.rdlc");
            if (!File.Exists(reportPath))
            {
                MessageBox.Show($"Không tìm thấy file báo cáo: {reportPath}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            reportViewer1.LocalReport.ReportPath = reportPath;

            IList<ReportParameter> param = new List<ReportParameter>
            {
                new ReportParameter("NgayLap", string.Format("Ngày {0} Tháng {1} Năm {2}", hoaDon.NgayLap.Day, hoaDon.NgayLap.Month, hoaDon.NgayLap.Year)),
                new ReportParameter("NguoiBan_Ten", "CỬA HÀNG VẬT LIỆU XÂY DỰNG"),
                new ReportParameter("NguoiBan_DiaChi", "Mỹ Phước, TP. Long Xuyên, An Giang"),
                new ReportParameter("NguoiBan_MaSoThue", "1602162070"),
                new ReportParameter("NguoiMua_Ten", hoaDon.KhachHang.TenKhachHang),
                new ReportParameter("NguoiMua_DiaChi", hoaDon.KhachHang.DiaChi ?? ""),
                new ReportParameter("NguoiMua_MaSoThue", ""),
                new ReportParameter("TongTien", string.Format("{0:N0}", total))
            };
            reportViewer1.LocalReport.SetParameters(param);

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            reportViewer1.RefreshReport();
        }
    }
}