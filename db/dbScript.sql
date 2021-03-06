USE [master]
GO
/****** Object:  Database [WebsiteViecLam]    Script Date: 2/17/2020 9:19:53 PM ******/
CREATE DATABASE [WebsiteViecLam]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WebsiteViecLam', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\WebsiteViecLam.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'WebsiteViecLam_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\WebsiteViecLam_log.ldf' , SIZE = 3456KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [WebsiteViecLam] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WebsiteViecLam].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WebsiteViecLam] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WebsiteViecLam] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WebsiteViecLam] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WebsiteViecLam] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WebsiteViecLam] SET ARITHABORT OFF 
GO
ALTER DATABASE [WebsiteViecLam] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [WebsiteViecLam] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WebsiteViecLam] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WebsiteViecLam] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WebsiteViecLam] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WebsiteViecLam] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WebsiteViecLam] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WebsiteViecLam] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WebsiteViecLam] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WebsiteViecLam] SET  DISABLE_BROKER 
GO
ALTER DATABASE [WebsiteViecLam] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WebsiteViecLam] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WebsiteViecLam] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WebsiteViecLam] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WebsiteViecLam] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WebsiteViecLam] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WebsiteViecLam] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WebsiteViecLam] SET RECOVERY FULL 
GO
ALTER DATABASE [WebsiteViecLam] SET  MULTI_USER 
GO
ALTER DATABASE [WebsiteViecLam] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WebsiteViecLam] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WebsiteViecLam] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WebsiteViecLam] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [WebsiteViecLam] SET DELAYED_DURABILITY = DISABLED 
GO
USE [WebsiteViecLam]
GO
/****** Object:  Table [dbo].[CongTy]    Script Date: 2/17/2020 9:19:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CongTy](
	[ID_CongTy] [int] IDENTITY(1,1) NOT NULL,
	[TenCongTy] [nvarchar](255) NULL,
	[TenDangNhap] [varchar](150) NULL,
	[MatKhau] [varchar](50) NULL,
	[DiaChi] [nvarchar](250) NULL,
	[QuyMo] [nvarchar](250) NULL,
	[SDT] [varchar](50) NULL,
	[Website] [varchar](50) NULL,
	[MoTa] [nvarchar](max) NULL,
	[NguoiDaiDien] [nvarchar](150) NULL,
	[Email] [varchar](150) NULL,
	[ID_ThanhPho] [int] NULL,
	[IsTuyenDung] [int] NULL DEFAULT ((0)),
 CONSTRAINT [PK_CongTy] PRIMARY KEY CLUSTERED 
(
	[ID_CongTy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CV_UngVien]    Script Date: 2/17/2020 9:19:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CV_UngVien](
	[ID_CV] [int] IDENTITY(1,1) NOT NULL,
	[ID_UngVien] [int] NULL,
	[TieuDe] [nvarchar](255) NULL,
	[ID_NganhNghe] [int] NULL,
	[KyNang] [nvarchar](max) NULL,
	[ID_ViTri] [int] NULL,
	[ID_TrinhDo] [int] NULL,
	[ID_KinhNghiem] [int] NULL,
	[NgoaiNgu] [nvarchar](255) NULL,
	[MucLuong] [nvarchar](100) NULL,
	[BangCap] [nvarchar](200) NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_CV_UngVien] PRIMARY KEY CLUSTERED 
(
	[ID_CV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DangKy]    Script Date: 2/17/2020 9:19:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangKy](
	[ID_DangKy] [int] IDENTITY(1,1) NOT NULL,
	[ID_CV] [int] NULL,
	[ID_ViecLam] [int] NULL,
	[NgayXem] [date] NULL,
	[NgayUngTuyen] [date] NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_DangKy] PRIMARY KEY CLUSTERED 
(
	[ID_DangKy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KinhNghiem]    Script Date: 2/17/2020 9:19:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KinhNghiem](
	[ID_KinhNghiem] [int] IDENTITY(1,1) NOT NULL,
	[TenKinhNghiem] [nvarchar](255) NULL,
 CONSTRAINT [PK_KinhNghiem] PRIMARY KEY CLUSTERED 
(
	[ID_KinhNghiem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiTaiKhoan]    Script Date: 2/17/2020 9:19:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiTaiKhoan](
	[ID_LoaiTaiKhoan] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](255) NULL,
 CONSTRAINT [PK_LoaiTaiKhoan] PRIMARY KEY CLUSTERED 
(
	[ID_LoaiTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NganhNghe]    Script Date: 2/17/2020 9:19:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NganhNghe](
	[ID_NganhNghe] [int] IDENTITY(1,1) NOT NULL,
	[TenNganhNghe] [nvarchar](250) NULL,
 CONSTRAINT [PK_NganhNghe] PRIMARY KEY CLUSTERED 
(
	[ID_NganhNghe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 2/17/2020 9:19:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[ID_TaiKhoan] [int] IDENTITY(1,1) NOT NULL,
	[ID_LoaiTaiKhoan] [int] NULL,
	[TenDangNhap] [varchar](150) NULL,
	[MatKhau] [varchar](50) NULL,
	[HoTen] [nvarchar](250) NULL,
	[Email] [varchar](50) NULL,
	[SDT] [varchar](50) NULL,
	[ID_Vung] [int] NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[ID_TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TinViecLam]    Script Date: 2/17/2020 9:19:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TinViecLam](
	[ID_ViecLam] [int] IDENTITY(1,1) NOT NULL,
	[TieuDeViecLam] [nvarchar](250) NULL,
	[MoTa] [nvarchar](max) NULL,
	[ID_NganhNghe] [int] NULL,
	[ID_ViTri] [int] NULL,
	[GioiTinh] [nvarchar](100) NULL,
	[YeuCauKyNang] [nvarchar](max) NULL,
	[ThoiGianThuViec] [nvarchar](100) NULL,
	[ID_KinhNghiem] [int] NULL,
	[ID_TrinhDo] [int] NULL,
	[MucLuong] [nvarchar](50) NULL,
	[NgayDang] [date] NULL,
	[NgayHetHan] [date] NULL,
	[TrangThai] [bit] NULL,
	[ID_CongTy] [int] NULL,
	[SoLuong] [int] NULL,
	[YeuCauHoSo] [nvarchar](max) NULL,
 CONSTRAINT [PK_TinViecLam] PRIMARY KEY CLUSTERED 
(
	[ID_ViecLam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThanhPho]    Script Date: 2/17/2020 9:19:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThanhPho](
	[ID_ThanhPho] [int] IDENTITY(1,1) NOT NULL,
	[TenThanhPho] [nvarchar](50) NULL,
	[ID_Vung] [int] NULL,
 CONSTRAINT [PK_ThanhPho] PRIMARY KEY CLUSTERED 
(
	[ID_ThanhPho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TrinhDo]    Script Date: 2/17/2020 9:19:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrinhDo](
	[ID_TrinhDo] [int] IDENTITY(1,1) NOT NULL,
	[TenTrinhDo] [nvarchar](250) NULL,
 CONSTRAINT [PK_TrinhDo] PRIMARY KEY CLUSTERED 
(
	[ID_TrinhDo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UngVien]    Script Date: 2/17/2020 9:19:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UngVien](
	[ID_UngVien] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](150) NULL,
	[MatKhau] [varchar](100) NULL,
	[DiaChi] [nvarchar](250) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[Email] [varchar](150) NULL,
	[SDT] [varchar](50) NULL,
	[ID_ThanhPho] [int] NULL,
	[IsUngVien] [int] NULL DEFAULT ((1)),
	[TenDangNhap] [varchar](255) NULL,
 CONSTRAINT [PK_UngVien] PRIMARY KEY CLUSTERED 
(
	[ID_UngVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ViTriUngTuyen]    Script Date: 2/17/2020 9:19:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ViTriUngTuyen](
	[ID_ViTri] [int] IDENTITY(1,1) NOT NULL,
	[TenViTri] [nvarchar](255) NULL,
 CONSTRAINT [PK_ViTriUngTuyen] PRIMARY KEY CLUSTERED 
(
	[ID_ViTri] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VungMien]    Script Date: 2/17/2020 9:19:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VungMien](
	[ID_Vung] [int] IDENTITY(1,1) NOT NULL,
	[TenVung] [nvarchar](150) NULL,
 CONSTRAINT [PK_VungMien] PRIMARY KEY CLUSTERED 
(
	[ID_Vung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[CongTy]  WITH CHECK ADD  CONSTRAINT [FK_CongTy_ThanhPho] FOREIGN KEY([ID_ThanhPho])
REFERENCES [dbo].[ThanhPho] ([ID_ThanhPho])
GO
ALTER TABLE [dbo].[CongTy] CHECK CONSTRAINT [FK_CongTy_ThanhPho]
GO
ALTER TABLE [dbo].[CV_UngVien]  WITH CHECK ADD  CONSTRAINT [FK_CV_UngVien_KinhNghiem] FOREIGN KEY([ID_KinhNghiem])
REFERENCES [dbo].[KinhNghiem] ([ID_KinhNghiem])
GO
ALTER TABLE [dbo].[CV_UngVien] CHECK CONSTRAINT [FK_CV_UngVien_KinhNghiem]
GO
ALTER TABLE [dbo].[CV_UngVien]  WITH CHECK ADD  CONSTRAINT [FK_CV_UngVien_NganhNghe] FOREIGN KEY([ID_NganhNghe])
REFERENCES [dbo].[NganhNghe] ([ID_NganhNghe])
GO
ALTER TABLE [dbo].[CV_UngVien] CHECK CONSTRAINT [FK_CV_UngVien_NganhNghe]
GO
ALTER TABLE [dbo].[CV_UngVien]  WITH CHECK ADD  CONSTRAINT [FK_CV_UngVien_TrinhDo] FOREIGN KEY([ID_TrinhDo])
REFERENCES [dbo].[TrinhDo] ([ID_TrinhDo])
GO
ALTER TABLE [dbo].[CV_UngVien] CHECK CONSTRAINT [FK_CV_UngVien_TrinhDo]
GO
ALTER TABLE [dbo].[CV_UngVien]  WITH CHECK ADD  CONSTRAINT [FK_CV_UngVien_UngVien] FOREIGN KEY([ID_UngVien])
REFERENCES [dbo].[UngVien] ([ID_UngVien])
GO
ALTER TABLE [dbo].[CV_UngVien] CHECK CONSTRAINT [FK_CV_UngVien_UngVien]
GO
ALTER TABLE [dbo].[CV_UngVien]  WITH CHECK ADD  CONSTRAINT [FK_CV_UngVien_ViTriUngTuyen] FOREIGN KEY([ID_ViTri])
REFERENCES [dbo].[ViTriUngTuyen] ([ID_ViTri])
GO
ALTER TABLE [dbo].[CV_UngVien] CHECK CONSTRAINT [FK_CV_UngVien_ViTriUngTuyen]
GO
ALTER TABLE [dbo].[DangKy]  WITH CHECK ADD  CONSTRAINT [FK_DangKy_CV_UngVien] FOREIGN KEY([ID_CV])
REFERENCES [dbo].[CV_UngVien] ([ID_CV])
GO
ALTER TABLE [dbo].[DangKy] CHECK CONSTRAINT [FK_DangKy_CV_UngVien]
GO
ALTER TABLE [dbo].[DangKy]  WITH CHECK ADD  CONSTRAINT [FK_DangKy_TinViecLam] FOREIGN KEY([ID_ViecLam])
REFERENCES [dbo].[TinViecLam] ([ID_ViecLam])
GO
ALTER TABLE [dbo].[DangKy] CHECK CONSTRAINT [FK_DangKy_TinViecLam]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_LoaiTaiKhoan] FOREIGN KEY([ID_LoaiTaiKhoan])
REFERENCES [dbo].[LoaiTaiKhoan] ([ID_LoaiTaiKhoan])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_LoaiTaiKhoan]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_VungMien] FOREIGN KEY([ID_Vung])
REFERENCES [dbo].[VungMien] ([ID_Vung])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_VungMien]
GO
ALTER TABLE [dbo].[TinViecLam]  WITH CHECK ADD  CONSTRAINT [FK_TinViecLam_CongTy] FOREIGN KEY([ID_CongTy])
REFERENCES [dbo].[CongTy] ([ID_CongTy])
GO
ALTER TABLE [dbo].[TinViecLam] CHECK CONSTRAINT [FK_TinViecLam_CongTy]
GO
ALTER TABLE [dbo].[TinViecLam]  WITH CHECK ADD  CONSTRAINT [FK_TinViecLam_KinhNghiem] FOREIGN KEY([ID_KinhNghiem])
REFERENCES [dbo].[KinhNghiem] ([ID_KinhNghiem])
GO
ALTER TABLE [dbo].[TinViecLam] CHECK CONSTRAINT [FK_TinViecLam_KinhNghiem]
GO
ALTER TABLE [dbo].[TinViecLam]  WITH CHECK ADD  CONSTRAINT [FK_TinViecLam_NganhNghe] FOREIGN KEY([ID_NganhNghe])
REFERENCES [dbo].[NganhNghe] ([ID_NganhNghe])
GO
ALTER TABLE [dbo].[TinViecLam] CHECK CONSTRAINT [FK_TinViecLam_NganhNghe]
GO
ALTER TABLE [dbo].[TinViecLam]  WITH CHECK ADD  CONSTRAINT [FK_TinViecLam_TrinhDo] FOREIGN KEY([ID_TrinhDo])
REFERENCES [dbo].[TrinhDo] ([ID_TrinhDo])
GO
ALTER TABLE [dbo].[TinViecLam] CHECK CONSTRAINT [FK_TinViecLam_TrinhDo]
GO
ALTER TABLE [dbo].[TinViecLam]  WITH CHECK ADD  CONSTRAINT [FK_TinViecLam_ViTriUngTuyen] FOREIGN KEY([ID_ViTri])
REFERENCES [dbo].[ViTriUngTuyen] ([ID_ViTri])
GO
ALTER TABLE [dbo].[TinViecLam] CHECK CONSTRAINT [FK_TinViecLam_ViTriUngTuyen]
GO
ALTER TABLE [dbo].[ThanhPho]  WITH CHECK ADD  CONSTRAINT [FK_ThanhPho_VungMien] FOREIGN KEY([ID_Vung])
REFERENCES [dbo].[VungMien] ([ID_Vung])
GO
ALTER TABLE [dbo].[ThanhPho] CHECK CONSTRAINT [FK_ThanhPho_VungMien]
GO
ALTER TABLE [dbo].[UngVien]  WITH CHECK ADD  CONSTRAINT [FK_UngVien_ThanhPho] FOREIGN KEY([ID_ThanhPho])
REFERENCES [dbo].[ThanhPho] ([ID_ThanhPho])
GO
ALTER TABLE [dbo].[UngVien] CHECK CONSTRAINT [FK_UngVien_ThanhPho]
GO
USE [master]
GO
ALTER DATABASE [WebsiteViecLam] SET  READ_WRITE 
GO
