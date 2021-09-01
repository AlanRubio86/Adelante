CREATE PROC [dbo].[Sp_RegresaAreasCliente]
@dato VARCHAR(50),
@idCliente INT
AS
SELECT  dbo.AreasXCliente.Areasxcliente_sesiones, 
		dbo.AreasXCliente.idArea,
		dbo.Productos.Productos_Nombre,
		dbo.Productos.Productos_Descripcion,
		Productos_Precio 
		
FROM dbo.AreasXCliente

INNER JOIN dbo.Productos ON dbo.AreasXCliente.idArea=dbo.Productos.IdProductos

WHERE Productos.Productos_Nombre LIKE @dato
  AND AreasXCliente.idCliente = @idCliente