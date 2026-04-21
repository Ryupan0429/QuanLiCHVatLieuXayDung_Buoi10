using QuanLiCHVatLieuXayDung.Data;
using QuanLiCHVatLieuXayDung.Reports;
using QuanLiCHVatLieuXayDung.Utilities;
using QuanLiCHVatLieuXayDung.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;

namespace QuanLiCHVatLieuXayDung.Forms
{
    // Form chính (Main): quản lý điều hướng toàn ứng dụng, quyền truy cập, đăng nhập/đăng xuất
    // - Mở các form con (MDI)
    // - Điều chỉnh quyền hiển thị menu theo vai trò
    // - Ghi nhật ký đăng nhập/đăng xuất
    public partial class frmMain : Form
    {
        QLCHVLXDDbContext context = new QLCHVLXDDbContext();
        frmLoaiSanPham loaiSanPham = null;
        frmNhaCungCap nhaCungCap = null;
        frmSanPham sanPham = null;
        frmKhachHang khachHang = null;
        frmNhanVien nhanVien = null;
        frmHoaDon hoaDon = null;
        frmPhieuNhap phieuNhap = null;
        frmLichSuHoatDong lichSuHoatDong = null;
        frmDangNhap dangNhap = null;
        frmThongKeSanPham thongKeSP = null;
        frmThongKeDoanhThu thongKeDT = null;
        frmThongKeChiTieu thongKeCT = null;
        frmDoiMatKhau doiMatKhau = null;
        frmBaoCaoNoCuaKhachHang baoCaoNo = null;
        string hoVaTenNhanVien = "";

        public frmMain()
        {
            InitializeComponent();
        }

