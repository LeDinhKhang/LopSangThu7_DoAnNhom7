CREATE DATABASE DBQuanLiSanPham
GO
USE DBQuanLiSanPham
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 6/23/2020 7:05:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[TenSP] [nvarchar](50) NOT NULL,
	[LoaiSP] [nvarchar](50) NULL,
	[NhaSX] [nvarchar](50) NULL,
	[NgaySX] [datetime] NULL,
	[NgayHH] [datetime] NULL,
	[SoLuongSP] [int] NULL,
	[MaSP] [nchar](20) NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[TenSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[SanPham] ([TenSP], [LoaiSP], [NhaSX], [NgaySX], [NgayHH], [SoLuongSP], [MaSP]) VALUES (N'Ấm Điện', N'Thiết Bị Điện Tử', N'Sendo', CAST(N'2020-09-01T00:00:00.000' AS DateTime), CAST(N'2023-06-01T00:00:00.000' AS DateTime), 5, N'198446374           ')
INSERT [dbo].[SanPham] ([TenSP], [LoaiSP], [NhaSX], [NgaySX], [NgayHH], [SoLuongSP], [MaSP]) VALUES (N'Balo', N'Đồ Gia Dụng', N'Lazada', CAST(N'2020-07-25T00:00:00.000' AS DateTime), CAST(N'2022-08-02T00:00:00.000' AS DateTime), 50, N'198223344           ')
INSERT [dbo].[SanPham] ([TenSP], [LoaiSP], [NhaSX], [NgaySX], [NgayHH], [SoLuongSP], [MaSP]) VALUES (N'Bếp Điện Từ', N'Thiết Bị Điện Tử', N'Toshiba', CAST(N'2020-07-29T00:00:00.000' AS DateTime), CAST(N'2022-10-15T00:00:00.000' AS DateTime), 23, N'198876341           ')
INSERT [dbo].[SanPham] ([TenSP], [LoaiSP], [NhaSX], [NgaySX], [NgayHH], [SoLuongSP], [MaSP]) VALUES (N'Conan', N'Văn Phòng Phẩm, Sách', N'Kim Đồng', CAST(N'2021-01-01T00:00:00.000' AS DateTime), CAST(N'2022-05-05T00:00:00.000' AS DateTime), 1, N'198455123           ')
INSERT [dbo].[SanPham] ([TenSP], [LoaiSP], [NhaSX], [NgaySX], [NgayHH], [SoLuongSP], [MaSP]) VALUES (N'Dầu Gội Xmen', N'Đồ Gia Dụng', N'XMEN', CAST(N'2021-05-01T00:00:00.000' AS DateTime), CAST(N'2022-06-01T00:00:00.000' AS DateTime), 12, N'198671128           ')
INSERT [dbo].[SanPham] ([TenSP], [LoaiSP], [NhaSX], [NgaySX], [NgayHH], [SoLuongSP], [MaSP]) VALUES (N'Giày Nike', N'Đồ Gia Dụng', N'Nike', CAST(N'2020-08-05T18:58:11.000' AS DateTime), CAST(N'2021-06-02T18:58:11.000' AS DateTime), 1, N'198223342           ')
INSERT [dbo].[SanPham] ([TenSP], [LoaiSP], [NhaSX], [NgaySX], [NgayHH], [SoLuongSP], [MaSP]) VALUES (N'Sách Toán', N'Văn Phòng Phẩm, Sách', N'Kim Đồng', CAST(N'2020-08-05T18:57:12.000' AS DateTime), CAST(N'2021-04-07T18:57:12.000' AS DateTime), 10, N'198443124           ')
INSERT [dbo].[SanPham] ([TenSP], [LoaiSP], [NhaSX], [NgaySX], [NgayHH], [SoLuongSP], [MaSP]) VALUES (N'Xe Đạp Điện', N'Thiết Bị Điện Tử', N'Honda', CAST(N'2020-07-15T18:55:48.000' AS DateTime), CAST(N'2021-09-01T18:55:48.000' AS DateTime), 5, N'198446323           ')
GO
