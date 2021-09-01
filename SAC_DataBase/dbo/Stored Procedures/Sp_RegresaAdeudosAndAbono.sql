CREATE PROCEDURE [dbo].[Sp_RegresaAdeudosAndAbono]
@idCliente INT 
WITH 
EXECUTE AS CALLER
AS 

     SELECT    
			ISNULL(SUM(Adeudos.Adeudo_Saldo),0) AS Adeudo_Saldo,
			 (
			    SELECT TOP 1 Abono_Total  
			      FROM Abonos 
			     WHERE Abonos.idCliente = @idCliente
			  ORDER BY Abonos.Abono_Fecha DESC 
			  ) AS Abono_Total
			   
	   FROM Adeudos  
	   
      WHERE Adeudos.IdCliente = @idCliente
        AND Adeudo_Pagado != 1