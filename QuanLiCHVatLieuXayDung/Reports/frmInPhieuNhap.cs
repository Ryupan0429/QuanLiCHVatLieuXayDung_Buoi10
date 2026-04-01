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
    public partial class frmInPhieuNhap : Form
    {
        QLCHVLXDDbContext context = new QLCHVLXDDbContext();
        QLCHVLXDDataSet.DanhSachPhieuNhap_ChiTietDataTable dt = new QLCHVLXDDataSet.DanhSachPhieuNhap_ChiTietDataTable();
        string reportsFolder;
        int idPhieu;

        public frmInPhieuNhap(int id = 0)
        {
            InitializeComponent();
            idPhieu = id;
            //  Xác định đường dẫn đến thư mục Reports
            reportsFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Reports");
            reportsFolder = Path.GetFullPath(reportsFolder);
        }

        private void frmInPhieuNhap_Load(object sender, EventArgs e)
        {
            var phieuNhap = context.PhieuNhap.Include(r => r.NhaCungCap).Include(r => r.NhanVien)
                .Where(r => r.ID == idPhieu).SingleOrDefault();

            if (phieuNhap == null)
            {
                MessageBox.Show("Không tìm thấy phiếu nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var chiTiet = context.PhieuNhap_ChiTiet.Where(r => r.PhieuNhapID == idPhieu).Select(r => new
            {
                r.ID,
                r.PhieuNhapID,
                r.SanPhamID,
                TenSanPham = r.SanPham.TenSanPham,
                SoLuong = r.SoLuong,            
                DonGiaNhap = r.DonGiaNhap,   
                ThanhTien = r.ThanhTien    
            }).ToList();

            decimal total = chiTiet.Sum(x => x.ThanhTien);

            dt.Clear();
            foreach (var row in chiTiet)
            {
                int soLuongInt = Convert.ToInt32((row.SoLuong));
                int donGiaInt = Convert.ToInt32(Math.Round(row.DonGiaNhap));
                int thanhTienInt = Convert.ToInt32(Math.Round(row.ThanhTien));

                dt.AddDanhSachPhieuNhap_ChiTietRow(row.ID, row.PhieuNhapID, row.SanPhamID, row.TenSanPham, soLuongInt, donGiaInt, thanhTienInt);
            }

            ReportDataSource rds = new ReportDataSource("DanhSachPhieuNhap_ChiTiet", (DataTable)dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            string reportPath = Path.Combine(reportsFolder, "rptInPhieuNhap.rdlc");
            if (!File.Exists(reportPath))
            {
                MessageBox.Show($"Không tìm thấy file báo cáo: {reportPath}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            reportViewer1.LocalReport.ReportPath = reportPath;

            IList<ReportParameter> param = new List<ReportParameter>
            {
                new ReportParameter("NgayNhap", string.Format("Ngày {0} Tháng {1} Năm {2}", phieuNhap.NgayNhap.Day, phieuNhap.NgayNhap.Month, phieuNhap.NgayNhap.Year)),
                new ReportParameter("NV_Ten", phieuNhap.NhanVien.HoVaTen),
                new ReportParameter("CH_DiaChi", "Số 123, Đường ABC, TP. Long Xuyên, An Giang"),
                new ReportParameter("CH_MaSoThue", "1602162070"),
                new ReportParameter("NCC_Ten", phieuNhap.NhaCungCap.TenNhaCungCap),
                new ReportParameter("NCC_DiaChi", phieuNhap.NhaCungCap.DiaChi ?? ""),
                new ReportParameter("NCC_MaSoThue", "MST-NCC-001"),
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