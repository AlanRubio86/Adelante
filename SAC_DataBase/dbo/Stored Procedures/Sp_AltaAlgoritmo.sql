CREATE proc [dbo].[Sp_AltaAlgoritmo] 
 
@Fecha DATETIME
 
AS  
 
 BEGIN
   UPDATE Algoritmo 
		SET 
		 Algoritmo_Fecha =  @Fecha
   WHERE  idAlgoritmo = 1 
  END