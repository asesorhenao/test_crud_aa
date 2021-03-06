USE [master]
GO
/****** Object:  Database [inscriptionsCrud]    Script Date: 05/08/2020 17:26:48 ******/
CREATE DATABASE [inscriptionsCrud]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'inscriptionsCrud', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\inscriptionsCrud.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'inscriptionsCrud_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\inscriptionsCrud_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [inscriptionsCrud] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [inscriptionsCrud].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [inscriptionsCrud] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [inscriptionsCrud] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [inscriptionsCrud] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [inscriptionsCrud] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [inscriptionsCrud] SET ARITHABORT OFF 
GO
ALTER DATABASE [inscriptionsCrud] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [inscriptionsCrud] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [inscriptionsCrud] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [inscriptionsCrud] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [inscriptionsCrud] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [inscriptionsCrud] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [inscriptionsCrud] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [inscriptionsCrud] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [inscriptionsCrud] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [inscriptionsCrud] SET  DISABLE_BROKER 
GO
ALTER DATABASE [inscriptionsCrud] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [inscriptionsCrud] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [inscriptionsCrud] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [inscriptionsCrud] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [inscriptionsCrud] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [inscriptionsCrud] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [inscriptionsCrud] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [inscriptionsCrud] SET RECOVERY FULL 
GO
ALTER DATABASE [inscriptionsCrud] SET  MULTI_USER 
GO
ALTER DATABASE [inscriptionsCrud] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [inscriptionsCrud] SET DB_CHAINING OFF 
GO
ALTER DATABASE [inscriptionsCrud] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [inscriptionsCrud] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [inscriptionsCrud] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'inscriptionsCrud', N'ON'
GO
ALTER DATABASE [inscriptionsCrud] SET QUERY_STORE = OFF
GO
USE [inscriptionsCrud]
GO
/****** Object:  Table [dbo].[tbl_Inscriptions]    Script Date: 05/08/2020 17:26:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Inscriptions](
	[IdInscripcion] [bigint] IDENTITY(1,1) NOT NULL,
	[TipoAspirante] [varchar](50) NULL,
	[Modalidad] [varchar](50) NULL,
	[Sede] [varchar](50) NULL,
	[Programa] [varchar](50) NULL,
	[PeriodoAcademico] [varchar](50) NULL,
	[Nombres] [varchar](50) NULL,
	[Apellidos] [varchar](50) NULL,
	[FechaNacimiento] [varchar](50) NULL,
	[PaisNacimiento] [varchar](50) NULL,
	[DepartamentoNacimiento] [varchar](50) NULL,
	[CiudadNacimiento] [varchar](50) NULL,
	[GrupoSanguineo] [varchar](50) NULL,
	[TipoDocumento] [varchar](50) NULL,
	[NumeroDocumento] [varchar](50) NULL,
	[FechaExpedicion] [varchar](50) NULL,
	[PaisExpedicion] [varchar](50) NULL,
	[DepartamentoExpedicion] [varchar](50) NULL,
	[CiudadExpedicion] [varchar](50) NULL,
	[Sexo] [varchar](50) NULL,
	[EstadoCivil] [varchar](50) NULL,
	[NumeroTelefono] [varchar](50) NULL,
	[NumeroCelular] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Direccion] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_Inscriptions] PRIMARY KEY CLUSTERED 
(
	[IdInscripcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_Inscriptions] ON 

INSERT [dbo].[tbl_Inscriptions] ([IdInscripcion], [TipoAspirante], [Modalidad], [Sede], [Programa], [PeriodoAcademico], [Nombres], [Apellidos], [FechaNacimiento], [PaisNacimiento], [DepartamentoNacimiento], [CiudadNacimiento], [GrupoSanguineo], [TipoDocumento], [NumeroDocumento], [FechaExpedicion], [PaisExpedicion], [DepartamentoExpedicion], [CiudadExpedicion], [Sexo], [EstadoCivil], [NumeroTelefono], [NumeroCelular], [Email], [Direccion]) VALUES (1, N'Nuevo', N'Presencial', N'Medellìn', N'Programa 1', N'20202', N'Carlos Arturo', N'Correa Correa', N'23/01/1989', N'Colombia', N'Antioquia', N'Medellìn', N'O+', N'Cédula de Ciudadanía', N'1234567890', N'20/01/1998', N'Colombia', N'Antioquia', N'Medellín', N'Masculino', N'Soltero (a)', N'5791127', N'30098973423', N'email@email.com', N'Kra 80 # 90 - 80')
INSERT [dbo].[tbl_Inscriptions] ([IdInscripcion], [TipoAspirante], [Modalidad], [Sede], [Programa], [PeriodoAcademico], [Nombres], [Apellidos], [FechaNacimiento], [PaisNacimiento], [DepartamentoNacimiento], [CiudadNacimiento], [GrupoSanguineo], [TipoDocumento], [NumeroDocumento], [FechaExpedicion], [PaisExpedicion], [DepartamentoExpedicion], [CiudadExpedicion], [Sexo], [EstadoCivil], [NumeroTelefono], [NumeroCelular], [Email], [Direccion]) VALUES (2, N'Nuevo', N'Virtual', N'Medellìn', N'Programa 2', N'20202', N'Ana Maria', N'Restrepo Restrepo', N'23/01/1989', N'Colombia', N'Antioquia', N'Medellìn', N'O+', N'Cédula de Ciudadanía', N'1234567890', N'20/01/1998', N'Colombia', N'Antioquia', N'Medellín', N'Femenino', N'Soltero (a)', N'5791127', N'30098973423', N'email@email.com', N'Kra 80 # 90 - 80')
SET IDENTITY_INSERT [dbo].[tbl_Inscriptions] OFF
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Inscriptions'
GO
USE [master]
GO
ALTER DATABASE [inscriptionsCrud] SET  READ_WRITE 
GO
