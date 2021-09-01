CREATE PROCEDURE [dbo].[Sp_RegresaSesiones]
@idCliente INT,
@idArea INT

WITH 
EXECUTE AS CALLER
AS
     SELECT 
             Areasxcliente_sesiones 
          
       FROM dbo.AreasXCliente  
    
      WHERE idArea = @idArea
         AND idCliente = @idCliente