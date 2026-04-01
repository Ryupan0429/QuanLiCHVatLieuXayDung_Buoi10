using Microsoft.EntityFrameworkCore;
using QuanLiCHVatLieuXayDung.Data;
using QuanLiCHVatLieuXayDung.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ClosedXML.Excel;
using BC = BCrypt.Net.BCrypt;

namespace QuanLiCHVatLieuXayDung.Forms
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        QLCHVLXDDbContext context = new QLCHVLXDDbContext();
        bool xuLyThem = false;
        int idHienTai;

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LoadData();
        }

        private void LoadData()
        {
            dataGridView.DataSource = context.NhanVien.Select(nv => new DanhSachNhanVien
            {
                ID = nv.ID,
                HoVaTen = nv.HoVaTen,
                DienThoai = nv.DienThoai,
                DiaChi = nv.DiaChi,
                TenDangNhap = nv.TenDangNhap,
                QuyenHan = nv.QuyenHan,
                XemHoaDon = "Xem hóa đơn",
                XemPhieuNhap = "Xem phiếu nhập"
            }).ToList();
        }

        public void BatTatChucNang(bool isEditing)
        {
            btnThem.Enabled = !isEditing;
            btnSua.Enabled = !isEditing;
            btnXoa.Enabled = !isEditing;
            btnLuu.Enabled = isEditing;
            btnHuyBo.Enabled = isEditing;

            txtHoTen.Enabled = isEditing;
            txtTenDangNhap.Enabled = isEditing;
            txtMatKhau.Enabled = isEditing;
            txtDiaChi.Enabled = isEditing;
            txtDienThoai.Enabled = isEditing;
            chkQuyenHan.Enabled = isEditing;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            XoaTrang();
        }

        private void XoaTrang()
        {
            txtHoTen.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtDiaChi.Clear();
            txtDienThoai.Clear();
            chkQuyenHan.Checked = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDangNhap.Text)) return;

            if (xuLyThem)
            {
                NhanVien nv = new NhanVien();
                nv.HoVaTen = txtHoTen.Text;
                nv.TenDangNhap = txtTenDangNhap.Text;
                nv.MatKhau = BC.HashPassword(txtMatKhau.Text);
                nv.DiaChi = txtDiaChi.Text;
                nv.DienThoai = txtDienThoai.Text;
                nv.QuyenHan = chkQuyenHan.Checked;
                context.NhanVien.Add(nv);
                context.SaveChanges();
                NhatKyHeThong.GhiNhatKy("Thêm", "Nhân viên", $"Thêm nhân viên: {nv.HoVaTen}");
            }
            else
            {
                var nv = context.NhanVien.Find(idHienTai);
                if (nv != null)
                {
                    nv.HoVaTen = txtHoTen.Text;
                    nv.TenDangNhap = txtTenDangNhap.Text;
                    if (!string.IsNullOrEmpty(txtMatKhau.Text)) nv.MatKhau = BC.HashPassword(txtMatKhau.Text);
                    nv.DiaChi = txtDiaChi.Text;
                    nv.DienThoai = txtDienThoai.Text;
                    nv.QuyenHan = chkQuyenHan.Checked;
                    context.SaveChanges();
                    NhatKyHeThong.GhiNhatKy("Sửa", "Nhân viên", $"Sửa nhân viên: {nv.HoVaTen}");
                }
            }
            BatTatChucNang(false);
            LoadData();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            idHienTai = (int)dataGridView.Rows[e.RowIndex].Cells[0].Value;
            var nv = context.NhanVien.Find(idHienTai);
            if (nv != null)
            {
                txtHoTen.Text = nv.HoVaTen;
                txtTenDangNhap.Text = nv.TenDangNhap;
                txtDiaChi.Text = nv.DiaChi;
                txtDienThoai.Text = nv.DienThoai;
                chkQuyenHan.Checked = nv.QuyenHan;
                txtMatKhau.Clear();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;
            xuLyThem = false;
            BatTatChucNang(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var nv = context.NhanVien.Find(idHienTai);
                if (nv != null)
                {
                    try
                    {
                        context.NhanVien.Remove(nv);
                        context.SaveChanges();
                        NhatKyHeThong.GhiNhatKy("Xóa", "Nhân viên", $"Xóa nhân viên: {nv.HoVaTen}");
                        LoadData();
                        XoaTrang();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thể xóa nhân viên này vì có dữ liệu liên quan!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            BatTatChucNang(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Tập tin Excel|*.xlsx";
            saveFileDialog.FileName = "DanhSachNhanVien_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[] {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("HoVaTen", typeof(string)),
                        new DataColumn("DienThoai", typeof(string)),
                        new DataColumn("DiaChi", typeof(string)),
                        new DataColumn("TenDangNhap", typeof(string)),
                        new DataColumn("QuyenHan", typeof(string))
                    });

                    var list = context.NhanVien.ToList();
                    foreach (var nv in list)
                    {
                        table.Rows.Add(nv.ID, nv.HoVaTen, nv.DienThoai, nv.DiaChi, nv.TenDangNhap, nv.QuyenHan ? "Quản trị" : "Nhân viên");
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "NhanVien");
                        sheet.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Xuất dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Tập tin Excel|*.xlsx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook wb = new XLWorkbook(openFileDialog.FileName))
                    {
                        var sheet = wb.Worksheet(1);
                        var rows = sheet.RowsUsed().Skip(1);
                        int count = 0;

                        foreach (var row in rows)
                        {
                            string tenDangNhap = row.Cell(5).GetValue<string>();
                            if (context.NhanVien.Any(n => n.TenDangNhap == tenDangNhap)) continue;

                            NhanVien nv = new NhanVien
                            {
                                HoVaTen = row.Cell(2).GetValue<string>(),
                                DienThoai = row.Cell(3).GetValue<string>(),
                                DiaChi = row.Cell(4).GetValue<string>(),
                                TenDangNhap = tenDangNhap,
                                MatKhau = BC.HashPassword("123456"),
                                QuyenHan = row.Cell(6).GetValue<string>() == "Quản trị"
                            };
                            context.NhanVien.Add(nv);
                            count++;
                        }
                        context.SaveChanges();
                        MessageBox.Show($"Đã nhập thành công {count} nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi nhập Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                LoadData();
                return;
            }
            else
            {
                string keyword = txtTimKiem.Text.ToLower();
                var filtered = context.NhanVien.Where(nv => nv.HoVaTen.ToLower().Contains(keyword) || nv.TenDangNhap.ToLower().Contains(keyword)).Select(nv => new DanhSachNhanVien
                {
                    ID = nv.ID,
                    HoVaTen = nv.HoVaTen,
                    DienThoai = nv.DienThoai,
                    DiaChi = nv.DiaChi,
                    TenDangNhap = nv.TenDangNhap,
                    QuyenHan = nv.QuyenHan,
                    XemHoaDon = "Xem hóa đơn",
                    XemPhieuNhap = "Xem phiếu nhập"
                }).ToList();
                dataGridView.DataSource = filtered;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            frmNhanVien_Load(sender, e);
        }
    }
}