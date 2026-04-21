namespace QuanLiCHVatLieuXayDung.Forms
{
    partial class frmDoiMatKhau
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
            txtOldPass = new TextBox();
            txtNewPass = new TextBox();
            btnDoiMatKhau = new Button();
            btnHuy = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNewPassAgain = new TextBox();
            SuspendLayout();
            // 
            // txtOldPass
            // 
            txtOldPass.BackColor = Color.White;
            txtOldPass.ForeColor = Color.FromArgb(50, 50, 50);
            txtOldPass.Location = new Point(226, 32);
            txtOldPass.Name = "txtOldPass";
            txtOldPass.Size = new Size(183, 27);
            txtOldPass.TabIndex = 0;
            // 
            // txtNewPass
            // 
            txtNewPass.BackColor = Color.White;
            txtNewPass.ForeColor = Color.FromArgb(50, 50, 50);
            txtNewPass.Location = new Point(226, 65);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(183, 27);
            txtNewPass.TabIndex = 1;
            // 
            // btnDoiMatKhau
            // 
            btnDoiMatKhau.BackColor = Color.FromArgb(0, 123, 255);
            btnDoiMatKhau.FlatAppearance.BorderSize = 0;
            btnDoiMatKhau.FlatStyle = FlatStyle.Flat;
            btnDoiMatKhau.ForeColor = Color.White;
            btnDoiMatKhau.Location = new Point(251, 153);
            btnDoiMatKhau.Name = "btnDoiMatKhau";
            btnDoiMatKhau.Size = new Size(133, 29);
            btnDoiMatKhau.TabIndex = 2;
            btnDoiMatKhau.Text = "Đổi mật khẩu";
            btnDoiMatKhau.UseVisualStyleBackColor = false;
            btnDoiMatKhau.Click += btnDoiMatKhau_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(220, 53, 69);
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(115, 153);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 3;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 35);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 4;
            label1.Text = "Mật khẩu cũ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 72);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 5;
            label2.Text = "Mật khẩu mới:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 105);
            label3.Name = "label3";
            label3.Size = new Size(187, 20);
            label3.TabIndex = 7;
            label3.Text = "Xác nhận lại mật khẩu mới:";
            // 
            // txtNewPassAgain
            // 
            txtNewPassAgain.BackColor = Color.White;
            txtNewPassAgain.ForeColor = Color.FromArgb(50, 50, 50);
            txtNewPassAgain.Location = new Point(226, 98);
            txtNewPassAgain.Name = "txtNewPassAgain";
            txtNewPassAgain.Size = new Size(183, 27);
            txtNewPassAgain.TabIndex = 6;
            // 
            // frmDoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(475, 204);
            Controls.Add(label3);
            Controls.Add(txtNewPassAgain);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnHuy);
            Controls.Add(btnDoiMatKhau);
            Controls.Add(txtNewPass);
            Controls.Add(txtOldPass);
            Font = new Font("Segoe UI", 9F);
            Name = "frmDoiMatKhau";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đổi mật khẩu";
            Load += frmDoiMatKhau_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOldPass;
        private TextBox txtNewPass;
        private Button btnDoiMatKhau;
        private Button btnHuy;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNewPassAgain;
    }
}