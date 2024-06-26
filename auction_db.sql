USE [master]
GO
/****** Object:  Database [Auction]    Script Date: 4/6/2024 10:41:12 PM ******/
CREATE DATABASE [Auction]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Auction', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Auction.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Auction_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Auction_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Auction] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Auction].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Auction] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Auction] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Auction] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Auction] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Auction] SET ARITHABORT OFF 
GO
ALTER DATABASE [Auction] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Auction] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Auction] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Auction] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Auction] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Auction] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Auction] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Auction] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Auction] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Auction] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Auction] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Auction] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Auction] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Auction] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Auction] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Auction] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Auction] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Auction] SET RECOVERY FULL 
GO
ALTER DATABASE [Auction] SET  MULTI_USER 
GO
ALTER DATABASE [Auction] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Auction] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Auction] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Auction] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Auction] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Auction] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Auction', N'ON'
GO
ALTER DATABASE [Auction] SET QUERY_STORE = OFF
GO
USE [Auction]
GO
/****** Object:  Table [dbo].[Bid]    Script Date: 4/6/2024 10:41:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bid](
	[bidder_id] [int] NOT NULL,
	[lot_id] [int] NOT NULL,
	[money] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bidder]    Script Date: 4/6/2024 10:41:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bidder](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[email] [varchar](255) NOT NULL,
 CONSTRAINT [PK_Bidder] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lot]    Script Date: 4/6/2024 10:41:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lot](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[expirationTime] [datetime] NOT NULL,
	[type] [varchar](50) NOT NULL,
	[brand] [varchar](max) NULL,
	[model] [varchar](max) NULL,
	[color] [varchar](max) NULL,
	[total_km] [float] NULL,
	[battery_power] [int] NULL,
	[location] [varchar](max) NULL,
	[style] [varchar](max) NULL,
	[builtTime] [date] NULL,
 CONSTRAINT [PK_Lot] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 1, 1)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (2, 1, 40)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 1, 55)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (2, 1, 66)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 1, 124)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 1, 125)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 3, 3)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 3, 5)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 3, 7)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 3, 8)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 3, 24)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 3, 29)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 3, 30)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 3, 40)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 5, 2)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 2, 10)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 1, 100)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (2, 1, 111)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 1, 122)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 2, 1)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 3, 1)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 4, 1)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 2, 7)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 3, 9)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (2, 3, 10)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 3, 11)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (2, 3, 12)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (2, 3, 13)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (2, 3, 14)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 3, 15)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 3, 16)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 3, 17)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 3, 18)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 3, 19)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 3, 20)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 3, 21)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 3, 22)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 3, 23)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 5, 1)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 6, 1)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 2, 11)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 2, 12)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 2, 13)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 8, 1)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 11, 1)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 11, 33)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 12, 1)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 1, 126)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 2, 3)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 2, 5)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 2, 6)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 3, 25)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 3, 26)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 3, 27)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 3, 28)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 9, 1)
INSERT [dbo].[Bid] ([bidder_id], [lot_id], [money]) VALUES (1, 10, 1)
GO
SET IDENTITY_INSERT [dbo].[Bidder] ON 

INSERT [dbo].[Bidder] ([id], [name], [email]) VALUES (1, N'Vlad', N'vladislav.atamanciuc@student.nhlstenden.com')
INSERT [dbo].[Bidder] ([id], [name], [email]) VALUES (2, N'Gerjan', N'gerjan.van.oenen@nhlstenden.com')
INSERT [dbo].[Bidder] ([id], [name], [email]) VALUES (3, N'Jan', N'jan.doornbos@nhlstenden.com')
SET IDENTITY_INSERT [dbo].[Bidder] OFF
GO
SET IDENTITY_INSERT [dbo].[Lot] ON 

INSERT [dbo].[Lot] ([id], [expirationTime], [type], [brand], [model], [color], [total_km], [battery_power], [location], [style], [builtTime]) VALUES (1, CAST(N'2024-04-06T12:00:00.000' AS DateTime), N'Car', N'Ford', N'Mustang', N'Blue', 10000, NULL, NULL, NULL, NULL)
INSERT [dbo].[Lot] ([id], [expirationTime], [type], [brand], [model], [color], [total_km], [battery_power], [location], [style], [builtTime]) VALUES (2, CAST(N'2024-04-08T12:00:00.000' AS DateTime), N'Car', N'Test', N'Test', N'Test', 45987654, NULL, NULL, NULL, NULL)
INSERT [dbo].[Lot] ([id], [expirationTime], [type], [brand], [model], [color], [total_km], [battery_power], [location], [style], [builtTime]) VALUES (3, CAST(N'2024-04-08T12:00:00.000' AS DateTime), N'Car', N'Test2', N'Test2', N'Test2', 485967, NULL, NULL, NULL, NULL)
INSERT [dbo].[Lot] ([id], [expirationTime], [type], [brand], [model], [color], [total_km], [battery_power], [location], [style], [builtTime]) VALUES (4, CAST(N'2024-04-08T12:00:00.000' AS DateTime), N'Car', N'Test3', N'Test3', N'Test3', 32423, NULL, NULL, NULL, NULL)
INSERT [dbo].[Lot] ([id], [expirationTime], [type], [brand], [model], [color], [total_km], [battery_power], [location], [style], [builtTime]) VALUES (5, CAST(N'2024-04-08T12:00:00.000' AS DateTime), N'Telephone', N'Apple', N'Iphone 13 Pro Max', N'Space Gray', NULL, 94, NULL, NULL, NULL)
INSERT [dbo].[Lot] ([id], [expirationTime], [type], [brand], [model], [color], [total_km], [battery_power], [location], [style], [builtTime]) VALUES (6, CAST(N'2024-04-08T12:00:00.000' AS DateTime), N'House', NULL, NULL, NULL, NULL, NULL, N'Van Schaikweg 94', N'Educational', CAST(N'2000-04-08' AS Date))
INSERT [dbo].[Lot] ([id], [expirationTime], [type], [brand], [model], [color], [total_km], [battery_power], [location], [style], [builtTime]) VALUES (8, CAST(N'2024-04-11T21:52:42.000' AS DateTime), N'Car', N'Test4', N'Test4', N'Test4', 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[Lot] ([id], [expirationTime], [type], [brand], [model], [color], [total_km], [battery_power], [location], [style], [builtTime]) VALUES (9, CAST(N'2024-04-06T21:58:33.000' AS DateTime), N'Telephone', N'Test5', N'Test5', N'Test5', NULL, 54, NULL, NULL, NULL)
INSERT [dbo].[Lot] ([id], [expirationTime], [type], [brand], [model], [color], [total_km], [battery_power], [location], [style], [builtTime]) VALUES (10, CAST(N'2024-04-06T22:00:53.000' AS DateTime), N'Telephone', N'Test6', N'Test6', N'Test6', NULL, 66, NULL, NULL, NULL)
INSERT [dbo].[Lot] ([id], [expirationTime], [type], [brand], [model], [color], [total_km], [battery_power], [location], [style], [builtTime]) VALUES (11, CAST(N'2024-04-08T22:16:44.000' AS DateTime), N'House', NULL, NULL, NULL, NULL, NULL, N'Somewhere', N'Fusion', CAST(N'2023-09-18' AS Date))
INSERT [dbo].[Lot] ([id], [expirationTime], [type], [brand], [model], [color], [total_km], [battery_power], [location], [style], [builtTime]) VALUES (12, CAST(N'2024-04-11T22:16:44.000' AS DateTime), N'Telephone', N'Samsung', N'S23', N'Yellow', NULL, 1, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Lot] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UniqueEmail]    Script Date: 4/6/2024 10:41:12 PM ******/
ALTER TABLE [dbo].[Bidder] ADD  CONSTRAINT [UniqueEmail] UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UniqueName]    Script Date: 4/6/2024 10:41:12 PM ******/
ALTER TABLE [dbo].[Bidder] ADD  CONSTRAINT [UniqueName] UNIQUE NONCLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Bid] ADD  CONSTRAINT [DF_Bid_money]  DEFAULT ((1)) FOR [money]
GO
ALTER TABLE [dbo].[Bid]  WITH CHECK ADD  CONSTRAINT [FK_Bidder_Bid] FOREIGN KEY([bidder_id])
REFERENCES [dbo].[Bidder] ([id])
GO
ALTER TABLE [dbo].[Bid] CHECK CONSTRAINT [FK_Bidder_Bid]
GO
ALTER TABLE [dbo].[Bid]  WITH CHECK ADD  CONSTRAINT [FK_Lot_Bid] FOREIGN KEY([lot_id])
REFERENCES [dbo].[Lot] ([id])
GO
ALTER TABLE [dbo].[Bid] CHECK CONSTRAINT [FK_Lot_Bid]
GO
/****** Object:  Trigger [dbo].[trgAfterInsert]    Script Date: 4/6/2024 10:41:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[trgAfterInsert]
ON [dbo].[Lot]
AFTER INSERT
AS
BEGIN

	DECLARE @lot_id INT;

    SELECT @lot_id = id FROM INSERTED;

    
	INSERT INTO [dbo].[Bid]
			   ([bidder_id]
			   ,[lot_id]
			   ,[money])
		 VALUES
			   (1, @lot_id, 1)
END;
GO
ALTER TABLE [dbo].[Lot] ENABLE TRIGGER [trgAfterInsert]
GO
USE [master]
GO
ALTER DATABASE [Auction] SET  READ_WRITE 
GO
