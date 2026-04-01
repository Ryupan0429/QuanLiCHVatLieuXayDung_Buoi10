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
            reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            dtpDenNgay = new DateTimePicker();
            dtpTuNgay = new DateTimePicker();
            btnHienTatCa = new Button();
            label1 = new Label();
            label2 = new Label();
            btnLocKetQua = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // reportViewer
            // 
            reportViewer.Dock = DockStyle.Fill;
            reportViewer.Location = new Point(0, 0);
            reportViewer.Name = "reportViewer";
            reportViewer.ServerReport.BearerToken = null;
            reportViewer.Size = new Size(960, 408);
            reportViewer.TabIndex = 0;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(551, 66);
            dtpDenNgay.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpDenNgay.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(163, 27);
            dtpDenNgay.TabIndex = 20;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(256, 66);
            dtpTuNgay.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpTuNgay.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(163, 27);
            dtpTuNgay.TabIndex = 19;
            // 
            // btnHienTatCa
            // 
            btnHienTatCa.Location = new Point(844, 65);
            btnHienTatCa.Name = "btnHienTatCa";
            btnHienTatCa.Size = new Size(94, 29);
            btnHienTatCa.TabIndex = 18;
            btnHienTatCa.Text = "Hiện tất cả ";
            btnHienTatCa.UseVisualStyleBackColor = true;
            btnHienTatCa.Click += btnHienTatCa_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 71);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 15;
            label1.Text = "Từ ngày:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(470, 71);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 16;
            label2.Text = "Đến ngày:";
            // 
            // btnLocKetQua
            // 
            btnLocKetQua.Location = new Point(735, 65);
            btnLocKetQua.Name = "btnLocKetQua";
            btnLocKetQua.Size = new Size(94, 29);
            btnLocKetQua.TabIndex = 17;
            btnLocKetQua.Text = "Lọc kết quả ";
            btnLocKetQua.UseVisualStyleBackColor = true;
            btnLocKetQua.Click += btnLocKetQua_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(reportViewer);
            panel1.Location = new Point(34, 137);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 408);
            panel1.TabIndex = 14;
            // 
            // frmThongKeDoanhThu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 647);
            Controls.Add(dtpDenNgay);
            Controls.Add(dtpTuNgay);
            Controls.Add(btnHienTatCa);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btnLocKetQua);
            Controls.Add(panel1);
            Name = "frmThongKeDoanhThu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê doanh thu";
            Load += frmThongKeDoanhThu_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private DateTimePicker dtpDenNgay;
        private DateTimePicker dtpTuNgay;
        private Button btnHienTatCa;
        private Label label1;
        private Label label2;
        private Button btnLocKetQua;
        private Panel panel1;
    }
}