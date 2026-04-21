namespace QuanLiCHVatLieuXayDung.Forms
{
    partial class frmNhaCungCap
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
            groupBox1 = new GroupBox();
            btnThoat = new Button();
            txtDiaChi = new TextBox();
            btnHuyBo = new Button();
            label4 = new Label();
            btnLuu = new Button();
            btnXoa = new Button();
            txtSDT = new TextBox();
            btnSua = new Button();
            label2 = new Label();
            btnThem = new Button();
            txtTenNhaCungCap = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            NCCID = new DataGridViewTextBoxColumn();
            TenNhaCungCap = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            btnLamMoi = new Button();
            btnTim = new Button();
            label6 = new Label();
            txtTimKiem = new TextBox();
            btnNhap = new Button();
            btnXuat = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtTenNhaCungCap);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1000, 200);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(108, 117, 125);
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(643, 156);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(135, 100);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(400, 50);
            txtDiaChi.TabIndex = 5;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.FromArgb(220, 53, 69);
            btnHuyBo.Cursor = Cursors.Hand;
            btnHuyBo.FlatAppearance.BorderSize = 0;
            btnHuyBo.FlatStyle = FlatStyle.Flat;
            btnHuyBo.ForeColor = Color.White;
            btnHuyBo.Location = new Point(543, 156);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(94, 29);
            btnHuyBo.TabIndex = 7;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 103);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 4;
            label4.Text = "Địa chỉ:";
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(0, 123, 255);
            btnLuu.Cursor = Cursors.Hand;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(441, 156);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 8;
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
            btnXoa.Location = new Point(341, 156);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(135, 65);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(400, 27);
            txtSDT.TabIndex = 3;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(0, 123, 255);
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(240, 156);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 68);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 2;
            label2.Text = "Số điện thoại:";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(0, 123, 255);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(140, 156);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 11;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenNhaCungCap
            // 
            txtTenNhaCungCap.Location = new Point(135, 30);
            txtTenNhaCungCap.Name = "txtTenNhaCungCap";
            txtTenNhaCungCap.Size = new Size(400, 27);
            txtTenNhaCungCap.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 33);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên NCC:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 270);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1000, 330);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhà cung cấp";
            // 
            // dataGridView
            // 
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
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { NCCID, TenNhaCungCap, SoDienThoai, DiaChi });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(994, 304);
            dataGridView.TabIndex = 0;
            // 
            // NCCID
            // 
            NCCID.DataPropertyName = "ID";
            NCCID.HeaderText = "ID";
            NCCID.MinimumWidth = 6;
            NCCID.Name = "NCCID";
            // 
            // TenNhaCungCap
            // 
            TenNhaCungCap.DataPropertyName = "TenNhaCungCap";
            TenNhaCungCap.HeaderText = "Tên nhà cung cấp";
            TenNhaCungCap.MinimumWidth = 6;
            TenNhaCungCap.Name = "TenNhaCungCap";
            // 
            // SoDienThoai
            // 
            SoDienThoai.DataPropertyName = "SoDienThoai";
            SoDienThoai.HeaderText = "Số điện thoại";
            SoDienThoai.MinimumWidth = 6;
            SoDienThoai.Name = "SoDienThoai";
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnLamMoi);
            groupBox3.Controls.Add(btnTim);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtTimKiem);
            groupBox3.Controls.Add(btnNhap);
            groupBox3.Controls.Add(btnXuat);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(0, 200);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1000, 70);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm kiếm và Tiện ích";
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(480, 25);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(380, 25);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(94, 29);
            btnTim.TabIndex = 2;
            btnTim.Text = "Tìm kiếm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 28);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 0;
            label6.Text = "Nội dung:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(135, 25);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(230, 27);
            txtTimKiem.TabIndex = 1;
            // 
            // btnNhap
            // 
            btnNhap.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNhap.Location = new Point(780, 25);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(94, 29);
            btnNhap.TabIndex = 4;
            btnNhap.Text = "Nhập Excel";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnXuat
            // 
            btnXuat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXuat.Location = new Point(880, 25);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 29);
            btnXuat.TabIndex = 5;
            btnXuat.Text = "Xuất Excel";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // frmNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "frmNhaCungCap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Nhà cung cấp";
            WindowState = FormWindowState.Maximized;
            Load += frmNhaCungCap_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtTenNhaCungCap;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private Label label4;
        private TextBox txtSDT;
        private Label label2;
        private TextBox txtDiaChi;
        private Button btnNhap;
        private Button btnXuat;
        private GroupBox groupBox3;
        private Button btnTim;
        private Label label6;
        private TextBox txtTimKiem;
        private Button btnLamMoi;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridViewTextBoxColumn NCCID;
        private DataGridViewTextBoxColumn TenNhaCungCap;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn DiaChi;
    }
}