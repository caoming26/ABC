USE [master]
GO
/****** Object:  Database [ABC_bakery]    Script Date: 12/10/2023 10:40:55 PM ******/
CREATE DATABASE [ABC_bakery]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ABC_bakery', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MINH\MSSQL\DATA\ABC_bakery.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ABC_bakery_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MINH\MSSQL\DATA\ABC_bakery_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ABC_bakery] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ABC_bakery].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ABC_bakery] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ABC_bakery] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ABC_bakery] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ABC_bakery] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ABC_bakery] SET ARITHABORT OFF 
GO
ALTER DATABASE [ABC_bakery] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ABC_bakery] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ABC_bakery] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ABC_bakery] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ABC_bakery] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ABC_bakery] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ABC_bakery] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ABC_bakery] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ABC_bakery] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ABC_bakery] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ABC_bakery] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ABC_bakery] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ABC_bakery] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ABC_bakery] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ABC_bakery] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ABC_bakery] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ABC_bakery] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ABC_bakery] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ABC_bakery] SET  MULTI_USER 
GO
ALTER DATABASE [ABC_bakery] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ABC_bakery] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ABC_bakery] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ABC_bakery] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ABC_bakery] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ABC_bakery] SET QUERY_STORE = OFF
GO
USE [ABC_bakery]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [ABC_bakery]
GO
/****** Object:  UserDefinedTableType [dbo].[ProductDetailsType]    Script Date: 12/10/2023 10:40:55 PM ******/
CREATE TYPE [dbo].[ProductDetailsType] AS TABLE(
	[product_id] [bigint] NULL,
	[OD_price] [float] NULL,
	[OD_total] [float] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[ProductDetailsType1]    Script Date: 12/10/2023 10:40:55 PM ******/
CREATE TYPE [dbo].[ProductDetailsType1] AS TABLE(
	[product_id] [bigint] NULL,
	[OD_price] [float] NULL,
	[OD_total] [int] NULL
)
GO
/****** Object:  UserDefinedFunction [dbo].[CalculateEachProduct]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[CalculateEachProduct] (@ProductID INT)
RETURNS INT
AS
BEGIN
    DECLARE @TotalPrice INT;

    SELECT @TotalPrice = price * amount
    FROM products
    WHERE id = @ProductID;

    RETURN @TotalPrice;
END;
GO
/****** Object:  UserDefinedFunction [dbo].[CalculateTotalPrice]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[CalculateTotalPrice]
(
)
RETURNS INT
AS
BEGIN
    DECLARE @totalPrice INT

    SELECT @totalPrice = SUM(price * amount)
    FROM products

    RETURN @totalPrice
END
GO
/****** Object:  UserDefinedFunction [dbo].[SumOfColumn]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[SumOfColumn]
(
    @TableName NVARCHAR(255),
    @ColumnName NVARCHAR(255)
)
RETURNS INT
AS
BEGIN
    DECLARE @DynamicSQL NVARCHAR(MAX);
    DECLARE @Total INT;

    -- Xây dựng câu truy vấn động để tính tổng
    SET @DynamicSQL = 'SELECT @Total = SUM(' + QUOTENAME(@ColumnName) + ') FROM ' + QUOTENAME(@TableName);

    -- Thực hiện câu truy vấn động và lấy kết quả tổng
    EXEC sp_executesql @DynamicSQL, N'@Total INT OUTPUT', @Total OUTPUT;

    RETURN @Total;
END;
GO
/****** Object:  Table [dbo].[categories]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categories](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[prefix] [nvarchar](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Chi]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chi](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](250) NULL,
	[quantity] [int] NULL,
	[price] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[images]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[images](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[product_id] [bigint] NOT NULL,
	[url] [varchar](512) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[import_product]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[import_product](
	[import_id] [bigint] NOT NULL,
	[product_id] [bigint] NOT NULL,
	[price] [float] NOT NULL,
	[amount] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[import_id] ASC,
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[imports]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[imports](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[supplier_id] [bigint] NOT NULL,
	[admin_id] [bigint] NOT NULL,
	[total] [int] NOT NULL,
	[created_at] [date] NOT NULL,
	[is_inter] [bit] NOT NULL,
	[prefix] [nvarchar](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[order_detail]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[order_detail](
	[order_id] [nchar](10) NULL,
	[product_id] [nchar](10) NULL,
	[price] [float] NULL,
	[total] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orders]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[promotion_id] [bigint] NULL,
	[receipt_id] [bigint] NOT NULL,
	[cashier_id] [bigint] NOT NULL,
	[price] [float] NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[address] [nvarchar](512) NOT NULL,
	[status] [int] NOT NULL,
	[type] [int] NOT NULL,
	[total] [int] NOT NULL,
	[ship_fee] [float] NOT NULL,
	[payment_method] [int] NOT NULL,
	[is_paid] [bit] NOT NULL,
	[prepay] [float] NOT NULL,
	[ordered_at] [date] NOT NULL,
	[note] [text] NOT NULL,
	[change] [int] NOT NULL,
	[receieved] [int] NOT NULL,
	[prefix] [nvarchar](5) NOT NULL,
 CONSTRAINT [PK__orders__3213E83F8699FE92] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[permissions]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[permissions](
	[id] [bigint] IDENTITY(0,1) NOT NULL,
	[allow_access] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[products]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[category_id] [bigint] NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[price] [float] NOT NULL,
	[is_active] [bit] NOT NULL,
	[amount] [int] NOT NULL,
	[expiration_date] [date] NOT NULL,
	[created_at] [date] NOT NULL,
	[updated_at] [date] NOT NULL,
	[prefix] [nvarchar](5) NOT NULL,
	[note] [nvarchar](4000) NULL,
	[supplier] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[promotions]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[promotions](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[is_active] [bit] NOT NULL,
	[created_at] [date] NOT NULL,
	[code] [nvarchar](6) NOT NULL,
	[prefix] [nvarchar](5) NOT NULL,
	[ratio] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[receipts]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[receipts](
	[id] [bigint] NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[receieved] [float] NOT NULL,
	[expense] [float] NOT NULL,
	[created_at] [date] NOT NULL,
	[prefix] [nvarchar](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[role_permission]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[role_permission](
	[permission_id] [bigint] NOT NULL,
	[role_id] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[permission_id] ASC,
	[role_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[roles]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roles](
	[id] [bigint] NOT NULL,
	[name] [varchar](30) NOT NULL,
 CONSTRAINT [PK__roles__3213E83FBCD8B838] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[suppliers]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[suppliers](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[phone_number] [varchar](10) NOT NULL,
	[address] [nvarchar](255) NOT NULL,
	[created_at] [date] NULL,
	[updated_at] [date] NULL,
	[show] [bit] NOT NULL,
	[prefix] [nvarchar](5) NOT NULL,
	[Note] [nvarchar](4000) NULL,
 CONSTRAINT [PK__supplier__3213E83FE8F7E6EA] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[role_id] [bigint] NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[created_at] [date] NOT NULL,
	[updated_at] [date] NOT NULL,
	[password] [nchar](20) NULL,
	[permission] [nvarchar](50) NULL,
	[expirationTime] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[categories] ON 

INSERT [dbo].[categories] ([id], [name], [prefix]) VALUES (2, N'Banh mi', N'TL')
INSERT [dbo].[categories] ([id], [name], [prefix]) VALUES (3, N'Banh ngot', N'TL')
INSERT [dbo].[categories] ([id], [name], [prefix]) VALUES (4, N'Banh kem nho', N'TL')
INSERT [dbo].[categories] ([id], [name], [prefix]) VALUES (5, N'Banh kem', N'TL')
INSERT [dbo].[categories] ([id], [name], [prefix]) VALUES (6, N'Dong goi', N'TL')
INSERT [dbo].[categories] ([id], [name], [prefix]) VALUES (7, N'Bánh mi', N'BM')
INSERT [dbo].[categories] ([id], [name], [prefix]) VALUES (8, N'Bánh bao', N'BB')
INSERT [dbo].[categories] ([id], [name], [prefix]) VALUES (9, N'Bánh trung thu', N'BTT')
INSERT [dbo].[categories] ([id], [name], [prefix]) VALUES (10, N'Bánh kem', N'BK')
INSERT [dbo].[categories] ([id], [name], [prefix]) VALUES (11, N'Bánh pizza', N'BP')
INSERT [dbo].[categories] ([id], [name], [prefix]) VALUES (12, N'Bánh bông lan', N'BBL')
INSERT [dbo].[categories] ([id], [name], [prefix]) VALUES (13, N'Noel', N'TL')
SET IDENTITY_INSERT [dbo].[categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Chi] ON 

INSERT [dbo].[Chi] ([id], [name], [quantity], [price]) VALUES (1, N'Ghế', 2, CAST(50000.00 AS Decimal(10, 2)))
INSERT [dbo].[Chi] ([id], [name], [quantity], [price]) VALUES (3, N'ly', 1234, CAST(222222.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[Chi] OFF
GO
INSERT [dbo].[import_product] ([import_id], [product_id], [price], [amount]) VALUES (1, 1, 20000, 10)
GO
SET IDENTITY_INSERT [dbo].[imports] ON 

INSERT [dbo].[imports] ([id], [supplier_id], [admin_id], [total], [created_at], [is_inter], [prefix]) VALUES (1, 1, 5, 10, CAST(N'2023-11-14' AS Date), 1, N'IPP')
SET IDENTITY_INSERT [dbo].[imports] OFF
GO
INSERT [dbo].[order_detail] ([order_id], [product_id], [price], [total]) VALUES (N'1         ', N'3         ', 20000, 5)
INSERT [dbo].[order_detail] ([order_id], [product_id], [price], [total]) VALUES (N'1         ', N'1         ', 20000, 3)
INSERT [dbo].[order_detail] ([order_id], [product_id], [price], [total]) VALUES (N'2         ', N'1         ', 20000, 5)
INSERT [dbo].[order_detail] ([order_id], [product_id], [price], [total]) VALUES (N'18        ', N'12        ', 30000, 1)
INSERT [dbo].[order_detail] ([order_id], [product_id], [price], [total]) VALUES (N'19        ', N'8         ', 20000, 1)
INSERT [dbo].[order_detail] ([order_id], [product_id], [price], [total]) VALUES (N'20        ', N'1         ', 20000, 2)
INSERT [dbo].[order_detail] ([order_id], [product_id], [price], [total]) VALUES (N'17        ', N'12        ', 30000, 1)
INSERT [dbo].[order_detail] ([order_id], [product_id], [price], [total]) VALUES (N'23        ', N'13        ', 15000, 2)
INSERT [dbo].[order_detail] ([order_id], [product_id], [price], [total]) VALUES (N'25        ', N'14        ', 50000, 2)
INSERT [dbo].[order_detail] ([order_id], [product_id], [price], [total]) VALUES (N'20        ', N'1         ', 50000, 2)
GO
SET IDENTITY_INSERT [dbo].[orders] ON 

INSERT [dbo].[orders] ([id], [promotion_id], [receipt_id], [cashier_id], [price], [name], [address], [status], [type], [total], [ship_fee], [payment_method], [is_paid], [prepay], [ordered_at], [note], [change], [receieved], [prefix]) VALUES (1, 20, 1, 5, 20000, N'olaoal', N'q7', 1, 1, 1, 0, 1, 1, 0, CAST(N'2023-11-18' AS Date), N'no', 1, 20000, N'HD')
INSERT [dbo].[orders] ([id], [promotion_id], [receipt_id], [cashier_id], [price], [name], [address], [status], [type], [total], [ship_fee], [payment_method], [is_paid], [prepay], [ordered_at], [note], [change], [receieved], [prefix]) VALUES (2, 20, 1, 5, 20000, N'sushi', N'q10', 0, 1, 1, 0, 1, 1, 0, CAST(N'2023-11-18' AS Date), N'no', 1, 20000, N'HD')
INSERT [dbo].[orders] ([id], [promotion_id], [receipt_id], [cashier_id], [price], [name], [address], [status], [type], [total], [ship_fee], [payment_method], [is_paid], [prepay], [ordered_at], [note], [change], [receieved], [prefix]) VALUES (4, 20, 1, 5, 150000, N'Khong', N'Khong', 1, 1, 6, 1, 1, 1, 0, CAST(N'2023-11-27' AS Date), N'', 1, 150000, N'OD')
INSERT [dbo].[orders] ([id], [promotion_id], [receipt_id], [cashier_id], [price], [name], [address], [status], [type], [total], [ship_fee], [payment_method], [is_paid], [prepay], [ordered_at], [note], [change], [receieved], [prefix]) VALUES (5, 20, 1, 5, 150000, N'Khong', N'Khong', 1, 1, 6, 1, 1, 1, 0, CAST(N'2023-11-27' AS Date), N'', 1, 150000, N'OD')
INSERT [dbo].[orders] ([id], [promotion_id], [receipt_id], [cashier_id], [price], [name], [address], [status], [type], [total], [ship_fee], [payment_method], [is_paid], [prepay], [ordered_at], [note], [change], [receieved], [prefix]) VALUES (6, 20, 1, 5, 150000, N'Khong', N'Khong', 1, 1, 6, 1, 1, 1, 0, CAST(N'2023-11-27' AS Date), N'', 1, 150000, N'OD')
INSERT [dbo].[orders] ([id], [promotion_id], [receipt_id], [cashier_id], [price], [name], [address], [status], [type], [total], [ship_fee], [payment_method], [is_paid], [prepay], [ordered_at], [note], [change], [receieved], [prefix]) VALUES (7, 20, 1, 5, 150000, N'Khong', N'Khong', 1, 1, 6, 1, 1, 1, 0, CAST(N'2023-11-27' AS Date), N'', 1, 150000, N'OD')
INSERT [dbo].[orders] ([id], [promotion_id], [receipt_id], [cashier_id], [price], [name], [address], [status], [type], [total], [ship_fee], [payment_method], [is_paid], [prepay], [ordered_at], [note], [change], [receieved], [prefix]) VALUES (8, 20, 1, 5, 150000, N'Khong', N'Khong', 1, 1, 6, 1, 1, 1, 0, CAST(N'2023-11-27' AS Date), N'', 1, 150000, N'OD')
INSERT [dbo].[orders] ([id], [promotion_id], [receipt_id], [cashier_id], [price], [name], [address], [status], [type], [total], [ship_fee], [payment_method], [is_paid], [prepay], [ordered_at], [note], [change], [receieved], [prefix]) VALUES (10, 20, 1, 5, 225000, N'minh', N'Khong', 1, 1, 9, 1, 1, 1, 0, CAST(N'2023-11-27' AS Date), N'', 1, 225000, N'OD')
INSERT [dbo].[orders] ([id], [promotion_id], [receipt_id], [cashier_id], [price], [name], [address], [status], [type], [total], [ship_fee], [payment_method], [is_paid], [prepay], [ordered_at], [note], [change], [receieved], [prefix]) VALUES (11, 20, 1, 5, 50000, N'Khong', N'Khong', 1, 1, 2, 1, 1, 1, 0, CAST(N'2023-11-28' AS Date), N'', 1, 50000, N'OD')
INSERT [dbo].[orders] ([id], [promotion_id], [receipt_id], [cashier_id], [price], [name], [address], [status], [type], [total], [ship_fee], [payment_method], [is_paid], [prepay], [ordered_at], [note], [change], [receieved], [prefix]) VALUES (13, 20, 1, 5, 90000, N'duy', N'Khong', 1, 1, 9, 1, 1, 1, 0, CAST(N'2023-12-02' AS Date), N'', 1, 90000, N'OD')
INSERT [dbo].[orders] ([id], [promotion_id], [receipt_id], [cashier_id], [price], [name], [address], [status], [type], [total], [ship_fee], [payment_method], [is_paid], [prepay], [ordered_at], [note], [change], [receieved], [prefix]) VALUES (14, 20, 1, 5, 75000, N'Khong', N'Khong', 1, 1, 5, 1, 1, 1, 0, CAST(N'2023-12-02' AS Date), N'', 1, 75000, N'OD')
INSERT [dbo].[orders] ([id], [promotion_id], [receipt_id], [cashier_id], [price], [name], [address], [status], [type], [total], [ship_fee], [payment_method], [is_paid], [prepay], [ordered_at], [note], [change], [receieved], [prefix]) VALUES (17, 20, 1, 5, 15000, N'2', N'Khong', 1, 1, 1, 1, 1, 1, 0, CAST(N'2023-12-02' AS Date), N'', 1, 15000, N'OD')
INSERT [dbo].[orders] ([id], [promotion_id], [receipt_id], [cashier_id], [price], [name], [address], [status], [type], [total], [ship_fee], [payment_method], [is_paid], [prepay], [ordered_at], [note], [change], [receieved], [prefix]) VALUES (18, 20, 1, 5, 15000, N'Khong', N'Khong', 1, 1, 1, 1, 1, 1, 0, CAST(N'2023-12-02' AS Date), N'', 1, 15000, N'OD')
INSERT [dbo].[orders] ([id], [promotion_id], [receipt_id], [cashier_id], [price], [name], [address], [status], [type], [total], [ship_fee], [payment_method], [is_paid], [prepay], [ordered_at], [note], [change], [receieved], [prefix]) VALUES (19, 22, 1, 5, 20000, N'Khong', N'Khong', 0, 2, 1, 1, 1, 1, 0, CAST(N'2023-12-02' AS Date), N'', 1, 20000, N'OD')
INSERT [dbo].[orders] ([id], [promotion_id], [receipt_id], [cashier_id], [price], [name], [address], [status], [type], [total], [ship_fee], [payment_method], [is_paid], [prepay], [ordered_at], [note], [change], [receieved], [prefix]) VALUES (20, 23, 1, 5, 80000, N'ABC Quận 7', N'Khong', 1, 3, 2, 1, 1, 1, 0, CAST(N'2023-12-02' AS Date), N'', 1, 80000, N'OD')
INSERT [dbo].[orders] ([id], [promotion_id], [receipt_id], [cashier_id], [price], [name], [address], [status], [type], [total], [ship_fee], [payment_method], [is_paid], [prepay], [ordered_at], [note], [change], [receieved], [prefix]) VALUES (23, 20, 1, 5, 30000, N'phat_test', N'q7', 1, 1, 2, 0, 1, 1, 0, CAST(N'2023-12-08' AS Date), N'no', 1, 30000, N'OD')
INSERT [dbo].[orders] ([id], [promotion_id], [receipt_id], [cashier_id], [price], [name], [address], [status], [type], [total], [ship_fee], [payment_method], [is_paid], [prepay], [ordered_at], [note], [change], [receieved], [prefix]) VALUES (25, 20, 1, 5, 100000, N'phat_test2', N'q3', 1, 1, 2, 0, 1, 1, 0, CAST(N'2023-12-08' AS Date), N'no', 1, 100000, N'OD')
SET IDENTITY_INSERT [dbo].[orders] OFF
GO
SET IDENTITY_INSERT [dbo].[products] ON 

INSERT [dbo].[products] ([id], [category_id], [name], [price], [is_active], [amount], [expiration_date], [created_at], [updated_at], [prefix], [note], [supplier]) VALUES (1, 4, N'banh kem cheese', 50000, 1, 15, CAST(N'2023-11-14' AS Date), CAST(N'2023-10-29' AS Date), CAST(N'2023-10-29' AS Date), N'SP', N'haha', NULL)
INSERT [dbo].[products] ([id], [category_id], [name], [price], [is_active], [amount], [expiration_date], [created_at], [updated_at], [prefix], [note], [supplier]) VALUES (3, 3, N'banh donut', 20000, 1, 2, CAST(N'2023-11-18' AS Date), CAST(N'2023-11-18' AS Date), CAST(N'2023-11-18' AS Date), N'SP', N'no', NULL)
INSERT [dbo].[products] ([id], [category_id], [name], [price], [is_active], [amount], [expiration_date], [created_at], [updated_at], [prefix], [note], [supplier]) VALUES (8, 12, N'Bánh bông lan trứng muối', 20000, 1, 6, CAST(N'2023-11-28' AS Date), CAST(N'2023-11-28' AS Date), CAST(N'2023-10-29' AS Date), N'SP', N'Bánh rất ngon', NULL)
INSERT [dbo].[products] ([id], [category_id], [name], [price], [is_active], [amount], [expiration_date], [created_at], [updated_at], [prefix], [note], [supplier]) VALUES (10, 2, N'bánh mì bơ tỏi', 25000, 1, 2, CAST(N'2023-11-28' AS Date), CAST(N'2023-11-28' AS Date), CAST(N'2023-10-29' AS Date), N'SP', NULL, NULL)
INSERT [dbo].[products] ([id], [category_id], [name], [price], [is_active], [amount], [expiration_date], [created_at], [updated_at], [prefix], [note], [supplier]) VALUES (12, 5, N'bánh kem xoài', 30000, 1, 26, CAST(N'2023-11-28' AS Date), CAST(N'2023-11-28' AS Date), CAST(N'2023-10-29' AS Date), N'SP', NULL, N'Xưởng quận 2')
INSERT [dbo].[products] ([id], [category_id], [name], [price], [is_active], [amount], [expiration_date], [created_at], [updated_at], [prefix], [note], [supplier]) VALUES (13, 9, N'Banh trung thu nhan thap cam', 15000, 1, 5, CAST(N'2023-12-31' AS Date), CAST(N'2023-12-08' AS Date), CAST(N'2023-12-08' AS Date), N'SP', NULL, NULL)
INSERT [dbo].[products] ([id], [category_id], [name], [price], [is_active], [amount], [expiration_date], [created_at], [updated_at], [prefix], [note], [supplier]) VALUES (14, 13, N'Banh kem xmas', 50000, 1, 5, CAST(N'2023-12-31' AS Date), CAST(N'2023-12-08' AS Date), CAST(N'2023-12-08' AS Date), N'SP', NULL, NULL)
INSERT [dbo].[products] ([id], [category_id], [name], [price], [is_active], [amount], [expiration_date], [created_at], [updated_at], [prefix], [note], [supplier]) VALUES (15, 2, N'Bánh mì thanh long', 5000, 1, 10, CAST(N'2023-12-10' AS Date), CAST(N'2023-12-10' AS Date), CAST(N'2023-10-29' AS Date), N'SP', NULL, NULL)
SET IDENTITY_INSERT [dbo].[products] OFF
GO
SET IDENTITY_INSERT [dbo].[promotions] ON 

INSERT [dbo].[promotions] ([id], [name], [is_active], [created_at], [code], [prefix], [ratio]) VALUES (20, N'Giangsinh', 1, CAST(N'2023-11-14' AS Date), N'001', N'KM', 50)
INSERT [dbo].[promotions] ([id], [name], [is_active], [created_at], [code], [prefix], [ratio]) VALUES (22, N'Khong Giam', 1, CAST(N'2023-12-02' AS Date), N'000', N'KM', 0)
INSERT [dbo].[promotions] ([id], [name], [is_active], [created_at], [code], [prefix], [ratio]) VALUES (23, N'Sinh nhat ABC', 1, CAST(N'2023-12-02' AS Date), N'002', N'KM', 20)
SET IDENTITY_INSERT [dbo].[promotions] OFF
GO
INSERT [dbo].[receipts] ([id], [name], [receieved], [expense], [created_at], [prefix]) VALUES (1, N'Ban hang', 10000, 20000, CAST(N'2023-11-14' AS Date), N'BN')
GO
INSERT [dbo].[roles] ([id], [name]) VALUES (1, N'Giam doc')
INSERT [dbo].[roles] ([id], [name]) VALUES (2, N'Nhan vien ke toan')
GO
SET IDENTITY_INSERT [dbo].[suppliers] ON 

INSERT [dbo].[suppliers] ([id], [name], [phone_number], [address], [created_at], [updated_at], [show], [prefix], [Note]) VALUES (1, N'Duy', N'0987654321', N'Q7', CAST(N'2023-11-14' AS Date), CAST(N'2023-11-14' AS Date), 1, N'KH', NULL)
INSERT [dbo].[suppliers] ([id], [name], [phone_number], [address], [created_at], [updated_at], [show], [prefix], [Note]) VALUES (2, N'Xưởng quận 6', N'012345677', N'quận 6', CAST(N'2023-11-27' AS Date), CAST(N'2023-11-27' AS Date), 1, N'SP', NULL)
INSERT [dbo].[suppliers] ([id], [name], [phone_number], [address], [created_at], [updated_at], [show], [prefix], [Note]) VALUES (3, N'Xưởng quận 2', N'023785389', N'quận 2', CAST(N'2023-11-27' AS Date), CAST(N'2023-11-27' AS Date), 1, N'SP', NULL)
INSERT [dbo].[suppliers] ([id], [name], [phone_number], [address], [created_at], [updated_at], [show], [prefix], [Note]) VALUES (4, N'Xưởng quận 3', N'838479287', N'quận 3', CAST(N'2023-11-27' AS Date), CAST(N'2023-11-27' AS Date), 1, N'SP', NULL)
INSERT [dbo].[suppliers] ([id], [name], [phone_number], [address], [created_at], [updated_at], [show], [prefix], [Note]) VALUES (5, N'Xưởng quận 7', N'924829034', N'quận 7', CAST(N'2023-11-27' AS Date), CAST(N'2023-11-27' AS Date), 1, N'SP', NULL)
SET IDENTITY_INSERT [dbo].[suppliers] OFF
GO
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([id], [role_id], [name], [created_at], [updated_at], [password], [permission], [expirationTime]) VALUES (5, 2, N'nhanvien1', CAST(N'2023-11-27' AS Date), CAST(N'2023-11-27' AS Date), N'nhanvien1           ', N'Thêm, xóa', CAST(N'2023-12-10T22:32:29.000' AS DateTime))
INSERT [dbo].[users] ([id], [role_id], [name], [created_at], [updated_at], [password], [permission], [expirationTime]) VALUES (6, 1, N'giamdoc', CAST(N'2023-11-27' AS Date), CAST(N'2023-11-27' AS Date), N'giamdoc             ', NULL, NULL)
SET IDENTITY_INSERT [dbo].[users] OFF
GO
ALTER TABLE [dbo].[categories] ADD  DEFAULT ('TL') FOR [prefix]
GO
ALTER TABLE [dbo].[imports] ADD  DEFAULT ('D') FOR [prefix]
GO
ALTER TABLE [dbo].[orders] ADD  CONSTRAINT [DF__orders__prefix__4F7CD00D]  DEFAULT ('HD') FOR [prefix]
GO
ALTER TABLE [dbo].[products] ADD  DEFAULT ('SP') FOR [prefix]
GO
ALTER TABLE [dbo].[promotions] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[promotions] ADD  DEFAULT ('KM') FOR [prefix]
GO
ALTER TABLE [dbo].[receipts] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[receipts] ADD  DEFAULT ('BN') FOR [prefix]
GO
ALTER TABLE [dbo].[suppliers] ADD  CONSTRAINT [DF__suppliers__creat__440B1D61]  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[suppliers] ADD  CONSTRAINT [DF__suppliers__updat__44FF419A]  DEFAULT (getdate()) FOR [updated_at]
GO
ALTER TABLE [dbo].[suppliers] ADD  CONSTRAINT [DF_suppliers_show/hide]  DEFAULT ((1)) FOR [show]
GO
ALTER TABLE [dbo].[suppliers] ADD  CONSTRAINT [DF__suppliers__prefi__45F365D3]  DEFAULT ('KH') FOR [prefix]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT (getdate()) FOR [updated_at]
GO
ALTER TABLE [dbo].[images]  WITH CHECK ADD  CONSTRAINT [FK_2] FOREIGN KEY([product_id])
REFERENCES [dbo].[products] ([id])
GO
ALTER TABLE [dbo].[images] CHECK CONSTRAINT [FK_2]
GO
ALTER TABLE [dbo].[import_product]  WITH CHECK ADD  CONSTRAINT [FK_8] FOREIGN KEY([import_id])
REFERENCES [dbo].[imports] ([id])
GO
ALTER TABLE [dbo].[import_product] CHECK CONSTRAINT [FK_8]
GO
ALTER TABLE [dbo].[import_product]  WITH CHECK ADD  CONSTRAINT [FK_9] FOREIGN KEY([product_id])
REFERENCES [dbo].[products] ([id])
GO
ALTER TABLE [dbo].[import_product] CHECK CONSTRAINT [FK_9]
GO
ALTER TABLE [dbo].[imports]  WITH CHECK ADD  CONSTRAINT [FK_5] FOREIGN KEY([supplier_id])
REFERENCES [dbo].[suppliers] ([id])
GO
ALTER TABLE [dbo].[imports] CHECK CONSTRAINT [FK_5]
GO
ALTER TABLE [dbo].[imports]  WITH CHECK ADD  CONSTRAINT [FK_6] FOREIGN KEY([admin_id])
REFERENCES [dbo].[users] ([id])
GO
ALTER TABLE [dbo].[imports] CHECK CONSTRAINT [FK_6]
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [FK_11] FOREIGN KEY([receipt_id])
REFERENCES [dbo].[receipts] ([id])
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [FK_11]
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [FK_12] FOREIGN KEY([cashier_id])
REFERENCES [dbo].[users] ([id])
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [FK_12]
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [FK_orders_promotions] FOREIGN KEY([promotion_id])
REFERENCES [dbo].[promotions] ([id])
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [FK_orders_promotions]
GO
ALTER TABLE [dbo].[products]  WITH CHECK ADD  CONSTRAINT [FK_1] FOREIGN KEY([category_id])
REFERENCES [dbo].[categories] ([id])
GO
ALTER TABLE [dbo].[products] CHECK CONSTRAINT [FK_1]
GO
ALTER TABLE [dbo].[role_permission]  WITH CHECK ADD  CONSTRAINT [FK_3] FOREIGN KEY([permission_id])
REFERENCES [dbo].[permissions] ([id])
GO
ALTER TABLE [dbo].[role_permission] CHECK CONSTRAINT [FK_3]
GO
ALTER TABLE [dbo].[role_permission]  WITH CHECK ADD  CONSTRAINT [FK_4] FOREIGN KEY([role_id])
REFERENCES [dbo].[roles] ([id])
GO
ALTER TABLE [dbo].[role_permission] CHECK CONSTRAINT [FK_4]
GO
ALTER TABLE [dbo].[users]  WITH CHECK ADD  CONSTRAINT [FK_7] FOREIGN KEY([role_id])
REFERENCES [dbo].[roles] ([id])
GO
ALTER TABLE [dbo].[users] CHECK CONSTRAINT [FK_7]
GO
ALTER TABLE [dbo].[promotions]  WITH CHECK ADD  CONSTRAINT [CK_1] CHECK  (([ratio]>=(0) AND [ratio]<=(101)))
GO
ALTER TABLE [dbo].[promotions] CHECK CONSTRAINT [CK_1]
GO
/****** Object:  StoredProcedure [dbo].[AddOrder]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddOrder]
	@promotionID bigint,
	@receipt_id bigint,
	@cashier_id bigint,
	@price float,
	@name nvarchar(255),
	@address nvarchar(512),
	@status int,
	@type int,
	@total int,
	@ship_fee float,
	@payment_method int,
	@is_paid bit,
	@prepay float,
	@ordered_at VARCHAR(10),
	@note text,
	@change int,
	@receieved int,
	@prefix nvarchar(5),
    @productDetails dbo.ProductDetailsType READONLY
AS
BEGIN
    SET NOCOUNT ON;

    -- Thêm đơn hàng vào bảng "orders"
    INSERT INTO orders (promotion_id, receipt_id, cashier_id, price, name, address, status, type, total, ship_fee, payment_method, is_paid, prepay, ordered_at, note, change, receieved, prefix)
    VALUES (@promotionID, @receipt_id,@cashier_id,@price,@name,@address,@status,@type,@total, @ship_fee, @payment_method, @is_paid, @prepay,CONVERT(DATE, @ordered_at), @note, @change, @receieved, @prefix);

    -- Lấy id của đơn hàng vừa thêm
    DECLARE @orderId bigINT;
    SET @orderId = SCOPE_IDENTITY();

    -- Thêm chi tiết đơn hàng vào bảng "order_detail"
    INSERT INTO order_detail (order_id, product_id, price, total)
    SELECT @orderId, product_id, OD_price, OD_total
    FROM @productDetails;

	Update products
	set products.amount = products.amount - OD_total
	from @productDetails
	where products.id = product_id
END
GO
/****** Object:  StoredProcedure [dbo].[AddOrderDetail]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddOrderDetail]
    @order_id BIGINT,
    @product_id BIGINT,
    @price FLOAT,
    @total INT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO order_detail (order_id, product_id, price, total)
    VALUES (@order_id, @product_id, @price, @total);

END
GO
/****** Object:  StoredProcedure [dbo].[AddOrderTemp]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddOrderTemp]
	@promotionID bigint,
	@receipt_id bigint,
	@cashier_id bigint,
	@price float,
	@name nvarchar(255),
	@address nvarchar(512),
	@status int,
	@type int,
	@total int,
	@ship_fee float,
	@payment_method int,
	@is_paid bit,
	@prepay float,
	@ordered_at VARCHAR(10),
	@note text,
	@change int,
	@receieved int,
	@prefix nvarchar(5)
     
AS
BEGIN
    SET NOCOUNT ON;

    -- Thêm đơn hàng vào bảng "orders"
    INSERT INTO orders (promotion_id, receipt_id, cashier_id, price, name, address, status, type, total, ship_fee, payment_method, is_paid, prepay, ordered_at, note, change, receieved, prefix)
    VALUES (@promotionID, @receipt_id,@cashier_id,@price,@name,@address,@status,@type,@total, @ship_fee, @payment_method, @is_paid, @prepay,CONVERT(DATE, @ordered_at), @note, @change, @receieved, @prefix);

    
END
GO
/****** Object:  StoredProcedure [dbo].[chiTietBanBanhNoelThuTienMat]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[chiTietBanBanhNoelThuTienMat]
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        o.ordered_at,
        od.product_id,
        p.name,
        SUM(od.total) AS Amount,
        MAX(od.price) AS Price,
        SUM(od.total * od.price) AS Total
    FROM
        order_detail od
    JOIN
        products p ON od.product_id = p.id
    JOIN
        orders o ON od.order_id = o.id
    WHERE
        p.category_id = '13'
    GROUP BY
        o.ordered_at, od.product_id, p.name;
END
GO
/****** Object:  StoredProcedure [dbo].[chiTietBanBanhThuTienMat]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[chiTietBanBanhThuTienMat]
AS
SELECT
    o.ordered_at,
    od.product_id,
    p.name,
    SUM(od.total) AS Amount,
    MAX(od.price) AS Price,
    SUM(od.total * od.price) AS Total
FROM
    order_detail od
JOIN
    products p ON od.product_id = p.id
JOIN
    orders o ON od.order_id = o.id
GROUP BY
    o.ordered_at, od.product_id, p.name;
GO
/****** Object:  StoredProcedure [dbo].[chiTietBanBanhTrungThuThuTienMat]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[chiTietBanBanhTrungThuThuTienMat]
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        o.ordered_at,
        od.product_id,
        p.name,
        SUM(od.total) AS Amount,
        MAX(od.price) AS Price,
        SUM(od.total * od.price) AS Total
    FROM
        order_detail od
    JOIN
        products p ON od.product_id = p.id
    JOIN
        orders o ON od.order_id = o.id
    WHERE
        p.category_id = '9'
    GROUP BY
        o.ordered_at, od.product_id, p.name;
END
GO
/****** Object:  StoredProcedure [dbo].[danhMucBanh_select]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[danhMucBanh_select]
AS
BEGIN
    SELECT c.name as categories_name, p.id, p.name, ip.price as price_bought, p.price as price_sell, p.is_active
    FROM products p, categories c, import_product ip
	where c.id = p.category_id
    --INNER JOIN categories c ON p.category_id = c.id
    --INNER JOIN import_product ip ON p.id = ip.product_id;
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteProductRow]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DeleteProductRow]
    @ProductID INT
AS
BEGIN
    DELETE FROM products
    WHERE id = @ProductID;
END;
GO
/****** Object:  StoredProcedure [dbo].[get_orderID]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[get_orderID]
@date VARCHAR(20)
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @convertedDate DATE;
	SET @convertedDate = CONVERT(DATE,@date,103);
	SELECT o.id
	FROM orders o
	WHERE CONVERT(DATE, o.ordered_at, 103) = @convertedDate
END
GO
/****** Object:  StoredProcedure [dbo].[getAllProducts]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getAllProducts] 

AS
BEGIN
	SET NOCOUNT ON;
	SELECT c.name as categoriesName, p.id, p.name, p.amount, p.price
	FROM categories c, products p
	WHERE p.category_id = c.id
END
GO
/****** Object:  StoredProcedure [dbo].[getAllPromotions]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[getAllPromotions] 

AS
BEGIN
	SET NOCOUNT ON;
	SELECT p.id, p.name, p.ratio
	FROM promotions p
	WHERE p.is_active = 1
END
GO
/****** Object:  StoredProcedure [dbo].[GetLatestOrderId]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetLatestOrderId]
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @latestId BIGINT;

    SELECT @latestId = MAX(id)
    FROM orders;

    SELECT @latestId AS LatestOrderId;
END
GO
/****** Object:  StoredProcedure [dbo].[GetProductsByDate]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetProductsByDate]
    @TargetDate VARCHAR(10)
AS
BEGIN
    DECLARE @ConvertedDate DATE;
    SET @ConvertedDate = CONVERT(DATE, @TargetDate, 103);

    SELECT id AS MaBanh, name AS TenBanh, amount AS SoLuong, price AS Gia, expiration_date, created_at, prefix
    FROM products
    WHERE CONVERT(DATE, created_at, 103) = @ConvertedDate;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetProductsByDateHaveSupplier]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetProductsByDateHaveSupplier]
    @TargetDate VARCHAR(10)
AS
BEGIN
    DECLARE @ConvertedDate DATE;
    SET @ConvertedDate = CONVERT(DATE, @TargetDate, 103);

    SELECT id AS MaBanh, name AS TenBanh, amount AS SoLuong, price AS Gia, expiration_date, created_at, prefix, supplier AS NhaCungCap
    FROM products
    WHERE CONVERT(DATE, created_at, 103) = @ConvertedDate AND supplier IS NOT NULL;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetProductsBySupplier]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetProductsBySupplier]
    @name NVARCHAR(50)
AS
BEGIN
    SELECT id AS MaBanh, name AS TenBanh, amount AS SoLuong, price AS Gia, expiration_date, created_at, prefix, supplier AS NhaCungCap
    FROM products
    WHERE supplier = @name;
END
GO
/****** Object:  StoredProcedure [dbo].[ImportInToNhapBanhMuaNgoai]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ImportInToNhapBanhMuaNgoai]
AS
BEGIN
    SELECT id AS MaBanh, name AS TenBanh, amount AS SoLuong, price AS Gia, expiration_date, created_at, prefix, supplier AS NhaCungCap
    FROM products WHERE supplier IS NOT NULL;
END;
GO
/****** Object:  StoredProcedure [dbo].[ImportInToNhapBanhNoiBo]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ImportInToNhapBanhNoiBo]
AS
BEGIN
    SELECT id AS MaBanh, name AS TenBanh, amount AS Ton, amount AS SoLuong, price AS Gia 
    FROM products;
END;
GO
/****** Object:  StoredProcedure [dbo].[load_xuat_di]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[load_xuat_di]
@date VARCHAR(20)
AS
BEGIN
	DECLARE @convertedDate DATE;
	SET @convertedDate = CONVERT(DATE,@date,103);
    SELECT	o.id as order_id,
			p.id, 
			p.name, 
			p.amount, 
			od.total, 
			CASE
				WHEN o.status = 1 THEN p.price - (p.price * pr.ratio /100)
				WHEN o.status = 0 THEN p.price
			END AS price,
			(CASE
				WHEN o.status = 1 THEN p.price - (p.price * pr.ratio / 100)
				WHEN o.status = 0 THEN p.price
			END * od.total) AS total_amount,
			o.note
    FROM order_detail od, products p, orders o, promotions pr
    WHERE od.order_id = o.id and od.product_id = p.id and o.promotion_id = pr.id and CONVERT(DATE, o.ordered_at, 103) = @convertedDate;
END
GO
/****** Object:  StoredProcedure [dbo].[order_delete]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[order_delete] 
@ID INT
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @IDDelete int;
	SET @IDDelete = @ID;
	IF EXISTS( SELECT 1 FROM orders WHERE @IDDelete = orders.id)
	BEGIN
		DELETE FROM order_detail WHERE order_id = @IDDelete;
		DELETE FROM orders WHERE id = @IDDelete;
	END
END
GO
/****** Object:  StoredProcedure [dbo].[SelectDanhMucKhachHang]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectDanhMucKhachHang]
AS
BEGIN
    SELECT * FROM [ABC_bakery].[dbo].[suppliers]
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateNoteInOrder]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateNoteInOrder]
    @Note text,
    @OrderID INT
AS
BEGIN
    -- Kiểm tra xem Order có tồn tại hay không
    IF NOT EXISTS (SELECT 1 FROM Orders WHERE id = @OrderID)
    BEGIN
        RAISERROR('Order not found', 16, 1)
        RETURN
    END

    BEGIN TRY
        -- Bắt đầu giao dịch
        BEGIN TRANSACTION
        
        -- Cập nhật ghi chú cho Order
        UPDATE Orders
        SET note = @Note
        WHERE id = @OrderID
        
        -- Hoàn thành giao dịch
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        -- Nếu có lỗi, rollback giao dịch
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION
        
        -- Trả về thông báo lỗi
        THROW
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[xuat_di]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[xuat_di]
@date VARCHAR(20)
AS
BEGIN
	DECLARE @convertedDate DATE;
	SET @convertedDate = CONVERT(DATE,@date,103);
    SELECT	o.id as order_id,
			p.id, 
			p.name, 
			p.amount, 
			od.total, 
			CASE
				WHEN o.status = 1 THEN p.price - (p.price * pr.ratio /100)
				WHEN o.status = 0 THEN p.price
			END AS price,
			(CASE
				WHEN o.status = 1 THEN p.price - (p.price * pr.ratio / 100)
				WHEN o.status = 0 THEN p.price
			END * od.total) AS total_amount,
			o.name as customerName,
			o.note
    FROM order_detail od, products p, orders o, promotions pr
    WHERE od.order_id = o.id and od.product_id = p.id and o.promotion_id = pr.id and o.type = 1 and CONVERT(DATE, o.ordered_at, 103) = @convertedDate;
END
GO
/****** Object:  StoredProcedure [dbo].[xuat_huy]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[xuat_huy]
@date VARCHAR(20)
AS
BEGIN
	DECLARE @convertedDate DATE;
	SET @convertedDate = CONVERT(DATE,@date,103);
    SELECT	o.id as order_id,
			p.id, 
			p.name, 
			p.amount, 
			od.total, 
			CASE
				WHEN o.status = 1 THEN p.price - (p.price * pr.ratio /100)
				WHEN o.status = 0 THEN p.price
			END AS price,
			(CASE
				WHEN o.status = 1 THEN p.price - (p.price * pr.ratio / 100)
				WHEN o.status = 0 THEN p.price
			END * od.total) AS total_amount,
			o.name as customerName,
			o.note
    FROM order_detail od, products p, orders o, promotions pr
    WHERE od.order_id = o.id and od.product_id = p.id and o.promotion_id = pr.id and o.type = 2 and CONVERT(DATE, o.ordered_at, 103) = @convertedDate;
END
GO
/****** Object:  StoredProcedure [dbo].[xuat_khac]    Script Date: 12/10/2023 10:40:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[xuat_khac]
@date VARCHAR(20)
AS
BEGIN
	DECLARE @convertedDate DATE;
	SET @convertedDate = CONVERT(DATE,@date,103);
    SELECT	o.id as order_id,
			p.id, 
			p.name, 
			p.amount, 
			od.total, 
			CASE
				WHEN o.status = 1 THEN p.price - (p.price * pr.ratio /100)
				WHEN o.status = 0 THEN p.price
			END AS price,
			(CASE
				WHEN o.status = 1 THEN p.price - (p.price * pr.ratio / 100)
				WHEN o.status = 0 THEN p.price
			END * od.total) AS total_amount,
			o.name as customerName,
			o.note
    FROM order_detail od, products p, orders o, promotions pr
    WHERE od.order_id = o.id and od.product_id = p.id and o.promotion_id = pr.id and o.type = 3 and CONVERT(DATE, o.ordered_at, 103) = @convertedDate;
END
GO
USE [master]
GO
ALTER DATABASE [ABC_bakery] SET  READ_WRITE 
GO
