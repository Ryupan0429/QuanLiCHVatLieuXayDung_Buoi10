namespace QuanLiCHVatLieuXayDung.Forms
{
    partial class frmSanPham
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            btnLuuAnh = new Button();
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
            btnLoc = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            cboNhaCungCapTim = new ComboBox();
            label10 = new Label();
            cboLoaiSanPhamTim = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            btnHuyLoc = new Button();
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
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenLoai, TenNhaCungCap, TenSanPham, SoLuong, DonViTinh, DonGia, HinhAnh });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1136, 247);
            dataGridView.TabIndex = 2;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
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
            TenSanPham.HeaderText = "Tên sản phẩm ";
            TenSanPham.MinimumWidth = 6;
            TenSanPham.Name = "TenSanPham";
            TenSanPham.ReadOnly = true;
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            SoLuong.DefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            DonGia.DefaultCellStyle = dataGridViewCellStyle2;
            DonGia.HeaderText = "Đơn giá";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            DonGia.ReadOnly = true;
            // 
            // HinhAnh
            // 
            HinhAnh.DataPropertyName = "HinhAnh";
            HinhAnh.HeaderText = "Hình ảnh";
            HinhAnh.MinimumWidth = 6;
            HinhAnh.Name = "HinhAnh";
            HinhAnh.ReadOnly = true;
            HinhAnh.Resizable = DataGridViewTriState.True;
            HinhAnh.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDVT);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnLuuAnh);
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
            groupBox1.Location = new Point(23, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1128, 208);
            groupBox1.TabIndex = 4;
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
            label7.TabIndex = 24;
            label7.Text = "Đơn vị tính:";
            // 
            // btnLuuAnh
            // 
            btnLuuAnh.Location = new Point(1012, 93);
            btnLuuAnh.Name = "btnLuuAnh";
            btnLuuAnh.Size = new Size(60, 29);
            btnLuuAnh.TabIndex = 23;
            btnLuuAnh.Text = "✓";
            btnLuuAnh.UseVisualStyleBackColor = true;
            // 
            // btnThuNho
            // 
            btnThuNho.Location = new Point(949, 94);
            btnThuNho.Name = "btnThuNho";
            btnThuNho.Size = new Size(57, 29);
            btnThuNho.TabIndex = 22;
            btnThuNho.Text = "-";
            btnThuNho.UseVisualStyleBackColor = true;
            // 
            // btnPhongTo
            // 
            btnPhongTo.Location = new Point(1012, 58);
            btnPhongTo.Name = "btnPhongTo";
            btnPhongTo.Size = new Size(60, 29);
            btnPhongTo.TabIndex = 21;
            btnPhongTo.Text = "+";
            btnPhongTo.UseVisualStyleBackColor = true;
            btnPhongTo.Click += btnPhongTo_Click;
            // 
            // btnXoayTrai
            // 
            btnXoayTrai.Location = new Point(949, 58);
            btnXoayTrai.Name = "btnXoayTrai";
            btnXoayTrai.Size = new Size(57, 29);
            btnXoayTrai.TabIndex = 20;
            btnXoayTrai.Text = "↺";
            btnXoayTrai.UseVisualStyleBackColor = true;
            btnXoayTrai.Click += btnXoayTrai_Click;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = SystemColors.ControlLight;
            btnXuat.Location = new Point(868, 172);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 29);
            btnXuat.TabIndex = 12;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.BackColor = SystemColors.ControlLight;
            btnDoiAnh.Location = new Point(949, 20);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(114, 29);
            btnDoiAnh.TabIndex = 19;
            btnDoiAnh.Text = "Đổi ảnh";
            btnDoiAnh.UseVisualStyleBackColor = false;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // btnNhap
            // 
            btnNhap.BackColor = SystemColors.ControlLight;
            btnNhap.Location = new Point(768, 172);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(94, 29);
            btnNhap.TabIndex = 17;
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
            picHinhAnh.TabIndex = 16;
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
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
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
            label5.TabIndex = 13;
            label5.Text = "Đơn giá (*):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(480, 30);
            label6.Name = "label6";
            label6.Size = new Size(92, 20);
            label6.TabIndex = 12;
            label6.Text = "Số lượng (*):";
            // 
            // cboNhaCungCap
            // 
            cboNhaCungCap.FormattingEnabled = true;
            cboNhaCungCap.Location = new Point(157, 59);
            cboNhaCungCap.Name = "cboNhaCungCap";
            cboNhaCungCap.Size = new Size(274, 28);
            cboNhaCungCap.TabIndex = 11;
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.FormattingEnabled = true;
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
            label4.Size = new Size(116, 20);
            label4.TabIndex = 8;
            label4.Text = "Mô tả sản phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 98);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 7;
            label3.Text = "Tên sản phẩm (*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 62);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 6;
            label2.Text = "Nhà cung cấp (*):";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.ControlLight;
            btnThoat.Location = new Point(658, 172);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = SystemColors.ControlLight;
            btnHuyBo.Location = new Point(558, 172);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(94, 29);
            btnHuyBo.TabIndex = 4;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = SystemColors.ControlLight;
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(456, 172);
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
            btnXoa.Location = new Point(356, 172);
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
            btnSua.Location = new Point(255, 172);
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
            btnThem.Location = new Point(155, 172);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 2;
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
            label1.TabIndex = 0;
            label1.Text = "Loại sản phẩm (*):";
            // 
            // btnLoc
            // 
            btnLoc.BackColor = SystemColors.ControlLight;
            btnLoc.ForeColor = SystemColors.ActiveCaptionText;
            btnLoc.Location = new Point(891, 17);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(94, 29);
            btnLoc.TabIndex = 18;
            btnLoc.Text = "Lọc";
            btnLoc.UseVisualStyleBackColor = false;
            btnLoc.Click += btnLoc_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(12, 278);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1142, 273);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách loại sản phẩm";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnHuyLoc);
            groupBox3.Controls.Add(cboNhaCungCapTim);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(cboLoaiSanPhamTim);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(btnLoc);
            groupBox3.Location = new Point(18, 219);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1133, 56);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Lọc";
            // 
            // cboNhaCungCapTim
            // 
            cboNhaCungCapTim.FormattingEnabled = true;
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
            label10.TabIndex = 26;
            label10.Text = "Nhà cung cấp:";
            // 
            // cboLoaiSanPhamTim
            // 
            cboLoaiSanPhamTim.FormattingEnabled = true;
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
            label9.TabIndex = 19;
            label9.Text = "Loại sản phẩm:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 26);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 17;
            // 
            // btnHuyLoc
            // 
            btnHuyLoc.BackColor = SystemColors.ControlLight;
            btnHuyLoc.ForeColor = SystemColors.ActiveCaptionText;
            btnHuyLoc.Location = new Point(1006, 18);
            btnHuyLoc.Name = "btnHuyLoc";
            btnHuyLoc.Size = new Size(94, 29);
            btnHuyLoc.TabIndex = 28;
            btnHuyLoc.Text = "Hủy lọc";
            btnHuyLoc.UseVisualStyleBackColor = false;
            btnHuyLoc.Click += btnHuyLoc_Click;
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 563);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "frmSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sản phẩm";
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
        private Button btnLuuAnh;
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