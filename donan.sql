CREATE DATABASE QL_CUAHANGLINHKIENMAYTINH
use QL_CUAHANGLINHKIENMAYTINH

CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] int IDENTITY(1,1), 
	[TenNhanVien] [nvarchar](50),
	[NgaySinh] [date],
	[GioiTinh] [nvarchar](10),
	[NgayVaoLam] [date],
	[ChucVu] int,
	[DiaChi] [nvarchar](50),
	[SoDT] [varchar](11),
	CONSTRAINT PK_NHANVIEN PRIMARY KEY([MaNhanVien])
	)

CREATE TABLE [dbo].[NhaPhanPhoi](
	[MaNhaPhanPhoi] int IDENTITY(1,1), 
	[TenNhaPhanPhoi] [nvarchar](50),
	[DiaChi] [nvarchar](50),
	[SDT] [varchar](11),
	[Email] [varchar](100),
 CONSTRAINT [PK_NhaPhanPhoi] PRIMARY KEY(MaNhaPhanPhoi) )

CREATE TABLE [dbo].[SanPham](
	[MaSanPham] int IDENTITY(1,1), 
	[TenSanPham] [nvarchar](200),
	[LoaiSanPham] int,
	[HangSanXuat] int,
	[GiaBan] int,
	[TonKho] [int] NOT NULL,
	[Image] nvarchar(100)
	CONSTRAINT PK_SP PRIMARY KEY(MaSanPham))
	
CREATE TABLE [dbo].[PhieuNhap](
	[MaPhieuNhap] int IDENTITY(1,1), 
	[MaNhanVien] int, 
	[MaNhaPhanPhoi] int,
	[TongTien] int,
	[NgayNhap] [date],
	CONSTRAINT PK_PN PRIMARY KEY(MaPhieuNhap))

CREATE TABLE [dbo].[ChucVu](
	[MaChucVu] int IDENTITY(1,1), 
	[TenChucVu] [nvarchar](50),
	CONSTRAINT PK_CV PRIMARY KEY(MaChucVu))

CREATE TABLE [dbo].[LoaiSanPham](
	[MaLoaiSanPham] int IDENTITY(1,1), 
	[TenLoaiSanPham] [nvarchar](50),
	CONSTRAINT PK_LH PRIMARY KEY(MaLoaiSanPham))

CREATE TABLE [dbo].[HangSanXuat](
	[MaHangSanXuat] int IDENTITY(1,1), 
	[TenHangSanXuat] [nvarchar](50),
	CONSTRAINT PK_HSX PRIMARY KEY(MaHangSanXuat))

CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[MaPhieuNhap] int,
	[MaSanPham] int,
	[SoLuong] [int],
	[TienNhap] int,
	CONSTRAINT PK_CTPN PRIMARY KEY(MaPhieuNhap,MaSanPham))

CREATE TABLE [dbo].[KhachHang](
	MaKH int IDENTITY(1,1), 
	[Gmail] [nvarchar](50),
	[Pass] [nvarchar](50),
	[TenKhachHang] [nvarchar](50),
	[Ngaysinh] [date],
	[GioiTinh] [nvarchar](10),
	[DiaChi] [nvarchar](50),
	[SDT] [varchar](11),
	CONSTRAINT PK_KHACHHANG PRIMARY KEY(MaKH))

CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] int IDENTITY(1,1), 
	MaKH int,
	[NgayLapHoaDon] [date],
	[MaNhanVien] int, 
	CONSTRAINT PK_CTHOADON PRIMARY KEY(MaHoaDon))

CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaHoaDon] int, 
	MaSanPham int,
	giaban int,
	soluong int,
	TongTien int,

	CONSTRAINT pk_chitiethoadonsp PRIMARY KEY(MaHoaDon,MaSanPham))

CREATE TABLE [dbo].[Users](
	[TenDangNhap] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[MaNhanVien] int,
	[Quyen] [bit],
	CONSTRAINT PK_TaiKhoan PRIMARY KEY (TenDangNhap)
)
CREATE VIEW View_KH AS
SELECT        MaKH, Gmail, Pass, TenKhachHang, Ngaysinh, GioiTinh, DiaChi, SDT
FROM            dbo.KhachHang

