CREATE PROCEDURE [dbo].[Sp_ReporteAdeudos] 
@cliente INT, 
@desde DATETIME, 
@hasta DATETIME
WITH 
EXECUTE AS CALLER
AS
     SELECT 
			Adeudos.IdAdeudo,
			Adeudos.IdCliente,
			Clientes.Clientes_Nombre+' '+Clientes.Clientes_Apellidos AS Nombre_Cliente,
			Adeudos.Adeudo_Monto, 
			Ventas.Venta_Importe,
			Adeudos.Adeudo_Fecha,
            Adeudos.IdVenta,
            Adeudos.Adeudo_Pagado,
            @desde AS Fecha_Desde,
			@hasta AS Fecha_Hasta 
         
	   FROM Adeudos 
    
 INNER JOIN Ventas
         ON Ventas.IdVenta = Adeudos.IdVenta 
 
 INNER JOIN Clientes
         ON Clientes.IdCliente = Ventas.IdCliente
   
      WHERE Adeudos.IdCliente = 
            CASE @cliente WHEN 0 THEN Adeudos.IdCliente
            ELSE @cliente END
            
        AND Adeudos.Adeudo_Fecha BETWEEN @desde AND @hasta
        
        AND Adeudo_Pagado = 0
    
   ORDER BY Adeudo_Fecha DESC