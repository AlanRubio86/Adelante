CREATE PROCEDURE [dbo].[Sp_RegresaAbonos]
@dato varchar(50) 
WITH 
EXECUTE AS CALLER
AS
SELECT 
         idAbono,
         Abonos.idCliente,
         Clientes_Nombre + ' ' +Clientes_Apellidos AS Nombre,
         Abono_Total,
         Abono_Fecha,
         Abono_ModoPago,
         Abono_Motivo
         
    FROM Abonos 
    
  INNER JOIN Clientes
          ON Clientes.IdCliente = Abonos.idCliente  
   
  WHERE Clientes.Clientes_Nombre LIKE @dato 
  
  
  UNION
  
  SELECT 
         idAbono,
         Abonos.idCliente,
         Clientes_Nombre + ' ' +Clientes_Apellidos AS Nombre,
         Abono_Total,
         Abono_Fecha,
         Abono_ModoPago,
         Abono_Motivo
         
    FROM Abonos 
    
  INNER JOIN Clientes
          ON Clientes.IdCliente = Abonos.idCliente  
   
  WHERE Clientes.Clientes_Apellidos LIKE @dato 
  
  ORDER BY Abono_Fecha DESC