CREATE VIEW View_CTHDSP AS
SELECT        MaHoaDon, MaSanPham, giaban, soluong, TongTien
FROM            dbo.ChiTietHoaDon

CREATE VIEW View_CTHD AS
SELECT        MaHoaDon, MaKH, NgayLapHoaDon, MaNhanVien
FROM            dbo.HoaDon

CREATE VIEW View_BieuMauGio AS
SELECT        dbo.SanPham.TenSanPham, dbo.ChiTietHoaDon.soluong, dbo.ChiTietHoaDon.giaban, dbo.HoaDon.NgayLapHoaDon, dbo.ChiTietHoaDon.MaHoaDon, dbo.ChiTietHoaDon.TongTien, dbo.KhachHang.MaKH
FROM            dbo.ChiTietHoaDon INNER JOIN
                         dbo.HoaDon ON dbo.ChiTietHoaDon.MaHoaDon = dbo.HoaDon.MaHoaDon INNER JOIN
                         dbo.SanPham ON dbo.ChiTietHoaDon.MaSanPham = dbo.SanPham.MaSanPham INNER JOIN
                         dbo.KhachHang ON dbo.HoaDon.MaKH = dbo.KhachHang.MaKH

CREATE VIEW View_GioHang AS
SELECT        dbo.ChiTietHoaDon.MaHoaDon, dbo.ChiTietHoaDon.MaSanPham, dbo.KhachHang.MaKH, dbo.SanPham.TenSanPham, dbo.LoaiSanPham.TenLoaiSanPham, dbo.ChiTietHoaDon.soluong, dbo.ChiTietHoaDon.giaban, 
                         dbo.HoaDon.NgayLapHoaDon, dbo.SanPham.Image
FROM            dbo.ChiTietHoaDon INNER JOIN
                         dbo.HoaDon ON dbo.ChiTietHoaDon.MaHoaDon = dbo.HoaDon.MaHoaDon INNER JOIN
                         dbo.SanPham ON dbo.ChiTietHoaDon.MaSanPham = dbo.SanPham.MaSanPham INNER JOIN
                         dbo.KhachHang ON dbo.HoaDon.MaKH = dbo.KhachHang.MaKH INNER JOIN
                         dbo.LoaiSanPham ON dbo.SanPham.LoaiSanPham = dbo.LoaiSanPham.MaLoaiSanPham



CREATE VIEW View_SanPham AS
SELECT MaSanPham, TenSanPham, LoaiSanPham, HangSanXuat, GiaBan, TonKho, Image
FROM     dbo.SanPham

CREATE VIEW View_NhanVien AS
SELECT MaNhanVien, TenNhanVien, NgaySinh, GioiTinh, NgayVaoLam, ChucVu, DiaChi, SoDT
FROM     dbo.NhanVien

CREATE VIEW View_HoaDon AS
SELECT MaHoaDon, MaKH, NgayLapHoaDon, MaNhanVien
FROM     dbo.HoaDon

CREATE VIEW View_PhieuNhap AS
SELECT        MaPhieuNhap, MaNhanVien, MaNhaPhanPhoi, TongTien, NgayNhap
FROM            dbo.PhieuNhap

CREATE VIEW View_CTPhieuNhap AS
SELECT        MaPhieuNhap, MaSanPham, SoLuong, TienNhap
FROM            dbo.ChiTietPhieuNhap

