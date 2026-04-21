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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            btnLamMoi = new Button();
            btnTim = new Button();
            label6 = new Label();
            txtTimKiem = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.White;
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
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1142, 214);
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
            chkQuyenHan.TabIndex = 0;
            chkQuyenHan.Text = "Là Admin?";
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
            label5.TabIndex = 16;
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
            label4.TabIndex = 17;
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
            label3.TabIndex = 18;
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
            label2.TabIndex = 19;
            label2.Text = "SĐT:";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(108, 117, 125);
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(736, 168);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 20;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.FromArgb(220, 53, 69);
            btnHuyBo.Cursor = Cursors.Hand;
            btnHuyBo.FlatAppearance.BorderSize = 0;
            btnHuyBo.FlatStyle = FlatStyle.Flat;
            btnHuyBo.ForeColor = Color.White;
            btnHuyBo.Location = new Point(636, 168);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(94, 29);
            btnHuyBo.TabIndex = 21;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(0, 123, 255);
            btnLuu.Cursor = Cursors.Hand;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(536, 168);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 22;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(220, 53, 69);
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(436, 168);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 23;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(0, 123, 255);
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(336, 168);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 24;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(0, 123, 255);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(236, 168);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 25;
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
            label1.TabIndex = 26;
            label1.Text = "Họ và tên (*):";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(12, 295);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1142, 340);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(245, 245, 245);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(40, 40, 40);
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.ColumnHeadersHeight = 29;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { colID, colHoVaTen, colDienThoai, colDiaChi, colTenDangNhap, colQuyenHan, XemHoaDon, XemPhieuNhap });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1136, 314);
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
            colQuyenHan.HeaderText = "Admin";
            colQuyenHan.MinimumWidth = 6;
            colQuyenHan.Name = "colQuyenHan";
            colQuyenHan.ReadOnly = true;
            // 
            // XemHoaDon
            // 
            XemHoaDon.DataPropertyName = "XemHoaDon";
            XemHoaDon.HeaderText = "Hóa đơn";
            XemHoaDon.MinimumWidth = 6;
            XemHoaDon.Name = "XemHoaDon";
            XemHoaDon.ReadOnly = true;
            // 
            // XemPhieuNhap
            // 
            XemPhieuNhap.DataPropertyName = "XemPhieuNhap";
            XemPhieuNhap.HeaderText = "Phiếu nhập";
            XemPhieuNhap.MinimumWidth = 6;
            XemPhieuNhap.Name = "XemPhieuNhap";
            XemPhieuNhap.ReadOnly = true;
            // 
            // btnNhap
            // 
            btnNhap.BackColor = Color.FromArgb(0, 123, 255);
            btnNhap.Cursor = Cursors.Hand;
            btnNhap.FlatAppearance.BorderSize = 0;
            btnNhap.FlatStyle = FlatStyle.Flat;
            btnNhap.ForeColor = Color.White;
            btnNhap.Location = new Point(1017, 653);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(113, 35);
            btnNhap.TabIndex = 18;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.FromArgb(0, 123, 255);
            btnXuat.Cursor = Cursors.Hand;
            btnXuat.FlatAppearance.BorderSize = 0;
            btnXuat.FlatStyle = FlatStyle.Flat;
            btnXuat.ForeColor = Color.White;
            btnXuat.Location = new Point(896, 653);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(113, 35);
            btnXuat.TabIndex = 19;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(btnLamMoi);
            groupBox3.Controls.Add(btnTim);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtTimKiem);
            groupBox3.Location = new Point(12, 230);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1142, 56);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm kiếm";
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(0, 123, 255);
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(737, 22);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 0;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.FromArgb(0, 123, 255);
            btnTim.Cursor = Cursors.Hand;
            btnTim.FlatAppearance.BorderSize = 0;
            btnTim.FlatStyle = FlatStyle.Flat;
            btnTim.ForeColor = Color.White;
            btnTim.Location = new Point(633, 21);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(98, 29);
            btnTim.TabIndex = 1;
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
            label6.TabIndex = 2;
            label6.Text = "Nhập họ tên/ tên đăng nhập:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(236, 22);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(382, 27);
            txtTimKiem.TabIndex = 17;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1166, 700);
            Controls.Add(groupBox3);
            Controls.Add(btnNhap);
            Controls.Add(btnXuat);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 9F);
            Name = "frmNhanVien";
            Text = "Quản lý Nhân viên";
            WindowState = FormWindowState.Maximized;
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