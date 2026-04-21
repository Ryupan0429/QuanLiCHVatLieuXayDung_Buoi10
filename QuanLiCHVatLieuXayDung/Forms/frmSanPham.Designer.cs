namespace QuanLiCHVatLieuXayDung.Forms
{
    partial class frmSanPham
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenLoai = new DataGridViewTextBoxColumn();
            TenNhaCungCap = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonViTinh = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            groupBox1 = new GroupBox();
            txtDVT = new TextBox();
            label7 = new Label();
            btnThuNho = new Button();
            btnPhongTo = new Button();
            btnXoayTrai = new Button();
            btnXuat = new Button();
            btnDoiAnh = new Button();
            btnNhap = new Button();
            picHinhAnh = new PictureBox();
            numDonGia = new NumericUpDown();
            numSoLuong = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            cboNhaCungCap = new ComboBox();
            cboLoaiSanPham = new ComboBox();
            txtMoTa = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtTenSanPham = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            btnHuyLoc = new Button();
            cboNhaCungCapTim = new ComboBox();
            label10 = new Label();
            cboLoaiSanPhamTim = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            btnLoc = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 245, 245);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(40, 40, 40);
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeight = 29;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenLoai, TenNhaCungCap, TenSanPham, SoLuong, DonViTinh, DonGia, HinhAnh });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1136, 265);
            dataGridView.TabIndex = 0;
            dataGridView.CellClick += dataGridView_CellClick;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            dataGridView.DataError += dataGridView_DataError;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // TenLoai
            // 
            TenLoai.DataPropertyName = "TenLoai";
            TenLoai.HeaderText = "Loại sản phẩm";
            TenLoai.MinimumWidth = 6;
            TenLoai.Name = "TenLoai";
            TenLoai.ReadOnly = true;
            // 
            // TenNhaCungCap
            // 
            TenNhaCungCap.DataPropertyName = "TenNhaCungCap";
            TenNhaCungCap.HeaderText = "Nhà cung cấp";
            TenNhaCungCap.MinimumWidth = 6;
            TenNhaCungCap.Name = "TenNhaCungCap";
            TenNhaCungCap.ReadOnly = true;
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.HeaderText = "Tên sản phẩm";
            TenSanPham.MinimumWidth = 6;
            TenSanPham.Name = "TenSanPham";
            TenSanPham.ReadOnly = true;
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            SoLuong.DefaultCellStyle = dataGridViewCellStyle2;
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            SoLuong.ReadOnly = true;
            // 
            // DonViTinh
            // 
            DonViTinh.DataPropertyName = "DonViTinh";
            DonViTinh.HeaderText = "DVT";
            DonViTinh.MinimumWidth = 6;
            DonViTinh.Name = "DonViTinh";
            DonViTinh.ReadOnly = true;
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(0, 123, 255);
            dataGridViewCellStyle3.Format = "N0";
            DonGia.DefaultCellStyle = dataGridViewCellStyle3;
            DonGia.HeaderText = "Đơn giá";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            DonGia.ReadOnly = true;
            // 
            // HinhAnh
            // 
            HinhAnh.DataPropertyName = "HinhAnh";
            HinhAnh.HeaderText = "Hình ảnh";
            HinhAnh.ImageLayout = DataGridViewImageCellLayout.Zoom;
            HinhAnh.MinimumWidth = 6;
            HinhAnh.Name = "HinhAnh";
            HinhAnh.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txtDVT);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnThuNho);
            groupBox1.Controls.Add(btnPhongTo);
            groupBox1.Controls.Add(btnXoayTrai);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnDoiAnh);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(picHinhAnh);
            groupBox1.Controls.Add(numDonGia);
            groupBox1.Controls.Add(numSoLuong);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cboNhaCungCap);
            groupBox1.Controls.Add(cboLoaiSanPham);
            groupBox1.Controls.Add(txtMoTa);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtTenSanPham);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1142, 208);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // txtDVT
            // 
            txtDVT.Location = new Point(593, 94);
            txtDVT.Name = "txtDVT";
            txtDVT.Size = new Size(176, 27);
            txtDVT.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(480, 99);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 26;
            label7.Text = "Đơn vị tính:";
            // 
            // btnThuNho
            // 
            btnThuNho.BackColor = Color.FromArgb(108, 117, 125);
            btnThuNho.Cursor = Cursors.Hand;
            btnThuNho.FlatAppearance.BorderSize = 0;
            btnThuNho.FlatStyle = FlatStyle.Flat;
            btnThuNho.ForeColor = Color.White;
            btnThuNho.Location = new Point(979, 73);
            btnThuNho.Name = "btnThuNho";
            btnThuNho.Size = new Size(57, 29);
            btnThuNho.TabIndex = 28;
            btnThuNho.Text = "-";
            btnThuNho.UseVisualStyleBackColor = false;
            btnThuNho.Click += btnThuNho_Click;
            // 
            // btnPhongTo
            // 
            btnPhongTo.BackColor = Color.FromArgb(0, 123, 255);
            btnPhongTo.Cursor = Cursors.Hand;
            btnPhongTo.FlatAppearance.BorderSize = 0;
            btnPhongTo.FlatStyle = FlatStyle.Flat;
            btnPhongTo.ForeColor = Color.White;
            btnPhongTo.Location = new Point(1042, 73);
            btnPhongTo.Name = "btnPhongTo";
            btnPhongTo.Size = new Size(60, 29);
            btnPhongTo.TabIndex = 29;
            btnPhongTo.Text = "+";
            btnPhongTo.UseVisualStyleBackColor = false;
            btnPhongTo.Click += btnPhongTo_Click;
            // 
            // btnXoayTrai
            // 
            btnXoayTrai.BackColor = Color.FromArgb(108, 117, 125);
            btnXoayTrai.Cursor = Cursors.Hand;
            btnXoayTrai.FlatAppearance.BorderSize = 0;
            btnXoayTrai.FlatStyle = FlatStyle.Flat;
            btnXoayTrai.ForeColor = Color.White;
            btnXoayTrai.Location = new Point(1014, 114);
            btnXoayTrai.Name = "btnXoayTrai";
            btnXoayTrai.Size = new Size(57, 29);
            btnXoayTrai.TabIndex = 30;
            btnXoayTrai.Text = "↺";
            btnXoayTrai.UseVisualStyleBackColor = false;
            btnXoayTrai.Click += btnXoayTrai_Click;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.FromArgb(0, 123, 255);
            btnXuat.Cursor = Cursors.Hand;
            btnXuat.FlatAppearance.BorderSize = 0;
            btnXuat.FlatStyle = FlatStyle.Flat;
            btnXuat.ForeColor = Color.White;
            btnXuat.Location = new Point(868, 172);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 29);
            btnXuat.TabIndex = 31;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.BackColor = Color.FromArgb(0, 123, 255);
            btnDoiAnh.Cursor = Cursors.Hand;
            btnDoiAnh.FlatAppearance.BorderSize = 0;
            btnDoiAnh.FlatStyle = FlatStyle.Flat;
            btnDoiAnh.ForeColor = Color.White;
            btnDoiAnh.Location = new Point(958, 20);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(114, 29);
            btnDoiAnh.TabIndex = 32;
            btnDoiAnh.Text = "Đổi ảnh";
            btnDoiAnh.UseVisualStyleBackColor = false;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // btnNhap
            // 
            btnNhap.BackColor = Color.FromArgb(0, 123, 255);
            btnNhap.Cursor = Cursors.Hand;
            btnNhap.FlatAppearance.BorderSize = 0;
            btnNhap.FlatStyle = FlatStyle.Flat;
            btnNhap.ForeColor = Color.White;
            btnNhap.Location = new Point(768, 172);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(94, 29);
            btnNhap.TabIndex = 33;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhap_Click;
            // 
            // picHinhAnh
            // 
            picHinhAnh.BorderStyle = BorderStyle.FixedSingle;
            picHinhAnh.Location = new Point(818, 21);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(125, 135);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 34;
            picHinhAnh.TabStop = false;
            picHinhAnh.Click += picHinhAnh_Click;
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(593, 61);
            numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(176, 27);
            numDonGia.TabIndex = 15;
            numDonGia.ThousandsSeparator = true;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(592, 22);
            numSoLuong.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(176, 27);
            numSoLuong.TabIndex = 14;
            numSoLuong.ThousandsSeparator = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(480, 64);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 35;
            label5.Text = "Đơn giá (*):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(480, 30);
            label6.Name = "label6";
            label6.Size = new Size(92, 20);
            label6.TabIndex = 36;
            label6.Text = "Số lượng (*):";
            // 
            // cboNhaCungCap
            // 
            cboNhaCungCap.Location = new Point(157, 59);
            cboNhaCungCap.Name = "cboNhaCungCap";
            cboNhaCungCap.Size = new Size(274, 28);
            cboNhaCungCap.TabIndex = 11;
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.Location = new Point(157, 21);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(274, 28);
            cboLoaiSanPham.TabIndex = 10;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(157, 129);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(611, 27);
            txtMoTa.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 136);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 37;
            label4.Text = "Mô tả sản phẩm:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 98);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 38;
            label3.Text = "Tên sản phẩm (*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 62);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 39;
            label2.Text = "Nhà cung cấp (*):";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(108, 117, 125);
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(658, 172);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 40;
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
            btnHuyBo.Location = new Point(558, 172);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(94, 29);
            btnHuyBo.TabIndex = 41;
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
            btnLuu.Location = new Point(456, 172);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 42;
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
            btnXoa.Location = new Point(356, 172);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 43;
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
            btnSua.Location = new Point(255, 172);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 44;
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
            btnThem.Location = new Point(155, 172);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 45;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(157, 95);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(274, 27);
            txtTenSanPham.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 29);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 46;
            label1.Text = "Loại sản phẩm (*):";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(12, 297);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1142, 291);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sản phẩm";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(btnHuyLoc);
            groupBox3.Controls.Add(cboNhaCungCapTim);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(cboLoaiSanPhamTim);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(btnLoc);
            groupBox3.Location = new Point(12, 226);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1142, 65);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Lọc";
            // 
            // btnHuyLoc
            // 
            btnHuyLoc.BackColor = Color.FromArgb(108, 117, 125);
            btnHuyLoc.Cursor = Cursors.Hand;
            btnHuyLoc.FlatAppearance.BorderSize = 0;
            btnHuyLoc.FlatStyle = FlatStyle.Flat;
            btnHuyLoc.ForeColor = Color.White;
            btnHuyLoc.Location = new Point(1006, 18);
            btnHuyLoc.Name = "btnHuyLoc";
            btnHuyLoc.Size = new Size(94, 29);
            btnHuyLoc.TabIndex = 0;
            btnHuyLoc.Text = "Hủy lọc";
            btnHuyLoc.UseVisualStyleBackColor = false;
            btnHuyLoc.Click += btnHuyLoc_Click;
            // 
            // cboNhaCungCapTim
            // 
            cboNhaCungCapTim.Location = new Point(593, 18);
            cboNhaCungCapTim.Name = "cboNhaCungCapTim";
            cboNhaCungCapTim.Size = new Size(274, 28);
            cboNhaCungCapTim.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(474, 21);
            label10.Name = "label10";
            label10.Size = new Size(103, 20);
            label10.TabIndex = 28;
            label10.Text = "Nhà cung cấp:";
            // 
            // cboLoaiSanPhamTim
            // 
            cboLoaiSanPhamTim.Location = new Point(165, 18);
            cboLoaiSanPhamTim.Name = "cboLoaiSanPhamTim";
            cboLoaiSanPhamTim.Size = new Size(274, 28);
            cboLoaiSanPhamTim.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(31, 26);
            label9.Name = "label9";
            label9.Size = new Size(108, 20);
            label9.TabIndex = 29;
            label9.Text = "Loại sản phẩm:";
            // 
            // label8
            // 
            label8.Location = new Point(9, 26);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 30;
            // 
            // btnLoc
            // 
            btnLoc.BackColor = Color.FromArgb(0, 123, 255);
            btnLoc.Cursor = Cursors.Hand;
            btnLoc.FlatAppearance.BorderSize = 0;
            btnLoc.FlatStyle = FlatStyle.Flat;
            btnLoc.ForeColor = Color.White;
            btnLoc.Location = new Point(891, 17);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(94, 29);
            btnLoc.TabIndex = 31;
            btnLoc.Text = "Lọc";
            btnLoc.UseVisualStyleBackColor = false;
            btnLoc.Click += btnLoc_Click;
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1166, 600);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 9F);
            Name = "frmSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Sản phẩm";
            WindowState = FormWindowState.Maximized;
            Load += frmSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private GroupBox groupBox1;
        private ComboBox cboLoaiSanPham;
        private TextBox txtMoTa;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtTenSanPham;
        private Label label1;
        private GroupBox groupBox2;
        private PictureBox picHinhAnh;
        private NumericUpDown numDonGia;
        private NumericUpDown numSoLuong;
        private Label label5;
        private Label label6;
        private ComboBox cboNhaCungCap;
        private Button btnDoiAnh;
        private Button btnNhap;
        private Button btnLoc;
        private Button btnXuat;
        private Button btnThuNho;
        private Button btnPhongTo;
        private Button btnXoayTrai;
        private TextBox txtDVT;
        private Label label7;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenLoai;
        private DataGridViewTextBoxColumn TenNhaCungCap;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonViTinh;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewImageColumn HinhAnh;
        private GroupBox groupBox3;
        private ComboBox cboNhaCungCapTim;
        private Label label10;
        private ComboBox cboLoaiSanPhamTim;
        private Label label9;
        private Label label8;
        private Button btnHuyLoc;
    }
}