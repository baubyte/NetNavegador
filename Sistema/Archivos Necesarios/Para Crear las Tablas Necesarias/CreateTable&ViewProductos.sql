use SISTEMA
go
if exists (select * from dbo.sysobjects where id = object_id(N'[Productos]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [Productos]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[NProducto] [int] IDENTITY(1,1) NOT NULL,
	[NombreProducto] [nvarchar](30) NULL,
    [DescripcionProducto] [nvarchar](200) NULL default '',
	[PrecioProducto] [money] NULL default 0,
    [PrecioCostoProducto] [money] NULL default 0,
    [StockProducto] [int] NULL default 0,
    [IDProveedor] [int] NOT NULL,
	[Estado] [bit] NULL default 0,
 CONSTRAINT [Producto_PK] PRIMARY KEY NONCLUSTERED 
(
	[NProducto] ASC
)
) ON [PRIMARY]

GO
    
    CREATE VIEW [dbo].[ProductosBusqueda]
    AS
    SELECT     TOP (100) PERCENT NProducto, UPPER(LTRIM(NombreProducto)) AS Producto , PrecioProducto AS Precio
    FROM         dbo.Productos
    order by UPPER(LTRIM(NombreProducto))
    GO