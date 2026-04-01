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
    public partial class frmThongKeChiTieu : Form
    {
        QLCHVLXDDbContext context = new QLCHVLXDDbContext();
        string reportsFolder;

        public frmThongKeChiTieu()
        {
            InitializeComponent();
            reportsFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Reports");
            reportsFolder = Path.GetFullPath(reportsFolder);
        }

        private void frmThongKeChiTieu_Load(object sender, EventArgs e)
        {
            dtpTuNgay.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDenNgay.Value = DateTime.Now;
            btnThongKe_Click(null, null);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1).AddSeconds(-1);

            var list = context.PhieuNhap
                .Where(r => r.NgayNhap >= tuNgay && r.NgayNhap <= denNgay)
                .Select(r => new
                {
                    ID = r.ID,
                    NgayNhap = r.NgayNhap,
                    HoVaTen = r.NhanVien.HoVaTen,
                    TenNhaCungCap = r.NhaCungCap.TenNhaCungCap,
                    TongTien = r.TongTien,
                    GhiChu = r.GhiChu
                }).ToList();

            ReportDataSource rds = new ReportDataSource("DanhSachPhieuNhap", list);
            
            string reportPath = Path.Combine(reportsFolder, "rptThongKeChiTieu.rdlc");
            
            if (!File.Exists(reportPath))
            {
                MessageBox.Show($"Không tìm thấy file báo cáo: {reportPath}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(rds);
            reportViewer.LocalReport.ReportPath = reportPath;

            ReportParameter p = new ReportParameter("KQHT", $"Từ ngày {tuNgay:dd/MM/yyyy} đến ngày {dtpDenNgay.Value:dd/MM/yyyy}");
            reportViewer.LocalReport.SetParameters(p);

            reportViewer.RefreshReport();
        }
    }
}