CREATE PROCEDURE [dbo].[Sp_AltaConceptoCaja]
 @concepto VARCHAR(MAX),
 @importe MONEY,
 @fecha DATETIME,
 @idUsuario INT 

WITH 
EXECUTE AS CALLER
AS 
	BEGIN
		INSERT INTO
		  dbo.CajasAbiertas
		          ( Caja_Concepto ,
		            Caja_Cantidad ,
		            Caja_Fecha ,
		            IdUsuarioSesion  
		          )
		  VALUES  ( @concepto, -- Caja_CveCaja - int
		            @importe, -- IdUsuario - int
		            @fecha , -- Caja_Fondo - money
		            @idUsuario
		          )
		  
		
	END