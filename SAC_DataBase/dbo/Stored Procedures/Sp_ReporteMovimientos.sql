CREATE PROCEDURE [dbo].[Sp_ReporteMovimientos]
@movimiento INT, 
@usuario INT, 
@desde DATETIME, 
@hasta DATETIME

WITH 
EXECUTE AS CALLER
AS
SELECT 
        Movimientos.*,
        Usuarios.Usuarios_Nombre +' '+Usuarios.Usuarios_Apellidos AS Usuario_Nombre,
        @desde AS Fecha_Desde,
        @hasta AS Fecha_Hasta
        
   FROM Movimientos 
  INNER JOIN Usuarios
          ON Usuarios.IdUsuario = Movimientos.IdUsuario 
    
           
  WHERE Movimientos.Movimientos_Tipo = 
        CASE @movimiento WHEN 0 THEN Movimientos.Movimientos_Tipo
        ELSE @movimiento END
        
    AND Movimientos.IdUsuario = 
        CASE @usuario WHEN 0 THEN Movimientos.IdUsuario
        ELSE @usuario END
        
    AND Movimientos.Movimientos_Fecha BETWEEN @desde AND @hasta
    
    ORDER BY Movimientos_Fecha DESC