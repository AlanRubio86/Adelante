CREATE PROCEDURE [dbo].[Sp_ReporteAbonos]
@cliente INT, 
@desde DATETIME, 
@hasta DATETIME
WITH 
EXECUTE AS CALLER
AS
SELECT 
         Abonos.idAbono,
         Abonos.idCliente,
         Clientes_Nombre + ' ' +Clientes_Apellidos AS Cliente_Nombre,
         Abonos.Abono_Total,
         Abonos.Abono_Fecha,
         Adeudos.IdAdeudo, 
		 DetalleAbonos.DetAbono_Abono,
		 Adeudos.Adeudo_Monto, 
		 DetalleAbonos.DetAbono_Saldo AS Saldo,
		 Ventas.Venta_Importe, 
		 Adeudos.IdVenta, 
		 @desde AS Fecha_Desde,
         @hasta AS Fecha_Hasta
         
    FROM Abonos 
    
  INNER JOIN Clientes
          ON Clientes.IdCliente = Abonos.idCliente  
  
  INNER JOIN DetalleAbonos
          ON DetalleAbonos.idAbono = Abonos.idAbono 
  
  INNER JOIN Adeudos
          ON Adeudos.IdAdeudo = DetalleAbonos.IdAdeudo
          
  INNER JOIN Ventas
          ON Ventas.IdVenta = Adeudos.IdVenta 
           
	   WHERE Abonos.idCliente = 
			 CASE @cliente WHEN 0 THEN Abonos.idCliente
			 ELSE @cliente END
		    
		 AND Abonos.Abono_Fecha BETWEEN @desde AND @hasta

    ORDER BY Abono_Fecha DESC