        // Hiển thị dialog đăng nhập và xử lý quyền theo người dùng
        private void DangNhap()
        {
        LamLai:
            if (dangNhap == null || dangNhap.IsDisposed)
                dangNhap = new frmDangNhap();

            if (dangNhap.ShowDialog() == DialogResult.OK)
            {
                string tenDangNhap = dangNhap.txtTenDangNhap.Text;
                string matKhau = dangNhap.txtMatKhau.Text;

                // Validate input
                if (tenDangNhap.Trim() == "")
                {
                    MessageBox.Show("Tên đăng nhập không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtTenDangNhap.Focus();
                    goto LamLai;
                }
                else if (matKhau.Trim() == "")
                {
                    MessageBox.Show("Mật khẩu không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtMatKhau.Focus();
                    goto LamLai;
                }
                else
                {
                    // Tìm user trong DB
                    var nhanVien = context.NhanVien.Where(r => r.TenDangNhap == tenDangNhap).SingleOrDefault();

                    if (nhanVien == null)
                    {
                        MessageBox.Show("Tên đăng nhập không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dangNhap.txtTenDangNhap.Focus();
                        goto LamLai;
                    }
                    else
                    {
                        // Kiểm tra mật khẩu
                        if (BC.Verify(matKhau, nhanVien.MatKhau))
                        {
                            // Lưu ID nhân viên hiện tại để ghi nhật ký
                            NhatKyHeThong.MaNhanVienHienTai = nhanVien.ID;
                            hoVaTenNhanVien = nhanVien.HoVaTen;

                            // Phân quyền giao diện theo QuyenHan
                            if (nhanVien.QuyenHan == true)
                            {
                                NhatKyHeThong.GhiNhatKy("Đăng nhập", "Hệ thống", $"Quản lý {nhanVien.HoVaTen} đăng nhập thành công.");
                                QuyenQuanLy();
                            }
                            else if (nhanVien.QuyenHan == false)
                            {
                                NhatKyHeThong.GhiNhatKy("Đăng nhập", "Hệ thống", $"Nhân viên {nhanVien.HoVaTen} đăng nhập thành công.");
                                QuyenNhanVien();
                            }
                            else
                                ChuaDangNhap();
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dangNhap.txtMatKhau.Focus();
                            goto LamLai;
                        }
                    }
                }
            }
        }

        // Thiết lập giao diện khi chưa đăng nhập: chỉ bật menu Đăng nhập
        public void ChuaDangNhap()
        {
            // Sáng đăng nhập 
            mnuDangNhap.Enabled = true;

            // Mờ tất cả 
            mnuDangXuat.Enabled = false;
            mnuDoiMatKhau.Enabled = false;

            mnuLoaiSanPham.Enabled = false;
            mnuNhaCungCap.Enabled = false;
            mnuSanPham.Enabled = false;
            mnuKhachHang.Enabled = false;
            mnuNhanVien.Enabled = false;
            mnuHoaDon.Enabled = false;
            mnuPhieuNhap.Enabled = false;
            mnuLichSuHD.Enabled = false;

            mnuThongKeSanPham.Enabled = false;
            mnuThongKeDoanhThu.Enabled = false;
            mnuThongKeChiTieu.Enabled = false;


            lblTrangThai.Text = "Chưa đăng nhập.";
        }

        // Thiết lập menu cho vai trò quản lý (quyền cao nhất)
        public void QuyenQuanLy()
        {
            // Mờ đăng nhập 
            mnuDangNhap.Enabled = false;

            // Sáng đăng xuất và các chức năng quản lý được phép 
            mnuDangXuat.Enabled = true;
            mnuDoiMatKhau.Enabled = true;

            mnuLoaiSanPham.Enabled = true;
            mnuNhaCungCap.Enabled = true;
            mnuSanPham.Enabled = true;
            mnuKhachHang.Enabled = true;
            mnuNhanVien.Enabled = true;
            mnuHoaDon.Enabled = true;
            mnuPhieuNhap.Enabled = true;
            mnuLichSuHD.Enabled = true;


            mnuThongKeSanPham.Enabled = true;
            mnuThongKeDoanhThu.Enabled = true;
            mnuThongKeChiTieu.Enabled = true;
            mnuBaoCaoNo.Enabled = true;

            // Hiển thị thông tin trên thanh trạng thái 
            lblTrangThai.Text = "Quản lý: " + hoVaTenNhanVien;
        }

        // Thiết lập menu cho vai trò nhân viên (ít quyền hơn)
        public void QuyenNhanVien()
        {
            // Mờ đăng nhập 
            mnuDangNhap.Enabled = false;

            // Mờ các chức năng nhân viên không được phép 
            mnuLoaiSanPham.Enabled = false;
            mnuNhaCungCap.Enabled = false;
            mnuSanPham.Enabled = false;
            mnuNhanVien.Enabled = false;
            mnuLichSuHD.Enabled = false;

            // Sáng đăng xuất và các chức năng nhân viên được phép 
            mnuDangXuat.Enabled = true;
            mnuDoiMatKhau.Enabled = true;

            mnuKhachHang.Enabled = true;
            mnuHoaDon.Enabled = true;
            mnuPhieuNhap.Enabled = true;

            mnuThongKeSanPham.Enabled = true;
            mnuThongKeDoanhThu.Enabled = true;
            mnuThongKeChiTieu.Enabled = true;
            mnuBaoCaoNo.Enabled = true;
            lblTrangThai.Text = "Nhân viên: " + hoVaTenNhanVien;
        }


        // Các handler mở form con: nếu chưa khởi tạo hoặc đã disposed thì tạo mới và hiển thị (MDI child)
        private void mnuLoaiSanPham_Click(object sender, EventArgs e)
        {
            if (loaiSanPham == null || loaiSanPham.IsDisposed)
            {
                loaiSanPham = new frmLoaiSanPham();
                loaiSanPham.MdiParent = this;
                loaiSanPham.Show();
            }
            else
                loaiSanPham.Activate();
        }

        private void mnuNhaCungCap_Click(object sender, EventArgs e)
        {
            if (nhaCungCap == null || nhaCungCap.IsDisposed)
            {
                nhaCungCap = new frmNhaCungCap();
                nhaCungCap.MdiParent = this;
                nhaCungCap.Show();
            }
            else
                nhaCungCap.Activate();
        }

        private void mnuSanPham_Click(object sender, EventArgs e)
        {
            if (sanPham == null || sanPham.IsDisposed)
            {
                sanPham = new frmSanPham();
                sanPham.MdiParent = this;
                sanPham.Show();
            }
            else
                sanPham.Activate();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            if (khachHang == null || khachHang.IsDisposed)
            {
                khachHang = new frmKhachHang();
                khachHang.MdiParent = this;
                khachHang.Show();
            }
            else
                khachHang.Activate();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            if (nhanVien == null || nhanVien.IsDisposed)
            {
                nhanVien = new frmNhanVien();
                nhanVien.MdiParent = this;
                nhanVien.Show();
            }
            else
                nhanVien.Activate();
        }

        private void mnuHoaDon_Click(object sender, EventArgs e)
        {
            if (hoaDon == null || hoaDon.IsDisposed)
            {
                hoaDon = new frmHoaDon();
                hoaDon.MdiParent = this;
                hoaDon.Show();
            }
            else
                hoaDon.Activate();
        }

        // Mở link liên kết (ví dụ trang web)
        private void lblLienKet_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "explorer.exe";
            info.Arguments = "https://fit.agu.edu.vn";
            Process.Start(info);
        }

        // Khi form chính load: trạng thái chưa đăng nhập rồi gọi dialog đăng nhập
        private void frmMain_Load(object sender, EventArgs e)
        {
            ChuaDangNhap();
            DangNhap();

        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        // Xử lý đăng xuất: đóng tất cả form con, ghi nhật ký nếu có người dùng
        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            // đăng xuất và ghi vào nhật ký hệ thống nếu có người dùng đang đăng nhập
            if (NhatKyHeThong.MaNhanVienHienTai != 0)
            {
                NhatKyHeThong.GhiNhatKy("Đăng xuất", "Hệ thống", $"{hoVaTenNhanVien} đăng xuất.");
                NhatKyHeThong.MaNhanVienHienTai = 0;
            }

            // Đóng tất cả các form con
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }
            ChuaDangNhap();
        }

        // Thoát ứng dụng: xác nhận và ghi nhật ký
        private void mnuThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // log exit if user is set
                if (NhatKyHeThong.MaNhanVienHienTai != 0)
                {
                    NhatKyHeThong.GhiNhatKy("Thoát", "Hệ thống", $"{hoVaTenNhanVien} thoát ứng dụng.");
                    NhatKyHeThong.MaNhanVienHienTai = 0;
                }

                Application.Exit();
            }
        }

