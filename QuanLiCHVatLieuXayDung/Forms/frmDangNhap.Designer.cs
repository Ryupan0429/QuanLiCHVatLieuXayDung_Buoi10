namespace QuanLiCHVatLieuXayDung.Forms
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            btnDangNhap = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            btnHuyBo = new Button();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(203, 218);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(107, 29);
            btnDangNhap.TabIndex = 16;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(47, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(251, 35);
            label3.Name = "label3";
            label3.Size = new Size(153, 31);
            label3.TabIndex = 14;
            label3.Text = "ĐĂNG NHẬP";
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(345, 218);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(107, 29);
            btnHuyBo.TabIndex = 13;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(200, 178);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '⚫';
            txtMatKhau.Size = new Size(252, 27);
            txtMatKhau.TabIndex = 12;
            txtMatKhau.KeyDown += txtMatKhau_KeyDown;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(200, 115);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(252, 27);
            txtTenDangNhap.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 155);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 10;
            label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(200, 92);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 9;
            label1.Text = "Tên đăng nhập:";
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 290);
            Controls.Add(btnDangNhap);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(btnHuyBo);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDangNhap;
        private PictureBox pictureBox1;
        private Label label3;
        private Button btnHuyBo;
        public TextBox txtMatKhau;
        public TextBox txtTenDangNhap;
        private Label label2;
        private Label label1;
    }
}