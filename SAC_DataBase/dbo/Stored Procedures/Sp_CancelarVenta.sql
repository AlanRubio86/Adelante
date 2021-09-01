CREATE PROCEDURE [dbo].[Sp_CancelarVenta]
 @idVenta INT,
 @idUsuario INT, 
 @idCaja INT,
 @total MONEY,
 @tipo INT
  

WITH 
EXECUTE AS CALLER
AS 
 DECLARE @usuarioCaja INT 
 
 IF(@tipo = 1)
 BEGIN
	 SET @usuarioCaja =(  
				 
				  SELECT Ventas.Venta_idUsuario
					FROM Ventas  
		           
				   WHERE IdVenta = @idVenta  
				)
	  IF(@usuarioCaja = @idUsuario)
		  BEGIN
			  SET @total = @total * -1      
			  EXEC Sp_DepositarCaja @idCaja,0,@total
			  UPDATE Ventas SET Venta_Status = 1 WHERE Ventas.IdVenta =  @idVenta 
		  END 
  END
  
  IF(@tipo = 2) 
  BEGIN
      UPDATE Ventas SET Venta_Status = 1 WHERE Ventas.IdVenta =  @idVenta 
      DELETE FROM Adeudos WHERE Adeudos.IdVenta = @idVenta
  END 
  
  
  IF(@tipo = 3)
  BEGIN
    UPDATE Ventas SET Venta_Status = 1 WHERE Ventas.IdVenta =  @idVenta 
  END