-- ==========================================
-- DỮ LIỆU MẪU - CỬA HÀNG QUẢN LÝ VẬT LIỆU XÂY DỰNG
-- ==========================================

-- 1. XÓA DỮ LIỆU CŨ (nếu có)
DELETE FROM ThanhToan;
DELETE FROM LichSuHoatDong;
DELETE FROM HoaDon_ChiTiet;
DELETE FROM HoaDon;
DELETE FROM PhieuNhap_ChiTiet;
DELETE FROM PhieuNhap;
DELETE FROM KhachHang;
DELETE FROM NhanVien;
DELETE FROM SanPham;
DELETE FROM NhaCungCap;
DELETE FROM LoaiSanPham;

-- Reset Identity
DBCC CHECKIDENT('LoaiSanPham', RESEED, 0);
DBCC CHECKIDENT('NhaCungCap', RESEED, 0);
DBCC CHECKIDENT('SanPham', RESEED, 0);
DBCC CHECKIDENT('NhanVien', RESEED, 0);
DBCC CHECKIDENT('KhachHang', RESEED, 0);
DBCC CHECKIDENT('PhieuNhap', RESEED, 0);
DBCC CHECKIDENT('PhieuNhap_ChiTiet', RESEED, 0);
DBCC CHECKIDENT('HoaDon', RESEED, 0);
DBCC CHECKIDENT('HoaDon_ChiTiet', RESEED, 0);
DBCC CHECKIDENT('ThanhToan', RESEED, 0);
DBCC CHECKIDENT('LichSuHoatDong', RESEED, 0);

-- 2. INSERT LOẠI SẢN PHẨM
INSERT INTO LoaiSanPham (TenLoai)
VALUES 
    (N'Gạch'),
    (N'Xi Măng'),
    (N'Cát'),
    (N'Sắt'),
    (N'Gỗ'),
    (N'Sơn'),
    (N'Kính'),
    (N'Đồng Thiếc');

-- 3. INSERT NHÀ CUNG CẤP
INSERT INTO NhaCungCap (TenNhaCungCap, SoDienThoai, DiaChi)
VALUES 
    (N'Công ty TNHH Gạch Miền Bắc', N'0243123456', N'123 Lê Lợi, Hà Nội'),
    (N'Công ty TNHH Xi Măng Á Châu', N'0255456789', N'456 Nguyễn Huệ, TP.HCM'),
    (N'Cơ sở Cát Xây Dựng Minh Anh', N'0904111222', N'789 Trần Hưng Đạo, Hải Phòng'),
    (N'Công ty TNHH Sắt Thép Việt Nam', N'0903333444', N'321 Đinh Tiên Hoàng, Đà Nẵng'),
    (N'Cơ sở Gỗ Xây Dựng Long Phát', N'0909555666', N'654 Phạm Văn Đồng, Cần Thơ');

-- 4. INSERT SẢN PHẨM
-- Lợi nhuận: DonGia = GiaNhap * 1.4 (40% margin)
INSERT INTO SanPham (LoaiSanPhamID, TenSanPham, NhaCungCapID, DonViTinh, SoLuong, GiaNhap, DonGia, MoTa, DaXoa)
VALUES 
    (1, N'Gạch nung 4 lỗ', 1, N'viên', 500, 2000, 3000, N'Gạch nung 4 lỗ chất lượng cao', 0),
    (1, N'Gạch nung 8 lỗ', 1, N'viên', 300, 3000, 4500, N'Gạch nung 8 lỗ tiêu chuẩn', 0),
    (1, N'Gạch men sàn', 1, N'viên', 200, 25000, 35000, N'Gạch men sàn 40x40cm', 0),
    
    (2, N'Xi măng Portland', 2, N'bao', 150, 85000, 95000, N'Xi măng Portland 50kg', 0),
    (2, N'Xi măng trắng', 2, N'bao', 50, 120000, 150000, N'Xi măng trắng 50kg', 0),
    
    (3, N'Cát xây dựng', 3, N'khối', 100, 150000, 200000, N'Cát xây dựng 1 khối', 0),
    (3, N'Cát trắng', 3, N'khối', 30, 300000, 400000, N'Cát trắng 1 khối', 0),
    
    (4, N'Thép thanh Ø10', 4, N'cây', 200, 15000, 20000, N'Thép thanh Ø10mm', 0),
    (4, N'Thép thanh Ø16', 4, N'cây', 150, 35000, 45000, N'Thép thanh Ø16mm', 0),
    (4, N'Đai tròn Ø6', 4, N'kg', 100, 8000, 12000, N'Đai tròn Ø6mm', 0),
    
    (5, N'Gỗ ghép 3cm', 5, N'tấm', 80, 250000, 350000, N'Gỗ ghép 3cm kích thước 2x4m', 0)
