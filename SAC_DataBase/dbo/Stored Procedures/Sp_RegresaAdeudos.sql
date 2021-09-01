CREATE PROCEDURE [dbo].[Sp_RegresaAdeudos]
@idCliente INT 
WITH 
EXECUTE AS CALLER
AS 

     SELECT 
			Adeudos.IdAdeudo, 
			Adeudos.Adeudo_Saldo,
			--Adeudos.Adeudo_Saldo AS Comodin,
			Adeudo_Pagos,
			Adeudo_Tipo,
			CASE Adeudo_Tipo 
			   WHEN 1 THEN 'Pagado'
			   WHEN 2 THEN 'En pagos'
			   WHEN 3 THEN 'Por sesion'
            ELSE 'Retoque' END AS Tipo_Descripcion , 
			Adeudo_Monto,
			Adeudos.Adeudo_Fecha 
         
	   FROM Adeudos  
	   
      WHERE Adeudos.IdCliente = @idCliente