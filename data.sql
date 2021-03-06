USE [LKDT_LOD]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 7/15/2020 8:41:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOADON](
	[sohoadon] [char](10) NOT NULL,
	[ngayhoadon] [datetime] NULL,
	[noidung] [nvarchar](128) NULL,
	[ma_nv] [char](10) NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[sohoadon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HOADONCT]    Script Date: 7/15/2020 8:41:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOADONCT](
	[sohoadonct] [char](10) NOT NULL,
	[sohoadon] [char](10) NULL,
	[ma_sp] [char](10) NULL,
	[ten_sp] [nvarchar](30) NULL,
	[soluong] [decimal](18, 0) NULL,
	[dongia] [decimal](18, 0) NULL,
 CONSTRAINT [PK_HOADONCT] PRIMARY KEY CLUSTERED 
(
	[sohoadonct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOAI_SP]    Script Date: 7/15/2020 8:41:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOAI_SP](
	[ma_loai] [char](10) NOT NULL,
	[ten_loai] [nvarchar](30) NULL,
	[ghichu] [nvarchar](128) NULL,
 CONSTRAINT [PK_LOAI_SP] PRIMARY KEY CLUSTERED 
(
	[ma_loai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHA_CC]    Script Date: 7/15/2020 8:41:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHA_CC](
	[ma_ncc] [char](10) NOT NULL,
	[ten_ncc] [nvarchar](30) NULL,
	[diachi] [nvarchar](100) NULL,
	[sdt] [nvarchar](10) NULL,
 CONSTRAINT [PK_NHA_CC] PRIMARY KEY CLUSTERED 
(
	[ma_ncc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 7/15/2020 8:41:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[ma_nv] [char](10) NOT NULL,
	[ten_nv] [nvarchar](30) NULL,
	[gioitinh] [bit] NULL,
	[ngaysinh] [datetime] NULL,
	[diachi] [nvarchar](100) NULL CONSTRAINT [DF_NHANVIEN_diachi]  DEFAULT (N'Bình Dương'),
	[sdt] [nvarchar](50) NULL,
	[quanly] [bit] NULL,
	[UserName] [char](20) NULL,
	[Password] [char](10) NULL,
	[MaLTK] [int] NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[ma_nv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 7/15/2020 8:41:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[sophieuphap] [char](10) NOT NULL,
	[ngayphieunhap] [datetime] NULL,
	[ma_ncc] [char](10) NULL,
	[noidung] [nvarchar](512) NULL,
	[ma_nv] [char](10) NULL,
 CONSTRAINT [PK_PHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[sophieuphap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUNHAP_CT]    Script Date: 7/15/2020 8:41:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUNHAP_CT](
	[sophieunhapct] [char](10) NOT NULL,
	[sophieunhap] [char](10) NULL,
	[ma_sp] [char](10) NULL,
	[soluong] [decimal](18, 0) NULL,
	[dongia] [decimal](18, 0) NULL,
	[thanhtien] [decimal](18, 0) NULL,
 CONSTRAINT [PK_PHIEUNHAP_CT] PRIMARY KEY CLUSTERED 
(
	[sophieunhapct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 7/15/2020 8:41:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[ma_sp] [char](10) NOT NULL,
	[ten_sp] [nvarchar](30) NULL,
	[donvitinh] [nvarchar](30) NULL,
	[dongia] [decimal](18, 0) NULL,
	[ma_loai] [char](10) NULL,
 CONSTRAINT [PK_SANPHAM] PRIMARY KEY CLUSTERED 
(
	[ma_sp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[HOADON] ([sohoadon], [ngayhoadon], [noidung], [ma_nv]) VALUES (N'HD001     ', CAST(N'2020-06-30 00:00:00.000' AS DateTime), N'noidung1', N'NV003     ')
INSERT [dbo].[HOADON] ([sohoadon], [ngayhoadon], [noidung], [ma_nv]) VALUES (N'HD002     ', CAST(N'2020-06-21 00:00:00.000' AS DateTime), N'noidung2', N'NV004     ')
INSERT [dbo].[HOADON] ([sohoadon], [ngayhoadon], [noidung], [ma_nv]) VALUES (N'HD003     ', CAST(N'2020-05-30 00:00:00.000' AS DateTime), N'noidung4', N'NV004     ')
INSERT [dbo].[HOADON] ([sohoadon], [ngayhoadon], [noidung], [ma_nv]) VALUES (N'HD004     ', CAST(N'2020-06-22 00:00:00.000' AS DateTime), N'noidung3', N'NV002     ')
INSERT [dbo].[HOADON] ([sohoadon], [ngayhoadon], [noidung], [ma_nv]) VALUES (N'HD005     ', CAST(N'2020-07-04 00:00:00.000' AS DateTime), N'noidung5', N'NV002     ')
INSERT [dbo].[HOADONCT] ([sohoadonct], [sohoadon], [ma_sp], [ten_sp], [soluong], [dongia]) VALUES (N'HDCT001   ', N'HD001     ', N'C001      ', N'CPU', CAST(200 AS Decimal(18, 0)), CAST(5000 AS Decimal(18, 0)))
INSERT [dbo].[HOADONCT] ([sohoadonct], [sohoadon], [ma_sp], [ten_sp], [soluong], [dongia]) VALUES (N'HDCT002   ', N'HD002     ', N'CA002     ', N'CARD', CAST(50 AS Decimal(18, 0)), CAST(2000 AS Decimal(18, 0)))
INSERT [dbo].[HOADONCT] ([sohoadonct], [sohoadon], [ma_sp], [ten_sp], [soluong], [dongia]) VALUES (N'HDCT003   ', N'HD003     ', N'MH001     ', N'Màn Hình DELL', CAST(100 AS Decimal(18, 0)), CAST(40000 AS Decimal(18, 0)))
INSERT [dbo].[HOADONCT] ([sohoadonct], [sohoadon], [ma_sp], [ten_sp], [soluong], [dongia]) VALUES (N'HDCT004   ', N'HD004     ', N'R003      ', N'rom dell', CAST(70 AS Decimal(18, 0)), CAST(4000 AS Decimal(18, 0)))
INSERT [dbo].[HOADONCT] ([sohoadonct], [sohoadon], [ma_sp], [ten_sp], [soluong], [dongia]) VALUES (N'HDCT005   ', N'HD005     ', N'R001      ', N'ram dell', CAST(80 AS Decimal(18, 0)), CAST(1000 AS Decimal(18, 0)))
INSERT [dbo].[NHA_CC] ([ma_ncc], [ten_ncc], [diachi], [sdt]) VALUES (N'DT002     ', N'Điện Tử Jing Gong Việt Nam', N'TX. Bến Cát,Bình Dương', N'0274355399')
INSERT [dbo].[NHA_CC] ([ma_ncc], [ten_ncc], [diachi], [sdt]) VALUES (N'FA004     ', N'FAB-9 Việt Nam', N'TX.Thuận An,Bình Dương', N'0274378342')
INSERT [dbo].[NHA_CC] ([ma_ncc], [ten_ncc], [diachi], [sdt]) VALUES (N'FU001     ', N'Fu Yuan VN', N'TP.Thủ Dầu Một,Bình Dương', N'0274370889')
INSERT [dbo].[NHA_CC] ([ma_ncc], [ten_ncc], [diachi], [sdt]) VALUES (N'JA003     ', N'JAE YOUNG VINA', N'TX.Thuận An,Bình Dương', N'0274246119')
INSERT [dbo].[NHANVIEN] ([ma_nv], [ten_nv], [gioitinh], [ngaysinh], [diachi], [sdt], [quanly], [UserName], [Password], [MaLTK]) VALUES (N'NV001     ', N'Duy', 1, CAST(N'1999-03-19 00:00:00.000' AS DateTime), N'Đắk Nông', N'0988981845', 1, N'a                   ', N'a         ', 1)
INSERT [dbo].[NHANVIEN] ([ma_nv], [ten_nv], [gioitinh], [ngaysinh], [diachi], [sdt], [quanly], [UserName], [Password], [MaLTK]) VALUES (N'NV002     ', N'Oanh', 0, CAST(N'2000-10-06 00:00:00.000' AS DateTime), N'Bình Dương', N'0338106877', 0, N'nhanvien1           ', N'123       ', 2)
INSERT [dbo].[NHANVIEN] ([ma_nv], [ten_nv], [gioitinh], [ngaysinh], [diachi], [sdt], [quanly], [UserName], [Password], [MaLTK]) VALUES (N'NV003     ', N'Trúc', 0, CAST(N'1998-10-07 00:00:00.000' AS DateTime), N'Lâm Đồng', N'0918981224', 0, N'nhanvien2           ', N'123       ', 3)
INSERT [dbo].[NHANVIEN] ([ma_nv], [ten_nv], [gioitinh], [ngaysinh], [diachi], [sdt], [quanly], [UserName], [Password], [MaLTK]) VALUES (N'NV004     ', N'Long', 1, CAST(N'1997-04-14 00:00:00.000' AS DateTime), N'Bình Dương', N'0123456789', 0, N'nhanvien3           ', N'123       ', 4)
INSERT [dbo].[NHANVIEN] ([ma_nv], [ten_nv], [gioitinh], [ngaysinh], [diachi], [sdt], [quanly], [UserName], [Password], [MaLTK]) VALUES (N'NV005     ', N'Nhật', 1, CAST(N'1999-05-19 00:00:00.000' AS DateTime), N'Lào Cai', N'0987564123', 0, N'nhanvien4           ', N'123       ', 5)
INSERT [dbo].[NHANVIEN] ([ma_nv], [ten_nv], [gioitinh], [ngaysinh], [diachi], [sdt], [quanly], [UserName], [Password], [MaLTK]) VALUES (N'NV006     ', N'Lưu', 1, CAST(N'2000-11-15 00:00:00.000' AS DateTime), N'Bình Dương', N'0915468712', 0, N'nhanvien5           ', N'123       ', 6)
INSERT [dbo].[PHIEUNHAP] ([sophieuphap], [ngayphieunhap], [ma_ncc], [noidung], [ma_nv]) VALUES (N'A1        ', CAST(N'2020-02-07 00:00:00.000' AS DateTime), N'FU001     ', N'nội dung1', N'NV001     ')
INSERT [dbo].[PHIEUNHAP] ([sophieuphap], [ngayphieunhap], [ma_ncc], [noidung], [ma_nv]) VALUES (N'A2        ', CAST(N'2020-01-06 00:00:00.000' AS DateTime), N'FA004     ', N'nội dung2', N'NV001     ')
INSERT [dbo].[PHIEUNHAP] ([sophieuphap], [ngayphieunhap], [ma_ncc], [noidung], [ma_nv]) VALUES (N'A3        ', CAST(N'2020-06-25 00:00:00.000' AS DateTime), N'JA003     ', N'nội dung3', N'NV001     ')
INSERT [dbo].[PHIEUNHAP] ([sophieuphap], [ngayphieunhap], [ma_ncc], [noidung], [ma_nv]) VALUES (N'A4        ', CAST(N'2020-04-26 00:00:00.000' AS DateTime), N'DT002     ', N'nội dung4', N'NV001     ')
INSERT [dbo].[PHIEUNHAP_CT] ([sophieunhapct], [sophieunhap], [ma_sp], [soluong], [dongia], [thanhtien]) VALUES (N'AA1       ', N'A1        ', N'C001      ', CAST(10000 AS Decimal(18, 0)), CAST(5000 AS Decimal(18, 0)), NULL)
INSERT [dbo].[PHIEUNHAP_CT] ([sophieunhapct], [sophieunhap], [ma_sp], [soluong], [dongia], [thanhtien]) VALUES (N'AA2       ', N'A1        ', N'CA002     ', CAST(5000 AS Decimal(18, 0)), CAST(2000 AS Decimal(18, 0)), NULL)
INSERT [dbo].[PHIEUNHAP_CT] ([sophieunhapct], [sophieunhap], [ma_sp], [soluong], [dongia], [thanhtien]) VALUES (N'AA3       ', N'A2        ', N'MH001     ', CAST(50 AS Decimal(18, 0)), CAST(40000 AS Decimal(18, 0)), NULL)
INSERT [dbo].[PHIEUNHAP_CT] ([sophieunhapct], [sophieunhap], [ma_sp], [soluong], [dongia], [thanhtien]) VALUES (N'AA4       ', N'A2        ', N'MH002     ', CAST(200 AS Decimal(18, 0)), NULL, NULL)
INSERT [dbo].[PHIEUNHAP_CT] ([sophieunhapct], [sophieunhap], [ma_sp], [soluong], [dongia], [thanhtien]) VALUES (N'AA5       ', N'A3        ', N'Q001      ', CAST(5000 AS Decimal(18, 0)), NULL, NULL)
INSERT [dbo].[PHIEUNHAP_CT] ([sophieunhapct], [sophieunhap], [ma_sp], [soluong], [dongia], [thanhtien]) VALUES (N'AA6       ', N'A3        ', N'R001      ', CAST(3000 AS Decimal(18, 0)), NULL, NULL)
INSERT [dbo].[PHIEUNHAP_CT] ([sophieunhapct], [sophieunhap], [ma_sp], [soluong], [dongia], [thanhtien]) VALUES (N'AA7       ', N'A4        ', N'R002      ', CAST(45 AS Decimal(18, 0)), NULL, NULL)
INSERT [dbo].[PHIEUNHAP_CT] ([sophieunhapct], [sophieunhap], [ma_sp], [soluong], [dongia], [thanhtien]) VALUES (N'AA8       ', N'A4        ', N'R003      ', CAST(126 AS Decimal(18, 0)), NULL, NULL)
INSERT [dbo].[SANPHAM] ([ma_sp], [ten_sp], [donvitinh], [dongia], [ma_loai]) VALUES (N'C001      ', N'CPU', N'cái', CAST(5000 AS Decimal(18, 0)), NULL)
INSERT [dbo].[SANPHAM] ([ma_sp], [ten_sp], [donvitinh], [dongia], [ma_loai]) VALUES (N'CA002     ', N'CARD', N'cái', CAST(2000 AS Decimal(18, 0)), NULL)
INSERT [dbo].[SANPHAM] ([ma_sp], [ten_sp], [donvitinh], [dongia], [ma_loai]) VALUES (N'MH001     ', N'Màn hình DELL ', N'cái', CAST(40000 AS Decimal(18, 0)), NULL)
INSERT [dbo].[SANPHAM] ([ma_sp], [ten_sp], [donvitinh], [dongia], [ma_loai]) VALUES (N'MH002     ', N'Màn hình ACER', N'cái', CAST(45000 AS Decimal(18, 0)), NULL)
INSERT [dbo].[SANPHAM] ([ma_sp], [ten_sp], [donvitinh], [dongia], [ma_loai]) VALUES (N'Q001      ', N'QUẠT', N'cái', CAST(100 AS Decimal(18, 0)), NULL)
INSERT [dbo].[SANPHAM] ([ma_sp], [ten_sp], [donvitinh], [dongia], [ma_loai]) VALUES (N'R001      ', N'ram dell', N'cái', CAST(1000 AS Decimal(18, 0)), NULL)
INSERT [dbo].[SANPHAM] ([ma_sp], [ten_sp], [donvitinh], [dongia], [ma_loai]) VALUES (N'R002      ', N'ram dell', N'cái', CAST(2000 AS Decimal(18, 0)), NULL)
INSERT [dbo].[SANPHAM] ([ma_sp], [ten_sp], [donvitinh], [dongia], [ma_loai]) VALUES (N'R003      ', N'rom dell', N'cái', CAST(4000 AS Decimal(18, 0)), NULL)
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_NHANVIEN] FOREIGN KEY([ma_nv])
REFERENCES [dbo].[NHANVIEN] ([ma_nv])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_NHANVIEN]
GO
ALTER TABLE [dbo].[HOADONCT]  WITH CHECK ADD  CONSTRAINT [FK_HOADONCT_HOADON1] FOREIGN KEY([sohoadon])
REFERENCES [dbo].[HOADON] ([sohoadon])
GO
ALTER TABLE [dbo].[HOADONCT] CHECK CONSTRAINT [FK_HOADONCT_HOADON1]
GO
ALTER TABLE [dbo].[HOADONCT]  WITH CHECK ADD  CONSTRAINT [FK_HOADONCT_SANPHAM] FOREIGN KEY([ma_sp])
REFERENCES [dbo].[SANPHAM] ([ma_sp])
GO
ALTER TABLE [dbo].[HOADONCT] CHECK CONSTRAINT [FK_HOADONCT_SANPHAM]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_NHA_CC1] FOREIGN KEY([ma_ncc])
REFERENCES [dbo].[NHA_CC] ([ma_ncc])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_NHA_CC1]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_NHANVIEN] FOREIGN KEY([ma_nv])
REFERENCES [dbo].[NHANVIEN] ([ma_nv])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_NHANVIEN]
GO
ALTER TABLE [dbo].[PHIEUNHAP_CT]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_CT_PHIEUNHAP] FOREIGN KEY([sophieunhap])
REFERENCES [dbo].[PHIEUNHAP] ([sophieuphap])
GO
ALTER TABLE [dbo].[PHIEUNHAP_CT] CHECK CONSTRAINT [FK_PHIEUNHAP_CT_PHIEUNHAP]
GO
ALTER TABLE [dbo].[PHIEUNHAP_CT]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_CT_SANPHAM] FOREIGN KEY([ma_sp])
REFERENCES [dbo].[SANPHAM] ([ma_sp])
GO
ALTER TABLE [dbo].[PHIEUNHAP_CT] CHECK CONSTRAINT [FK_PHIEUNHAP_CT_SANPHAM]
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD  CONSTRAINT [FK_SANPHAM_LOAI_SP] FOREIGN KEY([ma_loai])
REFERENCES [dbo].[LOAI_SP] ([ma_loai])
GO
ALTER TABLE [dbo].[SANPHAM] CHECK CONSTRAINT [FK_SANPHAM_LOAI_SP]
GO
