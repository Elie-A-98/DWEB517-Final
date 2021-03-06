USE [master]
GO
/****** Object:  Database [moph]    Script Date: 21/09/2020 1:44:50 PM ******/
CREATE DATABASE [moph]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'moph', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\moph.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'moph_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\moph_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [moph] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [moph].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [moph] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [moph] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [moph] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [moph] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [moph] SET ARITHABORT OFF 
GO
ALTER DATABASE [moph] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [moph] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [moph] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [moph] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [moph] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [moph] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [moph] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [moph] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [moph] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [moph] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [moph] SET  DISABLE_BROKER 
GO
ALTER DATABASE [moph] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [moph] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [moph] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [moph] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [moph] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [moph] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [moph] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [moph] SET RECOVERY FULL 
GO
ALTER DATABASE [moph] SET  MULTI_USER 
GO
ALTER DATABASE [moph] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [moph] SET DB_CHAINING OFF 
GO
ALTER DATABASE [moph] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [moph] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'moph', N'ON'
GO
USE [moph]
GO
/****** Object:  Table [dbo].[Doctor]    Script Date: 21/09/2020 1:44:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Doctor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[firstName] [varchar](50) NOT NULL,
	[lastName] [varchar](50) NOT NULL,
	[phone] [varchar](50) NULL,
	[dateOfBirth] [date] NULL,
	[email] [varchar](50) NULL,
	[salary] [int] NOT NULL,
	[speciality] [varchar](50) NOT NULL,
	[hospital] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Hospital]    Script Date: 21/09/2020 1:44:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Hospital](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nname] [varchar](50) NOT NULL,
	[location] [varchar](50) NOT NULL,
	[phone] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Speciality]    Script Date: 21/09/2020 1:44:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Speciality](
	[code] [varchar](50) NOT NULL,
	[nname] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Doctor] ON 

INSERT [dbo].[Doctor] ([id], [firstName], [lastName], [phone], [dateOfBirth], [email], [salary], [speciality], [hospital]) VALUES (2, N'ddddd', N'l1', N'1111', CAST(0xE2260B00 AS Date), N'we@hotmail.com', 12, N'ga', 1)
SET IDENTITY_INSERT [dbo].[Doctor] OFF
SET IDENTITY_INSERT [dbo].[Hospital] ON 

INSERT [dbo].[Hospital] ([id], [nname], [location], [phone]) VALUES (1, N'n1', N'l1', N'1111')
INSERT [dbo].[Hospital] ([id], [nname], [location], [phone]) VALUES (2, N'hospital2', N'location2', N'222222')
INSERT [dbo].[Hospital] ([id], [nname], [location], [phone]) VALUES (3, N'hospital3', N'location3', N'333333')
SET IDENTITY_INSERT [dbo].[Hospital] OFF
INSERT [dbo].[Speciality] ([code], [nname]) VALUES (N'ca', N'cardiology')
INSERT [dbo].[Speciality] ([code], [nname]) VALUES (N'der', N'dermatology')
INSERT [dbo].[Speciality] ([code], [nname]) VALUES (N'ga', N'gastroentrelogy')
ALTER TABLE [dbo].[Doctor]  WITH CHECK ADD  CONSTRAINT [Doctor_Hopital] FOREIGN KEY([hospital])
REFERENCES [dbo].[Hospital] ([id])
GO
ALTER TABLE [dbo].[Doctor] CHECK CONSTRAINT [Doctor_Hopital]
GO
ALTER TABLE [dbo].[Doctor]  WITH CHECK ADD  CONSTRAINT [Doctor_Speciality] FOREIGN KEY([speciality])
REFERENCES [dbo].[Speciality] ([code])
GO
ALTER TABLE [dbo].[Doctor] CHECK CONSTRAINT [Doctor_Speciality]
GO
USE [master]
GO
ALTER DATABASE [moph] SET  READ_WRITE 
GO
