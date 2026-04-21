using ClosedXML.Excel;
using QuanLiCHVatLieuXayDung.Data;
using QuanLiCHVatLieuXayDung.Reports;
using QuanLiCHVatLieuXayDung.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLiCHVatLieuXayDung.Forms
{
    public partial class frmPhieuNhap : Form
    {
        // Form quản lý phiếu nhập: hiển thị danh sách, thêm/sửa/xóa, nhập/xuất Excel, in phiếu
        // DbContext để truy xuất dữ liệu
        QLCHVLXDDbContext context = new QLCHVLXDDbContext();
        int id; // lưu id phiếu nhập đang chọn

        public frmPhieuNhap()
        {
            InitializeComponent();
        }

        // Khi form load: nạp danh sách phiếu nhập và hiển thị vào DataGridView
        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            // Lấy danh sách phiếu nhập cùng tổng tiền tính từ chi tiết
            List<DanhSachPhieuNhap> pn = context.PhieuNhap.Select(r => new DanhSachPhieuNhap
            {
                ID = r.ID,
                NhanVienID = r.NhanVienID,
                HoVaTenNhanVien = r.NhanVien.HoVaTen,
                NhaCungCapID = r.NhaCungCapID,
                TenNhaCungCap = r.NhaCungCap.TenNhaCungCap,
                NgayNhap = r.NgayNhap,
                GhiChu = r.GhiChu,
                // Tổng tiền = tổng (Số lượng * Đơn giá nhập) từ chi tiết
                TongTien = r.PhieuNhap_ChiTiet.Sum(ct => ct.SoLuong * ct.DonGiaNhap),
                XemChiTiet = "Xem chi tiết"
            }).ToList();
            dataGridView.DataSource = pn;
        }

        // Mở form chi tiết để lập phiếu mới
        private void btnLapPhieuNhap_Click(object sender, EventArgs e)
        {
            using (frmPhieuNhap_ChiTiet chiTiet = new frmPhieuNhap_ChiTiet())
            {
                chiTiet.ShowDialog();
                // reload danh sách sau khi đóng
                frmPhieuNhap_Load(sender, e);
            }
        }

        // Mở form chi tiết để sửa phiếu đã chọn
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["PNID"].Value);
                using (frmPhieuNhap_ChiTiet chiTiet = new frmPhieuNhap_ChiTiet(id))
                {
                    chiTiet.ShowDialog();
                    frmPhieuNhap_Load(sender, e);
                }
            }
        }

        // Xóa phiếu nhập: phục hồi tồn kho, xóa chi tiết rồi xóa phiếu
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["PNID"].Value);
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu nhập này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (var trans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            var pn = context.PhieuNhap.Find(id);
                            if (pn != null)
                            {
                                var chiTiets = context.PhieuNhap_ChiTiet.Where(ct => ct.PhieuNhapID == id).ToList();

                                // Hoàn tác tồn kho: trừ ngược số lượng đã cộng khi nhập
                                foreach (var ct in chiTiets)
                                {
                                    var sp = context.SanPham.Find(ct.SanPhamID);
                                    if (sp != null)
                                    {
                                        sp.SoLuong -= ct.SoLuong;
                                    }
                                }

                                context.PhieuNhap_ChiTiet.RemoveRange(chiTiets);
                                context.PhieuNhap.Remove(pn);
                                context.SaveChanges();
                                trans.Commit();

                                NhatKyHeThong.GhiNhatKy("Xóa", "Phiếu nhập", $"Xóa phiếu nhập ID: {id} - Tổng tiền: {pn.TongTien:N0}");

                                MessageBox.Show("Xóa phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                frmPhieuNhap_Load(sender, e);
                            }
                        }
                        catch (Exception ex)
                        {
                            trans.Rollback();
                            MessageBox.Show("Lỗi trong quá trình xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        // Đóng form
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Xử lý click vào nút Xem chi tiết trên lưới
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dataGridView.Columns["ChiTiet"] != null && e.ColumnIndex == dataGridView.Columns["ChiTiet"].Index)
            {
                id = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["PNID"].Value);
                using (frmPhieuNhap_ChiTiet chiTiet = new frmPhieuNhap_ChiTiet(id))
                {
                    chiTiet.ShowDialog();
                    frmPhieuNhap_Load(sender, e);
                }
            }
        }

        // Xuất danh sách phiếu nhập và chi tiết sang Excel
        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "PhieuNhap_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table1 = new DataTable();
                    DataTable table2 = new DataTable();

                    table1.Columns.AddRange(new DataColumn[6] {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("NhanVienID", typeof(int)),
                        new DataColumn("NhaCungCapID", typeof(int)),
                        new DataColumn("NgayNhap", typeof(DateTime)),
                        new DataColumn("GhiChu", typeof(string)),
                        new DataColumn("TongTien", typeof(decimal))
                    });

                    var phieuNhap = context.PhieuNhap.ToList();
                    if (phieuNhap != null)
                    {
                        foreach (var p in phieuNhap)
                            table1.Rows.Add(p.ID, p.NhanVienID, p.NhaCungCapID, p.NgayNhap, p.GhiChu, p.TongTien);
                    }

                    table2.Columns.AddRange(new DataColumn[6] {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("PhieuNhapID", typeof(int)),
                        new DataColumn("SanPhamID", typeof(int)),
                        new DataColumn("SoLuong", typeof(int)),
                        new DataColumn("DonGiaNhap", typeof(decimal)),
                        new DataColumn("ThanhTien", typeof(decimal))
                    });

                    var chiTietPhieuNhap = context.PhieuNhap_ChiTiet.ToList();
                    if (chiTietPhieuNhap != null)
                    {
                        foreach (var p in chiTietPhieuNhap)
                            table2.Rows.Add(p.ID, p.PhieuNhapID, p.SanPhamID, p.SoLuong, p.DonGiaNhap, p.ThanhTien);
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet1 = wb.Worksheets.Add(table1, "PhieuNhap");
                        var sheet2 = wb.Worksheets.Add(table2, "PhieuNhap_ChiTiet");
                        sheet1.Columns().AdjustToContents();
                        sheet2.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);
                        NhatKyHeThong.GhiNhatKy("Xuất Excel", "Phiếu nhập", $"Xuất danh sách ra file {saveFileDialog.FileName}");
                        MessageBox.Show("Đã xuất dữ liệu ra tập tin Excel thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        // Nhập dữ liệu từ Excel (hai sheet: PhieuNhap và PhieuNhap_ChiTiet)
        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu từ tập tin Excel";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        IXLWorksheet worksheet1 = workbook.Worksheet(1); // Sheet PhieuNhap
                        IXLWorksheet worksheet2 = workbook.Worksheet(2); // Sheet PhieuNhap_ChiTiet

                        DataTable table1 = new DataTable();
                        bool firstRow = true;
                        string readRange = "1:1";
                        foreach (IXLRow row in worksheet1.RowsUsed())
                        {
                            if (firstRow)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRange))
                                    table1.Columns.Add(cell.Value.ToString());
                                firstRow = false;
                            }
                            else
                            {
                                table1.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    table1.Rows[table1.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }

                        DataTable table2 = new DataTable();
                        firstRow = true;
                        foreach (IXLRow row in worksheet2.RowsUsed())
                        {
                            if (firstRow)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRange))
                                    table2.Columns.Add(cell.Value.ToString());
                                firstRow = false;
                            }
                            else
                            {
                                table2.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    table2.Rows[table2.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }

                        if (table1.Rows.Count > 0 && table2.Rows.Count > 0)
                        {
                            foreach (DataRow r in table1.Rows)
                            {
                                PhieuNhap pn = new PhieuNhap();
                                pn.NhanVienID = Convert.ToInt32(r["NhanVienID"]);
                                pn.NhaCungCapID = Convert.ToInt32(r["NhaCungCapID"]);
                                pn.NgayNhap = Convert.ToDateTime(r["NgayNhap"].ToString());
                                pn.GhiChu = r["GhiChu"].ToString();
                                pn.TongTien = Convert.ToDecimal(r["TongTien"]);
                                context.PhieuNhap.Add(pn);
                            }
                            foreach (DataRow r in table2.Rows)
                            {
                                PhieuNhap_ChiTiet ctpn = new PhieuNhap_ChiTiet();
                                ctpn.PhieuNhapID = Convert.ToInt32(r["PhieuNhapID"]);
                                ctpn.SanPhamID = Convert.ToInt32(r["SanPhamID"]);
                                ctpn.SoLuong = Convert.ToInt32(r["SoLuong"]);
                                ctpn.DonGiaNhap = Convert.ToDecimal(r["DonGiaNhap"]);
                                ctpn.ThanhTien = Convert.ToDecimal(r["ThanhTien"]);
                                context.PhieuNhap_ChiTiet.Add(ctpn);
                            }
                            context.SaveChanges();
                            NhatKyHeThong.GhiNhatKy("Nhập Excel", "Phiếu nhập", "Nhập " + table1.Rows.Count + " phiếu nhập từ file " + openFileDialog.FileName);
                            MessageBox.Show("Đã nhập thành công " + table1.Rows.Count + " phiếu nhập và " + table2.Rows.Count + " chi tiết.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmPhieuNhap_Load(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        // In phiếu nhập đã chọn
        private void btnInPhieuNhap_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["PNID"].Value.ToString());
                using (frmInPhieuNhap inPhieu = new frmInPhieuNhap(id))
                {
                    inPhieu.ShowDialog();
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        // Lọc theo khoảng thời gian
        private void btnLoc_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1).AddSeconds(-1);
            if (tuNgay > denNgay)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var phieuNhap = context.PhieuNhap.Where(p => p.NgayNhap >= tuNgay && p.NgayNhap <= denNgay).Select(r => new DanhSachPhieuNhap
                {
                    ID = r.ID,
                    NhanVienID = r.NhanVienID,
                    HoVaTenNhanVien = r.NhanVien.HoVaTen,
                    NhaCungCapID = r.NhaCungCapID,
                    TenNhaCungCap = r.NhaCungCap.TenNhaCungCap,
                    NgayNhap = r.NgayNhap,
                    GhiChu = r.GhiChu,
                    TongTien = r.PhieuNhap_ChiTiet.Sum(ct => ct.SoLuong * ct.DonGiaNhap),
                    XemChiTiet = "Xem chi tiết"
                }).ToList();
                dataGridView.DataSource = phieuNhap;
            }

        }
    }
}