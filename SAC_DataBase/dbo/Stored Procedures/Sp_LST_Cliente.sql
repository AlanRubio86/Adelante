CREATE PROCEDURE [dbo].[Sp_LST_Cliente]
@id INT
WITH 
EXECUTE AS CALLER
AS
     SELECT 
            Clientes.Clientes_Nombre,
            Clientes.Clientes_Apellidos, 
            ISNULL(SUM(Adeudos.Adeudo_Monto),0) Debe,
            Clientes.IdCliente,
            Clientes.Clientes_Correo
          
       FROM Clientes 
    
 FULL JOIN Adeudos
         ON Adeudos.IdCliente = Clientes.IdCliente 
    
      WHERE Clientes.IdCliente = @id 
        AND Clientes_Status = 0
        
        GROUP BY Clientes.IdCliente,
                 Clientes.Clientes_Nombre,
                 Clientes.Clientes_Apellidos,
                 Clientes.Clientes_Correo