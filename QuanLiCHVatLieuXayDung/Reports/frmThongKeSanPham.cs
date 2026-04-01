using Microsoft.Reporting.WinForms;
using QuanLiCHVatLieuXayDung.Data;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace QuanLiCHVatLieuXayDung.Reports
{
    public partial class frmThongKeSanPham : Form
    {
        QLCHVLXDDbContext context = new QLCHVLXDDbContext();
        QLCHVLXDDataSet.DanhSachSanPhamDataTable dtSP = new QLCHVLXDDataSet.DanhSachSanPhamDataTable();
        string reportsFolder;

        public frmThongKeSanPham()
        {
            InitializeComponent();

            reportsFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Reports");
            reportsFolder = Path.GetFullPath(reportsFolder); // Chuẩn hóa đường dẫn
        }

        private void frmThongKeSanPham_Load(object sender, EventArgs e)
        {
            var listNCC = context.NhaCungCap.Select(n => new { n.ID, n.TenNhaCungCap }).ToList();
            listNCC.Insert(0, new { ID = 0, TenNhaCungCap = "-- Tất cả --" });
            cboHangSanXuat.DataSource = listNCC;
            cboHangSanXuat.DisplayMember = "TenNhaCungCap";
            cboHangSanXuat.ValueMember = "ID";

            var listLoai = context.LoaiSanPham.Select(l => new { l.ID, l.TenLoai }).ToList();
            listLoai.Insert(0, new { ID = 0, TenLoai = "-- Tất cả --" });
            cboLoaiSanPham.DataSource = listLoai;
            cboLoaiSanPham.DisplayMember = "TenLoai";
            cboLoaiSanPham.ValueMember = "ID";

            btnLocKetQua_Click(null, null);
        }

        private void btnLocKetQua_Click(object sender, EventArgs e)
        {
            int nccId = (int)cboHangSanXuat.SelectedValue;
            int loaiId = (int)cboLoaiSanPham.SelectedValue;

            var query = context.SanPham.Where(s => !s.DaXoa).AsQueryable();
            if (nccId > 0) query = query.Where(s => s.NhaCungCapID == nccId);
            if (loaiId > 0) query = query.Where(s => s.LoaiSanPhamID == loaiId);

            var result = query.Select(r => new {
                r.ID,
                r.NhaCungCapID,
                TenNhaCungCap = r.NhaCungCap.TenNhaCungCap,
                r.LoaiSanPhamID,
                TenLoai = r.LoaiSanPham.TenLoai,
                r.TenSanPham,
                r.DonGia,
                r.SoLuong,
                r.HinhAnh,
                r.MoTa
            }).ToList();

            dtSP.Clear();
            foreach (var r in result)
                dtSP.AddDanhSachSanPhamRow(r.ID, r.NhaCungCapID, r.TenNhaCungCap, r.LoaiSanPhamID, r.TenLoai, r.TenSanPham, r.DonGia, r.SoLuong, r.HinhAnh, r.MoTa);

            string reportPath = Path.Combine(reportsFolder, "rptThongKeSanPham.rdlc");
            
            // Kiểm tra file tồn tại trước khi load
            if (!File.Exists(reportPath))
            {
                MessageBox.Show($"Không tìm thấy file báo cáo: {reportPath}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            reportViewer.LocalReport.ReportPath = reportPath;
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DanhSachSanPham", (DataTable)dtSP));
            reportViewer.RefreshReport();
        }
    }
}