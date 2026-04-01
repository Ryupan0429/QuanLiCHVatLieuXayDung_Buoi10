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
    public partial class frmHoaDon : Form
    {
        QLCHVLXDDbContext context = new QLCHVLXDDbContext();
        int id;

        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            List<DanhSachHoaDon> hd = context.HoaDon.Select(r => new DanhSachHoaDon
            {
                ID = r.ID,
                NhanVienID = r.NhanVienID,
                HoVaTenNhanVien = r.NhanVien.HoVaTen,
                KhachHangID = r.KhachHangID,
                HoVaTenKhachHang = r.KhachHang.TenKhachHang,
                NgayLap = r.NgayLap,
                GhiChuHoaDon = r.GhiChuHoaDon,
                TongTienHoaDon = r.HoaDon_ChiTiet.Sum(ct => ct.SoLuong * ct.DonGia),
                XemChiTiet = "Xem chi tiết"
            }).ToList();
            dataGridView.DataSource = hd;
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet())
            {
                chiTiet.ShowDialog();
                frmHoaDon_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);
                using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet(id))
                {
                    chiTiet.ShowDialog();
                    frmHoaDon_Load(sender, e);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    var hd = context.HoaDon.Find(id);
                    if (hd != null)
                    {
                        var chiTiets = context.HoaDon_ChiTiet.Where(ct => ct.HoaDonID == id).ToList();
                        decimal tongTien = hd.HoaDon_ChiTiet.Sum(ct => ct.SoLuong * ct.DonGia);
                        context.HoaDon_ChiTiet.RemoveRange(chiTiets);
                        context.HoaDon.Remove(hd);
                        context.SaveChanges();
                        NhatKyHeThong.GhiNhatKy("Xóa", "Hóa đơn", $"Xóa hóa đơn ID: {id} - Tổng tiền: {tongTien:N0}");
                        frmHoaDon_Load(sender, e);
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;
            if (dataGridView.Columns["ChiTiet"] != null && e.ColumnIndex == dataGridView.Columns["ChiTiet"].Index)
            {
                id = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["ID"].Value);
                using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet(id))
                {
                    chiTiet.ShowDialog();
                    frmHoaDon_Load(sender, e);
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "HoaDon_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table1 = new DataTable();
                    DataTable table2 = new DataTable();

                    table1.Columns.AddRange(new DataColumn[5] {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("NhanVienID", typeof(int)),
                        new DataColumn("KhachHangID", typeof(int)),
                        new DataColumn("NgayLap", typeof(DateTime)),
                        new DataColumn("GhiChuHoaDon", typeof(string))
                    });

                    var hoaDon = context.HoaDon.ToList();
                    if (hoaDon != null)
                    {
                        foreach (var p in hoaDon)
                            table1.Rows.Add(p.ID, p.NhanVienID, p.KhachHangID, p.NgayLap, p.GhiChuHoaDon);
                    }

                    table2.Columns.AddRange(new DataColumn[6] {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("HoaDonID", typeof(int)),
                        new DataColumn("SanPhamID", typeof(int)),
                        new DataColumn("SoLuong", typeof(decimal)),
                        new DataColumn("DonGia", typeof(decimal)),
                        new DataColumn("ThanhTien", typeof(decimal))
                    });

                    var chiTietHoaDon = context.HoaDon_ChiTiet.ToList();
                    if (chiTietHoaDon != null)
                    {
                        foreach (var p in chiTietHoaDon)
                            table2.Rows.Add(p.ID, p.HoaDonID, p.SanPhamID, p.SoLuong, p.DonGia, p.ThanhTien);
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet1 = wb.Worksheets.Add(table1, "HoaDon");
                        var sheet2 = wb.Worksheets.Add(table2, "HoaDon_ChiTiet");
                        sheet1.Columns().AdjustToContents();
                        sheet2.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);
                        NhatKyHeThong.GhiNhatKy("Xuất Excel", "Hóa đơn", $"Xuất danh sách ra file {saveFileDialog.FileName}");
                        MessageBox.Show("Đã xuất dữ liệu ra tập tin Excel thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

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
                        IXLWorksheet worksheet1 = workbook.Worksheet(1);
                        IXLWorksheet worksheet2 = workbook.Worksheet(2);

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
                                HoaDon hd = new HoaDon();
                                hd.NhanVienID = Convert.ToInt32(r["NhanVienID"]);
                                hd.KhachHangID = Convert.ToInt32(r["KhachHangID"]);
                                hd.NgayLap = Convert.ToDateTime(r["NgayLap"].ToString());
                                hd.GhiChuHoaDon = r["GhiChuHoaDon"].ToString();
                                context.HoaDon.Add(hd);
                            }
                            foreach (DataRow r in table2.Rows)
                            {
                                HoaDon_ChiTiet cthd = new HoaDon_ChiTiet();
                                cthd.HoaDonID = Convert.ToInt32(r["HoaDonID"]);
                                cthd.SanPhamID = Convert.ToInt32(r["SanPhamID"]);
                                cthd.SoLuong = Convert.ToInt32(r["SoLuong"]);
                                cthd.DonGia = Convert.ToDecimal(r["DonGia"]);
                                cthd.ThanhTien = Convert.ToDecimal(r["ThanhTien"]);
                                context.HoaDon_ChiTiet.Add(cthd);
                            }
                            context.SaveChanges();
                            NhatKyHeThong.GhiNhatKy("Nhập Excel", "Hóa đơn", "Nhập " + table1.Rows.Count + " hóa đơn từ file " + openFileDialog.FileName);
                            MessageBox.Show("Đã nhập thành công " + table1.Rows.Count + " hóa đơn và " + table2.Rows.Count + " chi tiết.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmHoaDon_Load(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
            using (frmInHoaDon inHoaDon = new frmInHoaDon(id))
            {
                inHoaDon.ShowDialog();
            }
        }

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
                List<DanhSachHoaDon> hd = context.HoaDon.Where(r => r.NgayLap >= tuNgay && r.NgayLap <= denNgay).Select(r => new DanhSachHoaDon
                {
                    ID = r.ID,
                    NhanVienID = r.NhanVienID,
                    HoVaTenNhanVien = r.NhanVien.HoVaTen,
                    KhachHangID = r.KhachHangID,
                    HoVaTenKhachHang = r.KhachHang.TenKhachHang,
                    NgayLap = r.NgayLap,
                    GhiChuHoaDon = r.GhiChuHoaDon,
                    TongTienHoaDon = r.HoaDon_ChiTiet.Sum(ct => ct.SoLuong * ct.DonGia),
                    XemChiTiet = "Xem chi tiết"
                }).ToList();
                dataGridView.DataSource = hd;

            }
        }

        private void btnHuyLoc_Click(object sender, EventArgs e)
        {
            frmHoaDon_Load(sender, e);
        }
    }
}