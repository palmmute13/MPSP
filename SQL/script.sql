USE [master]
GO
/****** Object:  Database [logdb]    Script Date: 23/4/2019 8:30:45 PM ******/
CREATE DATABASE [logdb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'logdb', FILENAME = N'D:\Programas\Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\logdb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'logdb_log', FILENAME = N'D:\Programas\Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\logdb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [logdb] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [logdb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [logdb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [logdb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [logdb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [logdb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [logdb] SET ARITHABORT OFF 
GO
ALTER DATABASE [logdb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [logdb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [logdb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [logdb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [logdb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [logdb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [logdb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [logdb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [logdb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [logdb] SET  ENABLE_BROKER 
GO
ALTER DATABASE [logdb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [logdb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [logdb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [logdb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [logdb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [logdb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [logdb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [logdb] SET RECOVERY FULL 
GO
ALTER DATABASE [logdb] SET  MULTI_USER 
GO
ALTER DATABASE [logdb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [logdb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [logdb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [logdb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [logdb] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'logdb', N'ON'
GO
ALTER DATABASE [logdb] SET QUERY_STORE = OFF
GO
USE [logdb]
GO
/****** Object:  User [localhost]    Script Date: 23/4/2019 8:30:45 PM ******/
CREATE USER [localhost] FOR LOGIN [localhost] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[logtable]    Script Date: 23/4/2019 8:30:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[logtable](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[cd_usuario] [char](11) NULL,
	[nombres] [varchar](25) NULL,
	[apellidos] [varchar](30) NULL,
	[telefono] [varchar](20) NULL,
	[email] [varchar](50) NOT NULL,
	[usuario] [varchar](20) NULL,
	[contrasena] [varchar](25) NULL,
	[estado] [varchar](13) NULL,
	[fecha_ingreso] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[logtable] ON 

INSERT [dbo].[logtable] ([id_usuario], [cd_usuario], [nombres], [apellidos], [telefono], [email], [usuario], [contrasena], [estado], [fecha_ingreso]) VALUES (1, N'03700933389', N'andy', N'peralta', N'8299813829', N'palmmute13@hotmail.com', N'palmm', N'3829777', N'Administrador', CAST(N'2018-11-23' AS Date))
INSERT [dbo].[logtable] ([id_usuario], [cd_usuario], [nombres], [apellidos], [telefono], [email], [usuario], [contrasena], [estado], [fecha_ingreso]) VALUES (2, N'11111111111', N'Anderson', N'De los Santos', N'85454545645', N'anderson@gmail.com', N'Anderson', N'2222', N'Administrador', CAST(N'2018-12-03' AS Date))
INSERT [dbo].[logtable] ([id_usuario], [cd_usuario], [nombres], [apellidos], [telefono], [email], [usuario], [contrasena], [estado], [fecha_ingreso]) VALUES (3, N'33333333333', N'Jeferson', N'De los Santos', N'9999999999', N'jef@gmail.com', N'Jef', N'5555', N'Administrador', CAST(N'2018-12-03' AS Date))
INSERT [dbo].[logtable] ([id_usuario], [cd_usuario], [nombres], [apellidos], [telefono], [email], [usuario], [contrasena], [estado], [fecha_ingreso]) VALUES (4, N'88888888888', N'Keroly', N'vasquez', N'33333333333', N'Keroly@gmail.com', N'Keroly', N'5555', N'Administrador', CAST(N'2018-12-03' AS Date))
INSERT [dbo].[logtable] ([id_usuario], [cd_usuario], [nombres], [apellidos], [telefono], [email], [usuario], [contrasena], [estado], [fecha_ingreso]) VALUES (5, N'           ', N'', N'', N'', N'lghdfklghdfjkl', N'', N'', N'', CAST(N'2018-12-03' AS Date))
INSERT [dbo].[logtable] ([id_usuario], [cd_usuario], [nombres], [apellidos], [telefono], [email], [usuario], [contrasena], [estado], [fecha_ingreso]) VALUES (6, N'           ', N'', N'', N'', N'palmmute13@gmail.com', N'', N'', N'', CAST(N'2018-12-03' AS Date))
INSERT [dbo].[logtable] ([id_usuario], [cd_usuario], [nombres], [apellidos], [telefono], [email], [usuario], [contrasena], [estado], [fecha_ingreso]) VALUES (7, N'           ', N'', N'', N'', N'palmmute13@gmail.com', N'', N'', N'', CAST(N'2018-12-03' AS Date))
INSERT [dbo].[logtable] ([id_usuario], [cd_usuario], [nombres], [apellidos], [telefono], [email], [usuario], [contrasena], [estado], [fecha_ingreso]) VALUES (8, N'03700933389', N'Julio', N'Perez', N'8095868872', N'palmmute13@gmail.com', N'', N'', N'', CAST(N'2018-12-03' AS Date))
INSERT [dbo].[logtable] ([id_usuario], [cd_usuario], [nombres], [apellidos], [telefono], [email], [usuario], [contrasena], [estado], [fecha_ingreso]) VALUES (10, N'12341532165', N'Rafael', N'Fernandez', N'65432162135', N'rafael@gmail.com', N'rafael', N'1111', N'Administrador', CAST(N'2018-12-03' AS Date))
INSERT [dbo].[logtable] ([id_usuario], [cd_usuario], [nombres], [apellidos], [telefono], [email], [usuario], [contrasena], [estado], [fecha_ingreso]) VALUES (11, N'03532655656', N'Pedro', N'Peralta', N'85656556566', N'palmmute@hotmail.com', N'Pedro', N'3030', N'Administrador', CAST(N'2018-12-03' AS Date))
INSERT [dbo].[logtable] ([id_usuario], [cd_usuario], [nombres], [apellidos], [telefono], [email], [usuario], [contrasena], [estado], [fecha_ingreso]) VALUES (12, N'03700033389', N'Pedro', N'Jimenez', N'80958655963', N'Pallmmute13@mail.com', N'Mario', N'1111', N'Administrador', CAST(N'2018-12-03' AS Date))
INSERT [dbo].[logtable] ([id_usuario], [cd_usuario], [nombres], [apellidos], [telefono], [email], [usuario], [contrasena], [estado], [fecha_ingreso]) VALUES (13, N'03700933389', N'Pedro', N'Peralta', N'8299813829', N'palmmute13@hotmail.com', N'Andy', N'3829777', N'Invitado', CAST(N'2018-11-18' AS Date))
INSERT [dbo].[logtable] ([id_usuario], [cd_usuario], [nombres], [apellidos], [telefono], [email], [usuario], [contrasena], [estado], [fecha_ingreso]) VALUES (14, N'03700033389', N'Pedro', N'Peralta', N'8093338569', N'palmmute@gmail.com', N'Mir', N'1111', N'Administrador', CAST(N'2018-12-04' AS Date))
INSERT [dbo].[logtable] ([id_usuario], [cd_usuario], [nombres], [apellidos], [telefono], [email], [usuario], [contrasena], [estado], [fecha_ingreso]) VALUES (15, N'03888966635', N'Chimi', N'Nation', N'8596587445', N'sistemof@hotmail.com', N'Combertion', N'7777', N'Administrador', CAST(N'2018-12-04' AS Date))
INSERT [dbo].[logtable] ([id_usuario], [cd_usuario], [nombres], [apellidos], [telefono], [email], [usuario], [contrasena], [estado], [fecha_ingreso]) VALUES (16, N'03700933389', N'Julu', N'puru', N'8095896566', N'palmmute143@gmail.com', N'Jer', N'55555', N'Administrador', CAST(N'2018-12-04' AS Date))
INSERT [dbo].[logtable] ([id_usuario], [cd_usuario], [nombres], [apellidos], [telefono], [email], [usuario], [contrasena], [estado], [fecha_ingreso]) VALUES (17, N'03700933389', N'Hector', N'Lugo', N'8093565685', N'palmmute13@gmail.com', N'Mer', N'5555', N'Administrador', CAST(N'2018-12-04' AS Date))
INSERT [dbo].[logtable] ([id_usuario], [cd_usuario], [nombres], [apellidos], [telefono], [email], [usuario], [contrasena], [estado], [fecha_ingreso]) VALUES (18, N'03700933389', N'Pedro', N'Peralta', N'8099813829', N'palmmute13@gmail.com', N'Julio', N'5555', N'Administrador', CAST(N'2018-12-04' AS Date))
INSERT [dbo].[logtable] ([id_usuario], [cd_usuario], [nombres], [apellidos], [telefono], [email], [usuario], [contrasena], [estado], [fecha_ingreso]) VALUES (19, N'03700033389', N'Pedro Aneudys', N'Peralta Rivera', N'8095863586', N'palmmute13@hotmail.com', N'Juxy', N'1111', N'Administrador', CAST(N'2018-12-04' AS Date))
INSERT [dbo].[logtable] ([id_usuario], [cd_usuario], [nombres], [apellidos], [telefono], [email], [usuario], [contrasena], [estado], [fecha_ingreso]) VALUES (20, N'03700933389', N'Javier Moly', N'Santos Minaya', N'8099813829', N'anderson@gmail.com', N'Javi', N'5555', N'Administrador', CAST(N'2018-12-04' AS Date))
INSERT [dbo].[logtable] ([id_usuario], [cd_usuario], [nombres], [apellidos], [telefono], [email], [usuario], [contrasena], [estado], [fecha_ingreso]) VALUES (21, N'03822121222', N'Rogelio Alberto', N'Minaya Soto', N'8098565458', N'palmmute13@gmail.com', N'Rogelio Alberto', N'5555', N'Administrador', CAST(N'2018-12-05' AS Date))
INSERT [dbo].[logtable] ([id_usuario], [cd_usuario], [nombres], [apellidos], [telefono], [email], [usuario], [contrasena], [estado], [fecha_ingreso]) VALUES (22, N'45555555555', N'Jonathan', N'Cid', N'5416541364', N'pepito12@queseyo.com', N'Jonathan', N'1212', N'Administrador', CAST(N'2019-01-13' AS Date))
SET IDENTITY_INSERT [dbo].[logtable] OFF
ALTER TABLE [dbo].[logtable] ADD  DEFAULT (NULL) FOR [cd_usuario]
GO
ALTER TABLE [dbo].[logtable] ADD  DEFAULT (NULL) FOR [nombres]
GO
ALTER TABLE [dbo].[logtable] ADD  DEFAULT (NULL) FOR [apellidos]
GO
ALTER TABLE [dbo].[logtable] ADD  DEFAULT (NULL) FOR [telefono]
GO
ALTER TABLE [dbo].[logtable] ADD  DEFAULT (NULL) FOR [usuario]
GO
ALTER TABLE [dbo].[logtable] ADD  DEFAULT (NULL) FOR [contrasena]
GO
ALTER TABLE [dbo].[logtable] ADD  DEFAULT (NULL) FOR [estado]
GO
ALTER TABLE [dbo].[logtable] ADD  DEFAULT (NULL) FOR [fecha_ingreso]
GO
USE [master]
GO
ALTER DATABASE [logdb] SET  READ_WRITE 
GO
