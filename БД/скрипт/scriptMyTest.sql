USE [master]
GO
/****** Object:  Database [MyTest]    Script Date: 30.05.2020 1:04:45 ******/
CREATE DATABASE [MyTest]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MyTest', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\MyTest.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MyTest_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\MyTest_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [MyTest] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MyTest].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MyTest] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MyTest] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MyTest] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MyTest] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MyTest] SET ARITHABORT OFF 
GO
ALTER DATABASE [MyTest] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MyTest] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MyTest] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MyTest] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MyTest] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MyTest] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MyTest] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MyTest] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MyTest] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MyTest] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MyTest] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MyTest] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MyTest] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MyTest] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MyTest] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MyTest] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MyTest] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MyTest] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MyTest] SET  MULTI_USER 
GO
ALTER DATABASE [MyTest] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MyTest] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MyTest] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MyTest] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MyTest] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MyTest] SET QUERY_STORE = OFF
GO
USE [MyTest]
GO
/****** Object:  Table [dbo].[Results]    Script Date: 30.05.2020 1:04:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Results](
	[ID_result] [int] IDENTITY(1,1) NOT NULL,
	[ID_student] [int] NOT NULL,
	[ID_test] [int] NOT NULL,
	[Date_testing] [date] NOT NULL,
	[Mark] [int] NOT NULL,
 CONSTRAINT [PK_Results] PRIMARY KEY CLUSTERED 
(
	[ID_result] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 30.05.2020 1:04:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[ID_student] [int] IDENTITY(1,1) NOT NULL,
	[Nmae_student] [nvarchar](50) NOT NULL,
	[ID_team] [int] NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[ID_student] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 30.05.2020 1:04:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teachers](
	[ID_teacher] [int] IDENTITY(1,1) NOT NULL,
	[Login] [varchar](50) NOT NULL,
	[Password] [varchar](20) NOT NULL,
	[Name_teacher] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Teachers] PRIMARY KEY CLUSTERED 
(
	[ID_teacher] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teams]    Script Date: 30.05.2020 1:04:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teams](
	[ID_team] [int] IDENTITY(1,1) NOT NULL,
	[Team] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Teams] PRIMARY KEY CLUSTERED 
(
	[ID_team] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tests]    Script Date: 30.05.2020 1:04:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tests](
	[ID_test] [int] IDENTITY(1,1) NOT NULL,
	[ID_teacher] [int] NOT NULL,
	[Name_test] [nvarchar](50) NOT NULL,
	[Date_create] [date] NOT NULL,
	[Comment] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tests] PRIMARY KEY CLUSTERED 
(
	[ID_test] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Teachers] ON 

INSERT [dbo].[Teachers] ([ID_teacher], [Login], [Password], [Name_teacher]) VALUES (1, N'LogTeachers1', N'123', N'Пономарёв Иван Борисович')
INSERT [dbo].[Teachers] ([ID_teacher], [Login], [Password], [Name_teacher]) VALUES (2, N'LogTeachers2', N'123', N'Щербакова Альбина Евгеньевна')
INSERT [dbo].[Teachers] ([ID_teacher], [Login], [Password], [Name_teacher]) VALUES (5, N'LogTeachers3', N'123', N'Князева Йоони Виталиевна')
INSERT [dbo].[Teachers] ([ID_teacher], [Login], [Password], [Name_teacher]) VALUES (6, N'LogTeachers4', N'123', N'Матвеев Ярослав Андреевич')
SET IDENTITY_INSERT [dbo].[Teachers] OFF
SET IDENTITY_INSERT [dbo].[Teams] ON 

INSERT [dbo].[Teams] ([ID_team], [Team]) VALUES (1, N'группа 374')
INSERT [dbo].[Teams] ([ID_team], [Team]) VALUES (2, N'группа 373')
INSERT [dbo].[Teams] ([ID_team], [Team]) VALUES (3, N'группа 666')
INSERT [dbo].[Teams] ([ID_team], [Team]) VALUES (4, N'группа 999')
SET IDENTITY_INSERT [dbo].[Teams] OFF
ALTER TABLE [dbo].[Results]  WITH CHECK ADD  CONSTRAINT [FK_Results_Students] FOREIGN KEY([ID_student])
REFERENCES [dbo].[Students] ([ID_student])
GO
ALTER TABLE [dbo].[Results] CHECK CONSTRAINT [FK_Results_Students]
GO
ALTER TABLE [dbo].[Results]  WITH CHECK ADD  CONSTRAINT [FK_Results_Tests] FOREIGN KEY([ID_test])
REFERENCES [dbo].[Tests] ([ID_test])
GO
ALTER TABLE [dbo].[Results] CHECK CONSTRAINT [FK_Results_Tests]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Teams1] FOREIGN KEY([ID_team])
REFERENCES [dbo].[Teams] ([ID_team])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Teams1]
GO
ALTER TABLE [dbo].[Tests]  WITH CHECK ADD  CONSTRAINT [FK_Tests_Teachers] FOREIGN KEY([ID_teacher])
REFERENCES [dbo].[Teachers] ([ID_teacher])
GO
ALTER TABLE [dbo].[Tests] CHECK CONSTRAINT [FK_Tests_Teachers]
GO
USE [master]
GO
ALTER DATABASE [MyTest] SET  READ_WRITE 
GO
