using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using QuanLiCHVatLieuXayDung.Data;
using QuanLiCHVatLieuXayDung.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLiCHVatLieuXayDung.Forms
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        QLCHVLXDDbContext context = new QLCHVLXDDbContext();
        bool xuLyThem = false;
        int idHienTai;

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LoadData();
        }

        private void LoadData()
        {
            dataGridView.DataSource = context.KhachHang.ToList();
        }

        public void BatTatChucNang(bool isEditing)
        {
            btnThem.Enabled = !isEditing;
            btnSua.Enabled = !isEditing;
            btnXoa.Enabled = !isEditing;
            btnHuyBo.Enabled = isEditing;
            btnLuu.Enabled = isEditing;

            txtTenKhachHang.Enabled = isEditing;
            txtSoDienThoai.Enabled = isEditing;
            txtDiaChi.Enabled = isEditing;
            txtLoaiKhach.Enabled = isEditing;
            txtTongNo.Enabled = isEditing;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            XoaTrang();
        }

        private void XoaTrang()
        {
            txtTenKhachHang.Clear();
            txtSoDienThoai.Clear();
            txtDiaChi.Clear();
            txtLoaiKhach.Clear();
            txtTongNo.Text = "0";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;
            xuLyThem = false;
            BatTatChucNang(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKhachHang.Text)) return;

            if (xuLyThem)
            {
                KhachHang kh = new KhachHang
                {
                    TenKhachHang = txtTenKhachHang.Text,
                    SoDienThoai = txtSoDienThoai.Text,
                    DiaChi = txtDiaChi.Text,
                    LoaiKhachHang = txtLoaiKhach.Text,
                    TongNo = decimal.Parse(txtTongNo.Text)
                };
                context.KhachHang.Add(kh);
                context.SaveChanges();
                NhatKyHeThong.GhiNhatKy("Thêm", "Khách hàng", "Thêm khách hàng: " + kh.TenKhachHang);
            }
            else
            {
                var kh = context.KhachHang.Find(idHienTai);
                if (kh != null)
                {
                    kh.TenKhachHang = txtTenKhachHang.Text;
                    kh.SoDienThoai = txtSoDienThoai.Text;
                    kh.DiaChi = txtDiaChi.Text;
                    kh.LoaiKhachHang = txtLoaiKhach.Text;
                    kh.TongNo = decimal.Parse(txtTongNo.Text);
                    context.SaveChanges();
                    NhatKyHeThong.GhiNhatKy("Sửa", "Khách hàng", "Cập nhật khách hàng ID: " + kh.ID);
                }
            }
            BatTatChucNang(false);
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;
            if (MessageBox.Show("Xác nhận xóa khách hàng này?", "Hỏi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var kh = context.KhachHang.Find(idHienTai);
                if (kh != null)
                {
                    context.KhachHang.Remove(kh);
                    context.SaveChanges();
                    NhatKyHeThong.GhiNhatKy("Xóa", "Khách hàng", "Xóa khách hàng: " + kh.TenKhachHang);
                    LoadData();
                }
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idHienTai = (int)dataGridView.Rows[e.RowIndex].Cells["KhachHangID"].Value;
                var kh = context.KhachHang.Find(idHienTai);
                if (kh != null)
                {
                    txtTenKhachHang.Text = kh.TenKhachHang;
                    txtSoDienThoai.Text = kh.SoDienThoai;
                    txtDiaChi.Text = kh.DiaChi;
                    txtLoaiKhach.Text = kh.LoaiKhachHang;
                    txtTongNo.Text = kh.TongNo.ToString();
                }
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog { Filter = "Excel|*.xlsx" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook wb = new XLWorkbook(ofd.FileName))
                    {
                        var sheet = wb.Worksheet(1);
                        var rows = sheet.RowsUsed().Skip(1);
                        int count = 0;
                        foreach (var row in rows)
                        {
                            KhachHang kh = new KhachHang
                            {
                                TenKhachHang = row.Cell(2).GetValue<string>(),
                                SoDienThoai = row.Cell(3).GetValue<string>(),
                                DiaChi = row.Cell(4).GetValue<string>(),
                                LoaiKhachHang = row.Cell(5).GetValue<string>(),
                                TongNo = row.Cell(6).GetValue<Decimal>(),
                            };
                            context.KhachHang.Add(kh);
                            count++;
                        }
                        context.SaveChanges();
                        NhatKyHeThong.GhiNhatKy("Nhập Excel", "Khách hàng", "Nhập " + count + " khách hàng từ file " + ofd.SafeFileName);
                        MessageBox.Show("Đã nhập thành công " + count + " khách hàng.");
                        LoadData();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog { Filter = "Excel|*.xlsx", FileName = "KhachHang_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (XLWorkbook wb = new XLWorkbook())
                {
                    var data = context.KhachHang.ToList();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID"); dt.Columns.Add("Tên Khách Hàng"); dt.Columns.Add("SĐT"); dt.Columns.Add("Địa Chỉ"); dt.Columns.Add("Loại"); dt.Columns.Add("Tổng Nợ");
                    foreach (var k in data) dt.Rows.Add(k.ID, k.TenKhachHang, k.SoDienThoai, k.DiaChi, k.LoaiKhachHang, k.TongNo);
                    wb.Worksheets.Add(dt, "KhachHang");
                    wb.SaveAs(sfd.FileName);
                    NhatKyHeThong.GhiNhatKy("Xuất Excel", "Khách hàng", "Xuất danh sách khách hàng ra file " + sfd.FileName);
                    MessageBox.Show("Xuất thành công.");
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e) => BatTatChucNang(false);
        private void btnThoat_Click(object sender, EventArgs e) => this.Close();

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                LoadData();
                return;
            }
            else
            {
                string keyword = txtTimKiem.Text.ToLower();
                var list = context.KhachHang.Where(k => k.TenKhachHang.ToLower().Contains(keyword) || k.SoDienThoai.Contains(keyword) || k.DiaChi.ToLower().Contains(keyword)).ToList();
                dataGridView.DataSource = list;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            frmKhachHang_Load(sender, e);
        }
    }
}