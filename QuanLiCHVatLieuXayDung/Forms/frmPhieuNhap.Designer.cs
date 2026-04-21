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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataGridView = new DataGridView();
            PNID = new DataGridViewTextBoxColumn();
            NhanVien = new DataGridViewTextBoxColumn();
            TenNhaCungCap = new DataGridViewTextBoxColumn();
            NgayNhap = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            ChiTiet = new DataGridViewLinkColumn();
            btnLapPhieuNhap = new Button();
            btnInPhieuNhap = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnXuat = new Button();
            btnNhap = new Button();
            btnThoat = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnHuy = new Button();
            label1 = new Label();
            label2 = new Label();
            dtpTuNgay = new DateTimePicker();
            btnLoc = new Button();
            dtpDenNgay = new DateTimePicker();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridView.Size = new Size(1011, 440);
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            NgayNhap.DefaultCellStyle = dataGridViewCellStyle2;
            NgayNhap.HeaderText = "Ngày nhập";
            NgayNhap.MinimumWidth = 6;
            NgayNhap.Name = "NgayNhap";
            NgayNhap.ReadOnly = true;
            // 
            // TongTien
            // 
            TongTien.DataPropertyName = "TongTien";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Blue;
            dataGridViewCellStyle3.Format = "N0";
            TongTien.DefaultCellStyle = dataGridViewCellStyle3;
            TongTien.HeaderText = "Tổng tiền";
            TongTien.MinimumWidth = 6;
            TongTien.Name = "TongTien";
            TongTien.ReadOnly = true;
            // 
            // ChiTiet
            // 
            ChiTiet.DataPropertyName = "XemChiTiet";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ChiTiet.DefaultCellStyle = dataGridViewCellStyle4;
            ChiTiet.HeaderText = "Chi tiết";
            ChiTiet.MinimumWidth = 6;
            ChiTiet.Name = "ChiTiet";
            ChiTiet.ReadOnly = true;
            // 
            // btnLapPhieuNhap
            // 
            btnLapPhieuNhap.BackColor = Color.FromArgb(0, 123, 255);
            btnLapPhieuNhap.ForeColor = SystemColors.ControlLightLight;
            btnLapPhieuNhap.Location = new Point(22, 14);
            btnLapPhieuNhap.Margin = new Padding(4, 5, 4, 5);
            btnLapPhieuNhap.Name = "btnLapPhieuNhap";
            btnLapPhieuNhap.Size = new Size(160, 38);
            btnLapPhieuNhap.TabIndex = 1;
            btnLapPhieuNhap.Text = "Lập phiếu nhập mới...";
            btnLapPhieuNhap.UseVisualStyleBackColor = false;
            btnLapPhieuNhap.Click += btnLapPhieuNhap_Click;
            // 
            // btnInPhieuNhap
            // 
            btnInPhieuNhap.BackColor = Color.FromArgb(0, 123, 255);
            btnInPhieuNhap.ForeColor = SystemColors.ControlLightLight;
            btnInPhieuNhap.Location = new Point(190, 14);
            btnInPhieuNhap.Margin = new Padding(4, 5, 4, 5);
            btnInPhieuNhap.Name = "btnInPhieuNhap";
            btnInPhieuNhap.Size = new Size(120, 38);
            btnInPhieuNhap.TabIndex = 2;
            btnInPhieuNhap.Text = "In phiếu nhập...";
            btnInPhieuNhap.UseVisualStyleBackColor = false;
            btnInPhieuNhap.Click += btnInPhieuNhap_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(0, 123, 255);
            btnSua.ForeColor = SystemColors.ControlLightLight;
            btnSua.Location = new Point(318, 14);
            btnSua.Margin = new Padding(4, 5, 4, 5);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 38);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa...";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(220, 53, 69);
            btnXoa.ForeColor = SystemColors.ControlLightLight;
            btnXoa.Location = new Point(442, 14);
            btnXoa.Margin = new Padding(4, 5, 4, 5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 38);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.FromArgb(0, 123, 255);
            btnXuat.ForeColor = SystemColors.ControlLightLight;
            btnXuat.Location = new Point(559, 14);
            btnXuat.Margin = new Padding(4, 5, 4, 5);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(113, 38);
            btnXuat.TabIndex = 5;
            btnXuat.Text = "Xuất Excel...";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.BackColor = Color.FromArgb(0, 123, 255);
            btnNhap.ForeColor = SystemColors.ControlLightLight;
            btnNhap.Location = new Point(695, 14);
            btnNhap.Margin = new Padding(4, 5, 4, 5);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(113, 38);
            btnNhap.TabIndex = 6;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhap_Click;
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
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dataGridView);
            groupBox1.Location = new Point(12, 120);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1017, 466);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách phiếu nhập";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnHuy);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(dtpTuNgay);
            groupBox2.Controls.Add(btnLoc);
            groupBox2.Controls.Add(dtpDenNgay);
            groupBox2.Location = new Point(22, 60);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1013, 50);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lọc";
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(686, 15);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(100, 30);
            btnHuy.TabIndex = 30;
            btnHuy.Text = "Hủy lọc";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 23);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 20;
            label1.Text = "Từ ngày:";
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
            // frmPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 597);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnThoat);
            Controls.Add(btnNhap);
            Controls.Add(btnXuat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnInPhieuNhap);
            Controls.Add(btnLapPhieuNhap);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmPhieuNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phiếu nhập";
            WindowState = FormWindowState.Maximized;
            Load += frmPhieuNhap_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }
        private DataGridView dataGridView;
        private Button btnLapPhieuNhap;
        private Button btnInPhieuNhap;
        private Button btnSua;
        private Button btnXoa;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnThoat;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnHuy;
        private Button btnLoc;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpTuNgay;
        private DateTimePicker dtpDenNgay;
        private DataGridViewTextBoxColumn PNID;
        private DataGridViewTextBoxColumn NhanVien;
        private DataGridViewTextBoxColumn TenNhaCungCap;
        private DataGridViewTextBoxColumn NgayNhap;
        private DataGridViewTextBoxColumn TongTien;
        private DataGridViewLinkColumn ChiTiet;
    }
}

