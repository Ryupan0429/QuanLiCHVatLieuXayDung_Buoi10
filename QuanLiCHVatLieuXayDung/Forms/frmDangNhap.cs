using QuanLiCHVatLieuXayDung.Data;
using QuanLiCHVatLieuXayDung.Utilities;
using System;
using System.Linq;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;

namespace QuanLiCHVatLieuXayDung.Forms
{
    // Form đăng nhập: xử lý giao diện đăng nhập (hiển thị, bắt phím Enter, hủy)
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        // Bắt sự kiện Enter trên textbox mật khẩu để kích hoạt đăng nhập
        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }
    }
}