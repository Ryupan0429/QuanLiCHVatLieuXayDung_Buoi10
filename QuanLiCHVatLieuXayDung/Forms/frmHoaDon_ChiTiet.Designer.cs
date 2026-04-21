namespace QuanLiCHVatLieuXayDung.Forms
{
    partial class frmHoaDon_ChiTiet
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.TextBox txtGhiChuHoaDon;
        private System.Windows.Forms.ComboBox cboSanPham;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.NumericUpDown numDonGia;
        private System.Windows.Forms.Button btnXacNhanBan;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuuHoaDon;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SanPhamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;

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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            cboNhanVien = new ComboBox();
            cboKhachHang = new ComboBox();
            txtGhiChuHoaDon = new TextBox();
            cboSanPham = new ComboBox();
            numSoLuong = new NumericUpDown();
            numDonGia = new NumericUpDown();
            btnXacNhanBan = new Button();
            btnXoa = new Button();
            btnLuuHoaDon = new Button();
            btnInHoaDon = new Button();
            btnThoat = new Button();
            dataGridView = new DataGridView();
            SanPhamID = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(147, 20);
            cboNhanVien.Margin = new Padding(4, 5, 4, 5);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(265, 28);
            cboNhanVien.TabIndex = 11;
            // 
            // cboKhachHang
            // 
            cboKhachHang.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(600, 31);
            cboKhachHang.Margin = new Padding(4, 5, 4, 5);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(333, 28);
            cboKhachHang.TabIndex = 10;
            // 
            // txtGhiChuHoaDon
            // 
            txtGhiChuHoaDon.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtGhiChuHoaDon.Location = new Point(147, 66);
            txtGhiChuHoaDon.Margin = new Padding(4, 5, 4, 5);
            txtGhiChuHoaDon.Name = "txtGhiChuHoaDon";
            txtGhiChuHoaDon.Size = new Size(705, 27);
            txtGhiChuHoaDon.TabIndex = 9;
            // 
            // cboSanPham
            // 
            cboSanPham.FormattingEnabled = true;
            cboSanPham.Location = new Point(141, 26);
            cboSanPham.Margin = new Padding(4, 5, 4, 5);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(199, 28);
            cboSanPham.TabIndex = 8;
            cboSanPham.SelectionChangeCommitted += cboSanPham_SelectionChangeCommitted;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(457, 27);
            numSoLuong.Margin = new Padding(4, 5, 4, 5);
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(107, 27);
            numSoLuong.TabIndex = 7;
            numSoLuong.ThousandsSeparator = true;
            numSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(683, 25);
            numDonGia.Margin = new Padding(4, 5, 4, 5);
            numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.ReadOnly = true;
            numDonGia.Size = new Size(160, 27);
            numDonGia.TabIndex = 6;
            numDonGia.ThousandsSeparator = true;
            // 
            // btnXacNhanBan
            // 
            btnXacNhanBan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXacNhanBan.BackColor = Color.FromArgb(0, 123, 255);
            btnXacNhanBan.FlatAppearance.BorderSize = 0;
            btnXacNhanBan.FlatStyle = FlatStyle.Flat;
            btnXacNhanBan.ForeColor = Color.White;
            btnXacNhanBan.Location = new Point(851, 23);
            btnXacNhanBan.Margin = new Padding(4, 5, 4, 5);
            btnXacNhanBan.Name = "btnXacNhanBan";
            btnXacNhanBan.Size = new Size(113, 35);
            btnXacNhanBan.TabIndex = 5;
            btnXacNhanBan.Text = "Xác nhận bán";
            btnXacNhanBan.UseVisualStyleBackColor = false;
            btnXacNhanBan.Click += btnXacNhanBan_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXoa.BackColor = Color.FromArgb(220, 53, 69);
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(972, 23);
            btnXoa.Margin = new Padding(4, 5, 4, 5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(80, 35);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuuHoaDon
            // 
            btnLuuHoaDon.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLuuHoaDon.BackColor = Color.FromArgb(0, 123, 255);
            btnLuuHoaDon.FlatAppearance.BorderSize = 0;
            btnLuuHoaDon.FlatStyle = FlatStyle.Flat;
            btnLuuHoaDon.ForeColor = Color.White;
            btnLuuHoaDon.Location = new Point(372, 603);
            btnLuuHoaDon.Margin = new Padding(4, 5, 4, 5);
            btnLuuHoaDon.Name = "btnLuuHoaDon";
            btnLuuHoaDon.Size = new Size(120, 46);
            btnLuuHoaDon.TabIndex = 2;
            btnLuuHoaDon.Text = "Lưu hóa đơn";
            btnLuuHoaDon.UseVisualStyleBackColor = false;
            btnLuuHoaDon.Click += btnLuuHoaDon_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnInHoaDon.BackColor = Color.FromArgb(0, 123, 255);
            btnInHoaDon.FlatAppearance.BorderSize = 0;
            btnInHoaDon.FlatStyle = FlatStyle.Flat;
            btnInHoaDon.ForeColor = Color.White;
            btnInHoaDon.Location = new Point(505, 603);
            btnInHoaDon.Margin = new Padding(4, 5, 4, 5);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(120, 46);
            btnInHoaDon.TabIndex = 1;
            btnInHoaDon.Text = "In hóa đơn...";
            btnInHoaDon.UseVisualStyleBackColor = false;
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnThoat.BackColor = Color.FromArgb(108, 117, 125);
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(638, 603);
            btnThoat.Margin = new Padding(4, 5, 4, 5);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(107, 46);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 245, 245);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { SanPhamID, TenSanPham, DonGia, SoLuong, ThanhTien });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.Location = new Point(0, 0);
            dataGridView.Margin = new Padding(4, 5, 4, 5);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1129, 366);
            dataGridView.TabIndex = 3;
            // 
            // SanPhamID
            // 
            SanPhamID.DataPropertyName = "SanPhamID";
            SanPhamID.HeaderText = "ID";
            SanPhamID.MinimumWidth = 6;
            SanPhamID.Name = "SanPhamID";
            SanPhamID.ReadOnly = true;
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.HeaderText = "Tên sản phẩm";
            TenSanPham.MinimumWidth = 6;
            TenSanPham.Name = "TenSanPham";
            TenSanPham.ReadOnly = true;
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            DonGia.DefaultCellStyle = dataGridViewCellStyle2;
            DonGia.HeaderText = "Đơn giá";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            DonGia.ReadOnly = true;
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            SoLuong.DefaultCellStyle = dataGridViewCellStyle3;
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            SoLuong.ReadOnly = true;
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(0, 123, 255);
            dataGridViewCellStyle4.Format = "N0";
            ThanhTien.DefaultCellStyle = dataGridViewCellStyle4;
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 6;
            ThanhTien.Name = "ThanhTien";
            ThanhTien.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(40, 40, 40);
            label1.Location = new Point(455, 23);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 12;
            label1.Text = "Khách hàng(*) :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(40, 40, 40);
            label2.Location = new Point(31, 23);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 13;
            label2.Text = "Nhân viên (*):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(40, 40, 40);
            label3.Location = new Point(31, 69);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 14;
            label3.Text = "Ghi chú:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(40, 40, 40);
            label4.Location = new Point(35, 30);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 15;
            label4.Text = "Sản phẩm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(40, 40, 40);
            label5.Location = new Point(364, 30);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 16;
            label5.Text = "Số lượng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.ForeColor = Color.FromArgb(40, 40, 40);
            label6.Location = new Point(616, 158);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 17;
            label6.Text = "Đơn giá";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtGhiChuHoaDon);
            groupBox1.Location = new Point(23, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1125, 111);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hóa đơn";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cboSanPham);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(numSoLuong);
            groupBox2.Controls.Add(numDonGia);
            groupBox2.Controls.Add(btnXacNhanBan);
            groupBox2.Location = new Point(23, 131);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1129, 90);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chi tiết hóa đơn";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dataGridView);
            panel1.Location = new Point(23, 227);
            panel1.Name = "panel1";
            panel1.Size = new Size(1129, 366);
            panel1.TabIndex = 20;
            // 
            // frmHoaDon_ChiTiet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1174, 663);
            Controls.Add(label6);
            Controls.Add(btnThoat);
            Controls.Add(btnInHoaDon);
            Controls.Add(btnLuuHoaDon);
            Controls.Add(cboKhachHang);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmHoaDon_ChiTiet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa đơn chi tiết";
            Load += frmHoaDon_ChiTiet_Load;
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Panel panel1;
    }
}