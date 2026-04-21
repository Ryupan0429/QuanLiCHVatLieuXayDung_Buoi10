using QuanLiCHVatLieuXayDung.Data;
using QuanLiCHVatLieuXayDung.Utilities;
using Microsoft.EntityFrameworkCore;
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
    public partial class frmThanhToan : Form
    {
        QLCHVLXDDbContext context = new QLCHVLXDDbContext();
        int hoaDonID;
        BindingList<ThanhToan> thanhToanList = new BindingList<ThanhToan>();

        public frmThanhToan(int maHoaDon = 0)
        {
            InitializeComponent();
            hoaDonID = maHoaDon;
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            LoadCboNhanVien();
            LoadThanhToan();

            string tenKhachHang = "";
            tenKhachHang = context.HoaDon.Where(h => h.ID == hoaDonID)
                .Select(h => h.KhachHang != null ? h.KhachHang.TenKhachHang : "Khách A")
                .FirstOrDefault() ?? "Khách A";

            if (hoaDonID > 0)
            {
                var hd = context.HoaDon
                    .Include(h => h.HoaDon_ChiTiet)
                    .Include(h => h.ThanhToans)
                    .FirstOrDefault(h => h.ID == hoaDonID);
                
                if (hd != null)
                {
                    // lấy thành tiền từ chi tiết hóa đơn (cột thành tiền) để tránh lỗi nếu có hóa đơn không có chi tiết nào
                   
                    decimal tongHoaDon = hd.HoaDon_ChiTiet?.Sum(ct => ct.SoLuong * ct.DonGia) ?? 0;
                    decimal tongDaTra = hd.ThanhToans?.Sum(t => t.SoTienThanhToan) ?? 0;
                    decimal conNo = tongHoaDon - tongDaTra;
                    lblHoaDonID.Text = $"#{hoaDonID}";
                    lblKhachHang.Text = $"{tenKhachHang}";
                    lblTongHoaDon.Text = $"{tongHoaDon:N0}đ";
                    lblTongDaTra.Text = $"{tongDaTra:N0}đ";
                    lblConNo.Text = $"{conNo:N0}đ";

                }
            }
        }

        private void LoadCboNhanVien()
        {
            cboNhanVien.DataSource = context.NhanVien.ToList();
            cboNhanVien.ValueMember = "ID";
            cboNhanVien.DisplayMember = "HoVaTen";
            // Đặt mặc định là nhân viên hiện tại
            if (NhatKyHeThong.MaNhanVienHienTai > 0)
                cboNhanVien.SelectedValue = NhatKyHeThong.MaNhanVienHienTai;
        }

        private void LoadThanhToan()
        {
            var thanhToan = context.ThanhToan
                .Where(t => t.HoaDonID == hoaDonID)
                .Select(t => new
                {
                    t.ID,
                    t.HoaDonID,
                    t.NgayThanhToan,
                    t.SoTienThanhToan,
                    t.PhuongThucThanhToan,
                    TenNhanVien = t.NhanVien.HoVaTen,
                    t.GhiChu
                })
                .ToList();

            dataGridView.DataSource = thanhToan;
            //Gán lại tổng tiền sau khi load thanh toán để cập nhật số nợ còn lại
            var hd = context.HoaDon.Find(hoaDonID);
            if (hd != null)
                {
                decimal tongHoaDon = hd.HoaDon_ChiTiet.Sum(ct => ct.SoLuong * ct.DonGia);
                decimal tongDaTra = hd.ThanhToans.Sum(t => t.SoTienThanhToan);
                decimal conNo = tongHoaDon - tongDaTra;
                lblTongHoaDon.Text = $"{tongHoaDon:N0}đ";
                lblTongDaTra.Text = $"{tongDaTra:N0}đ";
                lblConNo.Text = $"{conNo:N0}đ";
            }
        }

        private void btnThemThanhToan_Click(object sender, EventArgs e)
        {
            if (hoaDonID == 0)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn trước.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(cboNhanVien.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (numSoTien.Value <= 0)
            {
                MessageBox.Show("Số tiền thanh toán phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra số tiền không vượt quá số nợ còn lại
            var hd = context.HoaDon.Find(hoaDonID);
            if (hd != null)
            {
                decimal tongHoaDon = hd.HoaDon_ChiTiet.Sum(ct => ct.SoLuong * ct.DonGia);
                decimal tongDaTra = hd.ThanhToans.Sum(t => t.SoTienThanhToan);
                decimal conNo = tongHoaDon - tongDaTra;

                if (numSoTien.Value > conNo)
                {
                    MessageBox.Show($"Số tiền không thể vượt quá nợ còn lại ({conNo:N0}đ).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            try
            {
                ThanhToan tt = new ThanhToan();
                tt.HoaDonID = hoaDonID;
                tt.NgayThanhToan = dtpNgayThanhToan.Value;
                tt.SoTienThanhToan = numSoTien.Value;
                tt.PhuongThucThanhToan = cboPhuongThuc.SelectedItem.ToString();
                tt.GhiChu = txtGhiChu.Text;
                tt.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue);

                context.ThanhToan.Add(tt);
                context.SaveChanges();

                // Cập nhật trạng thái thanh toán của hóa đơn
                UpdateTrangThaiThanhToan();

                NhatKyHeThong.GhiNhatKy("Thêm", "Thanh toán", $"Ghi nhận TT {numSoTien.Value:N0}đ cho HĐ #{hoaDonID}");

                MessageBox.Show("Ghi nhận thanh toán thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset form
                numSoTien.Value = 0;
                txtGhiChu.Text = "";
                LoadThanhToan();
                frmThanhToan_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTrangThaiThanhToan()
        {
            var hd = context.HoaDon.Find(hoaDonID);
            if (hd != null)
            {
                decimal tongHoaDon = hd.HoaDon_ChiTiet.Sum(ct => ct.SoLuong * ct.DonGia);
                decimal tongDaTra = hd.ThanhToans.Sum(t => t.SoTienThanhToan);

                if (tongDaTra == 0)
                    hd.TrangThaiThanhToan = "Chưa thanh toán";
                else if (tongDaTra >= tongHoaDon)
                    hd.TrangThaiThanhToan = "Đã thanh toán";
                else
                    hd.TrangThaiThanhToan = "Thanh toán một phần";

                context.HoaDon.Update(hd);
                context.SaveChanges();
            }
        }

        private void btnXoaThanhToan_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                int thanhToanID = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);
                decimal soTienXoa = Convert.ToDecimal(dataGridView.CurrentRow.Cells["SoTienThanhToan"].Value);

                DialogResult dr = MessageBox.Show("Xóa ghi nhận thanh toán này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        var tt = context.ThanhToan.Find(thanhToanID);
                        if (tt != null)
                        {
                            context.ThanhToan.Remove(tt);
                            context.SaveChanges();

                            UpdateTrangThaiThanhToan();

                            NhatKyHeThong.GhiNhatKy("Xóa", "Thanh toán", $"Xóa ghi nhận TT {soTienXoa:N0}đ cho HĐ #{hoaDonID}");

                            LoadThanhToan();
                            frmThanhToan_Load(sender, e);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
