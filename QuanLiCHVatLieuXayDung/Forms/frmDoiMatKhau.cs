using QuanLiCHVatLieuXayDung.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiCHVatLieuXayDung.Forms
{
    public partial class frmDoiMatKhau : Form
    {
        String tenDangNhap;
        QLCHVLXDDbContext context = new QLCHVLXDDbContext();
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        public frmDoiMatKhau(string tenDangNhap) : this()
        {
            this.tenDangNhap = tenDangNhap;
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtOldPass.Text) || string.IsNullOrWhiteSpace(txtNewPass.Text) || string.IsNullOrWhiteSpace(txtNewPassAgain.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                using (var context = new QLCHVLXDDbContext())
                {
                    var user = context.NhanVien.FirstOrDefault(nv => nv.TenDangNhap == tenDangNhap);
                    if (user == null)
                    {
                        MessageBox.Show("Người dùng không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (!BCrypt.Net.BCrypt.Verify(txtOldPass.Text, user.MatKhau))
                    {
                        MessageBox.Show("Mật khẩu cũ không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (txtNewPass.Text != txtNewPassAgain.Text)
                    {
                        MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    user.MatKhau = BCrypt.Net.BCrypt.HashPassword(txtNewPass.Text);
                    context.SaveChanges();
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }


        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
