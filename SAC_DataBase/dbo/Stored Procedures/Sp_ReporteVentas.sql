CREATE PROCEDURE [dbo].[Sp_ReporteVentas]
@formapago INT, 
@cliente INT, 
@desde DATETIME, 
@hasta DATETIME

WITH 
EXECUTE AS CALLER
AS
SELECT 
        Ventas.*,
        Venta_Detallada.*,
        Clientes.Clientes_Nombre+' '+Clientes.Clientes_Apellidos AS Nombre_Cliente,
        Productos.IdProductos,
        Productos.Productos_Nombre,
        Productos.Producto_Marca,
        Productos.Productos_Descripcion,
        Productos.Productos_Tipo,
        @desde AS Fecha_Desde,
        @hasta AS Fecha_Hasta
        
   FROM Ventas 
   
   INNER JOIN Venta_Detallada
           ON Venta_Detallada.VtaDet_IdVenta = Ventas.IdVenta 
           
   INNER JOIN Clientes
           ON Clientes.IdCliente = Ventas.IdCliente
           
   INNER JOIN Productos
           ON Productos.IdProductos = Venta_Detallada.VtaDet_IdProducto
           
  WHERE Ventas.Venta_Tipo = 
        CASE @formapago WHEN 0 THEN Ventas.Venta_Tipo
        ELSE @formapago END
        
    AND Ventas.IdCliente = 
        CASE @cliente WHEN 0 THEN Ventas.IdCliente
        ELSE @cliente END
        
    AND Ventas.Venta_Fecha BETWEEN @desde AND @hasta
    
    ORDER BY Venta_Fecha DESC