CREATE PROCEDURE [dbo].[Sp_AltaAdeudo]
@idCliente int, @adeudo money, @fecha datetime, @tipo INT,@pagos INT, @motivo VARCHAR(max)
WITH 
EXECUTE AS CALLER
AS
BEGIN
		INSERT INTO
		  Adeudos
		  (
		     IdCliente, 
         Adeudo_Monto,
         Adeudo_Saldo,
         Adeudo_Fecha,
         Adeudo_Tipo,
         Adeudo_Pagos,
         Adeudo_Motivo         
		  ) 
		  VALUES
		  (  
        @idCliente, 
        @adeudo,
        @adeudo,
        @fecha,
        @tipo,
        @pagos,
        @motivo
		  )
		
	END