CREATE PROCEDURE [dbo].[Sp_AltaAreas]
@idArea int, @nombre varchar(10), @descripcion varchar(50), @costo money, @status bit
WITH 
EXECUTE AS CALLER
AS
DECLARE @aux INT 

SET @aux=(SELECT COUNT(*) FROM Productos WHERE IdProductos=@idArea)

IF(@aux>0)
 BEGIN
  UPDATE Productos SET   
		  
         Productos_Nombre = @nombre,
         Productos_Descripcion = @descripcion,
         Productos_Precio = @costo, 
         Productos_Status = @status  
      
  WHERE IdProductos = @idArea

 END
 
ELSE
	BEGIN
		INSERT INTO
		  Productos
		  (
		     Productos_Nombre,
             Productos_Descripcion,
             Productos_Precio, 
             Productos_Status,
             Productos_Tipo
		  ) 
		  VALUES
		  ( 
		     @nombre,
             @descripcion,
             @costo, 
             @status,
             2  
		  )
		
	END