USE [master]
GO
/****** Object:  Database [PC_08]    Script Date: 25/06/2019 11:59:10 ******/
CREATE DATABASE [PC_08]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PC_08', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS01\MSSQL\DATA\PC_08.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PC_08_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS01\MSSQL\DATA\PC_08_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [PC_08] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PC_08].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PC_08] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PC_08] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PC_08] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PC_08] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PC_08] SET ARITHABORT OFF 
GO
ALTER DATABASE [PC_08] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PC_08] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PC_08] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PC_08] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PC_08] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PC_08] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PC_08] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PC_08] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PC_08] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PC_08] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PC_08] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PC_08] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PC_08] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PC_08] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PC_08] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PC_08] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PC_08] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PC_08] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PC_08] SET  MULTI_USER 
GO
ALTER DATABASE [PC_08] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PC_08] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PC_08] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PC_08] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PC_08] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PC_08] SET QUERY_STORE = OFF
GO
USE [PC_08]
GO
/****** Object:  Table [dbo].[cases]    Script Date: 25/06/2019 11:59:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cases](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[creator_id] [int] NOT NULL,
	[code] [varchar](9) NOT NULL,
	[number_of_questions] [int] NOT NULL,
	[created_at] [datetime] NOT NULL,
	[deleted_at] [datetime] NULL,
 CONSTRAINT [PK_cases_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cases_details]    Script Date: 25/06/2019 11:59:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cases_details](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[case_id] [int] NOT NULL,
	[text] [varchar](200) NOT NULL,
	[option_a] [varchar](200) NOT NULL,
	[option_b] [varchar](200) NOT NULL,
	[option_c] [varchar](200) NOT NULL,
	[option_d] [varchar](200) NULL,
	[correct_answer] [varchar](200) NOT NULL,
	[created_at] [datetime] NOT NULL,
	[deleted_at] [datetime] NULL,
 CONSTRAINT [PK_cases_details] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[roles]    Script Date: 25/06/2019 11:59:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roles](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](200) NOT NULL,
	[created_at] [datetime] NOT NULL,
	[deleted_at] [datetime] NULL,
 CONSTRAINT [PK_roles] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rooms]    Script Date: 25/06/2019 11:59:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rooms](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[code] [varchar](4) NOT NULL,
	[capacity] [int] NOT NULL,
	[created_at] [datetime] NOT NULL,
	[deleted_at] [datetime] NULL,
 CONSTRAINT [PK_rooms] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[schedules]    Script Date: 25/06/2019 11:59:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[schedules](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[examiner_id] [int] NOT NULL,
	[type_id] [int] NOT NULL,
	[room_id] [int] NOT NULL,
	[case_id] [int] NOT NULL,
	[time] [datetime] NOT NULL,
	[created_at] [datetime] NOT NULL,
	[deleted_at] [datetime] NULL,
 CONSTRAINT [PK_schedules] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[schedules_participants]    Script Date: 25/06/2019 11:59:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[schedules_participants](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[schedule_id] [int] NOT NULL,
	[participant_id] [int] NOT NULL,
	[created_at] [datetime] NOT NULL,
	[deleted_at] [datetime] NULL,
 CONSTRAINT [PK_schedules_participants] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[test]    Script Date: 25/06/2019 11:59:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[test](
	[test] [varchar](200) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[types]    Script Date: 25/06/2019 11:59:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[types](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[code] [varchar](5) NOT NULL,
	[name] [varchar](200) NOT NULL,
	[created_at] [datetime] NOT NULL,
	[deleted_at] [datetime] NULL,
 CONSTRAINT [PK_types] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 25/06/2019 11:59:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[role_id] [int] NOT NULL,
	[username] [varchar](200) NOT NULL,
	[password] [varchar](200) NOT NULL,
	[name] [varchar](200) NOT NULL,
	[email] [varchar](200) NOT NULL,
	[phone] [varchar](200) NOT NULL,
	[gender] [varchar](6) NOT NULL,
	[address] [varchar](200) NOT NULL,
	[created_at] [datetime] NOT NULL,
	[deleted_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[cases] ADD  CONSTRAINT [DF_cases_created_at_1]  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[cases_details] ADD  CONSTRAINT [DF_cases_details_created_at]  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[roles] ADD  CONSTRAINT [DF_roles_created_at]  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[rooms] ADD  CONSTRAINT [DF_rooms_created_at]  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[schedules] ADD  CONSTRAINT [DF_schedules_created_at]  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[schedules_participants] ADD  CONSTRAINT [DF_schedules_participants_created_at]  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[types] ADD  CONSTRAINT [DF_types_created_at]  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[users] ADD  CONSTRAINT [DF_users_created_at]  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[cases]  WITH CHECK ADD  CONSTRAINT [FK_cases_users1] FOREIGN KEY([creator_id])
REFERENCES [dbo].[users] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[cases] CHECK CONSTRAINT [FK_cases_users1]
GO
ALTER TABLE [dbo].[cases_details]  WITH CHECK ADD  CONSTRAINT [FK_cases_details_cases1] FOREIGN KEY([case_id])
REFERENCES [dbo].[cases] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[cases_details] CHECK CONSTRAINT [FK_cases_details_cases1]
GO
ALTER TABLE [dbo].[schedules]  WITH NOCHECK ADD  CONSTRAINT [FK_schedules_cases1] FOREIGN KEY([case_id])
REFERENCES [dbo].[cases] ([id])
GO
ALTER TABLE [dbo].[schedules] NOCHECK CONSTRAINT [FK_schedules_cases1]
GO
ALTER TABLE [dbo].[schedules]  WITH CHECK ADD  CONSTRAINT [FK_schedules_rooms] FOREIGN KEY([room_id])
REFERENCES [dbo].[rooms] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[schedules] CHECK CONSTRAINT [FK_schedules_rooms]
GO
ALTER TABLE [dbo].[schedules]  WITH CHECK ADD  CONSTRAINT [FK_schedules_types] FOREIGN KEY([type_id])
REFERENCES [dbo].[types] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[schedules] CHECK CONSTRAINT [FK_schedules_types]
GO
ALTER TABLE [dbo].[schedules]  WITH CHECK ADD  CONSTRAINT [FK_schedules_users_123] FOREIGN KEY([examiner_id])
REFERENCES [dbo].[users] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[schedules] CHECK CONSTRAINT [FK_schedules_users_123]
GO
ALTER TABLE [dbo].[schedules_participants]  WITH CHECK ADD  CONSTRAINT [FK_schedules_participants_schedules] FOREIGN KEY([schedule_id])
REFERENCES [dbo].[schedules] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[schedules_participants] CHECK CONSTRAINT [FK_schedules_participants_schedules]
GO
ALTER TABLE [dbo].[schedules_participants]  WITH CHECK ADD  CONSTRAINT [FK_schedules_participants_users] FOREIGN KEY([participant_id])
REFERENCES [dbo].[users] ([id])
GO
ALTER TABLE [dbo].[schedules_participants] CHECK CONSTRAINT [FK_schedules_participants_users]
GO
ALTER TABLE [dbo].[users]  WITH NOCHECK ADD  CONSTRAINT [FK_users_roles] FOREIGN KEY([role_id])
REFERENCES [dbo].[roles] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[users] CHECK CONSTRAINT [FK_users_roles]
GO
USE [master]
GO
ALTER DATABASE [PC_08] SET  READ_WRITE 
GO
