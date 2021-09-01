CREATE PROCEDURE [dbo].[Sp_AltaDiferido]
@idCliente int, @adeudo money, @fecha datetime, @idVenta int
WITH 
EXECUTE AS CALLER
AS
BEGIN
		INSERT INTO
		  Adeudos
		  (
		     IdCliente, 
         Adeudo_Monto,
         Adeudo_Fecha,
         idVenta
		  ) 
		  VALUES
		  (  
        @idCliente, 
        @adeudo,
        @fecha,
        @idVenta
		  )
		
	END