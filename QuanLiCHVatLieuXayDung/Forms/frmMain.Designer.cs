namespace QuanLiCHVatLieuXayDung.Forms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mnuThongTinPhanMem = new ToolStripMenuItem();
            mnuTroGiup = new ToolStripMenuItem();
            mnuHDSD = new ToolStripMenuItem();
            mnuThongKeDoanhThu = new ToolStripMenuItem();
            mnuThongKeSanPham = new ToolStripMenuItem();
            mnuBaoCaoThongKe = new ToolStripMenuItem();
            mnuThongKeChiTieu = new ToolStripMenuItem();
            mnuBaoCaoNo = new ToolStripMenuItem();
            mnuHoaDon = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            mnuNhanVien = new ToolStripMenuItem();
            mnuKhachHang = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            mnuSanPham = new ToolStripMenuItem();
            mnuNhaCungCap = new ToolStripMenuItem();
            mnuLoaiSanPham = new ToolStripMenuItem();
            mnuQuanLy = new ToolStripMenuItem();
            mnuPhieuNhap = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            mnuLichSuHD = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnuDoiMatKhau = new ToolStripMenuItem();
            mnuDangXuat = new ToolStripMenuItem();
            mnuDangNhap = new ToolStripMenuItem();
            mnuHeThong = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            lblLienKet = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblTrangThai = new ToolStripStatusLabel();
            statusStrip1 = new StatusStrip();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // mnuThongTinPhanMem
            // 
            mnuThongTinPhanMem.Name = "mnuThongTinPhanMem";
            mnuThongTinPhanMem.Size = new Size(281, 26);
            mnuThongTinPhanMem.Text = "Thông tin phần mềm...";
            mnuThongTinPhanMem.Click += mnuThongTinPhanMem_Click;
            // 
            // mnuTroGiup
            // 
            mnuTroGiup.BackColor = SystemColors.ControlLightLight;
            mnuTroGiup.DropDownItems.AddRange(new ToolStripItem[] { mnuHDSD, mnuThongTinPhanMem });
            mnuTroGiup.Name = "mnuTroGiup";
            mnuTroGiup.Size = new Size(78, 24);
            mnuTroGiup.Text = "Trợ giúp";
            // 
            // mnuHDSD
            // 
            mnuHDSD.Name = "mnuHDSD";
            mnuHDSD.ShortcutKeys = Keys.Control | Keys.F1;
            mnuHDSD.Size = new Size(281, 26);
            mnuHDSD.Text = "Hướng dẫn sử dụng";
            mnuHDSD.Click += mnuHDSD_Click;
            // 
            // mnuThongKeDoanhThu
            // 
            mnuThongKeDoanhThu.Name = "mnuThongKeDoanhThu";
            mnuThongKeDoanhThu.Size = new Size(282, 26);
            mnuThongKeDoanhThu.Text = "Thống kê doanh thu...";
            mnuThongKeDoanhThu.Click += mnuThongKeDoanhThu_Click;
            // 
            // mnuThongKeSanPham
            // 
            mnuThongKeSanPham.Name = "mnuThongKeSanPham";
            mnuThongKeSanPham.Size = new Size(282, 26);
            mnuThongKeSanPham.Text = "Thống kê sản phẩm...";
            mnuThongKeSanPham.Click += mnuThongKeSanPham_Click;
            // 
            // mnuBaoCaoThongKe
            // 
            mnuBaoCaoThongKe.BackColor = SystemColors.ControlLightLight;
            mnuBaoCaoThongKe.DropDownItems.AddRange(new ToolStripItem[] { mnuThongKeSanPham, mnuThongKeDoanhThu, mnuThongKeChiTieu, mnuBaoCaoNo });
            mnuBaoCaoThongKe.Name = "mnuBaoCaoThongKe";
            mnuBaoCaoThongKe.Size = new Size(154, 24);
            mnuBaoCaoThongKe.Text = "Báo cáo – Thống kê";
            // 
            // mnuThongKeChiTieu
            // 
            mnuThongKeChiTieu.Name = "mnuThongKeChiTieu";
            mnuThongKeChiTieu.Size = new Size(282, 26);
            mnuThongKeChiTieu.Text = "Thống kê chi tiêu...";
            mnuThongKeChiTieu.Click += mnuThongKeChiTieu_Click;
            // 
            // mnuBaoCaoNo
            // 
            mnuBaoCaoNo.Name = "mnuBaoCaoNo";
            mnuBaoCaoNo.Size = new Size(282, 26);
            mnuBaoCaoNo.Text = "Báo cáo nợ của khách hàng...";
            mnuBaoCaoNo.Click += mnuBaoCaoNo_Click;
            // 
            // mnuHoaDon
            // 
            mnuHoaDon.Name = "mnuHoaDon";
            mnuHoaDon.Size = new Size(216, 26);
            mnuHoaDon.Text = "Hóa đơn bán hàng";
            mnuHoaDon.Click += mnuHoaDon_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(213, 6);
            // 
            // mnuNhanVien
            // 
            mnuNhanVien.Name = "mnuNhanVien";
            mnuNhanVien.Size = new Size(216, 26);
            mnuNhanVien.Text = "Nhân viên";
            mnuNhanVien.Click += mnuNhanVien_Click;
            // 
            // mnuKhachHang
            // 
            mnuKhachHang.Name = "mnuKhachHang";
            mnuKhachHang.Size = new Size(216, 26);
            mnuKhachHang.Text = "Khách hàng...";
            mnuKhachHang.Click += mnuKhachHang_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(213, 6);
            // 
            // mnuSanPham
            // 
            mnuSanPham.Name = "mnuSanPham";
            mnuSanPham.Size = new Size(216, 26);
            mnuSanPham.Text = "Sản phẩm...";
            mnuSanPham.Click += mnuSanPham_Click;
            // 
            // mnuNhaCungCap
            // 
            mnuNhaCungCap.Name = "mnuNhaCungCap";
            mnuNhaCungCap.Size = new Size(216, 26);
            mnuNhaCungCap.Text = "Nhà cung cấp...";
            mnuNhaCungCap.Click += mnuNhaCungCap_Click;
            // 
            // mnuLoaiSanPham
            // 
            mnuLoaiSanPham.Name = "mnuLoaiSanPham";
            mnuLoaiSanPham.Size = new Size(216, 26);
            mnuLoaiSanPham.Text = "Loại sản phẩm...";
            mnuLoaiSanPham.Click += mnuLoaiSanPham_Click;
            // 
            // mnuQuanLy
            // 
            mnuQuanLy.BackColor = SystemColors.ControlLightLight;
            mnuQuanLy.DropDownItems.AddRange(new ToolStripItem[] { mnuLoaiSanPham, mnuNhaCungCap, mnuSanPham, toolStripSeparator3, mnuKhachHang, mnuNhanVien, toolStripSeparator2, mnuHoaDon, mnuPhieuNhap, toolStripSeparator4, mnuLichSuHD });
            mnuQuanLy.Name = "mnuQuanLy";
            mnuQuanLy.Size = new Size(73, 24);
            mnuQuanLy.Text = "Quản lý";
            // 
            // mnuPhieuNhap
            // 
            mnuPhieuNhap.Name = "mnuPhieuNhap";
            mnuPhieuNhap.Size = new Size(216, 26);
            mnuPhieuNhap.Text = "Phiếu nhập";
            mnuPhieuNhap.Click += mnuPhieuNhap_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(213, 6);
            // 
            // mnuLichSuHD
            // 
            mnuLichSuHD.Name = "mnuLichSuHD";
            mnuLichSuHD.Size = new Size(216, 26);
            mnuLichSuHD.Text = "Lịch sử hoạt động";
            mnuLichSuHD.Click += mnuLichSuHD_Click;
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuThoat.Size = new Size(190, 26);
            mnuThoat.Text = "Thoát";
            mnuThoat.Click += mnuThoat_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(187, 6);
            // 
            // mnuDoiMatKhau
            // 
            mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            mnuDoiMatKhau.Size = new Size(190, 26);
            mnuDoiMatKhau.Text = "Đổi mật khẩu...";
            mnuDoiMatKhau.Click += mnuDoiMatKhau_Click;
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new Size(190, 26);
            mnuDangXuat.Text = "Đăng xuất";
            mnuDangXuat.Click += mnuDangXuat_Click;
            // 
            // mnuDangNhap
            // 
            mnuDangNhap.Name = "mnuDangNhap";
            mnuDangNhap.Size = new Size(190, 26);
            mnuDangNhap.Text = "Đăng nhập...";
            mnuDangNhap.Click += mnuDangNhap_Click;
            // 
            // mnuHeThong
            // 
            mnuHeThong.BackColor = SystemColors.ControlLightLight;
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuDangNhap, mnuDangXuat, mnuDoiMatKhau, toolStripSeparator1, mnuThoat });
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new Size(85, 24);
            mnuHeThong.Text = "Hệ thống";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuQuanLy, mnuBaoCaoThongKe, mnuTroGiup });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(987, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // lblLienKet
            // 
            lblLienKet.IsLink = true;
            lblLienKet.Name = "lblLienKet";
            lblLienKet.Size = new Size(134, 20);
            lblLienKet.Text = "© 2026 TƯỜNG VY";
            lblLienKet.Click += lblLienKet_Click;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(717, 20);
            toolStripStatusLabel1.Spring = true;
            // 
            // lblTrangThai
            // 
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(121, 20);
            lblTrangThai.Text = "Chưa đăng nhập.";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTrangThai, toolStripStatusLabel1, lblLienKet });
            statusStrip1.Location = new Point(0, 335);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(987, 26);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(987, 361);
            Controls.Add(menuStrip1);
            Controls.Add(statusStrip1);
            IsMdiContainer = true;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý cửa hàng vật liệu xây dựng";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            Click += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem mnuThongTinPhanMem;
        private ToolStripMenuItem mnuTroGiup;
        private ToolStripMenuItem mnuHDSD;
        private ToolStripMenuItem mnuThongKeDoanhThu;
        private ToolStripMenuItem mnuThongKeSanPham;
        private ToolStripMenuItem mnuBaoCaoThongKe;
        private ToolStripMenuItem mnuHoaDon;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem mnuNhanVien;
        private ToolStripMenuItem mnuKhachHang;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem mnuSanPham;
        private ToolStripMenuItem mnuNhaCungCap;
        private ToolStripMenuItem mnuLoaiSanPham;
        private ToolStripMenuItem mnuQuanLy;
        private ToolStripMenuItem mnuThoat;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuDoiMatKhau;
        private ToolStripMenuItem mnuDangXuat;
        private ToolStripMenuItem mnuDangNhap;
        private ToolStripMenuItem mnuBaoCaoNo;
        private ToolStripMenuItem mnuHeThong;
        private MenuStrip menuStrip1;
        private ToolStripStatusLabel lblLienKet;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblTrangThai;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem mnuPhieuNhap;
        private ToolStripMenuItem mnuThongKeChiTieu;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem mnuLichSuHD;
    }
}