CREATE PROCEDURE [dbo].[Sp_ReporteReferidos]
 
@desde DATETIME, 
@hasta DATETIME

WITH 
EXECUTE AS CALLER
AS
SELECT 
        Clientes.*, 
        @desde AS Fecha_Desde,
        @hasta AS Fecha_Hasta
        
   FROM Clientes  
   
        
    WHERE Clientes.Clientes_Fecha BETWEEN @desde AND @hasta
    
    ORDER BY Clientes_Fecha DESC