        // Mở form thống kê sản phẩm
        private void mnuThongKeSanPham_Click(object sender, EventArgs e)
        {
            //mở form thống kê sản phẩm
            if (thongKeSP == null || thongKeSP.IsDisposed)
            {
                thongKeSP = new frmThongKeSanPham();
                thongKeSP.MdiParent = this;
                thongKeSP.Show();
            }
            else
                thongKeSP.Activate();
        }

        private void mnuPhieuNhap_Click(object sender, EventArgs e)
        {

            if (phieuNhap == null || phieuNhap.IsDisposed)
            {
                phieuNhap = new frmPhieuNhap();
                phieuNhap.MdiParent = this;
                phieuNhap.Show();
            }
            else
                phieuNhap.Activate();

        }

        private void mnuLichSuHD_Click(object sender, EventArgs e)
        {

            if (lichSuHoatDong == null || lichSuHoatDong.IsDisposed)
            {
                lichSuHoatDong = new frmLichSuHoatDong();
                lichSuHoatDong.MdiParent = this;
                lichSuHoatDong.Show();
            }
            else
                lichSuHoatDong.Activate();
        }

        private void mnuThongKeDoanhThu_Click(object sender, EventArgs e)
        {

            if (thongKeDT == null || thongKeDT.IsDisposed)
            {
                thongKeDT = new frmThongKeDoanhThu();
                thongKeDT.MdiParent = this;
                thongKeDT.Show();
            }
            else
                thongKeDT.Activate();
        }

        private void mnuThongKeChiTieu_Click(object sender, EventArgs e)
        {

            if (thongKeCT == null || thongKeCT.IsDisposed)
            {
                thongKeCT = new frmThongKeChiTieu();
                thongKeCT.MdiParent = this;
                thongKeCT.Show();
            }
            else
                thongKeCT.Activate();
        }

        // Mở form đổi mật khẩu (truyền tên đăng nhập từ dialog đăng nhập)
        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (doiMatKhau == null || doiMatKhau.IsDisposed)
            {
                doiMatKhau = new frmDoiMatKhau(dangNhap.txtTenDangNhap.Text);
                doiMatKhau.MdiParent = this;
                doiMatKhau.Show();
            }
            else
                doiMatKhau.Activate();

        }

        private void mnuBaoCaoNo_Click(object sender, EventArgs e)
        {
            if (baoCaoNo == null || baoCaoNo.IsDisposed)
            {
                baoCaoNo = new frmBaoCaoNoCuaKhachHang();
                baoCaoNo.MdiParent = this;
                baoCaoNo.Show();
            }
            else
                baoCaoNo.Activate();
        }

        private void mnuHDSD_Click(object sender, EventArgs e)
        {
            try
            {
                string htmlPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\HuongDanSuDung.html");
                htmlPath = Path.GetFullPath(htmlPath);

                if (File.Exists(htmlPath))
                {
                    Process.Start(new ProcessStartInfo(htmlPath) { UseShellExecute = true });
                }
                else
                {
                    MessageBox.Show("Không tìm thấy file hướng dẫn sử dụng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mở hướng dẫn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuThongTinPhanMem_Click(object sender, EventArgs e)
        {
            try
            {
                string htmlPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\ThongTinPhanMem.html");
                htmlPath = Path.GetFullPath(htmlPath);

                if (File.Exists(htmlPath))
                {
                    Process.Start(new ProcessStartInfo(htmlPath) { UseShellExecute = true });
                }
                else
                {
                    MessageBox.Show("Không tìm thấy file thông tin phần mềm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mở hướng dẫn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
