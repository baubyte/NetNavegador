"SELECT TOP (100) PERCENT dbo.Productos.NProducto, UPPER(LTRIM(RTRIM(ISNULL(dbo.Productos.NombreProducto,'****')))) AS NombreProducto,
		LTRIM(RTRIM(ISNULL(dbo.Productos.CodigoProducto, ''))) AS CodigoProducto, UPPER(LTRIM(RTRIM(ISNULL(dbo.Productos.MarcaProducto,'*')))) AS MarcaProducto, 
		UPPER(LTRIM(RTRIM(ISNULL(dbo.Productos.DescripcionProducto,'****')))) AS DescripcionProducto, LTRIM(RTRIM(ISNULL(dbo.Productos.PrecioProducto, ''))) AS PrecioProducto, 
		LTRIM(RTRIM(ISNULL(dbo.Productos.PrecioCostoProducto, ''))) AS PrecioCostoProducto, LTRIM(RTRIM(ISNULL(dbo.Productos.StockProducto, ''))) AS StockProducto, 
		UPPER(LTRIM(dbo.Proveedores.NombreProveedor) +', ' + LTRIM(dbo.Proveedores.ApellidoProveedor)) AS Proveedor, 
        LTRIM(RTRIM(ISNULL(dbo.Productos.CategoriaProducto,''))) AS CategoriaProducto, ISNULL(dbo.Productos.Estado,0) AS Estado AS Estado, dbo.Proveedores.NProveedor AS NProveedor
FROM dbo.Productos INNER JOIN dbo.Proveedores ON dbo.Productos.NProveedor = dbo.Proveedores.NProveedor
WHERE dbo.Productos.NProducto =" + Conversion.Val(lIdProducto.Text)
