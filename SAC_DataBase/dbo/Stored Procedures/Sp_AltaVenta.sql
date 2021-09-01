CREATE PROCEDURE [dbo].[Sp_AltaVenta]
@id int, @idUsuario int, @fecha datetime, @importe money, @idCliente int, @tipoVenta int
WITH 
EXECUTE AS CALLER
AS
INSERT INTO 
   Ventas
   (
     --IdVenta,
     Venta_idUsuario,
     Venta_Fecha,
     Venta_Importe,
     IdCliente,
     Venta_Tipo
  ) VALUES (
     --@id,
     @idUsuario,
     @fecha,
     @importe,
     @idCliente,  
     @tipoVenta
  )