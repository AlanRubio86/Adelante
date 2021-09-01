create PROCEDURE [dbo].[Sp_ReporteArea]
 @status tinyint
WITH 
EXECUTE AS CALLER
AS
SELECT 
         Productos.IdProductos,
         Productos.Productos_Nombre,
         Productos.Productos_Descripcion,
         Productos.Productos_Precio,
         Productos.Productos_Status,
         CASE Productos_Status WHEN 1 THEN 'Deshabilitado'
         ELSE 'Habilitado' END AS Estado

    FROM Productos 
   WHERE Productos_Tipo = 2
     AND Productos_Status =
         CASE @status WHEN 2 THEN Productos_Status
         ELSE @status END