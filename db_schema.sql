USE [master]
GO
/****** Object:  Database [ebook]    Script Date: 6/2/2018 8:55:08 PM ******/
CREATE DATABASE [ebook]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ebook', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\ebook.mdf' , SIZE = 75776KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ebook_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\ebook_log.ldf' , SIZE = 12352KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ebook] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ebook].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ebook] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ebook] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ebook] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ebook] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ebook] SET ARITHABORT OFF 
GO
ALTER DATABASE [ebook] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ebook] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [ebook] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ebook] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ebook] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ebook] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ebook] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ebook] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ebook] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ebook] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ebook] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ebook] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ebook] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ebook] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ebook] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ebook] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ebook] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ebook] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ebook] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ebook] SET  MULTI_USER 
GO
ALTER DATABASE [ebook] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ebook] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ebook] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ebook] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [ebook]
GO
/****** Object:  StoredProcedure [dbo].[GetBookInfo]    Script Date: 6/2/2018 8:55:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetBookInfo]
@bookid int
as
begin
select * from book where id = @bookid
end
GO
/****** Object:  StoredProcedure [dbo].[GetBookList]    Script Date: 6/2/2018 8:55:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetBookList]
AS SELECT * FROM book

GO
/****** Object:  StoredProcedure [dbo].[GetBookStatus]    Script Date: 6/2/2018 8:55:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetBookStatus]
	@bookid int = 1
AS
begin
	SELECT * from book where id = @bookid
end
GO
/****** Object:  StoredProcedure [dbo].[GetChapterInfo]    Script Date: 6/2/2018 8:55:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetChapterInfo]
@chapid int, @bookid int
as
begin
select * from chapter where id = @chapid and bookid = @bookid
end
GO
/****** Object:  StoredProcedure [dbo].[GetChapterList]    Script Date: 6/2/2018 8:55:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetChapterList]
@bookid int
as
begin
select * from chapter where bookid = @bookid
end
GO
/****** Object:  StoredProcedure [dbo].[GetLastBook]    Script Date: 6/2/2018 8:55:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetLastBook]
as
begin
select * from book where is_last = 1
end
GO
/****** Object:  StoredProcedure [dbo].[SetLastBook]    Script Date: 6/2/2018 8:55:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SetLastBook]
@bookid int
as
begin
update book set is_last = 0 where is_last = 1;
update book set is_last = 1 where id = @bookid;
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateBookStatus]    Script Date: 6/2/2018 8:55:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UpdateBookStatus]
@bookid int, @status int
as
begin
update book
set status = @status
where id = @bookid
end
GO
/****** Object:  Table [dbo].[book]    Script Date: 6/2/2018 8:55:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[book](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[status] [int] NOT NULL,
	[is_last] [bit] NULL,
 CONSTRAINT [PK_book] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[chapter]    Script Date: 6/2/2018 8:55:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chapter](
	[id] [int] NOT NULL,
	[name] [nvarchar](100) NULL,
	[chapcontent] [ntext] NULL,
	[bookid] [int] NOT NULL,
 CONSTRAINT [PK_chapter] PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[bookid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[book] ADD  CONSTRAINT [DF_book_status]  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[book] ADD  CONSTRAINT [DF_book_is_last]  DEFAULT ((0)) FOR [is_last]
GO
ALTER TABLE [dbo].[chapter] ADD  CONSTRAINT [DF_chapter_bookid]  DEFAULT ((1)) FOR [bookid]
GO
ALTER TABLE [dbo].[chapter]  WITH CHECK ADD  CONSTRAINT [FK_chapter_book] FOREIGN KEY([bookid])
REFERENCES [dbo].[book] ([id])
GO
ALTER TABLE [dbo].[chapter] CHECK CONSTRAINT [FK_chapter_book]
GO
USE [master]
GO
ALTER DATABASE [ebook] SET  READ_WRITE 
GO
