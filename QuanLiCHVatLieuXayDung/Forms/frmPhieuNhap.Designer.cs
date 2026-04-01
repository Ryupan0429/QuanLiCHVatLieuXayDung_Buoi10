namespace QuanLiCHVatLieuXayDung.Forms
{
    partial class frmPhieuNhap
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridView = new DataGridView();
            PNID = new DataGridViewTextBoxColumn();
            NhanVien = new DataGridViewTextBoxColumn();
            TenNhaCungCap = new DataGridViewTextBoxColumn();
            NgayNhap = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            ChiTiet = new DataGridViewLinkColumn();
            btnNhap = new Button();
            groupBox1 = new GroupBox();
            btnThoat = new Button();
            btnXuat = new Button();
            btnTimKiem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnInPhieuNhap = new Button();
            btnLapPhieuNhap = new Button();
            btnLoc = new Button();
            label2 = new Label();
            dtpDenNgay = new DateTimePicker();
            label1 = new Label();
            dtpTuNgay = new DateTimePicker();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { PNID, NhanVien, TenNhaCungCap, NgayNhap, TongTien, ChiTiet });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.Margin = new Padding(4, 5, 4, 5);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1011, 496);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // PNID
            // 
            PNID.DataPropertyName = "ID";
            PNID.HeaderText = "ID";
            PNID.MinimumWidth = 6;
            PNID.Name = "PNID";
            PNID.ReadOnly = true;
            // 
            // NhanVien
            // 
            NhanVien.DataPropertyName = "HoVaTenNhanVien";
            NhanVien.HeaderText = "Nhân viên";
            NhanVien.MinimumWidth = 6;
            NhanVien.Name = "NhanVien";
            NhanVien.ReadOnly = true;
            // 
            // TenNhaCungCap
            // 
            TenNhaCungCap.DataPropertyName = "TenNhaCungCap";
            TenNhaCungCap.HeaderText = "Nhà cung cấp";
            TenNhaCungCap.MinimumWidth = 6;
            TenNhaCungCap.Name = "TenNhaCungCap";
            TenNhaCungCap.ReadOnly = true;
            // 
            // NgayNhap
            // 
            NgayNhap.DataPropertyName = "NgayNhap";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            NgayNhap.DefaultCellStyle = dataGridViewCellStyle1;
            NgayNhap.HeaderText = "Ngày nhập";
            NgayNhap.MinimumWidth = 6;
            NgayNhap.Name = "NgayNhap";
            NgayNhap.ReadOnly = true;
            // 
            // TongTien
            // 
            TongTien.DataPropertyName = "TongTien";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.Blue;
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
            // btnNhap
            // 
            btnNhap.Location = new Point(762, 26);
            btnNhap.Margin = new Padding(4, 5, 4, 5);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(113, 38);
            btnNhap.TabIndex = 18;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView);
            groupBox1.Location = new Point(8, 128);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1017, 522);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách phiếu nhập";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(910, 26);
            btnThoat.Margin = new Padding(4, 5, 4, 5);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(100, 38);
            btnThoat.TabIndex = 16;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(641, 26);
            btnXuat.Margin = new Padding(4, 5, 4, 5);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(113, 38);
            btnXuat.TabIndex = 15;
            btnXuat.Text = "Xuất Excel...";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(520, 26);
            btnTimKiem.Margin = new Padding(4, 5, 4, 5);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(113, 38);
            btnTimKiem.TabIndex = 14;
            btnTimKiem.Text = "Tìm kiếm...";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(412, 26);
            btnXoa.Margin = new Padding(4, 5, 4, 5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 38);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(304, 26);
            btnSua.Margin = new Padding(4, 5, 4, 5);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 38);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa...";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnInPhieuNhap
            // 
            btnInPhieuNhap.Location = new Point(176, 26);
            btnInPhieuNhap.Margin = new Padding(4, 5, 4, 5);
            btnInPhieuNhap.Name = "btnInPhieuNhap";
            btnInPhieuNhap.Size = new Size(120, 38);
            btnInPhieuNhap.TabIndex = 11;
            btnInPhieuNhap.Text = "In phiếu nhập...";
            btnInPhieuNhap.UseVisualStyleBackColor = true;
            btnInPhieuNhap.Click += btnInPhieuNhap_Click;
            // 
            // btnLapPhieuNhap
            // 
            btnLapPhieuNhap.Location = new Point(8, 26);
            btnLapPhieuNhap.Margin = new Padding(4, 5, 4, 5);
            btnLapPhieuNhap.Name = "btnLapPhieuNhap";
            btnLapPhieuNhap.Size = new Size(160, 38);
            btnLapPhieuNhap.TabIndex = 10;
            btnLapPhieuNhap.Text = "Lập phiếu nhập mới...";
            btnLapPhieuNhap.UseVisualStyleBackColor = true;
            btnLapPhieuNhap.Click += btnLapPhieuNhap_Click;
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
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(307, 23);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 22;
            label2.Text = "Đến ngày:";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 23);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 20;
            label1.Text = "Từ ngày:";
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
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(dtpTuNgay);
            groupBox2.Controls.Add(btnLoc);
            groupBox2.Controls.Add(dtpDenNgay);
            groupBox2.Location = new Point(13, 72);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(997, 50);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lọc";
            // 
            // frmPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 697);
            Controls.Add(btnNhap);
            Controls.Add(groupBox1);
            Controls.Add(btnThoat);
            Controls.Add(btnXuat);
            Controls.Add(btnTimKiem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnInPhieuNhap);
            Controls.Add(btnLapPhieuNhap);
            Controls.Add(groupBox2);
            Name = "frmPhieuNhap";
            Text = "Phiếu nhập";
            Load += frmPhieuNhap_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }
        private DataGridView dataGridView;
        private Button btnNhap;
        private GroupBox groupBox1;
        private Button btnThoat;
        private Button btnXuat;
        private Button btnTimKiem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnInPhieuNhap;
        private Button btnLapPhieuNhap;
        private DataGridViewTextBoxColumn PNID;
        private DataGridViewTextBoxColumn NhanVien;
        private DataGridViewTextBoxColumn TenNhaCungCap;
        private DataGridViewTextBoxColumn NgayNhap;
        private DataGridViewTextBoxColumn TongTien;
        private DataGridViewLinkColumn ChiTiet;
        private Button btnLoc;
        private Label label2;
        private DateTimePicker dtpDenNgay;
        private Label label1;
        private DateTimePicker dtpTuNgay;
        private GroupBox groupBox2;
    }
}