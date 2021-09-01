CREATE PROCEDURE [dbo].[Sp_AltaVentaDetalles]
 @id INT,
 @idproducto INT,
 @cantidad INT, 
 @precio MONEY

WITH 
EXECUTE AS CALLER
AS 
	BEGIN
		INSERT INTO
		  Venta_Detallada
		  (
		     VtaDet_IdVenta,
             VtaDet_IdProducto,
             VtaDet_Cantidad,
             VtaDet_Precio
		  ) 
		  VALUES
		  ( 
		     @id,
             @idproducto,
             @cantidad,
             @precio 
		  )
		
	END