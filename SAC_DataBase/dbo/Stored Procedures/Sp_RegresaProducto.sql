CREATE PROCEDURE [dbo].[Sp_RegresaProducto]
@dato VARCHAR(50), @marca VARCHAR(50), @status TINYINT
WITH 
EXECUTE AS CALLER
AS
SELECT 
        Productos.*,
        CASE Productos.Productos_Status 
             WHEN 1 THEN 'Deshabilitado'
        ELSE 'Habilitado' END AS Estado
        
   FROM Productos 
  WHERE Productos_Descripcion LIKE @dato AND Producto_Marca LIKE @marca
    AND Productos_Tipo = 1
    AND Productos_Status = 
        CASE @status WHEN 2 THEN Productos_Status
        ELSE @status END