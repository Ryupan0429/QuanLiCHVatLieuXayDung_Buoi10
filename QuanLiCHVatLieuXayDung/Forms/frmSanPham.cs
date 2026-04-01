using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using QuanLiCHVatLieuXayDung.Data;
using QuanLiCHVatLieuXayDung.Utilities;
using Slugify;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace QuanLiCHVatLieuXayDung.Forms
{
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }

        QLCHVLXDDbContext context = new QLCHVLXDDbContext();
        bool xuLyThem = false;
        int idSanPhamHienTai;
        string imagesFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Images");

        BindingSource bindingSource = new BindingSource();

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LoadComboBoxData();
            LoadDataGrid();
        }

        private void LoadComboBoxData()
        {
            cboNhaCungCap.DataSource = context.NhaCungCap.ToList();
            cboNhaCungCap.DisplayMember = "TenNhaCungCap";
            cboNhaCungCap.ValueMember = "ID";

            cboNhaCungCapTim.DataSource = context.NhaCungCap.ToList();
            cboNhaCungCapTim.DisplayMember = "TenNhaCungCap";
            cboNhaCungCapTim.ValueMember = "ID";

            cboLoaiSanPhamTim.DataSource = context.LoaiSanPham.ToList();
            cboLoaiSanPhamTim.DisplayMember = "TenLoai";
            cboLoaiSanPhamTim.ValueMember = "ID";

            cboLoaiSanPham.DataSource = context.LoaiSanPham.ToList();
            cboLoaiSanPham.DisplayMember = "TenLoai";
            cboLoaiSanPham.ValueMember = "ID";
        }

        private void LoadDataGrid()
        {
            dataGridView.AutoGenerateColumns = false;

            List<DanhSachSanPham> sp = context.SanPham
                .Where(s => s.DaXoa == false)
                .Select(r => new DanhSachSanPham
                {
                    ID = r.ID,
                    NhaCungCapID = r.NhaCungCapID,
                    TenNhaCungCap = r.NhaCungCap.TenNhaCungCap,
                    LoaiSanPhamID = r.LoaiSanPhamID,
                    TenLoai = r.LoaiSanPham.TenLoai,
                    TenSanPham = r.TenSanPham,
                    SoLuong = r.SoLuong,
                    DonGia = r.DonGia,
                    GiaNhap = r.GiaNhap,
                    DonViTinh = r.DonViTinh,
                    MoTa = r.MoTa,
                    HinhAnh = r.HinhAnh
                }).ToList();

            bindingSource.DataSource = sp;

            cboLoaiSanPham.DataBindings.Clear();
            cboNhaCungCap.DataBindings.Clear();
            txtTenSanPham.DataBindings.Clear();
            numSoLuong.DataBindings.Clear();
            numDonGia.DataBindings.Clear();
            txtDVT.DataBindings.Clear();
            txtMoTa.DataBindings.Clear();
            picHinhAnh.DataBindings.Clear();

            cboLoaiSanPham.DataBindings.Add("SelectedValue", bindingSource, "LoaiSanPhamID", false, DataSourceUpdateMode.Never);
            cboNhaCungCap.DataBindings.Add("SelectedValue", bindingSource, "NhaCungCapID", false, DataSourceUpdateMode.Never);
            txtTenSanPham.DataBindings.Add("Text", bindingSource, "TenSanPham", false, DataSourceUpdateMode.Never);
            numSoLuong.DataBindings.Add("Value", bindingSource, "SoLuong", false, DataSourceUpdateMode.Never);
            numDonGia.DataBindings.Add("Value", bindingSource, "DonGia", false, DataSourceUpdateMode.Never);
            txtDVT.DataBindings.Add("Text", bindingSource, "DonViTinh", false, DataSourceUpdateMode.Never);
            txtMoTa.DataBindings.Add("Text", bindingSource, "MoTa", false, DataSourceUpdateMode.Never);

            Binding hinhAnh = new Binding("ImageLocation", bindingSource, "HinhAnh", true, DataSourceUpdateMode.Never);
            hinhAnh.Format += (s, e) =>
            {
                if (e.Value != null && !string.IsNullOrEmpty(e.Value.ToString()))
                {
                    e.Value = Path.Combine(imagesFolder, e.Value.ToString());
                }
            };
            picHinhAnh.DataBindings.Add(hinhAnh);

            dataGridView.DataSource = bindingSource;
        }

        public void BatTatChucNang(bool isEditing)
        {
            btnThem.Enabled = !isEditing;
            btnSua.Enabled = !isEditing;
            btnXoa.Enabled = !isEditing;

            btnLuu.Enabled = isEditing;
            btnHuyBo.Enabled = isEditing;

            txtTenSanPham.Enabled = isEditing;
            cboNhaCungCap.Enabled = isEditing;
            cboLoaiSanPham.Enabled = isEditing;
            numDonGia.Enabled = isEditing;
            numSoLuong.Enabled = isEditing;
            txtDVT.Enabled = isEditing;
            txtMoTa.Enabled = isEditing;
            picHinhAnh.Enabled = isEditing;

            btnDoiAnh.Enabled = !isEditing;
            btnLoc.Enabled = !isEditing;
            btnNhap.Enabled = !isEditing;
            btnXuat.Enabled = !isEditing;

            // Đặt lại SizeMode mặc định khi tắt/bật
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            ResetInput();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (idSanPhamHienTai == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!");
                return;
            }
            xuLyThem = false;
            BatTatChucNang(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var sp = context.SanPham.Find(idSanPhamHienTai);
                if (sp != null)
                {
                    sp.DaXoa = true;
                    context.SanPham.Update(sp);
                    context.SaveChanges();

                    MessageBox.Show("Đã xóa thành công!");
                    NhatKyHeThong.GhiNhatKy("Xóa", "Sản phẩm", $"Xóa sản phẩm ID: {idSanPhamHienTai} - {sp.TenSanPham}");
                    LoadDataGrid();
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            var spTrung = context.SanPham
                .FirstOrDefault(s => s.TenSanPham.ToLower() == txtTenSanPham.Text.Trim().ToLower());

            if (xuLyThem)
            {
                if (spTrung != null)
                {
                    if (spTrung.DaXoa == false)
                    {
                        MessageBox.Show("Tên sản phẩm này đã tồn tại! Vui lòng chọn tên khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show(
                            "Sản phẩm này đã từng tồn tại nhưng đang bị xóa.\nBạn có muốn KHÔI PHỤC lại sản phẩm này không?",
                            "Phát hiện trùng lặp",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (dr == DialogResult.Yes)
                        {
                            spTrung.DaXoa = false;
                            GanDuLieuVaoObject(spTrung);
                            context.SanPham.Update(spTrung);
                            context.SaveChanges();

                            MessageBox.Show("Đã khôi phục sản phẩm thành công!");
                            NhatKyHeThong.GhiNhatKy("Khôi phục", "Sản phẩm", $"Khôi phục sản phẩm: {txtTenSanPham.Text}");
                            LoadDataGrid();
                            BatTatChucNang(false);
                            return;
                        }
                        else
                        {
                            return;
                        }
                    }
                }

                SanPham sp = new SanPham();
                GanDuLieuVaoObject(sp);
                sp.DaXoa = false;
                context.SanPham.Add(sp);
                NhatKyHeThong.GhiNhatKy("Thêm mới", "Sản phẩm", $"Thêm sản phẩm: {txtTenSanPham.Text}");
            }
            else
            {
                if (spTrung != null && spTrung.ID != idSanPhamHienTai)
                {
                    MessageBox.Show("Tên sản phẩm mới trùng với một sản phẩm khác!", "Cảnh báo");
                    return;
                }

                SanPham sp = context.SanPham.Find(idSanPhamHienTai);
                if (sp != null)
                {
                    GanDuLieuVaoObject(sp);
                    context.SanPham.Update(sp);
                    NhatKyHeThong.GhiNhatKy("Cập nhật", "Sản phẩm", $"Cập nhật sản phẩm ID: {idSanPhamHienTai}");
                }
            }

            try
            {
                context.SaveChanges();
                MessageBox.Show("Lưu thành công!");
                xuLyThem = false;
                BatTatChucNang(false);
                LoadDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            if (dataGridView.CurrentRow != null)
            {
                dataGridView_CellClick(sender, new DataGridViewCellEventArgs(0, dataGridView.CurrentRow.Index));
                bindingSource.Position = dataGridView.CurrentRow.Index;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                idSanPhamHienTai = Convert.ToInt32(row.Cells["ID"].Value);
            }
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "HinhAnh" && e.Value != null)
            {
                string imagePath = Path.Combine(imagesFolder, e.Value.ToString());
                if (File.Exists(imagePath))
                {
                    try
                    {
                        Image image = Image.FromFile(imagePath);
                        e.Value = new Bitmap(image, 24, 24);
                    }
                    catch { }
                }
            }
        }

        private void ResetInput()
        {
            txtTenSanPham.Clear();
            numDonGia.Value = 0;
            numSoLuong.Value = 0;
            txtDVT.Clear();
            txtMoTa.Clear();
            cboNhaCungCap.SelectedIndex = -1;
            cboLoaiSanPham.SelectedIndex = -1;
            txtTenSanPham.Focus();
            picHinhAnh.ImageLocation = null;
            picHinhAnh.Image = null;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtTenSanPham.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm."); return false;
            }
            if (cboNhaCungCap.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn Nhà cung cấp."); return false;
            }
            if (cboLoaiSanPham.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn Loại sản phẩm."); return false;
            }
            if (numSoLuong.Value <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false;
            }
            if (numDonGia.Value <= 0)
            {
                MessageBox.Show("Đơn giá sản phẩm phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false;
            }
            if (picHinhAnh.Image == null && string.IsNullOrEmpty(picHinhAnh.ImageLocation))
            {
                MessageBox.Show("Vui lòng chọn hình ảnh sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false;
            }

            return true;
        }

        private void GanDuLieuVaoObject(SanPham sp)
        {
            sp.TenSanPham = txtTenSanPham.Text;
            sp.NhaCungCapID = Convert.ToInt32(cboNhaCungCap.SelectedValue);
            sp.LoaiSanPhamID = Convert.ToInt32(cboLoaiSanPham.SelectedValue);
            sp.DonGia = (int)numDonGia.Value;
            sp.GiaNhap = 0;
            sp.SoLuong = (int)numSoLuong.Value;
            sp.DonViTinh = txtDVT.Text;
            sp.MoTa = txtMoTa.Text;

            if (!string.IsNullOrEmpty(picHinhAnh.ImageLocation))
            {
                sp.HinhAnh = Path.GetFileName(picHinhAnh.ImageLocation);
            }
        }

        private void picHinhAnh_Click(object sender, EventArgs e)
        {
            if (!xuLyThem) return;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn hình ảnh sản phẩm";
            openFileDialog.Filter = "Tập tin hình ảnh|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var slugHelper = new SlugHelper();
                string fileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                string ext = Path.GetExtension(openFileDialog.FileName);
                string savedFileName = slugHelper.GenerateSlug(fileName) + ext;

                if (File.Exists(Path.Combine(imagesFolder, savedFileName)))
                {
                    MessageBox.Show("Hình ảnh sản phẩm đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string fileSavePath = Path.Combine(imagesFolder, savedFileName);
                File.Copy(openFileDialog.FileName, fileSavePath, true);

                picHinhAnh.ImageLocation = fileSavePath;
            }
        }

        private void btnXoayTrai_Click(object sender, EventArgs e)
        {
            if (picHinhAnh.Image != null)
            {
                picHinhAnh.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                picHinhAnh.Refresh();
            }
        }

        private void btnPhongTo_Click(object sender, EventArgs e)
        {
            if (picHinhAnh.Image != null)
            {
                picHinhAnh.SizeMode = PictureBoxSizeMode.CenterImage;

                int newWidth = (int)(picHinhAnh.Image.Width * 1.1);
                int newHeight = (int)(picHinhAnh.Image.Height * 1.1);

                Bitmap bmp = new Bitmap(picHinhAnh.Image, newWidth, newHeight);
                picHinhAnh.Image = bmp;
            }
        }

        private void btnThuNho_Click(object sender, EventArgs e)
        {
            if (picHinhAnh.Image != null)
            {
                picHinhAnh.SizeMode = PictureBoxSizeMode.CenterImage;

                int newWidth = (int)(picHinhAnh.Image.Width / 1.1);
                int newHeight = (int)(picHinhAnh.Image.Height / 1.1);

                if (newWidth > 0 && newHeight > 0)
                {
                    Bitmap bmp = new Bitmap(picHinhAnh.Image, newWidth, newHeight);
                    picHinhAnh.Image = bmp;
                }
            }
        }

        private void btnDoiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Cập nhật hình ảnh sản phẩm";
            openFileDialog.Filter = "Tập tin hình ảnh|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var slugHelper = new SlugHelper();
                string fileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                string ext = Path.GetExtension(openFileDialog.FileName);
                string savedFileName = slugHelper.GenerateSlug(fileName) + ext;

                if (File.Exists(Path.Combine(imagesFolder, savedFileName)))
                {
                    MessageBox.Show("Hình ảnh sản phẩm đã tồn tại trong thư mục!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string fileSavePath = Path.Combine(imagesFolder, savedFileName);
                File.Copy(openFileDialog.FileName, fileSavePath, true);

                SanPham sp = context.SanPham.Find(idSanPhamHienTai);
                if (sp != null)
                {
                    sp.HinhAnh = savedFileName;
                    context.SanPham.Update(sp);
                    context.SaveChanges();

                    MessageBox.Show("Đổi ảnh thành công!");
                    LoadDataGrid();
                }
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu từ tập tin Excel";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        IXLWorksheet worksheet = workbook.Worksheet(1);
                        bool firstRow = true;
                        string readRange = "1:1";
                        foreach (IXLRow row in worksheet.RowsUsed())
                        {
                            if (firstRow)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRange))
                                    table.Columns.Add(cell.Value.ToString());
                                firstRow = false;
                            }
                            else
                            {
                                table.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    table.Rows[table.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }
                        if (table.Rows.Count > 0)
                        {
                            foreach (DataRow r in table.Rows)
                            {
                                SanPham sp = new SanPham();
                                sp.NhaCungCapID = Convert.ToInt32(r["NhaCungCapID"]);
                                sp.LoaiSanPhamID = Convert.ToInt32(r["LoaiSanPhamID"]);
                                sp.TenSanPham = r["TenSanPham"].ToString();
                                sp.DonGia = Convert.ToInt32(r["DonGia"]);
                                sp.GiaNhap = Convert.ToInt32(r["GiaNhap"]);
                                sp.DonViTinh = r["DonViTinh"].ToString();
                                sp.SoLuong = Convert.ToInt32(r["SoLuong"]);
                                sp.HinhAnh = r["HinhAnh"].ToString();
                                sp.MoTa = r["MoTa"].ToString();
                                sp.DaXoa = false;
                                context.SanPham.Add(sp);
                            }
                            context.SaveChanges();
                            NhatKyHeThong.GhiNhatKy("Nhập Excel", "Sản phẩm", "Nhập " + table.Rows.Count + " sản phẩm từ file " + openFileDialog.FileName);
                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmSanPham_Load(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "SanPham_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[10] {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("NhaCungCapID", typeof(int)),
                        new DataColumn("LoaiSanPhamID", typeof(int)),
                        new DataColumn("TenSanPham", typeof(string)),
                        new DataColumn("DonGia", typeof(int)),
                        new DataColumn("GiaNhap", typeof(int)),
                        new DataColumn("DonViTinh", typeof(string)),
                        new DataColumn("SoLuong", typeof(int)),
                        new DataColumn("HinhAnh", typeof(string)),
                        new DataColumn("MoTa", typeof(string))
                    });

                    var sanPham = context.SanPham.ToList();
                    if (sanPham != null)
                    {
                        foreach (var p in sanPham)
                            table.Rows.Add(p.ID, p.NhaCungCapID, p.LoaiSanPhamID, p.TenSanPham, p.DonGia, p.GiaNhap, p.DonViTinh, p.SoLuong, p.HinhAnh, p.MoTa);
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "SanPham");
                        sheet.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);
                        NhatKyHeThong.GhiNhatKy("Xuất Excel", "Sản phẩm", $"Xuất danh sách ra file {saveFileDialog.FileName}");
                        MessageBox.Show("Đã xuất dữ liệu ra tập tin Excel thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            int nhaCungCapID = Convert.ToInt32(cboNhaCungCapTim.SelectedValue);
            int loaiSanPhamID = Convert.ToInt32(cboLoaiSanPhamTim.SelectedValue);
            if (
                (nhaCungCapID > 0 && loaiSanPhamID > 0) ||
                (nhaCungCapID > 0 && loaiSanPhamID == 0) ||
                (nhaCungCapID == 0 && loaiSanPhamID > 0)
                )
            {

                var sp = context.SanPham
                    .Where(s => s.DaXoa == false &&
                        (nhaCungCapID == 0 || s.NhaCungCapID == nhaCungCapID) &&
                        (loaiSanPhamID == 0 || s.LoaiSanPhamID == loaiSanPhamID))
                    .Select(r => new DanhSachSanPham
                    {
                        ID = r.ID,
                        NhaCungCapID = r.NhaCungCapID,
                        TenNhaCungCap = r.NhaCungCap.TenNhaCungCap,
                        LoaiSanPhamID = r.LoaiSanPhamID,
                        TenLoai = r.LoaiSanPham.TenLoai,
                        TenSanPham = r.TenSanPham,
                        SoLuong = r.SoLuong,
                        DonGia = r.DonGia,
                        GiaNhap = r.GiaNhap,
                        DonViTinh = r.DonViTinh,
                        MoTa = r.MoTa,
                        HinhAnh = r.HinhAnh
                    }).ToList();
            }
        }

        private void btnHuyLoc_Click(object sender, EventArgs e)
        {
            cboNhaCungCapTim.SelectedIndex = -1;
            cboLoaiSanPhamTim.SelectedIndex = -1;
            LoadDataGrid();
        }
    }
}