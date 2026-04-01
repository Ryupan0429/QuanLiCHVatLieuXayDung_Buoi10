namespace QuanLiCHVatLieuXayDung.Forms
{
    partial class frmLichSuHoatDong
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
            panel1 = new Panel();
            btnThoat = new Button();
            btnXuatExcel = new Button();
            btnLoc = new Button();
            label2 = new Label();
            dtpDenNgay = new DateTimePicker();
            label1 = new Label();
            dtpTuNgay = new DateTimePicker();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NhanVien = new DataGridViewTextBoxColumn();
            ThoiGian = new DataGridViewTextBoxColumn();
            HanhDong = new DataGridViewTextBoxColumn();
            DoiTuong = new DataGridViewTextBoxColumn();
            MoTa = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnXuatExcel);
            panel1.Controls.Add(btnLoc);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dtpDenNgay);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dtpTuNgay);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1104, 70);
            panel1.TabIndex = 0;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(980, 20);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(100, 30);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Location = new Point(850, 20);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(120, 30);
            btnXuatExcel.TabIndex = 5;
            btnXuatExcel.Text = "Xuất Excel";
            btnXuatExcel.UseVisualStyleBackColor = true;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // btnLoc
            // 
            btnLoc.Location = new Point(540, 20);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(100, 30);
            btnLoc.TabIndex = 4;
            btnLoc.Text = "Lọc dữ liệu";
            btnLoc.UseVisualStyleBackColor = true;
            btnLoc.Click += btnLoc_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(285, 25);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 3;
            label2.Text = "Đến ngày:";
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(370, 22);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(150, 27);
            dtpDenNgay.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 25);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 1;
            label1.Text = "Từ ngày:";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(100, 22);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(150, 27);
            dtpTuNgay.TabIndex = 0;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, NhanVien, ThoiGian, HanhDong, DoiTuong, MoTa });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 70);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1104, 532);
            dataGridView.TabIndex = 1;
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
            // NhanVien
            // 
            NhanVien.DataPropertyName = "NhanVien";
            NhanVien.HeaderText = "Nhân viên thực hiện";
            NhanVien.MinimumWidth = 6;
            NhanVien.Name = "NhanVien";
            NhanVien.ReadOnly = true;
            // 
            // ThoiGian
            // 
            ThoiGian.DataPropertyName = "ThoiGian";
            ThoiGian.HeaderText = "Thời gian";
            ThoiGian.MinimumWidth = 6;
            ThoiGian.Name = "ThoiGian";
            ThoiGian.ReadOnly = true;
            // 
            // HanhDong
            // 
            HanhDong.DataPropertyName = "HanhDong";
            HanhDong.HeaderText = "Hành động";
            HanhDong.MinimumWidth = 6;
            HanhDong.Name = "HanhDong";
            HanhDong.ReadOnly = true;
            // 
            // DoiTuong
            // 
            DoiTuong.DataPropertyName = "DoiTuong";
            DoiTuong.HeaderText = "Đối tượng";
            DoiTuong.MinimumWidth = 6;
            DoiTuong.Name = "DoiTuong";
            DoiTuong.ReadOnly = true;
            // 
            // MoTa
            // 
            MoTa.DataPropertyName = "MoTa";
            MoTa.HeaderText = "Mô tả chi tiết";
            MoTa.MinimumWidth = 6;
            MoTa.Name = "MoTa";
            MoTa.ReadOnly = true;
            // 
            // frmLichSuHoatDong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 602);
            Controls.Add(dataGridView);
            Controls.Add(panel1);
            Name = "frmLichSuHoatDong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhật ký hệ thống";
            Load += frmLichSuHoatDong_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DateTimePicker dtpTuNgay;
        private Button btnLoc;
        private Label label2;
        private DateTimePicker dtpDenNgay;
        private Button btnThoat;
        private Button btnXuatExcel;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NhanVien;
        private DataGridViewTextBoxColumn ThoiGian;
        private DataGridViewTextBoxColumn HanhDong;
        private DataGridViewTextBoxColumn DoiTuong;
        private DataGridViewTextBoxColumn MoTa;
    }
}