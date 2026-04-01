namespace QuanLiCHVatLieuXayDung.Forms
{
    partial class frmNhanVien
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            chkQuyenHan = new CheckBox();
            txtMatKhau = new TextBox();
            label5 = new Label();
            txtTenDangNhap = new TextBox();
            label4 = new Label();
            txtDiaChi = new TextBox();
            label3 = new Label();
            txtDienThoai = new TextBox();
            label2 = new Label();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtHoTen = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colHoVaTen = new DataGridViewTextBoxColumn();
            colDienThoai = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            colTenDangNhap = new DataGridViewTextBoxColumn();
            colQuyenHan = new DataGridViewCheckBoxColumn();
            XemHoaDon = new DataGridViewLinkColumn();
            XemPhieuNhap = new DataGridViewLinkColumn();
            btnNhap = new Button();
            btnXuat = new Button();
            groupBox3 = new GroupBox();
            btnTim = new Button();
            label6 = new Label();
            txtTimKiem = new TextBox();
            btnLamMoi = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkQuyenHan);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(900, 214);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // chkQuyenHan
            // 
            chkQuyenHan.AutoSize = true;
            chkQuyenHan.Location = new Point(180, 140);
            chkQuyenHan.Name = "chkQuyenHan";
            chkQuyenHan.Size = new Size(101, 24);
            chkQuyenHan.TabIndex = 16;
            chkQuyenHan.Text = "Là Admin?";
            chkQuyenHan.UseVisualStyleBackColor = true;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(580, 100);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(250, 27);
            txtMatKhau.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(480, 103);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 14;
            label5.Text = "Mật khẩu:";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(180, 100);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(250, 27);
            txtTenDangNhap.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 103);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 12;
            label4.Text = "Tên đăng nhập:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(180, 65);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(650, 27);
            txtDiaChi.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 68);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 10;
            label3.Text = "Địa chỉ:";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(580, 30);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(250, 27);
            txtDienThoai.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(480, 33);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 8;
            label2.Text = "SĐT:";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.ControlLight;
            btnThoat.Location = new Point(736, 168);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = SystemColors.ControlLight;
            btnHuyBo.Location = new Point(636, 168);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(94, 29);
            btnHuyBo.TabIndex = 6;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = SystemColors.ControlLight;
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(536, 168);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.ControlLight;
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(436, 168);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = SystemColors.ControlLight;
            btnSua.Location = new Point(336, 168);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.ControlLight;
            btnThem.Location = new Point(236, 168);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(180, 30);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(250, 27);
            txtHoTen.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 33);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên (*):";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(0, 272);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(900, 360);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { colID, colHoVaTen, colDienThoai, colDiaChi, colTenDangNhap, colQuyenHan, XemHoaDon, XemPhieuNhap });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(894, 334);
            dataGridView.TabIndex = 0;
            dataGridView.CellClick += dataGridView_CellClick;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.ReadOnly = true;
            // 
            // colHoVaTen
            // 
            colHoVaTen.DataPropertyName = "HoVaTen";
            colHoVaTen.HeaderText = "Họ và tên";
            colHoVaTen.MinimumWidth = 6;
            colHoVaTen.Name = "colHoVaTen";
            colHoVaTen.ReadOnly = true;
            // 
            // colDienThoai
            // 
            colDienThoai.DataPropertyName = "DienThoai";
            colDienThoai.HeaderText = "Điện thoại";
            colDienThoai.MinimumWidth = 6;
            colDienThoai.Name = "colDienThoai";
            colDienThoai.ReadOnly = true;
            // 
            // colDiaChi
            // 
            colDiaChi.DataPropertyName = "DiaChi";
            colDiaChi.HeaderText = "Địa chỉ";
            colDiaChi.MinimumWidth = 6;
            colDiaChi.Name = "colDiaChi";
            colDiaChi.ReadOnly = true;
            // 
            // colTenDangNhap
            // 
            colTenDangNhap.DataPropertyName = "TenDangNhap";
            colTenDangNhap.HeaderText = "Tên đăng nhập";
            colTenDangNhap.MinimumWidth = 6;
            colTenDangNhap.Name = "colTenDangNhap";
            colTenDangNhap.ReadOnly = true;
            // 
            // colQuyenHan
            // 
            colQuyenHan.DataPropertyName = "QuyenHan";
            colQuyenHan.HeaderText = "Quyền quản trị";
            colQuyenHan.MinimumWidth = 6;
            colQuyenHan.Name = "colQuyenHan";
            colQuyenHan.ReadOnly = true;
            colQuyenHan.Resizable = DataGridViewTriState.True;
            colQuyenHan.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // XemHoaDon
            // 
            XemHoaDon.DataPropertyName = "XemHoaDon";
            XemHoaDon.HeaderText = "Hóa đơn lập";
            XemHoaDon.MinimumWidth = 6;
            XemHoaDon.Name = "XemHoaDon";
            XemHoaDon.ReadOnly = true;
            // 
            // XemPhieuNhap
            // 
            XemPhieuNhap.DataPropertyName = "XemPhieuNhap";
            XemPhieuNhap.HeaderText = "Phiếu nhập lập";
            XemPhieuNhap.MinimumWidth = 6;
            XemPhieuNhap.Name = "XemPhieuNhap";
            XemPhieuNhap.ReadOnly = true;
            // 
            // btnNhap
            // 
            btnNhap.BackColor = SystemColors.ControlLight;
            btnNhap.Location = new Point(465, 640);
            btnNhap.Margin = new Padding(4, 5, 4, 5);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(113, 28);
            btnNhap.TabIndex = 13;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = SystemColors.ControlLight;
            btnXuat.Location = new Point(344, 640);
            btnXuat.Margin = new Padding(4, 5, 4, 5);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(113, 28);
            btnXuat.TabIndex = 12;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnLamMoi);
            groupBox3.Controls.Add(btnTim);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtTimKiem);
            groupBox3.Location = new Point(12, 220);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(899, 56);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm kiếm";
            // 
            // btnTim
            // 
            btnTim.BackColor = SystemColors.ControlLight;
            btnTim.Location = new Point(633, 21);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(98, 29);
            btnTim.TabIndex = 17;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 26);
            label6.Name = "label6";
            label6.Size = new Size(200, 20);
            label6.TabIndex = 17;
            label6.Text = "Nhập họ tên/ tên đăng nhập:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(236, 22);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(382, 27);
            txtTimKiem.TabIndex = 17;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = SystemColors.ControlLight;
            btnLamMoi.ForeColor = SystemColors.ActiveCaptionText;
            btnLamMoi.Location = new Point(737, 22);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 29;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 682);
            Controls.Add(groupBox3);
            Controls.Add(btnNhap);
            Controls.Add(btnXuat);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmNhanVien";
            Text = "Quản lý Nhân viên";
            Load += frmNhanVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkQuyenHan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView;
        private Button btnNhap;
        private Button btnXuat;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colHoVaTen;
        private DataGridViewTextBoxColumn colDienThoai;
        private DataGridViewTextBoxColumn colDiaChi;
        private DataGridViewTextBoxColumn colTenDangNhap;
        private DataGridViewCheckBoxColumn colQuyenHan;
        private DataGridViewLinkColumn XemHoaDon;
        private DataGridViewLinkColumn XemPhieuNhap;
        private GroupBox groupBox3;
        private Button btnTim;
        private Label label6;
        private TextBox txtTimKiem;
        private Button btnLamMoi;
    }
}