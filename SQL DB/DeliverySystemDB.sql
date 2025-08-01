USE [master]
GO
/****** Object:  Database [DeliverySystemDB]    Script Date: 28/07/2025 8:51:39 p. m. ******/
CREATE DATABASE [DeliverySystemDB]
GO
ALTER DATABASE [DeliverySystemDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DeliverySystemDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DeliverySystemDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DeliverySystemDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DeliverySystemDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DeliverySystemDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DeliverySystemDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [DeliverySystemDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DeliverySystemDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DeliverySystemDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DeliverySystemDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DeliverySystemDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DeliverySystemDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DeliverySystemDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DeliverySystemDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DeliverySystemDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DeliverySystemDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DeliverySystemDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DeliverySystemDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DeliverySystemDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DeliverySystemDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DeliverySystemDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DeliverySystemDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DeliverySystemDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DeliverySystemDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DeliverySystemDB] SET  MULTI_USER 
GO
ALTER DATABASE [DeliverySystemDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DeliverySystemDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DeliverySystemDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DeliverySystemDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DeliverySystemDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DeliverySystemDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DeliverySystemDB] SET QUERY_STORE = OFF
GO
USE [DeliverySystemDB]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 28/07/2025 8:51:39 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clientes](
	[codigoCli] [int] NOT NULL,
	[tipoIdentificacionCli] [nvarchar](50) NOT NULL,
	[identificacionCli] [nvarchar](50) NOT NULL,
	[nombreCli] [nvarchar](50) NOT NULL,
	[direccionCli] [nvarchar](50) NOT NULL,
	[codEstado] [int] NOT NULL,
 CONSTRAINT [PK_clientes_codigoCli] PRIMARY KEY CLUSTERED 
(
	[codigoCli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[envios]    Script Date: 28/07/2025 8:51:39 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[envios](
	[codigoFactura] [nvarchar](50) NOT NULL,
	[nombreRecibe] [nvarchar](50) NOT NULL,
	[telRecibe] [nvarchar](50) NOT NULL,
	[direccionEnvio] [nvarchar](50) NOT NULL,
	[fechaEnvio] [datetime] NOT NULL,
	[estEnvio] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_envios_codigoFactura] PRIMARY KEY CLUSTERED 
(
	[codigoFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[estado]    Script Date: 28/07/2025 8:51:39 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estado](
	[codEstado] [int] NOT NULL,
	[nomEstado] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_estado_codEstado] PRIMARY KEY CLUSTERED 
(
	[codEstado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[facturas]    Script Date: 28/07/2025 8:51:39 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[facturas](
	[codigoFactura] [nvarchar](50) NOT NULL,
	[codigoCli] [int] NOT NULL,
	[codigoProducto] [int] NOT NULL,
	[cantidadVenta] [int] NOT NULL,
	[fecFactura] [datetime] NOT NULL,
 CONSTRAINT [PK_facturas_codigoFactura] PRIMARY KEY CLUSTERED 
(
	[codigoFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[productos]    Script Date: 28/07/2025 8:51:39 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[productos](
	[codigoProducto] [int] NOT NULL,
	[nombreProducto] [nvarchar](50) NOT NULL,
	[cantidadStorage] [int] NOT NULL,
 CONSTRAINT [PK_productos_codigoProducto] PRIMARY KEY CLUSTERED 
(
	[codigoProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[proveedores]    Script Date: 28/07/2025 8:51:39 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[proveedores](
	[codigoProve] [int] NOT NULL,
	[tipoIdentificacionProve] [nvarchar](50) NOT NULL,
	[identificacionProve] [nvarchar](50) NOT NULL,
	[nombreProve] [nvarchar](50) NOT NULL,
	[direccionProve] [nvarchar](50) NOT NULL,
	[codEstado] [int] NOT NULL,
 CONSTRAINT [PK_proveedores_codigoProve] PRIMARY KEY CLUSTERED 
(
	[codigoProve] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProveedorProducto]    Script Date: 28/07/2025 8:51:39 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProveedorProducto](
	[codigoProve] [int] NOT NULL,
	[codigoProducto] [int] NOT NULL,
	[Calidad] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_proveeXproducto_codigoProve_codigoProducto] PRIMARY KEY CLUSTERED 
(
	[codigoProve] ASC,
	[codigoProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[roles]    Script Date: 28/07/2025 8:51:39 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roles](
	[codRol] [int] NOT NULL,
	[nombreRol] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_roles_codRol] PRIMARY KEY CLUSTERED 
(
	[codRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuarioRol]    Script Date: 28/07/2025 8:51:39 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuarioRol](
	[codUsuario] [int] NOT NULL,
	[codRol] [int] NOT NULL,
 CONSTRAINT [PK_usuXrol_codEstado_codRol] PRIMARY KEY CLUSTERED 
(
	[codUsuario] ASC,
	[codRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 28/07/2025 8:51:39 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[codUsuario] [int] NOT NULL,
	[nomUsuario] [nvarchar](50) NOT NULL,
	[apeUsuario] [nvarchar](50) NOT NULL,
	[contraseña] [nvarchar](50) NOT NULL,
	[codEstado] [int] NOT NULL,
	[fecInicio] [datetime] NOT NULL,
 CONSTRAINT [PK_usuarios_codUsuario] PRIMARY KEY CLUSTERED 
(
	[codUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[clientes] ([codigoCli], [tipoIdentificacionCli], [identificacionCli], [nombreCli], [direccionCli], [codEstado]) VALUES (1, N'Nit', N'900800700-1', N'ClienteUno', N'carrera 94 # 67', 1)
INSERT [dbo].[clientes] ([codigoCli], [tipoIdentificacionCli], [identificacionCli], [nombreCli], [direccionCli], [codEstado]) VALUES (2, N'Nit', N'900654852-1', N'ClienteDos', N'transversal 67 # 67', 1)
INSERT [dbo].[clientes] ([codigoCli], [tipoIdentificacionCli], [identificacionCli], [nombreCli], [direccionCli], [codEstado]) VALUES (3, N'Nit', N'900800700-1', N'ClientePosibleUno', N'carrera 94 # 67', 3)
GO
INSERT [dbo].[envios] ([codigoFactura], [nombreRecibe], [telRecibe], [direccionEnvio], [fechaEnvio], [estEnvio]) VALUES (N'FAC001', N'jessy tatiana peralta', N'31389632547', N'carrera 31 #3-3', CAST(N'2025-07-19T00:00:00.000' AS DateTime), N'Enviado')
INSERT [dbo].[envios] ([codigoFactura], [nombreRecibe], [telRecibe], [direccionEnvio], [fechaEnvio], [estEnvio]) VALUES (N'FAC002', N'Maria Jimenez', N'31789148757', N'Transversal 31 #3-3', CAST(N'2025-07-19T00:00:00.000' AS DateTime), N'Entregado')
INSERT [dbo].[envios] ([codigoFactura], [nombreRecibe], [telRecibe], [direccionEnvio], [fechaEnvio], [estEnvio]) VALUES (N'FAC003', N'Juan Perez', N'31845698547', N'calle 31 #3-3', CAST(N'2025-07-19T00:00:00.000' AS DateTime), N'Devolucion')
INSERT [dbo].[envios] ([codigoFactura], [nombreRecibe], [telRecibe], [direccionEnvio], [fechaEnvio], [estEnvio]) VALUES (N'FAC004', N'Grabriela Sanchez', N'318889632547', N'Avenida 31 #3-3', CAST(N'2025-07-19T00:00:00.000' AS DateTime), N'Entregado')
GO
INSERT [dbo].[estado] ([codEstado], [nomEstado]) VALUES (1, N'Activo')
INSERT [dbo].[estado] ([codEstado], [nomEstado]) VALUES (2, N'Inactivo')
INSERT [dbo].[estado] ([codEstado], [nomEstado]) VALUES (3, N'PosibleCliente')
GO
INSERT [dbo].[facturas] ([codigoFactura], [codigoCli], [codigoProducto], [cantidadVenta], [fecFactura]) VALUES (N'FAC001', 1, 1, 20, CAST(N'2025-07-18T00:00:00.000' AS DateTime))
INSERT [dbo].[facturas] ([codigoFactura], [codigoCli], [codigoProducto], [cantidadVenta], [fecFactura]) VALUES (N'FAC002', 1, 2, 10, CAST(N'2025-07-18T00:00:00.000' AS DateTime))
INSERT [dbo].[facturas] ([codigoFactura], [codigoCli], [codigoProducto], [cantidadVenta], [fecFactura]) VALUES (N'FAC003', 1, 1, 5, CAST(N'2025-07-18T00:00:00.000' AS DateTime))
INSERT [dbo].[facturas] ([codigoFactura], [codigoCli], [codigoProducto], [cantidadVenta], [fecFactura]) VALUES (N'FAC004', 1, 2, 5, CAST(N'2025-07-18T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[productos] ([codigoProducto], [nombreProducto], [cantidadStorage]) VALUES (1, N'Lapiz', 50)
INSERT [dbo].[productos] ([codigoProducto], [nombreProducto], [cantidadStorage]) VALUES (2, N'Tajalapiz', 50)
INSERT [dbo].[productos] ([codigoProducto], [nombreProducto], [cantidadStorage]) VALUES (3, N'Borrador', 50)
GO
INSERT [dbo].[proveedores] ([codigoProve], [tipoIdentificacionProve], [identificacionProve], [nombreProve], [direccionProve], [codEstado]) VALUES (1, N'Nit', N'900800700-1', N'ProveedorUno', N'carrera 94 # 67', 1)
INSERT [dbo].[proveedores] ([codigoProve], [tipoIdentificacionProve], [identificacionProve], [nombreProve], [direccionProve], [codEstado]) VALUES (2, N'Nit', N'900654852-1', N'ProveedorDos', N'calle 85 -98-2 ', 1)
GO
INSERT [dbo].[ProveedorProducto] ([codigoProve], [codigoProducto], [Calidad]) VALUES (1, 1, N'buena')
INSERT [dbo].[ProveedorProducto] ([codigoProve], [codigoProducto], [Calidad]) VALUES (1, 2, N'regular')
INSERT [dbo].[ProveedorProducto] ([codigoProve], [codigoProducto], [Calidad]) VALUES (1, 3, N'mala')
INSERT [dbo].[ProveedorProducto] ([codigoProve], [codigoProducto], [Calidad]) VALUES (2, 1, N'buena')
INSERT [dbo].[ProveedorProducto] ([codigoProve], [codigoProducto], [Calidad]) VALUES (2, 2, N'regular')
INSERT [dbo].[ProveedorProducto] ([codigoProve], [codigoProducto], [Calidad]) VALUES (2, 3, N'mala')
GO
INSERT [dbo].[roles] ([codRol], [nombreRol]) VALUES (1, N'Administradores')
INSERT [dbo].[roles] ([codRol], [nombreRol]) VALUES (2, N'Ventas')
INSERT [dbo].[roles] ([codRol], [nombreRol]) VALUES (3, N'Proveedores')
INSERT [dbo].[roles] ([codRol], [nombreRol]) VALUES (4, N'Operacion')
GO
INSERT [dbo].[UsuarioRol] ([codUsuario], [codRol]) VALUES (1, 1)
GO
INSERT [dbo].[usuarios] ([codUsuario], [nomUsuario], [apeUsuario], [contraseña], [codEstado], [fecInicio]) VALUES (1, N'UsuGestionHumana', N'NoAplica', N'P@ssw0rd', 1, CAST(N'2024-07-18T00:00:00.000' AS DateTime))
GO
ALTER TABLE [dbo].[clientes]  WITH CHECK ADD  CONSTRAINT [FK_clientes_estado] FOREIGN KEY([codEstado])
REFERENCES [dbo].[estado] ([codEstado])
GO
ALTER TABLE [dbo].[clientes] CHECK CONSTRAINT [FK_clientes_estado]
GO
ALTER TABLE [dbo].[envios]  WITH CHECK ADD  CONSTRAINT [FK_envios_facturas] FOREIGN KEY([codigoFactura])
REFERENCES [dbo].[facturas] ([codigoFactura])
GO
ALTER TABLE [dbo].[envios] CHECK CONSTRAINT [FK_envios_facturas]
GO
ALTER TABLE [dbo].[facturas]  WITH CHECK ADD  CONSTRAINT [FK_facturas_clientes] FOREIGN KEY([codigoCli])
REFERENCES [dbo].[clientes] ([codigoCli])
GO
ALTER TABLE [dbo].[facturas] CHECK CONSTRAINT [FK_facturas_clientes]
GO
ALTER TABLE [dbo].[proveedores]  WITH CHECK ADD  CONSTRAINT [FK_proveedores_estado] FOREIGN KEY([codEstado])
REFERENCES [dbo].[estado] ([codEstado])
GO
ALTER TABLE [dbo].[proveedores] CHECK CONSTRAINT [FK_proveedores_estado]
GO
ALTER TABLE [dbo].[ProveedorProducto]  WITH CHECK ADD  CONSTRAINT [FK_proveeXproducto_productos] FOREIGN KEY([codigoProducto])
REFERENCES [dbo].[productos] ([codigoProducto])
GO
ALTER TABLE [dbo].[ProveedorProducto] CHECK CONSTRAINT [FK_proveeXproducto_productos]
GO
ALTER TABLE [dbo].[ProveedorProducto]  WITH CHECK ADD  CONSTRAINT [FK_proveeXproducto_proveedores] FOREIGN KEY([codigoProve])
REFERENCES [dbo].[proveedores] ([codigoProve])
GO
ALTER TABLE [dbo].[ProveedorProducto] CHECK CONSTRAINT [FK_proveeXproducto_proveedores]
GO
ALTER TABLE [dbo].[UsuarioRol]  WITH CHECK ADD  CONSTRAINT [FK_usuXrol_roles] FOREIGN KEY([codRol])
REFERENCES [dbo].[roles] ([codRol])
GO
ALTER TABLE [dbo].[UsuarioRol] CHECK CONSTRAINT [FK_usuXrol_roles]
GO
ALTER TABLE [dbo].[UsuarioRol]  WITH CHECK ADD  CONSTRAINT [FK_usuXrol_usuarios] FOREIGN KEY([codUsuario])
REFERENCES [dbo].[usuarios] ([codUsuario])
GO
ALTER TABLE [dbo].[UsuarioRol] CHECK CONSTRAINT [FK_usuXrol_usuarios]
GO
ALTER TABLE [dbo].[usuarios]  WITH CHECK ADD  CONSTRAINT [FK_usuarios_estado] FOREIGN KEY([codEstado])
REFERENCES [dbo].[estado] ([codEstado])
GO
ALTER TABLE [dbo].[usuarios] CHECK CONSTRAINT [FK_usuarios_estado]
GO
USE [master]
GO
ALTER DATABASE [DeliverySystemDB] SET  READ_WRITE 
GO
