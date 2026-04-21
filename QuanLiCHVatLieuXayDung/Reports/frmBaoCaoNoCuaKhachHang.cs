using Microsoft.Reporting.WinForms;
using Microsoft.EntityFrameworkCore;
using QuanLiCHVatLieuXayDung.Data;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace QuanLiCHVatLieuXayDung.Reports
{
    public partial class frmBaoCaoNoCuaKhachHang : Form
    {
        QLCHVLXDDbContext context = new QLCHVLXDDbContext();
        string reportsFolder;

        public frmBaoCaoNoCuaKhachHang()
        {
            InitializeComponent();
            reportsFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Reports");
            reportsFolder = Path.GetFullPath(reportsFolder);
        }

        private void frmBaoCaoNoCuaKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                // Thiết lập ngày mặc định
                dtpTuNgay.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                dtpDenNgay.Value = DateTime.Now;

                // Load nhóm quá hạn
                cboNhomQuaHan.Items.Add("Tất cả");
                cboNhomQuaHan.Items.Add("Chưa quá hạn (< 30 ngày)");
                cboNhomQuaHan.Items.Add("Quá hạn 30-60 ngày");
                cboNhomQuaHan.Items.Add("Quá hạn > 60 ngày");
                cboNhomQuaHan.SelectedIndex = 0;

                // Load báo cáo lần đầu
                btnLocKetQua_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải form: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLocKetQua_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime start = dtpTuNgay.Value.Date;
                DateTime end = dtpDenNgay.Value.Date.AddDays(1).AddSeconds(-1);
                string nhomQuaHan = cboNhomQuaHan.SelectedItem?.ToString() ?? "Tất cả";

                // Query hóa đơn có nợ - Include related data
                var hoaDonNo = context.HoaDon
                    .Include(h => h.KhachHang)
                    .Include(h => h.HoaDon_ChiTiet)
                    .Include(h => h.ThanhToans)
                    .Where(h => h.NgayLap >= start && h.NgayLap <= end)
                    .Where(h => h.KhachHang != null)
                    .AsEnumerable()
                    .Where(h => h.HoaDon_ChiTiet.Sum(ct => ct.ThanhTien) > h.ThanhToans.Sum(tt => tt.SoTienThanhToan))
                    .ToList();

                // Tạo dữ liệu
                // lấy từ ThanhToans của từng hóa đơn để tính tổng đã thanh toán, tránh lỗi nếu có hóa đơn không có thanh toán nào
               
                var data = hoaDonNo.Select(h => new
                {
                    MaHoaDon = "HĐ #" + h.ID,
                    TenKhachHang = h.KhachHang?.TenKhachHang ?? "N/A",
                    h.NgayLap,
                    SoNgayQuaHan = (DateTime.Now - h.NgayLap).Days,
                    NhomQuaHan = GetPastDueGroup(h.NgayLap),
                    TongHoaDon = h.HoaDon_ChiTiet?.Sum(ct => ct.ThanhTien) ?? 0,
                    TongDaTT = h.ThanhToans?.Sum(tt => tt.SoTienThanhToan) ?? 0,
                    SoNoConLai = (h.HoaDon_ChiTiet?.Sum(ct => ct.ThanhTien) ?? 0) - (h.ThanhToans?.Sum(tt => tt.SoTienThanhToan) ?? 0)
                }).ToList();

                // Load báo cáo
                string reportPath = Path.Combine(reportsFolder, "rptBaoCaoNoCuaKhachHang.rdlc");

                if (!File.Exists(reportPath))
                {
                    MessageBox.Show($"Không tìm thấy file báo cáo: {reportPath}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                reportViewer1.LocalReport.ReportPath = reportPath;
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DanhSachNo", data));

                string kqht = $"Từ ngày {start:dd/MM/yyyy} đến ngày {dtpDenNgay.Value:dd/MM/yyyy}";
                if (nhomQuaHan != "Tất cả")
                    kqht += $" - {nhomQuaHan}";

                ReportParameter p = new ReportParameter("KQHT", kqht);
                reportViewer1.LocalReport.SetParameters(p);

                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lọc báo cáo: {ex.Message}\n{ex.StackTrace}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            dtpTuNgay.Value = new DateTime(2020, 1, 1);
            dtpDenNgay.Value = DateTime.Now;
            cboNhomQuaHan.SelectedIndex = 0;
            btnLocKetQua_Click(null, null);
        }

        private string GetPastDueGroup(DateTime ngayLap)
        {
            int daysPastDue = (DateTime.Now - ngayLap).Days;
            if (daysPastDue < 0)
                return "Chưa quá hạn (< 30 ngày)";
            else if (daysPastDue < 30)
                return "Chưa quá hạn (< 30 ngày)";
            else if (daysPastDue < 60)
                return "Quá hạn 30-60 ngày";
            else
                return "Quá hạn > 60 ngày";
        }
    }
}