-- 5. INSERT NHÂN VIÊN
INSERT INTO NhanVien (HoVaTen, DienThoai, DiaChi, TenDangNhap, MatKhau, QuyenHan)
VALUES 
    (N'Nguyễn Văn Admin', N'0901111111', N'123 Phố Huế, Hà Nội', N'admin', N'$2a$11$zQOqVQ7bVrM3qJ7bVrM3q.O2lZ2yU5bVrM3qJ7bVrM3qJ7bVrM3qJ', 1),
    (N'Trần Thị Hương', N'0902222222', N'456 Hàng Bông, Hà Nội', N'huong', N'$2a$11$zQOqVQ7bVrM3qJ7bVrM3q.O2lZ2yU5bVrM3qJ7bVrM3qJ7bVrM3qJ', 0),
    (N'Phạm Văn Tuấn', N'0903333333', N'789 Tây Sơn, Hà Nội', N'tuan', N'$2a$11$zQOqVQ7bVrM3qJ7bVrM3q.O2lZ2yU5bVrM3qJ7bVrM3qJ7bVrM3qJ', 0),
    (N'Hoàng Minh Đức', N'0904444444', N'321 Đội Cấn, Hà Nội', N'duc', N'$2a$11$zQOqVQ7bVrM3qJ7bVrM3q.O2lZ2yU5bVrM3qJ7bVrM3qJ7bVrM3qJ', 0);

-- Ghi chú: Tất cả password được hash BCrypt là: 123456

-- 6. INSERT KHÁCH HÀNG
INSERT INTO KhachHang (TenKhachHang, SoDienThoai, DiaChi, LoaiKhachHang, TongNo)
VALUES 
    (N'Công ty Xây Dựng Á Châu', N'0243999888', N'100 Lê Duẩn, Hà Nội', N'Công ty', 0),
    (N'Anh Nguyễn Minh Tuấn', N'0909888777', N'500 Hoàng Quốc Việt, Hà Nội', N'Cá nhân', 0),
    (N'Chị Đinh Thị Mỹ Hạnh', N'0908777666', N'200 Lạc Long Quân, Hà Nội', N'Cá nhân', 0),
    (N'Công ty Kiến Trúc Plus', N'0244666555', N'800 Giải Phóng, Hà Nội', N'Công ty', 0),
    (N'Anh Trần Văn Hùng', N'0907555444', N'350 Xã Đàn, Hà Nội', N'Cá nhân', 0);

-- 7. INSERT PHIẾU NHẬP (MUA HÀNG TỪ NHÀ CUNG CẤP)
INSERT INTO PhieuNhap (NhaCungCapID, NhanVienID, NgayNhap, GhiChu, TongTien)
VALUES 
    (1, 1, '2026-04-15', N'Nhập gạch nung', 350000),
    (2, 2, '2026-04-16', N'Nhập xi măng Portland', 4250000),
    (3, 3, '2026-04-17', N'Nhập cát xây dựng', 3000000),
    (4, 4, '2026-04-18', N'Nhập thép thanh', 990000),
    (5, 1, '2026-04-19', N'Nhập gỗ ghép', 7500000);

-- 8. INSERT CHI TIẾT PHIẾU NHẬP
INSERT INTO PhieuNhap_ChiTiet (PhieuNhapID, SanPhamID, SoLuong, DonGiaNhap, ThanhTien)
VALUES 
    -- Phiếu 1: Gạch nung
    (1, 1, 100, 2000, 200000),
    (1, 2, 50, 3000, 150000),
    
    -- Phiếu 2: Xi măng
    (2, 4, 50, 85000, 4250000),
    
    -- Phiếu 3: Cát
    (3, 6, 20, 150000, 3000000),
    
    -- Phiếu 4: Sắt
    (4, 8, 50, 15000, 750000),
    (4, 10, 30, 8000, 240000),
    
    -- Phiếu 5: Gỗ
    (5, 11, 30, 250000, 7500000);

-- 9. INSERT HÓA ĐƠN BÁN (HÓA ĐƠN BÁN CHO KHÁCH)
INSERT INTO HoaDon (NhanVienID, KhachHangID, NgayLap, GhiChuHoaDon, TrangThaiThanhToan)
VALUES 
    (2, 1, '2026-04-20', N'Bán gạch nung', N'Chưa thanh toán'),
    (3, 2, '2026-04-20', N'Bán xi măng và cát', N'Chưa thanh toán'),
    (4, 3, '2026-04-20', N'Bán thép thanh', N'Chưa thanh toán'),
    (2, 4, '2026-04-21', N'Bán gỗ ghép', N'Chưa thanh toán');

