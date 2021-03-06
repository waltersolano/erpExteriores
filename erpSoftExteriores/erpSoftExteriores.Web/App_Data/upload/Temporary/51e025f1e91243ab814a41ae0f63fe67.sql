USE [master]
GO
/****** Object:  Database [ErpSoftExteriores]    Script Date: 10/1/2016 5:14:11 PM ******/
CREATE DATABASE [ErpSoftExteriores]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ErpSoftExteriores', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\ErpSoftExteriores.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ErpSoftExteriores_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\ErpSoftExteriores_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ErpSoftExteriores] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ErpSoftExteriores].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ErpSoftExteriores] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ErpSoftExteriores] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ErpSoftExteriores] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ErpSoftExteriores] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ErpSoftExteriores] SET ARITHABORT OFF 
GO
ALTER DATABASE [ErpSoftExteriores] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ErpSoftExteriores] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ErpSoftExteriores] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ErpSoftExteriores] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ErpSoftExteriores] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ErpSoftExteriores] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ErpSoftExteriores] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ErpSoftExteriores] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ErpSoftExteriores] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ErpSoftExteriores] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ErpSoftExteriores] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ErpSoftExteriores] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ErpSoftExteriores] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ErpSoftExteriores] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ErpSoftExteriores] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ErpSoftExteriores] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ErpSoftExteriores] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ErpSoftExteriores] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ErpSoftExteriores] SET  MULTI_USER 
GO
ALTER DATABASE [ErpSoftExteriores] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ErpSoftExteriores] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ErpSoftExteriores] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ErpSoftExteriores] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ErpSoftExteriores] SET DELAYED_DURABILITY = DISABLED 
GO
USE [ErpSoftExteriores]
GO
/****** Object:  Table [dbo].[Gen_DivisionesAdministrativas]    Script Date: 10/1/2016 5:14:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Gen_DivisionesAdministrativas](
	[primerNivel] [varchar](50) NOT NULL,
	[segundoNivel] [varchar](50) NULL,
	[tercerNivel] [varchar](50) NULL,
	[cuartoNivel] [varchar](50) NULL,
	[quintoNivel] [varchar](50) NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Gen_DivisionesAdministrativas] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Gen_DivisionesAdministrativasN1]    Script Date: 10/1/2016 5:14:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Gen_DivisionesAdministrativasN1](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [varchar](25) NULL,
	[nombre] [varchar](25) NOT NULL,
	[divisionSuperior] [int] NULL,
 CONSTRAINT [PK_Gen_DivisionesAdministrativasN1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Gen_DivisionesAdministrativasN2]    Script Date: 10/1/2016 5:14:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Gen_DivisionesAdministrativasN2](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [varchar](25) NULL,
	[nombre] [varchar](25) NOT NULL,
	[divisionSuperiorN1] [int] NOT NULL,
 CONSTRAINT [PK_Gen_DivisionesAdministrativasN2] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Gen_DivisionesAdministrativasN3]    Script Date: 10/1/2016 5:14:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Gen_DivisionesAdministrativasN3](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [varchar](25) NULL,
	[nombre] [varchar](25) NOT NULL,
	[divisionSuperiorN2] [int] NOT NULL,
 CONSTRAINT [PK_Gen_DivisionesAdministrativasN3] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Gen_DivisionesAdministrativasN4]    Script Date: 10/1/2016 5:14:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Gen_DivisionesAdministrativasN4](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [varchar](25) NULL,
	[nombre] [varchar](25) NOT NULL,
	[divisionSuperiorN3] [int] NOT NULL,
 CONSTRAINT [PK_Gen_DivisionesAdministrativasN4] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Gen_DivisionesAdministrativasN5]    Script Date: 10/1/2016 5:14:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Gen_DivisionesAdministrativasN5](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [varchar](25) NULL,
	[nombre] [varchar](25) NOT NULL,
	[divisionSuperiorN4] [int] NOT NULL,
 CONSTRAINT [PK_Gen_DivisionesAdministrativasN5] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Gen_Monedas]    Script Date: 10/1/2016 5:14:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gen_Monedas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nchar](30) NOT NULL,
	[simbolo] [nchar](10) NOT NULL,
	[codigo] [nchar](10) NOT NULL,
	[pais] [nchar](30) NOT NULL,
	[codigoPais] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Gen_Monedas] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Gen_Notas]    Script Date: 10/1/2016 5:14:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gen_Notas](
	[notaID] [int] NULL,
	[EntityType] [nvarchar](100) NOT NULL,
	[EntityID] [bigint] NOT NULL,
	[Text] [nvarchar](max) NOT NULL,
	[tenantID] [int] NULL,
	[insertUserId] [int] NOT NULL,
	[insertDate] [datetime] NOT NULL,
	[active] [bit] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Gen_Rutas]    Script Date: 10/1/2016 5:14:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Gen_Rutas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NULL,
	[descripcion] [varchar](500) NULL,
	[carreteras] [varchar](500) NULL,
 CONSTRAINT [PK_Rutas] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Gen_TipoIdentificacion]    Script Date: 10/1/2016 5:14:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gen_TipoIdentificacion](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nchar](100) NOT NULL,
 CONSTRAINT [PK_Gen_TipoIdentificacion] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Inv_Arrendadores]    Script Date: 10/1/2016 5:14:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inv_Arrendadores](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[identificacion] [nvarchar](100) NOT NULL,
	[nombre] [nvarchar](100) NOT NULL,
	[tipoID] [int] NOT NULL,
	[notas] [nvarchar](200) NULL,
	[direccion] [nvarchar](200) NOT NULL,
	[emails] [nvarchar](200) NULL,
	[codigoPostal] [nvarchar](50) NULL,
	[tenantID] [int] NULL,
	[nombreRepresentante] [nvarchar](100) NULL,
	[identificacionRepresentante] [nvarchar](100) NULL,
	[tipoIDRepresentante] [int] NULL,
	[website] [nvarchar](50) NULL,
 CONSTRAINT [PK_Inv_Arrendadores] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Inv_ArrendadoresContactos]    Script Date: 10/1/2016 5:14:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inv_ArrendadoresContactos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](60) NOT NULL,
	[telefono1] [nvarchar](20) NOT NULL,
	[email] [nvarchar](100) NULL,
	[cargo] [nvarchar](100) NULL,
	[arrendadorID] [int] NOT NULL,
	[tenantID] [int] NULL,
	[telefono2] [nvarchar](20) NULL,
	[telefono3] [nvarchar](20) NULL,
 CONSTRAINT [PK_Inv_ArrendadoresContactos] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Inv_CategoriasSoporteEstructura]    Script Date: 10/1/2016 5:14:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Inv_CategoriasSoporteEstructura](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[tenantID] [int] NULL,
 CONSTRAINT [PK_Inv_CategoriasSoporteEstructura] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Inv_Productos]    Script Date: 10/1/2016 5:14:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Inv_Productos](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[sitioID] [int] NOT NULL,
	[nombre] [nvarchar](40) NULL,
	[categoriasSoporteEstructuraID] [int] NOT NULL,
	[tiposEstructuraID] [int] NOT NULL,
	[circuitoID] [int] NULL,
	[estatusID] [int] NOT NULL CONSTRAINT [DF__Inv_Produ__estat__6C190EBB]  DEFAULT ((1)),
	[monedaID] [int] NOT NULL,
	[precioVenta] [money] NOT NULL CONSTRAINT [DF__Inv_Produ__preci__6D0D32F4]  DEFAULT ((0)),
	[precioVentaMinimo] [money] NOT NULL CONSTRAINT [DF__Inv_Produ__preci__6E01572D]  DEFAULT ((0)),
	[precioVentaCircuito] [money] NULL CONSTRAINT [DF__Inv_Produ__preci__6EF57B66]  DEFAULT ((0)),
	[cantidadPorUnidad] [nvarchar](20) NULL,
	[unidadesEnStock] [smallint] NULL CONSTRAINT [DF__Inv_Produ__unida__6FE99F9F]  DEFAULT ((0)),
	[codigoProducto] [varchar](50) NULL,
	[notas] [varchar](200) NULL,
	[descriptionVista] [varchar](200) NULL,
	[base] [decimal](10, 2) NULL,
	[altura] [decimal](10, 2) NULL,
	[imagenes] [varchar](max) NULL,
	[GPSLatitud] [varchar](100) NULL,
	[GPSLongitud] [varchar](100) NULL,
	[ubicacion] [varchar](200) NULL,
	[GPSRutaID] [int] NULL,
	[tenantID] [int] NULL,
	[userID] [int] NULL,
	[ultimaModificacion] [datetime] NULL,
	[userIDModifica] [int] NULL,
	[fechaCreacion] [datetime] NULL,
	[legalInfoID] [int] NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Inv_Sitios]    Script Date: 10/1/2016 5:14:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Inv_Sitios](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[arrendadorID] [int] NOT NULL,
	[direccion] [varchar](200) NOT NULL,
	[notas] [varchar](200) NULL,
	[tenantID] [int] NULL,
	[divisionAdministrativaN1] [int] NULL,
	[divisionAdministrativaN2] [int] NULL,
	[divisionAdministrativaN3] [int] NULL,
	[divisionAdministrativaN4] [int] NULL,
	[divisionAdministrativaN5] [int] NULL,
	[rutaID] [int] NULL,
	[codigoSitio] [varchar](50) NULL,
 CONSTRAINT [PK_Inv_Sitios] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Inv_SitiosContratosArrendamiento]    Script Date: 10/1/2016 5:14:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Inv_SitiosContratosArrendamiento](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SitioID] [int] NOT NULL,
	[ArrendadorID] [int] NOT NULL,
	[numeroContrato] [nchar](100) NOT NULL,
	[tipoContratoID] [int] NULL,
	[tipoFechaDePagoContratoID] [int] NOT NULL,
	[monedaID] [int] NOT NULL,
	[monto] [money] NOT NULL,
	[archivos] [varchar](max) NULL,
	[fechaInicial] [date] NOT NULL,
	[fechaFinal] [date] NOT NULL,
	[porcentajeIncrementoRenovacion] [decimal](5, 2) NOT NULL,
	[userID] [int] NOT NULL,
	[tenantID] [int] NULL,
	[fechaModificacion] [datetime] NULL,
	[fechaCreacion] [datetime] NULL,
	[userIDModifica] [int] NULL,
 CONSTRAINT [PK_Inv_SitiosContratosArrendamiento] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Inv_Status]    Script Date: 10/1/2016 5:14:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inv_Status](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[tenantID] [int] NULL,
	[criterios] [nvarchar](200) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Inv_TiposEstructura]    Script Date: 10/1/2016 5:14:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Inv_TiposEstructura](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[categoriasSoporteEstructuraID] [int] NOT NULL,
	[tenantID] [int] NULL,
	[nombre] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Inv_TiposEstructura] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Languages]    Script Date: 10/1/2016 5:14:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Languages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LanguageId] [nvarchar](10) NOT NULL,
	[LanguageName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Languages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Log_RegistroSimple]    Script Date: 10/1/2016 5:14:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Log_RegistroSimple](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[EntityType] [varchar](70) NOT NULL,
	[EntityID] [bigint] NOT NULL,
	[UsuarioRegistraID] [int] NULL,
	[FechaRegistro] [datetime] NULL,
	[UsuarioModifica] [int] NULL,
	[FechaModifica] [datetime] NULL,
	[Texto1] [varchar](1000) NULL,
	[Texto2] [varchar](300) NULL,
	[Ip1] [varchar](100) NULL,
	[Ip2] [varchar](50) NULL,
	[tenantID] [int] NULL,
 CONSTRAINT [PK_RegistroShortLog] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Notes]    Script Date: 10/1/2016 5:14:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Notes](
	[NoteID] [bigint] IDENTITY(1,1) NOT NULL,
	[EntityType] [nvarchar](100) NOT NULL,
	[EntityID] [bigint] NOT NULL,
	[Text] [nvarchar](max) NOT NULL,
	[InsertUserId] [int] NOT NULL,
	[InsertDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Notes] PRIMARY KEY CLUSTERED 
(
	[NoteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ordenes]    Script Date: 10/1/2016 5:14:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ordenes](
	[ID_Orden] [int] IDENTITY(1,1) NOT NULL,
	[ID_Cliente] [nvarchar](5) NOT NULL,
	[ID_Empleado] [int] NOT NULL,
	[FechaOrden] [datetime] NOT NULL,
	[FechaInicial] [datetime] NOT NULL,
	[FechaFinal] [datetime] NOT NULL,
 CONSTRAINT [PK_Ordenes] PRIMARY KEY CLUSTERED 
(
	[ID_Orden] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Productos]    Script Date: 10/1/2016 5:14:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Productos](
	[ID_Producto] [int] IDENTITY(1,1) NOT NULL,
	[ID_Sitio] [int] NULL,
	[Nombre] [nvarchar](40) NOT NULL,
	[ID_Categoria] [int] NULL,
	[CantidadPorUnidad] [nvarchar](20) NULL,
	[Precio] [money] NOT NULL CONSTRAINT [DF_Products_UnitPrice]  DEFAULT ((0)),
	[UnidadesEnStock] [smallint] NULL CONSTRAINT [DF_Products_UnitsInStock]  DEFAULT ((0)),
	[UnidadesEnOrden] [smallint] NULL CONSTRAINT [DF_Products_UnitsOnOrder]  DEFAULT ((0)),
	[Deshabilitado] [bit] NULL CONSTRAINT [DF_Products_Discontinued]  DEFAULT ((0)),
	[ID_Moneda] [int] NOT NULL,
	[PrecioMinimo] [money] NOT NULL,
	[CodigoInterno] [varchar](50) NULL,
	[ID_TipoProducto] [int] NULL,
	[Descripcion] [varchar](200) NULL,
	[DescriptionVista] [varchar](200) NULL,
	[Base] [decimal](10, 2) NULL,
	[Altura] [decimal](10, 2) NULL,
	[PrecioElectricidad] [money] NULL,
	[Images] [varchar](max) NULL,
	[NumPlanoCas] [varchar](100) NULL,
	[NumOficina] [varchar](100) NULL,
	[NumPermiso] [varchar](100) NULL,
	[PermisionDueDate] [datetime] NULL,
	[GPSLatitud] [varchar](100) NULL,
	[GPSLongitud] [varchar](100) NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ID_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RolePermissions]    Script Date: 10/1/2016 5:14:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RolePermissions](
	[RolePermissionId] [bigint] IDENTITY(1,1) NOT NULL,
	[RoleId] [int] NOT NULL,
	[PermissionKey] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_RolePermissions] PRIMARY KEY CLUSTERED 
(
	[RolePermissionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Roles]    Script Date: 10/1/2016 5:14:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserPermissions]    Script Date: 10/1/2016 5:14:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserPermissions](
	[UserPermissionId] [bigint] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[PermissionKey] [nvarchar](100) NOT NULL,
	[Granted] [bit] NOT NULL CONSTRAINT [DF_UserPermissions_Grant]  DEFAULT ((1)),
 CONSTRAINT [PK_UserPermissions] PRIMARY KEY CLUSTERED 
(
	[UserPermissionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserPreferences]    Script Date: 10/1/2016 5:14:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserPreferences](
	[UserPreferenceId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[PreferenceType] [nvarchar](100) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_UserPreferences] PRIMARY KEY CLUSTERED 
(
	[UserPreferenceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserRoles]    Script Date: 10/1/2016 5:14:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRoles](
	[UserRoleId] [bigint] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[RoleId] [int] NOT NULL,
 CONSTRAINT [PK_UserRoles] PRIMARY KEY CLUSTERED 
(
	[UserRoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 10/1/2016 5:14:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](100) NOT NULL,
	[DisplayName] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](100) NULL,
	[Source] [nvarchar](4) NOT NULL,
	[PasswordHash] [nvarchar](86) NOT NULL,
	[PasswordSalt] [nvarchar](10) NOT NULL,
	[InsertDate] [datetime] NOT NULL,
	[InsertUserId] [int] NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateUserId] [int] NULL,
	[IsActive] [smallint] NOT NULL CONSTRAINT [DF_Users_IsActive]  DEFAULT ((1)),
	[LastDirectoryUpdate] [datetime] NULL,
	[tenantID] [int] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UsuariosRegistrosShortLog]    Script Date: 10/1/2016 5:14:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuariosRegistrosShortLog](
	[ID] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VersionInfo]    Script Date: 10/1/2016 5:14:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VersionInfo](
	[Version] [bigint] NOT NULL,
	[AppliedOn] [datetime] NULL,
	[Description] [nvarchar](1024) NULL
) ON [PRIMARY]

GO
/****** Object:  Index [UC_Version]    Script Date: 10/1/2016 5:14:11 PM ******/
CREATE UNIQUE CLUSTERED INDEX [UC_Version] ON [dbo].[VersionInfo]
(
	[Version] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Gen_DivisionesAdministrativas] ON 

