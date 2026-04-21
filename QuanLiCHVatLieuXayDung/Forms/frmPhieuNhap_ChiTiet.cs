using DocumentFormat.OpenXml.Office2010.Excel;
using QuanLiCHVatLieuXayDung.Data;
using QuanLiCHVatLieuXayDung.Reports;
using QuanLiCHVatLieuXayDung.Utilities;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace QuanLiCHVatLieuXayDung.Forms
{
    public partial class frmPhieuNhap_ChiTiet : Form
    {
        // Form quản lý chi tiết phiếu nhập: thêm/sửa/xóa chi tiết, tính tổng, lưu phiếu nhập
        QLCHVLXDDbContext context = new QLCHVLXDDbContext();
        BindingList<DanhSachPhieuNhap_ChiTiet> listChiTiet = new BindingList<DanhSachPhieuNhap_ChiTiet>();
        int id; // id phiếu nhập

        public frmPhieuNhap_ChiTiet()
        {
            InitializeComponent();
        }

        public frmPhieuNhap_ChiTiet(int maPhieuNhap = 0)
        {
            InitializeComponent();
            // Lưu id được truyền vào để nạp dữ liệu khi sửa
            id = maPhieuNhap;
        }

        // Khi load form: nạp combobox, nạp chi tiết nếu có id (sửa) và hiển thị lên grid
        private void frmPhieuNhap_ChiTiet_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            dataGridView.AutoGenerateColumns = false;

            if (id != 0)
            {
                var pn = context.PhieuNhap.Where(p => p.ID == id).SingleOrDefault();
                if (pn != null)
                {
                    cboNhaCungCap.SelectedValue = pn.NhaCungCapID;
                    dtpNgayNhap.Value = pn.NgayNhap;
                    txtGhiChu.Text = pn.GhiChu;

                    // Lấy danh sách chi tiết từ DB và chuyển thành DTO
                    var ct = context.PhieuNhap_ChiTiet
                        .Where(r => r.PhieuNhapID == id)
                        .Select(r => new DanhSachPhieuNhap_ChiTiet
                        {
                            ID = r.ID,
                            PhieuNhapID = r.PhieuNhapID,
                            SanPhamID = r.SanPhamID,
                            TenSanPham = r.SanPham.TenSanPham,
                            SoLuong = r.SoLuong,
                            DonGiaNhap = r.DonGiaNhap,
                            ThanhTien = r.SoLuong * r.DonGiaNhap
                        }).ToList();

                    listChiTiet = new BindingList<DanhSachPhieuNhap_ChiTiet>(ct);
                }
            }

            dataGridView.DataSource = listChiTiet;
            RecalculateTotal();
            UpdateUiState();
        }

        // Nạp dữ liệu cho combobox Nhà cung cấp và Sản phẩm
        private void LoadComboBox()
        {
            cboNhaCungCap.DataSource = context.NhaCungCap.ToList();
            cboNhaCungCap.DisplayMember = "TenNhaCungCap";
            cboNhaCungCap.ValueMember = "ID";

            cboSanPham.DataSource = context.SanPham.Where(s => !s.DaXoa).ToList();
            cboSanPham.DisplayMember = "TenSanPham";
            cboSanPham.ValueMember = "ID";
            cboSanPham.SelectedIndex = -1;
        }

        // Cập nhật trạng thái UI: khi không có chi tiết thì disable nút lưu, xóa
        private void UpdateUiState()
        {
            if (id == 0 && dataGridView.Rows.Count == 0)
            {
                cboNhaCungCap.Text = "";
                cboSanPham.Text = "";
                numSoLuong.Value = 1;
                numDonGia.Value = 0;
                txtTongTien.Text = "0";
            }

            btnLuu.Enabled = dataGridView.Rows.Count > 0;
            btnXoaSP.Enabled = dataGridView.Rows.Count > 0;
        }

        // Khi chọn sản phẩm, nạp đơn giá nhập mặc định từ sản phẩm
        private void cboSanPham_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedValue != null)
            {
                int idSp = (int)cboSanPham.SelectedValue;
                var sp = context.SanPham.Find(idSp);
                if (sp != null)
                {
                    numDonGia.Value = sp.GiaNhap;
                }
            }
        }

        // Thêm sản phẩm vào danh sách chi tiết (nếu đã tồn tại thì cộng số lượng)
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedItem is SanPham sp)
            {
                int sl =  Convert.ToInt32(numSoLuong.Value);
                decimal dg = numDonGia.Value;

                if (sl <= 0)
                {
                    MessageBox.Show("Số lượng phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dg <= 0)
                {
                    MessageBox.Show("Đơn giá nhập phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var item = listChiTiet.FirstOrDefault(x => x.SanPhamID == sp.ID);
                if (item != null)
                {
                    item.SoLuong += sl;
                    item.DonGiaNhap = dg;
                    item.ThanhTien = item.SoLuong * item.DonGiaNhap;
                    listChiTiet.ResetBindings();
                }
                else
                {
                    listChiTiet.Add(new DanhSachPhieuNhap_ChiTiet
                    {
                        ID = 0,
                        PhieuNhapID = id,
                        SanPhamID = sp.ID,
                        TenSanPham = sp.TenSanPham,
                        SoLuong = sl,
                        DonGiaNhap = dg,
                        ThanhTien = sl * dg
                    });
                }

                RecalculateTotal();
                UpdateUiState();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Tính lại tổng tiền từ danh sách chi tiết
        private void RecalculateTotal()
        {
            decimal tong = listChiTiet.Sum(x => x.ThanhTien);
            txtTongTien.Text = tong.ToString("N0");
        }

        // Xóa sản phẩm khỏi danh sách chi tiết
        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                var maSanPhamObj = dataGridView.CurrentRow.Cells["SanPhamID"].Value;
                if (maSanPhamObj != null && int.TryParse(maSanPhamObj.ToString(), out int maSanPham))
                {
                    var chiTiet = listChiTiet.FirstOrDefault(x => x.SanPhamID == maSanPham);
                    if (chiTiet != null)
                    {
                        listChiTiet.Remove(chiTiet);
                        RecalculateTotal();
                    }
                }
                UpdateUiState();
            }
        }

        // Lưu phiếu nhập: tạo mới hoặc cập nhật, cập nhật tồn kho và ghi nhật ký
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (listChiTiet.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm ít nhất một sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboNhaCungCap.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var trans = context.Database.BeginTransaction())
            {
                try
                {
                    if (id != 0)
                    {
                        var pn = context.PhieuNhap.Find(id);
                        if (pn != null)
                        {
                            pn.NhaCungCapID = (int)cboNhaCungCap.SelectedValue;
                            pn.NgayNhap = dtpNgayNhap.Value;
                            pn.GhiChu = txtGhiChu.Text;
                            pn.TongTien = listChiTiet.Sum(x => x.ThanhTien);
                            context.PhieuNhap.Update(pn);

                            var oldDetails = context.PhieuNhap_ChiTiet.Where(r => r.PhieuNhapID == id).ToList();
                            foreach (var old in oldDetails)
                            {
                                var spOld = context.SanPham.Find(old.SanPhamID);
                                if (spOld != null)
                                {
                                    spOld.SoLuong -= old.SoLuong;
                                }
                            }

                            context.PhieuNhap_ChiTiet.RemoveRange(oldDetails);
                            context.SaveChanges();

                            foreach (var item in listChiTiet.ToList())
                            {
                                PhieuNhap_ChiTiet ct = new PhieuNhap_ChiTiet
                                {
                                    PhieuNhapID = pn.ID,
                                    SanPhamID = item.SanPhamID,
                                    SoLuong = item.SoLuong,
                                    DonGiaNhap = item.DonGiaNhap,
                                    ThanhTien = item.ThanhTien
                                };
                                context.PhieuNhap_ChiTiet.Add(ct);

                                var sp = context.SanPham.Find(item.SanPhamID);
                                if (sp != null)
                                {
                                    sp.SoLuong += (int)item.SoLuong;
                                }
                            }

                            context.SaveChanges();
                            trans.Commit();

                            NhatKyHeThong.GhiNhatKy("Nhập kho", "Phiếu nhập", $"Cập nhật phiếu nhập ID: {pn.ID} - Tổng tiền: {pn.TongTien:N0}");
                            MessageBox.Show("Cập nhật phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        PhieuNhap pn = new PhieuNhap
                        {
                            NhaCungCapID = (int)cboNhaCungCap.SelectedValue,
                            NhanVienID = NhatKyHeThong.MaNhanVienHienTai,
                            NgayNhap = dtpNgayNhap.Value,
                            GhiChu = txtGhiChu.Text,
                            TongTien = listChiTiet.Sum(x => x.ThanhTien)
                        };
                        context.PhieuNhap.Add(pn);
                        context.SaveChanges();

                        foreach (var item in listChiTiet)
                        {
                            PhieuNhap_ChiTiet ct = new PhieuNhap_ChiTiet
                            {
                                PhieuNhapID = pn.ID,
                                SanPhamID = item.SanPhamID,
                                SoLuong = item.SoLuong,
                                DonGiaNhap = item.DonGiaNhap,
                                ThanhTien = item.ThanhTien
                            };
                            context.PhieuNhap_ChiTiet.Add(ct);

                            var sp = context.SanPham.Find(item.SanPhamID);
                            if (sp != null)
                            {
                                sp.SoLuong += (int)item.SoLuong;
                            }
                        }

                        context.SaveChanges();
                        trans.Commit();

                        NhatKyHeThong.GhiNhatKy("Nhập kho", "Phiếu nhập", $"Lập phiếu nhập ID: {pn.ID} - Tổng tiền: {pn.TongTien:N0}");
                        MessageBox.Show("Lưu phiếu nhập và cập nhật kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Lỗi trong quá trình lưu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Đóng form
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // In phiếu nhập
        private void btnInPhieuNhap_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Vui lòng lưu phiếu nhập trước khi in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (frmInPhieuNhap inPhieu = new frmInPhieuNhap(id))
            {
                inPhieu.ShowDialog();
            }
        }
    }
}