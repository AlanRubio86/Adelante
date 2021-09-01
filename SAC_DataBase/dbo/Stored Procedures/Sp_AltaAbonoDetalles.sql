CREATE PROCEDURE [dbo].[Sp_AltaAbonoDetalles]
 @idAbono INT,
 @idAdeudo INT,
 @abono MONEY,
 @saldo MONEY, 
 @idUsuario INT

WITH 
EXECUTE AS CALLER
AS 
	BEGIN
		INSERT INTO
		  DetalleAbonos
		  (
		     idAbono,
		     IdAdeudo,
		     DetAbono_Abono,
             DetAbono_Saldo 
		  ) 
		  VALUES
		  ( 
		     @idAbono,
		     @idAdeudo,
             @abono,
             @saldo 
		  )  
	END
	
	EXEC Sp_ActualizarAdeudo @idAdeudo, @abono