CREATE PROCEDURE [dbo].[Sp_AltaPaqueteDetalles]
 @idpaquete INT,
 @idarea INT,
 @sesiones INT 

WITH 
EXECUTE AS CALLER
AS 
	BEGIN
		INSERT INTO
		  DetallePaquete
		  (
		     IdPaquete,
             IdArea,
             PaqDetalles_Sesiones 
		  ) 
		  VALUES
		  ( 
		     @idpaquete,
             @idarea,
             @sesiones 
		  )
		
	END