INSERT [dbo].[Gen_DivisionesAdministrativas] ([primerNivel], [segundoNivel], [tercerNivel], [cuartoNivel], [quintoNivel], [ID]) VALUES (N'Provincia', N'Cantón', N'Distrito', NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[Gen_DivisionesAdministrativas] OFF
SET IDENTITY_INSERT [dbo].[Gen_DivisionesAdministrativasN1] ON 

INSERT [dbo].[Gen_DivisionesAdministrativasN1] ([ID], [codigo], [nombre], [divisionSuperior]) VALUES (1, NULL, N'San José', NULL)
INSERT [dbo].[Gen_DivisionesAdministrativasN1] ([ID], [codigo], [nombre], [divisionSuperior]) VALUES (2, NULL, N'Heredia', NULL)
INSERT [dbo].[Gen_DivisionesAdministrativasN1] ([ID], [codigo], [nombre], [divisionSuperior]) VALUES (3, NULL, N'Cartago', NULL)
INSERT [dbo].[Gen_DivisionesAdministrativasN1] ([ID], [codigo], [nombre], [divisionSuperior]) VALUES (4, NULL, N'Alajuela', NULL)
INSERT [dbo].[Gen_DivisionesAdministrativasN1] ([ID], [codigo], [nombre], [divisionSuperior]) VALUES (5, NULL, N'Guanacaste', NULL)
INSERT [dbo].[Gen_DivisionesAdministrativasN1] ([ID], [codigo], [nombre], [divisionSuperior]) VALUES (6, NULL, N'Puntarenas', NULL)
INSERT [dbo].[Gen_DivisionesAdministrativasN1] ([ID], [codigo], [nombre], [divisionSuperior]) VALUES (7, NULL, N'Limon', NULL)
SET IDENTITY_INSERT [dbo].[Gen_DivisionesAdministrativasN1] OFF
SET IDENTITY_INSERT [dbo].[Gen_DivisionesAdministrativasN2] ON 

INSERT [dbo].[Gen_DivisionesAdministrativasN2] ([ID], [codigo], [nombre], [divisionSuperiorN1]) VALUES (1, NULL, N'San José Central', 1)
INSERT [dbo].[Gen_DivisionesAdministrativasN2] ([ID], [codigo], [nombre], [divisionSuperiorN1]) VALUES (2, NULL, N'Acosta', 1)
INSERT [dbo].[Gen_DivisionesAdministrativasN2] ([ID], [codigo], [nombre], [divisionSuperiorN1]) VALUES (3, NULL, N'Alajuelita', 1)
INSERT [dbo].[Gen_DivisionesAdministrativasN2] ([ID], [codigo], [nombre], [divisionSuperiorN1]) VALUES (4, NULL, N'Goicoechea', 1)
INSERT [dbo].[Gen_DivisionesAdministrativasN2] ([ID], [codigo], [nombre], [divisionSuperiorN1]) VALUES (5, NULL, N'Montes de Oca', 1)
INSERT [dbo].[Gen_DivisionesAdministrativasN2] ([ID], [codigo], [nombre], [divisionSuperiorN1]) VALUES (7, NULL, N'Paraíso', 3)
INSERT [dbo].[Gen_DivisionesAdministrativasN2] ([ID], [codigo], [nombre], [divisionSuperiorN1]) VALUES (8, NULL, N'Heredia Central', 2)
INSERT [dbo].[Gen_DivisionesAdministrativasN2] ([ID], [codigo], [nombre], [divisionSuperiorN1]) VALUES (9, NULL, N'Alvarado', 3)
SET IDENTITY_INSERT [dbo].[Gen_DivisionesAdministrativasN2] OFF
SET IDENTITY_INSERT [dbo].[Gen_DivisionesAdministrativasN3] ON 

INSERT [dbo].[Gen_DivisionesAdministrativasN3] ([ID], [codigo], [nombre], [divisionSuperiorN2]) VALUES (1, NULL, N'Carmen', 1)
INSERT [dbo].[Gen_DivisionesAdministrativasN3] ([ID], [codigo], [nombre], [divisionSuperiorN2]) VALUES (2, NULL, N'Merced', 1)
INSERT [dbo].[Gen_DivisionesAdministrativasN3] ([ID], [codigo], [nombre], [divisionSuperiorN2]) VALUES (3, NULL, N'Zapote', 1)
INSERT [dbo].[Gen_DivisionesAdministrativasN3] ([ID], [codigo], [nombre], [divisionSuperiorN2]) VALUES (4, NULL, N'Uruca', 1)
INSERT [dbo].[Gen_DivisionesAdministrativasN3] ([ID], [codigo], [nombre], [divisionSuperiorN2]) VALUES (5, NULL, N'Guadalupe', 4)
INSERT [dbo].[Gen_DivisionesAdministrativasN3] ([ID], [codigo], [nombre], [divisionSuperiorN2]) VALUES (6, NULL, N'Calle Blancos', 4)
INSERT [dbo].[Gen_DivisionesAdministrativasN3] ([ID], [codigo], [nombre], [divisionSuperiorN2]) VALUES (7, NULL, N'San Ignacio', 2)
INSERT [dbo].[Gen_DivisionesAdministrativasN3] ([ID], [codigo], [nombre], [divisionSuperiorN2]) VALUES (8, NULL, N'Concepción', 3)
INSERT [dbo].[Gen_DivisionesAdministrativasN3] ([ID], [codigo], [nombre], [divisionSuperiorN2]) VALUES (9, NULL, N'San Pedro', 5)
INSERT [dbo].[Gen_DivisionesAdministrativasN3] ([ID], [codigo], [nombre], [divisionSuperiorN2]) VALUES (10, NULL, N'Sabanilla', 5)
INSERT [dbo].[Gen_DivisionesAdministrativasN3] ([ID], [codigo], [nombre], [divisionSuperiorN2]) VALUES (11, NULL, N'Mata de Platano', 4)
INSERT [dbo].[Gen_DivisionesAdministrativasN3] ([ID], [codigo], [nombre], [divisionSuperiorN2]) VALUES (13, NULL, N'Orosi', 7)
INSERT [dbo].[Gen_DivisionesAdministrativasN3] ([ID], [codigo], [nombre], [divisionSuperiorN2]) VALUES (14, NULL, N'Cachi', 7)
INSERT [dbo].[Gen_DivisionesAdministrativasN3] ([ID], [codigo], [nombre], [divisionSuperiorN2]) VALUES (15, NULL, N'Pacayas', 9)
SET IDENTITY_INSERT [dbo].[Gen_DivisionesAdministrativasN3] OFF
SET IDENTITY_INSERT [dbo].[Gen_DivisionesAdministrativasN4] ON 

INSERT [dbo].[Gen_DivisionesAdministrativasN4] ([ID], [codigo], [nombre], [divisionSuperiorN3]) VALUES (1, NULL, N'subnivelOrosi', 13)
INSERT [dbo].[Gen_DivisionesAdministrativasN4] ([ID], [codigo], [nombre], [divisionSuperiorN3]) VALUES (2, NULL, N'Un Barrio Nivel 4 Pacayas', 15)
SET IDENTITY_INSERT [dbo].[Gen_DivisionesAdministrativasN4] OFF
SET IDENTITY_INSERT [dbo].[Gen_DivisionesAdministrativasN5] ON 

INSERT [dbo].[Gen_DivisionesAdministrativasN5] ([ID], [codigo], [nombre], [divisionSuperiorN4]) VALUES (1, NULL, N'Nivel 5', 2)
SET IDENTITY_INSERT [dbo].[Gen_DivisionesAdministrativasN5] OFF
SET IDENTITY_INSERT [dbo].[Gen_Monedas] ON 

INSERT [dbo].[Gen_Monedas] ([ID], [nombre], [simbolo], [codigo], [pais], [codigoPais]) VALUES (1, N'Dólar                         ', N'US$       ', N'USD       ', N'Estados Unidos                ', N'US        ')
INSERT [dbo].[Gen_Monedas] ([ID], [nombre], [simbolo], [codigo], [pais], [codigoPais]) VALUES (2, N'Colón                         ', N'¢         ', N'CRC       ', N'Costa Rica                    ', N'CRC       ')
SET IDENTITY_INSERT [dbo].[Gen_Monedas] OFF
SET IDENTITY_INSERT [dbo].[Gen_Rutas] ON 

INSERT [dbo].[Gen_Rutas] ([ID], [nombre], [descripcion], [carreteras]) VALUES (1, N'Ruta 1 (San José - Peñas Blancas)', NULL, N'De San José al Aeropuerto ITLN - Juan Santamaría, Autopista General Cañas. 
Del aeropuerto a San Ramón, Autopista Bernardo Soto. 
De San Ramón a Peñas Blancas, Interamericana Norte Algunas ciudades que comunica: San José -Heredia-Alajuela-San Ramón -Esparza-Puntarenas Peajes :2 . En Alajuela y otro en Naranjo')
INSERT [dbo].[Gen_Rutas] ([ID], [nombre], [descripcion], [carreteras]) VALUES (2, N'Ruta 2 (San José - Paso Canoas)', NULL, N'De San José a Cartago: Autopista Florencio del Castillo. De Cartago a Paso Canoas, Interamericana Sur. Algunas ciudades que comunica: San José - Cartago - San Isidro de El General - Buenos Aires - Palmar Norte - Neily - Paso Canoas. Peajes:1, en Tres Ríos de La Unión.')
INSERT [dbo].[Gen_Rutas] ([ID], [nombre], [descripcion], [carreteras]) VALUES (3, N'Ruta 27(San José - Caldera)', NULL, N'De San José a Santa Ana, Autopista Próspero Fernández. De Santa Ana a Caldera, Autopista José María Castro Madriz. Algunas ciudades que comunica: San José, Santa Ana, Ciudad Colón, Alajuela (por radial), Atenas, Orotina y Puntarenas. Peajes: 4, San Rafael de Escazú - San Rafael de Alajuela - Atenas - Orotina.')
INSERT [dbo].[Gen_Rutas] ([ID], [nombre], [descripcion], [carreteras]) VALUES (4, N'Ruta 32 (San José -Limón)', NULL, N'De San José a San Juan de Tibás: Autopista Braulio Carrillo, de San Juan de Tibás a la ciudad de Limón: Carretera Braulio Carrillo. Algunas ciudades que comunica: San José - Guápiles - Guácimo - Siquirres - Limón. Peajes:1. En San Isidro, Heredia.')
INSERT [dbo].[Gen_Rutas] ([ID], [nombre], [descripcion], [carreteras]) VALUES (5, N'Ruta 34 (Pozón - Palmar Norte)', NULL, N'Nombre: Pacífica Fernández. Algunas ciudades que comunica: Pozón - Tárcoles - Herradura - Jacó - Parrita - Quepos - Dominical- Puerto Cortés - Palmar Norte')
INSERT [dbo].[Gen_Rutas] ([ID], [nombre], [descripcion], [carreteras]) VALUES (6, N'Ruta 39 (Circunvalación)', NULL, N'Paseo de la Segunda República Principal via de distribución de la ciudad de San José. Inicia en el distrito de Uruca en el cantón de San Jose y termina en el distro de Calle Blancos del cantón de Goicoechea. Su trayecto interseca las carreteras principales de Costa Rica como la ruta 1 (Interamericana Norte - Autopista General Cañas), ruta 27 ( Carretera a Caldera - Autopista Prospero Fernández) y ruta 2 (Interamericana Sur). Posee varios pasos a desniveles, intersecciones de semáforos y rotonda')
SET IDENTITY_INSERT [dbo].[Gen_Rutas] OFF
SET IDENTITY_INSERT [dbo].[Gen_TipoIdentificacion] ON 

INSERT [dbo].[Gen_TipoIdentificacion] ([ID], [nombre]) VALUES (1, N'Cédula                                                                                              ')
INSERT [dbo].[Gen_TipoIdentificacion] ([ID], [nombre]) VALUES (2, N'Cédula de Residencia                                                                                ')
INSERT [dbo].[Gen_TipoIdentificacion] ([ID], [nombre]) VALUES (3, N'Pasaporte                                                                                           ')
INSERT [dbo].[Gen_TipoIdentificacion] ([ID], [nombre]) VALUES (4, N'Cédula Juridica                                                                                     ')
SET IDENTITY_INSERT [dbo].[Gen_TipoIdentificacion] OFF
SET IDENTITY_INSERT [dbo].[Inv_Arrendadores] ON 

INSERT [dbo].[Inv_Arrendadores] ([ID], [identificacion], [nombre], [tipoID], [notas], [direccion], [emails], [codigoPostal], [tenantID], [nombreRepresentante], [identificacionRepresentante], [tipoIDRepresentante], [website]) VALUES (3, N'21414123434', N'Juan Perez', 2, NULL, N'850 oeste del centro de Tejar, Cartago', N'fdsgdfsg@234234.com', NULL, NULL, N'Carlos Osorio', N'312312312', 2, NULL)
INSERT [dbo].[Inv_Arrendadores] ([ID], [identificacion], [nombre], [tipoID], [notas], [direccion], [emails], [codigoPostal], [tenantID], [nombreRepresentante], [identificacionRepresentante], [tipoIDRepresentante], [website]) VALUES (4, N'188885545', N'Compañia Azucarera Panal', 4, NULL, N'El Alto', N'asldja@ASDAS.COM', NULL, NULL, N'Jsda asdoi', N'188885545', 2, NULL)
INSERT [dbo].[Inv_Arrendadores] ([ID], [identificacion], [nombre], [tipoID], [notas], [direccion], [emails], [codigoPostal], [tenantID], [nombreRepresentante], [identificacionRepresentante], [tipoIDRepresentante], [website]) VALUES (7, N'234234', N'Inversiones Parabens', 4, NULL, N'ASFDASDF', N'23424@ASDF.COM', NULL, NULL, N'wADSASDs', N'98173912873', 2, NULL)
INSERT [dbo].[Inv_Arrendadores] ([ID], [identificacion], [nombre], [tipoID], [notas], [direccion], [emails], [codigoPostal], [tenantID], [nombreRepresentante], [identificacionRepresentante], [tipoIDRepresentante], [website]) VALUES (8, N'88785548', N'Wilberth Varela', 2, NULL, N'200 sur del cruce de Palmar Norte, Finca la Alegría', N'dad@asdas.com', N'sdadasd a23', NULL, N'Wilberth Varela', N'88785548', 2, N'http://www.com')
SET IDENTITY_INSERT [dbo].[Inv_Arrendadores] OFF
SET IDENTITY_INSERT [dbo].[Inv_ArrendadoresContactos] ON 

INSERT [dbo].[Inv_ArrendadoresContactos] ([ID], [nombre], [telefono1], [email], [cargo], [arrendadorID], [tenantID], [telefono2], [telefono3]) VALUES (24, N'Maria Mora', N'+506 8877 9988', N'sdadad@sadsad.com', NULL, 4, NULL, NULL, NULL)
INSERT [dbo].[Inv_ArrendadoresContactos] ([ID], [nombre], [telefono1], [email], [cargo], [arrendadorID], [tenantID], [telefono2], [telefono3]) VALUES (25, N'Diego Casas', N'+506 8870485', NULL, NULL, 3, NULL, NULL, NULL)
INSERT [dbo].[Inv_ArrendadoresContactos] ([ID], [nombre], [telefono1], [email], [cargo], [arrendadorID], [tenantID], [telefono2], [telefono3]) VALUES (26, N'Amanda Mikazo', N'+506 8877 0033', NULL, NULL, 3, NULL, NULL, NULL)
INSERT [dbo].[Inv_ArrendadoresContactos] ([ID], [nombre], [telefono1], [email], [cargo], [arrendadorID], [tenantID], [telefono2], [telefono3]) VALUES (28, N'Efrain Perez', N'+506 8870 4861', NULL, NULL, 3, NULL, N'+506 2245 4949', NULL)
INSERT [dbo].[Inv_ArrendadoresContactos] ([ID], [nombre], [telefono1], [email], [cargo], [arrendadorID], [tenantID], [telefono2], [telefono3]) VALUES (29, N'walter v', N'+506 223344', NULL, NULL, 7, NULL, NULL, NULL)
INSERT [dbo].[Inv_ArrendadoresContactos] ([ID], [nombre], [telefono1], [email], [cargo], [arrendadorID], [tenantID], [telefono2], [telefono3]) VALUES (30, N'Diogenes Moreno', N'+506 88707898', NULL, NULL, 8, NULL, NULL, NULL)
INSERT [dbo].[Inv_ArrendadoresContactos] ([ID], [nombre], [telefono1], [email], [cargo], [arrendadorID], [tenantID], [telefono2], [telefono3]) VALUES (31, N'Otra Persona', N'+506 2254454', NULL, NULL, 7, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Inv_ArrendadoresContactos] OFF
SET IDENTITY_INSERT [dbo].[Inv_CategoriasSoporteEstructura] ON 

INSERT [dbo].[Inv_CategoriasSoporteEstructura] ([ID], [nombre], [tenantID]) VALUES (1, N'Valla', NULL)
INSERT [dbo].[Inv_CategoriasSoporteEstructura] ([ID], [nombre], [tenantID]) VALUES (2, N'Mupis', NULL)
INSERT [dbo].[Inv_CategoriasSoporteEstructura] ([ID], [nombre], [tenantID]) VALUES (3, N'Cabina', NULL)
INSERT [dbo].[Inv_CategoriasSoporteEstructura] ([ID], [nombre], [tenantID]) VALUES (4, N'Autobuses', NULL)
INSERT [dbo].[Inv_CategoriasSoporteEstructura] ([ID], [nombre], [tenantID]) VALUES (5, N'Icono', NULL)
INSERT [dbo].[Inv_CategoriasSoporteEstructura] ([ID], [nombre], [tenantID]) VALUES (6, N'Metro', NULL)
INSERT [dbo].[Inv_CategoriasSoporteEstructura] ([ID], [nombre], [tenantID]) VALUES (7, N'Aeropuerto', NULL)
INSERT [dbo].[Inv_CategoriasSoporteEstructura] ([ID], [nombre], [tenantID]) VALUES (8, N'Centros Comerciales', NULL)
INSERT [dbo].[Inv_CategoriasSoporteEstructura] ([ID], [nombre], [tenantID]) VALUES (9, N'Iconos Tipo 2', NULL)
SET IDENTITY_INSERT [dbo].[Inv_CategoriasSoporteEstructura] OFF
SET IDENTITY_INSERT [dbo].[Inv_Productos] ON 

INSERT [dbo].[Inv_Productos] ([ID], [sitioID], [nombre], [categoriasSoporteEstructuraID], [tiposEstructuraID], [circuitoID], [estatusID], [monedaID], [precioVenta], [precioVentaMinimo], [precioVentaCircuito], [cantidadPorUnidad], [unidadesEnStock], [codigoProducto], [notas], [descriptionVista], [base], [altura], [imagenes], [GPSLatitud], [GPSLongitud], [ubicacion], [GPSRutaID], [tenantID], [userID], [ultimaModificacion], [userIDModifica], [fechaCreacion], [legalInfoID]) VALUES (1, 1, NULL, 1, 11, 1, 1, 1, 1000.0000, 800.0000, 850.0000, NULL, 0, N'ewrwr', N'kkjss   sakjdsl dljsdlj l lkjsdl jasldj', N'Viendo hacia curridabat', CAST(7.00 AS Decimal(10, 2)), CAST(15.00 AS Decimal(10, 2)), NULL, N'10.000373965411333', N'-84.19626832008362', NULL, NULL, 1, 1, CAST(N'2016-09-20 00:00:00.000' AS DateTime), 1, CAST(N'2016-09-20 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Inv_Productos] ([ID], [sitioID], [nombre], [categoriasSoporteEstructuraID], [tiposEstructuraID], [circuitoID], [estatusID], [monedaID], [precioVenta], [precioVentaMinimo], [precioVentaCircuito], [cantidadPorUnidad], [unidadesEnStock], [codigoProducto], [notas], [descriptionVista], [base], [altura], [imagenes], [GPSLatitud], [GPSLongitud], [ubicacion], [GPSRutaID], [tenantID], [userID], [ultimaModificacion], [userIDModifica], [fechaCreacion], [legalInfoID]) VALUES (2, 6, NULL, 2, 8, 1, 1, 1, 1000.0000, 750.0000, 900.0000, NULL, 0, N'PROD002', N'ewr', N'Viendo hacia el Norte', CAST(3.00 AS Decimal(10, 2)), CAST(4.00 AS Decimal(10, 2)), NULL, N'10.0003', N'-84.1001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Inv_Productos] ([ID], [sitioID], [nombre], [categoriasSoporteEstructuraID], [tiposEstructuraID], [circuitoID], [estatusID], [monedaID], [precioVenta], [precioVentaMinimo], [precioVentaCircuito], [cantidadPorUnidad], [unidadesEnStock], [codigoProducto], [notas], [descriptionVista], [base], [altura], [imagenes], [GPSLatitud], [GPSLongitud], [ubicacion], [GPSRutaID], [tenantID], [userID], [ultimaModificacion], [userIDModifica], [fechaCreacion], [legalInfoID]) VALUES (3, 6, NULL, 1, 11, NULL, 1, 1, 350.0000, 300.0000, 254.0000, NULL, 0, N'PROD0003', NULL, N'al sur', CAST(12.00 AS Decimal(10, 2)), CAST(13.00 AS Decimal(10, 2)), NULL, N'9.977251147795782', N'-84.7390079498291', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Inv_Productos] ([ID], [sitioID], [nombre], [categoriasSoporteEstructuraID], [tiposEstructuraID], [circuitoID], [estatusID], [monedaID], [precioVenta], [precioVentaMinimo], [precioVentaCircuito], [cantidadPorUnidad], [unidadesEnStock], [codigoProducto], [notas], [descriptionVista], [base], [altura], [imagenes], [GPSLatitud], [GPSLongitud], [ubicacion], [GPSRutaID], [tenantID], [userID], [ultimaModificacion], [userIDModifica], [fechaCreacion], [legalInfoID]) VALUES (4, 7, NULL, 5, 5, NULL, 1, 1, 150.0000, 125.0000, 125.0000, NULL, 0, N'PROD0004', N'Esto es una nota', N'Hacia el norte', CAST(1.00 AS Decimal(10, 2)), CAST(1.50 AS Decimal(10, 2)), N'[{"Filename":"Productos/00000/00000004_bvvqjqz5zyx4q.png","OriginalName":"billboardIcon.png"},{"Filename":"Productos/00000/00000004_z4nl5psdzfucy.jpg","OriginalName":"masvallas.jpg"}]', N'9.997609008331551', N'-84.11238491535187', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Inv_Productos] ([ID], [sitioID], [nombre], [categoriasSoporteEstructuraID], [tiposEstructuraID], [circuitoID], [estatusID], [monedaID], [precioVenta], [precioVentaMinimo], [precioVentaCircuito], [cantidadPorUnidad], [unidadesEnStock], [codigoProducto], [notas], [descriptionVista], [base], [altura], [imagenes], [GPSLatitud], [GPSLongitud], [ubicacion], [GPSRutaID], [tenantID], [userID], [ultimaModificacion], [userIDModifica], [fechaCreacion], [legalInfoID]) VALUES (5, 1, NULL, 1, 9, NULL, 1, 1, 1250.0000, 1000.0000, 1000.0000, NULL, 0, N'PROD0005', NULL, N'Hacia San Pedro', CAST(15.00 AS Decimal(10, 2)), CAST(10.00 AS Decimal(10, 2)), NULL, N'9.932179920258799', N'-84.07117277383804', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Inv_Productos] ([ID], [sitioID], [nombre], [categoriasSoporteEstructuraID], [tiposEstructuraID], [circuitoID], [estatusID], [monedaID], [precioVenta], [precioVentaMinimo], [precioVentaCircuito], [cantidadPorUnidad], [unidadesEnStock], [codigoProducto], [notas], [descriptionVista], [base], [altura], [imagenes], [GPSLatitud], [GPSLongitud], [ubicacion], [GPSRutaID], [tenantID], [userID], [ultimaModificacion], [userIDModifica], [fechaCreacion], [legalInfoID]) VALUES (7, 1, NULL, 1, 11, NULL, 1, 1, 1000.0000, 1000.0000, 1000.0000, NULL, 0, N'PROD0007', NULL, N'Hacia el ESTE', CAST(10.00 AS Decimal(10, 2)), CAST(6.00 AS Decimal(10, 2)), N'[{"Filename":"Productos/00000/00000007_ymsv2aqcdh4uo.png","OriginalName":"billboardIcon.png"}]', N'9.923631090867913', N'-84.03822854161263', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Inv_Productos] ([ID], [sitioID], [nombre], [categoriasSoporteEstructuraID], [tiposEstructuraID], [circuitoID], [estatusID], [monedaID], [precioVenta], [precioVentaMinimo], [precioVentaCircuito], [cantidadPorUnidad], [unidadesEnStock], [codigoProducto], [notas], [descriptionVista], [base], [altura], [imagenes], [GPSLatitud], [GPSLongitud], [ubicacion], [GPSRutaID], [tenantID], [userID], [ultimaModificacion], [userIDModifica], [fechaCreacion], [legalInfoID]) VALUES (8, 3, NULL, 1, 11, 1, 1, 1, 800.0000, 800.0000, 800.0000, NULL, 0, N'PROD0008', NULL, NULL, CAST(5.00 AS Decimal(10, 2)), CAST(8.00 AS Decimal(10, 2)), NULL, N'9.92220188830608', N'-84.05885875225067', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Inv_Productos] ([ID], [sitioID], [nombre], [categoriasSoporteEstructuraID], [tiposEstructuraID], [circuitoID], [estatusID], [monedaID], [precioVenta], [precioVentaMinimo], [precioVentaCircuito], [cantidadPorUnidad], [unidadesEnStock], [codigoProducto], [notas], [descriptionVista], [base], [altura], [imagenes], [GPSLatitud], [GPSLongitud], [ubicacion], [GPSRutaID], [tenantID], [userID], [ultimaModificacion], [userIDModifica], [fechaCreacion], [legalInfoID]) VALUES (9, 7, NULL, 1, 11, NULL, 2, 1, 1500.0000, 1000.0000, 1200.0000, NULL, 0, N'PROD0009', NULL, NULL, CAST(2.00 AS Decimal(10, 2)), CAST(5.00 AS Decimal(10, 2)), NULL, N'9.931075558342336', N'-84.08512026071548', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Inv_Productos] OFF
SET IDENTITY_INSERT [dbo].[Inv_Sitios] ON 

INSERT [dbo].[Inv_Sitios] ([ID], [arrendadorID], [direccion], [notas], [tenantID], [divisionAdministrativaN1], [divisionAdministrativaN2], [divisionAdministrativaN3], [divisionAdministrativaN4], [divisionAdministrativaN5], [rutaID], [codigoSitio]) VALUES (1, 7, N'10 metros norte esquina noroeste del parque', N'Notas del Sitio', NULL, 1, 4, 5, NULL, NULL, 1, N'Sitio 1')
INSERT [dbo].[Inv_Sitios] ([ID], [arrendadorID], [direccion], [notas], [tenantID], [divisionAdministrativaN1], [divisionAdministrativaN2], [divisionAdministrativaN3], [divisionAdministrativaN4], [divisionAdministrativaN5], [rutaID], [codigoSitio]) VALUES (3, 4, N'Ina Alajuela', N'Más notas ñero', NULL, 1, 3, 8, NULL, NULL, 4, N'Sitio 2')
INSERT [dbo].[Inv_Sitios] ([ID], [arrendadorID], [direccion], [notas], [tenantID], [divisionAdministrativaN1], [divisionAdministrativaN2], [divisionAdministrativaN3], [divisionAdministrativaN4], [divisionAdministrativaN5], [rutaID], [codigoSitio]) VALUES (4, 4, N'dad asd asd asd', NULL, NULL, 1, 2, 7, NULL, NULL, NULL, NULL)
INSERT [dbo].[Inv_Sitios] ([ID], [arrendadorID], [direccion], [notas], [tenantID], [divisionAdministrativaN1], [divisionAdministrativaN2], [divisionAdministrativaN3], [divisionAdministrativaN4], [divisionAdministrativaN5], [rutaID], [codigoSitio]) VALUES (5, 8, N'ZXxZX Z xs ad', N'sadADS', NULL, 3, 9, 15, NULL, NULL, NULL, NULL)
INSERT [dbo].[Inv_Sitios] ([ID], [arrendadorID], [direccion], [notas], [tenantID], [divisionAdministrativaN1], [divisionAdministrativaN2], [divisionAdministrativaN3], [divisionAdministrativaN4], [divisionAdministrativaN5], [rutaID], [codigoSitio]) VALUES (6, 4, N'DZGZDF', N'ADFASDF', NULL, 3, 7, 14, NULL, NULL, 1, N'SIT0000006')
INSERT [dbo].[Inv_Sitios] ([ID], [arrendadorID], [direccion], [notas], [tenantID], [divisionAdministrativaN1], [divisionAdministrativaN2], [divisionAdministrativaN3], [divisionAdministrativaN4], [divisionAdministrativaN5], [rutaID], [codigoSitio]) VALUES (7, 3, N'San Jose Costa Rica', N'Esto es una nota del Sitio', NULL, 1, 4, 6, NULL, NULL, 2, N'SIT0007')
SET IDENTITY_INSERT [dbo].[Inv_Sitios] OFF
SET IDENTITY_INSERT [dbo].[Inv_Status] ON 

INSERT [dbo].[Inv_Status] ([ID], [nombre], [tenantID], [criterios]) VALUES (1, N'Disponible', NULL, NULL)
INSERT [dbo].[Inv_Status] ([ID], [nombre], [tenantID], [criterios]) VALUES (2, N'Reservado (a)', NULL, NULL)
INSERT [dbo].[Inv_Status] ([ID], [nombre], [tenantID], [criterios]) VALUES (3, N'Arrendado (a)', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Inv_Status] OFF
SET IDENTITY_INSERT [dbo].[Inv_TiposEstructura] ON 

INSERT [dbo].[Inv_TiposEstructura] ([ID], [categoriasSoporteEstructuraID], [tenantID], [nombre]) VALUES (1, 4, NULL, N'Espalda')
INSERT [dbo].[Inv_TiposEstructura] ([ID], [categoriasSoporteEstructuraID], [tenantID], [nombre]) VALUES (2, 4, NULL, N'Costado')
INSERT [dbo].[Inv_TiposEstructura] ([ID], [categoriasSoporteEstructuraID], [tenantID], [nombre]) VALUES (3, 8, NULL, N'Elevador')
INSERT [dbo].[Inv_TiposEstructura] ([ID], [categoriasSoporteEstructuraID], [tenantID], [nombre]) VALUES (4, 8, NULL, N'Gradas Electricas')
INSERT [dbo].[Inv_TiposEstructura] ([ID], [categoriasSoporteEstructuraID], [tenantID], [nombre]) VALUES (5, 5, NULL, N'Iconos Standard Via Pública')
INSERT [dbo].[Inv_TiposEstructura] ([ID], [categoriasSoporteEstructuraID], [tenantID], [nombre]) VALUES (6, 5, NULL, N'Informativo Vía Publica')
INSERT [dbo].[Inv_TiposEstructura] ([ID], [categoriasSoporteEstructuraID], [tenantID], [nombre]) VALUES (7, 6, NULL, N'Vagón Costado 100%')
INSERT [dbo].[Inv_TiposEstructura] ([ID], [categoriasSoporteEstructuraID], [tenantID], [nombre]) VALUES (8, 2, NULL, N'Estandar Cristal Via Pública')
INSERT [dbo].[Inv_TiposEstructura] ([ID], [categoriasSoporteEstructuraID], [tenantID], [nombre]) VALUES (9, 1, NULL, N'Unipolar 2 Caras')
INSERT [dbo].[Inv_TiposEstructura] ([ID], [categoriasSoporteEstructuraID], [tenantID], [nombre]) VALUES (11, 1, NULL, N'Estándar Viga Americana')
INSERT [dbo].[Inv_TiposEstructura] ([ID], [categoriasSoporteEstructuraID], [tenantID], [nombre]) VALUES (12, 1, NULL, N'Estándar Tubo Redondo')
SET IDENTITY_INSERT [dbo].[Inv_TiposEstructura] OFF
SET IDENTITY_INSERT [dbo].[Languages] ON 

INSERT [dbo].[Languages] ([Id], [LanguageId], [LanguageName]) VALUES (1, N'en', N'English')
INSERT [dbo].[Languages] ([Id], [LanguageId], [LanguageName]) VALUES (2, N'ru', N'Russian')
INSERT [dbo].[Languages] ([Id], [LanguageId], [LanguageName]) VALUES (3, N'es', N'Spanish')
INSERT [dbo].[Languages] ([Id], [LanguageId], [LanguageName]) VALUES (4, N'tr', N'Turkish')
INSERT [dbo].[Languages] ([Id], [LanguageId], [LanguageName]) VALUES (5, N'de', N'German')
INSERT [dbo].[Languages] ([Id], [LanguageId], [LanguageName]) VALUES (6, N'zh-CN', N'Chinese (Simplified)')
INSERT [dbo].[Languages] ([Id], [LanguageId], [LanguageName]) VALUES (7, N'it', N'Italian')
INSERT [dbo].[Languages] ([Id], [LanguageId], [LanguageName]) VALUES (8, N'pt', N'Portuguese')
INSERT [dbo].[Languages] ([Id], [LanguageId], [LanguageName]) VALUES (9, N'pt-BR', N'Portuguese (Brazil)')
INSERT [dbo].[Languages] ([Id], [LanguageId], [LanguageName]) VALUES (10, N'fa', N'Farsi')
SET IDENTITY_INSERT [dbo].[Languages] OFF
SET IDENTITY_INSERT [dbo].[Log_RegistroSimple] ON 

INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (1, N'Inventario.InvArrendadoresContactos', 19, 1, CAST(N'2016-09-07 18:13:18.473' AS DateTime), 1, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (3, N'Inventario.InvArrendadoresContactos', 18, 1, CAST(N'2016-09-07 18:13:18.473' AS DateTime), 2, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (4, N'Inventario.InvArrendadoresContactos', 17, 1, CAST(N'2014-04-01 01:13:18.473' AS DateTime), 1, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (5, N'Logs.LogRegistroSimple', 20, 1, CAST(N'2016-09-07 18:35:10.120' AS DateTime), 1, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (6, N'Inventario.InvArrendadoresContactos', 22, 1, CAST(N'2016-09-07 18:43:26.073' AS DateTime), 1, CAST(N'2016-09-08 16:43:28.487' AS DateTime), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (7, N'Inventario.InvArrendadoresContactos', 23, 1, CAST(N'2016-09-08 16:16:12.887' AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (8, N'Inventario.InvArrendadoresContactos', 24, 1, CAST(N'2016-09-08 17:02:47.000' AS DateTime), 1, CAST(N'2016-09-09 12:04:17.757' AS DateTime), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (9, N'Inventario.InvArrendadoresContactos', 25, 1, CAST(N'2016-09-08 17:48:32.570' AS DateTime), 1, CAST(N'2016-09-16 13:40:27.947' AS DateTime), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (10, N'Inventario.InvArrendadoresContactos', 26, 1, CAST(N'2016-09-08 17:49:03.807' AS DateTime), 1, CAST(N'2016-09-20 11:18:17.317' AS DateTime), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (11, N'Inventario.InvArrendadoresContactos', 27, 1, CAST(N'2016-09-08 17:58:26.617' AS DateTime), 1, CAST(N'2016-09-09 12:04:02.737' AS DateTime), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (12, N'Inventario.InvCategoriasSoporteEstructura', 9, 1, CAST(N'2016-09-10 18:27:31.327' AS DateTime), 1, CAST(N'2016-09-16 16:46:25.940' AS DateTime), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (13, N'Inventario.InvArrendadores', 6, 1, CAST(N'2016-09-12 11:45:28.017' AS DateTime), NULL, NULL, NULL, N'Deleted by admin on 9/12/2016 11:46:50 AM', NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (14, N'Inventario.InvArrendadores', 7, 1, CAST(N'2016-09-12 11:47:41.743' AS DateTime), 1, CAST(N'2016-09-16 13:37:18.740' AS DateTime), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (15, N'Inventario.InvArrendadores', 8, 1, CAST(N'2016-09-16 12:48:06.620' AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (16, N'Inventario.InvArrendadoresContactos', 28, 1, CAST(N'2016-09-16 12:53:35.097' AS DateTime), 1, CAST(N'2016-09-16 12:54:37.060' AS DateTime), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (17, N'Inventario.InvArrendadoresContactos', 29, 1, CAST(N'2016-09-16 13:00:50.063' AS DateTime), 1, CAST(N'2016-09-16 13:21:02.947' AS DateTime), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (18, N'Inventario.InvArrendadoresContactos', 30, 1, CAST(N'2016-09-16 13:39:22.443' AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (19, N'Inventario.InvSitios', 1, 1, CAST(N'2016-09-19 10:24:57.830' AS DateTime), 1, CAST(N'2016-10-01 16:11:26.090' AS DateTime), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (20, N'Inventario.InvSitios', 2, 1, CAST(N'2016-09-19 11:34:30.337' AS DateTime), 1, CAST(N'2016-09-19 17:00:05.040' AS DateTime), NULL, N'Deleted by admin on 9/19/2016 5:27:29 PM', NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (21, N'Inventario.InvSitios', 3, 1, CAST(N'2016-09-19 16:10:17.743' AS DateTime), 1, CAST(N'2016-09-20 13:51:50.230' AS DateTime), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (22, N'Inventario.InvSitios', 4, 1, CAST(N'2016-09-19 17:51:07.277' AS DateTime), NULL, NULL, NULL, N'Deleted by admin on 9/19/2016 5:51:17 PM', NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (23, N'Inventario.InvSitios', 5, 1, CAST(N'2016-09-19 17:51:52.360' AS DateTime), NULL, NULL, NULL, N'Deleted by admin on 9/19/2016 5:52:43 PM', NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (24, N'Inventario.InvSitios', 6, 1, CAST(N'2016-09-19 18:02:54.630' AS DateTime), NULL, NULL, NULL, N'Deleted by admin on 9/19/2016 6:03:03 PM', NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (25, N'Inventario.InvTiposEstructura', 1, 1, CAST(N'2016-09-20 18:43:28.183' AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (26, N'Inventario.InvTiposEstructura', 2, 1, CAST(N'2016-09-20 18:43:35.253' AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (27, N'Inventario.InvTiposEstructura', 3, 1, CAST(N'2016-09-20 18:43:58.660' AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (28, N'Inventario.InvTiposEstructura', 4, 1, CAST(N'2016-09-20 18:44:09.477' AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (29, N'Inventario.InvTiposEstructura', 5, 1, CAST(N'2016-09-20 18:44:34.623' AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (30, N'Inventario.InvTiposEstructura', 6, 1, CAST(N'2016-09-20 18:44:58.243' AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (31, N'Inventario.InvTiposEstructura', 7, 1, CAST(N'2016-09-20 18:45:27.487' AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (32, N'Inventario.InvTiposEstructura', 8, 1, CAST(N'2016-09-20 18:45:54.337' AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (33, N'Inventario.InvTiposEstructura', 9, 1, CAST(N'2016-09-20 18:46:16.757' AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (34, N'Inventario.InvTiposEstructura', 10, 1, CAST(N'2016-09-20 18:46:27.623' AS DateTime), NULL, NULL, NULL, N'Deleted by admin on 10/1/2016 4:12:09 PM', NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (35, N'Inventario.InvTiposEstructura', 11, 1, CAST(N'2016-09-20 18:47:56.457' AS DateTime), 1, CAST(N'2016-09-24 15:46:52.050' AS DateTime), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (36, N'Inventario.InvTiposEstructura', 12, 1, CAST(N'2016-09-20 18:48:16.983' AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (37, N'Inventario.InvSitios', 4, 1, CAST(N'2016-09-23 17:29:25.787' AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (38, N'Inventario.InvSitios', 5, 1, CAST(N'2016-09-23 17:29:48.390' AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (39, N'Inventario.InvSitios', 6, 1, CAST(N'2016-09-23 17:32:18.050' AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (40, N'Inventario.InvProductos', 2, 1, CAST(N'2016-09-23 17:49:28.897' AS DateTime), 1, CAST(N'2016-09-28 17:18:50.863' AS DateTime), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (41, N'Inventario.InvSitios', 7, 1, CAST(N'2016-09-23 17:53:15.173' AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (42, N'Inventario.InvProductos', 3, 1, CAST(N'2016-09-26 10:42:28.573' AS DateTime), 1, CAST(N'2016-09-29 19:00:47.037' AS DateTime), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (43, N'Inventario.InvProductos', 4, 1, CAST(N'2016-09-28 09:44:53.710' AS DateTime), 1, CAST(N'2016-09-30 09:30:19.597' AS DateTime), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (44, N'Inventario.InvProductos', 5, 1, CAST(N'2016-09-28 17:06:46.850' AS DateTime), 1, CAST(N'2016-09-30 10:23:46.763' AS DateTime), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (45, N'Inventario.InvProductos', 7, 1, CAST(N'2016-09-30 11:07:32.517' AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (46, N'Inventario.InvProductos', 8, 1, CAST(N'2016-09-30 11:09:02.670' AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (47, N'Inventario.InvProductos', 9, 1, CAST(N'2016-10-01 14:59:15.937' AS DateTime), 1, CAST(N'2016-10-01 15:01:38.953' AS DateTime), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (48, N'Inventario.InvArrendadoresContactos', 31, 1, CAST(N'2016-10-01 15:03:12.963' AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Log_RegistroSimple] ([ID], [EntityType], [EntityID], [UsuarioRegistraID], [FechaRegistro], [UsuarioModifica], [FechaModifica], [Texto1], [Texto2], [Ip1], [Ip2], [tenantID]) VALUES (49, N'Inventario.InvStatus', 3, 1, CAST(N'2016-10-01 16:55:09.207' AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Log_RegistroSimple] OFF
SET IDENTITY_INSERT [dbo].[Notes] ON 

INSERT [dbo].[Notes] ([NoteID], [EntityType], [EntityID], [Text], [InsertUserId], [InsertDate]) VALUES (2, N'Inventario.InvProductos', 1, N'<p>esto es otra nota simple</p>', 1, CAST(N'2016-09-29 09:36:38.877' AS DateTime))
INSERT [dbo].[Notes] ([NoteID], [EntityType], [EntityID], [Text], [InsertUserId], [InsertDate]) VALUES (3, N'Inventario.InvProductos', 2, N'<p>esto es una nota simplea</p>', 1, CAST(N'2016-09-29 09:36:38.890' AS DateTime))
INSERT [dbo].[Notes] ([NoteID], [EntityType], [EntityID], [Text], [InsertUserId], [InsertDate]) VALUES (5, N'[dbo].[Inv_Productos]', 4, N'<p>Esto es una nota de otro usuario sadad</p>', 2, CAST(N'2016-09-29 09:40:30.953' AS DateTime))
INSERT [dbo].[Notes] ([NoteID], [EntityType], [EntityID], [Text], [InsertUserId], [InsertDate]) VALUES (6, N'Inventario.InvProductos', 5, N'<p>fsfasfasf</p>', 2, CAST(N'2016-09-29 09:43:43.587' AS DateTime))
INSERT [dbo].[Notes] ([NoteID], [EntityType], [EntityID], [Text], [InsertUserId], [InsertDate]) VALUES (7, N'[dbo].[Inv_Productos]', 3, N'<p>afafafdafadfadf</p>', 2, CAST(N'2016-09-29 11:11:01.050' AS DateTime))
INSERT [dbo].[Notes] ([NoteID], [EntityType], [EntityID], [Text], [InsertUserId], [InsertDate]) VALUES (9, N'[dbo].[Inv_Productos]', 4, N'<p><span style="color:#008000">asdasdassd sad sad sd s&nbsp;</span><span style="color:#FF0000">&nbsp;asdsds&nbsp;</span><span style="color:#00FFFF">dsadasdsad &nbsp; &nbsp;<em>asdasdasdd s</em><strong>&nbsp;sadda sdad<u>asdadasda asd sd asddsa</u></strong></span></p>', 1, CAST(N'2016-09-29 15:21:24.073' AS DateTime))
INSERT [dbo].[Notes] ([NoteID], [EntityType], [EntityID], [Text], [InsertUserId], [InsertDate]) VALUES (12, N'[dbo].[Inv_Productos]', 1, N'<p>nota</p>', 1, CAST(N'2016-09-29 18:21:09.000' AS DateTime))
INSERT [dbo].[Notes] ([NoteID], [EntityType], [EntityID], [Text], [InsertUserId], [InsertDate]) VALUES (13, N'[dbo].[Inv_Productos]', 5, N'<p>dfasfaf a sdf ads</p>', 1, CAST(N'2016-09-29 19:01:18.137' AS DateTime))
INSERT [dbo].[Notes] ([NoteID], [EntityType], [EntityID], [Text], [InsertUserId], [InsertDate]) VALUES (14, N'[dbo].[Inv_Productos]', 5, N'<p>das as AD AD SADAS</p>', 1, CAST(N'2016-09-30 10:23:46.750' AS DateTime))
INSERT [dbo].[Notes] ([NoteID], [EntityType], [EntityID], [Text], [InsertUserId], [InsertDate]) VALUES (15, N'[dbo].[Inv_Productos]', 9, N'<p>lk jso jsjdfo sodf osdjf oajfd</p>', 1, CAST(N'2016-10-01 15:01:38.947' AS DateTime))
INSERT [dbo].[Notes] ([NoteID], [EntityType], [EntityID], [Text], [InsertUserId], [InsertDate]) VALUES (16, N'[dbo].[Inv_Productos]', 9, N'<p>tfggk g hgk jkgkg k &nbsp;uk gkg &nbsp;ggkjhkhjk</p>', 1, CAST(N'2016-10-01 15:01:38.953' AS DateTime))
SET IDENTITY_INSERT [dbo].[Notes] OFF
SET IDENTITY_INSERT [dbo].[Productos] ON 

INSERT [dbo].[Productos] ([ID_Producto], [ID_Sitio], [Nombre], [ID_Categoria], [CantidadPorUnidad], [Precio], [UnidadesEnStock], [UnidadesEnOrden], [Deshabilitado], [ID_Moneda], [PrecioMinimo], [CodigoInterno], [ID_TipoProducto], [Descripcion], [DescriptionVista], [Base], [Altura], [PrecioElectricidad], [Images], [NumPlanoCas], [NumOficina], [NumPermiso], [PermisionDueDate], [GPSLatitud], [GPSLongitud]) VALUES (1, 1, N'Valla 1', 1, N'1', 1500.0000, 1, 1, 0, 1, 1200.0000, N'1 #45', 1, N'Valla', N'Hacia la Uruca', CAST(9.00 AS Decimal(10, 2)), CAST(6.00 AS Decimal(10, 2)), 300.0000, NULL, NULL, NULL, NULL, CAST(N'2016-08-27 00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[Productos] ([ID_Producto], [ID_Sitio], [Nombre], [ID_Categoria], [CantidadPorUnidad], [Precio], [UnidadesEnStock], [UnidadesEnOrden], [Deshabilitado], [ID_Moneda], [PrecioMinimo], [CodigoInterno], [ID_TipoProducto], [Descripcion], [DescriptionVista], [Base], [Altura], [PrecioElectricidad], [Images], [NumPlanoCas], [NumOficina], [NumPermiso], [PermisionDueDate], [GPSLatitud], [GPSLongitud]) VALUES (2, 2, N'Vallas 2Bc', 2, N'1', 950.0000, 1, 1, 0, 1, 870.0000, N'23 #2', 1, N'Valla Publicitaria', N'Hacia Heredia', CAST(10.00 AS Decimal(10, 2)), CAST(6.00 AS Decimal(10, 2)), 0.0000, N'ProductImage/00000/00000002_d73yzrxt62yek.jpg', NULL, NULL, NULL, NULL, N'-989889', N'-989899')
INSERT [dbo].[Productos] ([ID_Producto], [ID_Sitio], [Nombre], [ID_Categoria], [CantidadPorUnidad], [Precio], [UnidadesEnStock], [UnidadesEnOrden], [Deshabilitado], [ID_Moneda], [PrecioMinimo], [CodigoInterno], [ID_TipoProducto], [Descripcion], [DescriptionVista], [Base], [Altura], [PrecioElectricidad], [Images], [NumPlanoCas], [NumOficina], [NumPermiso], [PermisionDueDate], [GPSLatitud], [GPSLongitud]) VALUES (3, 321, N'Vallas 321', 1, N'1', 1200.0000, 1, 1, 0, 1, 980.0000, N'02 #321', NULL, NULL, N'Hacia la Luna', CAST(7.00 AS Decimal(10, 2)), CAST(4.00 AS Decimal(10, 2)), 100.0000, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Productos] ([ID_Producto], [ID_Sitio], [Nombre], [ID_Categoria], [CantidadPorUnidad], [Precio], [UnidadesEnStock], [UnidadesEnOrden], [Deshabilitado], [ID_Moneda], [PrecioMinimo], [CodigoInterno], [ID_TipoProducto], [Descripcion], [DescriptionVista], [Base], [Altura], [PrecioElectricidad], [Images], [NumPlanoCas], [NumOficina], [NumPermiso], [PermisionDueDate], [GPSLatitud], [GPSLongitud]) VALUES (4, 1, N'Valla 1qw', NULL, NULL, 2334.0000, NULL, NULL, 0, 1, 2333.0000, NULL, NULL, NULL, NULL, NULL, NULL, 300.0000, N'[{"Filename":"ProductImage/00000/00000004_h4hnxdygbj75s.jpg","OriginalName":"IMG_20160802_103453.jpg"},{"Filename":"ProductImage/00000/00000004_sc5ait7djfelc.jpg","OriginalName":"IMG_20160802_103403.jpg"}]', NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Productos] OFF
SET IDENTITY_INSERT [dbo].[UserPermissions] ON 

INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (1, 2, N'Administration:Translation', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (2, 2, N'Administration:Security', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (9, 2, N'AdministradorDeSistema', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (10, 2, N'DatosGenerales', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (12, 2, N'Northwind:General', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (13, 2, N'Northwind:Customer:Modify', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (14, 2, N'Northwind:Customer:Delete', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (15, 2, N'Northwind:Customer:View', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (28, 2, N'MantenimientoGeneral', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (37, 2, N'General:MantenimientoGeneral:DivisionesAdministrativas:Actualizar', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (38, 2, N'General:MantenimientoGeneral:DivisionesAdministrativas:Borrar', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (39, 2, N'General:MantenimientoGeneral:DivisionesAdministrativas:Insertar', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (40, 2, N'General:MantenimientoGeneral:DivisionesAdministrativas:Leer', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (41, 2, N'General:MantenimientoGeneral:DivisionesAdministrativas:Modificar', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (43, 2, N'General:PaginaMantenimientoGeneral', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (44, 2, N'General:MantenimientoGeneral:PaginaDivisionAdministrativaN1', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (45, 2, N'General:MantenimientoGeneral:PaginaDivisionAdministrativaN2', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (46, 2, N'General:MantenimientoGeneral:PaginaDivisionAdministrativaN3', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (47, 2, N'Inventario:Arrendadores:Actualizar', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (48, 2, N'Inventario:Arrendadores:Borrar', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (49, 2, N'Inventario:Arrendadores:Insertar', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (50, 2, N'Inventario:Arrendadores:Leer', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (51, 2, N'Inventario:Arrendadores:Modificar', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (52, 2, N'Inventario:ContratosArrendamiento:Actualizar', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (53, 2, N'Inventario:ContratosArrendamiento:Borrar', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (54, 2, N'Inventario:ContratosArrendamiento:Insertar', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (55, 2, N'Inventario:ContratosArrendamiento:Leer', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (56, 2, N'Inventario:ContratosArrendamiento:Modificar', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (57, 2, N'Inventario:PaginaArrendadores', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (58, 2, N'Inventario:PaginaContratos', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (59, 2, N'Inventario:PaginaEstructuras', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (60, 2, N'Inventario:PaginaProductos', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (61, 2, N'Inventario:PaginaSitios', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (62, 2, N'Inventario:Productos:Actualizar', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (63, 2, N'Inventario:Productos:Borrar', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (64, 2, N'Inventario:Productos:Insertar', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (65, 2, N'Inventario:Productos:Leer', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (66, 2, N'Inventario:Productos:Modificar', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (67, 2, N'Inventario:Sitios:Actualizar', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (68, 2, N'Inventario:Sitios:Borrar', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (69, 2, N'Inventario:Sitios:Insertar', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (70, 2, N'Inventario:Sitios:Leer', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (71, 2, N'Inventario:Sitios:Modificar', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (72, 2, N'AdministracionDeInventario', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (73, 2, N'General:MantenimientoGeneral:Actualizar', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (74, 2, N'General:MantenimientoGeneral:Borrar', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (75, 2, N'General:MantenimientoGeneral:Insertar', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (76, 2, N'General:MantenimientoGeneral:Leer', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (77, 2, N'General:MantenimientoGeneral:Modificar', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (78, 2, N'General:MantenimientoGeneral:PaginaDivisionAdministrativaN4', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (79, 2, N'General:MantenimientoGeneral:PaginaDivisionAdministrativaN5', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (80, 2, N'General:Notas:Actualizar', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (81, 2, N'General:Notas:Borrar', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (82, 2, N'General:Notas:Insertar', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (83, 2, N'General:Notas:Leer', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (84, 2, N'General:Notas:Modificar', 1)
INSERT [dbo].[UserPermissions] ([UserPermissionId], [UserId], [PermissionKey], [Granted]) VALUES (85, 2, N'Administration', 1)
SET IDENTITY_INSERT [dbo].[UserPermissions] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserId], [Username], [DisplayName], [Email], [Source], [PasswordHash], [PasswordSalt], [InsertDate], [InsertUserId], [UpdateDate], [UpdateUserId], [IsActive], [LastDirectoryUpdate], [tenantID]) VALUES (1, N'admin', N'admin', N'admin@dummy.com', N'site', N'rfqpSPYs0ekFlPyvIRTXsdhE/qrTHFF+kKsAUla7pFkXL4BgLGlTe89GDX5DBysenMDj8AqbIZPybqvusyCjwQ', N'hJf_F', CAST(N'2014-01-01 00:00:00.000' AS DateTime), 1, NULL, NULL, 1, NULL, NULL)
INSERT [dbo].[Users] ([UserId], [Username], [DisplayName], [Email], [Source], [PasswordHash], [PasswordSalt], [InsertDate], [InsertUserId], [UpdateDate], [UpdateUserId], [IsActive], [LastDirectoryUpdate], [tenantID]) VALUES (2, N'admin2', N'admin2', N'admin2@admin.com', N'site', N'qUfJyt5KibMJYLNcCyfwUcd5ent82S0rM9Er0texhRsex2QxTitzrPjCkF8Baw5pINC7OgY5gURkibNjTHWitQ', N'blz%R', CAST(N'2016-08-30 19:41:48.227' AS DateTime), 1, CAST(N'2016-08-30 20:00:02.037' AS DateTime), 2, 1, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Users] OFF
INSERT [dbo].[VersionInfo] ([Version], [AppliedOn], [Description]) VALUES (20141103140000, CAST(N'2016-08-25 21:37:42.000' AS DateTime), N'DefaultDB_20141103_140000_Initial')
INSERT [dbo].[VersionInfo] ([Version], [AppliedOn], [Description]) VALUES (20141111113000, CAST(N'2016-08-25 21:37:42.000' AS DateTime), N'DefaultDB_20141111_113000_Permissions')
INSERT [dbo].[VersionInfo] ([Version], [AppliedOn], [Description]) VALUES (20151111133500, CAST(N'2016-08-25 21:37:42.000' AS DateTime), N'DefaultDB_20151111_133500_UserPermissionGrant')
INSERT [dbo].[VersionInfo] ([Version], [AppliedOn], [Description]) VALUES (20151217000600, CAST(N'2016-08-25 21:37:42.000' AS DateTime), N'DefaultDB_20151217_000600_LastDirectoryUpdate')
INSERT [dbo].[VersionInfo] ([Version], [AppliedOn], [Description]) VALUES (20160515072600, CAST(N'2016-08-25 21:37:42.000' AS DateTime), N'DefaultDB_20160515_072600_UserPreferences')
INSERT [dbo].[VersionInfo] ([Version], [AppliedOn], [Description]) VALUES (20160605215300, CAST(N'2016-08-25 21:37:43.000' AS DateTime), N'DefaultDB_20160605_215300_Granted')
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_RolePerm_RoleId_PermKey]    Script Date: 10/1/2016 5:14:11 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_RolePerm_RoleId_PermKey] ON [dbo].[RolePermissions]
(
	[RoleId] ASC,
	[PermissionKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_UserPerm_UserId_PermKey]    Script Date: 10/1/2016 5:14:11 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_UserPerm_UserId_PermKey] ON [dbo].[UserPermissions]
(
	[UserId] ASC,
	[PermissionKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_UserPref_UID_PrefType_Name]    Script Date: 10/1/2016 5:14:11 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_UserPref_UID_PrefType_Name] ON [dbo].[UserPreferences]
(
	[UserId] ASC,
	[PreferenceType] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserRoles_RoleId_UserId]    Script Date: 10/1/2016 5:14:11 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserRoles_RoleId_UserId] ON [dbo].[UserRoles]
(
	[RoleId] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ_UserRoles_UserId_RoleId]    Script Date: 10/1/2016 5:14:11 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_UserRoles_UserId_RoleId] ON [dbo].[UserRoles]
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Gen_DivisionesAdministrativasN2]  WITH CHECK ADD  CONSTRAINT [FK_Gen_DivisionesAdministrativasN2_Gen_DivisionesAdministrativasN1] FOREIGN KEY([divisionSuperiorN1])
REFERENCES [dbo].[Gen_DivisionesAdministrativasN1] ([ID])
GO
ALTER TABLE [dbo].[Gen_DivisionesAdministrativasN2] CHECK CONSTRAINT [FK_Gen_DivisionesAdministrativasN2_Gen_DivisionesAdministrativasN1]
GO
ALTER TABLE [dbo].[Gen_DivisionesAdministrativasN3]  WITH CHECK ADD  CONSTRAINT [FK_Gen_DivisionesAdministrativasN3_Gen_DivisionesAdministrativasN2] FOREIGN KEY([divisionSuperiorN2])
REFERENCES [dbo].[Gen_DivisionesAdministrativasN2] ([ID])
GO
ALTER TABLE [dbo].[Gen_DivisionesAdministrativasN3] CHECK CONSTRAINT [FK_Gen_DivisionesAdministrativasN3_Gen_DivisionesAdministrativasN2]
GO
ALTER TABLE [dbo].[Gen_DivisionesAdministrativasN4]  WITH CHECK ADD  CONSTRAINT [FK_Gen_DivisionesAdministrativasN4_Gen_DivisionesAdministrativasN3] FOREIGN KEY([divisionSuperiorN3])
REFERENCES [dbo].[Gen_DivisionesAdministrativasN3] ([ID])
GO
ALTER TABLE [dbo].[Gen_DivisionesAdministrativasN4] CHECK CONSTRAINT [FK_Gen_DivisionesAdministrativasN4_Gen_DivisionesAdministrativasN3]
GO
ALTER TABLE [dbo].[Gen_DivisionesAdministrativasN5]  WITH CHECK ADD  CONSTRAINT [FK_Gen_DivisionesAdministrativasN5_Gen_DivisionesAdministrativasN4] FOREIGN KEY([divisionSuperiorN4])
REFERENCES [dbo].[Gen_DivisionesAdministrativasN4] ([ID])
GO
ALTER TABLE [dbo].[Gen_DivisionesAdministrativasN5] CHECK CONSTRAINT [FK_Gen_DivisionesAdministrativasN5_Gen_DivisionesAdministrativasN4]
GO
ALTER TABLE [dbo].[Inv_Arrendadores]  WITH CHECK ADD  CONSTRAINT [FK_Inv_Arrendadores_Gen_TipoIdentificacion] FOREIGN KEY([tipoID])
REFERENCES [dbo].[Gen_TipoIdentificacion] ([ID])
GO
ALTER TABLE [dbo].[Inv_Arrendadores] CHECK CONSTRAINT [FK_Inv_Arrendadores_Gen_TipoIdentificacion]
GO
ALTER TABLE [dbo].[Inv_Arrendadores]  WITH CHECK ADD  CONSTRAINT [FK_Inv_Arrendadores_Gen_TipoIdentificacion2] FOREIGN KEY([tipoIDRepresentante])
REFERENCES [dbo].[Gen_TipoIdentificacion] ([ID])
GO
ALTER TABLE [dbo].[Inv_Arrendadores] CHECK CONSTRAINT [FK_Inv_Arrendadores_Gen_TipoIdentificacion2]
GO
ALTER TABLE [dbo].[Inv_ArrendadoresContactos]  WITH CHECK ADD  CONSTRAINT [FK_Inv_ArrendadoresContactos_Inv_Arrendadores] FOREIGN KEY([arrendadorID])
REFERENCES [dbo].[Inv_Arrendadores] ([ID])
GO
ALTER TABLE [dbo].[Inv_ArrendadoresContactos] CHECK CONSTRAINT [FK_Inv_ArrendadoresContactos_Inv_Arrendadores]
GO
ALTER TABLE [dbo].[Inv_Productos]  WITH CHECK ADD  CONSTRAINT [FK_Inv_Productos_Gen_Monedas] FOREIGN KEY([monedaID])
REFERENCES [dbo].[Gen_Monedas] ([ID])
GO
ALTER TABLE [dbo].[Inv_Productos] CHECK CONSTRAINT [FK_Inv_Productos_Gen_Monedas]
GO
ALTER TABLE [dbo].[Inv_Productos]  WITH CHECK ADD  CONSTRAINT [FK_Inv_Productos_Inv_Sitios] FOREIGN KEY([sitioID])
REFERENCES [dbo].[Inv_Sitios] ([ID])
GO
ALTER TABLE [dbo].[Inv_Productos] CHECK CONSTRAINT [FK_Inv_Productos_Inv_Sitios]
GO
ALTER TABLE [dbo].[Inv_Productos]  WITH CHECK ADD  CONSTRAINT [FK_Inv_Productos_Users] FOREIGN KEY([userIDModifica])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[Inv_Productos] CHECK CONSTRAINT [FK_Inv_Productos_Users]
GO
ALTER TABLE [dbo].[Inv_Sitios]  WITH CHECK ADD  CONSTRAINT [FK_Inv_Sitios_Gen_DivisionesAdministrativasN1] FOREIGN KEY([divisionAdministrativaN1])
REFERENCES [dbo].[Gen_DivisionesAdministrativasN1] ([ID])
GO
ALTER TABLE [dbo].[Inv_Sitios] CHECK CONSTRAINT [FK_Inv_Sitios_Gen_DivisionesAdministrativasN1]
GO
ALTER TABLE [dbo].[Inv_Sitios]  WITH CHECK ADD  CONSTRAINT [FK_Inv_Sitios_Gen_DivisionesAdministrativasN2] FOREIGN KEY([divisionAdministrativaN2])
REFERENCES [dbo].[Gen_DivisionesAdministrativasN2] ([ID])
GO
ALTER TABLE [dbo].[Inv_Sitios] CHECK CONSTRAINT [FK_Inv_Sitios_Gen_DivisionesAdministrativasN2]
GO
ALTER TABLE [dbo].[Inv_Sitios]  WITH CHECK ADD  CONSTRAINT [FK_Inv_Sitios_Gen_DivisionesAdministrativasN3] FOREIGN KEY([divisionAdministrativaN3])
REFERENCES [dbo].[Gen_DivisionesAdministrativasN3] ([ID])
GO
ALTER TABLE [dbo].[Inv_Sitios] CHECK CONSTRAINT [FK_Inv_Sitios_Gen_DivisionesAdministrativasN3]
GO
ALTER TABLE [dbo].[Inv_Sitios]  WITH CHECK ADD  CONSTRAINT [FK_Inv_Sitios_Gen_DivisionesAdministrativasN4] FOREIGN KEY([divisionAdministrativaN4])
REFERENCES [dbo].[Gen_DivisionesAdministrativasN4] ([ID])
GO
ALTER TABLE [dbo].[Inv_Sitios] CHECK CONSTRAINT [FK_Inv_Sitios_Gen_DivisionesAdministrativasN4]
GO
ALTER TABLE [dbo].[Inv_Sitios]  WITH CHECK ADD  CONSTRAINT [FK_Inv_Sitios_Gen_DivisionesAdministrativasN5] FOREIGN KEY([divisionAdministrativaN5])
REFERENCES [dbo].[Gen_DivisionesAdministrativasN5] ([ID])
GO
ALTER TABLE [dbo].[Inv_Sitios] CHECK CONSTRAINT [FK_Inv_Sitios_Gen_DivisionesAdministrativasN5]
GO
ALTER TABLE [dbo].[Inv_Sitios]  WITH CHECK ADD  CONSTRAINT [FK_Inv_Sitios_Gen_Rutas] FOREIGN KEY([rutaID])
REFERENCES [dbo].[Gen_Rutas] ([ID])
GO
ALTER TABLE [dbo].[Inv_Sitios] CHECK CONSTRAINT [FK_Inv_Sitios_Gen_Rutas]
GO
ALTER TABLE [dbo].[Inv_Sitios]  WITH CHECK ADD  CONSTRAINT [FK_Inv_Sitios_Inv_Arrendadores] FOREIGN KEY([arrendadorID])
REFERENCES [dbo].[Inv_Arrendadores] ([ID])
GO
ALTER TABLE [dbo].[Inv_Sitios] CHECK CONSTRAINT [FK_Inv_Sitios_Inv_Arrendadores]
GO
ALTER TABLE [dbo].[Inv_SitiosContratosArrendamiento]  WITH CHECK ADD  CONSTRAINT [FK_Inv_SitiosContratosArrendamiento_Inv_Arrendadores] FOREIGN KEY([ArrendadorID])
REFERENCES [dbo].[Inv_Arrendadores] ([ID])
GO
ALTER TABLE [dbo].[Inv_SitiosContratosArrendamiento] CHECK CONSTRAINT [FK_Inv_SitiosContratosArrendamiento_Inv_Arrendadores]
GO
ALTER TABLE [dbo].[Inv_SitiosContratosArrendamiento]  WITH CHECK ADD  CONSTRAINT [FK_Inv_SitiosContratosArrendamiento_Inv_Sitios] FOREIGN KEY([SitioID])
REFERENCES [dbo].[Inv_Sitios] ([ID])
GO
ALTER TABLE [dbo].[Inv_SitiosContratosArrendamiento] CHECK CONSTRAINT [FK_Inv_SitiosContratosArrendamiento_Inv_Sitios]
GO
ALTER TABLE [dbo].[Inv_TiposEstructura]  WITH CHECK ADD  CONSTRAINT [FK_Inv_TiposEstructura_Inv_CategoriasSoporteEstructura] FOREIGN KEY([categoriasSoporteEstructuraID])
REFERENCES [dbo].[Inv_CategoriasSoporteEstructura] ([ID])
GO
ALTER TABLE [dbo].[Inv_TiposEstructura] CHECK CONSTRAINT [FK_Inv_TiposEstructura_Inv_CategoriasSoporteEstructura]
GO
ALTER TABLE [dbo].[Log_RegistroSimple]  WITH CHECK ADD  CONSTRAINT [FK_Log_RegistroSimple_Users] FOREIGN KEY([UsuarioRegistraID])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[Log_RegistroSimple] CHECK CONSTRAINT [FK_Log_RegistroSimple_Users]
GO
ALTER TABLE [dbo].[Log_RegistroSimple]  WITH CHECK ADD  CONSTRAINT [FK_Log_RegistroSimple_Users1] FOREIGN KEY([UsuarioModifica])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[Log_RegistroSimple] CHECK CONSTRAINT [FK_Log_RegistroSimple_Users1]
GO
ALTER TABLE [dbo].[RolePermissions]  WITH CHECK ADD  CONSTRAINT [FK_RolePermissions_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([RoleId])
GO
ALTER TABLE [dbo].[RolePermissions] CHECK CONSTRAINT [FK_RolePermissions_RoleId]
GO
ALTER TABLE [dbo].[UserPermissions]  WITH CHECK ADD  CONSTRAINT [FK_UserPermissions_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[UserPermissions] CHECK CONSTRAINT [FK_UserPermissions_UserId]
GO
ALTER TABLE [dbo].[UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([RoleId])
GO
ALTER TABLE [dbo].[UserRoles] CHECK CONSTRAINT [FK_UserRoles_RoleId]
GO
ALTER TABLE [dbo].[UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserRoles_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[UserRoles] CHECK CONSTRAINT [FK_UserRoles_UserId]
GO
USE [master]
GO
ALTER DATABASE [ErpSoftExteriores] SET  READ_WRITE 
GO
