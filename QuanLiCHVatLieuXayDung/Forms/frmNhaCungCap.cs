using ClosedXML.Excel;
using QuanLiCHVatLieuXayDung.Data;
using QuanLiCHVatLieuXayDung.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuanLiCHVatLieuXayDung.Forms
{
    public partial class frmNhaCungCap : Form
    {
        // Form quản lý nhà cung cấp. Các ghi chú và quy tắc xác thực:
        //  - TenNhaCungCap là bắt buộc
        //  - SoDienThoai nếu có thì phải đúng định dạng (cho phép chữ số, dấu +, khoảng trắng, dấu - và dấu ngoặc)

        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        QLCHVLXDDbContext context = new QLCHVLXDDbContext();
        bool xuLyThem = false;
        int idHienTai;

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LoadData();
        }

        private void LoadData()
        {
            dataGridView.DataSource = context.NhaCungCap.ToList();
        }

        public void BatTatChucNang(bool isEditing)
        {
            btnThem.Enabled = !isEditing;
            btnSua.Enabled = !isEditing;
            btnXoa.Enabled = !isEditing;
            btnHuyBo.Enabled = isEditing;
            btnLuu.Enabled = isEditing;

            txtTenNhaCungCap.Enabled = isEditing;
            txtSDT.Enabled = isEditing;
            txtDiaChi.Enabled = isEditing;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            XoaTrang();
        }

        private void XoaTrang()
        {
            txtTenNhaCungCap.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;
            xuLyThem = false;
            BatTatChucNang(true);
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtTenNhaCungCap.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenNhaCungCap.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                var phonePattern = new Regex(@"^[0-9\+\-\s\(\)]{7,}$");
                if (!phonePattern.IsMatch(txtSDT.Text.Trim()))
                {
                    MessageBox.Show("Số điện thoại không đúng định dạng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSDT.Focus();
                    return false;
                }
            }

            return true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            if (xuLyThem)
            {
                NhaCungCap ncc = new NhaCungCap
                {
                    TenNhaCungCap = txtTenNhaCungCap.Text.Trim(),
                    SoDienThoai = txtSDT.Text.Trim(),
                    DiaChi = txtDiaChi.Text.Trim()
                };
                context.NhaCungCap.Add(ncc);
                context.SaveChanges();
                NhatKyHeThong.GhiNhatKy("Thêm", "Nhà cung cấp", "Thêm NCC: " + ncc.TenNhaCungCap);
            }
            else
            {
                var ncc = context.NhaCungCap.Find(idHienTai);
                if (ncc != null)
                {
                    ncc.TenNhaCungCap = txtTenNhaCungCap.Text.Trim();
                    ncc.SoDienThoai = txtSDT.Text.Trim();
                    ncc.DiaChi = txtDiaChi.Text.Trim();
                    context.SaveChanges();
                    NhatKyHeThong.GhiNhatKy("Sửa", "Nhà cung cấp", "Cập nhật NCC ID: " + ncc.ID);
                }
            }
            BatTatChucNang(false);
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;
            if (MessageBox.Show("Xác nhận xóa nhà cung cấp này?", "Hỏi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var ncc = context.NhaCungCap.Find(idHienTai);
                if (ncc != null)
                {
                    context.NhaCungCap.Remove(ncc);
                    context.SaveChanges();
                    NhatKyHeThong.GhiNhatKy("Xóa", "Nhà cung cấp", "Xóa NCC: " + ncc.TenNhaCungCap);
                    LoadData();
                }
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var cellVal = dataGridView.Rows[e.RowIndex].Cells["NCCID"].Value;
                if (cellVal == null) return;
                if (!int.TryParse(cellVal.ToString(), out idHienTai)) return;

                var ncc = context.NhaCungCap.Find(idHienTai);
                if (ncc != null)
                {
                    txtTenNhaCungCap.Text = ncc.TenNhaCungCap;
                    txtSDT.Text = ncc.SoDienThoai;
                    txtDiaChi.Text = ncc.DiaChi;
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
                            NhaCungCap ncc = new NhaCungCap
                            {
                                TenNhaCungCap = row.Cell(2).GetValue<string>(),
                                SoDienThoai = row.Cell(3).GetValue<string>(),
                                DiaChi = row.Cell(4).GetValue<string>()
                            };
                            context.NhaCungCap.Add(ncc);
                            count++;
                        }
                        context.SaveChanges();
                        NhatKyHeThong.GhiNhatKy("Nhập Excel", "Nhà cung cấp", "Nhập " + count + " NCC từ file " + ofd.SafeFileName);
                        MessageBox.Show("Đã nhập thành công " + count + " nhà cung cấp.");
                        LoadData();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog { Filter = "Excel|*.xlsx", FileName = "NhaCungCap_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (XLWorkbook wb = new XLWorkbook())
                {
                    var data = context.NhaCungCap.ToList();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID"); dt.Columns.Add("Tên Nhà Cung Cấp"); dt.Columns.Add("SĐT"); dt.Columns.Add("Địa Chỉ");
                    foreach (var n in data) dt.Rows.Add(n.ID, n.TenNhaCungCap, n.SoDienThoai, n.DiaChi);
                    wb.Worksheets.Add(dt, "NhaCungCap");
                    wb.SaveAs(sfd.FileName);
                    NhatKyHeThong.GhiNhatKy("Xuất Excel", "Nhà cung cấp", "Xuất danh sách NCC ra file " + sfd.FileName);
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
            }
            else
            {
                string keyword = txtTimKiem.Text.ToLower();
                var result = context.NhaCungCap.Where(n => n.TenNhaCungCap.ToLower().Contains(keyword) || n.SoDienThoai.Contains(keyword) || n.DiaChi.ToLower().Contains(keyword)).ToList();
                dataGridView.DataSource = result;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            LoadData();
        }
    }
}