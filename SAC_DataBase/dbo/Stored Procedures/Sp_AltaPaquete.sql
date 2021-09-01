CREATE PROCEDURE [dbo].[Sp_AltaPaquete]
@idPaquete int,
@nombre varchar(10), 
@precio money,
@status bit
WITH 
EXECUTE AS CALLER
AS
DECLARE @aux INT 

SET @aux=(SELECT COUNT(*) FROM Paquete WHERE IdPaquete=@idpaquete)

IF(@aux>0)
 BEGIN
  UPDATE Paquete SET   
		  
         Paquete_Nombre = @nombre, 
         Paquete_Precio = @precio, 
         Paquete_Status = @status  
      
  WHERE IdPaquete = @idpaquete

 END
 
ELSE
	BEGIN
		INSERT INTO
		  Paquete
		  (
		     Paquete_Nombre, 
             Paquete_Precio, 
             Paquete_Status 
		  ) 
		  VALUES
		  ( 
		     @nombre, 
             @precio, 
             @status 
		  )
		
	END