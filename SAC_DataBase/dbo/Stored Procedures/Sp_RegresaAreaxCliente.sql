CREATE PROC [dbo].[Sp_RegresaAreaxCliente]
@idcliente INT
AS
SELECT dbo.AreasXCliente.Areasxcliente_sesiones,
		dbo.AreasXCliente.Areasxcliente_retoque,
		dbo.AreasXCliente.idArea,
		dbo.Productos.Productos_Nombre,
		dbo.Productos.Productos_Descripcion,
		dbo.AreasXCliente.Areasxcliente_pagados
FROM dbo.AreasXCliente
INNER JOIN dbo.Productos ON dbo.AreasXCliente.idArea=dbo.Productos.IdProductos
WHERE Areasxcliente.idCliente=@idcliente