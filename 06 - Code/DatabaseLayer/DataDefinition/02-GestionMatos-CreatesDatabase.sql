USE [master]
GO
/****** Object:  Database [GestionMatos]    Script Date: 05/11/2015 16:04:12 ******/
CREATE DATABASE [GestionMatos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GestionMatos', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\GestionMatos.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'GestionMatos_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\GestionMatos_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [GestionMatos] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GestionMatos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GestionMatos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GestionMatos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GestionMatos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GestionMatos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GestionMatos] SET ARITHABORT OFF 
GO
ALTER DATABASE [GestionMatos] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GestionMatos] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [GestionMatos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GestionMatos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GestionMatos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GestionMatos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GestionMatos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GestionMatos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GestionMatos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GestionMatos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GestionMatos] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GestionMatos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GestionMatos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GestionMatos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GestionMatos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GestionMatos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GestionMatos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GestionMatos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GestionMatos] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GestionMatos] SET  MULTI_USER 
GO
ALTER DATABASE [GestionMatos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GestionMatos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GestionMatos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GestionMatos] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [GestionMatos]
GO

/****** Object:  Table [dbo].[Salle]    Script Date: 05/11/2015 16:04:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salle](
	[id_Salle] [int] IDENTITY(1,1) NOT NULL,
	[nom_Salle] varchar(100) NOT NULL,
	[id_Etage] [int] NOT NULL,
 CONSTRAINT [PK_Salle] PRIMARY KEY CLUSTERED 
(
	[id_Salle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[Batiment]    Script Date: 05/11/2015 16:04:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Batiment](
	[id_Batiment] [int] IDENTITY(1,1) NOT NULL,
	[num_Batiment] [int] NOT NULL,
	[id_Site] [int] NOT NULL,
	[id_Client] [int] NOT NULL,
 CONSTRAINT [PK_Batiment] PRIMARY KEY CLUSTERED 
(
	[id_Batiment] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Client]    Script Date: 05/11/2015 16:04:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[id_Client] [int] IDENTITY(1,1) NOT NULL,
	[nom_Client] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[id_Client] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Etage]    Script Date: 05/11/2015 16:04:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Etage](
	[id_Etage] [int] IDENTITY(1,1) NOT NULL,
	[num_Etage] [int] NOT NULL,
	[id_Batiment] [int] NOT NULL,
 CONSTRAINT [PK_Etage] PRIMARY KEY CLUSTERED 
(
	[id_Etage] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Intervention]    Script Date: 05/11/2015 16:04:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Intervention](
	[id_Intervention] [int] IDENTITY(1,1) NOT NULL,
	[id_Materiel] [int] NOT NULL,
	[date_InterventionPlanifie] [date] NOT NULL,
	[date_InterventionRealisee] [date] NULL,
	[commentaire_Intervention] [text] NULL,
	[status_Intervention] [bit] NOT NULL
 CONSTRAINT [PK_Intervention] PRIMARY KEY CLUSTERED 
(
	[id_Intervention] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Materiel]    Script Date: 05/11/2015 16:04:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materiel](
	[id_Materiel] [int] IDENTITY(1,1) NOT NULL,
	[nom_Materiel] [varchar](100) NOT NULL,
	[guid_Materiel] [nvarchar](36) NOT NULL,
	[id_type_Materiel] [int] NOT NULL,
	[id_Client] [int] NOT NULL,
	[id_Site] [int] NOT NULL,
	[id_Batiment] [int] NOT NULL,
	[id_Etage] [int] NOT NULL,
	[id_Salle] [int] NOT NULL,
	[date_dernier_Intervention] [date] NOT NULL,
	[description] [varchar](100) NOT NULL
 CONSTRAINT [PK_Materiel] PRIMARY KEY CLUSTERED 
(
	[id_Materiel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Site]    Script Date: 05/11/2015 16:04:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Site](
	[id_Site] [int] IDENTITY(1,1) NOT NULL,
	[nom_Site] [nvarchar](50) NOT NULL,
	[Adresse] [text] NOT NULL,
 CONSTRAINT [PK_Site] PRIMARY KEY CLUSTERED 
(
	[id_Site] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Type_Materiel]    Script Date: 05/11/2015 16:04:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type_Materiel](
	[id_Type_Materiel] [int] IDENTITY(1,1) NOT NULL,
	[nom_Type_Materiel] [nvarchar](100) NOT NULL,
	[MTBF] [int] NULL,
 CONSTRAINT [PK_Type_Materiel] PRIMARY KEY CLUSTERED 
(
	[id_Type_Materiel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Batiment]  WITH CHECK ADD  CONSTRAINT [FK_Batiment_Client] FOREIGN KEY([id_Client])
REFERENCES [dbo].[Client] ([id_Client])
GO
ALTER TABLE [dbo].[Batiment] CHECK CONSTRAINT [FK_Batiment_Client]
GO
ALTER TABLE [dbo].[Batiment]  WITH CHECK ADD  CONSTRAINT [FK_Batiment_Site] FOREIGN KEY([id_Site])
REFERENCES [dbo].[Site] ([id_Site])
GO
ALTER TABLE [dbo].[Batiment] CHECK CONSTRAINT [FK_Batiment_Site]
GO
ALTER TABLE [dbo].[Etage]  WITH CHECK ADD  CONSTRAINT [FK_Etage_Batiment] FOREIGN KEY([id_Batiment])
REFERENCES [dbo].[Batiment] ([id_Batiment])
GO
ALTER TABLE [dbo].[Etage] CHECK CONSTRAINT [FK_Etage_Batiment]
GO
ALTER TABLE [dbo].[Intervention]  WITH CHECK ADD  CONSTRAINT [FK_Intervention_Materiel] FOREIGN KEY([id_Materiel])
REFERENCES [dbo].[Materiel] ([id_Materiel])
GO
ALTER TABLE [dbo].[Intervention] CHECK CONSTRAINT [FK_Intervention_Materiel]
GO
ALTER TABLE [dbo].[Materiel]  WITH CHECK ADD  CONSTRAINT [FK_Materiel_Client] FOREIGN KEY([id_Client])
REFERENCES [dbo].[Client] ([id_Client])
GO
ALTER TABLE [dbo].[Materiel] CHECK CONSTRAINT [FK_Materiel_Client]
GO
ALTER TABLE [dbo].[Materiel]  WITH CHECK ADD  CONSTRAINT [FK_Materiel_Etage] FOREIGN KEY([id_Etage])
REFERENCES [dbo].[Etage] ([id_Etage])
GO
ALTER TABLE [dbo].[Materiel] CHECK CONSTRAINT [FK_Materiel_Etage]
GO
ALTER TABLE [dbo].[Materiel]  WITH CHECK ADD  CONSTRAINT [FK_Materiel_Type_Materiel] FOREIGN KEY([id_type_Materiel])
REFERENCES [dbo].[Type_Materiel] ([id_Type_Materiel])
GO
ALTER TABLE [dbo].[Materiel] CHECK CONSTRAINT [FK_Materiel_Type_Materiel]
GO

ALTER TABLE [dbo].[Salle]  WITH CHECK ADD  CONSTRAINT [FK_Salle_Etage_id_Etage] FOREIGN KEY([id_Etage])
REFERENCES [dbo].[Etage] ([id_Etage])
GO
USE [master]
GO
ALTER DATABASE [GestionMatos] SET  READ_WRITE 
GO