--KHOÁ NGOẠI
ALTER TABLE [dbo].[ChiTietHoaDon]
ADD CONSTRAINT FK_cthdsp FOREIGN KEY(MaHoaDon) REFERENCES [dbo].[HoaDon](MaHoaDon)
ALTER TABLE [dbo].[SanPham]
ADD CONSTRAINT FK_SP_LH FOREIGN KEY(LoaiSanPham) REFERENCES [dbo].[LoaiSanPham](MaLoaiSanPham)
ALTER TABLE [dbo].[SanPham]
ADD CONSTRAINT FK_SP_HSX FOREIGN KEY(HangSanXuat) REFERENCES [dbo].[HangSanXuat](MaHangSanXuat)
ALTER TABLE [dbo].[PhieuNhap]
ADD CONSTRAINT FK_PN_NCC FOREIGN KEY(MaNhaPhanPhoi) REFERENCES [dbo].[NhaPhanPhoi](MaNhaPhanPhoi)
ALTER TABLE [dbo].[PhieuNhap]
ADD CONSTRAINT FK_PN_NV FOREIGN KEY(MaNhanVien) REFERENCES [dbo].[NhanVien](MaNhanVien)
ALTER TABLE [dbo].[NhanVien]
ADD CONSTRAINT FK_NV_CV FOREIGN KEY(ChucVu) REFERENCES [dbo].[ChucVu](MaChucVu)
ALTER TABLE [dbo].[ChiTietPhieuNhap]
ADD CONSTRAINT FK_CTPN_PN FOREIGN KEY(MaPhieuNhap) REFERENCES [dbo].[PhieuNhap](MaPhieuNhap)
ALTER TABLE [dbo].[ChiTietPhieuNhap]
ADD CONSTRAINT FK_CTPN_SP FOREIGN KEY(MaSanPham) REFERENCES [dbo].[SanPham](MaSanPham)
ALTER TABLE [dbo].[ChiTietHoaDon]
ADD CONSTRAINT FK_CT_HOADON_SANPHAM FOREIGN KEY(MaSanPham) REFERENCES [dbo].[SanPham](MaSanPham)
ALTER TABLE [dbo].[HoaDon]
ADD CONSTRAINT FK_CT_HOADON_User FOREIGN KEY(MaKH) REFERENCES [dbo].[KhachHang](MaKH)
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT FK_User FOREIGN KEY(MaNhanVien) REFERENCES [dbo].[NhanVien](MaNhanVien)

-----------------------RẰNG BUỘC--------------------------------------------
ALTER TABLE [dbo].[ChiTietPhieuNhap]
ADD CONSTRAINT CK_PN CHECK(SoLuong > 0)
ALTER TABLE [dbo].[SanPham]
ADD CONSTRAINT CK_GIA CHECK(GiaBan > 0)
ALTER TABLE [dbo].[KhachHang]
ADD CONSTRAINT CK_KhachHang CHECK(GioiTinh = N'Nam' or GioiTinh = N'Nữ')
ALTER TABLE [dbo].[NhanVien]
ADD CONSTRAINT CK_NhanVien CHECK(GioiTinh = N'Nam' or GioiTinh = N'Nữ')
ALTER TABLE [dbo].[SanPham]
ADD CONSTRAINT UNI_TENSP UNIQUE(TenSanPham)
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT UNI_TENND UNIQUE(TenDangNhap)

--tự động giảm khi tạo hóa đơn
go
CREATE TRIGGER SOLUONG2
ON ChiTietHoaDon for insert
as
begin
		DECLARE @SOLUONGGIAM INT;
		SELECT @SOLUONGGIAM = SanPham.TonKho FROM SanPham, inserted WHERE inserted.MaSanPham = SanPham.MaSanPham
		IF(@SOLUONGGIAM < 1)
		BEGIN
			RAISERROR(N'HIỆN TẠI MẶT HÀNG KHÔNG ĐỦ SỐ LƯỢNG',16,1)
		END
		ELSE
		BEGIN
		UPDATE SanPham
		SET TonKho = TonKho - (SELECT soluong FROM inserted) FROM inserted,SanPham WHERE inserted.MaSanPham =SanPham.MaSanPham
		END
end

go
CREATE TRIGGER SOLUONG3
ON ChiTietHoaDon for delete
as
begin
  BEGIN
  UPDATE SanPham
  SET TonKho = TonKho + (SELECT soluong FROM deleted) FROM deleted,SanPham WHERE deleted.MaSanPham =SanPham.MaSanPham
  END
end

