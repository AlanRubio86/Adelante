CREATE PROCEDURE [dbo].[Sp_EliminarAbonoDetalles]
 @idAbono INT,
 @idAdeudo INT,  
 @idUsuario INT

WITH 
EXECUTE AS CALLER
AS 
 DECLARE @abono MONEY 
 SET @abono=(  
			  SELECT ISNULL(SUM(DetAbono_Abono),0)
				FROM DetalleAbonos  
	           
			   WHERE IdAdeudo = @idAdeudo 
			     AND idAbono = @idAbono
            ) * -1 
	 
	DELETE FROM DetalleAbonos WHERE idAbono = @idAbono  AND IdAdeudo =  @idAdeudo
	 
	EXEC Sp_ActualizarAdeudo @idAdeudo, @abono