using Microsoft.Reporting.WinForms;
using QuanLiCHVatLieuXayDung.Data;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace QuanLiCHVatLieuXayDung.Reports
{
    public partial class frmThongKeDoanhThu : Form
    {
        QLCHVLXDDbContext context = new QLCHVLXDDbContext();
        string reportsFolder;

        public frmThongKeDoanhThu()
        {
            InitializeComponent();
            reportsFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Reports");
            reportsFolder = Path.GetFullPath(reportsFolder);
        }

        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            dtpTuNgay.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDenNgay.Value = DateTime.Now;
            btnLocKetQua_Click(null, null);
        }

        private void btnLocKetQua_Click(object sender, EventArgs e)
        {
            DateTime start = dtpTuNgay.Value.Date;
            DateTime end = dtpDenNgay.Value.Date.AddDays(1).AddSeconds(-1);

            var data = context.HoaDon.Where(h => h.NgayLap >= start && h.NgayLap <= end)
                .Select(h => new
                {
                    h.ID,
                    h.NhanVienID,
                    HoVaTen = h.NhanVien.HoVaTen,
                    h.KhachHangID,
                    HoVaTenKhachHang = h.KhachHang.TenKhachHang,
                    h.NgayLap,
                    TongTien = h.HoaDon_ChiTiet.Sum(ct => ct.ThanhTien),
                    GhiChu = h.GhiChuHoaDon
                }).ToList();

            string reportPath = Path.Combine(reportsFolder, "rptThongKeDoanhThu.rdlc");
            
            if (!File.Exists(reportPath))
            {
                MessageBox.Show($"Không tìm thấy file báo cáo: {reportPath}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            reportViewer.LocalReport.ReportPath = reportPath;
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DanhSachHoaDon", data));

            ReportParameter p = new ReportParameter("KQHT", $"Từ ngày {start:dd/MM/yyyy} đến ngày {dtpDenNgay.Value:dd/MM/yyyy}");
            reportViewer.LocalReport.SetParameters(p);  

            reportViewer.RefreshReport();
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            dtpTuNgay.Value = new DateTime(2020, 1, 1);
            dtpDenNgay.Value = DateTime.Now;
            btnLocKetQua_Click(null, null);
        }
    }
}