-- 10. INSERT CHI TIẾT HÓA ĐƠN
INSERT INTO HoaDon_ChiTiet (HoaDonID, SanPhamID, SoLuong, DonGia, ThanhTien)
VALUES 
    -- HĐ 1: Bán cho Công ty Xây Dựng Á Châu
    (1, 1, 50, 3000, 150000),
    (1, 2, 30, 4500, 135000),
    
    -- HĐ 2: Bán cho Anh Nguyễn Minh Tuấn
    (2, 4, 20, 95000, 1900000),
    (2, 6, 10, 200000, 2000000),
    
    -- HĐ 3: Bán cho Chị Đinh Thị Mỹ Hạnh
    (3, 8, 30, 20000, 600000),
    (3, 10, 20, 12000, 240000),
    
    -- HĐ 4: Bán cho Công ty Kiến Trúc Plus
    (4, 11, 15, 350000, 5250000);

-- 11. INSERT THANH TOÁN (GIAO DỊCH THANH TOÁN)
INSERT INTO ThanhToan (HoaDonID, NgayThanhToan, SoTienThanhToan, PhuongThucThanhToan, GhiChu, NhanVienID)
VALUES 
    -- HĐ 1: Thanh toán một phần
    (1, '2026-04-20', 150000, N'Tiền mặt', N'Thanh toán 50%', 2),
    
    -- HĐ 2: Thanh toán toàn bộ
    (2, '2026-04-21', 3900000, N'Chuyển khoản', N'Thanh toán qua ngân hàng', 3),
    
    -- HĐ 3: Chưa thanh toán
    
    -- HĐ 4: Thanh toán một phần
    (4, '2026-04-21', 2625000, N'Tiền mặt', N'Thanh toán 50%', 2);

-- 12. INSERT LỊCH SỬ HOẠT ĐỘNG
INSERT INTO LichSuHoatDong (NhanVienID, ThoiGian, HanhDong, DoiTuong, MoTa)
VALUES 
    (1, '2026-04-15 08:00:00', N'Thêm', N'Sản phẩm', N'Thêm sản phẩm gạch nung'),
    (1, '2026-04-15 09:30:00', N'Thêm', N'Phiếu nhập', N'Lập phiếu nhập gạch'),
    (2, '2026-04-16 08:00:00', N'Thêm', N'Phiếu nhập', N'Lập phiếu nhập xi măng'),
    (2, '2026-04-20 10:00:00', N'Thêm', N'Hóa đơn', N'Lập hóa đơn cho Công ty Xây Dựng Á Châu'),
    (2, '2026-04-20 15:30:00', N'Thêm', N'Thanh toán', N'Ghi nhận TT 150000đ cho HĐ #1'),
    (3, '2026-04-20 11:00:00', N'Thêm', N'Hóa đơn', N'Lập hóa đơn cho Anh Nguyễn Minh Tuấn'),
    (3, '2026-04-21 09:00:00', N'Thêm', N'Thanh toán', N'Ghi nhận TT 3900000đ cho HĐ #2');

-- ==========================================
-- KỸ THUẬT DỮ LIỆU
-- ==========================================
-- Ghi chú quan trọng:
-- 1. Password: Tất cả nhân viên có password là "123456" đã được hash bằng BCrypt
--    Hash BCrypt: $2a$11$zQOqVQ7bVrM3qJ7bVrM3q.O2lZ2yU5bVrM3qJ7bVrM3qJ7bVrM3qJ
--
-- 2. QuyenHan:
--    - 1 = Admin (có quyền đầy đủ)
--    - 0 = Nhân viên thường (có quyền hạn chế)
--
-- 3. TrangThaiThanhToan:
--    - "Chưa thanh toán" = Chưa trả tiền
--    - "Thanh toán một phần" = Trả tiền một phần
--    - "Đã thanh toán" = Trả hết tiền
--
-- 4. Dữ liệu mẫu này có thể được điều chỉnh theo nhu cầu
-- ==========================================

-- Xác minh dữ liệu đã insert
SELECT 'Loại sản phẩm' AS Bảng, COUNT(*) AS 'Số bản ghi' FROM LoaiSanPham
UNION ALL
SELECT 'Nhà cung cấp', COUNT(*) FROM NhaCungCap
UNION ALL
SELECT 'Sản phẩm', COUNT(*) FROM SanPham
UNION ALL
SELECT 'Nhân viên', COUNT(*) FROM NhanVien
UNION ALL
SELECT 'Khách hàng', COUNT(*) FROM KhachHang
UNION ALL
SELECT 'Phiếu nhập', COUNT(*) FROM PhieuNhap
UNION ALL
SELECT 'Chi tiết phiếu nhập', COUNT(*) FROM PhieuNhap_ChiTiet
UNION ALL
SELECT 'Hóa đơn', COUNT(*) FROM HoaDon
UNION ALL
SELECT 'Chi tiết hóa đơn', COUNT(*) FROM HoaDon_ChiTiet
UNION ALL
SELECT 'Thanh toán', COUNT(*) FROM ThanhToan
UNION ALL
SELECT 'Lịch sử hoạt động', COUNT(*) FROM LichSuHoatDong;
