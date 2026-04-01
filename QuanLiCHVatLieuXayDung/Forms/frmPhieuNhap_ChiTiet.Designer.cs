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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            btnLuu = new Button();
            btnThoat = new Button();
            label6 = new Label();
            txtTongTien = new TextBox();
            SanPhamID = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGiaNhap = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpNgayNhap);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtGhiChu);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cboNhaCungCap);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1075, 110);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.Format = DateTimePickerFormat.Short;
            dtpNgayNhap.Location = new Point(125, 65);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(250, 27);
            dtpNgayNhap.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 70);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 4;
            label3.Text = "Ngày nhập:";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(500, 30);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(550, 62);
            txtGhiChu.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(415, 33);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 2;
            label2.Text = "Ghi chú:";
            // 
            // cboNhaCungCap
            // 
            cboNhaCungCap.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNhaCungCap.FormattingEnabled = true;
            cboNhaCungCap.Location = new Point(125, 30);
            cboNhaCungCap.Name = "cboNhaCungCap";
            cboNhaCungCap.Size = new Size(250, 28);
            cboNhaCungCap.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 33);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhà cung cấp:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnXoaSP);
            groupBox2.Controls.Add(btnThemSP);
            groupBox2.Controls.Add(numDonGia);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(numSoLuong);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cboSanPham);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 128);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1075, 80);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết mặt hàng";
            // 
            // btnXoaSP
            // 
            btnXoaSP.Location = new Point(950, 28);
            btnXoaSP.Name = "btnXoaSP";
            btnXoaSP.Size = new Size(110, 30);
            btnXoaSP.TabIndex = 7;
            btnXoaSP.Text = "Xóa mặt hàng";
            btnXoaSP.UseVisualStyleBackColor = true;
            btnXoaSP.Click += btnXoaSP_Click;
            // 
            // btnThemSP
            // 
            btnThemSP.Location = new Point(835, 28);
            btnThemSP.Name = "btnThemSP";
            btnThemSP.Size = new Size(100, 30);
            btnThemSP.TabIndex = 6;
            btnThemSP.Text = "Thêm vào";
            btnThemSP.UseVisualStyleBackColor = true;
            btnThemSP.Click += btnThemSP_Click;
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(650, 31);
            numDonGia.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(150, 27);
            numDonGia.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(575, 33);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 4;
            label7.Text = "Đơn giá:";
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(460, 31);
            numSoLuong.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(100, 27);
            numSoLuong.TabIndex = 3;
            numSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(385, 33);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 2;
            label5.Text = "Số lượng:";
            // 
            // cboSanPham
            // 
            cboSanPham.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSanPham.FormattingEnabled = true;
            cboSanPham.Location = new Point(95, 30);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(270, 28);
            cboSanPham.TabIndex = 1;
            cboSanPham.SelectionChangeCommitted += cboSanPham_SelectionChangeCommitted;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 33);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 0;
            label4.Text = "Sản phẩm:";
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView);
            panel1.Location = new Point(12, 214);
            panel1.Name = "panel1";
            panel1.Size = new Size(1075, 380);
            panel1.TabIndex = 2;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { SanPhamID, TenSanPham, SoLuong, DonGiaNhap, ThanhTien });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 0);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1075, 380);
            dataGridView.TabIndex = 0;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(810, 610);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(140, 40);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Lưu phiếu nhập";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(967, 610);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(120, 40);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(12, 615);
            label6.Name = "label6";
            label6.Size = new Size(108, 28);
            label6.TabIndex = 5;
            label6.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            txtTongTien.BackColor = SystemColors.Info;
            txtTongTien.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtTongTien.ForeColor = Color.Red;
            txtTongTien.Location = new Point(126, 612);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(250, 34);
            txtTongTien.TabIndex = 6;
            txtTongTien.Text = "0";
            txtTongTien.TextAlign = HorizontalAlignment.Right;
            // 
            // SanPhamID
            // 
            SanPhamID.DataPropertyName = "SanPhamID";
            SanPhamID.HeaderText = "Mã SP";
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
            // DonGiaNhap
            // 
            DonGiaNhap.DataPropertyName = "DonGiaNhap";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            DonGiaNhap.DefaultCellStyle = dataGridViewCellStyle2;
            DonGiaNhap.HeaderText = "Đơn giá nhập";
            DonGiaNhap.MinimumWidth = 6;
            DonGiaNhap.Name = "DonGiaNhap";
            DonGiaNhap.ReadOnly = true;
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            ThanhTien.DefaultCellStyle = dataGridViewCellStyle3;
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 6;
            ThanhTien.Name = "ThanhTien";
            ThanhTien.ReadOnly = true;
            // 
            // frmPhieuNhap_ChiTiet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 663);
            Controls.Add(txtTongTien);
            Controls.Add(label6);
            Controls.Add(btnThoat);
            Controls.Add(btnLuu);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmPhieuNhap_ChiTiet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi tiết Phiếu nhập";
            Load += frmPhieuNhap_ChiTiet_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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