using ClosedXML.Excel;
using QuanLiCHVatLieuXayDung.Data;
using QuanLiCHVatLieuXayDung.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLiCHVatLieuXayDung.Forms
{
    public partial class frmLoaiSanPham : Form
    {
        public frmLoaiSanPham()
        {
            InitializeComponent();
        }

        QLCHVLXDDbContext context = new QLCHVLXDDbContext();
        bool xuLyThem = false;
        int idHienTai;

        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LoadData();
        }

        private void LoadData()
        {
            dataGridView.DataSource = context.LoaiSanPham.ToList();
        }

        public void BatTatChucNang(bool isEditing)
        {
            btnThem.Enabled = !isEditing;
            btnSua.Enabled = !isEditing;
            btnXoa.Enabled = !isEditing;
            btnHuyBo.Enabled = isEditing;
            btnLuu.Enabled = isEditing;

            txtTenLoai.Enabled = isEditing;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTenLoai.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;
            xuLyThem = false;
            BatTatChucNang(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenLoai.Text)) return;

            if (xuLyThem)
            {
                LoaiSanPham l = new LoaiSanPham { TenLoai = txtTenLoai.Text };
                context.LoaiSanPham.Add(l);
                context.SaveChanges();
                NhatKyHeThong.GhiNhatKy("Thêm", "Loại sản phẩm", "Thêm loại: " + l.TenLoai);
            }
            else
            {
                var l = context.LoaiSanPham.Find(idHienTai);
                if (l != null)
                {
                    l.TenLoai = txtTenLoai.Text;
                    context.SaveChanges();
                    NhatKyHeThong.GhiNhatKy("Sửa", "Loại sản phẩm", "Cập nhật loại ID: " + l.ID);
                }
            }
            BatTatChucNang(false);
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;
            if (MessageBox.Show("Xác nhận xóa loại sản phẩm này?", "Hỏi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var l = context.LoaiSanPham.Find(idHienTai);
                if (l != null)
                {
                    context.LoaiSanPham.Remove(l);
                    context.SaveChanges();
                    NhatKyHeThong.GhiNhatKy("Xóa", "Loại sản phẩm", "Xóa loại: " + l.TenLoai);
                    LoadData();
                }
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idHienTai = (int)dataGridView.Rows[e.RowIndex].Cells["ID"].Value;
                var l = context.LoaiSanPham.Find(idHienTai);
                if (l != null)
                {
                    txtTenLoai.Text = l.TenLoai;
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
                            LoaiSanPham l = new LoaiSanPham { TenLoai = row.Cell(2).GetValue<string>() };
                            context.LoaiSanPham.Add(l);
                            count++;
                        }
                        context.SaveChanges();
                        NhatKyHeThong.GhiNhatKy("Nhập Excel", "Loại sản phẩm", "Nhập " + count + " loại SP từ file " + ofd.SafeFileName);
                        MessageBox.Show("Đã nhập thành công " + count + " loại sản phẩm.");
                        LoadData();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog { Filter = "Excel|*.xlsx", FileName = "LoaiSanPham_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (XLWorkbook wb = new XLWorkbook())
                {
                    var data = context.LoaiSanPham.ToList();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID"); dt.Columns.Add("Tên loại");
                    foreach (var l in data) dt.Rows.Add(l.ID, l.TenLoai);
                    wb.Worksheets.Add(dt, "LoaiSanPham");
                    wb.SaveAs(sfd.FileName);
                    NhatKyHeThong.GhiNhatKy("Xuất Excel", "Loại sản phẩm", "Xuất danh sách loại sản phẩm ra file " + sfd.FileName);
                    MessageBox.Show("Xuất thành công.");
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e) => BatTatChucNang(false);
        private void btnThoat_Click(object sender, EventArgs e) => this.Close();
    }
}