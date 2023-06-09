USE [Tenyo_Ferreteria]
GO
/****** Object:  Table [dbo].[TENYO_CARACTERISTICA]    Script Date: 07/07/2022 12:47:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TENYO_CARACTERISTICA](
	[tenyo_clave_caracteristica] [varchar](20) NOT NULL,
	[tenyo_nombre_caracteristica] [varchar](150) NOT NULL,
	[tenyo_status_caracteristica] [bit] NOT NULL,
 CONSTRAINT [PK_TENYO_CARACTERISTICA] PRIMARY KEY CLUSTERED 
(
	[tenyo_clave_caracteristica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TENYO_CATEGORIA]    Script Date: 07/07/2022 12:47:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TENYO_CATEGORIA](
	[tenyo_id_categoria] [int] IDENTITY(1,1) NOT NULL,
	[tenyo_descripcion_categoria] [varchar](200) NOT NULL,
	[tenyo_status_categoria] [bit] NOT NULL,
 CONSTRAINT [PK_TENYO_CATEGORIA] PRIMARY KEY CLUSTERED 
(
	[tenyo_id_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TENYO_COMPRA]    Script Date: 07/07/2022 12:47:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TENYO_COMPRA](
	[tenyo_id_compra] [int] IDENTITY(1,1) NOT NULL,
	[tenyo_folio_ticket_compra] [varchar](20) NOT NULL,
	[tenyo_clave_proveedor] [varchar](15) NOT NULL,
	[tenyo_clave_empleado] [varchar](30) NOT NULL,
	[tenyo_fecha_hora_compra] [datetime] NOT NULL,
	[tenyo_total_compra] [float] NOT NULL,
 CONSTRAINT [PK_TENYO_COMPRA] PRIMARY KEY CLUSTERED 
(
	[tenyo_id_compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TENYO_DEPARTAMENTO]    Script Date: 07/07/2022 12:47:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TENYO_DEPARTAMENTO](
	[tenyo_id_departamento] [tinyint] IDENTITY(1,1) NOT NULL,
	[tenyo_descripcion_departamento] [varchar](100) NOT NULL,
	[tenyo_status_departamento] [bit] NOT NULL,
 CONSTRAINT [PK_TENYO_DEPARTAMENTO] PRIMARY KEY CLUSTERED 
(
	[tenyo_id_departamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TENYO_DESCUENTO]    Script Date: 07/07/2022 12:47:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TENYO_DESCUENTO](
	[tenyo_id_descuento] [tinyint] IDENTITY(1,1) NOT NULL,
	[tenyo_porcentaje_descuento] [float] NOT NULL,
	[tenyo_status_descuento] [bit] NOT NULL,
 CONSTRAINT [PK_TENYO_DESCUENTO] PRIMARY KEY CLUSTERED 
(
	[tenyo_id_descuento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TENYO_DETALLE_COMPRA]    Script Date: 07/07/2022 12:47:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TENYO_DETALLE_COMPRA](
	[tenyo_id_detalle_compra] [int] IDENTITY(1,1) NOT NULL,
	[tenyo_id_compra] [int] NOT NULL,
	[tenyo_clave_producto] [varchar](30) NOT NULL,
	[tenyo_cantidad_producto_compra] [float] NOT NULL,
	[tenyo_precio_unidad_compra] [float] NOT NULL,
	[tenyo_total_compra] [float] NOT NULL,
 CONSTRAINT [PK_TENYO_DETALLE_COMPRA] PRIMARY KEY CLUSTERED 
(
	[tenyo_id_detalle_compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TENYO_DETALLE_VENTA]    Script Date: 07/07/2022 12:47:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TENYO_DETALLE_VENTA](
	[tenyo_id_detalle_venta] [int] IDENTITY(1,1) NOT NULL,
	[tenyo_folio_venta] [varchar](15) NOT NULL,
	[tenyo_clave_producto] [varchar](30) NOT NULL,
	[tenyo_cantidad_producto_venta] [float] NOT NULL,
	[tenyo_precio_producto] [float] NOT NULL,
	[tenyo_id_descuento] [tinyint] NOT NULL,
	[tenyo_total_cantidad_precio] [float] NOT NULL,
 CONSTRAINT [PK_TENYO_DETALLE_VENTA] PRIMARY KEY CLUSTERED 
(
	[tenyo_id_detalle_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TENYO_DEVOLUCION]    Script Date: 07/07/2022 12:47:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TENYO_DEVOLUCION](
	[tenyo_id_devolucion] [int] IDENTITY(1,1) NOT NULL,
	[tenyo_folio_venta] [varchar](15) NOT NULL,
	[tenyo_clave_producto] [varchar](30) NOT NULL,
	[tenyo_cantidad_devolucion] [float] NOT NULL,
	[tenyo_fecha_hora_devolucion] [float] NOT NULL,
	[tenyo_motivo_descripcion_devolucion] [varchar](250) NOT NULL,
 CONSTRAINT [PK_TENYO_DEVOLUCION] PRIMARY KEY CLUSTERED 
(
	[tenyo_id_devolucion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TENYO_EMPLEADO]    Script Date: 07/07/2022 12:47:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TENYO_EMPLEADO](
	[tenyo_clave_empleado] [varchar](30) NOT NULL,
	[tenyo_nombre_empleado] [varchar](200) NOT NULL,
	[tenyo_ape1_empleado] [varchar](200) NOT NULL,
	[tenyo_ape2_empleado] [varchar](200) NULL,
	[tenyo_telefono_empleado] [varchar](12) NOT NULL,
	[tenyo_fecha_contratado] [date] NOT NULL,
	[tenyo_status_empleado] [bit] NOT NULL,
 CONSTRAINT [PK_TENYO_EMPLEADO] PRIMARY KEY CLUSTERED 
(
	[tenyo_clave_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TENYO_ESTANTE]    Script Date: 07/07/2022 12:47:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TENYO_ESTANTE](
	[tenyo_id_estante] [smallint] IDENTITY(1,1) NOT NULL,
	[tenyo_numero_estante] [varchar](20) NOT NULL,
	[tenyo_status_estante] [bit] NOT NULL,
 CONSTRAINT [PK_TENYO_ESTANTE] PRIMARY KEY CLUSTERED 
(
	[tenyo_id_estante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TENYO_FICHA_TECNICA]    Script Date: 07/07/2022 12:47:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TENYO_FICHA_TECNICA](
	[tenyo_clave_producto] [varchar](30) NOT NULL,
	[tenyo_clave_caracteristica] [varchar](20) NOT NULL,
	[tenyo_medida_valor_producto] [varchar](30) NOT NULL,
	[tenyo_id_medida] [smallint] NOT NULL,
	[tenyo_observacion] [varchar](150) NULL,
	[tenyo_status] [bit] NOT NULL,
 CONSTRAINT [PK_TENYO_FICHA_TECNICA] PRIMARY KEY CLUSTERED 
(
	[tenyo_clave_producto] ASC,
	[tenyo_clave_caracteristica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TENYO_MARCA]    Script Date: 07/07/2022 12:47:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TENYO_MARCA](
	[tenyo_id_marca] [tinyint] IDENTITY(1,1) NOT NULL,
	[tenyo_nombre_marca] [varchar](70) NOT NULL,
	[tenyo_status_marca] [bit] NOT NULL,
 CONSTRAINT [PK_TENYO_MARCA] PRIMARY KEY CLUSTERED 
(
	[tenyo_id_marca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TENYO_MATERIAL]    Script Date: 07/07/2022 12:47:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TENYO_MATERIAL](
	[tenyo_id_material] [smallint] IDENTITY(1,1) NOT NULL,
	[tenyo_descripcion_material] [varchar](150) NOT NULL,
	[tenyo_status_material] [bit] NOT NULL,
 CONSTRAINT [PK_TENYO_MATERIAL] PRIMARY KEY CLUSTERED 
(
	[tenyo_id_material] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TENYO_MEDIDA]    Script Date: 07/07/2022 12:47:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TENYO_MEDIDA](
	[tenyo_id_medida] [smallint] IDENTITY(1,1) NOT NULL,
	[tenyo_nombre_medida] [varchar](50) NOT NULL,
	[tenyo_abreviatura_medida] [varchar](50) NOT NULL,
	[tenyo_status_medida] [bit] NOT NULL,
 CONSTRAINT [PK_TENYO_MEDIDA] PRIMARY KEY CLUSTERED 
(
	[tenyo_id_medida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TENYO_PASILLO]    Script Date: 07/07/2022 12:47:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TENYO_PASILLO](
	[tenyo_id_pasillo] [smallint] IDENTITY(1,1) NOT NULL,
	[tenyo_numero_pasillo] [varchar](20) NOT NULL,
 CONSTRAINT [PK_TENYO_PASILLO] PRIMARY KEY CLUSTERED 
(
	[tenyo_id_pasillo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TENYO_PRODUCTO]    Script Date: 07/07/2022 12:47:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TENYO_PRODUCTO](
	[tenyo_clave_producto] [varchar](30) NOT NULL,
	[tenyo_codigo_producto] [varchar](10) NOT NULL,
	[tenyo_id_departamento] [tinyint] NOT NULL,
	[tenyo_id_marca] [tinyint] NOT NULL,
	[tenyo_id_categoria] [int] NOT NULL,
	[tenyo_id_pasillo] [smallint] NOT NULL,
	[tenyo_id_estante] [smallint] NOT NULL,
	[tenyo_id_material] [smallint] NOT NULL,
	[tenyo_nivel_competencia] [tinyint] NOT NULL,
	[tenyo_cantidad_producto] [smallint] NOT NULL,
	[tenyo_existencias_producto] [smallint] NOT NULL,
	[tenyo_stock_min] [tinyint] NOT NULL,
	[tenyo_stock_max] [smallint] NOT NULL,
	[tenyo_precio_actual_producto_mayoreo] [float] NOT NULL,
	[tenyo_precio_actual_publico] [float] NOT NULL,
	[tenyo_imagen_producto] [image] NULL,
	[tenyo_id_descuento] [tinyint] NOT NULL,
	[tenyo_status] [bit] NOT NULL,
 CONSTRAINT [PK_TENYO_PRODUCTO] PRIMARY KEY CLUSTERED 
(
	[tenyo_clave_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TENYO_PROVEEDOR]    Script Date: 07/07/2022 12:47:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TENYO_PROVEEDOR](
	[tenyo_clave_proveedor] [varchar](15) NOT NULL,
	[tenyo_razon_social] [varchar](200) NOT NULL,
	[tenyo_direccion_proveedor] [varchar](200) NOT NULL,
	[tenyo_telefono_proveedor] [varchar](12) NOT NULL,
	[tenyo_contacto_proveedor] [varchar](50) NOT NULL,
	[tenyo_status_proveedor] [bit] NOT NULL,
 CONSTRAINT [PK_TENYO_PROVEEDOR] PRIMARY KEY CLUSTERED 
(
	[tenyo_clave_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TENYO_VENTA]    Script Date: 07/07/2022 12:47:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TENYO_VENTA](
	[tenyo_folio_venta] [varchar](15) NOT NULL,
	[tenyo_clave_empleado] [varchar](30) NOT NULL,
	[tenyo_fecha_hora_venta] [datetime] NOT NULL,
	[tenyo_descuento_total_venta] [float] NOT NULL,
	[tenyo_precio_total_venta] [float] NOT NULL,
	[tenyo_status_venta] [bit] NOT NULL,
 CONSTRAINT [PK_TENYO_VENTA] PRIMARY KEY CLUSTERED 
(
	[tenyo_folio_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TENYO_COMPRA]  WITH CHECK ADD  CONSTRAINT [FK_TENYO_COMPRA_TENYO_EMPLEADO] FOREIGN KEY([tenyo_clave_empleado])
REFERENCES [dbo].[TENYO_EMPLEADO] ([tenyo_clave_empleado])
GO
ALTER TABLE [dbo].[TENYO_COMPRA] CHECK CONSTRAINT [FK_TENYO_COMPRA_TENYO_EMPLEADO]
GO
ALTER TABLE [dbo].[TENYO_COMPRA]  WITH CHECK ADD  CONSTRAINT [FK_TENYO_COMPRA_TENYO_PROVEEDOR] FOREIGN KEY([tenyo_clave_proveedor])
REFERENCES [dbo].[TENYO_PROVEEDOR] ([tenyo_clave_proveedor])
GO
ALTER TABLE [dbo].[TENYO_COMPRA] CHECK CONSTRAINT [FK_TENYO_COMPRA_TENYO_PROVEEDOR]
GO
ALTER TABLE [dbo].[TENYO_DETALLE_COMPRA]  WITH CHECK ADD  CONSTRAINT [FK_TENYO_DETALLE_COMPRA_TENYO_COMPRA] FOREIGN KEY([tenyo_id_compra])
REFERENCES [dbo].[TENYO_COMPRA] ([tenyo_id_compra])
GO
ALTER TABLE [dbo].[TENYO_DETALLE_COMPRA] CHECK CONSTRAINT [FK_TENYO_DETALLE_COMPRA_TENYO_COMPRA]
GO
ALTER TABLE [dbo].[TENYO_DETALLE_COMPRA]  WITH CHECK ADD  CONSTRAINT [FK_TENYO_DETALLE_COMPRA_TENYO_PRODUCTO] FOREIGN KEY([tenyo_clave_producto])
REFERENCES [dbo].[TENYO_PRODUCTO] ([tenyo_clave_producto])
GO
ALTER TABLE [dbo].[TENYO_DETALLE_COMPRA] CHECK CONSTRAINT [FK_TENYO_DETALLE_COMPRA_TENYO_PRODUCTO]
GO
ALTER TABLE [dbo].[TENYO_DETALLE_VENTA]  WITH CHECK ADD  CONSTRAINT [FK_TENYO_DETALLE_VENTA_TENYO_DESCUENTO] FOREIGN KEY([tenyo_id_descuento])
REFERENCES [dbo].[TENYO_DESCUENTO] ([tenyo_id_descuento])
GO
ALTER TABLE [dbo].[TENYO_DETALLE_VENTA] CHECK CONSTRAINT [FK_TENYO_DETALLE_VENTA_TENYO_DESCUENTO]
GO
ALTER TABLE [dbo].[TENYO_DETALLE_VENTA]  WITH CHECK ADD  CONSTRAINT [FK_TENYO_DETALLE_VENTA_TENYO_PRODUCTO] FOREIGN KEY([tenyo_clave_producto])
REFERENCES [dbo].[TENYO_PRODUCTO] ([tenyo_clave_producto])
GO
ALTER TABLE [dbo].[TENYO_DETALLE_VENTA] CHECK CONSTRAINT [FK_TENYO_DETALLE_VENTA_TENYO_PRODUCTO]
GO
ALTER TABLE [dbo].[TENYO_DETALLE_VENTA]  WITH CHECK ADD  CONSTRAINT [FK_TENYO_DETALLE_VENTA_TENYO_VENTA] FOREIGN KEY([tenyo_folio_venta])
REFERENCES [dbo].[TENYO_VENTA] ([tenyo_folio_venta])
GO
ALTER TABLE [dbo].[TENYO_DETALLE_VENTA] CHECK CONSTRAINT [FK_TENYO_DETALLE_VENTA_TENYO_VENTA]
GO
ALTER TABLE [dbo].[TENYO_DEVOLUCION]  WITH CHECK ADD  CONSTRAINT [FK_TENYO_DEVOLUCION_TENYO_PRODUCTO] FOREIGN KEY([tenyo_clave_producto])
REFERENCES [dbo].[TENYO_PRODUCTO] ([tenyo_clave_producto])
GO
ALTER TABLE [dbo].[TENYO_DEVOLUCION] CHECK CONSTRAINT [FK_TENYO_DEVOLUCION_TENYO_PRODUCTO]
GO
ALTER TABLE [dbo].[TENYO_DEVOLUCION]  WITH CHECK ADD  CONSTRAINT [FK_TENYO_DEVOLUCION_TENYO_VENTA] FOREIGN KEY([tenyo_folio_venta])
REFERENCES [dbo].[TENYO_VENTA] ([tenyo_folio_venta])
GO
ALTER TABLE [dbo].[TENYO_DEVOLUCION] CHECK CONSTRAINT [FK_TENYO_DEVOLUCION_TENYO_VENTA]
GO
ALTER TABLE [dbo].[TENYO_FICHA_TECNICA]  WITH CHECK ADD  CONSTRAINT [FK_TENYO_FICHA_TECNICA_TENYO_CARACTERISTICA] FOREIGN KEY([tenyo_clave_caracteristica])
REFERENCES [dbo].[TENYO_CARACTERISTICA] ([tenyo_clave_caracteristica])
GO
ALTER TABLE [dbo].[TENYO_FICHA_TECNICA] CHECK CONSTRAINT [FK_TENYO_FICHA_TECNICA_TENYO_CARACTERISTICA]
GO
ALTER TABLE [dbo].[TENYO_FICHA_TECNICA]  WITH CHECK ADD  CONSTRAINT [FK_TENYO_FICHA_TECNICA_TENYO_MEDIDA] FOREIGN KEY([tenyo_id_medida])
REFERENCES [dbo].[TENYO_MEDIDA] ([tenyo_id_medida])
GO
ALTER TABLE [dbo].[TENYO_FICHA_TECNICA] CHECK CONSTRAINT [FK_TENYO_FICHA_TECNICA_TENYO_MEDIDA]
GO
ALTER TABLE [dbo].[TENYO_FICHA_TECNICA]  WITH CHECK ADD  CONSTRAINT [FK_TENYO_FICHA_TECNICA_TENYO_PRODUCTO] FOREIGN KEY([tenyo_clave_producto])
REFERENCES [dbo].[TENYO_PRODUCTO] ([tenyo_clave_producto])
GO
ALTER TABLE [dbo].[TENYO_FICHA_TECNICA] CHECK CONSTRAINT [FK_TENYO_FICHA_TECNICA_TENYO_PRODUCTO]
GO
ALTER TABLE [dbo].[TENYO_PRODUCTO]  WITH CHECK ADD  CONSTRAINT [FK_TENYO_PRODUCTO_TENYO_CATEGORIA] FOREIGN KEY([tenyo_id_categoria])
REFERENCES [dbo].[TENYO_CATEGORIA] ([tenyo_id_categoria])
GO
ALTER TABLE [dbo].[TENYO_PRODUCTO] CHECK CONSTRAINT [FK_TENYO_PRODUCTO_TENYO_CATEGORIA]
GO
ALTER TABLE [dbo].[TENYO_PRODUCTO]  WITH CHECK ADD  CONSTRAINT [FK_TENYO_PRODUCTO_TENYO_DEPARTAMENTO] FOREIGN KEY([tenyo_id_departamento])
REFERENCES [dbo].[TENYO_DEPARTAMENTO] ([tenyo_id_departamento])
GO
ALTER TABLE [dbo].[TENYO_PRODUCTO] CHECK CONSTRAINT [FK_TENYO_PRODUCTO_TENYO_DEPARTAMENTO]
GO
ALTER TABLE [dbo].[TENYO_PRODUCTO]  WITH CHECK ADD  CONSTRAINT [FK_TENYO_PRODUCTO_TENYO_DESCUENTO] FOREIGN KEY([tenyo_id_descuento])
REFERENCES [dbo].[TENYO_DESCUENTO] ([tenyo_id_descuento])
GO
ALTER TABLE [dbo].[TENYO_PRODUCTO] CHECK CONSTRAINT [FK_TENYO_PRODUCTO_TENYO_DESCUENTO]
GO
ALTER TABLE [dbo].[TENYO_PRODUCTO]  WITH CHECK ADD  CONSTRAINT [FK_TENYO_PRODUCTO_TENYO_ESTANTE] FOREIGN KEY([tenyo_id_estante])
REFERENCES [dbo].[TENYO_ESTANTE] ([tenyo_id_estante])
GO
ALTER TABLE [dbo].[TENYO_PRODUCTO] CHECK CONSTRAINT [FK_TENYO_PRODUCTO_TENYO_ESTANTE]
GO
ALTER TABLE [dbo].[TENYO_PRODUCTO]  WITH CHECK ADD  CONSTRAINT [FK_TENYO_PRODUCTO_TENYO_MARCA] FOREIGN KEY([tenyo_id_marca])
REFERENCES [dbo].[TENYO_MARCA] ([tenyo_id_marca])
GO
ALTER TABLE [dbo].[TENYO_PRODUCTO] CHECK CONSTRAINT [FK_TENYO_PRODUCTO_TENYO_MARCA]
GO
ALTER TABLE [dbo].[TENYO_PRODUCTO]  WITH CHECK ADD  CONSTRAINT [FK_TENYO_PRODUCTO_TENYO_MATERIAL] FOREIGN KEY([tenyo_id_material])
REFERENCES [dbo].[TENYO_MATERIAL] ([tenyo_id_material])
GO
ALTER TABLE [dbo].[TENYO_PRODUCTO] CHECK CONSTRAINT [FK_TENYO_PRODUCTO_TENYO_MATERIAL]
GO
ALTER TABLE [dbo].[TENYO_PRODUCTO]  WITH CHECK ADD  CONSTRAINT [FK_TENYO_PRODUCTO_TENYO_PASILLO] FOREIGN KEY([tenyo_id_pasillo])
REFERENCES [dbo].[TENYO_PASILLO] ([tenyo_id_pasillo])
GO
ALTER TABLE [dbo].[TENYO_PRODUCTO] CHECK CONSTRAINT [FK_TENYO_PRODUCTO_TENYO_PASILLO]
GO
ALTER TABLE [dbo].[TENYO_VENTA]  WITH CHECK ADD  CONSTRAINT [FK_TENYO_VENTA_TENYO_EMPLEADO] FOREIGN KEY([tenyo_clave_empleado])
REFERENCES [dbo].[TENYO_EMPLEADO] ([tenyo_clave_empleado])
GO
ALTER TABLE [dbo].[TENYO_VENTA] CHECK CONSTRAINT [FK_TENYO_VENTA_TENYO_EMPLEADO]
GO
/****** Object:  StoredProcedure [dbo].[buscar_caracteristica_tenyo]    Script Date: 07/07/2022 12:47:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscar_caracteristica_tenyo]
	@p_caract_tenyo VARCHAR(150)
AS
BEGIN
	SELECT c.[tenyo_clave_caracteristica] CLAVE,
	c.[tenyo_nombre_caracteristica] CARACTERISTICA
	FROM [dbo].[TENYO_CARACTERISTICA] c
	WHERE c.[tenyo_nombre_caracteristica] LIKE '%' + @p_caract_tenyo + '%'
	AND c.[tenyo_status_caracteristica] = '1'
END;
GO
/****** Object:  StoredProcedure [dbo].[buscar_empleado_tenyo]    Script Date: 07/07/2022 12:47:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscar_empleado_tenyo]
	@p_nombre_apellido_tenyo VARCHAR(200)
AS
BEGIN
	SELECT e.[tenyo_clave_empleado] CLAVE,
	e.[tenyo_nombre_empleado] + ' ' + e.[tenyo_ape1_empleado] + ' ' + e.[tenyo_ape2_empleado] EMPLEADO,
	E.[tenyo_telefono_empleado] TELEFONO,
	e.[tenyo_fecha_contratado] 'FECHA CONTRATADO'
	FROM [dbo].[TENYO_EMPLEADO] e
	WHERE e.[tenyo_clave_empleado] LIKE '%' + @p_nombre_apellido_tenyo + '%'
	OR e.[tenyo_nombre_empleado] LIKE '%' + @p_nombre_apellido_tenyo + '%'
	OR e.[tenyo_ape1_empleado] LIKE '%' + @p_nombre_apellido_tenyo + '%'
	OR e.[tenyo_ape2_empleado] LIKE '%' + @p_nombre_apellido_tenyo + '%'
	AND e.[tenyo_status_empleado] = 1;
END;
GO
/****** Object:  StoredProcedure [dbo].[buscar_ficha_tecnica_tenyo]    Script Date: 07/07/2022 12:47:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscar_ficha_tecnica_tenyo]
	@p_clave_producto_tenyo VARCHAR(30)
AS
BEGIN
	SELECT c.[tenyo_nombre_caracteristica] CARACTERISTICA,
	f.[tenyo_medida_valor_producto] VALOR,
	m.[tenyo_abreviatura_medida] MEDIDA,
	f.[tenyo_observacion] OBSERVACION
	FROM [dbo].[TENYO_FICHA_TECNICA] f
	JOIN [dbo].[TENYO_CARACTERISTICA] c
	ON f.[tenyo_clave_caracteristica] = c.[tenyo_clave_caracteristica]
	JOIN [dbo].[TENYO_MEDIDA] m
	ON f.[tenyo_id_medida] = m.[tenyo_id_medida]
	WHERE f.[tenyo_clave_producto] = @p_clave_producto_tenyo
	ORDER BY CARACTERISTICA;
END;
GO
/****** Object:  StoredProcedure [dbo].[buscar_medida_tenyo]    Script Date: 07/07/2022 12:47:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscar_medida_tenyo]
	@p_nombre_medida VARCHAR(50)
AS
BEGIN
	SELECT m.[tenyo_nombre_medida] MEDIDA,
	m.[tenyo_abreviatura_medida] ABREVIATURA
	FROM [dbo].[TENYO_MEDIDA] m
	WHERE m.[tenyo_nombre_medida] LIKE '%' + @p_nombre_medida + '%'
	OR m.[tenyo_abreviatura_medida] LIKE '%' + @p_nombre_medida + '%'
END;
GO
/****** Object:  StoredProcedure [dbo].[buscar_producto_tenyo]    Script Date: 07/07/2022 12:47:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscar_producto_tenyo]
	@p_buscar_cosa_tenyo VARCHAR(100)
AS
BEGIN
	SELECT TOP 20 p.[tenyo_clave_producto] CLAVE,
		p.[tenyo_codigo_producto] CODIGO,
		d.[tenyo_descripcion_departamento] DEPARTAMENTO,
		m.[tenyo_nombre_marca] MARCA,
		c.[tenyo_descripcion_categoria] CATEGORIA,
		pas.[tenyo_numero_pasillo] PASILLO,
		es.[tenyo_numero_estante] ESTANTE,
		ma.[tenyo_descripcion_material] MATERIAL,
		p.[tenyo_nivel_competencia] 'NIVEL COMPETENCIA',
		p.[tenyo_cantidad_producto] CANTIDAD,
		p.[tenyo_existencias_producto] EXISTENCIAS,
		p.[tenyo_stock_min] 'STOCK MINIMO',
		p.[tenyo_stock_max] 'STOCK MAXIMO',
		p.[tenyo_precio_actual_producto_mayoreo] 'PRECIO MAYOREO',
		p.[tenyo_precio_actual_publico] 'PRECIO PUBLICO',
		de.[tenyo_porcentaje_descuento] DESCUENTO
	FROM [dbo].[TENYO_PRODUCTO] p
		LEFT JOIN [dbo].[TENYO_DEPARTAMENTO] d
		ON p.[tenyo_id_departamento] = d.[tenyo_id_departamento]
		LEFT JOIN [dbo].[TENYO_MARCA] m
		ON p.[tenyo_id_marca] = m.[tenyo_id_marca]
		LEFT JOIN [dbo].[TENYO_CATEGORIA] c
		ON p.[tenyo_id_categoria] = c.[tenyo_id_categoria]
		LEFT JOIN [dbo].[TENYO_PASILLO] pas
		ON p.[tenyo_id_pasillo] = pas.[tenyo_id_pasillo]
		LEFT JOIN [dbo].[TENYO_ESTANTE] es
		ON p.[tenyo_id_estante] = es.[tenyo_id_estante]
		LEFT JOIN [dbo].[TENYO_MATERIAL] ma
		ON p.[tenyo_id_material] = ma.[tenyo_id_material]
		LEFT JOIN [dbo].[TENYO_DESCUENTO] de
		ON p.[tenyo_id_descuento] = de.[tenyo_id_descuento]
	WHERE p.[tenyo_clave_producto] LIKE '%' + @p_buscar_cosa_tenyo +'%'
		OR p.[tenyo_codigo_producto] LIKE '%' + @p_buscar_cosa_tenyo + '%'
		OR d.[tenyo_descripcion_departamento] LIKE '%' + @p_buscar_cosa_tenyo + '%'
		OR m.[tenyo_nombre_marca] LIKE '%' + @p_buscar_cosa_tenyo + '%'
		OR c.[tenyo_descripcion_categoria] LIKE '%' + @p_buscar_cosa_tenyo + '%'
		OR es.[tenyo_numero_estante] LIKE '%' + @p_buscar_cosa_tenyo + '%'
		OR ma.[tenyo_descripcion_material] LIKE '%' + @p_buscar_cosa_tenyo + '%'
		ORDER BY CATEGORIA
END;
GO
/****** Object:  StoredProcedure [dbo].[buscar_proveedor_tenyo]    Script Date: 07/07/2022 12:47:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscar_proveedor_tenyo]
	@p_clave_razon_tenyo VARCHAR(200)
AS
BEGIN
	SELECT p.[tenyo_clave_proveedor] CLAVE,
	p.[tenyo_razon_social] 'RAZON SOCIAL',
	p.[tenyo_direccion_proveedor] DIRECCION,
	p.[tenyo_telefono_proveedor] TELEFONO,
	p.[tenyo_contacto_proveedor] CONTACTO
	FROM [dbo].[TENYO_PROVEEDOR] p
	WHERE p.[tenyo_clave_proveedor] LIKE '%' + @p_clave_razon_tenyo + '%'
	OR p.[tenyo_razon_social] LIKE '%' + @p_clave_razon_tenyo + '%'
	AND p.[tenyo_status_proveedor] = 1
	ORDER BY 'RAZON SOCIAL'
END;
GO
/****** Object:  StoredProcedure [dbo].[cerrar_venta_tenyo]    Script Date: 07/07/2022 12:47:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[cerrar_venta_tenyo]
	@p_folio_venta_tenyo VARCHAR(15)
AS
BEGIN
	IF EXISTS(
		SELECT TOP 1 v.[tenyo_folio_venta]
		FROM [dbo].[TENYO_VENTA] v
		WHERE v.[tenyo_folio_venta] = @p_folio_venta_tenyo
		AND v.[tenyo_status_venta] = 1
	)
	BEGIN
		UPDATE [dbo].[TENYO_VENTA]
		SET [dbo].[TENYO_VENTA].[tenyo_precio_total_venta] =
			(SELECT SUM(dv.[tenyo_total_cantidad_precio])
			FROM [dbo].[TENYO_DETALLE_VENTA] dv
			WHERE dv.[tenyo_folio_venta] = @p_folio_venta_tenyo),
			[dbo].[TENYO_VENTA].[tenyo_status_venta] = '0'
		WHERE [dbo].[TENYO_VENTA].[tenyo_folio_venta] = @p_folio_venta_tenyo;
		SELECT 'VENTA CERRADA EXITOSAMENTE' AS MENSAJE;
	END;
END;
GO
/****** Object:  StoredProcedure [dbo].[insert_detVenta_tenyo]    Script Date: 07/07/2022 12:47:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insert_detVenta_tenyo]
	@p_folio_venta_tenyo VARCHAR(15),
	@p_clave_producto VARCHAR(30),
	@p_precio_producto FLOAT,
	@p_cantidad_producto FLOAT
AS
BEGIN
	IF EXISTS(
		SELECT TOP 1 dv.[tenyo_clave_producto]
		FROM [dbo].[TENYO_DETALLE_VENTA] dv
		WHERE dv.[tenyo_folio_venta] = @p_folio_venta_tenyo
		AND dv.[tenyo_clave_producto] = @p_clave_producto
	)
		BEGIN
			UPDATE [dbo].[TENYO_DETALLE_VENTA]
			SET [dbo].[TENYO_DETALLE_VENTA].[tenyo_cantidad_producto_venta] = @p_cantidad_producto,
			[dbo].[TENYO_DETALLE_VENTA].[tenyo_total_cantidad_precio] = @p_cantidad_producto * @p_precio_producto
			WHERE [dbo].[TENYO_DETALLE_VENTA].[tenyo_folio_venta] = @p_folio_venta_tenyo
			AND [dbo].[TENYO_DETALLE_VENTA].[tenyo_clave_producto] = @p_clave_producto;
		END;
	ELSE
		BEGIN
			INSERT [dbo].[TENYO_DETALLE_VENTA] VALUES(
			@p_folio_venta_tenyo,
			@p_clave_producto,
			@p_cantidad_producto,
			@p_precio_producto,
			(SELECT TOP 1 p.[tenyo_id_descuento]
			FROM [dbo].[TENYO_PRODUCTO] p
			WHERE p.[tenyo_clave_producto] = @p_clave_producto),
			(@p_cantidad_producto * @p_precio_producto)
			);
		END;
END;
GO
/****** Object:  StoredProcedure [dbo].[insert_venta_tenyo]    Script Date: 07/07/2022 12:47:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insert_venta_tenyo]
	@p_folio_venta_tenyo VARCHAR(15),
	@p_clave_empleado_tenyo VARCHAR(30)
AS
BEGIN
	IF EXISTS(
		SELECT v.[tenyo_folio_venta]
		FROM [dbo].[TENYO_VENTA] v
		WHERE v.[tenyo_folio_venta] = @p_folio_venta_tenyo
		AND v.[tenyo_status_venta] = '0'
	)
		BEGIN
			SELECT 'ESTA VENTA YA HA SIDO CERRADA' AS MENSAJE;
		END;
	ELSE
		BEGIN
			INSERT [dbo].[TENYO_VENTA] VALUES(
				@p_folio_venta_tenyo,
				@p_clave_empleado_tenyo,
				SYSDATETIME(),
				0,
				0,
				'1'
			);
		END;
END;
GO
/****** Object:  StoredProcedure [dbo].[insertar_caracteristica_tenyo]    Script Date: 07/07/2022 12:47:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertar_caracteristica_tenyo]
	@p_clave_caracteristica_tenyo VARCHAR(20),
	@p_descripcion_caracteristica_tenyo VARCHAR(150)
AS
BEGIN
	IF EXISTS(
		SELECT TOP 1 c.[tenyo_clave_caracteristica]
		FROM [dbo].[TENYO_CARACTERISTICA] c
		WHERE c.[tenyo_clave_caracteristica] = @p_clave_caracteristica_tenyo
	)
		BEGIN
			SELECT 'LA CARACTERISTICA ' + @p_descripcion_caracteristica_tenyo + ' YA SE HA REGISTRADO ANTERIORMENTE' AS MENSAJE;
		END;
	ELSE
		BEGIN
			INSERT [dbo].[TENYO_CARACTERISTICA] VALUES(
				@p_clave_caracteristica_tenyo,
				@p_descripcion_caracteristica_tenyo,
				'1'
			)
			SELECT 'LA CARACTERISTICA ' + @p_descripcion_caracteristica_tenyo + ' SE AGREGO CON EXITO' AS MENSAJE;
		END;
END;
GO
/****** Object:  StoredProcedure [dbo].[insertar_categoria_tenyo]    Script Date: 07/07/2022 12:47:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertar_categoria_tenyo]
	@p_descripcion_categoria_tenyo VARCHAR(200)
AS
BEGIN
	IF EXISTS (SELECT TOP 1 cat.[tenyo_id_categoria]
		FROM [dbo].[TENYO_CATEGORIA] cat
		WHERE cat.[tenyo_descripcion_categoria] = @p_descripcion_categoria_tenyo)
		BEGIN
			SELECT 'LA CATEGORIA ' + @p_descripcion_categoria_tenyo + ' YA HA SIDO REGISTRADA ANTERIORMENTE' AS MENSAJE;
		END
	ELSE
		BEGIN
			INSERT [dbo].[TENYO_CATEGORIA] VALUES(
				@p_descripcion_categoria_tenyo,
				'1'
			);
			SELECT 'LA CATEGORIA ' + @p_descripcion_categoria_tenyo + ' SE AGREGO CON EXITO' AS MENSAJE;
		END
END
GO
/****** Object:  StoredProcedure [dbo].[insertar_departamento_tenyo]    Script Date: 07/07/2022 12:47:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertar_departamento_tenyo]
	@p_decripcion_departamento_tenyo VARCHAR(100)
AS
BEGIN
	IF EXISTS (SELECT TOP 1 dep.[tenyo_id_departamento]
		FROM [dbo].[TENYO_DEPARTAMENTO] dep
		WHERE dep.[tenyo_descripcion_departamento] = @p_decripcion_departamento_tenyo)
		BEGIN
			SELECT 'EL DEPARTAMENTO ' + @p_decripcion_departamento_tenyo + ' YA HA SIDO REGISTRADO ANTERIORMENTE' AS MENSAJE;
		END
	ELSE
		BEGIN
			INSERT [dbo].[TENYO_DEPARTAMENTO] VALUES(
				@p_decripcion_departamento_tenyo,
				'1'
			);
			SELECT 'EL DEPARTAMENTO ' + @p_decripcion_departamento_tenyo + ' SE AGREGO CON EXITO' AS MENSAJE;
		END
END
GO
/****** Object:  StoredProcedure [dbo].[insertar_descuento_tenyo]    Script Date: 07/07/2022 12:47:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertar_descuento_tenyo]
	@p_porcentaje_descuento_tenyo FLOAT
AS
BEGIN
	IF EXISTS (SELECT TOP 1 d.[tenyo_id_descuento]
		FROM [dbo].[TENYO_DESCUENTO] d
		WHERE d.[tenyo_porcentaje_descuento] = @p_porcentaje_descuento_tenyo)
		BEGIN
			SELECT 'EL PORCENTAJE DE DESCUENTO ' + CONVERT(VARCHAR, @p_porcentaje_descuento_tenyo) + ' YA HA SIDO REGISTRADO ANTERIORMENTE' AS MENSAJE;
			UPDATE [dbo].[TENYO_DESCUENTO]
			SET [dbo].[TENYO_DESCUENTO].[tenyo_status_descuento] = 1
			WHERE [dbo].[TENYO_DESCUENTO].[tenyo_porcentaje_descuento] = @p_porcentaje_descuento_tenyo;
		END
	ELSE
		BEGIN
			INSERT [dbo].[TENYO_DESCUENTO] VALUES(
				@p_porcentaje_descuento_tenyo,
				'1'
			);
			SELECT 'EL PORCENTAJE DE DESCUENTO ' + CONVERT(VARCHAR, @p_porcentaje_descuento_tenyo) + ' SE AGREGO CON EXITO' AS MENSAJE;
		END
END
GO
/****** Object:  StoredProcedure [dbo].[insertar_empleado_tenyo]    Script Date: 07/07/2022 12:47:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertar_empleado_tenyo]
	@p_clave_empleado_tenyo VARCHAR(30),
	@p_nombre_empleado_tenyo VARCHAR(200),
	@p_ape1_empleado_tenyo VARCHAR(200),
	@p_ape2_empleado_tenyo VARCHAR(200),
	@p_telefono_empleado_tenyo VARCHAR(12)
AS
BEGIN

	IF EXISTS(
		SELECT TOP 1 e.[tenyo_clave_empleado]
		FROM [dbo].[TENYO_EMPLEADO] e
		WHERE e.[tenyo_clave_empleado] = @p_clave_empleado_tenyo
	)
		BEGIN
			SELECT 'EL EMPLEADO CON CLAVE ' + @p_clave_empleado_tenyo + ' YA HA SIDO REGISTRADO CON ANTERIORIDAD' AS MENSAJE;
		END;
	ELSE
		BEGIN
			INSERT [dbo].[TENYO_EMPLEADO] VALUES(
				@p_clave_empleado_tenyo,
				@p_nombre_empleado_tenyo,
				@p_ape1_empleado_tenyo,
				@p_ape2_empleado_tenyo,
				@p_telefono_empleado_tenyo,
				CONVERT(DATE, GETDATE()),
				'1'
			);
			SELECT 'EL EMPLEADO ' + @p_nombre_empleado_tenyo + ' SE AGREGO CON EXITO' AS MENSAJE;
		END;
END;
GO
/****** Object:  StoredProcedure [dbo].[insertar_estante_tenyo]    Script Date: 07/07/2022 12:47:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertar_estante_tenyo]
	@p_numero_estante_tenyo VARCHAR(20)
AS
BEGIN
	IF EXISTS (SELECT TOP 1 est.[tenyo_id_estante]
		FROM [dbo].[TENYO_ESTANTE] est
		WHERE est.[tenyo_numero_estante] = @p_numero_estante_tenyo)
		BEGIN
			SELECT 'EL ESTANTE ' + @p_numero_estante_tenyo + ' YA HA SIDO REGISTRADO ANTERIORMENTE'AS MENSAJE;
		END
	ELSE
		BEGIN
			INSERT [dbo].[TENYO_ESTANTE] VALUES(
				@p_numero_estante_tenyo,
				'1'
			);
			SELECT 'EL ESTANTE ' + @p_numero_estante_tenyo + ' SE AGREGO CON EXITO' AS MENSAJE;
		END
END
GO
/****** Object:  StoredProcedure [dbo].[insertar_ficha_tecnica_tenyo]    Script Date: 07/07/2022 12:47:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertar_ficha_tecnica_tenyo]
	@p_clave_producto_tenyo VARCHAR(30),
	@p_caracteristica VARCHAR(20),
	@p_medida_valor_producto VARCHAR(30),
	@p_medida_tenyo VARCHAR(50),
	@p_observacion_tenyo VARCHAR(150)
AS
BEGIN
	IF EXISTS(
		SELECT TOP 1 f.[tenyo_clave_caracteristica]
		FROM [dbo].[TENYO_FICHA_TECNICA] f
		WHERE f.[tenyo_clave_caracteristica] = (
			SELECT TOP 1 c.[tenyo_clave_caracteristica]
			FROM [dbo].[TENYO_CARACTERISTICA] c
			WHERE c.[tenyo_nombre_caracteristica] = @p_caracteristica
			AND c.[tenyo_status_caracteristica] = 1)
		AND f.[tenyo_clave_producto] = @p_clave_producto_tenyo
		AND f.[tenyo_status] = '1'
	)
		BEGIN
			SELECT 'LA CARACTERISTICA ' + @p_caracteristica + ' YA EXISTE' AS MENSAJE;
		END;
	ELSE
		BEGIN
			INSERT [dbo].[TENYO_FICHA_TECNICA] VALUES(
				@p_clave_producto_tenyo,
				(SELECT TOP 1 c.[tenyo_clave_caracteristica]
					FROM [dbo].[TENYO_CARACTERISTICA] c
					WHERE c.[tenyo_nombre_caracteristica] = @p_caracteristica
					AND c.[tenyo_status_caracteristica] = 1),
				@p_medida_valor_producto,
				(SELECT TOP 1 m.[tenyo_id_medida]
					FROM [dbo].[TENYO_MEDIDA] m
					WHERE m.[tenyo_abreviatura_medida] = @p_medida_tenyo),
				@p_observacion_tenyo,
				'1'
			);
			SELECT 'LA CARACTERISTICA ' + @p_caracteristica + ' SE REGISTRO CON EXITO' AS MENSAJE;
		END;
END;
GO
/****** Object:  StoredProcedure [dbo].[insertar_marca_tenyo]    Script Date: 07/07/2022 12:47:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertar_marca_tenyo]
	@p_nombre_marca_tenyo VARCHAR(70)
AS
BEGIN
	IF EXISTS (SELECT mar.[tenyo_id_marca]
		FROM [dbo].[TENYO_MARCA] mar
		WHERE mar.[tenyo_nombre_marca] = @p_nombre_marca_tenyo)
		BEGIN
			SELECT 'LA MARCA ' + @p_nombre_marca_tenyo + ' YA HA SIDO REGISTRADO ANTERIORMENTE ' AS MENSAJE;
		END
	ELSE
		BEGIN
			INSERT [dbo].[TENYO_MARCA] VALUES(
				@p_nombre_marca_tenyo,
				'1'
			);
			SELECT 'LA MARCA ' + @p_nombre_marca_tenyo + ' SE AGREGO CON EXITO' AS MENSAJE;
		END
END
GO
/****** Object:  StoredProcedure [dbo].[insertar_material_tenyo]    Script Date: 07/07/2022 12:47:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertar_material_tenyo]
	@p_descripcion_material_tenyo VARCHAR(150)
AS
BEGIN
	IF EXISTS (SELECT TOP 1 mat.[tenyo_id_material]
		FROM [dbo].[TENYO_MATERIAL] mat
		WHERE mat.[tenyo_descripcion_material] = @p_descripcion_material_tenyo)
		BEGIN
			SELECT 'EL MATERIAL ' + @p_descripcion_material_tenyo + ' YA HA SIDO REGISTRADO ANTERIORMENTE' AS MENSAJE;
		END
	ELSE
		BEGIN
			INSERT [dbo].[TENYO_MATERIAL] VALUES(
				@p_descripcion_material_tenyo,
				'1'
			);
			SELECT 'EL MATERIAL ' + @p_descripcion_material_tenyo + ' SE AGREGO CON EXITO' AS MENSAJE;
		END
END
GO
/****** Object:  StoredProcedure [dbo].[insertar_medida_tenyo]    Script Date: 07/07/2022 12:47:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertar_medida_tenyo]
	@p_nombre_medida_tenyo VARCHAR(50),
	@p_abreviatura_medida_tenyo VARCHAR(50)
AS
BEGIN
	IF EXISTS(
		SELECT TOP 1 m.[tenyo_id_medida]
		FROM [dbo].[TENYO_MEDIDA] m
		WHERE m.[tenyo_nombre_medida] = @p_nombre_medida_tenyo
	)
		BEGIN
			SELECT 'LA MEDIDA ' + @p_nombre_medida_tenyo + ' YA SE AGREGO ANTERIORMENTE' AS MENSAJE;
		END;
	ELSE IF EXISTS(
		SELECT TOP 1 m.[tenyo_id_medida]
		FROM [dbo].[TENYO_MEDIDA] m
		WHERE m.[tenyo_abreviatura_medida] = @p_abreviatura_medida_tenyo
	)
		BEGIN
			SELECT 'LA ABREVIATURA ' + @p_abreviatura_medida_tenyo + ' SE AGREGO ANTERIORMENTE' AS MENSAJE;
		END;
	ELSE
		BEGIN
			INSERT [dbo].[TENYO_MEDIDA] VALUES(
				@p_nombre_medida_tenyo,
				@p_abreviatura_medida_tenyo,
				'1'
			)
			SELECT 'LA MEDIDA ' + @p_nombre_medida_tenyo + ' SE AGREGO CON EXITO' AS MENSAJE;
		END;
END;
GO
/****** Object:  StoredProcedure [dbo].[insertar_pasillo_tenyo]    Script Date: 07/07/2022 12:47:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertar_pasillo_tenyo]
	@p_numero_pasillo_tenyo VARCHAR(20)
AS
BEGIN
	IF EXISTS (SELECT TOP 1 pas.[tenyo_id_pasillo]
		FROM [dbo].[TENYO_PASILLO] pas
		WHERE pas.[tenyo_numero_pasillo] = @p_numero_pasillo_tenyo)
		BEGIN
			SELECT 'EL NUMERO DE PASILLO ' + @p_numero_pasillo_tenyo + ' YA HA SIDO REGISTRADO ANTERIORMENTE' AS MENSAJE;
		END
	ELSE
		BEGIN
			INSERT [dbo].[TENYO_PASILLO] VALUES(
				@p_numero_pasillo_tenyo
			);
			SELECT 'EL NUMERO DE PASILLO ' + @p_numero_pasillo_tenyo + ' SE AGREGO CON EXITO' AS MENSAJE;
		END
END
GO
/****** Object:  StoredProcedure [dbo].[insertar_producto_tenyo]    Script Date: 07/07/2022 12:47:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertar_producto_tenyo]
	@p_clave_producto_tenyo VARCHAR(30),
	@p_codigo_producto_tenyo VARCHAR(10),
	@p_descripcion_departamento_tenyo VARCHAR(12),
	@p_marca_tenyo VARCHAR(70),
	@p_categoria_tenyo VARCHAR(200),
	@p_pasillo_tenyo VARCHAR(20),
	@p_estante_tenyo VARCHAR(12),
	@p_material_tenyo VARCHAR(150),
	@p_nivel_competencia_tenyo TINYINT,
	@p_cantidad_tenyo SMALLINT,
	@p_existencias_tenyo SMALLINT,
	@p_stock_min_tenyo TINYINT,
	@p_stock_max_tenyo SMALLINT,
	@p_precio_actual_mayoreo FLOAT,
	@p_precio_actual_publico FLOAT,
	@p_descuento FLOAT
AS
BEGIN
	IF EXISTS (
		SELECT TOP 1 p.[tenyo_clave_producto]
		FROM [dbo].[TENYO_PRODUCTO] p
		WHERE p.[tenyo_clave_producto] = @p_clave_producto_tenyo
	)
		BEGIN
			SELECT 'LA CLAVE DE PRODUCTO ' + @p_clave_producto_tenyo + ' YA HA SIDO REGISTRADO' AS MENSAJE;
		END;
	ELSE IF EXISTS(
		SELECT TOP 1 p.[tenyo_codigo_producto]
		FROM [dbo].[TENYO_PRODUCTO] p
		WHERE p.[tenyo_codigo_producto] = @p_codigo_producto_tenyo
	)
		BEGIN
			SELECT 'EL CODIGO DE PRODUCTO ' + @p_codigo_producto_tenyo + ' YA HA SIO REGISTRADO' AS MENSAJE;
		END;
	ELSE
		BEGIN
			INSERT [dbo].[TENYO_PRODUCTO] VALUES(
				@p_clave_producto_tenyo,
				@p_codigo_producto_tenyo,
				(SELECT TOP 1 [dbo].[TENYO_DEPARTAMENTO].[tenyo_id_departamento]
					FROM [dbo].[TENYO_DEPARTAMENTO]
					WHERE [dbo].[TENYO_DEPARTAMENTO].[tenyo_descripcion_departamento] = @p_descripcion_departamento_tenyo),
				(SELECT TOP 1 [dbo].[TENYO_MARCA].[tenyo_id_marca]
					FROM [dbo].[TENYO_MARCA]
					WHERE [dbo].[TENYO_MARCA].[tenyo_nombre_marca] = @p_marca_tenyo),
				(SELECT TOP 1 [dbo].[TENYO_CATEGORIA].[tenyo_id_categoria]
					FROM [dbo].[TENYO_CATEGORIA]
					WHERE [dbo].[TENYO_CATEGORIA].[tenyo_descripcion_categoria] = @p_categoria_tenyo),
				(SELECT TOP 1 [dbo].[TENYO_PASILLO].[tenyo_id_pasillo]
					FROM [dbo].[TENYO_PASILLO]
					WHERE [dbo].[TENYO_PASILLO].[tenyo_numero_pasillo] = @p_pasillo_tenyo),
				(SELECT TOP 1 [dbo].[TENYO_ESTANTE].[tenyo_id_estante]
					FROM [dbo].[TENYO_ESTANTE]
					WHERE [dbo].[TENYO_ESTANTE].[tenyo_numero_estante] = @p_estante_tenyo),
				(SELECT TOP 1 [dbo].[TENYO_MATERIAL].[tenyo_id_material]
					FROM [dbo].[TENYO_MATERIAL]
					WHERE [dbo].[TENYO_MATERIAL].[tenyo_descripcion_material] = @p_material_tenyo),
				@p_nivel_competencia_tenyo,
				@p_cantidad_tenyo,
				@p_existencias_tenyo,
				@p_stock_min_tenyo,
				@p_stock_max_tenyo,
				@p_precio_actual_mayoreo,
				@p_precio_actual_publico,
				NULL,
				(SELECT TOP 1 [dbo].[TENYO_DESCUENTO].[tenyo_id_descuento]
					FROM [dbo].[TENYO_DESCUENTO]
					WHERE [dbo].[TENYO_DESCUENTO].[tenyo_porcentaje_descuento] = @p_descuento),
				'1'
			)
			SELECT 'EL PRODUCTO ' + @p_codigo_producto_tenyo + ' SE REGISTRO CORRECTAMENTE' AS MENSAJE;
		END;
END;
GO
/****** Object:  StoredProcedure [dbo].[insertar_proveedor_tenyo]    Script Date: 07/07/2022 12:47:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertar_proveedor_tenyo]
	@p_clave_proveedor_tenyo VARCHAR(15),
	@p_razon_social_proveedor_tenyo VARCHAR(200),
	@p_direccion_proveedor_tenyo VARCHAR(200),
	@p_telefono_proveedor_tenyo VARCHAR(12),
	@p_contacto_proveedor_tenyo VARCHAR(50)
AS
BEGIN
	IF EXISTS(
		SELECT prov.[tenyo_clave_proveedor]
		FROM [dbo].[TENYO_PROVEEDOR] prov
		WHERE prov.[tenyo_clave_proveedor] = @p_clave_proveedor_tenyo
	)
		BEGIN
			SELECT 'EL PROVEEDOR ' + @p_razon_social_proveedor_tenyo + ' YA HA SIDO REGISTRADO ANTERIORMENTE' AS MENSAJE;
		END;
	ELSE
		BEGIN
			INSERT [dbo].[TENYO_PROVEEDOR] VALUES(
				@p_clave_proveedor_tenyo,
				@p_razon_social_proveedor_tenyo,
				@p_direccion_proveedor_tenyo,
				@p_telefono_proveedor_tenyo,
				@p_contacto_proveedor_tenyo,
				'1'
			)
			SELECT 'EL PROVEEDOR ' + @p_razon_social_proveedor_tenyo + ' SE AGREGO CON EXITO' AS MENSAJE;
		END;
END;
GO
/****** Object:  StoredProcedure [dbo].[select_caracteristica_tenyo]    Script Date: 07/07/2022 12:47:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_caracteristica_tenyo]
AS
BEGIN
	SELECT c.[tenyo_clave_caracteristica] CLAVE,
	c.[tenyo_nombre_caracteristica] CARACTERISTICA
	FROM [dbo].[TENYO_CARACTERISTICA] c
	WHERE c.[tenyo_status_caracteristica] = 1
	ORDER BY CARACTERISTICA;
END;
GO
/****** Object:  StoredProcedure [dbo].[select_categoria_tenyo]    Script Date: 07/07/2022 12:47:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_categoria_tenyo]
AS
BEGIN
	SELECT cat.[tenyo_descripcion_categoria] CATEGORIA
		FROM [dbo].[TENYO_CATEGORIA] cat
		WHERE cat.[tenyo_status_categoria] = 1
		ORDER BY CATEGORIA;
END
GO
/****** Object:  StoredProcedure [dbo].[select_departamento_tenyo]    Script Date: 07/07/2022 12:47:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_departamento_tenyo]
AS
BEGIN
	SELECT dep.[tenyo_descripcion_departamento] DEPARTAMENTO
		FROM [dbo].[TENYO_DEPARTAMENTO] dep
		WHERE dep.tenyo_status_departamento = 1
		ORDER BY DEPARTAMENTO;
END
GO
/****** Object:  StoredProcedure [dbo].[select_descuento_tenyo]    Script Date: 07/07/2022 12:47:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_descuento_tenyo]
AS
BEGIN
	SELECT d.[tenyo_porcentaje_descuento] DESCUENTO
		FROM [dbo].[TENYO_DESCUENTO] d
		WHERE d.[tenyo_status_descuento] = 1
		ORDER BY DESCUENTO;
END
GO
/****** Object:  StoredProcedure [dbo].[select_empleado_tenyo]    Script Date: 07/07/2022 12:47:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_empleado_tenyo]
AS
BEGIN
	SELECT e.[tenyo_clave_empleado] CLAVE,
	CONCAT(e.[tenyo_nombre_empleado], ' ', e.[tenyo_ape1_empleado]) EMPLEADO
	FROM [dbo].[TENYO_EMPLEADO] e
	WHERE e.[tenyo_status_empleado] = 1
	ORDER BY EMPLEADO;
END;
GO
/****** Object:  StoredProcedure [dbo].[select_estante_tenyo]    Script Date: 07/07/2022 12:47:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_estante_tenyo]
AS
BEGIN
	SELECT est.[tenyo_numero_estante] ESTANTE
		FROM [dbo].[TENYO_ESTANTE] est
		WHERE est.[tenyo_status_estante] = 1
		ORDER BY ESTANTE;
END
GO
/****** Object:  StoredProcedure [dbo].[select_marca_tenyo]    Script Date: 07/07/2022 12:47:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_marca_tenyo]
AS
BEGIN
	SELECT mar.[tenyo_nombre_marca] MARCA
		FROM [dbo].[TENYO_MARCA] mar
		WHERE mar.[tenyo_status_marca] = 1
		ORDER BY MARCA;
END
GO
/****** Object:  StoredProcedure [dbo].[select_material_tenyo]    Script Date: 07/07/2022 12:47:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_material_tenyo]
AS
BEGIN
	SELECT mat.[tenyo_descripcion_material] MATERIAL
		FROM [dbo].[TENYO_MATERIAL] mat
		WHERE mat.[tenyo_status_material] = 1
		ORDER BY MATERIAL;
END
GO
/****** Object:  StoredProcedure [dbo].[select_medida_tenyo]    Script Date: 07/07/2022 12:47:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_medida_tenyo]
AS
BEGIN
	SELECT m.[tenyo_nombre_medida] MEDIDA,
	m.[tenyo_abreviatura_medida] ABREVIATURA
	FROM [dbo].[TENYO_MEDIDA] m
	WHERE m.[tenyo_status_medida] = 1
	ORDER BY MEDIDA
END;
GO
/****** Object:  StoredProcedure [dbo].[select_pasillo_tenyo]    Script Date: 07/07/2022 12:47:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_pasillo_tenyo]
AS
BEGIN
	SELECT pas.[tenyo_numero_pasillo] PASILLO
		FROM [dbo].[TENYO_PASILLO] pas
		ORDER BY PASILLO;
END
GO
/****** Object:  StoredProcedure [dbo].[select_producto_tenyo]    Script Date: 07/07/2022 12:47:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_producto_tenyo]
AS
BEGIN
	SELECT p.[tenyo_clave_producto] CLAVE,
	p.[tenyo_codigo_producto] CODIGO
	FROM [dbo].[TENYO_PRODUCTO] p
	WHERE p.[tenyo_status] = 1
END;
GO
