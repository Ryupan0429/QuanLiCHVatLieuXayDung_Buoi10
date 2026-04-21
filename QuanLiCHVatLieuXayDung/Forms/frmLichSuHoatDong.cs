using QuanLiCHVatLieuXayDung.Data;
using QuanLiCHVatLieuXayDung.Utilities;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;

namespace QuanLiCHVatLieuXayDung.Forms
{
    public partial class frmLichSuHoatDong : Form
    {
        public frmLichSuHoatDong()
        {
            InitializeComponent();
        }

        QLCHVLXDDbContext context = new QLCHVLXDDbContext();

        // Khi load, khởi tạo khoảng thời gian mặc định (từ đầu tháng đến hôm nay) và nạp dữ liệu
        private void frmLichSuHoatDong_Load(object sender, EventArgs e)
        {
            dtpTuNgay.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDenNgay.Value = DateTime.Now;
            LoadData();
        }

        // Nạp dữ liệu nhật ký trong khoảng thời gian chọn
        private void LoadData()
        {
            try
            {
                DateTime tuNgay = dtpTuNgay.Value.Date;
                DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1).AddSeconds(-1);

                var logs = context.LichSuHoatDong
                    .Include(l => l.NhanVien)
                    .Where(l => l.ThoiGian >= tuNgay && l.ThoiGian <= denNgay)
                    .OrderByDescending(l => l.ThoiGian)
                    .Select(l => new
                    {
                        l.ID,
                        NhanVien = l.NhanVien.HoVaTen,
                        l.ThoiGian,
                        l.HanhDong,
                        l.DoiTuong,
                        l.MoTa
                    }).ToList();

                dataGridView.DataSource = logs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Lọc theo khoảng thời gian và nạp lại dữ liệu
        private void btnLoc_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        // Xuất dữ liệu nhật ký ra Excel
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog { Filter = "Excel Workbook|*.xlsx", FileName = "NhatKyHoatDong_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var data = context.LichSuHoatDong
                            .Include(l => l.NhanVien)
                            .OrderByDescending(l => l.ThoiGian)
                            .Select(l => new
                            {
                                ID = l.ID,
                                NhanVien = l.NhanVien.HoVaTen,
                                ThoiGian = l.ThoiGian,
                                HanhDong = l.HanhDong,
                                DoiTuong = l.DoiTuong,
                                MoTa = l.MoTa
                            }).ToList();

                        DataTable dt = ExcelHelper.ToDataTable(data);
                        wb.Worksheets.Add(dt, "NhatKy");
                        wb.SaveAs(sfd.FileName);
                        MessageBox.Show("Xuất báo cáo Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xuất file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            frmLichSuHoatDong_Load(sender, e);
        }
    }
}