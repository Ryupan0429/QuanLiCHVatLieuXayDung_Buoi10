using QuanLiCHVatLieuXayDung.Data;
using QuanLiCHVatLieuXayDung.Reports;
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
            id = maHoaDon;
        }

        public void LayNhanVienVaoComboBox()
        {
            cboNhanVien.DataSource = context.NhanVien.ToList();
            cboNhanVien.ValueMember = "ID";
            cboNhanVien.DisplayMember = "HoVaTen";
        }

        public void LayKhachHangVaoComboBox()
        {
            cboKhachHang.DataSource = context.KhachHang.ToList();
            cboKhachHang.ValueMember = "ID";
            cboKhachHang.DisplayMember = "HoVaTen";
        }

        public void LaySanPhamVaoComboBox()
        {
            cboSanPham.DataSource = context.SanPham.ToList();
            cboSanPham.ValueMember = "ID";
            cboSanPham.DisplayMember = "TenSanPham";
        }

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
                    cboNhanVien.SelectedValue = hoaDon.NhanVienID;
                    cboKhachHang.SelectedValue = hoaDon.KhachHangID;
                    txtGhiChuHoaDon.Text = hoaDon.GhiChuHoaDon;

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

        private void btnXacNhanBan_Click(object sender, EventArgs e)
        {
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
                chiTiet.SoLuong = Convert.ToInt32(numSoLuong.Value);
                chiTiet.DonGia = numDonGia.Value;
                chiTiet.ThanhTien = numSoLuong.Value * numDonGia.Value;
                dataGridView.Refresh();
            }
            else
            {
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

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
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

            if (id != 0)
            {
                HoaDon hd = context.HoaDon.Find(id);
                if (hd != null)
                {
                    hd.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue);
                    hd.KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue);
                    hd.GhiChuHoaDon = txtGhiChuHoaDon.Text;
                    context.HoaDon.Update(hd);

                    var old = context.HoaDon_ChiTiet.Where(r => r.HoaDonID == id).ToList();
                    context.HoaDon_ChiTiet.RemoveRange(old);

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
                    context.SaveChanges();
                }
            }
            else
            {
                HoaDon hd = new HoaDon();
                hd.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue);
                hd.KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue);
                hd.NgayLap = DateTime.Now;
                hd.GhiChuHoaDon = txtGhiChuHoaDon.Text;
                context.HoaDon.Add(hd);
                context.SaveChanges();

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
                context.SaveChanges();
            }
            MessageBox.Show("Đã lưu thành công!", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

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

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            using (frmInHoaDon inHoaDon = new frmInHoaDon(id))
            {
                inHoaDon.ShowDialog();
            }
        }
    }
}
