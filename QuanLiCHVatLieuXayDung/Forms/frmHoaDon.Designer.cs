namespace QuanLiCHVatLieuXayDung.Forms
{
    partial class frmHoaDon
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnLapHoaDon;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridView = new DataGridView();
            btnLapHoaDon = new Button();
            btnInHoaDon = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThanhToan = new Button();
            btnXuat = new Button();
            btnThoat = new Button();
            groupBox1 = new GroupBox();
            btnNhap = new Button();
            groupBox2 = new GroupBox();
            btnHuy = new Button();
            label1 = new Label();
            label2 = new Label();
            dtpTuNgay = new DateTimePicker();
            btnLoc = new Button();
            dtpDenNgay = new DateTimePicker();
            HDID = new DataGridViewTextBoxColumn();
            NhanVien = new DataGridViewTextBoxColumn();
            KhachHang = new DataGridViewTextBoxColumn();
            NgayLap = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            ChiTiet = new DataGridViewLinkColumn();
            TrangThaiThanhToan = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // Theme & Font
            // 
            this.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.BackColor = Color.WhiteSmoke;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { HDID, NhanVien, KhachHang, NgayLap, TongTien, ChiTiet, TrangThaiThanhToan });
            dataGridView.Location = new Point(12, 23);
            dataGridView.Margin = new Padding(4, 5, 4, 5);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(987, 390);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(40, 40, 40);
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            // 
            // btnLapHoaDon
            // 
            btnLapHoaDon.Location = new Point(22, 14);
            btnLapHoaDon.Margin = new Padding(4, 5, 4, 5);
            btnLapHoaDon.Name = "btnLapHoaDon";
            btnLapHoaDon.Size = new Size(160, 38);
            btnLapHoaDon.TabIndex = 1;
            btnLapHoaDon.Text = "Lập hóa đơn mới...";
            btnLapHoaDon.UseVisualStyleBackColor = true;
            btnLapHoaDon.Click += btnLapHoaDon_Click;
            // primary blue style
            btnLapHoaDon.BackColor = Color.FromArgb(0, 123, 255);
            btnLapHoaDon.ForeColor = Color.White;
            btnLapHoaDon.FlatStyle = FlatStyle.Flat;
            btnLapHoaDon.FlatAppearance.BorderSize = 0;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Location = new Point(190, 14);
            btnInHoaDon.Margin = new Padding(4, 5, 4, 5);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(120, 38);
            btnInHoaDon.TabIndex = 2;
            btnInHoaDon.Text = "In hóa đơn...";
            btnInHoaDon.UseVisualStyleBackColor = true;
            btnInHoaDon.Click += btnInHoaDon_Click;
            btnInHoaDon.BackColor = Color.FromArgb(0, 123, 255);
            btnInHoaDon.ForeColor = Color.White;
            btnInHoaDon.FlatStyle = FlatStyle.Flat;
            btnInHoaDon.FlatAppearance.BorderSize = 0;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(318, 14);
            btnSua.Margin = new Padding(4, 5, 4, 5);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 38);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa...";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            btnSua.BackColor = Color.FromArgb(0, 123, 255);
            btnSua.ForeColor = Color.White;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.FlatAppearance.BorderSize = 0;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(426, 14);
            btnXoa.Margin = new Padding(4, 5, 4, 5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 38);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // danger red style
            btnXoa.BackColor = Color.FromArgb(220, 53, 69);
            btnXoa.ForeColor = Color.White;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.FlatAppearance.BorderSize = 0;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(534, 14);
            btnThanhToan.Margin = new Padding(4, 5, 4, 5);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(120, 38);
            btnThanhToan.TabIndex = 5;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            btnThanhToan.BackColor = Color.FromArgb(255, 193, 7); // yellow accent
            btnThanhToan.ForeColor = Color.FromArgb(30, 30, 30);
            btnThanhToan.FlatStyle = FlatStyle.Flat;
            btnThanhToan.FlatAppearance.BorderSize = 0;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(662, 14);
            btnXuat.Margin = new Padding(4, 5, 4, 5);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(113, 38);
            btnXuat.TabIndex = 6;
            btnXuat.Text = "Xuất Excel...";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            btnXuat.BackColor = Color.FromArgb(0, 123, 255);
            btnXuat.ForeColor = Color.White;
            btnXuat.FlatStyle = FlatStyle.Flat;
            btnXuat.FlatAppearance.BorderSize = 0;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(904, 14);
            btnThoat.Margin = new Padding(4, 5, 4, 5);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(108, 38);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            btnThoat.BackColor = Color.FromArgb(108, 117, 125); // gray
            btnThoat.ForeColor = Color.White;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.FlatAppearance.BorderSize = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dataGridView);
            groupBox1.Location = new Point(12, 120);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1010, 440);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách hóa đơn";
            groupBox1.BackColor = Color.White;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(783, 14);
            btnNhap.Margin = new Padding(4, 5, 4, 5);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(113, 38);
            btnNhap.TabIndex = 9;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            btnNhap.BackColor = Color.FromArgb(0, 123, 255);
            btnNhap.ForeColor = Color.White;
            btnNhap.FlatStyle = FlatStyle.Flat;
            btnNhap.FlatAppearance.BorderSize = 0;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(btnHuy);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(dtpTuNgay);
            groupBox2.Controls.Add(btnLoc);
            groupBox2.Controls.Add(dtpDenNgay);
            groupBox2.Location = new Point(22, 60);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1000, 50);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lọc";
            groupBox2.BackColor = Color.White;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(686, 15);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(100, 30);
            btnHuy.TabIndex = 30;
            btnHuy.Text = "Hủy lọc";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            btnHuy.BackColor = Color.FromArgb(108, 117, 125);
            btnHuy.ForeColor = Color.White;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.FlatAppearance.BorderSize = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 23);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 20;
            label1.Text = "Từ ngày:";
            label1.ForeColor = Color.FromArgb(40, 40, 40);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(307, 23);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 22;
            label2.Text = "Đến ngày:";
            label2.ForeColor = Color.FromArgb(40, 40, 40);
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(151, 18);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(150, 27);
            dtpTuNgay.TabIndex = 19;
            // 
            // btnLoc
            // 
            btnLoc.Location = new Point(569, 15);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(100, 30);
            btnLoc.TabIndex = 23;
            btnLoc.Text = "Lọc dữ liệu";
            btnLoc.UseVisualStyleBackColor = true;
            btnLoc.Click += btnLoc_Click;
            btnLoc.BackColor = Color.FromArgb(0, 123, 255);
            btnLoc.ForeColor = Color.White;
            btnLoc.FlatStyle = FlatStyle.Flat;
            btnLoc.FlatAppearance.BorderSize = 0;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(400, 18);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(150, 27);
            dtpDenNgay.TabIndex = 21;
            // 
            // HDID
            // 
            HDID.DataPropertyName = "ID";
            HDID.HeaderText = "ID";
            HDID.MinimumWidth = 6;
            HDID.Name = "HDID";
            HDID.ReadOnly = true;
            // 
            // NhanVien
            // 
            NhanVien.DataPropertyName = "HoVaTenNhanVien";
            NhanVien.HeaderText = "Nhân viên";
            NhanVien.MinimumWidth = 6;
            NhanVien.Name = "NhanVien";
            NhanVien.ReadOnly = true;
            // 
            // KhachHang
            // 
            KhachHang.DataPropertyName = "HoVaTenKhachHang";
            KhachHang.HeaderText = "Khách hàng";
            KhachHang.MinimumWidth = 6;
            KhachHang.Name = "KhachHang";
            KhachHang.ReadOnly = true;
            // 
            // NgayLap
            // 
            NgayLap.DataPropertyName = "NgayLap";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            NgayLap.DefaultCellStyle = dataGridViewCellStyle1;
            NgayLap.HeaderText = "Ngày lập";
            NgayLap.MinimumWidth = 6;
            NgayLap.Name = "NgayLap";
            NgayLap.ReadOnly = true;
            // 
            // TongTien
            // 
            TongTien.DataPropertyName = "TongTienHoaDon";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(0, 123, 255);
            dataGridViewCellStyle2.Format = "N0";
            TongTien.DefaultCellStyle = dataGridViewCellStyle2;
            TongTien.HeaderText = "Tổng tiền";
            TongTien.MinimumWidth = 6;
            TongTien.Name = "TongTien";
            TongTien.ReadOnly = true;
            // 
            // ChiTiet
            // 
            ChiTiet.DataPropertyName = "XemChiTiet";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ChiTiet.DefaultCellStyle = dataGridViewCellStyle3;
            ChiTiet.HeaderText = "Chi tiết";
            ChiTiet.MinimumWidth = 6;
            ChiTiet.Name = "ChiTiet";
            ChiTiet.ReadOnly = true;
            // 
            // TrangThaiThanhToan
            // 
            TrangThaiThanhToan.DataPropertyName = "TrangThaiThanhToan";
            TrangThaiThanhToan.HeaderText = "Trạng Thái";
            TrangThaiThanhToan.MinimumWidth = 6;
            TrangThaiThanhToan.Name = "TrangThaiThanhToan";
            TrangThaiThanhToan.ReadOnly = true;
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 597);
            Controls.Add(groupBox2);
            Controls.Add(btnNhap);
            Controls.Add(groupBox1);
            Controls.Add(btnThoat);
            Controls.Add(btnXuat);
            Controls.Add(btnThanhToan);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnInHoaDon);
            Controls.Add(btnLapHoaDon);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa đơn";
            WindowState = FormWindowState.Maximized;
            Load += frmHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }
        private GroupBox groupBox1;
        private Button btnNhap;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpTuNgay;
        private Button btnLoc;
        private DateTimePicker dtpDenNgay;
        private Button btnHuyLoc;
        private Button btnHuy;
        private DataGridViewTextBoxColumn HDID;
        private DataGridViewTextBoxColumn NhanVien;
        private DataGridViewTextBoxColumn KhachHang;
        private DataGridViewTextBoxColumn NgayLap;
        private DataGridViewTextBoxColumn TongTien;
        private DataGridViewLinkColumn ChiTiet;
        private DataGridViewTextBoxColumn TrangThaiThanhToan;
    }
}