namespace QuanLiCHVatLieuXayDung.Reports
{
    partial class frmThongKeDoanhThu
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
            dtpDenNgay = new DateTimePicker();
            dtpTuNgay = new DateTimePicker();
            btnHienTatCa = new Button();
            label1 = new Label();
            label2 = new Label();
            btnLocKetQua = new Button();
            reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(529, 48);
            dtpDenNgay.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpDenNgay.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(178, 27);
            dtpDenNgay.TabIndex = 20;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(249, 48);
            dtpTuNgay.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpTuNgay.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(160, 27);
            dtpTuNgay.TabIndex = 19;
            // 
            // btnHienTatCa
            // 
            btnHienTatCa.Location = new Point(837, 47);
            btnHienTatCa.Name = "btnHienTatCa";
            btnHienTatCa.Size = new Size(94, 29);
            btnHienTatCa.TabIndex = 18;
            btnHienTatCa.Text = "Hiện tất cả ";
            btnHienTatCa.UseVisualStyleBackColor = true;
            btnHienTatCa.Click += btnHienTatCa_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(159, 53);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 15;
            label1.Text = "Từ ngày:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(448, 53);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 16;
            label2.Text = "Đến ngày:";
            // 
            // btnLocKetQua
            // 
            btnLocKetQua.Location = new Point(728, 47);
            btnLocKetQua.Name = "btnLocKetQua";
            btnLocKetQua.Size = new Size(94, 29);
            btnLocKetQua.TabIndex = 17;
            btnLocKetQua.Text = "Lọc kết quả ";
            btnLocKetQua.UseVisualStyleBackColor = true;
            btnLocKetQua.Click += btnLocKetQua_Click;
            // 
            // reportViewer
            // 
            reportViewer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reportViewer.Location = new Point(12, 151);
            reportViewer.Name = "reportViewer";
            reportViewer.ServerReport.BearerToken = null;
            reportViewer.Size = new Size(966, 484);
            reportViewer.TabIndex = 21;
            // 
            // frmThongKeDoanhThu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 647);
            Controls.Add(reportViewer);
            Controls.Add(dtpDenNgay);
            Controls.Add(dtpTuNgay);
            Controls.Add(btnHienTatCa);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btnLocKetQua);
            Name = "frmThongKeDoanhThu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê doanh thu";
            Load += frmThongKeDoanhThu_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        private DateTimePicker dtpDenNgay;
        private DateTimePicker dtpTuNgay;
        private Button btnHienTatCa;
        private Label label1;
        private Label label2;
        private Button btnLocKetQua;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
    }
}