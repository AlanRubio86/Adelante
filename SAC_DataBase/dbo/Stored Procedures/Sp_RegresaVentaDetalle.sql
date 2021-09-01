CREATE PROCEDURE [dbo].[Sp_RegresaVentaDetalle]
@idVenta int
WITH 
EXECUTE AS CALLER
AS
    SELECT 
           Venta_Detallada.VtaDet_IdProducto,  
           Productos.Productos_Nombre,
           Productos.Productos_Descripcion,
           Venta_Detallada.VtaDet_Cantidad,
           Venta_Detallada.VtaDet_Precio
           
      FROM Venta_Detallada
        
INNER JOIN Productos
        ON Venta_Detallada.VtaDet_IdProducto = Productos.IdProductos
        
     WHERE Venta_Detallada.VtaDet_IdVenta = @idVenta