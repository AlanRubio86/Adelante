CREATE PROCEDURE [dbo].[Sp_RegresaPaquetes]
@dato varchar(50), @status tinyint
WITH 
EXECUTE AS CALLER
AS
SELECT 
         Paquete.*,
         CASE Paquete_Status WHEN 1 THEN 'Deshabilitado'
         ELSE 'Habilitado' END AS Estado

    FROM Paquete 
   WHERE Paquete_Nombre LIKE @dato  
     AND Paquete_Status =
         CASE @status WHEN 2 THEN Paquete_Status
         ELSE @status END