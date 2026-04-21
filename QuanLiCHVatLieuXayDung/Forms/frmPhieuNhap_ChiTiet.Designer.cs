namespace QuanLiCHVatLieuXayDung.Forms
{
    partial class frmPhieuNhap_ChiTiet
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
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle moneyStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle qtyStyle = new DataGridViewCellStyle();

            groupBox1 = new GroupBox();
            dtpNgayNhap = new DateTimePicker();
            label3 = new Label();
            txtGhiChu = new TextBox();
            label2 = new Label();
            cboNhaCungCap = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnXoaSP = new Button();
            btnThemSP = new Button();
            numDonGia = new NumericUpDown();
            label7 = new Label();
            numSoLuong = new NumericUpDown();
            label5 = new Label();
            cboSanPham = new ComboBox();
            label4 = new Label();
            panel1 = new Panel();
            dataGridView = new DataGridView();
            SanPhamID = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGiaNhap = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            btnLuu = new Button();
            btnThoat = new Button();
            label6 = new Label();
            txtTongTien = new TextBox();

            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();

            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1099, 663);
            this.Font = new Font("Segoe UI", 9F);
            this.BackColor = Color.WhiteSmoke;
            this.Text = "Chi tiết Phiếu nhập";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += frmPhieuNhap_ChiTiet_Load;

            groupBox1.BackColor = Color.White;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Size = new Size(1075, 110);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phiếu nhập";
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            label1.Text = "Nhà cung cấp:";
            label1.Location = new Point(15, 33);
            label1.AutoSize = true;

            cboNhaCungCap.Location = new Point(125, 30);
            cboNhaCungCap.Size = new Size(250, 28);
            cboNhaCungCap.DropDownStyle = ComboBoxStyle.DropDownList;

            label3.Text = "Ngày nhập:";
            label3.Location = new Point(15, 70);
            label3.AutoSize = true;

            dtpNgayNhap.Location = new Point(125, 65);
            dtpNgayNhap.Size = new Size(250, 27);
            dtpNgayNhap.Format = DateTimePickerFormat.Short;

            label2.Text = "Ghi chú:";
            label2.Location = new Point(415, 33);
            label2.AutoSize = true;

            txtGhiChu.Location = new Point(500, 30);
            txtGhiChu.Size = new Size(550, 62);
            txtGhiChu.Multiline = true;
            txtGhiChu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            groupBox2.BackColor = Color.White;
            groupBox2.Location = new Point(12, 128);
            groupBox2.Size = new Size(1075, 80);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết mặt hàng";
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            label4.Text = "Sản phẩm:";
            label4.Location = new Point(15, 33);
            label4.AutoSize = true;

            cboSanPham.Location = new Point(95, 30);
            cboSanPham.Size = new Size(270, 28);
            cboSanPham.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSanPham.SelectionChangeCommitted += cboSanPham_SelectionChangeCommitted;

            label5.Text = "Số lượng:";
            label5.Location = new Point(385, 33);
            label5.AutoSize = true;

            numSoLuong.Location = new Point(460, 31);
            numSoLuong.Size = new Size(100, 27);
            numSoLuong.Maximum = 1000000;
            numSoLuong.Value = 1;

            label7.Text = "Đơn giá:";
            label7.Location = new Point(575, 33);
            label7.AutoSize = true;

            numDonGia.Location = new Point(650, 31);
            numDonGia.Size = new Size(150, 27);
            numDonGia.Maximum = 1410065407;
            numDonGia.ThousandsSeparator = true;

            btnThemSP.Text = "Thêm vào";
            btnThemSP.Location = new Point(835, 28);
            btnThemSP.Size = new Size(100, 30);
            btnThemSP.BackColor = Color.FromArgb(0, 123, 255);
            btnThemSP.ForeColor = Color.White;
            btnThemSP.FlatStyle = FlatStyle.Flat;
            btnThemSP.FlatAppearance.BorderSize = 0;
            btnThemSP.Cursor = Cursors.Hand;
            btnThemSP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemSP.Click += btnThemSP_Click;

            btnXoaSP.Text = "Xóa mặt hàng";
            btnXoaSP.Location = new Point(950, 28);
            btnXoaSP.Size = new Size(110, 30);
            btnXoaSP.BackColor = Color.FromArgb(220, 53, 69);
            btnXoaSP.ForeColor = Color.White;
            btnXoaSP.FlatStyle = FlatStyle.Flat;
            btnXoaSP.FlatAppearance.BorderSize = 0;
            btnXoaSP.Cursor = Cursors.Hand;
            btnXoaSP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXoaSP.Click += btnXoaSP_Click;

            panel1.Location = new Point(12, 214);
            panel1.Size = new Size(1075, 380);
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.MultiSelect = false;
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            headerStyle.BackColor = Color.FromArgb(245, 245, 245);
            headerStyle.ForeColor = Color.FromArgb(40, 40, 40);
            headerStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridView.ColumnHeadersDefaultCellStyle = headerStyle;

            qtyStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            qtyStyle.Format = "N0";

            moneyStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            moneyStyle.Format = "N0";
            moneyStyle.ForeColor = Color.FromArgb(0, 123, 255);
            moneyStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            SanPhamID.DataPropertyName = "SanPhamID"; SanPhamID.HeaderText = "Mã SP";
            TenSanPham.DataPropertyName = "TenSanPham"; TenSanPham.HeaderText = "Tên sản phẩm";
            SoLuong.DataPropertyName = "SoLuong"; SoLuong.HeaderText = "Số lượng"; SoLuong.DefaultCellStyle = qtyStyle;
            DonGiaNhap.DataPropertyName = "DonGiaNhap"; DonGiaNhap.HeaderText = "Đơn giá nhập"; DonGiaNhap.DefaultCellStyle = qtyStyle;
            ThanhTien.DataPropertyName = "ThanhTien"; ThanhTien.HeaderText = "Thành tiền"; ThanhTien.DefaultCellStyle = moneyStyle;

            dataGridView.Columns.AddRange(new DataGridViewColumn[] { SanPhamID, TenSanPham, SoLuong, DonGiaNhap, ThanhTien });
            panel1.Controls.Add(dataGridView);

            label6.Text = "Tổng tiền:";
            label6.Location = new Point(12, 615);
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;

            txtTongTien.Location = new Point(126, 612);
            txtTongTien.Size = new Size(250, 34);
            txtTongTien.BackColor = Color.White;
            txtTongTien.ForeColor = Color.FromArgb(0, 123, 255);
            txtTongTien.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtTongTien.ReadOnly = true;
            txtTongTien.TextAlign = HorizontalAlignment.Right;
            txtTongTien.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;

            btnLuu.Text = "Lưu phiếu nhập";
            btnLuu.Location = new Point(810, 610);
            btnLuu.Size = new Size(140, 40);
            btnLuu.BackColor = Color.FromArgb(0, 123, 255);
            btnLuu.ForeColor = Color.White;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.Cursor = Cursors.Hand;
            btnLuu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLuu.Click += btnLuu_Click;

            btnThoat.Text = "Thoát";
            btnThoat.Location = new Point(967, 610);
            btnThoat.Size = new Size(120, 40);
            btnThoat.BackColor = Color.FromArgb(108, 117, 125);
            btnThoat.ForeColor = Color.White;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnThoat.Click += btnThoat_Click;

            groupBox1.Controls.AddRange(new Control[] { dtpNgayNhap, label3, txtGhiChu, label2, cboNhaCungCap, label1 });
            groupBox2.Controls.AddRange(new Control[] { btnXoaSP, btnThemSP, numDonGia, label7, numSoLuong, label5, cboSanPham, label4 });
            this.Controls.AddRange(new Control[] { txtTongTien, label6, btnThoat, btnLuu, panel1, groupBox2, groupBox1 });

            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private GroupBox groupBox1;
        private Label label1;
        private ComboBox cboNhaCungCap;
        private TextBox txtGhiChu;
        private Label label2;
        private DateTimePicker dtpNgayNhap;
        private Label label3;
        private GroupBox groupBox2;
        private ComboBox cboSanPham;
        private Label label4;
        private NumericUpDown numSoLuong;
        private Label label5;
        private Button btnThemSP;
        private Panel panel1;
        private DataGridView dataGridView;
        private Button btnLuu;
        private Button btnThoat;
        private Label label6;
        private TextBox txtTongTien;
        private NumericUpDown numDonGia;
        private Label label7;
        private Button btnXoaSP;
        private DataGridViewTextBoxColumn SanPhamID;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGiaNhap;
        private DataGridViewTextBoxColumn ThanhTien;
    }
}