USE [master]
GO
/****** Object:  Database [SistemaEducacion]    Script Date: 12/9/2022 20:17:24 ******/
CREATE DATABASE [SistemaEducacion]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SistemaEducacion', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SistemaEducacion.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SistemaEducacion_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SistemaEducacion_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SistemaEducacion] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SistemaEducacion].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SistemaEducacion] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SistemaEducacion] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SistemaEducacion] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SistemaEducacion] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SistemaEducacion] SET ARITHABORT OFF 
GO
ALTER DATABASE [SistemaEducacion] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [SistemaEducacion] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SistemaEducacion] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SistemaEducacion] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SistemaEducacion] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SistemaEducacion] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SistemaEducacion] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SistemaEducacion] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SistemaEducacion] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SistemaEducacion] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SistemaEducacion] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SistemaEducacion] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SistemaEducacion] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SistemaEducacion] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SistemaEducacion] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SistemaEducacion] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SistemaEducacion] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SistemaEducacion] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SistemaEducacion] SET  MULTI_USER 
GO
ALTER DATABASE [SistemaEducacion] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SistemaEducacion] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SistemaEducacion] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SistemaEducacion] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SistemaEducacion] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SistemaEducacion] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SistemaEducacion] SET QUERY_STORE = OFF
GO
USE [SistemaEducacion]
GO
/****** Object:  Table [dbo].[alumno-clase]    Script Date: 12/9/2022 20:17:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[alumno-clase](
	[id] [int] NOT NULL,
	[idalumno] [int] NULL,
	[idperiodo] [int] NULL,
	[idclase] [int] NULL,
 CONSTRAINT [PK_alumno-clase] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[alumnos]    Script Date: 12/9/2022 20:17:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[alumnos](
	[id] [int] NOT NULL,
	[nombre] [nchar](10) NULL,
	[apellido] [nchar](10) NULL,
	[dni] [nchar](10) NULL,
	[fecha-nacimiento] [datetime] NULL,
	[domicilio] [nvarchar](50) NOT NULL,
	[idsexo] [int] NULL,
 CONSTRAINT [PK_alumnos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[carreras]    Script Date: 12/9/2022 20:17:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[carreras](
	[id] [int] NOT NULL,
	[nombre] [nvarchar](50) NULL,
 CONSTRAINT [PK_carreras] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clase]    Script Date: 12/9/2022 20:17:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clase](
	[id] [int] NOT NULL,
	[idmateria] [int] NULL,
	[idcarrera] [int] NULL,
	[idprofesor] [int] NULL,
	[idturno] [int] NULL,
 CONSTRAINT [PK_clase] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[materias]    Script Date: 12/9/2022 20:17:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[materias](
	[id] [int] NOT NULL,
	[nombre] [nvarchar](50) NULL,
 CONSTRAINT [PK_materias] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Periodo]    Script Date: 12/9/2022 20:17:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Periodo](
	[id] [int] NOT NULL,
	[fecha-inicio] [datetime] NULL,
	[fecha-fin] [datetime] NULL,
	[semestre] [int] NULL,
 CONSTRAINT [PK_Periodo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[profesores]    Script Date: 12/9/2022 20:17:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[profesores](
	[id] [int] NOT NULL,
	[nombre] [nchar](10) NULL,
	[apellido] [nchar](10) NULL,
	[dni] [nchar](10) NULL,
	[fecha-nacimiento] [datetime] NULL,
	[idsexo] [int] NULL,
 CONSTRAINT [PK_profesores] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sexo]    Script Date: 12/9/2022 20:17:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sexo](
	[id] [int] NOT NULL,
	[sexo] [nchar](10) NULL,
 CONSTRAINT [PK_sexo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[turnos]    Script Date: 12/9/2022 20:17:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[turnos](
	[id] [int] NOT NULL,
	[nombre] [nchar](10) NULL,
 CONSTRAINT [PK_turnos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[alumno-clase] ([id], [idalumno], [idperiodo], [idclase]) VALUES (1, 1, 1, 1)
GO
INSERT [dbo].[alumnos] ([id], [nombre], [apellido], [dni], [fecha-nacimiento], [domicilio], [idsexo]) VALUES (1, N'sabrina   ', N'rodriguez ', N'35526656  ', CAST(N'1990-09-20T00:00:00.000' AS DateTime), N'La tablada 2036', 1)
GO
INSERT [dbo].[carreras] ([id], [nombre]) VALUES (1, N'abogacia  ')
GO
INSERT [dbo].[carreras] ([id], [nombre]) VALUES (2, N'enfermeria')
GO
INSERT [dbo].[carreras] ([id], [nombre]) VALUES (3, N'desarrollo')
GO
INSERT [dbo].[carreras] ([id], [nombre]) VALUES (4, N'periodismo')
GO
INSERT [dbo].[carreras] ([id], [nombre]) VALUES (5, N'contabilidad')
GO
INSERT [dbo].[carreras] ([id], [nombre]) VALUES (6, N'recursos humanos')
GO
INSERT [dbo].[carreras] ([id], [nombre]) VALUES (7, N'relaciones publicas')
GO
INSERT [dbo].[clase] ([id], [idmateria], [idcarrera], [idprofesor], [idturno]) VALUES (1, 4, 3, 1, 1)
GO
INSERT [dbo].[materias] ([id], [nombre]) VALUES (1, N'matematicas')
GO
INSERT [dbo].[materias] ([id], [nombre]) VALUES (2, N'investigacion')
GO
INSERT [dbo].[materias] ([id], [nombre]) VALUES (3, N'programacion')
GO
INSERT [dbo].[materias] ([id], [nombre]) VALUES (4, N'base de datos')
GO
INSERT [dbo].[materias] ([id], [nombre]) VALUES (5, N'comunicacion')
GO
INSERT [dbo].[materias] ([id], [nombre]) VALUES (6, N'introduccion a los estados contables')
GO
INSERT [dbo].[materias] ([id], [nombre]) VALUES (7, N'derecho penal')
GO
INSERT [dbo].[materias] ([id], [nombre]) VALUES (8, N'derecho procesal')
GO
INSERT [dbo].[materias] ([id], [nombre]) VALUES (9, N'lenguaje visual')
GO
INSERT [dbo].[materias] ([id], [nombre]) VALUES (10, N'seleccion')
GO
INSERT [dbo].[materias] ([id], [nombre]) VALUES (11, N'administracion y organizaciones')
GO
INSERT [dbo].[materias] ([id], [nombre]) VALUES (12, N'negociacion y liderazgo')
GO
INSERT [dbo].[materias] ([id], [nombre]) VALUES (13, N'anatomia ')
GO
INSERT [dbo].[materias] ([id], [nombre]) VALUES (14, N'farmacologia')
GO
INSERT [dbo].[Periodo] ([id], [fecha-inicio], [fecha-fin], [semestre]) VALUES (1, CAST(N'2022-03-08T00:00:00.000' AS DateTime), CAST(N'2022-07-31T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[Periodo] ([id], [fecha-inicio], [fecha-fin], [semestre]) VALUES (2, CAST(N'2022-08-01T00:00:00.000' AS DateTime), CAST(N'2022-11-24T00:00:00.000' AS DateTime), 2)
GO
INSERT [dbo].[profesores] ([id], [nombre], [apellido], [dni], [fecha-nacimiento], [idsexo]) VALUES (1, N'Paula     ', N'Gomez     ', N'37987535  ', CAST(N'1991-03-26T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[sexo] ([id], [sexo]) VALUES (1, N'Femenino  ')
GO
INSERT [dbo].[sexo] ([id], [sexo]) VALUES (2, N'Masculino ')
GO
INSERT [dbo].[sexo] ([id], [sexo]) VALUES (3, N'Otros     ')
GO
INSERT [dbo].[turnos] ([id], [nombre]) VALUES (1, N'mañana    ')
GO
INSERT [dbo].[turnos] ([id], [nombre]) VALUES (2, N'tarde     ')
GO
INSERT [dbo].[turnos] ([id], [nombre]) VALUES (3, N'noche     ')
GO
ALTER TABLE [dbo].[alumno-clase]  WITH CHECK ADD  CONSTRAINT [FK_alumno-clase_alumnos] FOREIGN KEY([idalumno])
REFERENCES [dbo].[alumnos] ([id])
GO
ALTER TABLE [dbo].[alumno-clase] CHECK CONSTRAINT [FK_alumno-clase_alumnos]
GO
ALTER TABLE [dbo].[alumno-clase]  WITH CHECK ADD  CONSTRAINT [FK_alumno-clase_clase] FOREIGN KEY([idclase])
REFERENCES [dbo].[clase] ([id])
GO
ALTER TABLE [dbo].[alumno-clase] CHECK CONSTRAINT [FK_alumno-clase_clase]
GO
ALTER TABLE [dbo].[alumno-clase]  WITH CHECK ADD  CONSTRAINT [FK_alumno-clase_Periodo] FOREIGN KEY([idperiodo])
REFERENCES [dbo].[Periodo] ([id])
GO
ALTER TABLE [dbo].[alumno-clase] CHECK CONSTRAINT [FK_alumno-clase_Periodo]
GO
ALTER TABLE [dbo].[alumnos]  WITH CHECK ADD  CONSTRAINT [FK_alumnos_sexo] FOREIGN KEY([idsexo])
REFERENCES [dbo].[sexo] ([id])
GO
ALTER TABLE [dbo].[alumnos] CHECK CONSTRAINT [FK_alumnos_sexo]
GO
ALTER TABLE [dbo].[clase]  WITH CHECK ADD  CONSTRAINT [FK_clase_carreras] FOREIGN KEY([idcarrera])
REFERENCES [dbo].[carreras] ([id])
GO
ALTER TABLE [dbo].[clase] CHECK CONSTRAINT [FK_clase_carreras]
GO
ALTER TABLE [dbo].[clase]  WITH CHECK ADD  CONSTRAINT [FK_clase_materias] FOREIGN KEY([idmateria])
REFERENCES [dbo].[materias] ([id])
GO
ALTER TABLE [dbo].[clase] CHECK CONSTRAINT [FK_clase_materias]
GO
ALTER TABLE [dbo].[clase]  WITH CHECK ADD  CONSTRAINT [FK_clase_profesores] FOREIGN KEY([idprofesor])
REFERENCES [dbo].[profesores] ([id])
GO
ALTER TABLE [dbo].[clase] CHECK CONSTRAINT [FK_clase_profesores]
GO
ALTER TABLE [dbo].[clase]  WITH CHECK ADD  CONSTRAINT [FK_clase_turnos] FOREIGN KEY([idturno])
REFERENCES [dbo].[turnos] ([id])
GO
ALTER TABLE [dbo].[clase] CHECK CONSTRAINT [FK_clase_turnos]
GO
ALTER TABLE [dbo].[profesores]  WITH CHECK ADD  CONSTRAINT [FK_profesores_sexo] FOREIGN KEY([idsexo])
REFERENCES [dbo].[sexo] ([id])
GO
ALTER TABLE [dbo].[profesores] CHECK CONSTRAINT [FK_profesores_sexo]
GO
USE [master]
GO
ALTER DATABASE [SistemaEducacion] SET  READ_WRITE 
GO
