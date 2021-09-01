CREATE PROCEDURE [dbo].[Sp_EliminarPaqueteDetalles]
 @idPaquete INT 

WITH 
EXECUTE AS CALLER
AS  
	 
	DELETE FROM DetallePaquete WHERE IdPaquete = @idPaquete