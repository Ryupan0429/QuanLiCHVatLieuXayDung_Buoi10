namespace QuanLiCHVatLieuXayDung.Forms
{
    partial class frmThanhToan
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

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            lblConNo = new Label();
            lblTongDaTra = new Label();
            lblTongHoaDon = new Label();
            lblKhachHang = new Label();
            lblHoaDonID = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnThoat = new Button();
            txtGhiChu = new TextBox();
            btnXoaThanhToan = new Button();
            label11 = new Label();
            btnThemThanhToan = new Button();
            cboPhuongThuc = new ComboBox();
            dtpNgayThanhToan = new DateTimePicker();
            cboNhanVien = new ComboBox();
            numSoTien = new NumericUpDown();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NgayThanhToan = new DataGridViewTextBoxColumn();
            SoTienThanhToan = new DataGridViewTextBoxColumn();
            PhuongThucThanhToan = new DataGridViewTextBoxColumn();
            TenNhanVien = new DataGridViewTextBoxColumn();
            GhiChu = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoTien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblConNo);
            groupBox1.Controls.Add(lblTongDaTra);
            groupBox1.Controls.Add(lblTongHoaDon);
            groupBox1.Controls.Add(lblKhachHang);
            groupBox1.Controls.Add(lblHoaDonID);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(16, 18);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1035, 151);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Hóa Đơn";
            // 
            // lblConNo
            // 
            lblConNo.AutoSize = true;
            lblConNo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConNo.ForeColor = Color.Red;
            lblConNo.Location = new Point(855, 118);
            lblConNo.Margin = new Padding(4, 0, 4, 0);
            lblConNo.Name = "lblConNo";
            lblConNo.Size = new Size(29, 20);
            lblConNo.TabIndex = 9;
            lblConNo.Text = "0đ";
            // 
            // lblTongDaTra
            // 
            lblTongDaTra.AutoSize = true;
            lblTongDaTra.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongDaTra.Location = new Point(855, 72);
            lblTongDaTra.Margin = new Padding(4, 0, 4, 0);
            lblTongDaTra.Name = "lblTongDaTra";
            lblTongDaTra.Size = new Size(29, 20);
            lblTongDaTra.TabIndex = 8;
            lblTongDaTra.Text = "0đ";
            // 
            // lblTongHoaDon
            // 
            lblTongHoaDon.AutoSize = true;
            lblTongHoaDon.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongHoaDon.Location = new Point(855, 25);
            lblTongHoaDon.Margin = new Padding(4, 0, 4, 0);
            lblTongHoaDon.Name = "lblTongHoaDon";
            lblTongHoaDon.Size = new Size(29, 20);
            lblTongHoaDon.TabIndex = 7;
            lblTongHoaDon.Text = "0đ";
            // 
            // lblKhachHang
            // 
            lblKhachHang.AutoSize = true;
            lblKhachHang.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKhachHang.Location = new Point(377, 89);
            lblKhachHang.Margin = new Padding(4, 0, 4, 0);
            lblKhachHang.Name = "lblKhachHang";
            lblKhachHang.Size = new Size(30, 20);
            lblKhachHang.TabIndex = 6;
            lblKhachHang.Text = "---";
            // 
            // lblHoaDonID
            // 
            lblHoaDonID.AutoSize = true;
            lblHoaDonID.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoaDonID.Location = new Point(377, 42);
            lblHoaDonID.Margin = new Padding(4, 0, 4, 0);
            lblHoaDonID.Name = "lblHoaDonID";
            lblHoaDonID.Size = new Size(30, 20);
            lblHoaDonID.TabIndex = 5;
            lblHoaDonID.Text = "---";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(728, 118);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 4;
            label5.Text = "Còn nợ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(728, 72);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 3;
            label4.Text = "Đã thanh toán:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(728, 25);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 2;
            label3.Text = "Tổng hóa đơn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 89);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 1;
            label2.Text = "Khách hàng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(250, 42);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Hóa đơn:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnThoat);
            groupBox2.Controls.Add(txtGhiChu);
            groupBox2.Controls.Add(btnXoaThanhToan);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(btnThemThanhToan);
            groupBox2.Controls.Add(cboPhuongThuc);
            groupBox2.Controls.Add(dtpNgayThanhToan);
            groupBox2.Controls.Add(cboNhanVien);
            groupBox2.Controls.Add(numSoTien);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(16, 179);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(1035, 176);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ghi Nhận Thanh Toán";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(108, 117, 125);
            btnThoat.ForeColor = SystemColors.ControlLightLight;
            btnThoat.Location = new Point(842, 125);
            btnThoat.Margin = new Padding(4, 5, 4, 5);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(133, 43);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(168, 112);
            txtGhiChu.Margin = new Padding(4, 5, 4, 5);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(607, 56);
            txtGhiChu.TabIndex = 7;
            // 
            // btnXoaThanhToan
            // 
            btnXoaThanhToan.BackColor = Color.FromArgb(220, 53, 69);
            btnXoaThanhToan.ForeColor = SystemColors.ControlLightLight;
            btnXoaThanhToan.Location = new Point(842, 77);
            btnXoaThanhToan.Margin = new Padding(4, 5, 4, 5);
            btnXoaThanhToan.Name = "btnXoaThanhToan";
            btnXoaThanhToan.Size = new Size(133, 42);
            btnXoaThanhToan.TabIndex = 4;
            btnXoaThanhToan.Text = "Xóa";
            btnXoaThanhToan.UseVisualStyleBackColor = false;
            btnXoaThanhToan.Click += btnXoaThanhToan_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 115);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(61, 20);
            label11.TabIndex = 6;
            label11.Text = "Ghi chú:";
            // 
            // btnThemThanhToan
            // 
            btnThemThanhToan.BackColor = Color.FromArgb(0, 123, 255);
            btnThemThanhToan.ForeColor = SystemColors.ControlLightLight;
            btnThemThanhToan.Location = new Point(842, 30);
            btnThemThanhToan.Margin = new Padding(4, 5, 4, 5);
            btnThemThanhToan.Name = "btnThemThanhToan";
            btnThemThanhToan.Size = new Size(133, 41);
            btnThemThanhToan.TabIndex = 3;
            btnThemThanhToan.Text = "Ghi Nhận";
            btnThemThanhToan.UseVisualStyleBackColor = false;
            btnThemThanhToan.Click += btnThemThanhToan_Click;
            // 
            // cboPhuongThuc
            // 
            cboPhuongThuc.FormattingEnabled = true;
            cboPhuongThuc.Items.AddRange(new object[] { "Tiền mặt", "Chuyển khoản", "Séc" });
            cboPhuongThuc.Location = new Point(590, 74);
            cboPhuongThuc.Margin = new Padding(4, 5, 4, 5);
            cboPhuongThuc.Name = "cboPhuongThuc";
            cboPhuongThuc.Size = new Size(185, 28);
            cboPhuongThuc.TabIndex = 5;
            cboPhuongThuc.Text = "Tiền mặt";
            // 
            // dtpNgayThanhToan
            // 
            dtpNgayThanhToan.CustomFormat = "dd/MM/yyyy";
            dtpNgayThanhToan.Format = DateTimePickerFormat.Custom;
            dtpNgayThanhToan.Location = new Point(590, 30);
            dtpNgayThanhToan.Margin = new Padding(4, 5, 4, 5);
            dtpNgayThanhToan.Name = "dtpNgayThanhToan";
            dtpNgayThanhToan.Size = new Size(185, 27);
            dtpNgayThanhToan.TabIndex = 4;
            dtpNgayThanhToan.Value = new DateTime(2026, 4, 21, 1, 22, 20, 263);
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(168, 74);
            cboNhanVien.Margin = new Padding(4, 5, 4, 5);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(199, 28);
            cboNhanVien.TabIndex = 3;
            // 
            // numSoTien
            // 
            numSoTien.Location = new Point(168, 35);
            numSoTien.Margin = new Padding(4, 5, 4, 5);
            numSoTien.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            numSoTien.Name = "numSoTien";
            numSoTien.Size = new Size(200, 27);
            numSoTien.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(401, 77);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(171, 20);
            label10.TabIndex = 2;
            label10.Text = "Phương thức thanh toán:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(401, 35);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(122, 20);
            label9.TabIndex = 1;
            label9.Text = "Ngày thanh toán:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 77);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(139, 20);
            label8.TabIndex = 1;
            label8.Text = "Nhân viên ghi nhận:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 38);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 0;
            label7.Text = "Số tiền:";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, NgayThanhToan, SoTienThanhToan, PhuongThucThanhToan, TenNhanVien, GhiChu });
            dataGridView.Location = new Point(16, 376);
            dataGridView.Margin = new Padding(4, 5, 4, 5);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1035, 308);
            dataGridView.TabIndex = 2;
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
            // NgayThanhToan
            // 
            NgayThanhToan.DataPropertyName = "NgayThanhToan";
            NgayThanhToan.HeaderText = "Ngày Thanh Toán";
            NgayThanhToan.MinimumWidth = 6;
            NgayThanhToan.Name = "NgayThanhToan";
            NgayThanhToan.ReadOnly = true;
            // 
            // SoTienThanhToan
            // 
            SoTienThanhToan.DataPropertyName = "SoTienThanhToan";
            SoTienThanhToan.HeaderText = "Số Tiền";
            SoTienThanhToan.MinimumWidth = 6;
            SoTienThanhToan.Name = "SoTienThanhToan";
            SoTienThanhToan.ReadOnly = true;
            // 
            // PhuongThucThanhToan
            // 
            PhuongThucThanhToan.DataPropertyName = "PhuongThucThanhToan";
            PhuongThucThanhToan.HeaderText = "Phương Thức";
            PhuongThucThanhToan.MinimumWidth = 6;
            PhuongThucThanhToan.Name = "PhuongThucThanhToan";
            PhuongThucThanhToan.ReadOnly = true;
            // 
            // TenNhanVien
            // 
            TenNhanVien.DataPropertyName = "TenNhanVien";
            TenNhanVien.HeaderText = "Nhân Viên";
            TenNhanVien.MinimumWidth = 6;
            TenNhanVien.Name = "TenNhanVien";
            TenNhanVien.ReadOnly = true;
            // 
            // GhiChu
            // 
            GhiChu.DataPropertyName = "GhiChu";
            GhiChu.HeaderText = "Ghi Chú";
            GhiChu.MinimumWidth = 6;
            GhiChu.Name = "GhiChu";
            GhiChu.ReadOnly = true;
            // 
            // frmThanhToan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 694);
            Controls.Add(dataGridView);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmThanhToan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Thanh Toán";
            WindowState = FormWindowState.Maximized;
            Load += frmThanhToan_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoTien).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblConNo;
        private System.Windows.Forms.Label lblTongDaTra;
        private System.Windows.Forms.Label lblTongHoaDon;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.Label lblHoaDonID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboPhuongThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayThanhToan;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.NumericUpDown numSoTien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTienThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhuongThucThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.Button btnThemThanhToan;
        private System.Windows.Forms.Button btnXoaThanhToan;
        private System.Windows.Forms.Button btnThoat;
    }
}
