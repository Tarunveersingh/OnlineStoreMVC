USE [master]
GO
/****** Object:  Database [OnlineStoreEntity]    Script Date: 9/17/2020 11:26:12 PM ******/
CREATE DATABASE [OnlineStoreEntity]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'OnlineStoreEntity_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\OnlineStoreEntity.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'OnlineStoreEntity_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\OnlineStoreEntity.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [OnlineStoreEntity] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OnlineStoreEntity].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OnlineStoreEntity] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OnlineStoreEntity] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OnlineStoreEntity] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OnlineStoreEntity] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OnlineStoreEntity] SET ARITHABORT OFF 
GO
ALTER DATABASE [OnlineStoreEntity] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [OnlineStoreEntity] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OnlineStoreEntity] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OnlineStoreEntity] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OnlineStoreEntity] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OnlineStoreEntity] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OnlineStoreEntity] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OnlineStoreEntity] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OnlineStoreEntity] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OnlineStoreEntity] SET  DISABLE_BROKER 
GO
ALTER DATABASE [OnlineStoreEntity] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OnlineStoreEntity] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OnlineStoreEntity] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OnlineStoreEntity] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OnlineStoreEntity] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OnlineStoreEntity] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [OnlineStoreEntity] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OnlineStoreEntity] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [OnlineStoreEntity] SET  MULTI_USER 
GO
ALTER DATABASE [OnlineStoreEntity] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OnlineStoreEntity] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OnlineStoreEntity] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OnlineStoreEntity] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [OnlineStoreEntity] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [OnlineStoreEntity] SET QUERY_STORE = OFF
GO
USE [OnlineStoreEntity]
GO
/****** Object:  Table [dbo].[AdminDetails]    Script Date: 9/17/2020 11:26:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminDetails](
	[AdminName] [varchar](50) NULL,
	[AdminPassword] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContactDetails]    Script Date: 9/17/2020 11:26:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContactDetails](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Contact] [varchar](50) NULL,
	[Message] [varchar](50) NULL,
 CONSTRAINT [PK_ContactDetails] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PurchaseDetails]    Script Date: 9/17/2020 11:26:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseDetails](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](50) NULL,
	[CompanyName] [varchar](50) NULL,
	[Mobile] [varchar](50) NULL,
	[Qty] [varchar](50) NULL,
	[BuyingDate] [varchar](50) NULL,
	[Price] [varchar](50) NULL,
	[Bill] [varchar](50) NULL,
 CONSTRAINT [PK_PurchaseDetails] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SaleDetails]    Script Date: 9/17/2020 11:26:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaleDetails](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](50) NULL,
	[CustomerName] [varchar](50) NULL,
	[Mobile] [varchar](50) NULL,
	[SalingDate] [varchar](50) NULL,
	[Qty] [varchar](50) NULL,
	[Price] [varchar](50) NULL,
	[Total] [varchar](50) NULL,
 CONSTRAINT [PK_SaleDetails] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StockDetails]    Script Date: 9/17/2020 11:26:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockDetails](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](50) NULL,
	[Qty] [varchar](50) NULL,
	[Type] [varchar](50) NULL,
 CONSTRAINT [PK_StockDetails] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [OnlineStoreEntity] SET  READ_WRITE 
GO
