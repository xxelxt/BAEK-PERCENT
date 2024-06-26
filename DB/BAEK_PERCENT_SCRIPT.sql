CREATE DATABASE [BAEK_PERCENT]
GO
USE [BAEK_PERCENT]
GO
/****** Object:  Table [dbo].[CTThueSach]    Script Date: 07/06/2024 11:17:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTThueSach](
	[MaThue] [varchar](50) NOT NULL,
	[MaSach] [varchar](10) NOT NULL,
	[GiaThue] [int] NOT NULL,
	[DaTra] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaThue] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTTraSach]    Script Date: 07/06/2024 11:17:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTTraSach](
	[MaTra] [varchar](50) NOT NULL,
	[MaSach] [varchar](10) NOT NULL,
	[MaVP] [varchar](10) NOT NULL,
	[ThanhTien] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTra] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 07/06/2024 11:17:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [varchar](10) NOT NULL,
	[TenKH] [nvarchar](50) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[GioiTinh] [bit] NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[SDT] [varchar](11) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LinhVuc]    Script Date: 07/06/2024 11:17:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LinhVuc](
	[MaLV] [varchar](10) NOT NULL,
	[TenLV] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiSach]    Script Date: 07/06/2024 11:17:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSach](
	[MaLoai] [varchar](10) NOT NULL,
	[TenLoai] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NgonNgu]    Script Date: 07/06/2024 11:17:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NgonNgu](
	[MaNN] [varchar](10) NOT NULL,
	[TenNN] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 07/06/2024 11:17:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [varchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[TenDangNhap] [varchar](30) NULL,
	[NgaySinh] [date] NOT NULL,
	[GioiTinh] [bit] NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[SDT] [varchar](11) NOT NULL,
	[Luong] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 07/06/2024 11:17:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[MaSach] [varchar](10) NOT NULL,
	[TenSach] [nvarchar](100) NOT NULL,
	[MaLoai] [varchar](10) NULL,
	[MaLV] [varchar](10) NULL,
	[MaTG] [varchar](10) NULL,
	[MaNN] [varchar](10) NULL,
	[SoTrang] [int] NOT NULL,
	[GiaSach] [int] NOT NULL,
	[DonGiaThue] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[Anh] [text] NULL,
	[GhiChu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TacGia]    Script Date: 07/06/2024 11:17:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TacGia](
	[MaTG] [varchar](10) NOT NULL,
	[TenTG] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 07/06/2024 11:17:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenDangNhap] [varchar](30) NOT NULL,
	[MatKhau] [varchar](256) NOT NULL,
	[Quyen] [int] NOT NULL,
 CONSTRAINT [PK__TaiKhoan__55F68FC1671BA54A] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThueSach]    Script Date: 07/06/2024 11:17:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThueSach](
	[MaThue] [varchar](50) NOT NULL,
	[MaKH] [varchar](10) NULL,
	[MaNV] [varchar](10) NULL,
	[NgayThue] [date] NOT NULL,
	[NgayTra] [date] NOT NULL,
	[TienDatCoc] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaThue] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TraSach]    Script Date: 07/06/2024 11:17:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TraSach](
	[MaTra] [varchar](50) NOT NULL,
	[MaThue] [varchar](50) NULL,
	[MaNV] [varchar](10) NULL,
	[NgayTra] [date] NOT NULL,
	[TongTien] [int] NOT NULL,
 CONSTRAINT [PK__TraSach__31493C6759BFDA5D] PRIMARY KEY CLUSTERED 
(
	[MaTra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ViPham]    Script Date: 07/06/2024 11:17:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ViPham](
	[MaVP] [varchar](10) NOT NULL,
	[TenVP] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaVP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CTThueSach] ([MaThue], [MaSach], [GiaThue], [DaTra]) VALUES (N'TH240603015112', N'ST0000001', 21000, 0)
INSERT [dbo].[CTThueSach] ([MaThue], [MaSach], [GiaThue], [DaTra]) VALUES (N'TH240603015112', N'ST0000002', 35000, 0)
INSERT [dbo].[CTThueSach] ([MaThue], [MaSach], [GiaThue], [DaTra]) VALUES (N'TH240603015158', N'ST0000003', 15000, 0)
INSERT [dbo].[CTThueSach] ([MaThue], [MaSach], [GiaThue], [DaTra]) VALUES (N'TH240603015158', N'ST0000005', 25000, 0)
INSERT [dbo].[CTThueSach] ([MaThue], [MaSach], [GiaThue], [DaTra]) VALUES (N'TH240603020247', N'ST0000004', 21000, 1)
INSERT [dbo].[CTThueSach] ([MaThue], [MaSach], [GiaThue], [DaTra]) VALUES (N'TH240603022307', N'ST0000001', 15000, 1)
INSERT [dbo].[CTThueSach] ([MaThue], [MaSach], [GiaThue], [DaTra]) VALUES (N'TH240603022307', N'ST0000002', 25000, 1)
INSERT [dbo].[CTThueSach] ([MaThue], [MaSach], [GiaThue], [DaTra]) VALUES (N'TH240603022307', N'ST0000003', 15000, 1)
INSERT [dbo].[CTThueSach] ([MaThue], [MaSach], [GiaThue], [DaTra]) VALUES (N'TH240603124228', N'ST0000001', 21000, 0)
GO
INSERT [dbo].[CTTraSach] ([MaTra], [MaSach], [MaVP], [ThanhTien]) VALUES (N'TR240603020509', N'ST0000003', N'VP002', 86000)
INSERT [dbo].[CTTraSach] ([MaTra], [MaSach], [MaVP], [ThanhTien]) VALUES (N'TR240603020509', N'ST0000005', N'VP003', 66500)
GO
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'KH0000001', N'Nguyễn Thị A', CAST(N'1999-01-01' AS Date), 1, N'Chùa Bộc', N'0987654321')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'KH0000002', N'Trần Văn B', CAST(N'1998-02-02' AS Date), 0, N'Tây Sơn', N'0987623451')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'KH0000003', N'Lê Thị C', CAST(N'1997-03-03' AS Date), 1, N'Thái Hà', N'0987634521')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'KH0000004', N'Hoàng Văn D', CAST(N'1996-04-04' AS Date), 0, N'Phạm Ngọc Thạch', N'0987651234')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'KH0000005', N'Trần Thị G', CAST(N'1995-05-05' AS Date), 1, N'Nguyễn Lương Bằng', N'0987612345')
GO
INSERT [dbo].[LinhVuc] ([MaLV], [TenLV]) VALUES (N'LV001', N'Văn học hiện đại')
INSERT [dbo].[LinhVuc] ([MaLV], [TenLV]) VALUES (N'LV002', N'Trinh thám - Kinh dị')
GO
INSERT [dbo].[LoaiSach] ([MaLoai], [TenLoai]) VALUES (N'LS001', N'Sách mới')
INSERT [dbo].[LoaiSach] ([MaLoai], [TenLoai]) VALUES (N'LS002', N'Sách cũ')
INSERT [dbo].[LoaiSach] ([MaLoai], [TenLoai]) VALUES (N'LS003', N'Sách bán chạy')
INSERT [dbo].[LoaiSach] ([MaLoai], [TenLoai]) VALUES (N'LS004', N'Sách ngưng tái bản')
GO
INSERT [dbo].[NgonNgu] ([MaNN], [TenNN]) VALUES (N'NN001', N'Tiếng Việt')
INSERT [dbo].[NgonNgu] ([MaNN], [TenNN]) VALUES (N'NN002', N'Tiếng Anh')
INSERT [dbo].[NgonNgu] ([MaNN], [TenNN]) VALUES (N'NN003', N'Tiếng Nhật')
INSERT [dbo].[NgonNgu] ([MaNN], [TenNN]) VALUES (N'NN004', N'Tiếng Hàn')
INSERT [dbo].[NgonNgu] ([MaNN], [TenNN]) VALUES (N'NN005', N'Tiếng Trung')
GO
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [TenDangNhap], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Luong]) VALUES (N'NV0000001', N'Nguyễn Văn A', N'admin', CAST(N'2000-01-01' AS Date), 1, N'Chùa Bộc', N'0987654321', 7000000)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [TenDangNhap], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Luong]) VALUES (N'NV0000002', N'Trần Thị B', N'user1', CAST(N'1998-02-02' AS Date), 0, N'Tây Sơn', N'0987654322', 7000000)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [TenDangNhap], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Luong]) VALUES (N'NV0000003', N'Lê Văn C', N'user2', CAST(N'1997-03-03' AS Date), 1, N'Thái Hà', N'0987654323', 8000000)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [TenDangNhap], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Luong]) VALUES (N'NV0000004', N'Hoàng Thị D', N'user3', CAST(N'1996-04-04' AS Date), 0, N'Phạm Ngọc Thạch', N'0987654324', 8000000)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [TenDangNhap], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Luong]) VALUES (N'NV0000005', N'Trần Văn H', N'user4', CAST(N'1995-05-05' AS Date), 1, N'Nguyễn Lương Bằng', N'0987654325', 6000000)
GO
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaLoai], [MaLV], [MaTG], [MaNN], [SoTrang], [GiaSach], [DonGiaThue], [SoLuong], [Anh], [GhiChu]) VALUES (N'ST0000001', N'Ngôi thứ nhất số ít', N'LS001', N'LV001', N'TG001', N'NN003', 203, 108000, 3000, 7, N'E:\rkive\6\.NET\BAEK\BAEK-PERCENT\BAEK-PERCENT\Images\NgoiThuNhatSoIt.jpg', N'Ghi chú 1')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaLoai], [MaLV], [MaTG], [MaNN], [SoTrang], [GiaSach], [DonGiaThue], [SoLuong], [Anh], [GhiChu]) VALUES (N'ST0000002', N'Thị kiến (The Shining)', N'LS002', N'LV001', N'TG002', N'NN002', 592, 269000, 5000, 3, N'', N'Ghi chú 2')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaLoai], [MaLV], [MaTG], [MaNN], [SoTrang], [GiaSach], [DonGiaThue], [SoLuong], [Anh], [GhiChu]) VALUES (N'ST0000003', N'Số đỏ', N'LS002', N'LV001', N'TG003', N'NN001', 624, 86000, 3000, 3, N'', N'Ghi chú 3')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaLoai], [MaLV], [MaTG], [MaNN], [SoTrang], [GiaSach], [DonGiaThue], [SoLuong], [Anh], [GhiChu]) VALUES (N'ST0000004', N'Một hoạ sĩ chết rồi thành danh trở lại', N'LS002', N'LV002', N'TG004', N'NN005', 388, 165000, 3000, 4, N'', N'Ghi chú 4')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaLoai], [MaLV], [MaTG], [MaNN], [SoTrang], [GiaSach], [DonGiaThue], [SoLuong], [Anh], [GhiChu]) VALUES (N'ST0000005', N'Hạnh nhân', N'LS004', N'LV001', N'TG005', N'NN004', 243, 95000, 5000, 5, N'', N'Ghi chú 5')
GO
INSERT [dbo].[TacGia] ([MaTG], [TenTG]) VALUES (N'TG001', N'Haruki Murakami')
INSERT [dbo].[TacGia] ([MaTG], [TenTG]) VALUES (N'TG002', N'Stephen King')
INSERT [dbo].[TacGia] ([MaTG], [TenTG]) VALUES (N'TG003', N'Vũ Trọng Phụng')
INSERT [dbo].[TacGia] ([MaTG], [TenTG]) VALUES (N'TG004', N'Trương Hàn Tự')
INSERT [dbo].[TacGia] ([MaTG], [TenTG]) VALUES (N'TG005', N'Sohn Won Pyung')
GO
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [Quyen]) VALUES (N'admin', N'8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', 1)
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [Quyen]) VALUES (N'user1', N'0a041b9462caa4a31bac3567e0b6e6fd9100787db2ab433d96f6d178cabfce90', 0)
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [Quyen]) VALUES (N'user2', N'6025d18fe48abd45168528f18a82e265dd98d421a7084aa09f61b341703901a3', 0)
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [Quyen]) VALUES (N'user3', N'5860faf02b6bc6222ba5aca523560f0e364ccd8b67bee486fe8bf7c01d492ccb', 0)
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [Quyen]) VALUES (N'user4', N'5269ef980de47819ba3d14340f4665262c41e933dc92c1a27dd5d01b047ac80e', 0)
GO
INSERT [dbo].[ThueSach] ([MaThue], [MaKH], [MaNV], [NgayThue], [NgayTra], [TienDatCoc]) VALUES (N'TH240603015112', N'KH0000003', N'NV0000001', CAST(N'2024-06-03' AS Date), CAST(N'2024-06-10' AS Date), 20000)
INSERT [dbo].[ThueSach] ([MaThue], [MaKH], [MaNV], [NgayThue], [NgayTra], [TienDatCoc]) VALUES (N'TH240603015158', N'KH0000002', N'NV0000001', CAST(N'2024-05-30' AS Date), CAST(N'2024-06-04' AS Date), 20000)
INSERT [dbo].[ThueSach] ([MaThue], [MaKH], [MaNV], [NgayThue], [NgayTra], [TienDatCoc]) VALUES (N'TH240603020247', N'KH0000005', N'NV0000001', CAST(N'2024-05-28' AS Date), CAST(N'2024-06-04' AS Date), 10000)
INSERT [dbo].[ThueSach] ([MaThue], [MaKH], [MaNV], [NgayThue], [NgayTra], [TienDatCoc]) VALUES (N'TH240603022307', N'KH0000001', N'NV0000001', CAST(N'2024-05-25' AS Date), CAST(N'2024-05-30' AS Date), 30000)
INSERT [dbo].[ThueSach] ([MaThue], [MaKH], [MaNV], [NgayThue], [NgayTra], [TienDatCoc]) VALUES (N'TH240603124228', N'KH0000004', N'NV0000001', CAST(N'2024-06-03' AS Date), CAST(N'2024-06-10' AS Date), 20000)
GO
INSERT [dbo].[TraSach] ([MaTra], [MaThue], [MaNV], [NgayTra], [TongTien]) VALUES (N'TR240603020453', N'TH240603020247', N'NV0000001', CAST(N'2024-06-03' AS Date), 21000)
INSERT [dbo].[TraSach] ([MaTra], [MaThue], [MaNV], [NgayTra], [TongTien]) VALUES (N'TR240603020509', N'TH240603015158', N'NV0000001', CAST(N'2024-06-03' AS Date), 192500)
INSERT [dbo].[TraSach] ([MaTra], [MaThue], [MaNV], [NgayTra], [TongTien]) VALUES (N'TR240603022434', N'TH240603022307', N'NV0000001', CAST(N'2024-05-30' AS Date), 55000)
INSERT [dbo].[TraSach] ([MaTra], [MaThue], [MaNV], [NgayTra], [TongTien]) VALUES (N'TR240603124250', NULL, NULL, CAST(N'2000-01-01' AS Date), -1)
GO
INSERT [dbo].[ViPham] ([MaVP], [TenVP]) VALUES (N'VP001', N'Quá hạn trả')
INSERT [dbo].[ViPham] ([MaVP], [TenVP]) VALUES (N'VP002', N'Mất sách')
INSERT [dbo].[ViPham] ([MaVP], [TenVP]) VALUES (N'VP003', N'Hỏng sách')
GO
ALTER TABLE [dbo].[CTThueSach]  WITH CHECK ADD FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
ALTER TABLE [dbo].[CTThueSach]  WITH CHECK ADD FOREIGN KEY([MaThue])
REFERENCES [dbo].[ThueSach] ([MaThue])
GO
ALTER TABLE [dbo].[CTTraSach]  WITH CHECK ADD FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
ALTER TABLE [dbo].[CTTraSach]  WITH CHECK ADD  CONSTRAINT [FK__CTTraSach__MaTra__60A75C0F] FOREIGN KEY([MaTra])
REFERENCES [dbo].[TraSach] ([MaTra])
GO
ALTER TABLE [dbo].[CTTraSach] CHECK CONSTRAINT [FK__CTTraSach__MaTra__60A75C0F]
GO
ALTER TABLE [dbo].[CTTraSach]  WITH CHECK ADD FOREIGN KEY([MaVP])
REFERENCES [dbo].[ViPham] ([MaVP])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK__NhanVien__TenDan__4AB81AF0] FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[TaiKhoan] ([TenDangNhap])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK__NhanVien__TenDan__4AB81AF0]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiSach] ([MaLoai])
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD FOREIGN KEY([MaLV])
REFERENCES [dbo].[LinhVuc] ([MaLV])
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD FOREIGN KEY([MaNN])
REFERENCES [dbo].[NgonNgu] ([MaNN])
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD FOREIGN KEY([MaTG])
REFERENCES [dbo].[TacGia] ([MaTG])
GO
ALTER TABLE [dbo].[ThueSach]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[ThueSach]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[TraSach]  WITH CHECK ADD  CONSTRAINT [FK__TraSach__MaNV__5DCAEF64] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[TraSach] CHECK CONSTRAINT [FK__TraSach__MaNV__5DCAEF64]
GO
ALTER TABLE [dbo].[TraSach]  WITH CHECK ADD  CONSTRAINT [FK__TraSach__MaThue__5CD6CB2B] FOREIGN KEY([MaThue])
REFERENCES [dbo].[ThueSach] ([MaThue])
GO
ALTER TABLE [dbo].[TraSach] CHECK CONSTRAINT [FK__TraSach__MaThue__5CD6CB2B]
GO
/****** Object:  Trigger [dbo].[trg_KhachHang_Insert]    Script Date: 07/06/2024 11:17:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[trg_KhachHang_Insert]
ON [dbo].[KhachHang]
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @nextId int;

    -- Tìm giá trị lớn nhất hiện có trong MaKH
    SELECT @nextId = ISNULL(MAX(CAST(SUBSTRING(MaKH, 3, LEN(MaKH) - 2) AS int)), 0) + 1
    FROM KhachHang;

    -- Chèn dữ liệu vào bảng KhachHang với MaKH được tự động tạo
    INSERT INTO KhachHang (MaKH, TenKH, NgaySinh, GioiTinh, DiaChi, SDT)
    SELECT 'KH' + RIGHT('0000000' + CAST(@nextId + ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) - 1 AS varchar(7)), 7), TenKH, NgaySinh, GioiTinh, DiaChi, SDT
    FROM inserted;

    -- Hiển thị kết quả
    SELECT *
    FROM KhachHang;
END;
GO
ALTER TABLE [dbo].[KhachHang] ENABLE TRIGGER [trg_KhachHang_Insert]
GO
/****** Object:  Trigger [dbo].[trg_LinhVuc_Insert]    Script Date: 07/06/2024 11:18:00 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[trg_LinhVuc_Insert]
ON [dbo].[LinhVuc]
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @nextId int;

    -- Tìm giá trị lớn nhất hiện có trong MaLV
    SELECT @nextId = ISNULL(MAX(CAST(SUBSTRING(MaLV, 3, LEN(MaLV) - 2) AS int)), 0) + 1
    FROM LinhVuc;

    -- Chèn dữ liệu vào bảng LinhVuc
    INSERT INTO LinhVuc (MaLV, TenLV)
    SELECT 'LV' + RIGHT('000' + CAST(@nextId + ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) - 1 AS varchar(3)), 3), TenLV
    FROM inserted;

    -- Hiển thị kết quả
    SELECT *
    FROM LinhVuc;
END;
GO
ALTER TABLE [dbo].[LinhVuc] ENABLE TRIGGER [trg_LinhVuc_Insert]
GO
/****** Object:  Trigger [dbo].[trg_LoaiSach_Insert]    Script Date: 07/06/2024 11:18:00 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[trg_LoaiSach_Insert]
ON [dbo].[LoaiSach]
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @nextId int;

    -- Tìm giá trị lớn nhất hiện có trong MaLoai
    SELECT @nextId = ISNULL(MAX(CAST(SUBSTRING(MaLoai, 3, LEN(MaLoai) - 2) AS int)), 0) + 1
    FROM LoaiSach;

    -- Chèn dữ liệu vào bảng LoaiSach với MaLoai được tự động tạo
    INSERT INTO LoaiSach (MaLoai, TenLoai)
    SELECT 'LS' + RIGHT('000' + CAST(@nextId + ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) - 1 AS varchar(3)), 3), TenLoai
    FROM inserted;

    -- Hiển thị kết quả
    SELECT *
    FROM LoaiSach;
END;
GO
ALTER TABLE [dbo].[LoaiSach] ENABLE TRIGGER [trg_LoaiSach_Insert]
GO
/****** Object:  Trigger [dbo].[trg_NgonNgu_Insert]    Script Date: 07/06/2024 11:18:00 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[trg_NgonNgu_Insert]
ON [dbo].[NgonNgu]
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @nextId int;

    -- Tìm giá trị lớn nhất hiện có trong MaNN
    SELECT @nextId = ISNULL(MAX(CAST(SUBSTRING(MaNN, 3, LEN(MaNN) - 2) AS int)), 0) + 1
    FROM NgonNgu;

    -- Chèn dữ liệu vào bảng NgonNgu với MaNN được tự động tạo
    INSERT INTO NgonNgu (MaNN, TenNN)
    SELECT 'NN' + RIGHT('000' + CAST(@nextId + ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) - 1 AS varchar(3)), 3), TenNN
    FROM inserted;

    -- Hiển thị kết quả
    SELECT *
    FROM NgonNgu;
END;
GO
ALTER TABLE [dbo].[NgonNgu] ENABLE TRIGGER [trg_NgonNgu_Insert]
GO
/****** Object:  Trigger [dbo].[trg_NhanVien_Insert]    Script Date: 07/06/2024 11:18:00 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[trg_NhanVien_Insert]
ON [dbo].[NhanVien]
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @nextId int;

    -- Tìm giá trị lớn nhất hiện có trong MaNV
    SELECT @nextId = ISNULL(MAX(CAST(SUBSTRING(MaNV, 3, LEN(MaNV) - 2) AS int)), 0) + 1
    FROM NhanVien;

    -- Chèn dữ liệu vào bảng NhanVien với MaNV được tự động tạo
    INSERT INTO NhanVien (MaNV, TenNV, TenDangNhap, NgaySinh, GioiTinh, DiaChi, SDT, Luong)
    SELECT 'NV' + RIGHT('0000000' + CAST(@nextId + ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) - 1 AS varchar(7)), 7), 
           TenNV, TenDangNhap, NgaySinh, GioiTinh, DiaChi, SDT, Luong
    FROM inserted;

    -- Hiển thị kết quả
    SELECT *
    FROM NhanVien;
END;
GO
ALTER TABLE [dbo].[NhanVien] ENABLE TRIGGER [trg_NhanVien_Insert]
GO
/****** Object:  Trigger [dbo].[trg_Sach_Insert]    Script Date: 07/06/2024 11:18:00 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[trg_Sach_Insert]
ON [dbo].[Sach]
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @nextId int;

    -- Tìm giá trị lớn nhất hiện có trong MaSach
    SELECT @nextId = ISNULL(MAX(CAST(SUBSTRING(MaSach, 3, LEN(MaSach) - 2) AS int)), 0) + 1
    FROM Sach;

    -- Chèn dữ liệu vào bảng Sach với MaSach được tự động tạo
    INSERT INTO Sach (MaSach, TenSach, MaLoai, MaLV, MaTG, MaNN, SoTrang, GiaSach, DonGiaThue, SoLuong, Anh, GhiChu)
    SELECT 'ST' + RIGHT('0000000' + CAST(@nextId + ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) - 1 AS varchar(7)), 7), 
           TenSach, MaLoai, MaLV, MaTG, MaNN, SoTrang, GiaSach, DonGiaThue, SoLuong, Anh, GhiChu
    FROM inserted;

    -- Hiển thị kết quả
    SELECT *
    FROM Sach;
END;
GO
ALTER TABLE [dbo].[Sach] ENABLE TRIGGER [trg_Sach_Insert]
GO
/****** Object:  Trigger [dbo].[trg_TacGia_Insert]    Script Date: 07/06/2024 11:18:00 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[trg_TacGia_Insert]
ON [dbo].[TacGia]
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @nextId int;

    -- Tìm giá trị lớn nhất hiện có trong MaTG
    SELECT @nextId = ISNULL(MAX(CAST(SUBSTRING(MaTG, 3, LEN(MaTG) - 2) AS int)), 0) + 1
    FROM TacGia;

    -- Chèn dữ liệu vào bảng TacGia với MaTG được tự động tạo
    INSERT INTO TacGia (MaTG, TenTG)
    SELECT 'TG' + RIGHT('000' + CAST(@nextId + ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) - 1 AS varchar(3)), 3), TenTG
    FROM inserted;

    -- Hiển thị kết quả
    SELECT *
    FROM TacGia;
END;
GO
ALTER TABLE [dbo].[TacGia] ENABLE TRIGGER [trg_TacGia_Insert]
GO
/****** Object:  Trigger [dbo].[trg_ViPham_Insert]    Script Date: 07/06/2024 11:18:00 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[trg_ViPham_Insert]
ON [dbo].[ViPham]
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @nextId int;

    -- Tìm giá trị lớn nhất hiện có trong MaVP
    SELECT @nextId = ISNULL(MAX(CAST(SUBSTRING(MaVP, 3, LEN(MaVP) - 2) AS int)), 0) + 1
    FROM ViPham;

    -- Chèn dữ liệu vào bảng ViPham với MaVP được tự động tạo
    INSERT INTO ViPham (MaVP, TenVP)
    SELECT 'VP' + RIGHT('000' + CAST(@nextId + ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) - 1 AS varchar(3)), 3), TenVP
    FROM inserted;

    -- Hiển thị kết quả
    SELECT *
    FROM ViPham;
END;
GO
ALTER TABLE [dbo].[ViPham] ENABLE TRIGGER [trg_ViPham_Insert]
GO
USE [master]
GO
ALTER DATABASE [BAEK_PERCENT] SET  READ_WRITE 
GO
