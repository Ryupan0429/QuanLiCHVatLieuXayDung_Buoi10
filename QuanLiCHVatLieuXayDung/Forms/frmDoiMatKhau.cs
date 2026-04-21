using QuanLiCHVatLieuXayDung.Data;
using QuanLiCHVatLieuXayDung.Utilities;
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
        // Lưu tên đăng nhập để xác định người dùng đang đổi mật khẩu
        String tenDangNhap;
        QLCHVLXDDbContext context = new QLCHVLXDDbContext();
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        public frmDoiMatKhau(string tenDangNhap) : this()
        {
            // Khởi tạo form kèm tên đăng nhập của người dùng
            this.tenDangNhap = tenDangNhap;
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
        }

        // Xử lý khi người dùng bấm nút Đổi mật khẩu
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            // Kiểm tra input bắt buộc: các trường mật khẩu không được để trống
            if (string.IsNullOrWhiteSpace(txtOldPass.Text) || string.IsNullOrWhiteSpace(txtNewPass.Text) || string.IsNullOrWhiteSpace(txtNewPassAgain.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                using (var context = new QLCHVLXDDbContext())
                {
                    // Tìm user theo tên đăng nhập
                    var user = context.NhanVien.FirstOrDefault(nv => nv.TenDangNhap == tenDangNhap);
                    if (user == null)
                    {
                        MessageBox.Show("Người dùng không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Kiểm tra mật khẩu cũ bằng BCrypt
                    if (!BCrypt.Net.BCrypt.Verify(txtOldPass.Text, user.MatKhau))
                    {
                        MessageBox.Show("Mật khẩu cũ không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Kiểm tra mật khẩu mới và xác nhận mật khẩu có khớp không
                    if (txtNewPass.Text != txtNewPassAgain.Text)
                    {
                        MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Băm mật khẩu mới và lưu vào DB, sau đó ghi nhật ký hành động
                    user.MatKhau = BCrypt.Net.BCrypt.HashPassword(txtNewPass.Text);
                    context.SaveChanges();
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NhatKyHeThong.GhiNhatKy("Đổi mật khẩu", "Hệ thống", $"Tài khoản {tenDangNhap} đổi mật khẩu");
                    this.Close();
                }
            }


        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Đóng form khi hủy
            this.Close();
        }
    }
}
