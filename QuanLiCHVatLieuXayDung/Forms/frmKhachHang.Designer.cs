namespace QuanLiCHVatLieuXayDung.Forms
{
    partial class frmKhachHang
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
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            btnTim = new Button();
            label6 = new Label();
            txtTimKiem = new TextBox();
            txtTongNo = new TextBox();
            label5 = new Label();
            txtLoaiKhach = new TextBox();
            label4 = new Label();
            txtDiaChi = new TextBox();
            label3 = new Label();
            txtSoDienThoai = new TextBox();
            label2 = new Label();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtTenKhachHang = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            KhachHangID = new DataGridViewTextBoxColumn();
            TenKhachHang = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            LoaiKhachHang = new DataGridViewTextBoxColumn();
            TongNo = new DataGridViewTextBoxColumn();
            btnNhap = new Button();
            btnXuat = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(txtTongNo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtLoaiKhach);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtSoDienThoai);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtTenKhachHang);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(863, 240);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnTim);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtTimKiem);
            groupBox3.Location = new Point(3, 177);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(866, 56);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm kiếm";
            // 
            // btnTim
            // 
            btnTim.BackColor = SystemColors.ControlLight;
            btnTim.Location = new Point(715, 21);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(112, 29);
            btnTim.TabIndex = 17;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 26);
            label6.Name = "label6";
            label6.Size = new Size(235, 20);
            label6.TabIndex = 17;
            label6.Text = "Nhập tên/SĐT/địa chỉ khách hàng:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(266, 23);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(443, 27);
            txtTimKiem.TabIndex = 17;
            // 
            // txtTongNo
            // 
            txtTongNo.Location = new Point(580, 100);
            txtTongNo.Name = "txtTongNo";
            txtTongNo.Size = new Size(250, 27);
            txtTongNo.TabIndex = 15;
            txtTongNo.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(480, 103);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 14;
            label5.Text = "Tổng nợ:";
            // 
            // txtLoaiKhach
            // 
            txtLoaiKhach.Location = new Point(180, 100);
            txtLoaiKhach.Name = "txtLoaiKhach";
            txtLoaiKhach.Size = new Size(250, 27);
            txtLoaiKhach.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 103);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 12;
            label4.Text = "Loại khách:";
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
            label3.TabIndex = 10;
            label3.Text = "Địa chỉ:";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(580, 30);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(250, 27);
            txtSoDienThoai.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(480, 33);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 8;
            label2.Text = "SĐT:";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.ControlLight;
            btnThoat.Location = new Point(736, 142);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = SystemColors.ControlLight;
            btnHuyBo.Location = new Point(636, 142);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(94, 29);
            btnHuyBo.TabIndex = 6;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = SystemColors.ControlLight;
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(536, 142);
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
            btnXoa.Location = new Point(436, 142);
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
            btnSua.Location = new Point(336, 142);
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
            btnThem.Location = new Point(236, 142);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Location = new Point(180, 30);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(250, 27);
            txtTenKhachHang.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 33);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên khách hàng (*):";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(0, 239);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(849, 380);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách khách hàng";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { KhachHangID, TenKhachHang, SoDienThoai, DiaChi, LoaiKhachHang, TongNo });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(843, 354);
            dataGridView.TabIndex = 0;
            dataGridView.CellClick += dataGridView_CellClick;
            // 
            // KhachHangID
            // 
            KhachHangID.DataPropertyName = "ID";
            KhachHangID.HeaderText = "ID";
            KhachHangID.MinimumWidth = 6;
            KhachHangID.Name = "KhachHangID";
            KhachHangID.ReadOnly = true;
            // 
            // TenKhachHang
            // 
            TenKhachHang.DataPropertyName = "TenKhachHang";
            TenKhachHang.HeaderText = "Tên khách hàng";
            TenKhachHang.MinimumWidth = 6;
            TenKhachHang.Name = "TenKhachHang";
            TenKhachHang.ReadOnly = true;
            // 
            // SoDienThoai
            // 
            SoDienThoai.DataPropertyName = "SoDienThoai";
            SoDienThoai.HeaderText = "SĐT";
            SoDienThoai.MinimumWidth = 6;
            SoDienThoai.Name = "SoDienThoai";
            SoDienThoai.ReadOnly = true;
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            // 
            // LoaiKhachHang
            // 
            LoaiKhachHang.DataPropertyName = "LoaiKhachHang";
            LoaiKhachHang.HeaderText = "Loại khách";
            LoaiKhachHang.MinimumWidth = 6;
            LoaiKhachHang.Name = "LoaiKhachHang";
            LoaiKhachHang.ReadOnly = true;
            // 
            // TongNo
            // 
            TongNo.DataPropertyName = "TongNo";
            TongNo.HeaderText = "Tổng nợ";
            TongNo.MinimumWidth = 6;
            TongNo.Name = "TongNo";
            TongNo.ReadOnly = true;
            // 
            // btnNhap
            // 
            btnNhap.BackColor = SystemColors.ControlLight;
            btnNhap.Location = new Point(434, 624);
            btnNhap.Margin = new Padding(4, 5, 4, 5);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(113, 28);
            btnNhap.TabIndex = 11;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = SystemColors.ControlLight;
            btnXuat.Location = new Point(313, 624);
            btnXuat.Margin = new Padding(4, 5, 4, 5);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(113, 28);
            btnXuat.TabIndex = 10;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 666);
            Controls.Add(btnNhap);
            Controls.Add(btnXuat);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmKhachHang";
            Text = "Khách hàng";
            Load += frmKhachHang_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLoaiKhach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTongNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView;
        private DataGridViewTextBoxColumn KhachHangID;
        private DataGridViewTextBoxColumn TenKhachHang;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn LoaiKhachHang;
        private DataGridViewTextBoxColumn TongNo;
        private Button btnNhap;
        private Button btnXuat;
        private GroupBox groupBox3;
        private Button btnTim;
        private Label label6;
        private TextBox txtTimKiem;
    }
}