Go
CREATE TRIGGER SOLuongPN ON [dbo].[ChiTietPhieuNhap]
FOR delete
AS
BEGIN
	UPDATE SanPham
	SET TonKho = TonKho - (SELECT SoLuong FROM deleted)
	WHERE MaSanPham=(SELECT MaSanPham FROM deleted)
END
------update tiềnpn------
Go
CREATE TRIGGER TONGTIENPN ON [dbo].[ChiTietPhieuNhap]
FOR INSERT,UPDATE
AS
BEGIN
	UPDATE [dbo].[PhieuNhap]
	SET TongTien = (SELECT SUM(ChiTietPhieuNhap.SoLuong*ChiTietPhieuNhap.TienNhap)
						FROM ChiTietPhieuNhap,inserted
						WHERE ChiTietPhieuNhap.MaPhieuNhap = inserted.MaPhieuNhap
						GROUP BY ChiTietPhieuNhap.MaPhieuNhap)
	FROM PhieuNhap, inserted
	WHERE PhieuNhap.MaPhieuNhap = inserted.MaPhieuNhap
	------------------------
	UPDATE SanPham
	SET TonKho = TonKho + (SELECT SoLuong FROM inserted)
	WHERE MaSanPham=(SELECT MaSanPham FROM inserted)
END
--------------------------------------------------------------------------------------------
SET DATEFORMAT DMY

SET IDENTITY_INSERT [NhaPhanPhoi] ON
INSERT [dbo].[NhaPhanPhoi] ([MaNhaPhanPhoi], [TenNhaPhanPhoi], [DiaChi], [SDT], [Email]) VALUES (1, N'GearVN', N'Hồ Chí Minh', N'098674322', N'gearvn@gmail.com')
INSERT [dbo].[NhaPhanPhoi] ([MaNhaPhanPhoi], [TenNhaPhanPhoi], [DiaChi], [SDT], [Email]) VALUES (2, N'Phong vũ', N'Trung Quốc ', N'34657865434', N'pv@gmail.com')
INSERT [dbo].[NhaPhanPhoi] ([MaNhaPhanPhoi], [TenNhaPhanPhoi], [DiaChi], [SDT], [Email]) VALUES (3, N'Tin học ngôi sao', N'Việt Nam', N'34657865434', N'thns@gmail.com')
SET IDENTITY_INSERT [NhaPhanPhoi] OFF

SET IDENTITY_INSERT [LoaiSanPham] ON
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (1, N'CPU')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (2, N'GPU')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (3, N'Chuột')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (4, N'Màn hình')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (5, N'Ram')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (6, N'PC')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (7, N'Lap top')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (8, N'PSU')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (9, N'Case')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (10, N'Bàn phím')
SET IDENTITY_INSERT [LoaiSanPham] OFF

SET IDENTITY_INSERT [HangSanXuat] ON
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenHangSanXuat]) VALUES (1, N'Akko')
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenHangSanXuat]) VALUES (2, N'Samsung')
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenHangSanXuat]) VALUES (3, N'Intel')
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenHangSanXuat]) VALUES (4, N'AMD')
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenHangSanXuat]) VALUES (5, N'Acer')
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenHangSanXuat]) VALUES (6, N'Asus')
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenHangSanXuat]) VALUES (7, N'Gigabyte')
SET IDENTITY_INSERT [HangSanXuat] OFF

SET IDENTITY_INSERT [ChucVu] ON
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (1, N'Thu Ngân')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (2, N'Kế Toán')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (3, N'Admin')
SET IDENTITY_INSERT [ChucVu] OFF

SET IDENTITY_INSERT [NhanVien] ON
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam], [ChucVu], [DiaChi], [SoDT]) VALUES(1,N'Sơn sama','11/1/1999',N'Nam','16/3/2019',3,N'Việt Nam',N'0123131231');
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam], [ChucVu], [DiaChi], [SoDT]) VALUES(2,N'Huy kun','24/2/2001',N'Nam','16/4/2020',1,N'Thái Lan',N'0121231231');
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam], [ChucVu], [DiaChi], [SoDT]) VALUES(3,N'Lộc chan','14/3/1996',N'Nữ','16/1/2015',2,N'Campuchia',N'0176131231');
SET IDENTITY_INSERT [NhanVien] OFF

