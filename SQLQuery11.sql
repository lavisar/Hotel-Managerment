-- *******************************************************
----- Nhớ tạo trước 1 DB tên: PMQLKS để thống nhất -------
-- *******************************************************

CREATE DATABASE PMQLKS

USE [PMQLKS]
GO

-- TẠO BẢNG KHÁCH HÀNG
CREATE TABLE [dbo].[KhachHang](
	[KhachHangID] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[QuocTich] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[KhachHangID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO

-- CHÈN DỮ LIỆU KHÁCH HÀNG ( cỡ 14 khách )
SET IDENTITY_INSERT [dbo].[KhachHang] ON
INSERT [dbo].[KhachHang] ([KhachHangID], [TenKH], [QuocTich]) VALUES (1, N'Lavi', N'Việt Nam')
INSERT [dbo].[KhachHang] ([KhachHangID], [TenKH], [QuocTich]) VALUES (2, N'Quỳnh Hương', N'Việt Nam')
INSERT [dbo].[KhachHang] ([KhachHangID], [TenKH], [QuocTich]) VALUES (3, N'Yến Linh', N'Việt Nam')
INSERT [dbo].[KhachHang] ([KhachHangID], [TenKH], [QuocTich]) VALUES (4, N'Kim Hằng', N'Việt Nam')
INSERT [dbo].[KhachHang] ([KhachHangID], [TenKH], [QuocTich]) VALUES (5, N'Quách Hải', N'Việt Nam')
INSERT [dbo].[KhachHang] ([KhachHangID], [TenKH], [QuocTich]) VALUES (6, N'Mai Phương', N'Nhật Bản')
INSERT [dbo].[KhachHang] ([KhachHangID], [TenKH], [QuocTich]) VALUES (7, N'Linh Trung', N'Trung Quốc')
INSERT [dbo].[KhachHang] ([KhachHangID], [TenKH], [QuocTich]) VALUES (8, N'Văn Hội', N'Newzealand')
INSERT [dbo].[KhachHang] ([KhachHangID], [TenKH], [QuocTich]) VALUES (9, N'Tiên Nguyễn 00', N'Hàn')
INSERT [dbo].[KhachHang] ([KhachHangID], [TenKH], [QuocTich]) VALUES (10, N'Đồng Phương', N'Châu Phi')
INSERT [dbo].[KhachHang] ([KhachHangID], [TenKH], [QuocTich]) VALUES (11, N'Đồng Anh', N'Congo')
INSERT [dbo].[KhachHang] ([KhachHangID], [TenKH], [QuocTich]) VALUES (12, N'Đạt Nguyễn', N'Anh')
INSERT [dbo].[KhachHang] ([KhachHangID], [TenKH], [QuocTich]) VALUES (13, N'Mai Linh', N'Havana')
INSERT [dbo].[KhachHang] ([KhachHangID], [TenKH], [QuocTich]) VALUES (14, N'Lam Lam', N'Italia')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--TẠO BẢNG NHÂN VIÊN
CREATE TABLE [dbo].[NhanVien](
	[NhanVienID] [int] IDENTITY(1,1) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[PathImage] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[NhanVienID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

-- CHÈN DỮ LIỆU NHÂN VIÊN
SET IDENTITY_INSERT [dbo].[NhanVien] ON
INSERT [dbo].[NhanVien] ([NhanVienID], [TenNV], [PathImage]) VALUES (1, N'Nguyễn Văn A', N'iconUser.png')
INSERT [dbo].[NhanVien] ([NhanVienID], [TenNV], [PathImage]) VALUES (2, N'Nguyễn Văn B', N'iconUser.png')
INSERT [dbo].[NhanVien] ([NhanVienID], [TenNV], [PathImage]) VALUES (3, N'Nguyễn Thị C', N'iconUser.png')
INSERT [dbo].[NhanVien] ([NhanVienID], [TenNV], [PathImage]) VALUES (8, N'Nguyễn Văn D', N'iconUser.png')
INSERT [dbo].[NhanVien] ([NhanVienID], [TenNV], [PathImage]) VALUES (9, N'Văn B', NULL)
INSERT [dbo].[NhanVien] ([NhanVienID], [TenNV], [PathImage]) VALUES (11, N'Văn C', NULL)
SET IDENTITY_INSERT [dbo].[NhanVien] OFF

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

-- TẠO BẢNG ĐĂNG NHẬP
CREATE TABLE [dbo].[MatKhau](
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO

-- CHÈN DỮ LIỆU
INSERT [dbo].[MatKhau] ([username], [password]) VALUES (N'lavi', N'123')
INSERT [dbo].[MatKhau] ([username], [password]) VALUES (N'quynhhng15', N'lyly123')
INSERT [dbo].[MatKhau] ([username], [password]) VALUES (N'admin', N'123')


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

-- TẠO BẢNG LOẠI PHÒNG
CREATE TABLE [dbo].[LoaiPhong](
	[LoaiPhongID] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[LoaiPhongID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO

-- CHÈN DỮ LIỆU LOẠI PHÒNG 
SET IDENTITY_INSERT [dbo].[LoaiPhong] ON
INSERT [dbo].[LoaiPhong] ([LoaiPhongID], [TenLoai]) VALUES (1, N'Standard') 
INSERT [dbo].[LoaiPhong] ([LoaiPhongID], [TenLoai]) VALUES (2, N'Deluxe')  
INSERT [dbo].[LoaiPhong] ([LoaiPhongID], [TenLoai]) VALUES (3, N'Superior') 
SET IDENTITY_INSERT [dbo].[LoaiPhong] OFF

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- TẠO BẢNG NGƯỜI ĐẶT PHÒNG
CREATE TABLE [dbo].[Booking](
	[BookingID] [int] IDENTITY(1,1) NOT NULL,
	[TenBooking] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[BookingID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

-- CHÈN DỮ LIỆU
SET IDENTITY_INSERT [dbo].[Booking] ON
INSERT [dbo].[Booking] ([BookingID], [TenBooking]) VALUES (1, N'Agoda')
INSERT [dbo].[Booking] ([BookingID], [TenBooking]) VALUES (2, N'Travel Loka')
INSERT [dbo].[Booking] ([BookingID], [TenBooking]) VALUES (3, N'Booking.com')
INSERT [dbo].[Booking] ([BookingID], [TenBooking]) VALUES (4, N'Expedia')
INSERT [dbo].[Booking] ([BookingID], [TenBooking]) VALUES (5, N'AirBnB')
INSERT [dbo].[Booking] ([BookingID], [TenBooking]) VALUES (6, N'Khách Tự Đến')
INSERT [dbo].[Booking] ([BookingID], [TenBooking]) VALUES (7, N'Khách Đối Tác')
SET IDENTITY_INSERT [dbo].[Booking] OFF

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--TẠO BẢNG DỊCH VỤ
CREATE TABLE [dbo].[DichVu](
	[DichVuID] [int] IDENTITY(1,1) NOT NULL,
	[TenDV] [nvarchar](50) NULL,
	[GiaDV] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[DichVuID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

--CHÈN DỮ LIỆU BẢNG DỊCH VỤ
SET IDENTITY_INSERT [dbo].[DichVu] ON
INSERT [dbo].[DichVu] ([DichVuID], [TenDV], [GiaDV]) VALUES (1, N'fanta', 30000)
INSERT [dbo].[DichVu] ([DichVuID], [TenDV], [GiaDV]) VALUES (2, N'trà xanh', 15000)
INSERT [dbo].[DichVu] ([DichVuID], [TenDV], [GiaDV]) VALUES (3, N'bò cụng', 15000)
INSERT [dbo].[DichVu] ([DichVuID], [TenDV], [GiaDV]) VALUES (7, N'tour củ chi', 485000)
SET IDENTITY_INSERT [dbo].[DichVu] OFF

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- TẠO BẢNG VẬT TƯ
CREATE TABLE [dbo].[VatTu](
	[VatTuID] [int] IDENTITY(1,1) NOT NULL,
	[TenVT] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[VatTuID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

-- CHÈN DỮ LIỆU
SET IDENTITY_INSERT [dbo].[VatTu] ON
INSERT [dbo].[VatTu] ([VatTuID], [TenVT]) VALUES (3, N'Bàn Ủi')
INSERT [dbo].[VatTu] ([VatTuID], [TenVT]) VALUES (4, N'Dép')
INSERT [dbo].[VatTu] ([VatTuID], [TenVT]) VALUES (5, N'Bàn Gỗ')
INSERT [dbo].[VatTu] ([VatTuID], [TenVT]) VALUES (11, N'Thùng Rác')
INSERT [dbo].[VatTu] ([VatTuID], [TenVT]) VALUES (14, N'Bàn Ủi')
INSERT [dbo].[VatTu] ([VatTuID], [TenVT]) VALUES (17, N'Tivi')
INSERT [dbo].[VatTu] ([VatTuID], [TenVT]) VALUES (18, N'tủ lạnh')
INSERT [dbo].[VatTu] ([VatTuID], [TenVT]) VALUES (19, N'Tách Trà')
SET IDENTITY_INSERT [dbo].[VatTu] OFF

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- TẠO BẢNG PHÒNG
CREATE TABLE [dbo].[Phong](
	[PhongID] [int] IDENTITY(1,1) NOT NULL,
	[LoaiPhongID] [int] NULL,
	[GiaPhong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PhongID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

-- CHÈN DỮ LIỆU
SET IDENTITY_INSERT [dbo].[Phong] ON
INSERT [dbo].[Phong] ([PhongID], [LoaiPhongID], [GiaPhong]) VALUES (1, 1, 500000)
INSERT [dbo].[Phong] ([PhongID], [LoaiPhongID], [GiaPhong]) VALUES (2, 1, 500000)
INSERT [dbo].[Phong] ([PhongID], [LoaiPhongID], [GiaPhong]) VALUES (3, 1, 500000)
INSERT [dbo].[Phong] ([PhongID], [LoaiPhongID], [GiaPhong]) VALUES (4, 3, 700000)
INSERT [dbo].[Phong] ([PhongID], [LoaiPhongID], [GiaPhong]) VALUES (5, 3, 700000)
INSERT [dbo].[Phong] ([PhongID], [LoaiPhongID], [GiaPhong]) VALUES (6, 2, 1000000)
INSERT [dbo].[Phong] ([PhongID], [LoaiPhongID], [GiaPhong]) VALUES (7, 2, 1000000)
INSERT [dbo].[Phong] ([PhongID], [LoaiPhongID], [GiaPhong]) VALUES (8, 2, 1000000)
SET IDENTITY_INSERT [dbo].[Phong] OFF

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

-- TẠO BẢNG LỊCH LÀM VIỆC
CREATE TABLE [dbo].[LichLamViec](
	[LichLamViecID] [int] IDENTITY(1,1) NOT NULL,
	[NhanVienID] [int] NULL,
	[Ca] [nvarchar](10) NULL,
	[Ngay] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[LichLamViecID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO

-- CHÈN DỮ LIỆU
SET IDENTITY_INSERT [dbo].[LichLamViec] ON
INSERT [dbo].[LichLamViec] ([LichLamViecID], [NhanVienID], [Ca], [Ngay]) VALUES (1, 1, N'sáng', N'10/10/2022')
INSERT [dbo].[LichLamViec] ([LichLamViecID], [NhanVienID], [Ca], [Ngay]) VALUES (2, 2, N'trưa', N'10/10/2022')
INSERT [dbo].[LichLamViec] ([LichLamViecID], [NhanVienID], [Ca], [Ngay]) VALUES (3, 3, N'tối', N'10/10/2022')
INSERT [dbo].[LichLamViec] ([LichLamViecID], [NhanVienID], [Ca], [Ngay]) VALUES (6, 8, N'sáng', N'11/10/2022')
INSERT [dbo].[LichLamViec] ([LichLamViecID], [NhanVienID], [Ca], [Ngay]) VALUES (7, 9, N'trưa', N'11/10/2022')
INSERT [dbo].[LichLamViec] ([LichLamViecID], [NhanVienID], [Ca], [Ngay]) VALUES (8, 1, N'sáng', N'12/10/2022')
SET IDENTITY_INSERT [dbo].[LichLamViec] OFF

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

-- TẠO BẢNG HÓA ĐƠN
CREATE TABLE [dbo].[HoaDon](
	[HoaDonID] [int] IDENTITY(1,1) NOT NULL,
	[NhanVienID] [int] NULL,
	[KhachHangID] [int] NULL,
	[PhongID] [int] NULL,
	[TenLoai] [varchar](15) NULL,
	[SoDem] [int] NULL,
	[SoKhach] [int] NULL,
	[NgayHD] [varchar](15) NULL,
	[TongTien] [int] NULL,
	[BookingID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[HoaDonID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO

-- CHÈN DỮ LIỆU
SET IDENTITY_INSERT [dbo].[HoaDon] ON
INSERT [dbo].[HoaDon] ([HoaDonID], [NhanVienID], [KhachHangID], [PhongID], [TenLoai], [SoDem], [SoKhach], [NgayHD], [TongTien], [BookingID]) VALUES (1, 1, 1, 3, N'Deluxe', 2, 10, N'15/10/2022', 1460000, 1)
INSERT [dbo].[HoaDon] ([HoaDonID], [NhanVienID], [KhachHangID], [PhongID], [TenLoai], [SoDem], [SoKhach], [NgayHD], [TongTien], [BookingID]) VALUES (2, 1, 2, 1, N'Standard', 2, 1, N'15/10/2022', 1030000, 1)
INSERT [dbo].[HoaDon] ([HoaDonID], [NhanVienID], [KhachHangID], [PhongID], [TenLoai], [SoDem], [SoKhach], [NgayHD], [TongTien], [BookingID]) VALUES (3, 1, 3, 2, N'Deluxe', 2, 1, N'23/10/2022', 2060000, 1)
INSERT [dbo].[HoaDon] ([HoaDonID], [NhanVienID], [KhachHangID], [PhongID], [TenLoai], [SoDem], [SoKhach], [NgayHD], [TongTien], [BookingID]) VALUES (4, 1, 4, 1, N'Standard', 3, 3, N'15/10/2022', 1575000, 1)
INSERT [dbo].[HoaDon] ([HoaDonID], [NhanVienID], [KhachHangID], [PhongID], [TenLoai], [SoDem], [SoKhach], [NgayHD], [TongTien], [BookingID]) VALUES (5, 1, 5, 1, N'Standard', 1, 2, N'15/10/2022', 530000, 1)
INSERT [dbo].[HoaDon] ([HoaDonID], [NhanVienID], [KhachHangID], [PhongID], [TenLoai], [SoDem], [SoKhach], [NgayHD], [TongTien], [BookingID]) VALUES (6, 1, 6, 1, N'Standard', 2, 2, N'15/10/2022', 1030000, 3)
INSERT [dbo].[HoaDon] ([HoaDonID], [NhanVienID], [KhachHangID], [PhongID], [TenLoai], [SoDem], [SoKhach], [NgayHD], [TongTien], [BookingID]) VALUES (7, 1, 7, 2, N'Standard', 1, 2, N'17/10/2022', 515000, 5)
INSERT [dbo].[HoaDon] ([HoaDonID], [NhanVienID], [KhachHangID], [PhongID], [TenLoai], [SoDem], [SoKhach], [NgayHD], [TongTien], [BookingID]) VALUES (8, 1, 8, 1, N'Standard', 2, 2, N'17/10/2022', 1200000, 6)
INSERT [dbo].[HoaDon] ([HoaDonID], [NhanVienID], [KhachHangID], [PhongID], [TenLoai], [SoDem], [SoKhach], [NgayHD], [TongTien], [BookingID]) VALUES (9, 1, 9, 1, N'Standard', 2, 3, N'17/10/2022', 1485000, 2)
INSERT [dbo].[HoaDon] ([HoaDonID], [NhanVienID], [KhachHangID], [PhongID], [TenLoai], [SoDem], [SoKhach], [NgayHD], [TongTien], [BookingID]) VALUES (10, 1, 10, 3, N'Standard', 1, 3, N'17/10/2022', 515000, 4)
INSERT [dbo].[HoaDon] ([HoaDonID], [NhanVienID], [KhachHangID], [PhongID], [TenLoai], [SoDem], [SoKhach], [NgayHD], [TongTien], [BookingID]) VALUES (11, 1, 14, 4, N'Superior', 1, 3, N'17/10/2022', 730000, 7)
SET IDENTITY_INSERT [dbo].[HoaDon] OFF

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- TẠO BẢNG CHI TIẾT HÓA ĐƠN
CREATE TABLE [dbo].[ChiTietHoaDon](
	[ChiTietHoaDonID] [int] IDENTITY(1,1) NOT NULL,
	[HoaDonID] [int] NULL,
	[DichVuID] [int] NULL,
	[GiaDV] [int] NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ChiTietHoaDonID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

-- CHÈN DỮ LIỆU
SET IDENTITY_INSERT [dbo].[ChiTietHoaDon] ON
INSERT [dbo].[ChiTietHoaDon] ([ChiTietHoaDonID], [HoaDonID], [DichVuID], [GiaDV], [SoLuong], [ThanhTien]) VALUES (1, 1, 1, 30000, 2, 60000)
INSERT [dbo].[ChiTietHoaDon] ([ChiTietHoaDonID], [HoaDonID], [DichVuID], [GiaDV], [SoLuong], [ThanhTien]) VALUES (2, 1, 1, 30000, 1, 30000)
INSERT [dbo].[ChiTietHoaDon] ([ChiTietHoaDonID], [HoaDonID], [DichVuID], [GiaDV], [SoLuong], [ThanhTien]) VALUES (3, 1, 1, 30000, 1, 30000)
INSERT [dbo].[ChiTietHoaDon] ([ChiTietHoaDonID], [HoaDonID], [DichVuID], [GiaDV], [SoLuong], [ThanhTien]) VALUES (4, 1, 1, 30000, 1, 30000)
INSERT [dbo].[ChiTietHoaDon] ([ChiTietHoaDonID], [HoaDonID], [DichVuID], [GiaDV], [SoLuong], [ThanhTien]) VALUES (5, 1, 2, 15000, 3, 45000)
INSERT [dbo].[ChiTietHoaDon] ([ChiTietHoaDonID], [HoaDonID], [DichVuID], [GiaDV], [SoLuong], [ThanhTien]) VALUES (6, 1, 2, 15000, 2, 30000)
INSERT [dbo].[ChiTietHoaDon] ([ChiTietHoaDonID], [HoaDonID], [DichVuID], [GiaDV], [SoLuong], [ThanhTien]) VALUES (7, 1, 1, 30000, 1, 30000)
INSERT [dbo].[ChiTietHoaDon] ([ChiTietHoaDonID], [HoaDonID], [DichVuID], [GiaDV], [SoLuong], [ThanhTien]) VALUES (8, 1, 1, 30000, 1, 30000)
INSERT [dbo].[ChiTietHoaDon] ([ChiTietHoaDonID], [HoaDonID], [DichVuID], [GiaDV], [SoLuong], [ThanhTien]) VALUES (9, 1, 2, 15000, 1, 15000)
INSERT [dbo].[ChiTietHoaDon] ([ChiTietHoaDonID], [HoaDonID], [DichVuID], [GiaDV], [SoLuong], [ThanhTien]) VALUES (10, 1, 8, 200000, 1, 200000)
INSERT [dbo].[ChiTietHoaDon] ([ChiTietHoaDonID], [HoaDonID], [DichVuID], [GiaDV], [SoLuong], [ThanhTien]) VALUES (11, 1, 7, 485000, 1, 485000)
INSERT [dbo].[ChiTietHoaDon] ([ChiTietHoaDonID], [HoaDonID], [DichVuID], [GiaDV], [SoLuong], [ThanhTien]) VALUES (12, 1, 2, 15000, 1, 15000)
INSERT [dbo].[ChiTietHoaDon] ([ChiTietHoaDonID], [HoaDonID], [DichVuID], [GiaDV], [SoLuong], [ThanhTien]) VALUES (13, 1, 1, 30000, 1, 30000)
SET IDENTITY_INSERT [dbo].[ChiTietHoaDon] OFF

-- THÊM CÁC KHÓA NGOẠI
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD FOREIGN KEY([LoaiPhongID])
REFERENCES [dbo].[LoaiPhong] ([LoaiPhongID])
GO

ALTER TABLE [dbo].[LichLamViec]  WITH CHECK ADD FOREIGN KEY([NhanVienID])
REFERENCES [dbo].[NhanVien] ([NhanVienID])
GO

ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([KhachHangID])
REFERENCES [dbo].[KhachHang] ([KhachHangID])
GO

ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([NhanVienID])
REFERENCES [dbo].[NhanVien] ([NhanVienID])
GO

ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([PhongID])
REFERENCES [dbo].[Phong] ([PhongID])
GO

ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([HoaDonID])
REFERENCES [dbo].[HoaDon] ([HoaDonID])
GO
