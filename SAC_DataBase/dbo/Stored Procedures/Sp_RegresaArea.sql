CREATE PROCEDURE [dbo].[Sp_RegresaArea]
@dato varchar(50), @status tinyint
WITH 
EXECUTE AS CALLER
AS
SELECT 
         IdProductos,
         Productos_Nombre,
         Productos_Descripcion,
         Productos_Precio,
         Productos_Status, 
         CASE Productos_Status WHEN 1 THEN 'Deshabilitado'
         ELSE 'Habilitado' END AS Estado,
         Productos_Tipo

    FROM dbo.Productos 
   WHERE Productos_Nombre LIKE @dato  
    AND Productos_Tipo = 2
     AND Productos_Status =
         CASE @status WHEN 2 THEN Productos_Status
         ELSE @status END