INSERT [dbo].[Users] ([TenDangNhap], [Password],[MaNhanVien], [Quyen]) VALUES (N'son', N'son',1, 1)
INSERT [dbo].[Users] ([TenDangNhap], [Password],[MaNhanVien], [Quyen]) VALUES (N'huy', N'huy',2, 0)

SET IDENTITY_INSERT [SanPham] ON
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaBan], [TonKho], [Image]) VALUES (1, N'Ban phim co AKKO', 10, 1, 1590000, 34,'ban-phim-co-akko-3108-v2-world-tour-tokyo.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaBan], [TonKho], [Image]) VALUES (2, N'Ban phim co Asus', 10, 6, 1590000, 100,'akko-3108-ds-matcha-red-bean-01.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaBan], [TonKho], [Image]) VALUES (3, N'Nguon GIGABYTE P1000GM', 8, 7, 4290000, 10,'PSU_GG_GP-P1000GM-5.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaBan], [TonKho], [Image]) VALUES (4, N'Intel Core i5 12600KF', 1, 3, 7990000, 10,'intelcorei5-12600k.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaBan], [TonKho], [Image]) VALUES (5, N'Laptop gaming Acer Predator Helios', 7, 5, 41990000, 10,'62709_laptop_acer_gaming_predator_helios_500_12.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaBan], [TonKho], [Image]) VALUES (6, N'Chuot Akko AG325', 3, 1, 490000, 10,'akkoag325pink.jpg')
SET IDENTITY_INSERT [SanPham] OFF

SET IDENTITY_INSERT [PhieuNhap] ON
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhanVien], [MaNhaPhanPhoi], [TongTien], [NgayNhap]) VALUES (1,1,1,NULL,'16/3/2021')
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhanVien], [MaNhaPhanPhoi], [TongTien], [NgayNhap]) VALUES (2,2,2,NULL,'16/3/2021')
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhanVien], [MaNhaPhanPhoi], [TongTien], [NgayNhap]) VALUES (3,3,3,NULL,'16/3/2021')
SET IDENTITY_INSERT [PhieuNhap] OFF

INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [TienNhap]) VALUES (1, 1, 3, 1590000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [TienNhap]) VALUES (2, 2, 43, 1590000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [TienNhap]) VALUES (3, 3, 1, 1590000.0000)

SET IDENTITY_INSERT [KhachHang] ON
INSERT [dbo].[KhachHang] ([MaKH],[Gmail], [Pass], [TenKhachHang], [Ngaysinh], [GioiTinh], [DiaChi], [SDT]) VALUES (1,'sonlaso1119@gmail.com','123',N'ĐỖ GIA HUY','25/1/2001',N'Nam',N'BÌNH TÂN TPHCM',0903714326)
INSERT [dbo].[KhachHang] ([MaKH],[Gmail], [Pass], [TenKhachHang], [Ngaysinh], [GioiTinh], [DiaChi], [SDT]) VALUES (2,'sonlaso11119@gmail.com','123',N'NGUYỄN NGỌC SƠN','16/3/2001',N'Nam',N'LONG AN ',0906533337)
INSERT [dbo].[KhachHang] ([MaKH],[Gmail], [Pass], [TenKhachHang], [Ngaysinh], [GioiTinh], [DiaChi], [SDT]) VALUES (3,'sonlaso111119@gmail.com','123',N'NGUYỄN MINH TRUNG HIẾU','12/6/2001',N'Nam',N'BÌNH DƯƠNG ',0902114326)
SET IDENTITY_INSERT [KhachHang] OFF

SET IDENTITY_INSERT [HoaDon] ON
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKH], [NgayLapHoaDon],[MaNhanVien]) VALUES (1,1,'23/05/2022',1)
SET IDENTITY_INSERT [HoaDon] OFF

INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [giaban],[soluong],[TongTien]) VALUES (1,1,1590000,1,1590000)