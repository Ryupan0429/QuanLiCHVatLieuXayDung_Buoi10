using QuanLiCHVatLieuXayDung.Data;
using QuanLiCHVatLieuXayDung.Reports;
using QuanLiCHVatLieuXayDung.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiCHVatLieuXayDung.Forms
{
    public partial class frmHoaDon_ChiTiet : Form
    {
        QLCHVLXDDbContext context = new QLCHVLXDDbContext();
        int id;
        BindingList<DanhSachHoaDon_ChiTiet> hoaDonChiTiet = new BindingList<DanhSachHoaDon_ChiTiet>();
        

        public frmHoaDon_ChiTiet(int maHoaDon = 0)
        {
            InitializeComponent();
            // Lưu id hóa đơn (nếu có) để nạp dữ liệu chỉnh sửa
            id = maHoaDon;
        }

        // Nạp dữ liệu nhân viên vào combobox
        public void LayNhanVienVaoComboBox()
        {
            cboNhanVien.DataSource = context.NhanVien.ToList();
            cboNhanVien.ValueMember = "ID";
            cboNhanVien.DisplayMember = "HoVaTen";
        }

        // Nạp dữ liệu khách hàng vào combobox
        public void LayKhachHangVaoComboBox()
        {
            cboKhachHang.DataSource = context.KhachHang.ToList();
            cboKhachHang.ValueMember = "ID";
            cboKhachHang.DisplayMember = "TenKhachHang";
        }

        // Nạp dữ liệu sản phẩm vào combobox
        public void LaySanPhamVaoComboBox()
        {
            cboSanPham.DataSource = context.SanPham.ToList();
            cboSanPham.ValueMember = "ID";
            cboSanPham.DisplayMember = "TenSanPham";
        }

        // Bật/tắt các nút và đặt giá trị mặc định cho form
        public void BatTatChucNang()
        {
            if (id == 0 && dataGridView.Rows.Count == 0)
            {
                cboKhachHang.Text = "";
                cboNhanVien.Text = "";
                cboSanPham.Text = "";
                numSoLuong.Value = 1;
                numDonGia.Value = 0;
            }
            btnLuuHoaDon.Enabled = dataGridView.Rows.Count > 0;
            btnXoa.Enabled = dataGridView.Rows.Count > 0;
        }

        // Nạp chi tiết hóa đơn khi form load (trường hợp sửa)
        private void frmHoaDon_ChiTiet_Load(object sender, EventArgs e)
        {
            LayNhanVienVaoComboBox();
            LayKhachHangVaoComboBox();
            LaySanPhamVaoComboBox();
            dataGridView.AutoGenerateColumns = false;

            if (id != 0)
            {
                var hoaDon = context.HoaDon.Where(r => r.ID == id).SingleOrDefault();
                if (hoaDon != null)
                {
                    // Thiết lập các giá trị trên form theo hóa đơn
                    cboNhanVien.SelectedValue = hoaDon.NhanVienID;
                    cboKhachHang.SelectedValue = hoaDon.KhachHangID;
                    txtGhiChuHoaDon.Text = hoaDon.GhiChuHoaDon;

                    // Lấy danh sách chi tiết và chuyển thành BindingList để hiển thị
                    var ct = context.HoaDon_ChiTiet.Where(r => r.HoaDonID == id).Select(r => new DanhSachHoaDon_ChiTiet
                    {
                        ID = r.ID,
                        HoaDonID = r.HoaDonID,
                        SanPhamID = r.SanPhamID,
                        TenSanPham = r.SanPham.TenSanPham,
                        SoLuong = r.SoLuong,
                        DonGia = r.DonGia,
                        ThanhTien = r.SoLuong * r.DonGia
                    }).ToList();

                    hoaDonChiTiet = new BindingList<DanhSachHoaDon_ChiTiet>(ct);
                }
            }
            dataGridView.DataSource = hoaDonChiTiet;
            BatTatChucNang();
        }

        // Xác nhận thêm sản phẩm vào chi tiết hóa đơn
        private void btnXacNhanBan_Click(object sender, EventArgs e)
        {
            // Kiểm tra bắt buộc: sản phẩm, số lượng, đơn giá
            if (string.IsNullOrWhiteSpace(cboSanPham.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (numSoLuong.Value <= 0)
            {
                MessageBox.Show("Số lượng bán phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (numDonGia.Value <= 0)
            {
                MessageBox.Show("Đơn giá bán sản phẩm phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int maSanPham = Convert.ToInt32(cboSanPham.SelectedValue);
            var chiTiet = hoaDonChiTiet.FirstOrDefault(x => x.SanPhamID == maSanPham);

            if (chiTiet != null)
            {
                // Nếu sản phẩm đã tồn tại trong danh sách thì cập nhật số lượng và tính lại thành tiền
                chiTiet.SoLuong = Convert.ToInt32(numSoLuong.Value);
                chiTiet.DonGia = numDonGia.Value;
                chiTiet.ThanhTien = numSoLuong.Value * numDonGia.Value;
                dataGridView.Refresh();
            }
            else
            {
                // Thêm dòng chi tiết mới
                DanhSachHoaDon_ChiTiet ct = new DanhSachHoaDon_ChiTiet
                {
                    ID = 0,
                    HoaDonID = id,
                    SanPhamID = maSanPham,
                    TenSanPham = cboSanPham.Text,
                    SoLuong = Convert.ToInt32(numSoLuong.Value),
                    DonGia = numDonGia.Value,
                    ThanhTien = numSoLuong.Value * numDonGia.Value
                };
                hoaDonChiTiet.Add(ct);
            }
            BatTatChucNang();
        }

        // Xoá sản phẩm khỏi chi tiết hóa đơn
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                int maSanPham = Convert.ToInt32(dataGridView.CurrentRow.Cells["SanPhamID"].Value);
                var chiTiet = hoaDonChiTiet.FirstOrDefault(x => x.SanPhamID == maSanPham);
                if (chiTiet != null)
                {
                    hoaDonChiTiet.Remove(chiTiet);
                }
                BatTatChucNang();
            }
        }

        // Lưu hóa đơn (thêm mới hoặc cập nhật) - WITH TRANSACTION
        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            // Kiểm tra bắt buộc: nhân viên, khách hàng
            if (string.IsNullOrWhiteSpace(cboNhanVien.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên lập hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(cboKhachHang.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Khi sửa hóa đơn: Kiểm tra (tồn kho hiện tại + số lượng cũ) >= số lượng mới
            // Khi tạo mới: Kiểm tra tồn kho hiện tại >= số lượng mới
            foreach (var item in hoaDonChiTiet)
            {
                var sp = context.SanPham.Find(item.SanPhamID);
                if (sp == null)
                {
                    MessageBox.Show($"Sản phẩm không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int availableStock = sp.SoLuong;

                // Nếu đang sửa (id != 0), tính thêm số lượng cũ
                if (id != 0)
                {
                    var oldDetail = context.HoaDon_ChiTiet
                        .FirstOrDefault(r => r.HoaDonID == id && r.SanPhamID == item.SanPhamID);
                    
                    if (oldDetail != null)
                    {
                        availableStock += oldDetail.SoLuong;  // Cộng số lượng cũ (sẽ được khôi phục)
                    }
                }

                if (availableStock < item.SoLuong)
                {
                    MessageBox.Show($"Tồn kho {sp.TenSanPham} không đủ! " + 
                       $"Có sẵn: {availableStock}, Cần: {item.SoLuong}", 
                       "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;  // Không lưu
                }
            }

            // Sử dụng Transaction
            using (var trans = context.Database.BeginTransaction())
            {
                try
                {
                    if (id != 0)
                    {
                        // SỬA HÓA ĐƠN CŨ 
                        HoaDon hd = context.HoaDon.Find(id);
                        if (hd != null)
                        {
                            // Cập nhật thông tin hóa đơn
                            hd.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue);
                            hd.KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue);
                            hd.GhiChuHoaDon = txtGhiChuHoaDon.Text;
                            context.HoaDon.Update(hd);

                            // Lấy chi tiết cũ để khôi phục tồn kho trước khi xóa
                            var oldDetails = context.HoaDon_ChiTiet.Where(r => r.HoaDonID == id).ToList();
                            foreach (var old in oldDetails)
                            {
                                var sp = context.SanPham.Find(old.SanPhamID);
                                if (sp != null)
                                {
                                    sp.SoLuong += old.SoLuong;  // Cộng ngược tồn kho
                                    context.SanPham.Update(sp);
                                }
                            }

                            // Xóa chi tiết cũ
                            context.HoaDon_ChiTiet.RemoveRange(oldDetails);

                            // Thêm chi tiết mới
                            foreach (var item in hoaDonChiTiet.ToList())
                            {
                                HoaDon_ChiTiet ct = new HoaDon_ChiTiet();
                                ct.HoaDonID = id;
                                ct.SanPhamID = item.SanPhamID;
                                ct.SoLuong = item.SoLuong;
                                ct.DonGia = item.DonGia;
                                ct.ThanhTien = item.ThanhTien;
                                context.HoaDon_ChiTiet.Add(ct);
                            }

                            // Trừ tồn kho cho các item mới
                            foreach (var item in hoaDonChiTiet.ToList())
                            {
                                var sanPham = context.SanPham.Find(item.SanPhamID);
                                if (sanPham != null)
                                {
                                    sanPham.SoLuong -= item.SoLuong;  // Trừ tồn kho
                                    context.SanPham.Update(sanPham);
                                }
                            }

                            context.SaveChanges();
                        }
                    }
                    else
                    {
                        // TẠO HÓA ĐƠN MỚI
                        HoaDon hd = new HoaDon();
                        hd.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue);
                        hd.KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue);
                        hd.NgayLap = DateTime.Now;
                        hd.GhiChuHoaDon = txtGhiChuHoaDon.Text;
                        context.HoaDon.Add(hd);
                        context.SaveChanges();

                        // Thêm chi tiết hóa đơn và cập nhật tồn kho
                        foreach (var item in hoaDonChiTiet.ToList())
                        {
                            HoaDon_ChiTiet ct = new HoaDon_ChiTiet();
                            ct.HoaDonID = hd.ID;
                            ct.SanPhamID = item.SanPhamID;
                            ct.SoLuong = item.SoLuong;
                            ct.DonGia = item.DonGia;
                            ct.ThanhTien = item.ThanhTien;
                            context.HoaDon_ChiTiet.Add(ct);
                        }
                        // cập nhật số lượng tồn kho
                        foreach (var item in hoaDonChiTiet.ToList())
                        {
                            var sanPham = context.SanPham.Find(item.SanPhamID);
                            if (sanPham != null)
                            {
                                sanPham.SoLuong -= item.SoLuong;
                                context.SanPham.Update(sanPham);
                            }
                        }
                        context.SaveChanges();
                    }

                    trans.Commit();


                    // Ghi nhận lịch sử
                    if (id != 0)
                        NhatKyHeThong.GhiNhatKy("Sửa", "Hóa đơn", $"Sửa hóa đơn ID: {id} - {hoaDonChiTiet.Count} item");
                    else
                        NhatKyHeThong.GhiNhatKy("Thêm", "Hóa đơn", $"Lập hóa đơn mới - {hoaDonChiTiet.Count} item");
                    
                    MessageBox.Show("Đã lưu thành công!", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Lỗi khi lưu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Khi người dùng chọn sản phẩm trong combobox, nạp đơn giá hiện có của sản phẩm
        private void cboSanPham_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedValue != null)
            {
                int maSanPham = Convert.ToInt32(cboSanPham.SelectedValue);
                var sanPham = context.SanPham.Find(maSanPham);
                if (sanPham != null)
                {
                    numDonGia.Value = sanPham.DonGia;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // In hóa đơn
        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            using (frmInHoaDon inHoaDon = new frmInHoaDon(id))
            {
                inHoaDon.ShowDialog();
            }
        }
    }
}
