CREATE PROCEDURE [dbo].[Sp_RegresaVenta]
@dato varchar(50),
@idUsuario INT
WITH 
EXECUTE AS CALLER
AS
SELECT 
               Ventas.IdVenta,
               Ventas.IdCliente,
               Clientes.Clientes_Nombre,
               Clientes.Clientes_Apellidos,
               Ventas.Venta_Fecha,
               Ventas.Venta_Importe,
               Ventas.Venta_Tipo,
               CASE Ventas.Venta_Tipo 
                    WHEN 2 THEN 'Diferido'
                    WHEN 3 THEN 'Cortesia'
               ELSE 'Contado' END AS Tipo,
               ISNULL(Ventas.Venta_Status,0) AS Venta_Status,
               CASE Ventas.Venta_Status 
                    WHEN 0 THEN 'Activa' 
               ELSE 'Cancelada' END AS Estatus
               
          
           FROM Ventas
          
     INNER JOIN Clientes 
             ON Ventas.IdCliente = Clientes.IdCliente
             
          WHERE Clientes.Clientes_Nombre LIKE @dato
            AND Ventas.Venta_idUsuario = @idUsuario
         -- ORDER BY Ventas.Venta_Fecha ASC
          
 UNION 
        SELECT 
               Ventas.IdVenta,
               Ventas.IdCliente,
               Clientes.Clientes_Nombre,
               Clientes.Clientes_Apellidos,
               Ventas.Venta_Fecha,
               Ventas.Venta_Importe,
               Ventas.Venta_Tipo,
               CASE Ventas.Venta_Tipo 
                    WHEN 2 THEN 'Diferido'
                    WHEN 3 THEN 'Cortesia'
               ELSE 'Contado' END AS Tipo,
               ISNULL(Ventas.Venta_Status,0) AS Venta_Status,
               CASE Ventas.Venta_Status 
                    WHEN 0 THEN 'Activa' 
               ELSE 'Cancelada' END AS Estatus
          
           FROM Ventas
          
     INNER JOIN Clientes 
             ON Ventas.IdCliente = Clientes.IdCliente
             
          WHERE Clientes.Clientes_Apellidos LIKE @dato
            AND Ventas.Venta_idUsuario = @idUsuario
      
    ORDER BY Venta_Fecha DESC