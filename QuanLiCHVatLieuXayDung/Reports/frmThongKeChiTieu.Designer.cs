namespace QuanLiCHVatLieuXayDung.Reports
{
    partial class frmThongKeChiTieu
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
            label1 = new Label();
            dtpTuNgay = new DateTimePicker();
            label2 = new Label();
            dtpDenNgay = new DateTimePicker();
            btnThongKe = new Button();
            panel1 = new Panel();
            reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(241, 19);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 6;
            label1.Text = "Từ ngày:";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(321, 14);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(150, 27);
            dtpTuNgay.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(511, 19);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 5;
            label2.Text = "Đến ngày:";
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(601, 14);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(150, 27);
            dtpDenNgay.TabIndex = 3;
            // 
            // btnThongKe
            // 
            btnThongKe.Location = new Point(801, 12);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(100, 30);
            btnThongKe.TabIndex = 4;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnThongKe);
            panel1.Controls.Add(dtpDenNgay);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dtpTuNgay);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1119, 67);
            panel1.TabIndex = 1;
            // 
            // reportViewer
            // 
            reportViewer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reportViewer.Location = new Point(16, 73);
            reportViewer.Name = "reportViewer";
            reportViewer.ServerReport.BearerToken = null;
            reportViewer.Size = new Size(1103, 521);
            reportViewer.TabIndex = 2;
            // 
            // frmThongKeChiTieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 600);
            Controls.Add(reportViewer);
            Controls.Add(panel1);
            Name = "frmThongKeChiTieu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê chi tiêu";
            Load += frmThongKeChiTieu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }
        private Label label1;
        private DateTimePicker dtpTuNgay;
        private Label label2;
        private DateTimePicker dtpDenNgay;
        private Button btnThongKe;
        private Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
    }
}