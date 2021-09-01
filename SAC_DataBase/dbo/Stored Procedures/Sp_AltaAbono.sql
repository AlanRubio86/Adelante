CREATE PROCEDURE [dbo].[Sp_AltaAbono] 
 @id INT,
 @idCliente INT,  
 @importe MONEY,
 @fecha DATETIME,
 @motivo VARCHAR(max),
 @modopago VARCHAR(max),
 @idUsuario INT

WITH 
EXECUTE AS CALLER
AS
DECLARE @aux INT 

SET @aux=(SELECT COUNT(*) FROM Abonos WHERE idAbono=@id)

IF(@aux>0)
 BEGIN
  UPDATE Abonos SET   
		  
         idCliente = @idCliente,
         Abono_Total = @importe, 
         Abono_Fecha = @fecha,  
         idUsuario = @idUsuario,
         Abono_Motivo = @motivo,
         Abono_ModoPago = @modopago 
      
  WHERE idAbono = @id

 END
 
ELSE
	BEGIN
		INSERT INTO
		  Abonos
		  (  
			idCliente,
			Abono_Total, 
			Abono_Fecha,
			idUsuario,
			Abono_ModoPago,
			Abono_Motivo 
		  ) 
		  VALUES
		  (  
             @idCliente,
             @importe, 
             @fecha,
             @idUsuario,
             @modopago,
             @motivo 
		  )
		
	END