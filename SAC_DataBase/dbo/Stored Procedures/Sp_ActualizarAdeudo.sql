CREATE PROCEDURE [dbo].[Sp_ActualizarAdeudo]
@idAdeudo int, @abono MONEY
WITH 
EXECUTE AS CALLER

AS
 DECLARE @saldo MONEY
  
  UPDATE Adeudos SET 
          
          Adeudo_Saldo = Adeudo_Saldo - @abono 
      
  WHERE IdAdeudo = @idAdeudo  
  
 SET @saldo=(  
			  SELECT ISNULL(SUM(Adeudo_Saldo),0)
				FROM Adeudos  
	           
			   WHERE IdAdeudo = @idAdeudo
            ) 
            
  IF(@saldo <= 0)
  BEGIN
     UPDATE Adeudos SET 
          
          Adeudo_Pagado = 1 
      
  WHERE IdAdeudo = @idAdeudo 
  END
  
  ELSE
  BEGIN
      UPDATE Adeudos SET 
          
          Adeudo_Pagado = 0 
      
  WHERE IdAdeudo = @idAdeudo 
  END