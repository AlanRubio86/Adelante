CREATE PROCEDURE [dbo].[Sp_AltaProductos]
@id int, @nombre varchar(50), @descripcion varchar(MAX),@marca VARCHAR(50), @existencia int, @Precio money, @minExistencia int, @status bit, @tipo int 
WITH 
EXECUTE AS CALLER
AS
DECLARE @aux INT 

SET @aux=(SELECT COUNT(*) FROM Productos WHERE IdProductos=@id)

IF(@aux>0)
 BEGIN
  UPDATE Productos SET  
         
    Productos_Nombre = @nombre, 
		Productos_Descripcion = @descripcion,
		Producto_Marca = @marca,
		Productos_Existencia = @existencia,
		Productos_Precio = @precio,
		Productos_StockMinimo = @minExistencia,  
		Productos_Status=@status,
		Productos_Tipo = @tipo
      
  WHERE IdProductos = @id

 END
 
ELSE
	BEGIN
		INSERT INTO
		  Productos
		  (
        Productos_Nombre,
		    Productos_Descripcion,
		    Producto_Marca,
		    Productos_Existencia,
		    Productos_Precio,
        Productos_StockMinimo,  
        Productos_Status,
        Productos_Tipo 
		  ) 
		  VALUES
		  ( 
        @nombre,
		    @descripcion,
		    @marca,
        @existencia,
        @precio,
        @minExistencia,  
        @status,
        @tipo
		  )
		
	END