USE [master]
GO
/****** Object:  Database [BDF]    Script Date: 08/12/2019 0:20:47 ******/
CREATE DATABASE [BDF]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BDF', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER1\MSSQL\DATA\BDF.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BDF_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER1\MSSQL\DATA\BDF_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [BDF] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BDF].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BDF] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BDF] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BDF] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BDF] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BDF] SET ARITHABORT OFF 
GO
ALTER DATABASE [BDF] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BDF] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BDF] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BDF] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BDF] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BDF] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BDF] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BDF] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BDF] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BDF] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BDF] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BDF] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BDF] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BDF] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BDF] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BDF] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BDF] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BDF] SET RECOVERY FULL 
GO
ALTER DATABASE [BDF] SET  MULTI_USER 
GO
ALTER DATABASE [BDF] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BDF] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BDF] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BDF] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BDF] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'BDF', N'ON'
GO
ALTER DATABASE [BDF] SET QUERY_STORE = OFF
GO
USE [BDF]
GO
/****** Object:  Table [dbo].[bodega]    Script Date: 08/12/2019 0:20:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bodega](
	[id_bodega] [int] IDENTITY(1,1) NOT NULL,
	[id_productos] [int] NOT NULL,
	[stock] [int] NOT NULL,
	[preciounitario] [float] NOT NULL,
	[precioventa] [float] NOT NULL,
	[descripcion] [text] NULL,
	[id_localidad] [int] NULL,
 CONSTRAINT [PK_bodega] PRIMARY KEY CLUSTERED 
(
	[id_bodega] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[categorias]    Script Date: 08/12/2019 0:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categorias](
	[id_categoria] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[descripcion] [text] NULL,
	[Estado] [int] NULL,
 CONSTRAINT [PK_categorias] PRIMARY KEY CLUSTERED 
(
	[id_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 08/12/2019 0:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clientes](
	[id_clientes] [int] IDENTITY(1,1) NOT NULL,
	[nombrecliente] [nvarchar](50) NULL,
	[apellidopaterno] [nvarchar](50) NULL,
	[apellidomaterno] [nvarchar](50) NULL,
	[direccion] [nvarchar](50) NULL,
	[telefono] [smallint] NULL,
 CONSTRAINT [PK_clientes] PRIMARY KEY CLUSTERED 
(
	[id_clientes] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_pedido]    Script Date: 08/12/2019 0:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_pedido](
	[id_pedido] [int] NOT NULL,
	[nombreproducto] [nvarchar](50) NOT NULL,
	[cantidad] [int] NOT NULL,
	[precio] [float] NOT NULL,
	[subtotal] [float] NOT NULL,
	[total] [float] NOT NULL,
	[id_producto] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detallefactura]    Script Date: 08/12/2019 0:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detallefactura](
	[id_factura] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[precio] [float] NOT NULL,
	[subtotal] [float] NOT NULL,
	[total] [float] NOT NULL,
	[descuento] [float] NOT NULL,
	[id_producto] [int] NOT NULL,
 CONSTRAINT [PK_detallefactura] PRIMARY KEY CLUSTERED 
(
	[id_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[factura]    Script Date: 08/12/2019 0:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[factura](
	[num_factura] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [timestamp] NOT NULL,
	[id_vendedor] [int] NOT NULL,
	[id_cliente] [int] NOT NULL,
	[subtotal] [float] NOT NULL,
	[total] [float] NOT NULL,
	[descuento] [float] NOT NULL,
	[iva] [float] NULL,
 CONSTRAINT [PK_factura] PRIMARY KEY CLUSTERED 
(
	[num_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IMG]    Script Date: 08/12/2019 0:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IMG](
	[Descripcion] [nchar](10) NULL,
	[img] [image] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[localidad]    Script Date: 08/12/2019 0:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[localidad](
	[id_localidad] [int] IDENTITY(1,1) NOT NULL,
	[direccion] [text] NULL,
	[ciudad] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_localidad] PRIMARY KEY CLUSTERED 
(
	[id_localidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pedidos]    Script Date: 08/12/2019 0:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pedidos](
	[id_pedido] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [timestamp] NOT NULL,
	[id_proveedor] [int] NOT NULL,
	[subtotal] [float] NOT NULL,
	[total] [float] NOT NULL,
 CONSTRAINT [PK_pedidos] PRIMARY KEY CLUSTERED 
(
	[id_pedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[productos]    Script Date: 08/12/2019 0:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[productos](
	[id_productos] [int] IDENTITY(1,1) NOT NULL,
	[nombreproducto] [nvarchar](50) NOT NULL,
	[Descripcion] [nchar](10) NULL,
	[imagen] [image] NULL,
	[estado] [nvarchar](50) NULL,
	[id_categoria] [int] NULL,
	[Id_proveedor] [int] NULL,
 CONSTRAINT [PK_productos] PRIMARY KEY CLUSTERED 
(
	[id_productos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[proveedores]    Script Date: 08/12/2019 0:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[proveedores](
	[id_proveedor] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[telefono] [int] NULL,
	[direccion] [nvarchar](50) NULL,
	[ciudad] [nvarchar](50) NULL,
 CONSTRAINT [PK_proveedores] PRIMARY KEY CLUSTERED 
(
	[id_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vendedores]    Script Date: 08/12/2019 0:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vendedores](
	[id_vendedor] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[apellidopaterno] [nvarchar](50) NOT NULL,
	[apellidomaterno] [nvarchar](50) NULL,
	[email] [text] NULL,
	[direccion] [nvarchar](50) NULL,
	[telefono] [int] NULL,
	[foto] [image] NULL,
 CONSTRAINT [PK_vendedores] PRIMARY KEY CLUSTERED 
(
	[id_vendedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[bodega]  WITH CHECK ADD  CONSTRAINT [FK_bodega_localidad] FOREIGN KEY([id_localidad])
REFERENCES [dbo].[localidad] ([id_localidad])
GO
ALTER TABLE [dbo].[bodega] CHECK CONSTRAINT [FK_bodega_localidad]
GO
ALTER TABLE [dbo].[bodega]  WITH CHECK ADD  CONSTRAINT [FK_bodega_productos] FOREIGN KEY([id_productos])
REFERENCES [dbo].[productos] ([id_productos])
GO
ALTER TABLE [dbo].[bodega] CHECK CONSTRAINT [FK_bodega_productos]
GO
ALTER TABLE [dbo].[detalle_pedido]  WITH CHECK ADD  CONSTRAINT [FK_detalle_pedido_pedidos] FOREIGN KEY([id_pedido])
REFERENCES [dbo].[pedidos] ([id_pedido])
GO
ALTER TABLE [dbo].[detalle_pedido] CHECK CONSTRAINT [FK_detalle_pedido_pedidos]
GO
ALTER TABLE [dbo].[detallefactura]  WITH CHECK ADD  CONSTRAINT [FK_detallefactura_factura] FOREIGN KEY([id_factura])
REFERENCES [dbo].[factura] ([num_factura])
GO
ALTER TABLE [dbo].[detallefactura] CHECK CONSTRAINT [FK_detallefactura_factura]
GO
ALTER TABLE [dbo].[detallefactura]  WITH CHECK ADD  CONSTRAINT [FK_detallefactura_productos] FOREIGN KEY([id_producto])
REFERENCES [dbo].[productos] ([id_productos])
GO
ALTER TABLE [dbo].[detallefactura] CHECK CONSTRAINT [FK_detallefactura_productos]
GO
ALTER TABLE [dbo].[factura]  WITH CHECK ADD  CONSTRAINT [FK_factura_clientes] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[clientes] ([id_clientes])
GO
ALTER TABLE [dbo].[factura] CHECK CONSTRAINT [FK_factura_clientes]
GO
ALTER TABLE [dbo].[factura]  WITH CHECK ADD  CONSTRAINT [FK_factura_vendedores] FOREIGN KEY([id_vendedor])
REFERENCES [dbo].[vendedores] ([id_vendedor])
GO
ALTER TABLE [dbo].[factura] CHECK CONSTRAINT [FK_factura_vendedores]
GO
ALTER TABLE [dbo].[pedidos]  WITH CHECK ADD  CONSTRAINT [FK_pedidos_proveedores] FOREIGN KEY([id_proveedor])
REFERENCES [dbo].[proveedores] ([id_proveedor])
GO
ALTER TABLE [dbo].[pedidos] CHECK CONSTRAINT [FK_pedidos_proveedores]
GO
ALTER TABLE [dbo].[productos]  WITH CHECK ADD  CONSTRAINT [FK_productos_categorias] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[categorias] ([id_categoria])
GO
ALTER TABLE [dbo].[productos] CHECK CONSTRAINT [FK_productos_categorias]
GO
ALTER TABLE [dbo].[productos]  WITH CHECK ADD  CONSTRAINT [FK_productos_proveedores] FOREIGN KEY([Id_proveedor])
REFERENCES [dbo].[proveedores] ([id_proveedor])
GO
ALTER TABLE [dbo].[productos] CHECK CONSTRAINT [FK_productos_proveedores]
GO
/****** Object:  StoredProcedure [dbo].[EditarProveedor]    Script Date: 08/12/2019 0:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EditarProveedor]
@nombre nvarchar (100),
@email nvarchar (100),
@telefono int,
@direccion nvarchar(100),
@ciudad nvarchar(100),
@id_proveedor int
as
update proveedores set nombre=@nombre, email=@email, telefono=@telefono, direccion=@direccion, ciudad=@ciudad where id_proveedor=@id_proveedor
GO
/****** Object:  StoredProcedure [dbo].[EliminarProveedor]    Script Date: 08/12/2019 0:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[EliminarProveedor]
@id_proveedor int
as
delete from proveedores where id_proveedor=@id_proveedor
GO
/****** Object:  StoredProcedure [dbo].[RegistrarProveedor]    Script Date: 08/12/2019 0:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[RegistrarProveedor]
@nombre nvarchar (100),
@email nvarchar (100),
@telefono int,
@direccion nvarchar(100),
@ciudad nvarchar(100)
as
insert into proveedores values (@nombre,@email,@telefono,@direccion,@ciudad)
GO
USE [master]
GO
ALTER DATABASE [BDF] SET  READ_WRITE 
GO
