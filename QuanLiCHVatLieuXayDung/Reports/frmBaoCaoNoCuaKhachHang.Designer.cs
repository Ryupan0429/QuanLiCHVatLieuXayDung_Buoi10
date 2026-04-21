namespace QuanLiCHVatLieuXayDung.Reports
{
    partial class frmBaoCaoNoCuaKhachHang
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
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            label1 = new Label();
            label2 = new Label();
            dtpTuNgay = new DateTimePicker();
            dtpDenNgay = new DateTimePicker();
            label3 = new Label();
            cboNhomQuaHan = new ComboBox();
            btnLocKetQua = new Button();
            btnHienTatCa = new Button();
            splitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // reportViewer1
            // 
            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.Location = new Point(0, 0);
            reportViewer1.Name = "reportViewer1";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(1269, 517);
            reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(284, 35);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 2;
            label1.Text = "Từ ngày:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(536, 35);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 4;
            label2.Text = "Đến ngày:";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(370, 35);
            dtpTuNgay.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpTuNgay.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(150, 27);
            dtpTuNgay.TabIndex = 3;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(627, 35);
            dtpDenNgay.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpDenNgay.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(150, 27);
            dtpDenNgay.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(284, 85);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 6;
            label3.Text = "Nhóm quá hạn:";
            // 
            // cboNhomQuaHan
            // 
            cboNhomQuaHan.FormattingEnabled = true;
            cboNhomQuaHan.Location = new Point(400, 81);
            cboNhomQuaHan.Name = "cboNhomQuaHan";
            cboNhomQuaHan.Size = new Size(220, 28);
            cboNhomQuaHan.TabIndex = 7;
            // 
            // btnLocKetQua
            // 
            btnLocKetQua.Location = new Point(650, 75);
            btnLocKetQua.Name = "btnLocKetQua";
            btnLocKetQua.Size = new Size(100, 38);
            btnLocKetQua.TabIndex = 8;
            btnLocKetQua.Text = "Lọc kết quả";
            btnLocKetQua.UseVisualStyleBackColor = true;
            btnLocKetQua.Click += btnLocKetQua_Click;
            // 
            // btnHienTatCa
            // 
            btnHienTatCa.Location = new Point(774, 76);
            btnHienTatCa.Name = "btnHienTatCa";
            btnHienTatCa.Size = new Size(100, 38);
            btnHienTatCa.TabIndex = 9;
            btnHienTatCa.Text = "Hiện tất cả";
            btnHienTatCa.UseVisualStyleBackColor = true;
            btnHienTatCa.Click += btnHienTatCa_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnLocKetQua);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(btnHienTatCa);
            splitContainer1.Panel1.Controls.Add(dtpTuNgay);
            splitContainer1.Panel1.Controls.Add(cboNhomQuaHan);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(dtpDenNgay);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(reportViewer1);
            splitContainer1.Size = new Size(1269, 650);
            splitContainer1.SplitterDistance = 129;
            splitContainer1.TabIndex = 10;
            // 
            // frmBaoCaoNoCuaKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 650);
            Controls.Add(splitContainer1);
            Name = "frmBaoCaoNoCuaKhachHang";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Báo cáo nợ của khách hàng";
            WindowState = FormWindowState.Maximized;
            Load += frmBaoCaoNoCuaKhachHang_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpTuNgay;
        private DateTimePicker dtpDenNgay;
        private Label label3;
        private ComboBox cboNhomQuaHan;
        private Button btnLocKetQua;
        private Button btnHienTatCa;
        private SplitContainer splitContainer1;
    }
}