namespace QuanLiCHVatLieuXayDung.Reports
{
    partial class frmThongKeSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            cboHangSanXuat = new ComboBox();
            cboLoaiSanPham = new ComboBox();
            label2 = new Label();
            btnLocKetQua = new Button();
            splitContainer1 = new SplitContainer();
            reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cboHangSanXuat);
            panel1.Controls.Add(cboLoaiSanPham);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnLocKetQua);
            panel1.Location = new Point(34, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1026, 94);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 23);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 1;
            label1.Text = "Hãng sản xuất:";
            // 
            // cboHangSanXuat
            // 
            cboHangSanXuat.FormattingEnabled = true;
            cboHangSanXuat.Location = new Point(240, 15);
            cboHangSanXuat.Name = "cboHangSanXuat";
            cboHangSanXuat.Size = new Size(151, 28);
            cboHangSanXuat.TabIndex = 3;
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Location = new Point(542, 16);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(151, 28);
            cboLoaiSanPham.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(417, 23);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 2;
            label2.Text = "Loại sản phẩm:";
            // 
            // btnLocKetQua
            // 
            btnLocKetQua.Location = new Point(708, 15);
            btnLocKetQua.Name = "btnLocKetQua";
            btnLocKetQua.Size = new Size(94, 29);
            btnLocKetQua.TabIndex = 5;
            btnLocKetQua.Text = "Lọc kết quả ";
            btnLocKetQua.UseVisualStyleBackColor = true;
            btnLocKetQua.Click += btnLocKetQua_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(reportViewer);
            splitContainer1.Size = new Size(1078, 615);
            splitContainer1.SplitterDistance = 123;
            splitContainer1.TabIndex = 10;
            // 
            // reportViewer
            // 
            reportViewer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reportViewer.Location = new Point(17, 14);
            reportViewer.Name = "reportViewer";
            reportViewer.ServerReport.BearerToken = null;
            reportViewer.Size = new Size(1043, 462);
            reportViewer.TabIndex = 2;
            // 
            // frmThongKeSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 615);
            Controls.Add(splitContainer1);
            Name = "frmThongKeSanPham";
            Text = "Thống kê sản phẩm";
            Load += frmThongKeSanPham_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private ComboBox cboHangSanXuat;
        private ComboBox cboLoaiSanPham;
        private Label label2;
        private Button btnLocKetQua;
        private SplitContainer splitContainer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
    }
}